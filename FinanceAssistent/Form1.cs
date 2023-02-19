using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinanceAssistent
{
    public partial class Form1 : Form
    {
        DataBase dataBase = new DataBase();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormAuth formAuth = new FormAuth(this);
            formAuth.Show();
            dataBase.Open();
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            switch (e.Node.Text)
            {
                case "Доход":
                    dataGridView1.DataSource = dataBase.SelectData(Queries.SelectQueries.Dohod);
                    break;
                case "Тип дохода":
                    dataGridView1.DataSource = dataBase.SelectData(Queries.SelectQueries.TipDohoda);
                    break;
                case "Расход":
                    dataGridView1.DataSource = dataBase.SelectData(Queries.SelectQueries.Rashod);
                    break;
                case "Тип расхода":
                    dataGridView1.DataSource = dataBase.SelectData(Queries.SelectQueries.TipRashoda);
                    break;
                case "Семья":
                    dataGridView1.DataSource = dataBase.SelectData(Queries.SelectQueries.Semya);
                    break;
            }

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (treeView1.SelectedNode.Text)
            {
                case "Доход":
                    FormDohod formDohod = new FormDohod(dataGridView1);
                    formDohod.Show();
                    break;
                
                case "Тип дохода":
                    FormTipDohoda formTipDohoda = new FormTipDohoda(dataGridView1);
                    formTipDohoda.Show();
                    break;
                
                case "Расход":
                    
                    break;
                
                case "Тип расхода":
                    FormTipRashoda formTipRashoda = new FormTipRashoda(dataGridView1);
                    formTipRashoda.Show();
                    break;
                
                case "Семья":
                    FormSemya formSemya = new FormSemya(dataGridView1);
                    formSemya.Show();
                    break;
            }
        }

        private void изменитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (treeView1.SelectedNode.Text)
            {
                case "Доход":

                    break;

                case "Тип дохода":
                    FormUpdateTipDohoda formUpdateTipDohoda = new FormUpdateTipDohoda(dataGridView1);
                    formUpdateTipDohoda.Show();
                    break;

                case "Расход":

                    break;

                case "Тип расхода":

                    break;

                case "Семья":

                    break;
            }
        }

        private void найтиТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearch formSearch = new FormSearch();
            formSearch.Show();
        }

        private void сформироватьОтчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExelExporter.ExportFromDataGridView(dataGridView1);
        }

        private void построитьГрафикДоходовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            chart1.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            var dt = dataBase.SelectData(Queries.SelectQueries.Dohod);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                chart1.Series[0].Points[0].LegendText = dt.Rows[i][0].ToString();
                chart1.Series[0].Points.Add((double)dt.Rows[i][2]);
            }
        }
    }
}
