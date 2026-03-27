using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethotK_Lab3_CPT_206
{
    public partial class FullDatabase : Form
    {
        public FullDatabase()
        {
            InitializeComponent();
        }

        private void state_DatabaseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.state_DatabaseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Lab_3_Database_AccessDataSet);

        }

        private void FullDatabase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Lab_3_Database_AccessDataSet.State_Database' table. You can move, or remove it, as needed.
            this.state_DatabaseTableAdapter.Fill(this._Lab_3_Database_AccessDataSet.State_Database);

            comboBoxSort.Items.Add("Ascending Population");
            comboBoxSort.Items.Add("Descending Population");
            comboBoxSort.Items.Add("Sort by State Capitol");

        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (comboBoxSort.SelectedIndex == 0)
            {
                this.state_DatabaseTableAdapter.AscendingPopulationOrder(this._Lab_3_Database_AccessDataSet.State_Database);
            }
            else if (comboBoxSort.SelectedIndex == 1)
            {
                this.state_DatabaseTableAdapter.DescendingPopulationOrder(this._Lab_3_Database_AccessDataSet.State_Database);
            }
            else if(comboBoxSort.SelectedIndex == 2)
            {
                this.state_DatabaseTableAdapter.SortbyCapitolNames(this._Lab_3_Database_AccessDataSet.State_Database);
            }
            else
            {
                MessageBox.Show("Please select a Sorting option");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtBoxSearch.Text))
            {
                MessageBox.Show("Please enter a state name");
                return;
            }

            try
            {
                string enteredState = txtBoxSearch.Text.Trim();

                var table = new _Lab_3_Database_AccessDataSet.State_DatabaseDataTable();

                this.state_DatabaseTableAdapter.FillByState(table, enteredState);

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("State not found");
                    return;
                }

                Details window = new Details();
                window.Load(table);
                window.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            this.state_DatabaseTableAdapter.FilterByStateColor(this._Lab_3_Database_AccessDataSet.State_Database);
        }
    }
}
