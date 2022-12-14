using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWO
{
    public partial class Module3 : UserControl
    {
        public Module3()
        {
            InitializeComponent();
        }

        private void obliczButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(kwotaBruttoTextBox.Text) || string.IsNullOrWhiteSpace(kwotaBruttoTextBox.Text))
                return;
            try
            {
                SalaryData result = SalaryCalculator.CalculateSalary(Convert.ToDecimal(kwotaBruttoTextBox.Text), pit0CheckBox.Checked);
                kwotaNettoTextBox.Text = result.Netto.ToString("0.00");
                skladkaEmerytalnaTextBox.Text = result.SkladkaEmerytalna.ToString("0.00");
                skladkaRentowaTextBox.Text = result.SkladkaRentowna.ToString("0.00");
                skladkaChorobowaTextBox.Text = result.SkladkaChorobowa.ToString("0.00");
                skladkaZdrowotnaTextBox.Text = result.SkladkaZdrowotna.ToString("0.00");
                sumaSkladekTextBox.Text = result.SkladkiSpoleczne.ToString("0.00");
                podatekTextBox.Text = result.Tax.ToString("0.00");
            }
            catch (AmountLessThanOrEqualZeroException)
            {
                MessageBox.Show("Wprowadzona wartość musi być większa niż 0.");
            }
            
        }

        private void kwotaBruttoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar);
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
