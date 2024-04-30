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
            AddForm zv = new AddForm();
            zv.Show();
        }
        public void loadData()
        {
            db = new Praktika25vrContext();
            dtg_1.Rows.Clear();
            dtg_2.Rows.Clear();
            dtg_3.Rows.Clear();
            lb_name.Text = us_info.Name;
            lb_sname.Text = us_info.Lname;
            lb_lname.Text = us_info.Sname;

            var dg1 = db.Personals.ToList();
            foreach (var zv in dg1)
            {
                dtg_1.Rows.Add(zv.IdPersonal, db.Roles.Where(_ => _.IdRole == zv.RoleId).FirstOrDefault().Name, zv.Name, zv.Sname, zv.Lname);
            }
            var dg2 = db.Orders.ToList();
            foreach (var zv in dg2)
            {
                dtg_2.Rows.Add(zv.IdOrder, db.Otdels.Where(_ => _.IdOtdel == zv.OtdelId).FirstOrDefault().Name, db.Procceses.Where(_ => _.IdProcces == zv.ProccesId).FirstOrDefault().Name, zv.PartnerId, zv.Date);
            }
            var dg3 = db.Materials.ToList();
            foreach (var zv in dg3)
            {
                dtg_3.Rows.Add(zv.IdMat, zv.Name, db.TypeMaterials.Where(_ => _.IdType == zv.TypeMatId).FirstOrDefault().Name, zv.Dencity, zv.Price);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (tbc_1.SelectedIndex == 0)
            {
                EditPersonal pr = new EditPersonal(Convert.ToInt32(dtg_1.SelectedRows[0].Cells[0].Value.ToString()), this);
                pr.Show();

            }
            if (tbc_1.SelectedIndex == 1)
            {
                EditOrder pr = new EditOrder(Convert.ToInt32(dtg_2.SelectedRows[0].Cells[0].Value.ToString()), this);
                pr.Show();

            }
            if (tbc_1.SelectedIndex == 2)
            {
                EditMaterial pr = new EditMaterial(Convert.ToInt32(dtg_3.SelectedRows[0].Cells[0].Value.ToString()), this);
                pr.Show();

            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (tbc_1.SelectedIndex == 0)
            {
                db.Personals.Remove(db.Personals.Where(_ => _.IdPersonal == Convert.ToInt32(dtg_1.SelectedRows[0].Cells[0].Value.ToString())).FirstOrDefault());
                db.SaveChanges();
            }
            if (tbc_1.SelectedIndex == 1)
            {
                db.Orders.Remove(db.Orders.Where(_ => _.IdOrder == Convert.ToInt32(dtg_2.SelectedRows[0].Cells[0].Value.ToString())).FirstOrDefault());
                db.SaveChanges();

            }
            if (tbc_1.SelectedIndex == 2)
            {
                db.Materials.Remove(db.Materials.Where(_ => _.IdMat == Convert.ToInt32(dtg_3.SelectedRows[0].Cells[0].Value.ToString())).FirstOrDefault());
                db.SaveChanges();

            }
            loadData();
        }
    }
}
