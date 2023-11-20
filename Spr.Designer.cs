namespace Home_accounting
{
    partial class Spr
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
            label1 = new Label();
            name = new TextBox();
            desc = new TextBox();
            label2 = new Label();
            addSpr = new Button();
            closeSpr = new Button();
            error = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(22, 24);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Вид дохода";
            // 
            // name
            // 
            name.Location = new Point(22, 42);
            name.Name = "name";
            name.Size = new Size(353, 23);
            name.TabIndex = 1;
            // 
            // desc
            // 
            desc.Location = new Point(22, 96);
            desc.Name = "desc";
            desc.Size = new Size(353, 23);
            desc.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(22, 78);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Описание";
            // 
            // addSpr
            // 
            addSpr.Location = new Point(108, 136);
            addSpr.Name = "addSpr";
            addSpr.Size = new Size(75, 40);
            addSpr.TabIndex = 4;
            addSpr.Text = "Добавить";
            addSpr.UseVisualStyleBackColor = true;
            addSpr.Click += addSpr_Click;
            // 
            // closeSpr
            // 
            closeSpr.Location = new Point(221, 136);
            closeSpr.Name = "closeSpr";
            closeSpr.Size = new Size(75, 40);
            closeSpr.TabIndex = 5;
            closeSpr.Text = "Отмена";
            closeSpr.UseVisualStyleBackColor = true;
            closeSpr.Click += closeSpr_Click;
            // 
            // error
            // 
            error.AutoSize = true;
            error.ForeColor = Color.FromArgb(192, 0, 0);
            error.Location = new Point(96, 24);
            error.Name = "error";
            error.Size = new Size(245, 15);
            error.TabIndex = 6;
            error.Text = "Поле вид дохода не должно быть пустым!!!";
            error.Visible = false;
            // 
            // Spr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 192);
            Controls.Add(error);
            Controls.Add(closeSpr);
            Controls.Add(addSpr);
            Controls.Add(desc);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Spr";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Справочник - Виды доходов - Добавление";
            Shown += Spr_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button closeSpr;
        private Label error;
        public TextBox name;
        public TextBox desc;
        public Button addSpr;
    }
}