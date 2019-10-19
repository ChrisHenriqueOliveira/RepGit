using APS20192;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewButtonExample
{
    public partial class formEditRegister : MaterialSkin.Controls.MaterialForm
    {

        getUsers getUsers;
        userInfo userInfo;
        public formEditRegister()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
                );
        }

        public void editRegister(string user, string access, getUsers getUsersClass, userInfo userInfoClass)
        {
            lblUserCode.Text = user.Substring(0,user.Length-1);
            lblOldAccess.Text = access;

            getUsers = getUsersClass;
            userInfo = userInfoClass;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbNewAccess.Items.Contains(cbNewAccess.Text))
            {
                if(Convert.ToInt32(cbNewAccess.Text) > Convert.ToInt32(userInfo.AccessLevel))
                {
                    MessageBox.Show("You cannot change to a higher access level than yours!", "ERROR!");
                }
                else
                {
                    string OldName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\apsImage\\" + lblUserCode.Text + lblOldAccess.Text + ".png";
                    string NewName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\apsImage\\" + lblUserCode.Text + cbNewAccess.SelectedItem + ".png";
                    System.IO.File.Move(OldName, NewName);
                    getUsers.UserChanged = true;

                    pnlChange.Visible = false;
                    pnlEdited.Visible = true;

                    this.Dispose();
                }               
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
