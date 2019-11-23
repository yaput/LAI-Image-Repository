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

namespace WindowsFormsApplication2
{
    public partial class AuthorCodeImageGalleryVB : UserControl
    {
        public AuthorCodeImageGalleryVB()
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
        private string server;
        private string database;
        private string idDb;
        private string pwdDb;

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
        private string _Directory_Path;
        private string IDIndeks;
        public string Directorypath
        {
            get { return _Directory_Path; }
            set
            {
                _Directory_Path = value;
                XLocation = 25;
                YLocation = 25;
                PicWidth = 117;
                PicHeight = 109;
                CreateGallery();
            }
        }


        int i = 0;
        private string dbCaption;
        private string dbIDphoto;
        private void DrawPictureBox(string _filename, string _displayname)
        {
            CtrlWidth = this.Width;
            PictureBox Pic1 = new PictureBox();
            TextBox caption = new TextBox();
            Pic1.Location = new System.Drawing.Point(XLocation, YLocation);
            caption.Size = new System.Drawing.Size(PicWidth, 13);
            caption.Location = new System.Drawing.Point(XLocation, YLocation+110);
            XLocation = XLocation + PicWidth + 20;
            if (XLocation + PicWidth >= CtrlWidth)
            {
                XLocation = 25;
                YLocation = YLocation + PicHeight + 25;
            }
            //db_connection();
            //MySqlCommand cmd2 = new MySqlCommand();
            //cmd2.CommandText = "SELECT ID_Indeks from tbindeks ORDER by ID_Indeks DESC";
            //cmd2.Connection = connect;
            //MySqlDataReader rs6 = cmd2.ExecuteReader();
            //if (rs6.Read())
            //{
            //    IDIndeks = rs6.GetString("ID_Indeks");
            //}
            //connect.Close();
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT CaptionPhoto, ID_Photo from tbphoto WHERE PathPhoto = '" + _filename.Replace('\\', '/') + "'";
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
            this.Controls.Add(caption);
            Pic1.Name = "PictureBox" + i;
            i += 1;
            Pic1.Size = new System.Drawing.Size(PicWidth, PicHeight);
            Pic1.TabIndex = 0;
            Pic1.TabStop = false;
            Pic1.BorderStyle = BorderStyle.Fixed3D;
            caption.LostFocus += caption_LostFocus;
            this.Controls.Add(Pic1);
            try
            {
                Pic1.Image = Image.FromFile(_filename);
            }
            catch
            {
                Pic1.BackColor = Color.Black;
            }
            Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            
        }
        private void CreateGallery()
        {
            
            i = 0;
            RemoveControls();
            if (Directorypath != null)
            {
                this.Controls.Clear();
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Directorypath);

                System.IO.FileInfo[] diar1 = di.GetFiles("*.jpg");
                System.IO.FileInfo[] diar2 = di.GetFiles("*.bmp");
                System.IO.FileInfo[] diar3 = di.GetFiles("*.png");
                System.IO.FileInfo[] diar4 = di.GetFiles("*.gif");

                var diarList = new List<System.IO.FileInfo>();
                diarList.AddRange(diar1);
                diarList.AddRange(diar2);
                diarList.AddRange(diar3);
                diarList.AddRange(diar4);
                System.IO.FileInfo[] diar = diarList.ToArray();

                System.IO.FileInfo dra = null;
                foreach (System.IO.FileInfo dra_loopVariable in diar1)
                {
                    dra = dra_loopVariable;
                    DrawPictureBox(dra.FullName, dra.Name);
                }
            }
        }


        private void caption_LostFocus(System.Object sender, System.EventArgs e)
        {
            TextBox txt = default(TextBox);
            txt = (TextBox)sender;
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            if (txt.Text == "Insert Caption")
            {
                cmd.CommandText = "UPDATE tbphoto set CaptionPhoto = 'DEFAULT' WHERE ID_Photo = " + txt.Tag;
            }
            else
            {
                cmd.CommandText = "UPDATE tbphoto set CaptionPhoto = '" + txt.Text + "' WHERE ID_Photo = " + txt.Tag;
            }
            cmd.Connection = connect;
            cmd.ExecuteNonQuery();
            connect.Close();
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
                goto Again;
            }

            
        }
        
    }
}
