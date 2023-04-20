using diafilm.Properties;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diafilm
{
    public partial class ModifyForm : Form
    {
        private readonly int id;
        private readonly MainForm parent;
        public ModifyForm(int id, MainForm form)
        {
            this.id = id;
            this.parent = form;
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            SqlConnection connection = new(Resources.ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(
                "SELECT nev FROM kiado;",
                connection);
            SqlDataReader reader = command.ExecuteReader();

            cbKiado.Items.Clear();
            while (reader.Read())
            {
                cbKiado.Items.Add(reader.GetString(0));
            }

            reader.Close();

            command = new SqlCommand(
                "SELECT cim, kiadasiev, kocka, szinese, nev " +
                "FROM film " +
                "INNER JOIN kiado ON film.kiadoid = kiado.id " +
                $"WHERE film.id = {id};",
                connection);
            reader = command.ExecuteReader();
            reader.Read();

            tbCim.Text = reader.GetString(0);
            tbKiadasEve.Text = string.IsNullOrWhiteSpace(reader[1].ToString()) ? "" : reader.GetInt32(1).ToString();
            tbKocka.Text = string.IsNullOrWhiteSpace(reader[2].ToString()) ? "" : reader.GetInt32(2).ToString();
            if (reader.GetBoolean(3)) rbIgen.Checked = true;
            else rbNem.Checked = true;
            cbKiado.SelectedItem = reader.GetString(4);
        }

        private void OnBtnFelvetelClick(object sender, EventArgs e)
        {
            string cim, kiadasiev, kocka, kiado;
            int szinese;
            if (ValidateInput(out cim, out kiadasiev, out kocka, out szinese, out kiado)) return;
            

            if (MessageBox.Show("Szeretné felvenni a filmet?", "Felvétel", MessageBoxButtons.YesNoCancel) != DialogResult.Yes) return;
            
            SqlConnection connection = new(Resources.ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(
                $"INSERT INTO film (cim, kiadasiev, kocka, szinese, kiadoid) VALUES ('{cim}', {kiadasiev}, {kocka}, {szinese}, (SELECT id FROM kiado WHERE nev = '{kiado}'));",
                connection);
            command.ExecuteNonQuery();
            connection.Close();

            parent.RefreshTable();
            Close();
        }

        private void OnBtnModositasClick(object sender, EventArgs e)
        {
            string cim, kiadasiev, kocka, kiado;
            int szinese;
            if (ValidateInput(out cim, out kiadasiev, out kocka, out szinese, out kiado)) return;

            if (MessageBox.Show("Szeretné módosítani a filmet?", "Módosítás", MessageBoxButtons.YesNoCancel) != DialogResult.Yes) return;

            SqlConnection connection = new(Resources.ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(
                $"UPDATE film SET cim = '{cim}', kiadasiev = {kiadasiev}, kocka = {kocka}, szinese = {szinese}, kiadoid = (SELECT id FROM kiado WHERE nev = '{kiado}') WHERE id = {id};",
                connection);
            command.ExecuteNonQuery();
            connection.Close();

            parent.RefreshTable();
            Close();
        }

        private bool ValidateInput(out string cim, out string kiadasiev, out string kocka, out int szinese, out string kiado)
        {
            cim = kiadasiev = kocka = kiado = "";
            szinese = -1;

            cim = tbCim.Text;
            if (string.IsNullOrWhiteSpace(cim))
            {
                MessageBox.Show("Ne hagyja üresen a címet!");
                return true;
            }

            kiadasiev = tbKiadasEve.Text;
            if (!string.IsNullOrWhiteSpace(kiadasiev) && !int.TryParse(kiadasiev, out _))
            {
                MessageBox.Show("Nem megfelelő számformátum a kiadás évéhez!");
                return true;
            }
            if (string.IsNullOrWhiteSpace(kiadasiev)) kiadasiev = "NULL";

            kocka = tbKocka.Text;
            if (!string.IsNullOrWhiteSpace(kocka) && !int.TryParse(kocka, out _))
            {
                MessageBox.Show("Nem megfelelő számformátum a képkockaszámhoz!");
                return true;
            }
            if (string.IsNullOrWhiteSpace(kocka)) kocka = "NULL";

            szinese = rbIgen.Checked ? 1 : 0;

            kiado = cbKiado.SelectedItem.ToString();

            return false;
        }
    }
}
