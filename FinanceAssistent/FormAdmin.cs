using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceAssistent
{
    public partial class FormAdmin : Form
    {
        DataTable currentTable;
        SqlDataAdapter currentAdapter;
        
        DataBaseDataSetTableAdapters.TipRashodaTableAdapter TipRashodaTableAdapter = new DataBaseDataSetTableAdapters.TipRashodaTableAdapter();
        DataBaseDataSet.TipRashodaDataTable tipRashoda = new DataBaseDataSet.TipRashodaDataTable();

        DataBaseDataSetTableAdapters.DohodTableAdapter DohodTableAdapter = new DataBaseDataSetTableAdapters.DohodTableAdapter();
        DataBaseDataSet.DohodDataTable dohod = new DataBaseDataSet.DohodDataTable();

        public FormAdmin()
        {
            InitializeComponent();
        }
        private void FormAdmin_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TipRashodaTableAdapter.Adapter.UpdateCommand = new SqlCommandBuilder(TipRashodaTableAdapter.Adapter).GetUpdateCommand();

            TipRashodaTableAdapter.Fill(tipRashoda);
            dataGridView1.DataSource = tipRashoda;
            
            currentAdapter = TipRashodaTableAdapter.Adapter;
            currentTable = tipRashoda;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DohodTableAdapter.Adapter.UpdateCommand = new SqlCommandBuilder(DohodTableAdapter.Adapter).GetUpdateCommand();

            DohodTableAdapter.Fill(dohod);
            dataGridView1.DataSource = dohod;
            
            currentAdapter = DohodTableAdapter.Adapter;
            currentTable = dohod;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentAdapter.Update(currentTable);
        }

        
    }
}
