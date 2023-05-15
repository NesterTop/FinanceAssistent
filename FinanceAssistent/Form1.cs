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
        bool gState = false;
        DataBase dataBase = new DataBase();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //FormAuth formAuth = new FormAuth(this);
            //formAuth.Show();
            dataBase.Open();
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            switch (e.Node.Text)
            {
                case "Доход":
                    dataGridView1.DataSource = dataBase.SelectData(Queries.SelectQueries.Dohod);
                    break;
                case "Категория дохода":
                    dataGridView1.DataSource = dataBase.SelectData(Queries.SelectQueries.TipDohoda);
                    break;
                case "Расход":
                    dataGridView1.DataSource = dataBase.SelectData(Queries.SelectQueries.Rashod);
                    break;
                case "Категория расхода":
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
                    FormDohod formDohod = new FormDohod(this, gState);
                    formDohod.Show();
                    break;
                
                case "Категория дохода":
                    FormTipDohoda formTipDohoda = new FormTipDohoda(dataGridView1);
                    formTipDohoda.Show();
                    break;
                
                case "Расход":
                    FormRashod formRashod = new FormRashod(this, gState);
                    formRashod.Show();
                    break;
                
                case "Категория расхода":
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
                    new FormUpdateDohod(dataGridView1).Show();
                    break;

                case "Категория дохода":
                    new FormUpdateTipDohoda(dataGridView1).Show();
                    break;

                case "Расход":
                    new FormUpdateRashod(dataGridView1).Show();
                    break;

                case "Категория расхода":
                    new FormUpdateTipRashoda(dataGridView1).Show();
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

        private void CreateGraphic()
        {
            gState = true;
            double sumDohod = 0;
            double sumRashod = 0;

            chart1.Legends.Add("");
            chart1.Series[0].Points.Clear();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            //chart1.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;

            bool checkDohod = double.TryParse(dataBase.SelectScalar("select sum(summa) from Dohod").ToString(), out sumDohod);
            bool checkRashod = double.TryParse(dataBase.SelectScalar("select sum(summa) from Rashod").ToString(), out sumRashod);

            if (checkDohod && checkRashod)
            {
                int procentDohod = (int)(sumDohod / (sumDohod + sumRashod) * 100);
                int procentRashod = (int)(sumRashod / (sumRashod + sumDohod) * 100);

                var dohod = chart1.Series[0].Points.Add(sumDohod);
                var rashod = chart1.Series[0].Points.Add(sumRashod);

                dohod.LegendText = "Доходы";
                rashod.LegendText = "Расходы";

                dohod.Label = $"{procentDohod}%";
                rashod.Label = $"{procentRashod}%";
            }

            //else if (!checkDohod) { MessageBox.Show("Доход"); }
            //else if (!checkRashod) { MessageBox.Show("Расход"); }
        }

        public void UpdateGraphic()
        {
            ClearGraphic();
            CreateGraphic();
        }

        private void ClearGraphic()
        {
            gState = false;
            chart1.Legends.Clear();
            chart1.Series[0].Points.Clear();
        }

        private void построитьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateGraphic();
        }

        private void очиститьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearGraphic();
        }

        
    }
}
