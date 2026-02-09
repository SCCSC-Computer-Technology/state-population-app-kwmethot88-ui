using MethotK_Lab3_CPT_206._Lab_3_Database_AccessDataSetTableAdapters;
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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        public void Load(DataTable dt)
        {
            dataGridView1.DataSource = dt;
        }
    }
}
