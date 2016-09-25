using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkProperties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resButton_Click(object sender, EventArgs e)
        {
            double vol = Convert.ToDouble(volume.Text);
            
            //lactose content per 1mL
            double skim = 0.04954;
            double fat = 0.04730;
            double reg = 0.04705;
            double whole = 0.04622;
            double raw = 0.04054;
            
            //energy value per 1mL
            double skimEn = 0.38;
            double fatEn = 0.50;
            double regEn = 0.55;
            double wholeEn = 0.63;
            double rawEn = 0.70;
            
            //fat content per 1mL
            double skimFat = 0.005;
            double fatFat = 0.02;
            double regFat = 0.025;
            double wholeFat = 0.035;
            double rawFat = 0.04;

            //carbohydrate content per 1mL
            double skimCarb = 0.05;
            double fatCarb = 0.048;
            double regCarb = fatCarb;
            double wholeCarb = 0.047;
            double rawCarb = 0.0425;

            switch (milkType.Text)
            
            {
                case "Skim milk":
                    string res = Convert.ToString(vol * skim);
                    lacContent.Text = res;
                    enCon.Text = Convert.ToString(vol * skimEn);
                    fatC.Text = Convert.ToString(vol * skimFat);
                    carbCon.Text = Convert.ToString(vol * skimCarb);
                    break;

                case "Reduced fat milk":
                    res = Convert.ToString(vol * fat);
                    lacContent.Text = res;
                    enCon.Text = Convert.ToString(vol * fatEn);
                    fatC.Text = Convert.ToString(vol * fatFat);
                    carbCon.Text = Convert.ToString(vol * fatCarb);
                    break;

                case "Regular milk":
                    res = Convert.ToString(vol * reg);
                    lacContent.Text = res;
                    enCon.Text = Convert.ToString(vol * regEn);
                    fatC.Text = Convert.ToString(vol * regFat);
                    carbCon.Text = Convert.ToString(vol * regCarb);
                    break;

                case "Whole milk":
                    res = Convert.ToString(vol * whole);
                    lacContent.Text = res;
                    enCon.Text = Convert.ToString(vol * wholeEn);
                    fatC.Text = Convert.ToString(vol * wholeFat);
                    carbCon.Text = Convert.ToString(vol * wholeCarb);
                    break;

                case "Raw milk":
                    res = Convert.ToString(vol * raw);
                    lacContent.Text = res;
                    enCon.Text = Convert.ToString(vol * rawEn);
                    fatC.Text = Convert.ToString(vol * rawFat);
                    carbCon.Text = Convert.ToString(vol * rawCarb);
                    break;
            }
        }

    }
}
