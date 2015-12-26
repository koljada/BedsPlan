using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Tools.Excel;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Number2Words;

namespace BedsPlan
{
    public partial class PlanToPrint
    {
        private void Лист5_Startup(object sender, System.EventArgs e)
        {
        }

        private void Лист5_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.print.Click += new System.EventHandler(this.print_Click);
            this.Startup += new System.EventHandler(this.Лист5_Startup);
            this.Shutdown += new System.EventHandler(this.Лист5_Shutdown);

        }

        #endregion

        private void print_Click(object sender, EventArgs e)
        {
            int range = 23;
            List<Bed> beds = new List<Bed>();
            Globals.Result.Range["A1:I999"].Cells.Clear();
            foreach (Excel.Range row in UsedRange.Rows)
            {
                if (!string.IsNullOrEmpty(row.Cells[1, 12].Text) && row.Cells[1, 14].Text != "№ прихода")
                {
                    Bed bed = Bed.Convert(row);
                    beds.Add(bed);
                }
            }
            var y = beds.GroupBy(x => x.TransferDate).ToList();
            for (int i = 1; i <= y.Count(); i++)
            {
                int rowNumber = (i - 1) * range + 1;
                string st = "A" + rowNumber + ":G" + (i * range);
                var d = Globals.Result.Range[st];
                Globals.ResultTemplate.Range["A1:G23"].Copy(d);
                d.Cells[5, 5] = y[i - 1].Key;
                for (int j = 0; j < y[i - 1].Count(); j++)
                {
                    d.Cells[j + 8, 1].Value = y[i - 1].ToArray()[j].ToString();
                    d.Cells[j + 8, 7].Value = y[i - 1].ToArray()[j].Count;
                }
                d.Cells[19, 7].Formula = "=SUM(G" + (rowNumber + 7) + ":G" + (rowNumber + 17) + ")";
                this.Evaluate(d.Cells[19, 7]);
                string sum = d.Cells[19, 7].Text;
                d.Cells[19, 2] = RussianNumberToWordsConverter.Convert(int.Parse(sum), GrammaticalGender.Feminine);
            }
            Globals.Result.Activate();
        }
    }
}
