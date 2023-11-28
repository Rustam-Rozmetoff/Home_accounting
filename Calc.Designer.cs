namespace Home_accounting
{
    partial class Calc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calc));
            dateStart = new DateTimePicker();
            dateEnd = new DateTimePicker();
            lPer = new Label();
            lC = new Label();
            lPo = new Label();
            panel1 = new Panel();
            total = new Label();
            exp = new Label();
            inc = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            bCalc = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dateStart
            // 
            dateStart.Location = new Point(34, 34);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(146, 23);
            dateStart.TabIndex = 0;
            // 
            // dateEnd
            // 
            dateEnd.Location = new Point(216, 34);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(146, 23);
            dateEnd.TabIndex = 1;
            // 
            // lPer
            // 
            lPer.AutoSize = true;
            lPer.Font = new Font("Times New Roman", 14.25F);
            lPer.ForeColor = Color.Navy;
            lPer.Location = new Point(160, 5);
            lPer.Name = "lPer";
            lPer.Size = new Size(70, 21);
            lPer.TabIndex = 2;
            lPer.Text = "Период";
            // 
            // lC
            // 
            lC.AutoSize = true;
            lC.ForeColor = Color.Teal;
            lC.Location = new Point(12, 40);
            lC.Name = "lC";
            lC.Size = new Size(13, 15);
            lC.TabIndex = 3;
            lC.Text = "с";
            // 
            // lPo
            // 
            lPo.AutoSize = true;
            lPo.ForeColor = Color.Teal;
            lPo.Location = new Point(188, 40);
            lPo.Name = "lPo";
            lPo.Size = new Size(21, 15);
            lPo.TabIndex = 4;
            lPo.Text = "по";
            // 
            // panel1
            // 
            panel1.Controls.Add(total);
            panel1.Controls.Add(exp);
            panel1.Controls.Add(inc);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(21, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 100);
            panel1.TabIndex = 5;
            // 
            // total
            // 
            total.BorderStyle = BorderStyle.Fixed3D;
            total.Font = new Font("Times New Roman", 14.25F);
            total.ForeColor = Color.Green;
            total.Location = new Point(146, 70);
            total.Name = "total";
            total.Size = new Size(150, 21);
            total.TabIndex = 8;
            total.Text = "0";
            total.TextAlign = ContentAlignment.MiddleRight;
            // 
            // exp
            // 
            exp.BorderStyle = BorderStyle.Fixed3D;
            exp.Font = new Font("Times New Roman", 14.25F);
            exp.ForeColor = Color.Maroon;
            exp.Location = new Point(146, 40);
            exp.Name = "exp";
            exp.Size = new Size(150, 21);
            exp.TabIndex = 7;
            exp.Text = "0";
            exp.TextAlign = ContentAlignment.MiddleRight;
            // 
            // inc
            // 
            inc.BorderStyle = BorderStyle.Fixed3D;
            inc.Font = new Font("Times New Roman", 14.25F);
            inc.ForeColor = Color.Navy;
            inc.Location = new Point(146, 10);
            inc.Name = "inc";
            inc.Size = new Size(150, 21);
            inc.TabIndex = 6;
            inc.Text = "0";
            inc.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(37, 72);
            label6.Name = "label6";
            label6.Size = new Size(63, 21);
            label6.TabIndex = 5;
            label6.Text = "Итого:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(37, 42);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 4;
            label5.Text = "Расход";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(37, 12);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 3;
            label4.Text = "Доход";
            // 
            // bCalc
            // 
            bCalc.Font = new Font("Segoe UI", 10F);
            bCalc.Location = new Point(95, 178);
            bCalc.Name = "bCalc";
            bCalc.Size = new Size(88, 35);
            bCalc.TabIndex = 6;
            bCalc.Text = "Расчитать";
            bCalc.UseVisualStyleBackColor = true;
            bCalc.Click += bCalc_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(205, 178);
            button1.Name = "button1";
            button1.Size = new Size(88, 35);
            button1.TabIndex = 7;
            button1.Text = "Закрыть";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Calc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 226);
            Controls.Add(button1);
            Controls.Add(bCalc);
            Controls.Add(panel1);
            Controls.Add(lPo);
            Controls.Add(lC);
            Controls.Add(lPer);
            Controls.Add(dateEnd);
            Controls.Add(dateStart);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Calc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Расчёт";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        public Label total;
        public Label exp;
        public Label inc;
        private Button bCalc;
        private Button button1;
        public DateTimePicker dateStart;
        public DateTimePicker dateEnd;
        public Label lPer;
        public Label lC;
        public Label lPo;
    }
}