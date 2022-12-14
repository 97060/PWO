namespace PWO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabPage1.Controls.Add(new Module1());
            tabPage2.Controls.Add(new Module2());
            tabPage3.Controls.Add(new Module3());
        }
    }
}