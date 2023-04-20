using Microsoft.Data.SqlClient;
using diafilm.Properties;

namespace diafilm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnTbKeresesTextChanged(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            RefreshTable();
        }

        public void RefreshTable()
        {
            string query = tbKereses.Text;

            SqlConnection connection = new(Resources.ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(
                "SELECT film.id, cim, kiadasiev, kocka, szinese, nev " +
                "FROM film " +
                "INNER JOIN kiado ON film.kiadoid = kiado.id " +
                $"WHERE cim LIKE '{query}%' " +
                "ORDER BY kiadasiev ASC, cim ASC;",
                connection);
            SqlDataReader reader = command.ExecuteReader();

            dgvFilmek.Rows.Clear();
            while (reader.Read())
            {
                //MessageBox.Show(reader[2].ToString());
                dgvFilmek.Rows.Add(
                    reader[0],
                    reader[1],
                    string.IsNullOrWhiteSpace(reader[2].ToString()) ? "nincs adat" : reader[2],
                    string.IsNullOrWhiteSpace(reader[3].ToString()) ? "nincs adat" : reader[3],
                    reader.GetBoolean(4) ? "SZ" : "FF",
                    reader[5]);
            }

            reader.Close();
            connection.Close();
        }

        private void OnBtnDeleteClick(object sender, EventArgs e)
        {
            if (dgvFilmek.SelectedRows.Count == 0) return;
            if (MessageBox.Show("Biztosan ki szeretné körölni a rekordot?", "Adattörlés", MessageBoxButtons.YesNoCancel) != DialogResult.Yes) return;

            int id = int.Parse(dgvFilmek.SelectedCells[0].Value.ToString());

            SqlConnection connection = new(Resources.ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(
                $"DELETE FROM film WHERE id = {id};",
                connection);
            command.ExecuteNonQuery();
            connection.Close();

            RefreshTable();
        }

        private void OnBtnModifyClick(object sender, EventArgs e)
        {
            if (dgvFilmek.SelectedCells[0].Value.ToString() is null) return;
            int id = int.Parse(dgvFilmek.SelectedCells[0].Value.ToString());
            new ModifyForm(id, this).Show();
        }
    }
}