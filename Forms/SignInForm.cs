using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityManager.DataFolder;
namespace UniversityManager.Forms
{
    public partial class SignInForm : Form
    {
        DataManager dataManager = new DataManager();
        public event EventHandler SignInSuccessful;
        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            Account account = new Account
            {
                Username = UsernameValue.Text,
                Password = PasswordValue.Text,
            };
            if (dataManager.Check(account))
            {
                SignInSuccessful?.Invoke(this, EventArgs.Empty);
                this.Close();
            }

        }
    }
}
