using Microsoft.VisualBasic.ApplicationServices;
using Npgsql.Internal.TypeMapping;
using prk_25.Models;
namespace prk_25
{
    public partial class Login : Form
    {
        Praktika25vrContext db = new Praktika25vrContext();
        public Login()
        {
            InitializeComponent();
        }

        private void txt_Pass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(db.PersonalUserData.Where(_ => _.Password == txt_Pass.Text && _.Login == txt_Log.Text).Any())
                {
                    var user = db.PersonalUserData.Where(_ => _.Password == txt_Pass.Text && _.Login == txt_Log.Text).FirstOrDefault();
                    UserData.user_id = user.IdPersonal;

                    if (db.Roles.Where(_ => _.IdRole == db.Personals.Where(_ => _.IdPersonal == user.IdPersonal).FirstOrDefault().RoleId).FirstOrDefault().Name == "Рабочий")
                    {
                        MessageBox.Show("Вы вошли как рабочий");
                    }
                    if (db.Roles.Where(_ => _.IdRole == db.Personals.Where(_ => _.IdPersonal == user.IdPersonal).FirstOrDefault().RoleId).FirstOrDefault().Name == "Специалист")
                    {
                        Zayvki zv = new Zayvki();
                        this.Hide();
                        zv.Show();
                    }
                    if (db.Roles.Where(_ => _.IdRole == db.Personals.Where(_ => _.IdPersonal == user.IdPersonal).FirstOrDefault().RoleId).FirstOrDefault().Name == "Руководитель")
                    {
                        Manager zv = new Manager();
                        this.Hide();
                        zv.Show();
                    }
                    if (db.Roles.Where(_ => _.IdRole == db.Personals.Where(_ => _.IdPersonal == user.IdPersonal).FirstOrDefault().RoleId).FirstOrDefault().Name == "Служащий")
                    {
                        MessageBox.Show("Вы вошли как рабочий");
                    }
                }
                else
                {
                    MessageBox.Show("Пользователя не найдено");
                }
            }
        }
    }
}