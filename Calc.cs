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
    public partial class Calc : Form
    {
        Database db = new Database();
        public Calc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bCalc_Click(object sender, EventArgs e)
        {
            string dstart, dfinish = "";
            int[] rez = new int[3];            
            dstart = dateStart.Value.Date.ToString().Trim().Remove(11).Trim();
            dfinish = dateEnd.Value.Date.ToString().Trim().Remove(11).Trim();
            db.query = "SELECT * FROM balance WHERE trim(date) >= '" + dstart + "' AND trim(date) <= '" + dfinish + "';";            
            rez = db.GetDataTotal();
            inc.Text = rez[0].ToString();
            exp.Text = rez[1].ToString();
            total.Text = rez[2].ToString();            
        }
    }
}
