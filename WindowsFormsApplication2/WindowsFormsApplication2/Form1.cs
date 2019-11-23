using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;



namespace WindowsFormsApplication2
{
    

    public partial class Form1 : Form
    {
        private string conn;
        public MySqlConnection connect;
        private String path;
        private String pathFolder;
        private String IDProgram;
        private String IDEvent;
        private String IDLokasi;
        private String IDFotografer;
        private String IDIndeks;
        private string[] imgPaths;
        public string server;
        public string database;
        public string idDb;
        public string pwdDb;
        int jumlah;
        bool state;
        bool co = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void clearAll()
        {
            program.SelectedIndex = -1;
            vent.SelectedIndex = -1;
            lokasi.SelectedIndex = -1;
            fotografer.SelectedIndex = -1;
            dateTimePicker1.Text = "";
            tag.Text = "";
            folder.Text = "";
        }

        public void db_connection()
        {
            try
            {
                //conn = "Server=localhost;Database=lai1;Uid=root;Pwd=;";
                conn = "Server=" + server + ";Database=" + database + ";Uid=" + idDb + ";Pwd=" + pwdDb + ";";
                connect = new MySqlConnection(conn);
                connect.Open();
                Console.WriteLine("Connected");
                state = true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                state = false;
                co = false;
                MessageBox.Show("Wrong Input(s)!", "Error");
            }
        }

        private void getProgram()
        {
            
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT ID_Program, NamaProgram from tbprogram";
            cmd.Connection = connect;
            MySqlDataReader rs = cmd.ExecuteReader();
            program.Items.Clear();
            while (rs.Read())
            {
                ComboboxItem poe = new ComboboxItem();
                poe.Value = rs.GetString("ID_Program");
                poe.Text = rs.GetString("NamaProgram");
                program.Items.Add(poe);

               
            };
            program.SelectedIndex = -1;

            
            connect.Close();
        }

        private void getEvent()
        {
            vent.Items.Clear();
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT ID_Event, NamaEvent from tbevent";
            cmd.Connection = connect;
            MySqlDataReader rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                ComboboxItem poe = new ComboboxItem();
                poe.Value = rs.GetString("ID_Event");
                poe.Text = rs.GetString("NamaEvent");
                vent.Items.Add(poe);
            };
            connect.Close();
        }

