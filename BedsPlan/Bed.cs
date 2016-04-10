using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;

namespace BedsPlan
{
    public class Bed
    {
        private static ResourceManager rm = new ResourceManager("BedsPlan.Aliases", Assembly.GetExecutingAssembly());
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
        public string Decoration { get; set; }
        public string BedHead { get; set; }
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
            if (!string.IsNullOrEmpty(BedHead))
                res.AppendFormat(" {0} ", BedHead);
            if (!string.IsNullOrEmpty(Decoration))
                res.AppendFormat(" {0} ", Decoration);
            return res.ToString();
        }

        public static Bed Convert(Range row)
        {
            return new Bed
            {
                Name = row.Cells[1, 1].Text,
                Width = row.Cells[1, 2].Value,
                Height = row.Cells[1, 3].Value,
                Count = (int)(row.Cells[1, 4].Value),
                Color = rm.GetString(row.Cells[1, 5].Text.Trim()),
                Box = row.Cells[1, 7].Text,
                Div = row.Cells[1, 8].Text,
                Lam = row.Cells[1, 6].Text,
                BedHead= row.Cells[1, 9].Text,
                Decoration= row.Cells[1, 10].Text,
                Condition = row.Cells[1, 11].Text,
                DueDate = row.Cells[1, 12].Value,
                MadeDate = row.Cells[1, 13].Text,
                TransferDate = row.Cells[1, 14].Text.Trim(),
                Responsible = row.Cells[1, 15].Text
            };
        }

    }
}
