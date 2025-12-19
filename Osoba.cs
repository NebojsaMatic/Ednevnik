using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ednevnik
{
    public partial class Osoba : Form
    {
        int br_sloga;
        DataTable tabela;
        public Osoba()
        {
            InitializeComponent();
        }
        public void prikazi()
        {
            if (tabela.Rows.Count == 0)
            {
                txt_id.Text = "";
                txt_ime.Text = "";
                txt_prezime.Text = "";
                txt_adresa.Text = "";
                txt_jmbg.Text = "";
                txt_email.Text = "";
                txt_pass.Text = "";
                txt_uloga.Text = "";
                button_brisi.Enabled = false;
            }
            else
            {
                txt_id.Text = tabela.Rows[br_sloga]["id"].ToString();
                txt_ime.Text = tabela.Rows[br_sloga]["ime"].ToString();
                txt_prezime.Text = tabela.Rows[br_sloga]["prezime"].ToString();
                txt_adresa.Text = tabela.Rows[br_sloga]["adresa"].ToString();
                txt_jmbg.Text = tabela.Rows[br_sloga]["jmbg"].ToString();
                txt_email.Text = tabela.Rows[br_sloga]["email"].ToString();
                txt_pass.Text = tabela.Rows[br_sloga]["pass"].ToString();
                txt_uloga.Text = tabela.Rows[br_sloga]["uloga"].ToString();
                button_brisi.Enabled = true;
            }
            if (br_sloga == tabela.Rows.Count - 1)
            {
                button_sledeci.Enabled = false;
                button_poslednji.Enabled = false;
            }

            else
            {
                button_poslednji.Enabled = true;
                button_sledeci.Enabled = true;
            }
            if (br_sloga == 0)
            {
                button_prvi.Enabled = false;
                button_prethodni.Enabled = false;
            }
            else
            {
                button_prethodni.Enabled = true;
                button_prvi.Enabled = true;
            }
        }

        private void Osoba_Load(object sender, EventArgs e)
        {
            br_sloga = 0;
            SqlConnection veza = konekcija.povezi();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM osoba", veza);
            tabela = new DataTable();
            da.Fill(tabela);
            prikazi();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_prvi_Click(object sender, EventArgs e)
        {
            br_sloga = 0;
            prikazi();
        }

        private void button_prethodni_Click(object sender, EventArgs e)
        {
            br_sloga--;
            prikazi();
        }

        private void button_sledeci_Click(object sender, EventArgs e)
        {
            br_sloga++;
            prikazi();
        }

        private void button_poslednji_Click(object sender, EventArgs e)
        {
            br_sloga = tabela.Rows.Count - 1;
            prikazi();
        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            // INSERT INTO osoba 
            // VALUES('Jana', 'Karenjina',
            // 'Glavna', '123123', 'aaa@bbb', '123', 1)
            string naredba = "INSERT INTO osoba VALUES('";
            naredba = naredba + txt_ime.Text + "','";
            naredba = naredba + txt_prezime.Text + "','";
            naredba = naredba + txt_adresa.Text + "','";
            naredba = naredba + txt_jmbg.Text + "','";
            naredba = naredba + txt_pass.Text + "','";
            naredba = naredba + txt_uloga.Text + "',1)";
            SqlConnection veza = konekcija.povezi();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
           
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM osoba", veza);
            tabela = new DataTable();
            da.Fill(tabela);
            br_sloga = tabela.Rows.Count - 1;
            prikazi();
        }

        private void button_izmeni_Click(object sender, EventArgs e)
        {
            // PROMENI
            string naredba = "UPDATE osoba SET ";
            naredba += "ime='" + txt_ime.Text + "',";
            naredba += "prezime='" + txt_prezime.Text + "',";
            naredba += "adresa='" + txt_adresa.Text + "',";
            naredba += "jmbg='" + txt_jmbg.Text + "'";
            naredba += "WHERE id = " + txt_id.Text;
            SqlConnection veza = konekcija.povezi();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM osoba", veza);
            tabela = new DataTable();
            da.Fill(tabela);
            prikazi();
        }

        private void button_brisi_Click(object sender, EventArgs e)
        {
            if (br_sloga == tabela.Rows.Count - 1)
            {
                br_sloga--;
            }
            string naredba = "DELETE FROM osoba WHERE id=" + txt_id.Text;
            SqlConnection veza = konekcija.povezi();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.GetType().ToString());
            }

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM osoba", veza);
            tabela = new DataTable();
            da.Fill(tabela);
            prikazi();
        }
    }
}
