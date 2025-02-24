namespace ProjectCalculator
{
    public partial class FormKalkulator : Form
    {
        String stringVar = "";
        Double var1 = 0.0;
        Double varHasil = 0.0;
        String operations = "";

        public FormKalkulator()
        {
            InitializeComponent();
        }

        private void buttonOnOff_MouseHover(object sender, EventArgs e)
        {
            //buttonOnOff.BackColor = 
        }

        private void buttonOnOff_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            stringVar = "1";
            textBoxDisplay.Text = stringVar;
        }

        private void buttonNol_Click(object sender, EventArgs e)
        {
            stringVar += "0";
            textBoxDisplay.Text = stringVar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stringVar += "";
            textBoxDisplay.Text = stringVar;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stringVar += "3";
            textBoxDisplay.Text = stringVar;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stringVar += "4";
            textBoxDisplay.Text = stringVar;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            stringVar += "5";
            textBoxDisplay.Text = stringVar;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            stringVar += "6";
            textBoxDisplay.Text = stringVar;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            stringVar += "7";
            textBoxDisplay.Text = stringVar;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            stringVar += "8";
            textBoxDisplay.Text = stringVar;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            stringVar += "9";
            textBoxDisplay.Text = stringVar;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            operations = "+";
            var1 = Convert.ToDouble(stringVar);
            stringVar = "";
            textBoxDisplay.Text = "0";
        }

        private void buttonSamaDengan_Click(object sender, EventArgs e)
        {
            if (operations == "+")
            {
                varHasil = var1 + Convert.ToDouble(textBoxDisplay.Text);
                textBoxDisplay.Text = varHasil.ToString();
                stringVar = varHasil.ToString();
            }
            else if (operations == "x")
            {
                varHasil = var1 * Convert.ToDouble(textBoxDisplay.Text);
                textBoxDisplay.Text = varHasil.ToString();
                stringVar = varHasil.ToString();
            }
            else if (operations == "-")
            {
                varHasil = var1 - Convert.ToDouble(textBoxDisplay.Text);
                textBoxDisplay.Text = varHasil.ToString();
                stringVar = varHasil.ToString();
            }
            else if (operations == "/")
            {
                varHasil = var1 / Convert.ToDouble(textBoxDisplay.Text);
                textBoxDisplay.Text = varHasil.ToString();
                stringVar = varHasil.ToString();
            }
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            operations = "x";
            var1 = Convert.ToDouble(stringVar);
            stringVar = "";
            textBoxDisplay.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            stringVar = "0";
            textBoxDisplay.Text = stringVar;
            var1 = 0.0;
            varHasil = 0.0;
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            operations = "-";
            var1 = Convert.ToDouble(stringVar);
            stringVar = "";
            textBoxDisplay.Text = "0";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operations = "/";
            var1 = Convert.ToDouble(stringVar);
            stringVar = "";
            textBoxDisplay.Text = "0";
        }
    }
}
