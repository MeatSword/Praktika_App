using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Npgsql;
using prk_25.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Validation;
using TrueValid = System.ComponentModel.DataAnnotations.ValidationResult;
using System.ComponentModel.DataAnnotations;

namespace prk_25
{
    public partial class AddForm : Form
    {
        Praktika25vrContext db = new Praktika25vrContext();
        public AddForm()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            var dg1 = db.Roles.ToList();
            foreach (var zv in dg1)
            {
                txt_PersonalRoleID.Items.Add(zv.IdRole + " " + zv.Name);
            }
            var dg2 = db.Otdels.ToList();
            foreach (var zv in dg2)
            {
                txt_PersonalOtdelID.Items.Add(zv.IdOtdel + " " + zv.Name);
                txt_OrdersOtdelID.Items.Add(zv.IdOtdel + " " + zv.Name);
            }
            var dg3 = db.Procceses.ToList();
            foreach (var zv in dg3)
            {
                txt_OrdersProccesID.Items.Add(zv.IdProcces + " " + zv.Name);
            }
            var dg4 = db.TypeMaterials.ToList();
            foreach (var zv in dg4)
            {
                txt_MaterialsTypeMatID.Items.Add(zv.IdType + " " + zv.Name);
            }
            var dg5 = db.Providers.ToList();
            foreach (var zv in dg5)
            {
                txt_MaterialsProviderID.Items.Add(zv.IdProvider + " " + zv.Name);
            }
        }

        private void btn_Add1_Click(object sender, EventArgs e)
        {
            PersonalUserDatum tmpPrr = new PersonalUserDatum();
            tmpPrr.Login = txt_Log.Text;
            tmpPrr.Password = txt_Pass.Text;
            try
            {
                db.PersonalUserData.Add(tmpPrr);
                db.SaveChanges();
                MessageBox.Show("Успешно добавлено");
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            Personal tmpPr = new Personal();
            try
            {
                
                tmpPr.IdPersonal = db.PersonalUserData.OrderByDescending(o => o.IdPersonal).FirstOrDefault().IdPersonal;
                tmpPr.RoleId = Convert.ToInt32(txt_PersonalRoleID.Text.Split(" ")[0]);
                tmpPr.OtdelId = Convert.ToInt32(txt_PersonalOtdelID.Text.Split(" ")[0]);
                tmpPr.Name = txt_PersonalName.Text.Split(" ")[0];
                tmpPr.Sname = txt_PersonalName.Text.Split(" ")[1];
                tmpPr.Lname = txt_PersonalName.Text.Split(" ")[2];
                tmpPr.Phone = txt_PersonalPhone.Text;
                try
                {
                    db.Personals.Add(tmpPr);
                    db.SaveChanges();
                    MessageBox.Show("Успешно добавлено");
                }
                catch (DbEntityValidationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch
            {
                var context = new ValidationContext(tmpPr);
                var results = new List<TrueValid>();

                if (!Validator.TryValidateObject(tmpPr, context, results, true))
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
            

        }

        private void btn_Add2_Click(object sender, EventArgs e)
        {
            Order tmpPr = new Order();
            try
            {
                tmpPr.OtdelId = Convert.ToInt32(txt_OrdersOtdelID.Text.Split(" ")[0]);
                tmpPr.ProccesId = Convert.ToInt32(txt_OrdersProccesID.Text.Split(" ")[0]);
                tmpPr.PartnerId = Convert.ToInt32(txt_OrdersPartnerID.Text);
                tmpPr.Status = ch_OrdersStatus.Checked;
                tmpPr.Date = DateOnly.FromDateTime(DateTime.Now);
                try
                {
                    db.Orders.Add(tmpPr);
                    db.SaveChanges();
                    MessageBox.Show("Успешно добавлено");
                }
                catch (DbEntityValidationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch
            {
                var context = new ValidationContext(tmpPr);
                var results = new List<TrueValid>();

                if (!Validator.TryValidateObject(tmpPr, context, results, true))
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
            
        }

        private void btn_Add3_Click(object sender, EventArgs e)
        {
            Material tmpPr = new Material();
            try
            {
                tmpPr.TypeMatId = Convert.ToInt32(txt_MaterialsTypeMatID.Text.Split(" ")[0]);
                tmpPr.ProviderId = Convert.ToInt32(txt_MaterialsProviderID.Text.Split(" ")[0]);
                tmpPr.Dencity = Convert.ToInt32(txt_MaterialsDencity.Text);
                tmpPr.Price = Convert.ToInt32(txt_MaterialsPrice.Text);
                tmpPr.Name = txt_MaterialsName.Text;
                try
                {
                    db.Materials.Add(tmpPr);
                    db.SaveChanges();
                    MessageBox.Show("Успешно добавлено");
                }
                catch (DbEntityValidationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch
            {
                var context = new ValidationContext(tmpPr);
                var results = new List<TrueValid>();

                if (!Validator.TryValidateObject(tmpPr, context, results, true))
                {
                    string msg = "";
                    MessageBox.Show("Не удалось создать объект Material");
                    foreach (var error in results)
                    {
                        msg += error.ErrorMessage + "\n";
                    }
                    MessageBox.Show(msg);
                }
            }

            
        }


    }
}
