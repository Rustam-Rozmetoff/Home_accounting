using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Home_accounting
{
    public partial class Datas : Form
    {
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Form1"];
        Database db = new Database();
        public Datas()
        {
            InitializeComponent();
            tip.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addData_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(summa.Text.Trim()) <= 0)
            {
                error.Text = "СУММА должна быть числом и больше нуля!!!";
                error.Visible = true;
                summa.Focus();
                return;
            }
            if (date.Text.Trim().Length <= 0)
            {
                error.Text = "Заполните поле ДАТА!!!";
                error.Visible = true;
                date.Focus();
                return;
            }
            error.Visible = false;
            if (((Form1)f).grData.Text == "Данные - Доход")
            {
                if (addData.Text == "Добавить")
                {
                    db.query = "INSERT INTO balance (id_incom, name_incom, summa, date, desc) " +
                            "VALUES (" + vid.SelectedValue + ",'" + vid.Text + "', " +
                            summa.Value + ", '" + date.Text.Trim() + "', '" + desc.Text.Trim() + "');";
                    db.GetData();
                    ((Form1)f).incomToolStripMenuItem_Click(sender, e);
                    ((Form1)f).dgvData.CurrentCell = ((Form1)f).dgvData.Rows[((Form1)f).dgvData.Rows.Count - 1].Cells[0];
                    ((Form1)f).iRowId = ((Form1)f).dgvData.CurrentRow.Index;
                }
                else
                {
                    db.query = "UPDATE balance SET " +
                        "id_incom = " + vid.SelectedValue + "," +
                        "name_incom = '" + vid.Text + "', " +
                        "summa = " + summa.Value + ", " +
                        "date = '" + date.Text.Trim() + "', " +
                        "desc = '" + desc.Text.Trim() + "' WHERE id=" + ((Form1)f).iId + ";";
                    db.GetData();
                    ((Form1)f).incomToolStripMenuItem_Click(sender, e);
                    ((Form1)f).dgvData.CurrentCell = ((Form1)f).dgvData.Rows[((Form1)f).dgvData.Rows.Count - 1].Cells[0];
                    ((Form1)f).iRowId = ((Form1)f).dgvData.CurrentRow.Index;
                }

            }
            else if (((Form1)f).grData.Text == "Данные - Расход")
            {
                if (addData.Text == "Добавить")
                {
                    db.query = "INSERT INTO balance (id_exp, name_exp, summa, date, desc) " +
                            "VALUES (" + vid.SelectedValue + ",'" + vid.Text + "', " +
                            summa.Value + ", '" + date.Text.Trim() + "', '" + desc.Text.Trim() + "');";
                    db.GetData();
                    ((Form1)f).expencesToolStripMenuItem_Click(sender, e);
                    ((Form1)f).dgvData.CurrentCell = ((Form1)f).dgvData.Rows[((Form1)f).dgvData.Rows.Count - 1].Cells[0];
                    ((Form1)f).iRowOd = ((Form1)f).dgvData.CurrentRow.Index;
                }
                else
                {
                    db.query = "UPDATE balance SET " +
                        "id_exp = " + vid.SelectedValue + "," +
                        "name_exp = '" + vid.Text + "', " +
                        "summa = " + summa.Value + ", " +
                        "date = '" + date.Text.Trim() + "', " +
                        "desc = '" + desc.Text.Trim() + "' WHERE id=" + ((Form1)f).iId + ";";
                    db.GetData();
                    ((Form1)f).expencesToolStripMenuItem_Click(sender, e);
                    ((Form1)f).dgvData.CurrentCell = ((Form1)f).dgvData.Rows[((Form1)f).dgvData.Rows.Count - 1].Cells[0];
                    ((Form1)f).iRowOd = ((Form1)f).dgvData.CurrentRow.Index;
                }
            }
            else if (((Form1)f).grData.Text == "Данные - Все")
            {
                if (addData.Text == "Добавить")
                {
                    if (tip.SelectedIndex == 0)
                    {
                        db.query = "INSERT INTO balance (id_incom, name_incom, summa, date, desc) " +
                            "VALUES (" + vid.SelectedValue + ",'" + vid.Text + "', " +
                            summa.Value + ", '" + date.Text.Trim() + "', '" + desc.Text.Trim() + "');";
                    } else
                    {
                        db.query = "INSERT INTO balance (id_exp, name_exp, summa, date, desc) " +
                            "VALUES (" + vid.SelectedValue + ",'" + vid.Text + "', " +
                            summa.Value + ", '" + date.Text.Trim() + "', '" + desc.Text.Trim() + "');";
                    }
                    
                    db.GetData();
                    ((Form1)f).allToolStripMenuItem_Click(sender, e);
                    ((Form1)f).dgvData.CurrentCell = ((Form1)f).dgvData.Rows[((Form1)f).dgvData.Rows.Count - 1].Cells[0];
                    ((Form1)f).iRowAll = ((Form1)f).dgvData.CurrentRow.Index;
                }
                else
                {
                    if (tip.SelectedIndex == 0)
                    {
                        db.query = "UPDATE balance SET " +
                            "id_incom = " + vid.SelectedValue + "," +
                            "name_incom = '" + vid.Text + "', " +
                            "id_exp = NULL," +
                            "name_exp = '', " +
                            "summa = " + summa.Value + ", " +
                            "date = '" + date.Text.Trim() + "', " +
                            "desc = '" + desc.Text.Trim() + "' WHERE id=" + ((Form1)f).iId + ";";
                    } else
                    {
                        db.query = "UPDATE balance SET " +
                            "id_incom = NULL, " +
                            "name_incom = '', " +
                            "id_exp = " + vid.SelectedValue + "," +
                            "name_exp = '" + vid.Text + "', " +
                            "summa = " + summa.Value + ", " +
                            "date = '" + date.Text.Trim() + "', " +
                            "desc = '" + desc.Text.Trim() + "' WHERE id=" + ((Form1)f).iId + ";";
                    }                        
                    db.GetData();
                    ((Form1)f).allToolStripMenuItem_Click(sender, e);
                    ((Form1)f).dgvData.CurrentCell = ((Form1)f).dgvData.Rows[((Form1)f).dgvData.Rows.Count - 1].Cells[0];
                    ((Form1)f).iRowAll = ((Form1)f).dgvData.CurrentRow.Index;
                }
            }
            ((Form1)f).tipInd = tip.SelectedIndex;
            Close();
        }

        private void tip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tip.Text == "Доход")
            {
                lVid.Text = "Вид дохода";
                db.query = "SELECT id,name FROM spr_income";
                db.GetDataCombo(ref vid);
            }                
            else
            {
                lVid.Text = "Вид расхода";
                db.query = "SELECT id,name FROM spr_expenses";
                db.GetDataCombo(ref vid);
            }
            vid.SelectedIndex = 0;
        }
    }
}
