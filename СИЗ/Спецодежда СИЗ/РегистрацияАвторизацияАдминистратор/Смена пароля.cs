using System.Windows.Forms;

namespace Спецодежда_СИЗ.РегистрацияАвторизацияАдминистратор
{
    public delegate bool ValidateUser(string login, string oldPassword, string newPassword);

    public partial class Смена_пароля : Form
    {
        public event ValidateUser OnValidateUser;

        public Смена_пароля()
        {
            this.OnValidateUser += (login, oldPassword, newPassword) => { return true; };
            this.InitializeComponent();
        }

        public string GetLogin()
        {
            return this.textBoxLogin.Text;
        }

        public string GetOldPassword()
        {
            return this.textBoxOldPassword.Text;
        }

        public string GetNewPassword()
        {
            return this.textBoxNewPassword.Text;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (this.textBoxRepeatNewPassword.Text != this.textBoxNewPassword.Text)
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show("Введённые новые пароли не совпадают");
            }
            else if (!this.OnValidateUser(this.GetLogin(), this.GetOldPassword(), this.GetNewPassword()))
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void checkBox_CheckedChanged(object sender, System.EventArgs e)
        {
            this.textBoxNewPassword.PasswordChar = this.textBoxRepeatNewPassword.PasswordChar =
                this.checkBoxShowPassword.Checked
                ? (char)0
                : '*';
        }
    }
}