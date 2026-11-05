using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace HWF9
{
    public partial class Form1 : Form
    {
        Pet pet;
        static Timer tamagochiTimer = new Timer();
        public Form1()
        {
            InitializeComponent();
            PetNameLabel.Parent = pictureBox1;
            PetNameLabel.BackColor = Color.Transparent;
            PetNameLabel.Text = "";
            tamagochiTimer.Interval = 60;
            tamagochiTimer.Tick += Tick;
            FeedButton.Enabled = false;
            SleepButton.Enabled = false;
            PlayButton.Enabled = false;

        }

        public int petVar;

        private void DogButton_Click(object sender, EventArgs e)
        {
            if (this.NameBox.Text.Trim().Length < 3 || this.NameBox.Text.Trim().Length > 10)
                MessageBox.Show("Name must be between 3 and 10 characters long.");
            else
            {
                this.PetNameLabel.Text = this.NameBox.Text.Trim();
                petVar = 1; 
                pet = new Pet(this.PetNameLabel.Text, petVar);
                tamagochiTimer.Start();
                pictureBox1.BringToFront();
                PetNameLabel.BringToFront();
                initUI();
                FeedButton.Enabled = true;
                SleepButton.Enabled = true;
                PlayButton.Enabled = true;
            }
        }

        private void CatButton_Click(object sender, EventArgs e)
        {
            if (this.NameBox.Text.Trim().Length < 3 || this.NameBox.Text.Trim().Length > 10)
                MessageBox.Show("Name must be between 3 and 10 characters long.");
            else
            {
                this.PetNameLabel.Text = this.NameBox.Text.Trim();
                petVar = 2; 
                pet = new Pet(this.PetNameLabel.Text, petVar);
                tamagochiTimer.Start();
                pictureBox1.BringToFront();
                PetNameLabel.BringToFront();
                initUI();
                FeedButton.Enabled = true;
                SleepButton.Enabled = true;
                PlayButton.Enabled = true;
            }
        }

        private void Tick(Object source, EventArgs e)
        {
            // віднімання показників кожні 60 мілісекунд
            if (pet.getHappyness() > 0)
            {
                HappinessProgressBar.BringToFront();
                pet.decreaseHungry(0.05);
                pet.decreaseEnergy(0.05);
                pet.decreaseHappyness(0.05);
            }
            else if (pet.getHappyness() == 0)
            {
                WarningLabel.BringToFront();
                WarningLabel.Text = "ur pet is unhappy, he will lose more energy";
                pet.decreaseEnergy(0.15);
                pet.decreaseHungry(0.05);
            }

            // показ картинок petVar == 1 - собака, petVar == 2 - кіт

            if (pet.getEnergy() == 0 && petVar == 1 || pet.getFood() == 0 && petVar == 1)
            {
                this.pictureBox1.Image = global::HWF9.Properties.Resources.deaddog;
                tamagochiTimer.Enabled = false;
                initUI();

                DialogResult dr = MessageBox.Show("Ur pet is dead!!!", "GAME OVER!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (dr == DialogResult.OK)
                {
                    Application.Exit();
                }
                return;
            }

            if (pet.getEnergy() == 0 && petVar == 2 || pet.getFood() == 0 && petVar == 2)
            {
                this.pictureBox1.Image = global::HWF9.Properties.Resources.deadcat;
                tamagochiTimer.Enabled = false;
                initUI();

                DialogResult dr = MessageBox.Show("Ur pet is dead!!!", "GAME OVER!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (dr == DialogResult.OK)
                {
                    Application.Exit();
                }
                return;
            }

            if (pet.getEnergy() <= 30 && petVar == 1)
                this.pictureBox1.Image = global::HWF9.Properties.Resources.lowenergydog;
            else if (pet.getEnergy() <= 30 && petVar == 2)
                this.pictureBox1.Image = global::HWF9.Properties.Resources.lowenergycat;

            else if (pet.getFood() <= 30 && petVar == 1)
                this.pictureBox1.Image = global::HWF9.Properties.Resources.hungrydog;
            else if (pet.getFood() <= 30 && petVar == 2)
                this.pictureBox1.Image = global::HWF9.Properties.Resources.hungrycat;

            else if (pet.getHappyness() <= 30 && petVar == 1)
                this.pictureBox1.Image = global::HWF9.Properties.Resources.saddog;
            else if (pet.getHappyness() <= 30 && petVar == 2)
                this.pictureBox1.Image = global::HWF9.Properties.Resources.sadcat;

            else if (petVar == 1)
                this.pictureBox1.Image = global::HWF9.Properties.Resources.basedog;
            else if (petVar == 2)
                this.pictureBox1.Image = global::HWF9.Properties.Resources.basecat;

            initUI();
        }


        private void initUI()
        {

            this.FoodProgressBar.Value = Convert.ToInt32(pet.getFood());
            this.HappinessProgressBar.Value = Convert.ToInt32(pet.getHappyness());
            this.EnergyProgressBar.Value = Convert.ToInt32(pet.getEnergy());

            if (pet.getFood() <= 30)
                CBP.ChangeProgressBarColor(FoodProgressBar, 2);
            else if (pet.getFood() <= 60)
                CBP.ChangeProgressBarColor(FoodProgressBar, 3);
            else
                CBP.ChangeProgressBarColor(FoodProgressBar, 1);

            if (pet.getHappyness() <= 30)
                CBP.ChangeProgressBarColor(HappinessProgressBar, 2);
            else if (HappinessProgressBar.Value <= 60)
                CBP.ChangeProgressBarColor(HappinessProgressBar, 3);
            else
                CBP.ChangeProgressBarColor(HappinessProgressBar, 1);

            if (pet.getEnergy() <= 30)
                CBP.ChangeProgressBarColor(EnergyProgressBar, 2);
            else if (pet.getEnergy() <= 60)
                CBP.ChangeProgressBarColor(EnergyProgressBar, 3);
            else
                CBP.ChangeProgressBarColor(EnergyProgressBar, 1);

        }

        private void FeedButton_Click(object sender, EventArgs e)
        {
            pet.increaseEnergy(1);
            pet.increaseHungry(10);
        }

        private void SleepButton_Click(object sender, EventArgs e)
        {
            pet.increaseEnergy(10);
            pet.decreaseHungry(10);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            pet.increaseHappyness(10);
            pet.decreaseHungry(10);
            pet.decreaseEnergy(10);
        }
    }
}