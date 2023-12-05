using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLogin
{
    public partial class Form_delete : Form
    {
        public Form_delete()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Termek kivalasztottTermek = (Termek)listBox_termek.SelectedItem;
            textBox1.Text = kivalasztottTermek.termeknev.ToString();
            numericUpDown_termekid.Value = (decimal)kivalasztottTermek.termekid;
        }
    }
}
