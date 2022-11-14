using Microsoft.Data.SqlClient;
using WFA221114_1.Properties;

namespace WFA221114_1
{
    public partial class FrmMain : Form
    {
        public FrmMain() => InitializeComponent();

        private void FrmMain_Load(object sender, EventArgs e)
        {
            dgvMain.Rows.Clear();
            using SqlConnection connection = new(Resources.ConnectionString);
            connection.Open();
            SqlDataReader reader = new SqlCommand(
                cmdText: "SELECT unikornis.id, fajta.nev, tenyeszto.nev, varos, suly, nem " +
                "FROM unikornis " +
                "INNER JOIN fajta ON fajtaId = fajta.id " +
                "INNER JOIN tenyeszto ON tenyesztoId = tenyeszto.id " +
                "ORDER BY unikornis.id ASC;",
                connection: connection)
                .ExecuteReader();
            while (reader.Read()) dgvMain.Rows.Add(
                reader[0],
                reader[1],
                reader[2],
                reader[3],
                $"{reader[4]} Kg",
                reader.GetBoolean(5) ? "csõdör" : "kanca");
        }
    }
}