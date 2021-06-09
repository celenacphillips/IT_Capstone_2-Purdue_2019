namespace IT488_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.categorySelect = new System.Windows.Forms.Label();
            this.recipeSelect = new System.Windows.Forms.Label();
            this.recipeLabel = new System.Windows.Forms.Label();
            this.ingredientsBox = new System.Windows.Forms.RichTextBox();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.carbsLabel = new System.Windows.Forms.Label();
            this.fatLabel = new System.Windows.Forms.Label();
            this.proteinLabel = new System.Windows.Forms.Label();
            this.calOutput = new System.Windows.Forms.Label();
            this.carbOutput = new System.Windows.Forms.Label();
            this.fatOutput = new System.Windows.Forms.Label();
            this.proOutput = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.recipeBox = new System.Windows.Forms.ComboBox();
            this.instructionsBox = new System.Windows.Forms.RichTextBox();
            this.currentLabel = new System.Windows.Forms.Label();
            this.goalLabel = new System.Windows.Forms.Label();
            this.ORLabel = new System.Windows.Forms.Label();
            this.currentBox = new System.Windows.Forms.TextBox();
            this.goalBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.RichTextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // categorySelect
            // 
            this.categorySelect.AutoSize = true;
            this.categorySelect.Location = new System.Drawing.Point(47, 13);
            this.categorySelect.Name = "categorySelect";
            this.categorySelect.Size = new System.Drawing.Size(136, 13);
            this.categorySelect.TabIndex = 2;
            this.categorySelect.Text = "First, Select a Dietary Need";
            // 
            // recipeSelect
            // 
            this.recipeSelect.AutoSize = true;
            this.recipeSelect.Location = new System.Drawing.Point(235, 13);
            this.recipeSelect.Name = "recipeSelect";
            this.recipeSelect.Size = new System.Drawing.Size(114, 13);
            this.recipeSelect.TabIndex = 3;
            this.recipeSelect.Text = "Then, Select a Recipe";
            // 
            // recipeLabel
            // 
            this.recipeLabel.AutoSize = true;
            this.recipeLabel.Location = new System.Drawing.Point(47, 97);
            this.recipeLabel.Name = "recipeLabel";
            this.recipeLabel.Size = new System.Drawing.Size(0, 13);
            this.recipeLabel.TabIndex = 5;
            // 
            // ingredientsBox
            // 
            this.ingredientsBox.Enabled = false;
            this.ingredientsBox.Location = new System.Drawing.Point(47, 153);
            this.ingredientsBox.Name = "ingredientsBox";
            this.ingredientsBox.Size = new System.Drawing.Size(190, 368);
            this.ingredientsBox.TabIndex = 6;
            this.ingredientsBox.Text = "";
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Location = new System.Drawing.Point(269, 121);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(44, 13);
            this.caloriesLabel.TabIndex = 7;
            this.caloriesLabel.Text = "Calories";
            // 
            // carbsLabel
            // 
            this.carbsLabel.AutoSize = true;
            this.carbsLabel.Location = new System.Drawing.Point(387, 121);
            this.carbsLabel.Name = "carbsLabel";
            this.carbsLabel.Size = new System.Drawing.Size(34, 13);
            this.carbsLabel.TabIndex = 8;
            this.carbsLabel.Text = "Carbs";
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Location = new System.Drawing.Point(488, 121);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(22, 13);
            this.fatLabel.TabIndex = 9;
            this.fatLabel.Text = "Fat";
            // 
            // proteinLabel
            // 
            this.proteinLabel.AutoSize = true;
            this.proteinLabel.Location = new System.Drawing.Point(594, 121);
            this.proteinLabel.Name = "proteinLabel";
            this.proteinLabel.Size = new System.Drawing.Size(40, 13);
            this.proteinLabel.TabIndex = 10;
            this.proteinLabel.Text = "Protein";
            // 
            // calOutput
            // 
            this.calOutput.AutoSize = true;
            this.calOutput.Location = new System.Drawing.Point(320, 121);
            this.calOutput.Name = "calOutput";
            this.calOutput.Size = new System.Drawing.Size(0, 13);
            this.calOutput.TabIndex = 11;
            // 
            // carbOutput
            // 
            this.carbOutput.AutoSize = true;
            this.carbOutput.Location = new System.Drawing.Point(428, 121);
            this.carbOutput.Name = "carbOutput";
            this.carbOutput.Size = new System.Drawing.Size(0, 13);
            this.carbOutput.TabIndex = 12;
            // 
            // fatOutput
            // 
            this.fatOutput.AutoSize = true;
            this.fatOutput.Location = new System.Drawing.Point(526, 121);
            this.fatOutput.Name = "fatOutput";
            this.fatOutput.Size = new System.Drawing.Size(0, 13);
            this.fatOutput.TabIndex = 13;
            // 
            // proOutput
            // 
            this.proOutput.AutoSize = true;
            this.proOutput.Location = new System.Drawing.Point(650, 120);
            this.proOutput.Name = "proOutput";
            this.proOutput.Size = new System.Drawing.Size(0, 13);
            this.proOutput.TabIndex = 14;
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Keto",
            "Paleo",
            "Vegetarian",
            "SemiVegetarian",
            "Vegan",
            "OvoLactoVegetarian",
            "OvoVegetarian",
            "LactoVegetarian",
            "PescoVegetarian",
            "LactoseIntolerant",
            "GlutenFree",
            "SugarFree",
            "LowSugar"});
            this.categoryBox.Location = new System.Drawing.Point(47, 41);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(144, 21);
            this.categoryBox.TabIndex = 15;
            this.categoryBox.SelectedIndexChanged += new System.EventHandler(this.categoryBox_SelectedIndexChanged);
            // 
            // recipeBox
            // 
            this.recipeBox.Enabled = false;
            this.recipeBox.FormattingEnabled = true;
            this.recipeBox.Location = new System.Drawing.Point(238, 41);
            this.recipeBox.Name = "recipeBox";
            this.recipeBox.Size = new System.Drawing.Size(377, 21);
            this.recipeBox.TabIndex = 16;
            this.recipeBox.SelectedIndexChanged += new System.EventHandler(this.recipeBox_SelectedIndexChanged);
            // 
            // instructionsBox
            // 
            this.instructionsBox.Enabled = false;
            this.instructionsBox.Location = new System.Drawing.Point(264, 153);
            this.instructionsBox.Name = "instructionsBox";
            this.instructionsBox.Size = new System.Drawing.Size(480, 368);
            this.instructionsBox.TabIndex = 17;
            this.instructionsBox.Text = "";
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.Location = new System.Drawing.Point(802, 31);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(106, 13);
            this.currentLabel.TabIndex = 18;
            this.currentLabel.Text = "Enter Current Weight";
            // 
            // goalLabel
            // 
            this.goalLabel.AutoSize = true;
            this.goalLabel.Location = new System.Drawing.Point(802, 84);
            this.goalLabel.Name = "goalLabel";
            this.goalLabel.Size = new System.Drawing.Size(94, 13);
            this.goalLabel.TabIndex = 19;
            this.goalLabel.Text = "Enter Goal Weight";
            // 
            // ORLabel
            // 
            this.ORLabel.AutoSize = true;
            this.ORLabel.Location = new System.Drawing.Point(697, 31);
            this.ORLabel.Name = "ORLabel";
            this.ORLabel.Size = new System.Drawing.Size(45, 13);
            this.ORLabel.TabIndex = 20;
            this.ORLabel.Text = "OR First";
            // 
            // currentBox
            // 
            this.currentBox.Location = new System.Drawing.Point(805, 48);
            this.currentBox.Name = "currentBox";
            this.currentBox.Size = new System.Drawing.Size(100, 20);
            this.currentBox.TabIndex = 23;
            // 
            // goalBox
            // 
            this.goalBox.Location = new System.Drawing.Point(805, 101);
            this.goalBox.Name = "goalBox";
            this.goalBox.Size = new System.Drawing.Size(100, 20);
            this.goalBox.TabIndex = 24;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(805, 196);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 25;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // displayBox
            // 
            this.displayBox.Enabled = false;
            this.displayBox.Location = new System.Drawing.Point(805, 240);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(307, 281);
            this.displayBox.TabIndex = 26;
            this.displayBox.Text = "";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(802, 141);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(152, 13);
            this.timeLabel.TabIndex = 27;
            this.timeLabel.Text = "Enter Your Timeframe (Weeks)";
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(805, 157);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(100, 20);
            this.timeBox.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 564);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.goalBox);
            this.Controls.Add(this.currentBox);
            this.Controls.Add(this.ORLabel);
            this.Controls.Add(this.goalLabel);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.instructionsBox);
            this.Controls.Add(this.recipeBox);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.proOutput);
            this.Controls.Add(this.fatOutput);
            this.Controls.Add(this.carbOutput);
            this.Controls.Add(this.calOutput);
            this.Controls.Add(this.proteinLabel);
            this.Controls.Add(this.fatLabel);
            this.Controls.Add(this.carbsLabel);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.ingredientsBox);
            this.Controls.Add(this.recipeLabel);
            this.Controls.Add(this.recipeSelect);
            this.Controls.Add(this.categorySelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label categorySelect;
        private System.Windows.Forms.Label recipeSelect;
        private System.Windows.Forms.Label recipeLabel;
        private System.Windows.Forms.RichTextBox ingredientsBox;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.Label carbsLabel;
        private System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.Label proteinLabel;
        private System.Windows.Forms.Label calOutput;
        private System.Windows.Forms.Label carbOutput;
        private System.Windows.Forms.Label fatOutput;
        private System.Windows.Forms.Label proOutput;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.ComboBox recipeBox;
        private System.Windows.Forms.RichTextBox instructionsBox;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label goalLabel;
        private System.Windows.Forms.Label ORLabel;
        private System.Windows.Forms.TextBox currentBox;
        private System.Windows.Forms.TextBox goalBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.RichTextBox displayBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox timeBox;
    }
}

