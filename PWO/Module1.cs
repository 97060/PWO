namespace PWO
{
    public partial class Module1 : UserControl
    {
        private ExchangeRateClient _exchangeRate;
        public Module1()
        {
            _exchangeRate = new();
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            dataGridView1.Visible = false;
            dataGridView1.DataSource = await _exchangeRate.GetData();
            dataGridView1.Visible = true;
            button1.Enabled  = true;
        }
    }
}
