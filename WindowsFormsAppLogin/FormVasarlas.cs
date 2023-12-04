using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppLogin
{
    public partial class FormVasarlas : Form
    {
        MySqlConnection connection = null;
        MySqlCommand command = null;

        public FormVasarlas()
        {
            InitializeComponent();
        }

        private void FormVasarlas_Load(object sender, EventArgs e)
        {
            termekekBetoltese();
        }

        private void termekekBetoltese()
        {
            listBox_termek.Items.Clear();
            try
            {
                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }
                Program.command.CommandText = "SELECT `termekid`, `termeknev`, `ar`, `db` FROM `termek` WHERE 1 ORDER BY termeknev";
                using (MySqlDataReader dr = Program.command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Termek beolvasottTermek = new Termek(dr.GetInt32("termekid"), dr.GetString("termeknev"), dr.GetInt32("ar"), dr.GetInt32("db"));
                        listBox_termek.Items.Add(beolvasottTermek);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "bunko");
                Environment.Exit(0);
            }
        }
        private void listBox_termek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_termek.SelectedIndex<0)
            {
                return;
            }
            Termek kivalasztottTermek = (Termek)listBox_termek.SelectedItem;
            textBox1.Text = kivalasztottTermek.termeknev.ToString();
            textBox2.Text = kivalasztottTermek.db.ToString();
            numericUpDown_ar.Value = (decimal) kivalasztottTermek.ar;
            numericUpDown_termekid.Value = (decimal)kivalasztottTermek.termekid;
            numericUpDown_db.Maximum = kivalasztottTermek.db;



        }

        private void button_vasarlas_Click(object sender, EventArgs e)
        {
            //decimal osszeg = (decimal)numericUpDown_ar.Value;
           // decimal db = (decimal)numericUpDown_db.Value;
           // numericUpDown_vegosszeg.Value = osszeg * db;

            string nev = textBox1.Text;
            decimal darab = numericUpDown_db.Value;
            decimal vegosszeg = numericUpDown_vegosszeg.Value;
            decimal tid = numericUpDown_termekid.Value;
            
            
            Program.command.CommandText = "INSERT INTO `rendeles`(`termekid`, `vasarloid`, `db`, `ar`) VALUES (@tid, @uid ,@db, @vegosszeg); UPDATE `termek` SET `db`=`db`-@db WHERE `termeknev` = @termeknev ";

            Program.command.Parameters.Clear();
            Program.command.Parameters.AddWithValue("@termeknev", nev);
            Program.command.Parameters.AddWithValue("@db", darab);
            Program.command.Parameters.AddWithValue("@vegosszeg", vegosszeg);
            Program.command.Parameters.AddWithValue("@tid", tid);
            Program.command.Parameters.AddWithValue("@uid", Program.userid);
            try
            {
                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();

                }
                Program.command.ExecuteNonQuery();
                MessageBox.Show("Sikeres rögzítés");
                textBox1.Text = "";
                textBox2.Text = "";
                numericUpDown_ar.Value = 0;
                numericUpDown_db.Value = 1;
                numericUpDown_termekid.Value = 1;
                numericUpDown_vegosszeg.Value = 0;
                numericUpDown_ar.Value = 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void numericUpDown_db_ValueChanged(object sender, EventArgs e)
        {
            decimal osszeg = (decimal)numericUpDown_ar.Value;
            decimal db = (decimal)numericUpDown_db.Value;
            numericUpDown_vegosszeg.Value = osszeg * db;
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.formuj.ShowDialog();
        }
    }
}
