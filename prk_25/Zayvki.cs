using prk_25.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace prk_25
{
    public partial class Zayvki : Form
    {
        Praktika25vrContext db = new Praktika25vrContext();
        Personal us_info = new Personal();
        public Zayvki()
        {
            InitializeComponent();
            us_info = db.Personals.Where(_ => _.IdPersonal == UserData.user_id).FirstOrDefault();
            loadData();
        }


        void loadData()
        {
            lb_name.Text = us_info.Name;
            lb_sname.Text = us_info.Lname;
            lb_lname.Text = us_info.Sname;

            var zv = db.Zayavkis.Where(_ => _.IdPersonal == us_info.IdPersonal).ToList();
            foreach (var zvv in zv)
            {
                dtg_1.Rows.Add(zvv.IdApl, zvv.DescС);
            }
        }

        private void lb_sname_Click(object sender, EventArgs e)
        {

        }
        private void Zayvki_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Login zv = new Login();
            this.Close();
            zv.Show();
        }
    }
}
