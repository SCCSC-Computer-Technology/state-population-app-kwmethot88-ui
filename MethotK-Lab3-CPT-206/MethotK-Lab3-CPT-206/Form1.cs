using MethotK_Lab_3_ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MethotK_Lab3_CPT_206._Lab_3_Database_AccessDataSet;


namespace MethotK_Lab3_CPT_206
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void state_DatabaseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.state_DatabaseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Lab_3_Database_AccessDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the '_Lab_3_Database_AccessDataSet.State_Database' table. You can move, or remove it, as needed.
                this.state_DatabaseTableAdapter.Fill(this._Lab_3_Database_AccessDataSet.State_Database);

                comboBoxState.DataSource = this._Lab_3_Database_AccessDataSet.State_Database;
                comboBoxState.DisplayMember = "State";
                comboBoxState.ValueMember = "State";
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message); 
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (comboBoxState.SelectedIndex == -1)
            {
                MessageBox.Show("Select a State");
                return;
            }

            try
            {
                string selectedState = comboBoxState.SelectedValue.ToString();

                var table = new _Lab_3_Database_AccessDataSet.State_DatabaseDataTable();
                this.state_DatabaseTableAdapter.FillByState(table, selectedState);

               
                Details window = new Details();
                window.Load(table);
                window.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnFullDatabase_Click(object sender, EventArgs e)
        {
            FullDatabase fullDatabase = new FullDatabase();
            fullDatabase.ShowDialog();
        }
    }
}
