using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLogin
{
    public partial class Form_uj : Form
    {
        public Form_uj()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, EventArgs e)
        {

            Program.command.CommandText = "INSERT INTO `termek`(`termekid`, `termeknev`, `ar`, `db`) VALUES('" +"" + "','" + textBox_termeknev.Text + "','" + numericUpDown_termekar.Value + "','" + numericUpDown_termekdb.Value + "')";

            try
            {
                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();

                }
                Program.command.ExecuteNonQuery();
                MessageBox.Show("Sikeres rögzítés");
                Program.formVasarlas.termekekBetoltese();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
