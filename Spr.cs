using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_accounting
{
    public partial class Spr : Form
    {
        //private Form1 form1;
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Form1"];
        Database db = new Database();
        public Spr()
        {
            InitializeComponent();
            name.Text = ((Form1)f).iName;
            desc.Text = ((Form1)f).iDesc;
        }

        private void closeSpr_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Spr_Shown(object sender, EventArgs e)
        {
            error.Visible = false;
        }

        private void addSpr_Click(object sender, EventArgs e)
        {
            if (name.Text.Trim().Length == 0)
            {
                error.Visible = true;
                return;
            }
            if (addSpr.Text == "Добавить")
            {
                ((Form1)f).iName = name.Text;
                ((Form1)f).iDesc = desc.Text;
                error.Visible = false;
                if (((Form1)f).grSpr.Text == "Справочник - Виды доходов")
                {
                    db.query = "INSERT INTO spr_income ('name','desc') " +
                               "VALUES ('" + name.Text.Trim() + "','" + desc.Text.Trim() + "');";
                    db.GetData();
                    ((Form1)f).vidInToolStripMenuItem_Click(sender, e);
                    ((Form1)f).dgvSpr.CurrentCell = ((Form1)f).dgvSpr.Rows[((Form1)f).dgvSpr.Rows.Count - 1].Cells[0];
                    ((Form1)f).iRowI = ((Form1)f).dgvSpr.CurrentRow.Index;
                }
                else
                {
                    db.query = "INSERT INTO spr_expenses ('name','desc') " +
                               "VALUES ('" + name.Text.Trim() + "','" + desc.Text.Trim() + "');";
                    db.GetData();
                    ((Form1)f).vidOutToolStripMenuItem_Click(sender, e);
                    ((Form1)f).dgvSpr.CurrentCell = ((Form1)f).dgvSpr.Rows[((Form1)f).dgvSpr.Rows.Count - 1].Cells[0];
                    ((Form1)f).iRowO = ((Form1)f).dgvSpr.CurrentRow.Index;
                }
            }
            else {
                ((Form1)f).iName = name.Text;
                ((Form1)f).iDesc = desc.Text;
                error.Visible = false;
                if (((Form1)f).grSpr.Text == "Справочник - Виды доходов")
                {
                    db.query = "UPDATE spr_income SET name='" + name.Text.Trim() + "', " +
                    "desc='" + desc.Text.Trim() + "' WHERE id=" + ((Form1)f).dgvSpr.Rows[((Form1)f).iRowI].Cells[0].Value.ToString();
                    db.GetData();
                    ((Form1)f).vidInToolStripMenuItem_Click(sender, e);
                    ((Form1)f).dgvSpr.CurrentCell = ((Form1)f).dgvSpr.Rows[((Form1)f).iRowI].Cells[0];
                    ((Form1)f).iRowI = ((Form1)f).dgvSpr.CurrentRow.Index;
                }
                else
                {
                    db.query = "UPDATE spr_expenses SET name='" + name.Text.Trim() + "', " +
                    "desc='" + desc.Text.Trim() + "' WHERE id=" + ((Form1)f).dgvSpr.Rows[((Form1)f).iRowO].Cells[0].Value.ToString();
                    db.GetData();
                    ((Form1)f).vidOutToolStripMenuItem_Click(sender, e);
                    ((Form1)f).dgvSpr.CurrentCell = ((Form1)f).dgvSpr.Rows[((Form1)f).iRowO].Cells[0];
                    ((Form1)f).iRowO = ((Form1)f).dgvSpr.CurrentRow.Index;
                }
            }
            Close();
        }
    }
}
