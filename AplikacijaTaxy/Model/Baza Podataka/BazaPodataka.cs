using Mono.Data.Sqlite;
namespace AplikacijaTaxy {
	public static class BazaPodataka {
		
		private static string connectionString = "URI=file:MojaBaza.db3, version=3";

		internal static SqliteConnection con = new SqliteConnection(connectionString);

		internal static void OtvoriKonekciju() {
			con.Open();
		}

		internal static void ZatvoriKonekciju() {
			con.Close();
		}
	}
}
