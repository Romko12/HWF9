namespace HWF9
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
            this.namingLabel = new System.Windows.Forms.Label();
            this.DogButton = new System.Windows.Forms.Button();
            this.CatButton = new System.Windows.Forms.Button();
            this.PetNameLabel = new System.Windows.Forms.Label();
            this.FoodProgressBar = new System.Windows.Forms.ProgressBar();
            this.HappinessProgressBar = new System.Windows.Forms.ProgressBar();
            this.EnergyProgressBar = new System.Windows.Forms.ProgressBar();
            this.FoodLabel = new System.Windows.Forms.Label();
            this.HappinessLabel = new System.Windows.Forms.Label();
            this.EnergyLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.animalChooseLabel = new System.Windows.Forms.Label();
            this.FeedButton = new System.Windows.Forms.Button();
            this.SleepButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // namingLabel
            // 
            this.namingLabel.Location = new System.Drawing.Point(26, 34);
            this.namingLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.namingLabel.Name = "namingLabel";
            this.namingLabel.Size = new System.Drawing.Size(228, 89);
            this.namingLabel.TabIndex = 0;
            this.namingLabel.Text = "Name ur pet 3-10 symbols";
            this.namingLabel.UseCompatibleTextRendering = true;
            // 
            // DogButton
            // 
            this.DogButton.Location = new System.Drawing.Point(35, 238);
            this.DogButton.Name = "DogButton";
            this.DogButton.Size = new System.Drawing.Size(94, 56);
            this.DogButton.TabIndex = 2;
            this.DogButton.Text = "Dog";
            this.DogButton.UseVisualStyleBackColor = true;
            this.DogButton.Click += new System.EventHandler(this.DogButton_Click);
            // 
            // CatButton
            // 
            this.CatButton.Location = new System.Drawing.Point(149, 238);
            this.CatButton.Name = "CatButton";
            this.CatButton.Size = new System.Drawing.Size(95, 56);
            this.CatButton.TabIndex = 3;
            this.CatButton.Text = "Cat";
            this.CatButton.UseVisualStyleBackColor = true;
            this.CatButton.Click += new System.EventHandler(this.CatButton_Click);
            // 
            // PetNameLabel
            // 
            this.PetNameLabel.AutoSize = true;
            this.PetNameLabel.BackColor = System.Drawing.Color.White;
            this.PetNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PetNameLabel.Location = new System.Drawing.Point(18, 36);
            this.PetNameLabel.Name = "PetNameLabel";
            this.PetNameLabel.Size = new System.Drawing.Size(239, 45);
            this.PetNameLabel.TabIndex = 5;
            this.PetNameLabel.Text = "PetNameLabel";
            // 
            // FoodProgressBar
            // 
            this.FoodProgressBar.Location = new System.Drawing.Point(297, 36);
            this.FoodProgressBar.Name = "FoodProgressBar";
            this.FoodProgressBar.Size = new System.Drawing.Size(264, 35);
            this.FoodProgressBar.Step = 1;
            this.FoodProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.FoodProgressBar.TabIndex = 6;
            this.FoodProgressBar.Value = 100;
            // 
            // HappinessProgressBar
            // 
            this.HappinessProgressBar.Location = new System.Drawing.Point(297, 104);
            this.HappinessProgressBar.Name = "HappinessProgressBar";
            this.HappinessProgressBar.Size = new System.Drawing.Size(264, 35);
            this.HappinessProgressBar.Step = 1;
            this.HappinessProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.HappinessProgressBar.TabIndex = 7;
            this.HappinessProgressBar.Value = 100;
            // 
            // EnergyProgressBar
            // 
            this.EnergyProgressBar.Location = new System.Drawing.Point(297, 174);
            this.EnergyProgressBar.Name = "EnergyProgressBar";
            this.EnergyProgressBar.Size = new System.Drawing.Size(264, 35);
            this.EnergyProgressBar.Step = 1;
            this.EnergyProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.EnergyProgressBar.TabIndex = 8;
            this.EnergyProgressBar.Value = 100;
            // 
            // FoodLabel
            // 
            this.FoodLabel.AutoSize = true;
            this.FoodLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FoodLabel.Location = new System.Drawing.Point(292, 6);
            this.FoodLabel.Name = "FoodLabel";
            this.FoodLabel.Size = new System.Drawing.Size(55, 27);
            this.FoodLabel.TabIndex = 9;
            this.FoodLabel.Text = "Food";
            // 
            // HappinessLabel
            // 
            this.HappinessLabel.AutoSize = true;
            this.HappinessLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HappinessLabel.Location = new System.Drawing.Point(292, 74);
            this.HappinessLabel.Name = "HappinessLabel";
            this.HappinessLabel.Size = new System.Drawing.Size(102, 27);
            this.HappinessLabel.TabIndex = 10;
            this.HappinessLabel.Text = "Happiness";
            // 
            // EnergyLabel
            // 
            this.EnergyLabel.AutoSize = true;
            this.EnergyLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnergyLabel.Location = new System.Drawing.Point(292, 144);
            this.EnergyLabel.Name = "EnergyLabel";
            this.EnergyLabel.Size = new System.Drawing.Size(75, 27);
            this.EnergyLabel.TabIndex = 11;
            this.EnergyLabel.Text = "Energy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 340);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // animalChooseLabel
            // 
            this.animalChooseLabel.AutoSize = true;
            this.animalChooseLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.animalChooseLabel.Location = new System.Drawing.Point(28, 208);
            this.animalChooseLabel.Name = "animalChooseLabel";
            this.animalChooseLabel.Size = new System.Drawing.Size(226, 27);
            this.animalChooseLabel.TabIndex = 13;
            this.animalChooseLabel.Text = "Choose your pet animal";
            // 
            // FeedButton
            // 
            this.FeedButton.Location = new System.Drawing.Point(297, 215);
            this.FeedButton.Name = "FeedButton";
            this.FeedButton.Size = new System.Drawing.Size(120, 66);
            this.FeedButton.TabIndex = 14;
            this.FeedButton.Text = "Feed";
            this.FeedButton.UseVisualStyleBackColor = true;
            this.FeedButton.Click += new System.EventHandler(this.FeedButton_Click);
            // 
            // SleepButton
            // 
            this.SleepButton.Location = new System.Drawing.Point(448, 215);
            this.SleepButton.Name = "SleepButton";
            this.SleepButton.Size = new System.Drawing.Size(113, 66);
            this.SleepButton.TabIndex = 15;
            this.SleepButton.Text = "Sleep";
            this.SleepButton.UseVisualStyleBackColor = true;
            this.SleepButton.Click += new System.EventHandler(this.SleepButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(373, 287);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(113, 66);
            this.PlayButton.TabIndex = 16;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // WarningLabel
            // 
            this.WarningLabel.BackColor = System.Drawing.Color.White;
            this.WarningLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(297, 104);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(264, 35);
            this.WarningLabel.TabIndex = 17;
            this.WarningLabel.Text = "label1";
            this.WarningLabel.UseCompatibleTextRendering = true;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(26, 126);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(228, 45);
            this.NameBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(158)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(569, 357);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.SleepButton);
            this.Controls.Add(this.FeedButton);
            this.Controls.Add(this.animalChooseLabel);
            this.Controls.Add(this.EnergyLabel);
            this.Controls.Add(this.HappinessLabel);
            this.Controls.Add(this.FoodLabel);
            this.Controls.Add(this.EnergyProgressBar);
            this.Controls.Add(this.HappinessProgressBar);
            this.Controls.Add(this.FoodProgressBar);
            this.Controls.Add(this.PetNameLabel);
            this.Controls.Add(this.CatButton);
            this.Controls.Add(this.DogButton);
            this.Controls.Add(this.namingLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WarningLabel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(103)))), ((int)(((byte)(124)))));
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "Form1";
            this.Text = "Tamagotchi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label namingLabel;
        private System.Windows.Forms.Button DogButton;
        private System.Windows.Forms.Button CatButton;
        private System.Windows.Forms.Label PetNameLabel;
        private System.Windows.Forms.Label FoodLabel;
        private System.Windows.Forms.Label HappinessLabel;
        private System.Windows.Forms.Label EnergyLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label animalChooseLabel;
        private System.Windows.Forms.Button FeedButton;
        private System.Windows.Forms.Button SleepButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.ProgressBar FoodProgressBar;
        private System.Windows.Forms.ProgressBar HappinessProgressBar;
        private System.Windows.Forms.ProgressBar EnergyProgressBar;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.TextBox NameBox;
    }
}

