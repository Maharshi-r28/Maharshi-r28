namespace Arithematic_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //combooptions.Items.Add("");
            combooption.Items.Add("Addition");
            combooption.Items.Add("Subtraction");
            combooption.Items.Add("Multiplication");
            combooption.Items.Add("Division");
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtfirstnum.Text = " ";
            txtsecondnum.Text = " ";
            txtresult.Text = " ";
            combooption.Text = " ";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //this.close();
            Application.Exit();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;

            num1 = Convert.ToDouble(txtfirstnum.Text);
            num2 = Convert.ToDouble(txtsecondnum.Text);

            if(combooption.Text == "Addition")
            {
                txtresult.Text = Convert.ToString(num1 + num2);
            }

            if (combooption.Text == "Subtraction")
            {
                txtresult.Text = Convert.ToString(num1 - num2);
            }

            if (combooption.Text == "Multiplication")
            {
                txtresult.Text = Convert.ToString(num1 * num2);
            }

            if (combooption.Text == "Division")
            {
                txtresult.Text = Convert.ToString(num1 / num2);
            }

        }
    }
}
