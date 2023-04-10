using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП_ЛР_16__Чеботарьов_О._
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAdd.Text = "Додавання";
            btnRem.Text = "Віднімання";
            btnMult.Text = "Множення";
            btnDiv.Text = "Ділення";
            btnComp.Text = "Порівняння";
            lblResult.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string HexPrototype1 = txt1.Text;
            int HexNumber1 = Int32.Parse(HexPrototype1, System.Globalization.NumberStyles.HexNumber);
            string HexPrototype2 = txt2.Text;
            int HexNumber2 = Int32.Parse(HexPrototype2, System.Globalization.NumberStyles.HexNumber);
           lbltxt1.Text = HexNumber1.ToString();
           lbltxt2.Text = HexNumber2.ToString();

            int Adding = HexNumber1 + HexNumber2;
            
            lblResult.Text = Adding.ToString();
            string HexResult = Convert.ToString(Adding, 16);
            lblResultHex.Text = HexResult.ToString();

           
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            string HexPrototype1 = txt1.Text;
            int HexNumber1 = Int32.Parse(HexPrototype1, System.Globalization.NumberStyles.HexNumber);
            string HexPrototype2 = txt2.Text;
            int HexNumber2 = Int32.Parse(HexPrototype2, System.Globalization.NumberStyles.HexNumber);
            lbltxt1.Text = HexNumber1.ToString();
            lbltxt2.Text = HexNumber2.ToString();

            int Removing = HexNumber1 - HexNumber2;
            lblResult.Text = Removing.ToString();
            string HexResult = Convert.ToString(Removing, 16);
            lblResultHex.Text = HexResult.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            string HexPrototype1 = txt1.Text;
            int HexNumber1 = Int32.Parse(HexPrototype1, System.Globalization.NumberStyles.HexNumber);
            string HexPrototype2 = txt2.Text;
            int HexNumber2 = Int32.Parse(HexPrototype2, System.Globalization.NumberStyles.HexNumber);
            lbltxt1.Text = HexNumber1.ToString();
            lbltxt2.Text = HexNumber2.ToString();

            int Multiplying = HexNumber1 * HexNumber2;
            lblResult.Text = Multiplying.ToString();
            string HexResult = Convert.ToString(Multiplying, 16);
            lblResultHex.Text = HexResult.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            string HexPrototype1 = txt1.Text;
            int HexNumber1 = Int32.Parse(HexPrototype1, System.Globalization.NumberStyles.HexNumber);
            string HexPrototype2 = txt2.Text;
            int HexNumber2 = Int32.Parse(HexPrototype2, System.Globalization.NumberStyles.HexNumber);
            lbltxt1.Text = HexNumber1.ToString();
            lbltxt2.Text = HexNumber2.ToString();

            int Divided = HexNumber1 / HexNumber2;
            lblResult.Text = Divided.ToString();
            string HexResult = Convert.ToString(Divided, 16);
            lblResultHex.Text = HexResult.ToString();
        }

        private void btnComp_Click(object sender, EventArgs e)
        {
            string HexPrototype1 = txt1.Text;
            int HexNumber1 = Int32.Parse(HexPrototype1, System.Globalization.NumberStyles.HexNumber);
            string HexPrototype2 = txt2.Text;
            int HexNumber2 = Int32.Parse(HexPrototype2, System.Globalization.NumberStyles.HexNumber);
            lbltxt1.Text = HexNumber1.ToString();
            lbltxt2.Text = HexNumber2.ToString();

            if (HexNumber1 > HexNumber2)
            {
                lblResult.Text = "Перше число більше другого";
            }
            else if (HexNumber1 < HexNumber2)
            {
                lblResult.Text = "Перше число менше другого";
            }
            else
            {
                lblResult.Text = "Обидва числа рівні";
            }
            lblResultHex.Text = "";
        }
    }
}