        private void getLokasi()
        {
            lokasi.Items.Clear();
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT ID_Lokasi, NamaLokasi from tblokasi";
            cmd.Connection = connect;
            MySqlDataReader rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                ComboboxItem poe = new ComboboxItem();
                poe.Value = rs.GetString("ID_Lokasi");
                poe.Text = rs.GetString("NamaLokasi");
                lokasi.Items.Add(poe);
            };
            connect.Close();
        }

        private void getFotografer()
        {
            fotografer.Items.Clear();
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT ID_Photographer, NamaPhotographer from tbphotographer";
            cmd.Connection = connect;
            MySqlDataReader rs = cmd.ExecuteReader();
            while (rs.Read())
            {

                ComboboxItem poe = new ComboboxItem();
                poe.Value = rs.GetString("ID_Photographer");
                poe.Text = rs.GetString("NamaPhotographer");
                fotografer.Items.Add(poe);
            };
            connect.Close();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            serverInp.Text = "localhost";
            databaseInp.Text = "lai1";
            userInp.Text = "root";
            passwordInp.Text = "";
        }

        



        private void index_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            try
            {

            try{
                IDProgram = (program.SelectedItem as ComboboxItem).Value.ToString();
            }
            catch
            {
                String namaProgram = program.Text.ToUpper();
                db_connection();
                MySqlCommand cmd1 = new MySqlCommand();
                cmd1.CommandText = "INSERT INTO tbprogram(NamaProgram, IndukPath) values('" + namaProgram + "', '"+pathFolder.Replace('\\','/')+"')";
                cmd1.Connection = connect;
                cmd1.ExecuteNonQuery();
                Console.WriteLine("INSERT Program");
                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandText = "SELECT ID_Program from tbprogram WHERE NamaProgram = '"+namaProgram+"'";
                cmd2.Connection = connect;
                MySqlDataReader rs1 = cmd2.ExecuteReader();
                if (rs1.Read())
                {
                    IDProgram = rs1.GetString("ID_Program");
                };
                connect.Close();
            }

            try
            {
                IDLokasi = (lokasi.SelectedItem as ComboboxItem).Value.ToString();
            }
            catch 
            {
                String namaLokasi = lokasi.Text.ToUpper();
                db_connection();
                MySqlCommand cmd1 = new MySqlCommand();
                cmd1.CommandText = "INSERT INTO tblokasi(NamaLokasi) values('" + namaLokasi + "')";
                cmd1.Connection = connect;
                cmd1.ExecuteNonQuery();
                Console.WriteLine("INSERT Lokasi");
                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandText = "SELECT ID_Lokasi from tblokasi WHERE NamaLokasi = '" + namaLokasi + "'";
                cmd2.Connection = connect;
                MySqlDataReader rs1 = cmd2.ExecuteReader();
                if (rs1.Read())
                {
                    IDLokasi = rs1.GetString("ID_Lokasi");
                };
                connect.Close();
            }

            try 
            { 
                IDEvent = (vent.SelectedItem as ComboboxItem).Value.ToString(); 
            }
            catch {
                String namaEvent = vent.Text.ToUpper();
                db_connection();
                MySqlCommand cmd1 = new MySqlCommand();
                cmd1.CommandText = "INSERT INTO tbevent(tbProgram_ID_Program, tbLokasi_ID_Lokasi, NamaEvent) values('"+IDProgram+"', '"+IDLokasi+"', '" + namaEvent + "')";
                cmd1.Connection = connect;
                cmd1.ExecuteNonQuery();
                Console.WriteLine("INSERT EVENT");
                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandText = "SELECT ID_Event from tbevent WHERE NamaEvent = '" + namaEvent + "'";
                cmd2.Connection = connect;
                MySqlDataReader rs1 = cmd2.ExecuteReader();
                if (rs1.Read())
                {
                    IDEvent = rs1.GetString("ID_Event");
                };
                connect.Close();
            }

            try
            {
                IDFotografer = (fotografer.SelectedItem as ComboboxItem).Value.ToString();
            }
            catch
            {
                String namaFotografer = fotografer.Text.ToUpper();
                db_connection();
                MySqlCommand cmd1 = new MySqlCommand();
                cmd1.CommandText = "INSERT INTO tbphotographer(NamaPhotographer) values('" + namaFotografer + "')";
                cmd1.Connection = connect;
                cmd1.ExecuteNonQuery();
                Console.WriteLine("INSERT Fotografer");
                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandText = "SELECT ID_Photographer from tbphotographer WHERE NamaPhotographer = '" + namaFotografer + "'";
                cmd2.Connection = connect;
                MySqlDataReader rs1 = cmd2.ExecuteReader();
                if (rs1.Read())
                {
                    IDFotografer = rs1.GetString("ID_Photographer");
                    connect.Close();
                };
                db_connection();
                MySqlCommand cmd4 = new MySqlCommand();
                cmd4.CommandText = "INSERT INTO tbphotographer_has_tbevent(tbEvent_ID_Event, tbPhotographer_ID_Photographer) values('" + IDEvent + "', '"+IDFotografer+"')";
                cmd4.Connection = connect;
                cmd4.ExecuteNonQuery();
                connect.Close();
            }

            try
            {
                db_connection();
                MySqlCommand cmd1 = new MySqlCommand();
                cmd1.CommandText = "INSERT INTO tbindeks(TanggalIndeks) values('" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                cmd1.Connection = connect;
                cmd1.ExecuteNonQuery();
                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandText = "SELECT ID_Indeks from tbindeks ORDER by ID_Indeks DESC";
                cmd2.Connection = connect;
                MySqlDataReader rs6 = cmd2.ExecuteReader();
                if (rs6.Read())
                {
                    IDIndeks = rs6.GetString("ID_Indeks");
                }
                connect.Close();
            }
            catch
            {
                Console.WriteLine("GAGAL");
            }

            

           

            imgPaths = Directory.GetFiles(pathFolder,"*.jpg");
            String nameFile;
            string[] tempFile;
            string[] tempFile2;
            String typeFile;
        
            index.Text = "PROCESSING";
            index.Enabled = false;
            index.Visible = false;
            progressBar1.Visible = true;
            progressBar1.Maximum = imgPaths.Length;
            String res;
            Image foto;
            int countDone = 0;
            for (int x = 0; x < imgPaths.Length;x++ )
            {
                Console.WriteLine(imgPaths[x]);
                path = imgPaths[x].Replace('\\', '/');
                try
                {
                    foto = Image.FromFile(path);
                    res = foto.Width + "x" + foto.Height;
                }
                catch
                {
                    res = "UNDEFINED";
                }
                
                tempFile = imgPaths[x].Split('\\');
                tempFile2 = tempFile[(tempFile.Length)-1].Split('.');
                nameFile = tempFile2[0];
                typeFile = tempFile2[1];

                db_connection();
                MySqlCommand cmdCheck = new MySqlCommand();
                cmdCheck.CommandText = "SELECT ID_Photo from tbphoto WHERE PathPhoto = '" + path + "'";
                cmdCheck.Connection = connect;
                MySqlDataReader rsc = cmdCheck.ExecuteReader();
                if (!rsc.Read())
                {
                    db_connection();
                    MySqlCommand cmd5 = new MySqlCommand();
                    cmd5.CommandText = "INSERT INTO tbphoto(CaptionPhoto, NamaPhoto, PathPhoto, Resolution, TagPhoto, tbEvent_ID_Event, tbIndeks_ID_Indeks, tglPhoto, TypePhoto) values('DEFAULT', '" + nameFile + "', '" + path + "', '" + res + "', '" + tag.Text + "', '" + IDEvent + "', '" + IDIndeks + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', '" + typeFile + "')";
                    cmd5.Connection = connect;
                    cmd5.ExecuteNonQuery();
                    progressBar1.Value = x;
                    connect.Close();
                }
                else
                {
                    progressBar1.Value = x;
                    countDone += 1;
                }

            }
            
            if(countDone != 0)
            {
                
                MessageBox.Show(countDone + " Images Already in Databases", "Indexed");
            }

            db_connection();
            MySqlCommand cms = new MySqlCommand();
            cms.CommandText = "SELECT count(PathPhoto) from tbphoto WHERE tbIndeks_ID_Indeks = " + IDIndeks + "";
            cms.Connection = connect;
            MySqlDataReader rss = cms.ExecuteReader();
            if (rss.Read())
            {
                jumlah = rss.GetInt32(0);
                connect.Close();
            } 
            db_connection();
            string[] pho = new string[jumlah];
            string[] idPho = new string[jumlah];
            int yyy = 0;
            MySqlCommand cm = new MySqlCommand();
            cm.CommandText = "SELECT ID_Photo, PathPhoto from tbphoto WHERE tbIndeks_ID_Indeks = " + IDIndeks + "";
            cm.Connection = connect;
            MySqlDataReader rs = cm.ExecuteReader();
            while (rs.Read())
            {
                pho[yyy] = rs.GetString("PathPhoto");
                idPho[yyy] = rs.GetString("ID_Photo");
                if (yyy < jumlah)
                {
                    yyy += 1;
                }
            }
            connect.Close();
            authorCodeImageGalleryVB1.RemoveControls();
            authorCodeImageGalleryVB1.Directorypath = folderBrowserDialog1.SelectedPath;
            progressBar1.Visible = false;
            Cursor.Current = Cursors.Default;
            index.Visible = true;
            index.Text = "INDEXING";
            index.Enabled = true;
            save.Enabled = true;
                }
            catch
            {
                MessageBox.Show("Fill The Text Field(s) Properly");
            }
            watch.Stop();
            var elapsedMs = watch.Elapsed.TotalSeconds.ToString();
            time.Text = elapsedMs + " Seconds";
            time.Visible = true;
        }


        private void save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!");
            getEvent();
            getFotografer();
            getProgram();
            getLokasi();
            clearAll();
            authorCodeImageGalleryVB1.RemoveControls();
            save.Enabled = false;
        }


        private void browse_Click_1(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pathFolder = folderBrowserDialog1.SelectedPath;
                folder.Text = pathFolder;
            }
        }

        private void conct_Click(object sender, EventArgs e)
        {
            co = !co;
            server = serverInp.Text;
            database = databaseInp.Text;
            idDb = userInp.Text;
            pwdDb = passwordInp.Text;
            db_connection();
            if (state == true && co == true)
            {
                authorCodeImageGalleryVB1.setServer = server;
                authorCodeImageGalleryVB1.setDatabase = database;
                authorCodeImageGalleryVB1.setidDb = idDb;
                authorCodeImageGalleryVB1.setpwdDb = pwdDb;
                getProgram();
                getEvent();
                getLokasi();
                getFotografer();
                program.Enabled = true;
                vent.Enabled = true;
                lokasi.Enabled = true;
                fotografer.Enabled = true;
                dateTimePicker1.Enabled = true;
                tag.Enabled = true;
                index.Enabled = true;
                browse.Enabled = true;
                conct.Text = "Disconnect";
                serverInp.Enabled = false;
                databaseInp.Enabled = false;
                userInp.Enabled = false;
                passwordInp.Enabled = false;
            }
            else if(state == true && co == false)
            {
                authorCodeImageGalleryVB1.RemoveControls();
                clearAll();
                program.Enabled = false;
                vent.Enabled = false;
                lokasi.Enabled = false;
                fotografer.Enabled = false;
                dateTimePicker1.Enabled = false;
                tag.Enabled = false;
                index.Enabled = false;
                browse.Enabled = false;
                conct.Enabled = true;
                serverInp.Enabled = true;
                databaseInp.Enabled = true;
                userInp.Enabled = true;
                passwordInp.Enabled = true;
            }
            
        }






      
        

        
    }
    
}

public class ComboboxItem
{
    public string Text { get; set; }
    public object Value { get; set; }

    public override string ToString()
    {
        return Text;
    }
}
