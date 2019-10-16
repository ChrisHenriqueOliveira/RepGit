using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewButtonExample
{
    public class getUsers
    {
        List<string> usersRegistered = new List<string>();
        public List<string> getUsersRegistered()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\apsImage";

            DirectoryInfo dirInfo = new DirectoryInfo(path);

            foreach (FileInfo files in dirInfo.GetFiles())
            {
                string fullName = files.Name;
                string codeName = fullName.Substring(0, 6);

                usersRegistered.Add(codeName);              
            }
            return usersRegistered;
        }

        public Panel buildPanel(string users, int i)
        {
            Panel pnlUser = new Panel();
            pnlUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            pnlUser.Location = new System.Drawing.Point(10, 44+i);
            pnlUser.Name = "pnlUser" + users;
            pnlUser.Size = new System.Drawing.Size(390, 64);
            pnlUser.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            pnlUser.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            pnlUser.Visible = true;

            PictureBox picUser = new PictureBox();
            picUser.Location = new System.Drawing.Point(4, 4);
            picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picUser.Image = global::DataGridViewButtonExample.Properties.Resources._200_2008697_account_customer_login_man_user_icon_login_icon;
            picUser.Name = "picUser" + users;
            picUser.Size = new System.Drawing.Size(56, 56);
            picUser.TabStop = false;

            Label lblUserCode = new Label();
            lblUserCode.AutoSize = true;
            lblUserCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUserCode.Location = new System.Drawing.Point(67, 7);
            lblUserCode.Name = "lblUserCode" + users;
            lblUserCode.Size = new System.Drawing.Size(136, 16);
            lblUserCode.Text = "User code: 456558";

            Label lblUserAccess = new Label();
            lblUserAccess.AutoSize = true;
            lblUserAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUserAccess.Location = new System.Drawing.Point(67, 40);
            lblUserAccess.Name = "lblUserAccess" + users;
            lblUserAccess.Size = new System.Drawing.Size(190, 16);
            lblUserAccess.Text = "Access level: 1 (MASTER)";

            Button btnEdit = new Button();
            btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnEdit.Location = new System.Drawing.Point(290, 33);
            btnEdit.Name = "butEdit" + users;
            btnEdit.Size = new System.Drawing.Size(75, 23);
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;

            pnlUser.Controls.Add(picUser);
            pnlUser.Controls.Add(lblUserCode);
            pnlUser.Controls.Add(lblUserAccess);
            pnlUser.Controls.Add(btnEdit);

            return pnlUser;
        }

    }
}
