using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using System.Text;
using Nistoc.Net.Extentions;
using System.Resources;
using System.Reflection;

namespace BedsPlan
{
    public partial class Plan
    {
        private ResourceManager rm = new ResourceManager("BedsPlan.Aliases", Assembly.GetExecutingAssembly());
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
            this.show.Click += new System.EventHandler(this.show_Click);
            this.delete.Click += new System.EventHandler(this.delete_Click);
            this.print.Click += new System.EventHandler(this.print_Click);

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
                for (var i = 3; i < 999; i += 21)
                {
                    Range["A" + i + ":N" + (i + 19)].Cells.ClearContents();
                }
            }
        }
        public class Bed
        {
            public string Name { get; set; }
            public double Width { get; set; }
            public double Height { get; set; }
            public int Count { get; set; }
            public string Box { get; set; }
            public bool HasBox { get { return Box != "0"; } }
            public string Div { get; set; }
            public bool HasDiv { get { return Div != "0"; } }
            public string Lam { get; set; }
            public bool HasLam { get { return Lam != "0"; } }
            public string Condition { get; set; }
            public string Color { get; set; }
            public string TransferDate { get; set; }
            public string MadeDate { get; set; }
            public DateTime DueDate { get; set; }
            public string Responsible { get; set; }
            public int Number { get; set; }

            public override string ToString()
            {
                var res = new StringBuilder();
                res.AppendFormat(@"Ліжко ""{0}"" {1}x{2} {3}",
                    Name,
                    (Width / 1000).ToString("F1"),
                    (Height / 1000).ToString("F1"),
                    Color);
                if (HasBox)
                    res.AppendFormat(" {0} ", Box);
                if (HasDiv)
                    res.AppendFormat(" {0} ", Div);
                if (HasLam)
                    res.AppendFormat(" {0} ", Lam);
                return res.ToString();
            }

        }

        private Bed Convert(Range row)
        {
            return new Bed
            {
                Name = row.Cells[1, 1].Text,
                Width = row.Cells[1, 2].Value,
                Height = row.Cells[1, 3].Value,
                Count = (int)(row.Cells[1, 4].Value),
                Color = rm.GetString(row.Cells[1, 5].Text.Trim()),
                Box = row.Cells[1, 6].Text,
                Div = row.Cells[1, 7].Text,
                Lam = row.Cells[1, 8].Text,
                Condition = row.Cells[1, 9].Text,
                DueDate = row.Cells[1, 10].Value,
                MadeDate = row.Cells[1, 11].Text,
                TransferDate = row.Cells[1, 12].Text.Trim(),
                Responsible = row.Cells[1, 13].Text,
                Number = (int)(row.Cells[1, 14].Value)
            };
        }

        private void print_Click(object sender, EventArgs e)
        {
            int range = 23;
            var t = (this.Columns["N"].Cells.Value as Array).OfType<int>();
            List<Bed> beds = new List<Bed>();
            foreach (Range row in UsedRange.Rows)
            {
                if (!string.IsNullOrEmpty(row.Cells[1, 14].Text) && row.Cells[1, 14].Text != "№ прихода")
                {
                    Bed bed = Convert(row);
                    beds.Add(bed);
                }
            }
            var y = beds.GroupBy(x => new { x.Number, x.TransferDate }).ToList();
            for (int i = 1; i <= y.Count(); i++)
            {
                int rowNumber = (i - 1) * range + 1;
                string st = "A" + rowNumber + ":G" + (i * range);
                var d = Globals.Result.Range[st];
                Globals.ResultTemplate.Range["A1:G23"].Copy(d);
                d.Cells[4, 2] = y[i - 1].Key.Number;
                d.Cells[5, 5] = y[i - 1].Key.TransferDate;
                for (int j = 0; j < y[i - 1].Count(); j++)
                {
                    d.Cells[j + 8, 1].Value = y[i - 1].ToArray()[j].ToString();
                    d.Cells[j + 8, 7].Value = y[i - 1].ToArray()[j].Count;
                }
                d.Cells[19, 7].Formula = "=SUM(G" + (rowNumber + 7) + ":G" + (rowNumber + 17) + ")";
                this.Evaluate(d.Cells[19, 7]);
                string f = d.Cells[19, 7].Text;
                d.Cells[19, 2] = f.MoneyToWord();
            }
            Globals.Result.Activate();
        }

    }
}