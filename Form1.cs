using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Home_accounting
{
    public partial class Form1 : Form
    {
        public Database db = new Database();
        public String iName, iDesc = "";
        public String iNameD, iDescD, iDateD = "";

        public Int32 iRowI, iRowO, iRowAll = 0;
        public Int32 iRowId, iSumD, iId, iIdSd, iIdSO, iRowOd = 0;
        public Int32 tipInd = 0;

        public Form1()
        {
            InitializeComponent();
            filter.SelectedIndex = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.sqlite.Close();
        }

        public void incomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String text_filter = "";
            switch (filter.SelectedIndex)
            {
                case 0:
                    {
                        string day, mon, yer = "";
                        if (date.Value.Day.ToString().Length == 2)
                            day = "'" + date.Value.Day + "'";
                        else
                            day = "'0" + date.Value.Day + "'";
                        mon = "'" + date.Value.Month + "'";
                        yer = "'" + date.Value.Year + "'";

                        db.query = "SELECT * FROM balance WHERE id_incom > 0 AND " +
                            "substr(date,1,2) = " + day + " AND " +
                            "substr(date,4,2) = " + mon + " AND " +
                            "substr(date,7,4) = " + yer + ";";
                    }
                    break;
                case 1:
                    {
                        text_filter = "'" + date.Value.Month + "." + date.Value.Year + "';";
                        db.query = "SELECT * FROM balance WHERE id_incom > 0 AND substr(date,4,7) = " + text_filter;
                    }
                    break;
                case 2:
                    {
                        text_filter = "'" + date.Value.Year + "';";
                        db.query = "SELECT * FROM balance WHERE id_incom > 0 AND substr(date,7,4) = " + text_filter;
                    }
                    break;
            }
            dgvData.DataSource = db.GetData();
            dgvData.EnableHeadersVisualStyles = false;
            for (int i = 0; i < dgvData.Rows.Count; i++)
            {
                if (dgvData.Rows[i].Cells[4].Value.ToString().Trim() == "")
                {
                    dgvData.Rows[i].Cells[5].Style.ForeColor = Color.Blue;
                }
                else
                {
                    dgvData.Rows[i].Cells[5].Style.ForeColor = Color.Red;
                }
            }
            dgvData.Columns[0].HeaderText = "ID";
            dgvData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvData.Columns[1].Visible = false;
            dgvData.Columns[2].Visible = true;
            dgvData.Columns[2].HeaderText = "��� ������";
            dgvData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvData.Columns[2].Width = 200;
            dgvData.Columns[3].Visible = false;
            dgvData.Columns[4].Visible = false;
            dgvData.Columns[5].HeaderText = "�����";
            dgvData.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvData.Columns[5].DefaultCellStyle.ForeColor = Color.Blue;
            dgvData.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvData.Columns[6].HeaderText = "����";
            dgvData.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvData.Columns[7].HeaderText = "��������";
            dgvData.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grData.Text = "������ - �����";
            grSpr.Visible = false;
            grData.Visible = true;

            if (dgvData.Rows.Count > 0)
            {
                edit.Enabled = true;
                del.Enabled = true;
                dgvData.CurrentCell = dgvData.Rows[iRowId].Cells[0];
            }
            else
            {
                edit.Enabled = false;
                del.Enabled = false;
            }
        }

        public void expencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grData.Visible = true;

            String text_filter = "";
            switch (filter.SelectedIndex)
            {
                case 0:
                    {
                        string day, mon, yer = "";
                        if (date.Value.Day.ToString().Length == 2)
                            day = "'" + date.Value.Day + "'";
                        else
                            day = "'0" + date.Value.Day + "'";
                        mon = "'" + date.Value.Month + "'";
                        yer = "'" + date.Value.Year + "'";

                        db.query = "SELECT * FROM balance WHERE id_exp > 0 AND " +
                            "substr(date,1,2) = " + day + " AND " +
                            "substr(date,4,2) = " + mon + " AND " +
                            "substr(date,7,4) = " + yer + ";";
                    }
                    break;
                case 1:
                    {
                        text_filter = "'" + date.Value.Month + "." + date.Value.Year + "';";
                        db.query = "SELECT * FROM balance WHERE id_exp > 0 AND substr(date,4,7) = " + text_filter;
                    }
                    break;
                case 2:
                    {
                        text_filter = "'" + date.Value.Year + "';";
                        db.query = "SELECT * FROM balance WHERE id_exp > 0 AND substr(date,7,4) = " + text_filter;
                    }
                    break;
            }

            dgvData.DataSource = db.GetData();

            dgvData.EnableHeadersVisualStyles = false;

            for (int i = 0; i < dgvData.Rows.Count; i++)
            {
                if (dgvData.Rows[i].Cells[4].Value.ToString().Trim() == "")
                {
                    dgvData.Rows[i].Cells[5].Style.ForeColor = Color.Blue;
                }
                else
                {
                    dgvData.Rows[i].Cells[5].Style.ForeColor = Color.Red;
                }
            }

            dgvData.Columns[0].HeaderText = "ID";
            dgvData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvData.Columns[1].Visible = false;
            dgvData.Columns[2].Visible = false;
            dgvData.Columns[3].Visible = false;
            dgvData.Columns[4].Visible = true;
            dgvData.Columns[4].HeaderText = "��� �������";
            dgvData.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvData.Columns[4].Width = 200;
            dgvData.Columns[5].HeaderText = "�����";
            dgvData.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvData.Columns[5].DefaultCellStyle.ForeColor = Color.Blue;
            dgvData.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvData.Columns[6].HeaderText = "����";
            dgvData.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvData.Columns[7].HeaderText = "��������";
            dgvData.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grData.Text = "������ - ������";
            grSpr.Visible = false;
            grData.Visible = true;

            if (dgvData.Rows.Count > 0)
            {
                edit.Enabled = true;
                del.Enabled = true;
                dgvData.CurrentCell = dgvData.Rows[iRowOd].Cells[0];
            }
            else
            {
                edit.Enabled = false;
                del.Enabled = false;
            }
        }

        public void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grData.Visible = true;

            String text_filter = "";
            switch (filter.SelectedIndex)
            {
                case 0:
                    {
                        string day, mon, yer = "";
                        if (date.Value.Day.ToString().Length == 2)
                            day = "'" + date.Value.Day + "'";
                        else
                            day = "'0" + date.Value.Day + "'";
                        mon = "'" + date.Value.Month + "'";
                        yer = "'" + date.Value.Year + "'";

                        db.query = "SELECT * FROM balance WHERE " +
                            "substr(date,1,2) = " + day + " AND " +
                            "substr(date,4,2) = " + mon + " AND " +
                            "substr(date,7,4) = " + yer + ";";
                    }
                    break;
                case 1:
                    {
                        text_filter = "'" + date.Value.Month + "." + date.Value.Year + "';";
                        db.query = "SELECT * FROM balance WHERE substr(date,4,7) = " + text_filter;
                    }
                    break;
                case 2:
                    {
                        text_filter = "'" + date.Value.Year + "';";
                        db.query = "SELECT * FROM balance WHERE substr(date,7,4) = " + text_filter;
                    }
                    break;
            }

            dgvData.DataSource = db.GetData();

            dgvData.EnableHeadersVisualStyles = false;

            for (int i = 0; i < dgvData.Rows.Count; i++)
            {
                if (dgvData.Rows[i].Cells[4].Value.ToString().Trim() == "")
                {
                    dgvData.Rows[i].Cells[5].Style.ForeColor = Color.Blue;
                }
                else
                {
                    dgvData.Rows[i].Cells[5].Style.ForeColor = Color.Red;
                }
            }

            dgvData.Columns[0].HeaderText = "ID";
            dgvData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvData.Columns[1].Visible = false;
            dgvData.Columns[2].Visible = true;
            dgvData.Columns[2].HeaderText = "��� ������";
            dgvData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvData.Columns[2].Width = 200;
            dgvData.Columns[3].Visible = false;
            dgvData.Columns[4].Visible = true;
            dgvData.Columns[4].HeaderText = "��� �������";
            dgvData.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvData.Columns[4].Width = 200;
            dgvData.Columns[5].HeaderText = "�����";
            dgvData.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvData.Columns[5].DefaultCellStyle.ForeColor = Color.Blue;
            dgvData.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvData.Columns[6].HeaderText = "����";
            dgvData.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvData.Columns[7].HeaderText = "��������";
            dgvData.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grData.Text = "������ - ���";

            grSpr.Visible = false;
            grData.Visible = true;

            if (dgvData.Rows.Count > 0)
            {
                edit.Enabled = true;
                del.Enabled = true;
                dgvData.CurrentCell = dgvData.Rows[iRowAll].Cells[0];
            }
            else
            {
                edit.Enabled = false;
                del.Enabled = false;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            grData.Visible = false;
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            filter_SelectedIndexChanged(sender, e);
        }

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            String text_filter = "";
            switch (grData.Text)
            {
                case "������ - �����":
                    {
                        switch (filter.SelectedIndex)
                        {
                            case 0:
                                {
                                    string day, mon, yer = "";
                                    if (date.Value.Day.ToString().Length == 2)
                                        day = "'" + date.Value.Day + "'";
                                    else
                                        day = "'0" + date.Value.Day + "'";
                                    mon = "'" + date.Value.Month + "'";
                                    yer = "'" + date.Value.Year + "'";

                                    db.query = "SELECT * FROM balance WHERE id_incom > 0 AND " +
                                        "substr(date,1,2) = " + day + " AND " +
                                        "substr(date,4,2) = " + mon + " AND " +
                                        "substr(date,7,4) = " + yer + ";";
                                }
                                break;
                            case 1:
                                {
                                    text_filter = "'" + date.Value.Month + "." + date.Value.Year + "';";
                                    db.query = "SELECT * FROM balance WHERE id_incom > 0 AND substr(date,4,7) = " + text_filter;
                                }
                                break;
                            case 2:
                                {
                                    text_filter = "'" + date.Value.Year + "';";
                                    db.query = "SELECT * FROM balance WHERE id_incom > 0 AND substr(date,7,4) = " + text_filter;
                                }
                                break;
                        }
                    }
                    break;
                case "������ - ������":
                    {
                        switch (filter.SelectedIndex)
                        {
                            case 0:
                                {
                                    string day, mon, yer = "";
                                    if (date.Value.Day.ToString().Length == 2)
                                        day = "'" + date.Value.Day + "'";
                                    else
                                        day = "'0" + date.Value.Day + "'";
                                    mon = "'" + date.Value.Month + "'";
                                    yer = "'" + date.Value.Year + "'";

                                    db.query = "SELECT * FROM balance WHERE id_exp > 0 AND " +
                                        "substr(date,1,2) = " + day + " AND " +
                                        "substr(date,4,2) = " + mon + " AND " +
                                        "substr(date,7,4) = " + yer + ";";
                                }
                                break;
                            case 1:
                                {
                                    text_filter = "'" + date.Value.Month + "." + date.Value.Year + "';";
                                    db.query = "SELECT * FROM balance WHERE id_exp > 0 AND substr(date,4,7) = " + text_filter;
                                }
                                break;
                            case 2:
                                {
                                    text_filter = "'" + date.Value.Year + "';";
                                    db.query = "SELECT * FROM balance WHERE id_exp > 0 AND substr(date,7,4) = " + text_filter;
                                }
                                break;
                        }
                    }
                    break;
                case "������ - ���":
                    {
                        switch (filter.SelectedIndex)
                        {
                            case 0:
                                {
                                    string day, mon, yer = "";
                                    if (date.Value.Day.ToString().Length == 2)
                                        day = "'" + date.Value.Day + "'";
                                    else
                                        day = "'0" + date.Value.Day + "'";
                                    mon = "'" + date.Value.Month + "'";
                                    yer = "'" + date.Value.Year + "'";

                                    db.query = "SELECT * FROM balance WHERE " +
                                        "substr(date,1,2) = " + day + " AND " +
                                        "substr(date,4,2) = " + mon + " AND " +
                                        "substr(date,7,4) = " + yer + ";";
                                }
                                break;
                            case 1:
                                {
                                    text_filter = "'" + date.Value.Month + "." + date.Value.Year + "';";
                                    db.query = "SELECT * FROM balance WHERE substr(date,4,7) = " + text_filter;
                                }
                                break;
                            case 2:
                                {
                                    text_filter = "'" + date.Value.Year + "';";
                                    db.query = "SELECT * FROM balance WHERE substr(date,7,4) = " + text_filter;
                                }
                                break;
                        }
                    }
                    break;
                case "������":
                    {
                        db.query = "SELECT * FROM balance;";
                    }
                    break;
            }
            dgvData.DataSource = db.GetData();
            dgvData.EnableHeadersVisualStyles = false;
            for (int i = 0; i < dgvData.Rows.Count; i++)
            {
                if (dgvData.Rows[i].Cells[4].Value.ToString().Trim() == "")
                {
                    dgvData.Rows[i].Cells[5].Style.ForeColor = Color.Blue;
                }
                else
                {
                    dgvData.Rows[i].Cells[5].Style.ForeColor = Color.Red;
                }
            }
            if (dgvData.Rows.Count > 0)
            {
                edit.Enabled = true;
                del.Enabled = true;
                switch (grData.Text)
                {
                    case "������ - �����":
                        {
                            if (iRowId >= (dgvData.Rows.Count-1)) iRowId = dgvData.Rows.Count-1;
                            dgvData.CurrentCell = dgvData.Rows[iRowId].Cells[0];
                        }
                        break;
                    case "������ - ������":
                        {
                            if (iRowOd >= (dgvData.Rows.Count - 1)) iRowOd = dgvData.Rows.Count - 1;
                            dgvData.CurrentCell = dgvData.Rows[iRowOd].Cells[0];
                        }
                        break;
                    case "������ - ���":
                        {
                            if (iRowAll >= (dgvData.Rows.Count - 1)) iRowAll = dgvData.Rows.Count - 1;
                            dgvData.CurrentCell = dgvData.Rows[iRowAll].Cells[0];
                        }
                        break;
                }
            }
            else
            {
                edit.Enabled = false;
                del.Enabled = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void vidInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grData.Visible = false;
            grSpr.Text = "���������� - ���� �������";

            db.query = "SELECT * FROM spr_income";
            dgvSpr.DataSource = db.GetData();

            dgvSpr.EnableHeadersVisualStyles = false;

            dgvSpr.Columns[0].HeaderText = "ID";
            dgvSpr.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSpr.Columns[1].HeaderText = "��� ������";
            dgvSpr.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvSpr.Columns[1].Width = 200;
            dgvSpr.Columns[2].HeaderText = "��������";
            dgvSpr.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (dgvSpr.Rows.Count > 0)
            {
                editSpr.Enabled = true;
                delSpr.Enabled = true;
                dgvSpr.CurrentCell = dgvSpr.Rows[iRowI].Cells[0];
            }
            else
            {
                editSpr.Enabled = false;
                delSpr.Enabled = false;
            }
            grSpr.Visible = true;
        }

        public void vidOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grData.Visible = false;
            grSpr.Text = "���������� - ���� ��������";

            db.query = "SELECT * FROM spr_expenses";
            dgvSpr.DataSource = db.GetData();

            dgvSpr.EnableHeadersVisualStyles = false;

            dgvSpr.Columns[0].HeaderText = "ID";
            dgvSpr.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSpr.Columns[1].HeaderText = "��� �������";
            dgvSpr.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvSpr.Columns[1].Width = 200;
            dgvSpr.Columns[2].HeaderText = "��������";
            dgvSpr.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (dgvSpr.Rows.Count > 0)
            {
                editSpr.Enabled = true;
                delSpr.Enabled = true;
                dgvSpr.CurrentCell = dgvSpr.Rows[iRowO].Cells[0];
            }
            else
            {
                editSpr.Enabled = false;
                delSpr.Enabled = false;
            }

            grSpr.Visible = true;
        }

        private void closeSpr_Click(object sender, EventArgs e)
        {
            grSpr.Visible = false;
        }

        private void addSpr_Click(object sender, EventArgs e)
        {
            Spr spr = new Spr();
            if (grSpr.Text == "���������� - ���� �������")
            {
                spr.Text = "���������� - ���� ������� - ����������";
                spr.addSpr.Text = "��������";
            }
            else
            {
                spr.Text = "���������� - ���� �������� - ����������";
                spr.addSpr.Text = "��������";
            }

            spr.ShowDialog();

        }

        private void dgvSpr_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvSpr.Rows.Count > 0)
            {
                if (grSpr.Text == "���������� - ���� �������")
                    iRowI = dgvSpr.CurrentRow.Index;
                else
                    iRowO = dgvSpr.CurrentRow.Index;
            }
        }

        private void editSpr_Click(object sender, EventArgs e)
        {
            Spr spr = new Spr();
            if (grSpr.Text == "���������� - ���� �������")
            {
                iName = dgvSpr.Rows[iRowI].Cells[1].Value.ToString();
                iDesc = dgvSpr.Rows[iRowI].Cells[2].Value.ToString();
                spr.Text = "���������� - ���� ������� - ���������";
                spr.addSpr.Text = "��������";
            }
            else
            {
                iName = dgvSpr.Rows[iRowO].Cells[1].Value.ToString();
                iDesc = dgvSpr.Rows[iRowO].Cells[2].Value.ToString();
                spr.Text = "���������� - ���� �������� - ���������";
                spr.addSpr.Text = "��������";
            }
            spr.name.Text = iName;
            spr.desc.Text = iDesc;
            spr.ShowDialog();
        }

        private void delSpr_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("������� ������� ������?", "��������", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                if (grSpr.Text == "���������� - ���� �������")
                {
                    db.query = "DELETE FROM spr_income WHERE id=" + dgvSpr.Rows[iRowI].Cells[0].Value.ToString();
                    if (iRowI > 0)
                    {
                        if (dgvSpr.Rows.Count - 1 <= iRowI && dgvSpr.Rows.Count - 1 > 0)
                        {
                            iRowI--;
                        }
                    }
                    dgvSpr.DataSource = db.GetData();
                    vidInToolStripMenuItem_Click(sender, e);
                }
                else
                {
                    db.query = "DELETE FROM spr_expenses WHERE id=" + dgvSpr.Rows[iRowO].Cells[0].Value.ToString();
                    if (iRowO > 0)
                    {
                        if (dgvSpr.Rows.Count - 1 <= iRowO && dgvSpr.Rows.Count - 1 > 0)
                        {
                            iRowO--;
                        }
                    }
                    dgvSpr.DataSource = db.GetData();
                    vidOutToolStripMenuItem_Click(sender, e);
                }

                if (dgvSpr.Rows.Count > 0)
                {
                    if (grSpr.Text == "���������� - ���� �������")
                        dgvSpr.CurrentCell = dgvSpr.Rows[iRowI].Cells[0];
                    else
                        dgvSpr.CurrentCell = dgvSpr.Rows[iRowO].Cells[0];
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            Datas datas = new Datas();
            if (grData.Text == "������ - �����")
            {
                datas.Text = "������ - ���� ������� - ����������";
                datas.addData.Text = "��������";
                db.query = "SELECT id,name FROM spr_income";
                db.GetDataCombo(ref datas.vid);
                if (datas.vid.Items.Count == 0)
                {
                    MessageBox.Show("���������� - ���� ������� - ����!!! \n��������� ���!!!");
                    return;
                }
                datas.vid.SelectedIndex = 0;
                datas.tip.Enabled = false;
                datas.tip.SelectedIndex = 0;
            }
            else if (grData.Text == "������ - ������")
            {
                datas.Text = "������ - ���� �������� - ����������";
                datas.addData.Text = "��������";
                db.query = "SELECT id,name FROM spr_expenses";
                db.GetDataCombo(ref datas.vid);
                if (datas.vid.Items.Count == 0)
                {
                    MessageBox.Show("���������� - ���� �������� - ����!!! \n��������� ���!!!");
                    return;
                }
                datas.vid.SelectedIndex = 0;
                datas.tip.Enabled = false;
                datas.tip.SelectedIndex = 1;
            }
            else if (grData.Text == "������ - ���")
            {
                datas.Text = "������ - ��� - ����������";
                datas.addData.Text = "��������";
                db.query = "SELECT id,name FROM spr_income";
                db.GetDataCombo(ref datas.vid);
                if (datas.vid.Items.Count == 0)
                {
                    MessageBox.Show("���������� - ���� ������� - ����!!! \n��������� ���!!!");
                    return;
                }
                db.query = "SELECT id,name FROM spr_expenses";
                db.GetDataCombo(ref datas.vid);
                if (datas.vid.Items.Count == 0)
                {
                    MessageBox.Show("���������� - ���� �������� - ����!!! \n��������� ���!!!");
                    return;
                }
                db.query = "SELECT id,name FROM spr_income";
                db.GetDataCombo(ref datas.vid);
                datas.vid.SelectedIndex = 0;
                datas.tip.Enabled = true;
                datas.tip.SelectedIndex = tipInd;
            }
            datas.date.Text = date.Value.Date.ToString().Remove(11).Trim();
            datas.ShowDialog();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            Datas datas = new Datas();
            if (grData.Text == "������ - �����")
            {
                iId = Int32.Parse(dgvData.Rows[iRowId].Cells[0].Value.ToString());
                iIdSd = Int32.Parse(dgvData.Rows[iRowId].Cells[1].Value.ToString());
                iNameD = dgvData.Rows[iRowId].Cells[2].Value.ToString();
                iSumD = Int32.Parse(dgvData.Rows[iRowId].Cells[5].Value.ToString().Trim());
                iDateD = dgvData.Rows[iRowId].Cells[6].Value.ToString();
                iDescD = dgvData.Rows[iRowId].Cells[7].Value.ToString();
                datas.Text = "������ - ���� ������� - ���������";
                datas.addData.Text = "��������";
                db.query = "SELECT id,name FROM spr_income";
                db.GetDataCombo(ref datas.vid);
                if (datas.vid.Items.Count == 0)
                {
                    MessageBox.Show("���������� - ���� ������� - ����!!! \n��������� ���!!!");
                    return;
                }
                int i = 0;
                foreach (DataRowView item in datas.vid.Items)
                {
                    if (item.Row[1].ToString() == iNameD) datas.vid.SelectedIndex = i;
                    i++;
                }
                datas.tip.Enabled = false;
                datas.tip.SelectedIndex = 0;
                datas.summa.Value = iSumD;
                datas.date.Text = iDateD;
                datas.desc.Text = iDescD;
            }
            else if (grData.Text == "������ - ������")
            {
                iId = Int32.Parse(dgvData.Rows[iRowOd].Cells[0].Value.ToString());
                iIdSd = Int32.Parse(dgvData.Rows[iRowOd].Cells[3].Value.ToString());
                iNameD = dgvData.Rows[iRowOd].Cells[4].Value.ToString();
                iSumD = Int32.Parse(dgvData.Rows[iRowOd].Cells[5].Value.ToString().Trim());
                iDateD = dgvData.Rows[iRowOd].Cells[6].Value.ToString();
                iDescD = dgvData.Rows[iRowOd].Cells[7].Value.ToString();
                datas.Text = "������ - ���� �������� - ���������";
                datas.addData.Text = "��������";
                db.query = "SELECT id,name FROM spr_expenses";
                db.GetDataCombo(ref datas.vid);
                if (datas.vid.Items.Count == 0)
                {
                    MessageBox.Show("���������� - ���� �������� - ����!!! \n��������� ���!!!");
                    return;
                }
                int i = 0;
                foreach (DataRowView item in datas.vid.Items)
                {
                    if (item.Row[1].ToString() == iNameD) datas.vid.SelectedIndex = i;
                    i++;
                }
                datas.tip.Enabled = false;
                datas.tip.SelectedIndex = 1;
                datas.summa.Value = iSumD;
                datas.date.Text = iDateD;
                datas.desc.Text = iDescD;
            }
            else if (grData.Text == "������ - ���")
            {
                iId = Int32.Parse(dgvData.Rows[iRowAll].Cells[0].Value.ToString());

                if (dgvData.Rows[iRowAll].Cells[1].Value.ToString().Trim() != "")
                {
                    iIdSd = Int32.Parse(dgvData.Rows[iRowAll].Cells[1].Value.ToString());
                    iNameD = dgvData.Rows[iRowAll].Cells[2].Value.ToString();
                }
                else
                {
                    iIdSd = Int32.Parse(dgvData.Rows[iRowAll].Cells[3].Value.ToString());
                    iNameD = dgvData.Rows[iRowAll].Cells[4].Value.ToString();
                }
                iSumD = Int32.Parse(dgvData.Rows[iRowAll].Cells[5].Value.ToString().Trim());
                iDateD = dgvData.Rows[iRowAll].Cells[6].Value.ToString();
                iDescD = dgvData.Rows[iRowAll].Cells[7].Value.ToString();
                datas.Text = "������ - ��� - ���������";
                datas.addData.Text = "��������";
                db.query = "SELECT id,name FROM spr_income";
                db.GetDataCombo(ref datas.vid);
                if (datas.vid.Items.Count == 0)
                {
                    MessageBox.Show("���������� - ���� ������� - ����!!! \n��������� ���!!!");
                    return;
                }
                db.query = "SELECT id,name FROM spr_expenses";
                db.GetDataCombo(ref datas.vid);
                if (datas.vid.Items.Count == 0)
                {
                    MessageBox.Show("���������� - ���� �������� - ����!!! \n��������� ���!!!");
                    return;
                }
                if (dgvData.Rows[iRowAll].Cells[1].Value.ToString().Trim() != "")
                {
                    tipInd = 0;
                    db.query = "SELECT id,name FROM spr_income";
                    db.GetDataCombo(ref datas.vid);
                    datas.tip.SelectedIndex = tipInd;
                }
                else if (dgvData.Rows[iRowAll].Cells[3].Value.ToString().Trim() != "")
                {
                    tipInd = 1;
                    db.query = "SELECT id,name FROM spr_expenses";
                    db.GetDataCombo(ref datas.vid);
                    datas.tip.SelectedIndex = tipInd;
                }

                int i = 0;
                foreach (DataRowView item in datas.vid.Items)
                {
                    if (item.Row[1].ToString() == iNameD) datas.vid.SelectedIndex = i;
                    i++;
                }
                datas.tip.Enabled = true;
                datas.summa.Value = iSumD;
                datas.date.Text = iDateD;
                datas.desc.Text = iDescD;
            }
            datas.ShowDialog();
        }

        private void dgvData_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvData.Rows.Count > 0)
            {
                switch (grData.Text)
                {
                    case "������ - �����":
                        {
                            iRowId = dgvData.CurrentRow.Index;
                        }
                        break;
                    case "������ - ������":
                        {
                            iRowOd = dgvData.CurrentRow.Index;
                        }
                        break;
                    case "������ - ���":
                        {
                            iRowAll = dgvData.CurrentRow.Index;
                        }
                        break;
                }
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("������� ������� ������?", "��������", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                if (grData.Text == "������ - �����")
                {
                    db.query = "DELETE FROM balance WHERE id=" + dgvData.Rows[iRowId].Cells[0].Value.ToString();
                    if (iRowId > 0)
                    {
                        if (dgvData.Rows.Count - 1 <= iRowId && dgvData.Rows.Count - 1 > 0)
                        {
                            iRowId--;
                        }
                    }
                    dgvData.DataSource = db.GetData();
                    incomToolStripMenuItem_Click(sender, e);
                }
                else if (grData.Text == "������ - ������")
                {
                    db.query = "DELETE FROM balance WHERE id=" + dgvData.Rows[iRowOd].Cells[0].Value.ToString();
                    if (iRowOd > 0)
                    {
                        if (dgvData.Rows.Count - 1 <= iRowOd && dgvData.Rows.Count - 1 > 0)
                        {
                            iRowOd--;
                        }
                    }
                    dgvData.DataSource = db.GetData();
                    expencesToolStripMenuItem_Click(sender, e);
                }
                else if (grData.Text == "������ - ���")
                {
                    db.query = "DELETE FROM balance WHERE id=" + dgvData.Rows[iRowAll].Cells[0].Value.ToString();
                    if (iRowAll > 0)
                    {
                        if (dgvData.Rows.Count - 1 <= iRowAll && dgvData.Rows.Count - 1 > 0)
                        {
                            iRowAll--;
                        }
                    }
                    dgvData.DataSource = db.GetData();
                    allToolStripMenuItem_Click(sender, e);
                }

                if (dgvData.Rows.Count > 0)
                {
                    switch (grData.Text)
                    {
                        case "������ - �����":
                            {
                                iRowId = dgvData.CurrentRow.Index;
                            }
                            break;
                        case "������ - ������":
                            {
                                iRowOd = dgvData.CurrentRow.Index;
                            }
                            break;
                        case "������ - ���":
                            {
                                iRowAll = dgvData.CurrentRow.Index;
                            }
                            break;
                    }
                }
            }
        }

        private void calcMonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calcPerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calc calc = new Calc();
            calc.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.createTables();
        }
    }

}
