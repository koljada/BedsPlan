using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace BedsPlan
{
    public partial class BedsForm : Form
    {
        private readonly int perModel = 21;

        public BedsForm()
        {
            InitializeComponent();
            GetModels();
        }

        public string[] Models { get; set; }
        public string[] Widths { get; set; }
        public string[] Heights { get; set; }
        public string[] Colors { get; set; }

        public void GetModels()
        {
            Models = (Globals.Beds.Columns["B"].Cells.Value as Array)
                .OfType<object>()
                .Select(x => x.ToString())
                .Skip(1)
                .ToArray();
            model.Items.Clear();
            model.Items.AddRange(Models);
            model.AutoCompleteCustomSource.Clear();
            model.AutoCompleteCustomSource.AddRange(Models);
            model.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public void GetValues(int row)
        {
            widths.Items.Clear();
            heights.Items.Clear();
            colors.Items.Clear();
            model.SelectedIndex = row - 2;

            Widths = Globals.Beds.Cells[row, 3].Text.Split(',');
            widths.Items.AddRange(Widths);
            //widths.SelectedIndex = 1;

            Heights = Globals.Beds.Cells[row, 4].Text.Split(',');
            heights.Items.AddRange(Heights);
            //heights.SelectedIndex = 1;

            Colors = Globals.Beds.Cells[row, 8].Text.Split(',');
            colors.Items.AddRange(Colors);
            //colors.SelectedIndex = 1;

            hasLamel.Visible = (Globals.Beds.Cells[row, 7].Value == 1);
            hasBox.Visible = (Globals.Beds.Cells[row, 5].Value == 1);
            hasDivider.Visible = (Globals.Beds.Cells[row, 6].Value == 1);
        }

        private void add_Click(object sender, EventArgs e)
        {
            var model = this.model.Text;
            var row = Models.ToList().IndexOf(model);
            if (row < 0)
            {
                MessageBox.Show("Модель не выбрана");
                return;
            }
            if (widths.SelectedIndex < 0)
            {
                MessageBox.Show("Длинна не выбрана");
                return;
            }
            if (heights.SelectedIndex < 0)
            {
                MessageBox.Show("Ширина не выбрана");
                return;
            }
            if (colors.SelectedIndex < 0)
            {
                MessageBox.Show("Цвет не выбран");
                return;
            }

            var range = "A" + (row*perModel + 3) + ":A" + ((row + 1)*perModel + 2);
            var used = (Globals.Plan.Range[range].Cells.Value as Array).OfType<object>().Count();
            var last = row*perModel + used + 3;
            Globals.Plan.Cells[last, 1] = model;
            Globals.Plan.Cells[last, 2] = int.Parse(widths.Text);
            Globals.Plan.Cells[last, 3] = int.Parse(heights.Text);
            Globals.Plan.Cells[last, 4] = count.Value;
            Globals.Plan.Cells[last, 5] = colors.Text.Trim();
            Globals.Plan.Cells[last, 7] = hasBox.Checked ? "ящ" : "0";
            Globals.Plan.Cells[last, 8] = hasDivider.Checked ? "пер" :"0";
            Globals.Plan.Cells[last, 6] = hasLamel.Checked ? "усл" : "0";
            Globals.Plan.Cells[last, 9] = conditions.Text;
            Globals.Plan.Cells[last, 10] = deadline.Value.Date;
            Globals.Plan.Cells[last, 13] =
                responsible.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked).Text;
            Globals.Plan.Cells[(row + 1)*perModel + 2, 3] = "Сумма";
            Globals.Plan.Cells[(row + 1)*perModel + 2, 3].Borders.Weight = XlBorderWeight.xlMedium;
            Globals.Plan.Cells[(row + 1)*perModel + 2, 4].Formula = "=SUM(D" + (row*perModel + 3) + ":D" +
                                                                    ((row + 1)*perModel + 1) + ")";
            Globals.Plan.Cells[(row + 1)*perModel + 2, 4].Borders.Weight = XlBorderWeight.xlMedium;
            Globals.Plan.Activate();
            Globals.ThisWorkbook.Save();
            widths.SelectedIndex = -1;
            heights.SelectedIndex = -1;
            colors.SelectedIndex = -1;
            conditions.Text = "";
            count.Value = 1;
            hasBox.Checked = false;
            hasDivider.Checked = false;
            hasLamel.Checked = false;
        }

        private void model_SelectedIndexChanged(object sender, EventArgs e)
        {
            var row = Models.ToList().IndexOf((sender as ComboBox).Text) + 2;
            GetValues(row);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Globals.ThisWorkbook.Save();
            Hide();
        }
    }
}