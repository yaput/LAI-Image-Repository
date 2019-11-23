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

namespace Viewer
{
    public partial class Form1 : Form
    {
        private string conn;
        public MySqlConnection connect;
        public string server;
        public string database;
        public string idDb;
        public string pwdDb;
        private int count;
        bool state;
        bool co = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void clearAll()
        {
            vent.SelectedIndex = -1;
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

       /* private void getProgram()
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
        }*/

        private void getEvent()
        {
            db_connection();
            vent.Items.Clear();
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
                Console.WriteLine(co);
                authorGallery1.setServer = server;
                authorGallery1.setDatabase = database;
                authorGallery1.setidDb = idDb;
                authorGallery1.setpwdDb = pwdDb;
                conct.Text = "Disconnect";
                serverInp.Enabled = false;
                databaseInp.Enabled = false;
                userInp.Enabled = false;
                passwordInp.Enabled = false;
                vent.Enabled = true;
                search.Enabled = true;
                keyword.Enabled = true;
                refresh.Enabled = true;
                getEvent();
            }else if(state == true && co == false){
                authorGallery1.RemoveControls();
                clearAll();
                conct.Text = "Connect";
                serverInp.Enabled = true;
                databaseInp.Enabled = true;
                userInp.Enabled = true;
                passwordInp.Enabled = true;
                vent.Enabled = false;
                search.Enabled = false;
                keyword.Enabled = false;
                refresh.Enabled = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serverInp.Text = "localhost";
            databaseInp.Text = "lai1";
            userInp.Text = "root";
            passwordInp.Text = "";
            search.Enabled = false;
            vent.Enabled = false;
            request.Enabled = false;
        }


        private void search_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            search.Enabled = false;
            search.Visible = false;
            progressBar1.Visible = true;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            
            try
            {
                db_connection();
                MySqlCommand cmd = new MySqlCommand();
                if (vent.SelectedIndex == -1 && keyword.Text == "")
                {
                    cmd.CommandText = "SELECT count(PathPhoto) from tbphoto";
                    cmd.Connection = connect;
                    MySqlDataReader rs = cmd.ExecuteReader();
                    if (rs.Read())
                    {
                        count = rs.GetInt32(0);
                        progressBar1.Maximum = count;
                    }
                    connect.Close();
                }else if(vent.SelectedIndex == -1 && keyword.Text != "")
                {
                    cmd.CommandText = "SELECT count(PathPhoto) from tbphoto where TagPhoto like '%" + keyword.Text + "%' or CaptionPhoto like '%" + keyword.Text + "%'";
                    cmd.Connection = connect;
                    MySqlDataReader rs = cmd.ExecuteReader();
                    if (rs.Read())
                    {
                        count = rs.GetInt32(0);
                        progressBar1.Maximum = count;
                    }
                    connect.Close();
                }else if(vent.SelectedIndex != -1 && keyword.Text == ""){
                    cmd.CommandText = "SELECT count(PathPhoto) from tbphoto where tbEvent_ID_Event = '" + (vent.SelectedItem as ComboboxItem).Value.ToString() + "'";
                    cmd.Connection = connect;
                    MySqlDataReader rs = cmd.ExecuteReader();
                    if (rs.Read())
                    {
                        count = rs.GetInt32(0);
                        progressBar1.Maximum = count;
                    }
                    connect.Close();
                }
                else if(vent.SelectedIndex != -1 && keyword.Text != "")
                {
                    cmd.CommandText = "SELECT count(PathPhoto) from tbphoto where tbEvent_ID_Event = '" + (vent.SelectedItem as ComboboxItem).Value.ToString() + "' and TagPhoto like '%" + keyword.Text + "%' or tbEvent_ID_Event = '" + (vent.SelectedItem as ComboboxItem).Value.ToString() + "' and CaptionPhoto like '%" + keyword.Text + "%'";
                    cmd.Connection = connect;
                    MySqlDataReader rs = cmd.ExecuteReader();
                    if (rs.Read())
                    {
                        count = rs.GetInt32(0);
                        progressBar1.Maximum = count;
                    }
                    connect.Close();
                }

                Console.WriteLine(count.ToString());
                
                string[] ID_Photo = new string[count];
                try
                {
                db_connection();
                MySqlCommand cm = new MySqlCommand();
                if (vent.SelectedIndex == -1 && keyword.Text == "")
                {
                    cm.CommandText = "SELECT PathPhoto from tbphoto";
                    cm.Connection = connect;
                    MySqlDataReader rss = cm.ExecuteReader();
                    int x = 0;
                    while (rss.Read())
                    {
                        ID_Photo[x] = rss.GetString(0);
                        x = x + 1;
                        progressBar1.Value = x;
                    }
                    connect.Close();
                }
                else if (vent.SelectedIndex == -1 && keyword.Text != "")
                {
                    cm.CommandText = "SELECT PathPhoto from tbphoto where TagPhoto like '%" + keyword.Text + "%' or CaptionPhoto like '%" + keyword.Text + "%'";
                    cm.Connection = connect;
                    MySqlDataReader rss = cm.ExecuteReader();
                    int x = 0;
                    while (rss.Read())
                    {
                        ID_Photo[x] = rss.GetString(0);
                        x = x + 1;
                        progressBar1.Value = x;
                    }
                    connect.Close();
                }
                else if (vent.SelectedIndex != -1 && keyword.Text == "")
                {
                    cm.CommandText = "SELECT PathPhoto from tbphoto where tbEvent_ID_Event = '" + (vent.SelectedItem as ComboboxItem).Value.ToString() + "'";
                    cm.Connection = connect;
                    MySqlDataReader rss = cm.ExecuteReader();
                    int x = 0;
                    while (rss.Read())
                    {
                        ID_Photo[x] = rss.GetString(0);
                        x = x + 1;
                        progressBar1.Value = x;
                    }
                    connect.Close();
                }
                else if (vent.SelectedIndex != -1 && keyword.Text != "")
                {
                    cm.CommandText = "SELECT PathPhoto from tbphoto where tbEvent_ID_Event = '" + (vent.SelectedItem as ComboboxItem).Value.ToString() + "' and TagPhoto like '%" + keyword.Text + "%' or tbEvent_ID_Event = '" + (vent.SelectedItem as ComboboxItem).Value.ToString() + "' and CaptionPhoto like '%" + keyword.Text + "%'";
                    cm.Connection = connect;
                    MySqlDataReader rss = cm.ExecuteReader();
                    int x = 0;
                    while (rss.Read())
                    {
                        ID_Photo[x] = rss.GetString("PathPhoto");
                        x = x + 1;
                        progressBar1.Value = x;
                    }
                    connect.Close();
                }
               
                }
                catch(MySqlException d)
                {
                    Console.WriteLine(d.ToString());
                }
                if (count != 0)
                {
                    authorGallery1.RemoveControls();
                    authorGallery1.CreateGallery(ID_Photo);
                    
                }
                else
                {
                    MessageBox.Show("No Result Found!");
                    authorGallery1.RemoveControls();
                }
                
                progressBar1.Visible = false;
                Cursor.Current = Cursors.Default;
                search.Visible = true;
                search.Enabled = true;
                request.Enabled = true;
            }
            catch(MySqlException es)
            {
                MessageBox.Show(es.ToString());
            }
            watch.Stop();
            var elapsedMs = watch.Elapsed.TotalSeconds.ToString();
            time.Text = elapsedMs + " Seconds";
            time.Visible = true;
        }

        private void request_Click(object sender, EventArgs e)
        {
            List<string> requestt = new List<string>();
            MySqlCommand cmd = new MySqlCommand();
            foreach (string id in authorGallery1.idTxt)
            {
                db_connection();
                cmd.CommandText = "SELECT NamaPhoto, PathPhoto from tbphoto where ID_Photo = " + id;
                cmd.Connection = connect;
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {
                    requestt.Add("ID Foto = " + id + ", Nama Foto = " + rs.GetString("NamaPhoto") + ", Path Foto = "+rs.GetString("PathPhoto").Replace('/','\\'));
                }
                connect.Close();
            }

            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "FileName.txt";
            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                TextWriter tw = new StreamWriter(save.FileName);

                foreach (String s in requestt)
                    tw.WriteLine(s);

                tw.Dispose();
                tw.Close();
                MessageBox.Show("Request Photo(s) Saved", "Information");
                request.Enabled = false;
                vent.Text = "";
            }

            
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            clearAll();
            getEvent();
            keyword.Text = "";
        }

       

    }
}
