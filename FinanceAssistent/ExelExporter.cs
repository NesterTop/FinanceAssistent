using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
namespace FinanceAssistent
{
    public static class ExelExporter
    {
        public static void ExportFromDataGridView(DataGridView dataGrid)
        {
            Exel.Application _exApp = new Exel.Application();
            _exApp.Workbooks.Add();
            Exel.Worksheet _worksheet = _exApp.ActiveSheet;
            

            for(int i = 0; i < dataGrid.Rows.Count; i++)
            {
                for(int j = 0; j < dataGrid.Columns.Count; j++)
                {
                    _worksheet.Cells[1, j + 1] = dataGrid.Columns[j].HeaderText.ToString();
                    _worksheet.Cells[i + 2, j + 1] = dataGrid[j, i].Value.ToString();
                }
            }

            _exApp.Visible = true;
        }
    }
}
