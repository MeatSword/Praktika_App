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

    public partial class EditMaterial : Form
    {
        Praktika25vrContext db = new Praktika25vrContext();
        Material pers = new Material();
        Manager tt = new Manager();
        public EditMaterial(int id, Manager cs)
        {
            tt = cs;
            InitializeComponent();
            pers = db.Materials.Where(_ => _.IdMat == id).FirstOrDefault();

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

            foreach (var zv in txt_MaterialsTypeMatID.Items)
            {
                if (zv.ToString().Split(" ")[0] == pers.TypeMatId.ToString())
                {
                    txt_MaterialsTypeMatID.SelectedItem = zv;
                    break;
                }
            }
            foreach (var zv in txt_MaterialsProviderID.Items)
            {
                if (zv.ToString().Split(" ")[0] == pers.ProviderId.ToString())
                {
                    txt_MaterialsProviderID.SelectedItem = zv;
                    break;
                }
            }
            txt_MaterialsDencity.Text = pers.Dencity.ToString();
            txt_MaterialsName.Text = pers.Name.ToString();
            txt_MaterialsPrice.Text = pers.Price.ToString();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                pers.TypeMatId = Convert.ToInt32(txt_MaterialsTypeMatID.Text.Split(" ")[0]);
                pers.ProviderId = Convert.ToInt32(txt_MaterialsProviderID.Text.Split(" ")[0]);
                pers.Dencity = Convert.ToInt32(txt_MaterialsDencity.Text);
                pers.Price = Convert.ToInt32(txt_MaterialsPrice.Text);
                pers.Name = txt_MaterialsName.Text;
            }
            catch
            {
                var context = new ValidationContext(pers);
                var results = new List<TrueValid>();

                if (!Validator.TryValidateObject(pers, context, results, true))
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
            
            try
            {
                db.SaveChanges();
                MessageBox.Show("Успешно обновлено");
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditMaterial_FormClosing(object sender, FormClosingEventArgs e)
        {
            tt.loadData();
        }
    }
}
