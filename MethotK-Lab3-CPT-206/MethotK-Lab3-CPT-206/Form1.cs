using MethotK_Lab_3_ClassLibrary;
using System;
using System.Data;
using System.Windows.Forms;

namespace MethotK_Lab3_CPT_206
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnection db = new DatabaseConnection();
                DataTable table = db.GetStates();

                comboBoxState.DataSource = table;
                comboBoxState.DisplayMember = "State";
                comboBoxState.ValueMember = "State";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

                DatabaseConnection db = new DatabaseConnection();
                DataTable table = db.GetStateByName(selectedState);

                Details window = new Details();
                window.Load(table);
                window.ShowDialog();
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

        private void btnFullDatabase_Click(object sender, EventArgs e)
        {
            FullDatabase fullDatabase = new FullDatabase();
            fullDatabase.ShowDialog();
        }
    }
}