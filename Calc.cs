using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
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
            inc.Text = formateString( rez[0].ToString() );
            exp.Text = formateString( rez[1].ToString() );
            total.Text = formateString(rez[2].ToString() );            
        }

        private String formateString(String s1)
        {
            char[] charArray = s1.ToCharArray();
            Array.Reverse(charArray);
            int l1 = charArray.Length;
            string s2 = "";
            for (int i = 0; i < l1; i++)
            {
                s2 += charArray[i].ToString();
                if ( (i == 2) || (i == 5) || (i == 8) || (i == 11) || (i == 14))
                    s2 += ",";
            }
            char[] cArray = s2.ToCharArray();
            Array.Reverse(cArray);
            string s3 = String.Concat<char>(cArray);
            return s3;
        }
    }
}
