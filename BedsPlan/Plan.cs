using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Text;
using System.Resources;
using System.Reflection;
using Number2Words;
using System.Data;

namespace BedsPlan
{
    public partial class Plan
    {

        private void Лист1_Startup(object sender, EventArgs e)
        { }

        private void Лист1_Shutdown(object sender, EventArgs e)
        { }

        #region VSTO Designer generated code

        /// <summary>
        ///     Required method for Designer support - do not modify
        ///     the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.show.Click += new EventHandler(this.show_Click);
            this.delete.Click += new EventHandler(this.delete_Click);
            this.printPlan.Click += new EventHandler(this.printPlan_Click);

        }

        #endregion

        private void show_Click(object sender, EventArgs e)
        {
            Globals.ThisWorkbook.Form = new BedsForm();
            Globals.ThisWorkbook.Form.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            var btn = MessageBoxButtons.YesNo;
            if (MessageBox.Show("Очистить данные?", "Предупреждение", btn) == DialogResult.Yes)
            {
                //for (var i = 3; i < 1500; i += 21)
                //{
                //    Range["A" + i + ":N" + (i + 19)].Cells.ClearContents();
                //}
                Range["A3:N1500"].Cells.Clear();
                Globals.PlanToPrint.Range["A5:N999"].Cells.Clear();
            }
        }

        private void printPlan_Click(object sender, EventArgs e)
        {
            int count = 5;
            foreach (Range item in UsedRange.Rows)
            {
                if (!string.IsNullOrEmpty(item.Cells[1, 3].Text))
                {
                    var copyTo = Globals.PlanToPrint.Range["A" + count + ":N" + count];
                    item.Copy(copyTo);
                    Globals.PlanToPrint.Cells[count, 4] = item.Cells[1, 4].Text;
                    count++;
                }
            }
            Globals.ThisWorkbook.Save();
            Globals.PlanToPrint.Activate();
        }
    }


}