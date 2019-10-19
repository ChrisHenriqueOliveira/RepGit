using DataGridViewButtonExample;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS20192
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {

        userInfo userInfo = new userInfo();
        panelContent panelContent = new panelContent();
        getUsers getUsers = new getUsers();
        imageCompare imageCompare = new imageCompare();

        string foundLogin;
        float hitPercent;
        bool imageChoosed = false;

        Thread imageComp;
        public Form1()
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

        private void selectImage(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                userInfo.FileName = openFileDialog1.FileName;
                userInfo.Code = txtID.Text;
                picFingerPrint.ImageLocation = userInfo.FileName;
                imageChoosed = true;
            }
            else
            {
                return;
            }
        }

        private void btnLoginClick(object sender, EventArgs e)
        {
            if (btnLogin.Text == "LOGIN")
            {
                loginAction();
            }
            else
            {
                registerAction();
            }
        }

        private void loginAction()
        {
            if (txtID.Text != "" && txtID.TextLength == 6 && imageChoosed)
            {
                userInfo.Code = txtID.Text;

                loginLocalizer localizer = new loginLocalizer();
                foundLogin = localizer.localizer(userInfo);

                if (foundLogin != "")
                {
                    
                    imageComp = new Thread(imageComparision);
                    imageComp.Start();

                    timer2.Start();

                    pnlInitialScreen.Visible = false;
                    pnlHome.Visible = false;
                    pnlLoading.Visible = true;
                }
                else
                {
                    lblError.Text = "digital or user not found";
                    lblError.Visible = true;
                }

            }
            else
            {
                lblError.Text = "fill everything correctly";
                lblError.Visible = true;
            }
        }

        private void imageComparision()
        {
            hitPercent = imageCompare.compareImages(foundLogin, userInfo.FileName);
        }

        public void registerAction()
        {
            if (txtID.Text != "" && txtID.TextLength == 6 && imageChoosed)
            {
                userInfo.Code = txtID.Text;

                userRegistration userRegistration = new userRegistration();
                bool existsUser = userRegistration.register(userInfo);

                if (!existsUser)
                {
                    picFingerPrint.Image = DataGridViewButtonExample.Properties.Resources._1234561;
                    txtID.Clear();
                    lblError.Visible = false;

                    pnlInitialScreen.Visible = false;
                    pnlRegistered.Visible = true;

                    txtID.Hint = "User ID";
                    lblTitle.Text = "LOGIN";
                    btnLogin.Text = "LOGIN";

                    registerFormButton.Text = "REGISTER";
                }
                else
                {
                    lblError.Text = "id already registered";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "fill everything correctly";
                lblError.Visible = true;
            }
        }

        private void btnRegisterClick(object sender, EventArgs e)
        {
            if (registerFormButton.Text == "REGISTER")
            {
                picFingerPrint.Image = DataGridViewButtonExample.Properties.Resources._1234561;
                txtID.Clear();

                lblTitle.Text = "REGISTER";
                btnLogin.Text = "CONFIRM";

                registerFormButton.Text = "CANCEL";
            }
            else
            {
                picFingerPrint.Image = DataGridViewButtonExample.Properties.Resources._1234561;
                txtID.Clear();

                lblTitle.Text = "LOGIN";
                btnLogin.Text = "LOGIN";

                registerFormButton.Text = "REGISTER";
            }
        }

        private void btnBackClick(object sender, EventArgs e)
        {
            pnlRegistered.Visible = false;
            pnlInitialScreen.Visible = true;
        }

        public void logged()
        {
            lblLoggedAs.Text = "logged in as: " + userInfo.Code;
        }

        private void btnUsersClick(object sender, EventArgs e)
        {
            loadPnlUsers();
        }

        private void btnEditUserClick(object sender, EventArgs e)
        {
            Button edit = (Button)sender;
            string userCode = edit.Name.Substring(7, edit.Name.Length - 11);
            string userAccess = edit.Name.Substring(13, edit.Name.Length - 17);

            if(Convert.ToInt32(userInfo.AccessLevel) > Convert.ToInt32(userAccess))
            {
                formEditRegister editRegister = new formEditRegister();
                editRegister.editRegister(userCode, userAccess, getUsers, userInfo);

                timer1.Start();

                editRegister.Show();
            }
            else
            {
                MessageBox.Show("You can not change the information of a user who has more access level than you!", "ERROR!");
            }
          
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            cleanPnlUsers();
        }

        private void cleanPnlUsers()
        {
            int controlsCount = pnlUsers.Controls.Count;

            for (int i = 0; i < controlsCount; i++)
            {
                foreach (Control item in pnlUsers.Controls)
                {
                    if (item is Panel)
                        pnlUsers.Controls.Remove(item);
                }
            }

            pnlHome.Visible = true;
            pnlUsers.Visible = false;
        }

        private void loadPnlUsers()
        {
            int i = 0;
            pnlUsers.Visible = true;
            pnlHome.Visible = false;

            getUsers getUsers = new getUsers();
            List<string> usersRegistered = getUsers.getUsersRegistered();

            foreach (string users in usersRegistered)
            {
                Panel user = getUsers.buildPanel(users, i + 20, panelContent, userInfo);
                panelContent.BtnEdit.Click += new System.EventHandler(this.btnEditUserClick);
                pnlUsers.Controls.Add(panelContent.PnlUser);
                i += 70;
            }
        }

        private void verifyUsersChanges(object sender, EventArgs e)
        {
            if (getUsers.UserChanged == true)
            {
                cleanPnlUsers();
                loadPnlUsers();
                getUsers.UserChanged = false;
                timer1.Stop();
            }
            else
            {

            }
        }

        private void verifyLoginSuccess(object sender, EventArgs e)
        {
            if(imageCompare.FinishedCompare == true)
            {
                timer2.Stop();
                imageComp.Abort();
                ifLogged();
                imageCompare.FinishedCompare = false;
            }
            else
            {

            }
        }

        public void ifLogged()
        {
            if (hitPercent >= 98)
            {
                lblError.Visible = false;
                pnlLoading.Visible = false;
                pnlHome.Visible = true;

                logged();
            }
            else
            {
                pnlLoading.Visible = false;
                pnlInitialScreen.Visible = true;
                lblError.Text = "the fingerprints doesn't match";
                lblError.Visible = true;
            }
        }
    }
}
