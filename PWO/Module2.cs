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
    public partial class Module2 : UserControl
    {
        private readonly Db client = new();
       public Module2()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;
            if (editModeCheckBox.Checked)
            {
                await client.EditDataAsync((int)dataGridView1.SelectedRows[0].Cells[0].Value, comboBox1.Text, opisTextBox.Text, Convert.ToDecimal(kwotaTextBox.Text));
            }
            else
            {
                await client.AddDataAsync(comboBox1.Text, opisTextBox.Text, Convert.ToDecimal(kwotaTextBox.Text));
            }
            await RefreshAsync();
        }

        private void Module2_Load(object sender, EventArgs e)
        {
            RefreshAsync();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await client.DeleteDataAsync((int)dataGridView1.SelectedRows[0].Cells[0].Value);
            await RefreshAsync();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (!editModeCheckBox.Checked)
                return;
            SetControlsData();
        }

        private void editModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (editModeCheckBox.Checked)
            {
                groupBox1.Text = "Edytuj";
                if (dataGridView1.SelectedRows.Count > 0)
                    SetControlsData();
            }
            else
            {
                groupBox1.Text = "Dodaj";
                ClearControls();
            }
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected || !editModeCheckBox.Checked || dataGridView1.SelectedRows.Count == 0)
                return;
            SetControlsData();
        }

        private void kwotaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = (sender as TextBox).Text;
            e.Handled = e.KeyChar != (char)8 && !char.IsDigit(e.KeyChar) && e.KeyChar != '.';

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && text.Contains('.') && text[text.IndexOf('.')..].Length > 2)
            {
                e.Handled = true;
            }
        }

        private void kwotaTextBox_Leave(object sender, EventArgs e)
        {
            string text = (sender as TextBox).Text;
            if (text.EndsWith('.'))
                kwotaTextBox.Text = text.Remove(text.IndexOf('.'));
        }

        private async Task RefreshAsync()
        {
            rejestrDataBindingSource.DataSource = await client.GetDataAsync();
            DeleteButton.Enabled = false;
            editModeCheckBox.Enabled = false;
            saldoTextBox.Text = String.Empty;
            if (dataGridView1.RowCount > 0)
            {
                DeleteButton.Enabled = true;
                editModeCheckBox.Enabled = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                saldoTextBox.Text = dataGridView1.Rows.Cast<DataGridViewRow>()
                    .Sum(x => (decimal)x.Cells[4].Value).ToString() + " PLN";
            }
            ClearControls();
        }

        private bool Validate()
        {
            string message = "";
            if (String.IsNullOrEmpty(comboBox1.Text))
            {
                message += "Należy wybrać typ operacji.\n";
            }
            if (String.IsNullOrEmpty(opisTextBox.Text))
            {
                message += "Należy uzupełnić opis.\n";
            }
            if (String.IsNullOrEmpty(kwotaTextBox.Text))
            {
                message += "Kwota nie może być pusta.\n";
            }

            if (!String.IsNullOrEmpty(message))
            {
                MessageBox.Show(message, "Walidacja danych");
            }
            return String.IsNullOrEmpty(message);
        }

        private void SetControlsData()
        {
            var selectedRowCells = dataGridView1.SelectedRows[0].Cells;
            comboBox1.SelectedIndex = comboBox1.FindStringExact(selectedRowCells[2].Value.ToString());
            opisTextBox.Text = selectedRowCells[3].Value.ToString();
            kwotaTextBox.Text = selectedRowCells[4].Value.ToString();
        }
        private void ClearControls()
        {
            comboBox1.SelectedIndex = 0;
            opisTextBox.Text = String.Empty;
            kwotaTextBox.Text = String.Empty;
        }
    }
}
