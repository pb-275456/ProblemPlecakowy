using ProblemPlecakowy;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            int seed = 0, n = 0, capacity = 0;

            bool validSeed = ValidateInputSeed(out seed);
            bool validCapacity = ValidateInputCapacity(out capacity);
            bool validN = ValidateInputNumber(out n);

            if (!validSeed || !validCapacity || !validN) return;

            Problem problem = new Problem(n, seed);
            Result result = problem.Solve(capacity);

            instanceBox.Text = problem.ToString();

            resultBox.Text = result.ToString();
        }

        private bool ValidateInputSeed(out int seed)
        {
            if(!int.TryParse(seedBox.Text, out seed))
            {
                seedBox.BackColor = System.Drawing.Color.Red;
                return false;
            }
            seedBox.BackColor = System.Drawing.Color.PaleGreen;
            return true;
        }

        private bool ValidateInputNumber(out int n)
        {
            if (!int.TryParse(numberBox.Text, out n))
            {
                numberBox.BackColor = System.Drawing.Color.Red;
                return false;
            }
            if (n < 0)
            {
                numberBox.BackColor = System.Drawing.Color.Red;
                return false;
            }
            numberBox.BackColor = System.Drawing.Color.PaleGreen;
            return true;
        }

        private bool ValidateInputCapacity(out int capacity)
        {
            if (!int.TryParse(capacityBox.Text, out capacity))
            {
                capacityBox.BackColor = System.Drawing.Color.Red;
                return false;
            }
            if (capacity < 0)
            {
                capacityBox.BackColor = System.Drawing.Color.Red;
                return false;
            }
            capacityBox.BackColor = System.Drawing.Color.PaleGreen;
            return true;
        }
    }
}
