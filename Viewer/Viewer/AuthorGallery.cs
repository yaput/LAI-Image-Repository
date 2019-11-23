using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Viewer
{
    public partial class AuthorGallery : UserControl
    {
        public AuthorGallery()
        {
            InitializeComponent();
        }
        private string conn;
        private MySqlConnection connect;
        int CtrlWidth;
        int CtrlHeight;
        int PicWidth;
        int PicHeight;
        int XLocation;
        int YLocation;
        public List<string> idTxt = new List<string>();
        public string server;
        public string database;
        public string idDb;
        public string pwdDb;
        private bool ck = false;
        public string setServer
        {
            set { server = value; }
        }
        public string setDatabase
        {
            set { database = value; }
        }
        public string setidDb
        {
            set { idDb = value; }
        }
        public string setpwdDb
        {
            set { pwdDb = value; }
        }
        private void db_connection()
        {
            
            try
            {
                //conn = "Server=localhost;Database=lai1;Uid=root;Pwd=;";
                conn = "Server=" + server + ";Database=" + database + ";Uid=" + idDb + ";Pwd=" + pwdDb + ";";
                connect = new MySqlConnection(conn);
                connect.Open();
                Console.WriteLine("Connected");
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
        }
        private void AuthorCodeImageGalleryVB_Resize(System.Object sender, System.EventArgs e)
        {
            CtrlHeight = this.Height;
            CtrlWidth = this.Width;
        }
       


        int i = 0;
        private string dbCaption;
        private string dbIDphoto;
        private void DrawPictureBox(string _filename, string _displayname)
        {
            CtrlWidth = this.Width;
            PictureBox Pic1 = new PictureBox();
            Label caption = new Label();
            CheckBox cek = new CheckBox();
            cek.Size = new Size(12, 12);
            Pic1.Location = new System.Drawing.Point(XLocation, YLocation);
            caption.Size = new System.Drawing.Size(PicWidth, 13);
            caption.Location = new System.Drawing.Point(XLocation, YLocation + 110);
            cek.BringToFront();
            cek.Location = new System.Drawing.Point(XLocation+103, YLocation + 95);
            XLocation = XLocation + PicWidth + 20;
            if (XLocation + PicWidth >= CtrlWidth)
            {
                XLocation = 25;
                YLocation = YLocation + PicHeight + 25;
            }
           
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT CaptionPhoto, ID_Photo from tbphoto WHERE PathPhoto = '" + _filename + "'";
            cmd.Connection = connect;
            MySqlDataReader rs = cmd.ExecuteReader();
            if (rs.Read())
            {
                dbCaption = rs.GetString("CaptionPhoto");
                dbIDphoto = rs.GetString("ID_Photo");
            }
            connect.Close();
            if (dbCaption == "DEFAULT")
            {
                caption.Text = "Insert Caption";
            }
            else
            {
                caption.Text = dbCaption;
            }
            caption.Tag = dbIDphoto;
            cek.Tag = dbIDphoto;
            cek.CheckedChanged += cek_CheckedChanged;
            this.Controls.Add(caption);
            this.Controls.Add(cek);
            Pic1.Name = "PictureBox" + i;
            cek.Name = "cek" + i;
            i += 1;
            Pic1.Size = new System.Drawing.Size(PicWidth, PicHeight);
            Pic1.TabIndex = 0;
            Pic1.TabStop = false;
            Pic1.BorderStyle = BorderStyle.Fixed3D;
            try
            {
                Pic1.Image = Image.FromFile(_filename.Replace('/', '\\'));
            }
            catch(MySqlException d)
            {
                Console.WriteLine(d.ToString());
                Pic1.BackColor = Color.Black;
            }
            this.Controls.Add(Pic1);
            Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

        }


        void cek_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cek = default(CheckBox);
            cek = (CheckBox)sender;
            if (cek.Checked == true)
            {
                idTxt.Add(cek.Tag.ToString());
            }
            else
            {
                idTxt.Remove(cek.Tag.ToString());
            }
        }

        public void CreateGallery(string[] IDP)
        {
            
            PicWidth = 117;
            PicHeight = 109;
            XLocation = 25;
            YLocation = 25;
            i = 0;
            RemoveControls();
            this.Controls.Clear();
            string[] tempFile2;
            string nameFile;
            string[] tempFile;
            if (IDP != null)
            {

                this.Controls.Clear();
                //System.IO.FileInfo[] diar2 = di.GetFiles("*.bmp");
                //System.IO.FileInfo[] diar3 = di.GetFiles("*.png");
                //System.IO.FileInfo[] diar4 = di.GetFiles("*.gif");

                //var diarList = new List<System.IO.FileInfo>();
                //diarList.AddRange(diar1);
                //diarList.AddRange(diar2);
                //diarList.AddRange(diar3);
                //diarList.AddRange(diar4);
                //System.IO.FileInfo[] diar = diarList.ToArray();

                //System.IO.FileInfo dra = null;
                try {

                this.Controls.Clear();
                foreach(string file in IDP)
                {
                    tempFile = file.Split('/');
                    tempFile2 = tempFile[(tempFile.Length) - 1].Split('.');
                    nameFile = tempFile2[0];
                    DrawPictureBox(file, nameFile);
                }
                }
                catch
                {
                    Console.WriteLine("Not Enough Memory");
                }
            }
        }

      

       

        public void RemoveControls()
        {
        Again:
            foreach (Control ctrl in this.Controls)
            {
                this.Controls.Clear();
                this.Controls.Remove(ctrl);
            }
            if (this.Controls.Count > 0)
            {
                this.Controls.Clear();
                goto Again;
            }

        }

       
    }
}
