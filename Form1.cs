using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Alles_wiederholen
{
    public partial class Form1 : Form
    {
        Kontodaten konto = new Kontodaten();
        bool loggi = false;




        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Bestellungen_DB.mdb");
            OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from Mitarbeiter where Vorname='"+ txt_box_vorname.Text +"' and Nachname='"+ txt_box_nachname.Text +"' and Kennwort='"+ txt_box_kennwort.Text +"';";
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader["Vorname"].ToString() == txt_box_vorname.Text && reader["Nachname"].ToString() == txt_box_nachname.Text && reader["Kennwort"].ToString() == txt_box_kennwort.Text)
                {
                    konto.info(Convert.ToInt32(reader.GetValue(0).ToString()), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString());
                    loggi = true;
                }
            }



            reader.Close();
            con.Close();
            if (loggi)
            {
                MessageBox.Show("Loggi ich bin Floggi");
            }
        }
    }
}
