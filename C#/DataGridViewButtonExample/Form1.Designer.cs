namespace APS20192
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.registerFormButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlInitialScreen = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlRegistered = new System.Windows.Forms.Panel();
            this.btnBack = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.btnUsersScreen = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblLoggedAs = new System.Windows.Forms.Label();
            this.lblHomeTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.lblUsersTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picFingerPrint = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlInitialScreen.SuspendLayout();
            this.pnlRegistered.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFingerPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtID
            // 
            this.txtID.Depth = 0;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Hint = "User ID";
            this.txtID.Location = new System.Drawing.Point(85, 69);
            this.txtID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.Size = new System.Drawing.Size(260, 23);
            this.txtID.TabIndex = 4;
            this.txtID.UseSystemPasswordChar = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(189, 24);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(54, 18);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "LOGIN";
            // 
            // registerFormButton
            // 
            this.registerFormButton.AutoSize = true;
            this.registerFormButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerFormButton.Depth = 0;
            this.registerFormButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.registerFormButton.Location = new System.Drawing.Point(178, 387);
            this.registerFormButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registerFormButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerFormButton.Name = "registerFormButton";
            this.registerFormButton.Primary = false;
            this.registerFormButton.Size = new System.Drawing.Size(74, 36);
            this.registerFormButton.TabIndex = 6;
            this.registerFormButton.Text = "REGISTER";
            this.registerFormButton.UseVisualStyleBackColor = true;
            this.registerFormButton.Click += new System.EventHandler(this.btnRegisterClick);
            // 
            // btnLogin
            // 
            this.btnLogin.Depth = 0;
            this.btnLogin.Location = new System.Drawing.Point(140, 350);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(150, 36);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLoginClick);
            // 
            // pnlInitialScreen
            // 
            this.pnlInitialScreen.Controls.Add(this.lblError);
            this.pnlInitialScreen.Controls.Add(this.lblTitle);
            this.pnlInitialScreen.Controls.Add(this.registerFormButton);
            this.pnlInitialScreen.Controls.Add(this.btnLogin);
            this.pnlInitialScreen.Controls.Add(this.txtID);
            this.pnlInitialScreen.Controls.Add(this.picFingerPrint);
            this.pnlInitialScreen.Location = new System.Drawing.Point(1, 63);
            this.pnlInitialScreen.Name = "pnlInitialScreen";
            this.pnlInitialScreen.Size = new System.Drawing.Size(431, 500);
            this.pnlInitialScreen.TabIndex = 8;
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(13, 95);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(404, 23);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "digital or user not found";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // pnlRegistered
            // 
            this.pnlRegistered.Controls.Add(this.btnBack);
            this.pnlRegistered.Controls.Add(this.label1);
            this.pnlRegistered.Controls.Add(this.pictureBox1);
            this.pnlRegistered.Location = new System.Drawing.Point(1, 63);
            this.pnlRegistered.Name = "pnlRegistered";
            this.pnlRegistered.Size = new System.Drawing.Size(431, 500);
            this.pnlRegistered.TabIndex = 11;
            this.pnlRegistered.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Depth = 0;
            this.btnBack.Location = new System.Drawing.Point(192, 269);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.Primary = false;
            this.btnBack.Size = new System.Drawing.Size(47, 36);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBackClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(13, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "successfully registered";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.btnUsersScreen);
            this.pnlHome.Controls.Add(this.lblLoggedAs);
            this.pnlHome.Controls.Add(this.lblHomeTitle);
            this.pnlHome.Location = new System.Drawing.Point(1, 63);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(430, 500);
            this.pnlHome.TabIndex = 12;
            // 
            // btnUsersScreen
            // 
            this.btnUsersScreen.Depth = 0;
            this.btnUsersScreen.Location = new System.Drawing.Point(135, 89);
            this.btnUsersScreen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUsersScreen.Name = "btnUsersScreen";
            this.btnUsersScreen.Primary = true;
            this.btnUsersScreen.Size = new System.Drawing.Size(160, 36);
            this.btnUsersScreen.TabIndex = 11;
            this.btnUsersScreen.Text = "USERS";
            this.btnUsersScreen.UseVisualStyleBackColor = true;
            this.btnUsersScreen.Click += new System.EventHandler(this.btnUsersClick);
            // 
            // lblLoggedAs
            // 
            this.lblLoggedAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedAs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLoggedAs.Location = new System.Drawing.Point(13, 43);
            this.lblLoggedAs.Name = "lblLoggedAs";
            this.lblLoggedAs.Size = new System.Drawing.Size(404, 16);
            this.lblLoggedAs.TabIndex = 10;
            this.lblLoggedAs.Text = "logged in as: ";
            this.lblLoggedAs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHomeTitle
            // 
            this.lblHomeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblHomeTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHomeTitle.Location = new System.Drawing.Point(13, 11);
            this.lblHomeTitle.Name = "lblHomeTitle";
            this.lblHomeTitle.Size = new System.Drawing.Size(404, 32);
            this.lblHomeTitle.TabIndex = 9;
            this.lblHomeTitle.Text = "PRIVATE SYSTEM";
            this.lblHomeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(17, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panel1.Size = new System.Drawing.Size(390, 64);
            this.panel1.TabIndex = 12;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(306, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "EDIT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Access level: 1 (MASTER)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "User code: 456558";
            // 
            // pnlUsers
            // 
            this.pnlUsers.AutoScroll = true;
            this.pnlUsers.Controls.Add(this.lblUsersTitle);
            this.pnlUsers.Controls.Add(this.panel1);
            this.pnlUsers.Location = new System.Drawing.Point(0, 64);
            this.pnlUsers.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.pnlUsers.Size = new System.Drawing.Size(437, 500);
            this.pnlUsers.TabIndex = 13;
            this.pnlUsers.Visible = false;
            // 
            // lblUsersTitle
            // 
            this.lblUsersTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblUsersTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUsersTitle.Location = new System.Drawing.Point(13, 11);
            this.lblUsersTitle.Name = "lblUsersTitle";
            this.lblUsersTitle.Size = new System.Drawing.Size(404, 32);
            this.lblUsersTitle.TabIndex = 10;
            this.lblUsersTitle.Text = "USERS";
            this.lblUsersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DataGridViewButtonExample.Properties.Resources._200_2008697_account_customer_login_man_user_icon_login_icon;
            this.pictureBox2.Location = new System.Drawing.Point(4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // picFingerPrint
            // 
            this.picFingerPrint.Image = global::DataGridViewButtonExample.Properties.Resources._1234561;
            this.picFingerPrint.InitialImage = null;
            this.picFingerPrint.Location = new System.Drawing.Point(140, 147);
            this.picFingerPrint.Name = "picFingerPrint";
            this.picFingerPrint.Size = new System.Drawing.Size(150, 150);
            this.picFingerPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFingerPrint.TabIndex = 3;
            this.picFingerPrint.TabStop = false;
            this.picFingerPrint.Click += new System.EventHandler(this.selectImage);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DataGridViewButtonExample.Properties.Resources.correctVector;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(175, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 563);
            this.Controls.Add(this.pnlInitialScreen);
            this.Controls.Add(this.pnlRegistered);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.pnlUsers);
            this.Name = "Form1";
            this.Text = "APS System";
            this.pnlInitialScreen.ResumeLayout(false);
            this.pnlInitialScreen.PerformLayout();
            this.pnlRegistered.ResumeLayout(false);
            this.pnlRegistered.PerformLayout();
            this.pnlHome.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFingerPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picFingerPrint;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtID;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialFlatButton registerFormButton;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
        private System.Windows.Forms.Panel pnlInitialScreen;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel pnlRegistered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialFlatButton btnBack;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Label lblHomeTitle;
        private System.Windows.Forms.Label lblLoggedAs;
        private MaterialSkin.Controls.MaterialRaisedButton btnUsersScreen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.Label lblUsersTitle;
    }
}