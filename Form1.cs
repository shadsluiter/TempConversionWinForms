using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TempConversionClass;

namespace TempConversionWindowsForms
{
    public partial class Form1 : Form
    {
        ConversionCalculator Calc = new ConversionCalculator(0, 'F');

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            char fromTemp = 'F';
            char toTemp ='F';

            if (radio_F.Checked) fromTemp = 'F';  
            if (radio_C.Checked) fromTemp = 'C'; 
            if (radio_K.Checked) fromTemp = 'K'; 
            if (radio_toF.Checked) toTemp = 'F';  
            if (radio_toC.Checked) toTemp = 'C'; 
            if (radio_toK.Checked) toTemp = 'K';

            Calc = new ConversionCalculator(int.Parse(txt_temp.Text), fromTemp);
            
            switch(toTemp)
            {
                case 'C':
                    label_answer.Text = Calc.toCelsius().ToString();
                    break;

                case 'F':
                    label_answer.Text = Calc.toFahrenheight().ToString();
                    break;

                case 'K':
                    label_answer.Text = Calc.toKelvin().ToString();
                    break;
            }

        }
    }
}
