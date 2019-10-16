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

        userInfo userInfo;
        bool imageChoosed = false;
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
            userInfo = new userInfo();
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
                string foundLogin = localizer.localizer(userInfo);

                if(foundLogin != "")
                {
                    imageCompare compare = new imageCompare();
                    float hitPercent = compare.compareImages(foundLogin, userInfo.FileName);

                    if(hitPercent >= 98)
                    {
                        lblError.Visible = false;
                        pnlInitialScreen.Visible = false;
                        pnlHome.Visible = true;

                        logged();
                    }
                    else
                    {
                        lblError.Text = "the fingerprints don't match";
                        lblError.Visible = true;
                    }
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
            int i = 0;
            pnlUsers.Visible = true;
            pnlHome.Visible = false;

            getUsers getUsers = new getUsers();
            List<string> usersRegistered = getUsers.getUsersRegistered();

             foreach (string users in usersRegistered)
            {
                Panel user = getUsers.buildPanel(users, i+20);
                pnlUsers.Controls.Add(user);
                i += 70;
            }
            

        }
    }
}
