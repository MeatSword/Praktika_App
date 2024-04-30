using prk_25.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrueValid = System.ComponentModel.DataAnnotations.ValidationResult;

namespace prk_25
{
    public partial class EditOrder : Form
    {
        Praktika25vrContext db = new Praktika25vrContext();
        Order pers = new Order();
        Manager tt = new Manager();
        public EditOrder(int id, Manager cs)
        {
            
            InitializeComponent();
            pers = db.Orders.Where(_ => _.IdOrder == id).FirstOrDefault();
            tt = cs;

            var dg2 = db.Otdels.ToList();
            foreach (var zv in dg2)
            {
                txt_OrdersOtdelID.Items.Add(zv.IdOtdel + " " + zv.Name);
            }
            var dg3 = db.Procceses.ToList();
            foreach (var zv in dg3)
            {
                txt_OrdersProccesID.Items.Add(zv.IdProcces + " " + zv.Name);
            }

            foreach (var zv in txt_OrdersOtdelID.Items)
            {
                if (zv.ToString().Split(" ")[0] == pers.OtdelId.ToString())
                {
                    txt_OrdersOtdelID.SelectedItem = zv;
                    break;
                }
            }
            foreach (var zv in txt_OrdersProccesID.Items)
            {
                if (zv.ToString().Split(" ")[0] == pers.ProccesId.ToString())
                {
                    txt_OrdersProccesID.SelectedItem = zv;
                    break;
                }
            }

            txt_OrdersPartnerID.Text = pers.PartnerId.ToString();
            ch_OrdersStatus.Checked = pers.Status;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                pers.OtdelId = Convert.ToInt32(txt_OrdersOtdelID.Text.Split(" ")[0]);
                pers.ProccesId = Convert.ToInt32(txt_OrdersProccesID.Text.Split(" ")[0]);
                pers.PartnerId = Convert.ToInt32(txt_OrdersPartnerID.Text);
                pers.Status = ch_OrdersStatus.Checked;
                pers.Date = DateOnly.FromDateTime(DateTime.Now);
            }
            catch
            {
                var context = new ValidationContext(pers);
                var results = new List<TrueValid>();

                if (!Validator.TryValidateObject(pers, context, results, true))
                {
                    string msg = "";
                    MessageBox.Show("Не удалось создать объект Order");
                    foreach (var error in results)
                    {
                        msg += error.ErrorMessage + "\n";
                    }
                    MessageBox.Show(msg);
                }
            }
            try
            {
                db.SaveChanges();
                MessageBox.Show("Успешно обновлено");
                this.Close();
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            tt.loadData();
        }
    }
}
