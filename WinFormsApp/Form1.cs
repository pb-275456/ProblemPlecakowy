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

        private void Items_Click(object sender, EventArgs e)
        {

        }

        private void labelSize_Click(object sender, EventArgs e)
        {

        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            int seed = int.Parse(seedBox.Text);
            int n = int.Parse(numberBox.Text);
            int capacity = int.Parse(capacityBox.Text);

            Problem problem = new Problem(n, seed);
            Result result = problem.Solve(capacity);

            instanceBox.Text = problem.ToString();

            resultBox.Text = result.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
