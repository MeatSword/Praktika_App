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
    public partial class Manager : Form
    {
        Praktika25vrContext db = new Praktika25vrContext();
        Personal us_info = new Personal();

        public Manager()
        {
            InitializeComponent();
            us_info = db.Personals.Where(_ => _.IdPersonal == UserData.user_id).FirstOrDefault();
            loadData();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }
        void loadData()
        {
            lb_name.Text = us_info.Name;
            lb_sname.Text = us_info.Lname;
            lb_lname.Text = us_info.Sname;

            var dg1 = db.Personals.ToList();
            foreach (var zv in dg1)
            {
                dtg_1.Rows.Add(zv.IdPersonal, db.Roles.Where(_=>_.IdRole== zv.RoleId).FirstOrDefault().Name,zv.Name,zv.Sname,zv.Lname);
            }
        }
    }
}
