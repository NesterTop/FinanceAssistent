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
            dataBase.Open();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            switch (e.Node.Text)
            {
                case "Доходы":
                    dataGridView1.DataSource = dataBase.SelectData(Queries.SelectQueries.Dohod);
                    break;
                case "Категории дохода":
                    dataGridView1.DataSource = dataBase.SelectData(Queries.SelectQueries.TipDohoda);
                    break;
                case "Расходы":
                    dataGridView1.DataSource = dataBase.SelectData(Queries.SelectQueries.Rashod);
                    break;
                case "Категории расхода":
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
                case "Доходы":
                    FormDohod formDohod = new FormDohod(this, gState);
                    formDohod.Show();
                    break;
                
                case "Категории дохода":
                    FormTipDohoda formTipDohoda = new FormTipDohoda(dataGridView1);
                    formTipDohoda.Show();
                    break;
                
                case "Расходы":
                    FormRashod formRashod = new FormRashod(this, gState);
                    formRashod.Show();
                    break;
                
                case "Категории расхода":
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
                case "Доходы":
                    new FormUpdateDohod(dataGridView1).Show();
                    break;

                case "Категории дохода":
                    new FormUpdateTipDohoda(dataGridView1).Show();
                    break;

                case "Расходы":
                    new FormUpdateRashod(dataGridView1).Show();
                    break;

                case "Категории расхода":
                    new FormUpdateTipRashoda(dataGridView1).Show();
                    break;

                case "Семья":
                    new FormUpdateFamily(dataGridView1).Show(); 
                    break;
            }
        }

        private void удалитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (treeView1.SelectedNode.Text)
            {
                case "Доходы":
                    new FormDeleteDohod(dataGridView1).Show();
                    break;

                case "Категории дохода":
                    new FormDeleteTipDohoda(dataGridView1).Show();
                    break;

                case "Расходы":
                    new FormDeleteRashod(dataGridView1).Show();
                    break;

                case "Категории расхода":
                    new FormDeleteTipRashoda(dataGridView1).Show();
                    break;

                case "Семья":
                    new FormDeleteFamily(dataGridView1).Show();
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

            bool checkDohod = double.TryParse(dataBase.SelectScalar("select sum(summa) from Dohod").ToString(), out sumDohod);
            bool checkRashod = double.TryParse(dataBase.SelectScalar("select sum(summa) from Rashod").ToString(), out sumRashod);

            if (checkDohod && checkRashod)
            {
                int procentDohod = Convert.ToInt32(sumDohod / (sumDohod + sumRashod) * 100);
                int procentRashod = Convert.ToInt32(sumRashod / (sumRashod + sumDohod) * 100);

                var dohod = chart1.Series[0].Points.Add(sumDohod);
                var rashod = chart1.Series[0].Points.Add(sumRashod);

                dohod.LegendText = "Доходы";
                rashod.LegendText = "Расходы";

                dohod.Label = $"{procentDohod}%";
                rashod.Label = $"{procentRashod}%";
            }
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
