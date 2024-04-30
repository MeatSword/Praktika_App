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
    public partial class EditPersonal : Form
    {
        Praktika25vrContext db = new Praktika25vrContext();
        Personal pers = new Personal();
        Manager tt = new Manager();
        public EditPersonal(int id,Manager cs)
        {
            tt = cs;
            InitializeComponent();
            pers = db.Personals.Where(_ => _.IdPersonal == id).FirstOrDefault();

            var dg1 = db.Roles.ToList();
            foreach (var zv in dg1)
            {
                txt_PersonalRoleID.Items.Add(zv.IdRole + " " + zv.Name);
            }
            var dg2 = db.Otdels.ToList();
            foreach (var zv in dg2)
            {
                txt_PersonalOtdelID.Items.Add(zv.IdOtdel + " " + zv.Name);
            }

            foreach (var zv in txt_PersonalRoleID.Items)
            {
                if (zv.ToString().Split(" ")[0] == pers.RoleId.ToString())
                {
                    txt_PersonalRoleID.SelectedItem = zv;
                    break;
                }
            }
            foreach (var zv in txt_PersonalOtdelID.Items)
            {
                if (zv.ToString().Split(" ")[0] == pers.OtdelId.ToString())
                {
                    txt_PersonalOtdelID.SelectedItem = zv;
                    break;
                }
            }
            txt_PersonalName.Text = pers.Name + " " + pers.Sname + " " + pers.Lname;
            txt_Log.Text = db.PersonalUserData.Where(_ => _.IdPersonal == pers.IdPersonal).FirstOrDefault().Login;
            txt_Pass.Text = db.PersonalUserData.Where(_ => _.IdPersonal == pers.IdPersonal).FirstOrDefault().Password;
            txt_PersonalPhone.Text = pers.Phone;

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            PersonalUserDatum tmpPrr = db.PersonalUserData.Where(_ => _.IdPersonal == pers.IdPersonal).FirstOrDefault();
            tmpPrr.Login = txt_Log.Text;
            tmpPrr.Password = txt_Pass.Text;
            try
            {
                db.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                pers.RoleId = Convert.ToInt32(txt_PersonalRoleID.Text.Split(" ")[0]);
                pers.OtdelId = Convert.ToInt32(txt_PersonalOtdelID.Text.Split(" ")[0]);
                pers.Name = txt_PersonalName.Text.Split(" ")[0];
                pers.Sname = txt_PersonalName.Text.Split(" ")[1];
                pers.Lname = txt_PersonalName.Text.Split(" ")[2];
                pers.Phone = txt_PersonalPhone.Text;
            }
            catch
            {
                var context = new ValidationContext(pers);
                var results = new List<TrueValid>();

                if (!Validator.TryValidateObject(pers, context, results, true))
                {
                    string msg = "";
                    MessageBox.Show("Не удалось создать объект Personal");
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

        private void EditPersonal_FormClosing(object sender, FormClosingEventArgs e)
        {
            tt.loadData();
        }
    }
}
