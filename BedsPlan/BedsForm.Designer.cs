using System.ComponentModel;
using System.Windows.Forms;

namespace BedsPlan
{
    partial class BedsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.ComboBox();
            this.count = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.deadline = new System.Windows.Forms.DateTimePicker();
            this.conditions = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.colors = new System.Windows.Forms.ComboBox();
            this.heights = new System.Windows.Forms.ComboBox();
            this.widths = new System.Windows.Forms.ComboBox();
            this.hasDivider = new System.Windows.Forms.CheckBox();
            this.hasBox = new System.Windows.Forms.CheckBox();
            this.hasLamel = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.bedheads = new System.Windows.Forms.ComboBox();
            this.labelBedHead = new System.Windows.Forms.Label();
            this.responsible = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDecoration = new System.Windows.Forms.Label();
            this.decorations = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.count)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Модель";
            // 
            // model
            // 
            this.model.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.model.FormattingEnabled = true;
            this.model.Location = new System.Drawing.Point(37, 60);
            this.model.Margin = new System.Windows.Forms.Padding(4);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(160, 25);
            this.model.TabIndex = 53;
            this.model.SelectedIndexChanged += new System.EventHandler(this.model_SelectedIndexChanged);
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(259, 62);
            this.count.Margin = new System.Windows.Forms.Padding(4);
            this.count.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(160, 23);
            this.count.TabIndex = 52;
            this.count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(257, 35);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 17);
            this.label11.TabIndex = 51;
            this.label11.Text = "Количество";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(36, 418);
            this.add.Margin = new System.Windows.Forms.Padding(4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(177, 56);
            this.add.TabIndex = 50;
            this.add.Text = "Добавить запись";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 299);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "Срок";
            // 
            // deadline
            // 
            this.deadline.Location = new System.Drawing.Point(259, 322);
            this.deadline.Margin = new System.Windows.Forms.Padding(4);
            this.deadline.Name = "deadline";
            this.deadline.Size = new System.Drawing.Size(159, 23);
            this.deadline.TabIndex = 44;
            // 
            // conditions
            // 
            this.conditions.Location = new System.Drawing.Point(37, 376);
            this.conditions.Margin = new System.Windows.Forms.Padding(4);
            this.conditions.Name = "conditions";
            this.conditions.Size = new System.Drawing.Size(383, 23);
            this.conditions.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 355);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Дополнительные условия";
            // 
            // colors
            // 
            this.colors.FormattingEnabled = true;
            this.colors.Location = new System.Drawing.Point(37, 218);
            this.colors.Margin = new System.Windows.Forms.Padding(4);
            this.colors.Name = "colors";
            this.colors.Size = new System.Drawing.Size(160, 25);
            this.colors.TabIndex = 38;
            // 
            // heights
            // 
            this.heights.FormattingEnabled = true;
            this.heights.Location = new System.Drawing.Point(37, 166);
            this.heights.Margin = new System.Windows.Forms.Padding(4);
            this.heights.Name = "heights";
            this.heights.Size = new System.Drawing.Size(160, 25);
            this.heights.TabIndex = 37;
            // 
            // widths
            // 
            this.widths.FormattingEnabled = true;
            this.widths.Location = new System.Drawing.Point(37, 114);
            this.widths.Margin = new System.Windows.Forms.Padding(4);
            this.widths.Name = "widths";
            this.widths.Size = new System.Drawing.Size(160, 25);
            this.widths.TabIndex = 36;
            // 
            // hasDivider
            // 
            this.hasDivider.AutoSize = true;
            this.hasDivider.Location = new System.Drawing.Point(260, 166);
            this.hasDivider.Margin = new System.Windows.Forms.Padding(4);
            this.hasDivider.Name = "hasDivider";
            this.hasDivider.Size = new System.Drawing.Size(113, 21);
            this.hasDivider.TabIndex = 35;
            this.hasDivider.Text = "Перегородка";
            this.hasDivider.UseVisualStyleBackColor = true;
            // 
            // hasBox
            // 
            this.hasBox.AutoSize = true;
            this.hasBox.Location = new System.Drawing.Point(357, 112);
            this.hasBox.Margin = new System.Windows.Forms.Padding(4);
            this.hasBox.Name = "hasBox";
            this.hasBox.Size = new System.Drawing.Size(71, 21);
            this.hasBox.TabIndex = 34;
            this.hasBox.Text = "Ящики";
            this.hasBox.UseVisualStyleBackColor = true;
            // 
            // hasLamel
            // 
            this.hasLamel.AutoSize = true;
            this.hasLamel.Location = new System.Drawing.Point(259, 112);
            this.hasLamel.Margin = new System.Windows.Forms.Padding(4);
            this.hasLamel.Name = "hasLamel";
            this.hasLamel.Size = new System.Drawing.Size(100, 21);
            this.hasLamel.TabIndex = 33;
            this.hasLamel.Text = "Ус. ламели";
            this.hasLamel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Цвет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Ширина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Длинна";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(243, 417);
            this.exit.Margin = new System.Windows.Forms.Padding(4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(177, 56);
            this.exit.TabIndex = 55;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // bedheads
            // 
            this.bedheads.FormattingEnabled = true;
            this.bedheads.Location = new System.Drawing.Point(37, 268);
            this.bedheads.Margin = new System.Windows.Forms.Padding(4);
            this.bedheads.Name = "bedheads";
            this.bedheads.Size = new System.Drawing.Size(160, 25);
            this.bedheads.TabIndex = 57;
            // 
            // labelBedHead
            // 
            this.labelBedHead.AutoSize = true;
            this.labelBedHead.Location = new System.Drawing.Point(39, 247);
            this.labelBedHead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBedHead.Name = "labelBedHead";
            this.labelBedHead.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelBedHead.Size = new System.Drawing.Size(76, 17);
            this.labelBedHead.TabIndex = 56;
            this.labelBedHead.Text = "Изголовье";
            // 
            // responsible
            // 
            this.responsible.FormattingEnabled = true;
            this.responsible.Location = new System.Drawing.Point(37, 320);
            this.responsible.Margin = new System.Windows.Forms.Padding(4);
            this.responsible.Name = "responsible";
            this.responsible.Size = new System.Drawing.Size(160, 25);
            this.responsible.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 299);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 60;
            this.label5.Text = "Ответственный";
            // 
            // labelDecoration
            // 
            this.labelDecoration.AutoSize = true;
            this.labelDecoration.Location = new System.Drawing.Point(262, 197);
            this.labelDecoration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDecoration.Name = "labelDecoration";
            this.labelDecoration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelDecoration.Size = new System.Drawing.Size(97, 17);
            this.labelDecoration.TabIndex = 58;
            this.labelDecoration.Text = "Доп. отделка";
            // 
            // decorations
            // 
            this.decorations.FormattingEnabled = true;
            this.decorations.Location = new System.Drawing.Point(260, 218);
            this.decorations.Margin = new System.Windows.Forms.Padding(4);
            this.decorations.Name = "decorations";
            this.decorations.Size = new System.Drawing.Size(160, 25);
            this.decorations.TabIndex = 59;
            // 
            // BedsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 479);
            this.Controls.Add(this.responsible);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.decorations);
            this.Controls.Add(this.labelDecoration);
            this.Controls.Add(this.bedheads);
            this.Controls.Add(this.labelBedHead);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.model);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.deadline);
            this.Controls.Add(this.conditions);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.colors);
            this.Controls.Add(this.heights);
            this.Controls.Add(this.widths);
            this.Controls.Add(this.hasDivider);
            this.Controls.Add(this.hasBox);
            this.Controls.Add(this.hasLamel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BedsForm";
            this.ShowIcon = false;
            this.Text = "План производства";
            ((System.ComponentModel.ISupportInitialize)(this.count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox model;
        private NumericUpDown count;
        private Label label11;
        private Button add;
        private Label label8;
        private DateTimePicker deadline;
        private TextBox conditions;
        private Label label6;
        private ComboBox colors;
        private ComboBox heights;
        private ComboBox widths;
        private CheckBox hasDivider;
        private CheckBox hasBox;
        private CheckBox hasLamel;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button exit;
        private ComboBox bedheads;
        private Label labelBedHead;
        private ComboBox responsible;
        private Label label5;
        private Label labelDecoration;
        private ComboBox decorations;
    }
}