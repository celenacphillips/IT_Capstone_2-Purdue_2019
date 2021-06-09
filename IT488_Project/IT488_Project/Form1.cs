using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT488_Project
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;

        public Form1()
        {
            InitializeComponent();

            string server = "192.168.1.130";
            string database = "SimpleWayToEatHealthy";
            string username = "HealthyEater";
            string pass = "Healthy";

            string connectionString = @"Data Source= " + server + "; Initial Catalog= " + database + "; User ID= " + username + "; Password= " + pass;

            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Logging In.");
                connection.Close();
                this.Close();
            }
        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            recipeBox.Items.Clear();
            string categoryName = categoryBox.SelectedItem.ToString();

            selectACategory(categoryName);
        }

        private void recipeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string recipeName = recipeBox.SelectedItem.ToString();

            selectARecipe(recipeName);
        }

        private void selectACategory (string category)
        {
            string sqlString = "SELECT RecipeName FROM RecipeTable INNER JOIN CategoriesTable ON RecipeTable.RecipeID = CategoriesTable.RecipeID WHERE "+ category +" = 1;";
            command = new SqlCommand(sqlString, connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (!recipeBox.Items.Contains(reader.GetValue(0)))
                {
                    recipeBox.Items.Add(reader.GetValue(0));
                }
            }
            recipeBox.Enabled = true;

            reader.Close();
            command.Dispose();
        }

        private void selectARecipe(string recipe)
        {
            string sqlString = "SELECT * FROM RecipeTable WHERE RecipeName = '" + recipe + "';";
            command = new SqlCommand(sqlString, connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                recipeLabel.Text = reader.GetValue(1).ToString();


                string ingredients = reader.GetValue(2).ToString();
                string instructions = reader.GetValue(3).ToString();
                ingredients = ingredients.Replace('_', '\n');
                instructions = instructions.Replace('_', '\n');
                ingredientsBox.Text = "Ingredients:\n" + ingredients;
                instructionsBox.Text = "Instructions:\n" + instructions;


                calOutput.Text = reader.GetValue(4).ToString();
                carbOutput.Text = reader.GetValue(5).ToString();
                fatOutput.Text = reader.GetValue(6).ToString();
                proOutput.Text = reader.GetValue(7).ToString();
            }

            reader.Close();
            command.Dispose();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (currentBox.Text.Equals(null) || goalBox.Text.Equals(null) || timeBox.Text.Equals(null))
                MessageBox.Show("Error! Please fiil out all fields!");
            else
            {
                categoryBox.Enabled = false;

                string current = currentBox.Text, goal = goalBox.Text, timeframe = timeBox.Text;
                int currentWeight = 0, goalWeight = 0, time = 0;
                int totalChange = 0, totalCalories = 2000;
                double change = 0, calorieChange = 0, mealCalories = 0;



                if (System.Text.RegularExpressions.Regex.IsMatch(current, "^[0-9]*$"))
                {
                    currentWeight = Convert.ToInt32(current);
                    displayBox.Text = "Your current weight is " + currentWeight + " lbs.";
                }
                else
                    MessageBox.Show("Error! Enter valid number for your current weight!");


                if (System.Text.RegularExpressions.Regex.IsMatch(goal, "^[0-9]*$"))
                {
                    goalWeight = Convert.ToInt32(goal);
                    displayBox.Text += "\nYour goal weight is " + goalWeight + " lbs.";
                }
                else
                    MessageBox.Show("Error! Enter valid number for your goal weight!");

                totalChange = goalWeight - currentWeight;

                displayBox.Text += "\nYour net change is " + totalChange + " lbs.";

                if (System.Text.RegularExpressions.Regex.IsMatch(timeframe, "^[0-9]*$"))
                {
                    time = Convert.ToInt32(timeframe);
                    change = (double) totalChange / (double) time;

                    displayBox.Text += "Your timeframe is " + time + " weeks.";
                    displayBox.Text += "\nYou will need to change your weight by " + change + " lbs per week.";

                }
                else
                    MessageBox.Show("Error! Enter valid number for your timeframe!");

                calorieChange = calorieChangeCalculation(totalCalories, change);
                mealCalories = calorieChange / 3;

                displayBox.Text += "\nYou will need to consume " + calorieChange + " calories a day (assuming a standard 2,000 calorie diet).";
                displayBox.Text += "\n\nAlso assuming the standard three meals a day, your general calorie intake for each meal is " + (int) mealCalories + ". You can now view the recipe list.";

                string sqlString = "SELECT RecipeName FROM RecipeTable INNER JOIN CategoriesTable ON RecipeTable.RecipeID = CategoriesTable.RecipeID WHERE Calories <= " + mealCalories + ";";

                command = new SqlCommand(sqlString, connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (!recipeBox.Items.Contains(reader.GetValue(0)))
                    {
                        recipeBox.Items.Add(reader.GetValue(0));
                    }
                }
                recipeBox.Enabled = true;

                reader.Close();
                command.Dispose();
            }
        }

        private int calorieChangeCalculation (int total, double change)
        {
            int weeklyCalories = (int) change * 3000;
            int dailyCalories = weeklyCalories / 7;

            return total + dailyCalories;
        }
    }
}
