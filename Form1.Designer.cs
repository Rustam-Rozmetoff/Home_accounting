namespace Home_accounting
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mainMenu = new MenuStrip();
            datasToolStripMenuItem = new ToolStripMenuItem();
            incomToolStripMenuItem = new ToolStripMenuItem();
            expencesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            allToolStripMenuItem = new ToolStripMenuItem();
            sprsToolStripMenuItem = new ToolStripMenuItem();
            vidInToolStripMenuItem = new ToolStripMenuItem();
            vidOutToolStripMenuItem = new ToolStripMenuItem();
            calcToolStripMenuItem = new ToolStripMenuItem();
            calcPerToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            grData = new GroupBox();
            label3 = new Label();
            filter = new ComboBox();
            close = new Button();
            del = new Button();
            edit = new Button();
            add = new Button();
            dgvData = new DataGridView();
            date = new DateTimePicker();
            label2 = new Label();
            grSpr = new GroupBox();
            closeSpr = new Button();
            delSpr = new Button();
            editSpr = new Button();
            addSpr = new Button();
            dgvSpr = new DataGridView();
            mainMenu.SuspendLayout();
            grData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            grSpr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSpr).BeginInit();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.Items.AddRange(new ToolStripItem[] { datasToolStripMenuItem, sprsToolStripMenuItem, calcToolStripMenuItem, exitToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(830, 24);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "menuStrip1";
            // 
            // datasToolStripMenuItem
            // 
            datasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { incomToolStripMenuItem, expencesToolStripMenuItem, toolStripSeparator1, allToolStripMenuItem });
            datasToolStripMenuItem.Name = "datasToolStripMenuItem";
            datasToolStripMenuItem.Size = new Size(62, 20);
            datasToolStripMenuItem.Text = "Данные";
            // 
            // incomToolStripMenuItem
            // 
            incomToolStripMenuItem.Name = "incomToolStripMenuItem";
            incomToolStripMenuItem.Size = new Size(112, 22);
            incomToolStripMenuItem.Text = "Доход";
            incomToolStripMenuItem.Click += incomToolStripMenuItem_Click;
            // 
            // expencesToolStripMenuItem
            // 
            expencesToolStripMenuItem.Name = "expencesToolStripMenuItem";
            expencesToolStripMenuItem.Size = new Size(112, 22);
            expencesToolStripMenuItem.Text = "Расход";
            expencesToolStripMenuItem.Click += expencesToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(109, 6);
            // 
            // allToolStripMenuItem
            // 
            allToolStripMenuItem.Name = "allToolStripMenuItem";
            allToolStripMenuItem.Size = new Size(112, 22);
            allToolStripMenuItem.Text = "Все";
            allToolStripMenuItem.Click += allToolStripMenuItem_Click;
            // 
            // sprsToolStripMenuItem
            // 
            sprsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vidInToolStripMenuItem, vidOutToolStripMenuItem });
            sprsToolStripMenuItem.Name = "sprsToolStripMenuItem";
            sprsToolStripMenuItem.Size = new Size(94, 20);
            sprsToolStripMenuItem.Text = "Справочники";
            // 
            // vidInToolStripMenuItem
            // 
            vidInToolStripMenuItem.Name = "vidInToolStripMenuItem";
            vidInToolStripMenuItem.Size = new Size(157, 22);
            vidInToolStripMenuItem.Text = "Виды доходов";
            vidInToolStripMenuItem.Click += vidInToolStripMenuItem_Click;
            // 
            // vidOutToolStripMenuItem
            // 
            vidOutToolStripMenuItem.Name = "vidOutToolStripMenuItem";
            vidOutToolStripMenuItem.Size = new Size(157, 22);
            vidOutToolStripMenuItem.Text = "Виды расходов";
            vidOutToolStripMenuItem.Click += vidOutToolStripMenuItem_Click;
            // 
            // calcToolStripMenuItem
            // 
            calcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calcPerToolStripMenuItem });
            calcToolStripMenuItem.Name = "calcToolStripMenuItem";
            calcToolStripMenuItem.Size = new Size(56, 20);
            calcToolStripMenuItem.Text = "Расчёт";
            // 
            // calcPerToolStripMenuItem
            // 
            calcPerToolStripMenuItem.Name = "calcPerToolStripMenuItem";
            calcPerToolStripMenuItem.Size = new Size(168, 22);
            calcPerToolStripMenuItem.Text = "Расчёт за период";
            calcPerToolStripMenuItem.Click += calcPerToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(54, 20);
            exitToolStripMenuItem.Text = "Выход";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(133, 38);
            label1.Name = "label1";
            label1.Size = new Size(456, 39);
            label1.TabIndex = 1;
            label1.Text = "Домашняя бухгалтерия v 1.0";
            // 
            // grData
            // 
            grData.Controls.Add(label3);
            grData.Controls.Add(filter);
            grData.Controls.Add(close);
            grData.Controls.Add(del);
            grData.Controls.Add(edit);
            grData.Controls.Add(add);
            grData.Controls.Add(dgvData);
            grData.Location = new Point(12, 94);
            grData.Name = "grData";
            grData.Size = new Size(806, 395);
            grData.TabIndex = 2;
            grData.TabStop = false;
            grData.Text = "Данные";
            grData.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(644, 16);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 6;
            label3.Text = "Фильтр";
            // 
            // filter
            // 
            filter.DropDownStyle = ComboBoxStyle.DropDownList;
            filter.FormattingEnabled = true;
            filter.Items.AddRange(new object[] { "Дате", "Месяц", "Год" });
            filter.Location = new Point(695, 12);
            filter.Name = "filter";
            filter.Size = new Size(96, 23);
            filter.TabIndex = 5;
            filter.SelectedIndexChanged += filter_SelectedIndexChanged;
            // 
            // close
            // 
            close.Location = new Point(502, 339);
            close.Name = "close";
            close.Size = new Size(75, 40);
            close.TabIndex = 4;
            close.Text = "Скрыть";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // del
            // 
            del.Enabled = false;
            del.Location = new Point(407, 339);
            del.Name = "del";
            del.Size = new Size(75, 40);
            del.TabIndex = 3;
            del.Text = "Удалить";
            del.UseVisualStyleBackColor = true;
            del.Click += del_Click;
            // 
            // edit
            // 
            edit.Enabled = false;
            edit.Location = new Point(311, 339);
            edit.Name = "edit";
            edit.Size = new Size(75, 40);
            edit.TabIndex = 2;
            edit.Text = "Изменить";
            edit.UseVisualStyleBackColor = true;
            edit.Click += edit_Click;
            // 
            // add
            // 
            add.Location = new Point(216, 339);
            add.Name = "add";
            add.Size = new Size(75, 40);
            add.TabIndex = 1;
            add.Text = "Добавить";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.AllowUserToResizeColumns = false;
            dgvData.AllowUserToResizeRows = false;
            dgvData.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(15, 41);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersVisible = false;
            dgvData.RowTemplate.ReadOnly = true;
            dgvData.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.Size = new Size(776, 278);
            dgvData.StandardTab = true;
            dgvData.TabIndex = 0;
            dgvData.MouseClick += dgvData_MouseClick;
            // 
            // date
            // 
            date.Location = new Point(676, 54);
            date.Name = "date";
            date.Size = new Size(142, 23);
            date.TabIndex = 5;
            date.ValueChanged += date_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(786, 36);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 7;
            label2.Text = "Дата";
            // 
            // grSpr
            // 
            grSpr.Controls.Add(closeSpr);
            grSpr.Controls.Add(delSpr);
            grSpr.Controls.Add(editSpr);
            grSpr.Controls.Add(addSpr);
            grSpr.Controls.Add(dgvSpr);
            grSpr.Location = new Point(115, 85);
            grSpr.Name = "grSpr";
            grSpr.Size = new Size(605, 395);
            grSpr.TabIndex = 8;
            grSpr.TabStop = false;
            grSpr.Text = "Справочник - Виды доходов";
            grSpr.Visible = false;
            // 
            // closeSpr
            // 
            closeSpr.Location = new Point(399, 339);
            closeSpr.Name = "closeSpr";
            closeSpr.Size = new Size(75, 40);
            closeSpr.TabIndex = 8;
            closeSpr.Text = "Скрыть";
            closeSpr.UseVisualStyleBackColor = true;
            closeSpr.Click += closeSpr_Click;
            // 
            // delSpr
            // 
            delSpr.Enabled = false;
            delSpr.Location = new Point(304, 339);
            delSpr.Name = "delSpr";
            delSpr.Size = new Size(75, 40);
            delSpr.TabIndex = 7;
            delSpr.Text = "Удалить";
            delSpr.UseVisualStyleBackColor = true;
            delSpr.Click += delSpr_Click;
            // 
            // editSpr
            // 
            editSpr.Enabled = false;
            editSpr.Location = new Point(208, 339);
            editSpr.Name = "editSpr";
            editSpr.Size = new Size(75, 40);
            editSpr.TabIndex = 6;
            editSpr.Text = "Изменить";
            editSpr.UseVisualStyleBackColor = true;
            editSpr.Click += editSpr_Click;
            // 
            // addSpr
            // 
            addSpr.Location = new Point(113, 339);
            addSpr.Name = "addSpr";
            addSpr.Size = new Size(75, 40);
            addSpr.TabIndex = 5;
            addSpr.Text = "Добавить";
            addSpr.UseVisualStyleBackColor = true;
            addSpr.Click += addSpr_Click;
            // 
            // dgvSpr
            // 
            dgvSpr.AllowUserToAddRows = false;
            dgvSpr.AllowUserToDeleteRows = false;
            dgvSpr.AllowUserToResizeColumns = false;
            dgvSpr.AllowUserToResizeRows = false;
            dgvSpr.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSpr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSpr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSpr.Location = new Point(16, 41);
            dgvSpr.MultiSelect = false;
            dgvSpr.Name = "dgvSpr";
            dgvSpr.ReadOnly = true;
            dgvSpr.RowHeadersVisible = false;
            dgvSpr.RowTemplate.ReadOnly = true;
            dgvSpr.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvSpr.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSpr.Size = new Size(573, 278);
            dgvSpr.StandardTab = true;
            dgvSpr.TabIndex = 2;
            dgvSpr.MouseClick += dgvSpr_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 501);
            Controls.Add(label2);
            Controls.Add(date);
            Controls.Add(label1);
            Controls.Add(mainMenu);
            Controls.Add(grData);
            Controls.Add(grSpr);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mainMenu;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Домашняя бухгалтерия";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            grData.ResumeLayout(false);
            grData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            grSpr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSpr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem datasToolStripMenuItem;
        private ToolStripMenuItem incomToolStripMenuItem;
        private ToolStripMenuItem expencesToolStripMenuItem;
        private ToolStripMenuItem sprsToolStripMenuItem;
        private ToolStripMenuItem vidInToolStripMenuItem;
        private ToolStripMenuItem vidOutToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem calcToolStripMenuItem;
        private ToolStripMenuItem calcPerToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private DataGridViewTextBoxColumn selectCommandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn insertCommandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updateCommandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn deleteCommandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updateBatchSizeDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn acceptChangesDuringFillDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn acceptChangesDuringUpdateDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn continueUpdateOnErrorDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn fillLoadOptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn missingMappingActionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn missingSchemaActionDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn returnProviderSpecificTypesDataGridViewCheckBoxColumn;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem allToolStripMenuItem;
        private Button close;
        private Button del;
        private Button edit;
        private Button add;
        private DateTimePicker date;
        private ComboBox filter;
        private Label label3;
        private Label label2;
        public DataGridView dgvSpr;
        private Button closeSpr;
        private Button delSpr;
        private Button editSpr;
        private Button addSpr;
        public GroupBox grSpr;
        public DataGridView dgvData;
        public GroupBox grData;
    }
}
