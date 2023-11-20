namespace Home_accounting
{
    partial class Datas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            vid = new ComboBox();
            lVid = new Label();
            label2 = new Label();
            label3 = new Label();
            date = new TextBox();
            label4 = new Label();
            desc = new TextBox();
            addData = new Button();
            close = new Button();
            error = new Label();
            summa = new NumericUpDown();
            tip = new ComboBox();
            metod = new Label();
            ((System.ComponentModel.ISupportInitialize)summa).BeginInit();
            SuspendLayout();
            // 
            // vid
            // 
            vid.DropDownStyle = ComboBoxStyle.DropDownList;
            vid.FormattingEnabled = true;
            vid.Location = new Point(45, 88);
            vid.Name = "vid";
            vid.Size = new Size(325, 23);
            vid.TabIndex = 0;
            // 
            // lVid
            // 
            lVid.AutoSize = true;
            lVid.ForeColor = Color.Teal;
            lVid.Location = new Point(45, 70);
            lVid.Name = "lVid";
            lVid.Size = new Size(68, 15);
            lVid.TabIndex = 1;
            lVid.Text = "Вид дохода";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(45, 115);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Сумма";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(45, 159);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 4;
            label3.Text = "Дата";
            // 
            // date
            // 
            date.Location = new Point(44, 177);
            date.Name = "date";
            date.Size = new Size(94, 23);
            date.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(45, 204);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 6;
            label4.Text = "Описание";
            // 
            // desc
            // 
            desc.Location = new Point(45, 222);
            desc.Name = "desc";
            desc.Size = new Size(325, 23);
            desc.TabIndex = 7;
            // 
            // addData
            // 
            addData.Location = new Point(114, 257);
            addData.Name = "addData";
            addData.Size = new Size(75, 35);
            addData.TabIndex = 8;
            addData.Text = "Добавить";
            addData.UseVisualStyleBackColor = true;
            addData.Click += addData_Click;
            // 
            // close
            // 
            close.DialogResult = DialogResult.Cancel;
            close.Location = new Point(226, 257);
            close.Name = "close";
            close.Size = new Size(75, 35);
            close.TabIndex = 9;
            close.Text = "Отмена";
            close.UseVisualStyleBackColor = true;
            close.Click += button1_Click;
            // 
            // error
            // 
            error.AutoSize = true;
            error.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            error.ForeColor = Color.FromArgb(192, 0, 0);
            error.Location = new Point(46, 2);
            error.Name = "error";
            error.Size = new Size(50, 19);
            error.TabIndex = 10;
            error.Text = "label1";
            error.Visible = false;
            // 
            // summa
            // 
            summa.Location = new Point(46, 133);
            summa.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            summa.Name = "summa";
            summa.Size = new Size(92, 23);
            summa.TabIndex = 11;
            summa.TextAlign = HorizontalAlignment.Right;
            // 
            // tip
            // 
            tip.DropDownStyle = ComboBoxStyle.DropDownList;
            tip.FormattingEnabled = true;
            tip.Items.AddRange(new object[] { "Доход", "Расход" });
            tip.Location = new Point(46, 40);
            tip.Name = "tip";
            tip.Size = new Size(121, 23);
            tip.TabIndex = 12;
            tip.SelectedIndexChanged += tip_SelectedIndexChanged;
            // 
            // metod
            // 
            metod.AutoSize = true;
            metod.ForeColor = Color.Teal;
            metod.Location = new Point(46, 22);
            metod.Name = "metod";
            metod.Size = new Size(42, 15);
            metod.TabIndex = 13;
            metod.Text = "Метод";
            // 
            // Datas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 307);
            Controls.Add(metod);
            Controls.Add(tip);
            Controls.Add(summa);
            Controls.Add(error);
            Controls.Add(close);
            Controls.Add(addData);
            Controls.Add(desc);
            Controls.Add(label4);
            Controls.Add(date);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lVid);
            Controls.Add(vid);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Datas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Данные - Виды доходов - Добавление";
            ((System.ComponentModel.ISupportInitialize)summa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label metod;
        private Label lVid;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button close;
        public Button addData;
        public ComboBox vid;
        public TextBox date;
        private Label error;
        public TextBox desc;
        public NumericUpDown summa;
        public ComboBox tip;
    }
}