using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewButtonExample
{
    public class panelContent
    {

        Panel pnlUser = new Panel();
        PictureBox picUser = new PictureBox();
        Label lblUserCode = new Label();
        Label lblUserAccess = new Label();
        Button btnEdit = new Button();

        public Panel PnlUser { get => pnlUser; set => pnlUser = value; }
        public PictureBox PicUser { get => picUser; set => picUser = value; }
        public Label LblUserCode { get => lblUserCode; set => lblUserCode = value; }
        public Label LblUserAccess { get => lblUserAccess; set => lblUserAccess = value; }
        public Button BtnEdit { get => btnEdit; set => btnEdit = value; }
    }
}
