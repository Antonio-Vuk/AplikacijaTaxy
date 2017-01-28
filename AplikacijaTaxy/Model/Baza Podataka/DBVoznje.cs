using System;
using Mono.Data.Sqlite;
using System.Collections.Generic;

namespace AplikacijaTaxy {
	public static class DBVoznje {
		static DBVoznje() {
			SqliteCommand com = BazaPodataka.con.CreateCommand();

			com.CommandText = @"CREATE TABLE IF NOT EXISTS Voznja (
				id integer primary key autoincrement,
				narucitelj nvarchar(32) NOT NULL,
				kontakt nvarchar(32) NOT NULL,
				pocetna_lokacija nvarchar(32) NOT NULL,
				zavrsna_lokacija nvarchar(32),
                cijena LONG,
				id_vozaca integer,
				datum LONG NOT NULL,
				vrijeme nvarchar(32) NOT NULL,
				obavljeno boolean NOT NULL)";

			com.ExecuteNonQuery();
			com.Dispose();
		}
		public static void IzmijeniVoznju(string narucitelj, string mob, string lok_od, 
		                                  string lok_do, long cijena, int id_vozaca, 
		                                  DateTime datum, string vrijeme, long id) {
			SqliteCommand c = BazaPodataka.con.CreateCommand();

			c.CommandText = string.Format(@"UPDATE Voznja SET   narucitelj = '{0}', 
																kontakt = '{1}', 
																pocetna_lokacija = '{2}',
																zavrsna_lokacija = '{3}',
																cijena = '{4}',
																id_vozaca = '{5}',
																datum = '{6}',
																vrijeme = '{7}'
											WHERE id = '{8}'", narucitelj, mob, lok_od, lok_do, 
			                              cijena, id_vozaca, datum, vrijeme, id);
			c.ExecuteNonQuery();
			c.Dispose();
		}

		public static void potvrdiVoznju(long id) {
			SqliteCommand c = BazaPodataka.con.CreateCommand();

			c.CommandText = string.Format(@"UPDATE Voznja SET   obavljeno = '{0}' WHERE id = '{1}'", 1, id);
			c.ExecuteNonQuery();
			c.Dispose();
		}

		public static void DodajVoznju(string narucitelj, string mob, string lok_od, string lok_do, long cijena, 
		                               int id_vozaca, DateTime datum, string vrijeme) { 
			SqliteCommand c = BazaPodataka.con.CreateCommand();

			c.CommandText = string.Format(@"INSERT INTO Voznja (narucitelj, kontakt, pocetna_lokacija, zavrsna_lokacija, 
											cijena, id_vozaca, datum, vrijeme, obavljeno)
											VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", 
			                              narucitelj, mob, lok_od, lok_do, cijena, id_vozaca, datum.ToFileTime(), vrijeme, 0);

			c.ExecuteNonQuery();
			c.Dispose();
		}

		public static List<Voznja> DohvatiNePotvrgeneVoznje() {
			var lista = new List<Voznja>();

			SqliteCommand c = BazaPodataka.con.CreateCommand();

			c.CommandText = string.Format(@"SELECT 	id, narucitelj, kontakt, pocetna_lokacija, zavrsna_lokacija, cijena, 
													id_vozaca, datum, vrijeme, obavljeno 
											FROM Voznja 
											WHERE obavljeno = '{0}'", 0);

			SqliteDataReader reader = c.ExecuteReader();

			while (reader.Read()) {
				Voznja voznja = new Voznja();
				voznja.id = (long)reader["id"];
				voznja.Naziv_osobe = (string)reader["narucitelj"];
				voznja.Kontakt = (string)reader["kontakt"];
				voznja.Pocetna_lokacija = (string)reader["pocetna_lokacija"];
				voznja.Zavrsna_lokacija = (string)reader["zavrsna_lokacija"];
				voznja.Cijena = (long)reader["cijena"];
				voznja.Radnik = DBVozaci.DohvatiPoOIDVozaca((int)(long)reader["id_vozaca"]);
				voznja.Datum = DateTime.FromFileTime(reader.GetInt64(7));
				voznja.Vrijeme = (string)reader["vrijeme"];
				voznja.Obavljeno = ((bool)reader["obavljeno"]);

				lista.Add(voznja);
			}
			c.Dispose();
			return lista;
		}

		public static List<Voznja> DohvatiPotvrgeneVoznje() {
			var lista = new List<Voznja>();

			SqliteCommand c = BazaPodataka.con.CreateCommand();

			c.CommandText = string.Format(@"SELECT 	id, narucitelj, kontakt, pocetna_lokacija, zavrsna_lokacija, cijena, 
													id_vozaca, datum, vrijeme, obavljeno 
											FROM Voznja 
											WHERE obavljeno = '{0}'", 1);

			SqliteDataReader reader = c.ExecuteReader();

			while (reader.Read()) {
				Voznja voznja = new Voznja();
				voznja.id = (long)reader["id"];
				voznja.Naziv_osobe = (string)reader["narucitelj"];
				voznja.Kontakt = (string)reader["kontakt"];
				voznja.Pocetna_lokacija = (string)reader["pocetna_lokacija"];
				voznja.Zavrsna_lokacija = (string)reader["zavrsna_lokacija"];
				voznja.Cijena = (long)reader["cijena"];
				voznja.Radnik = DBVozaci.DohvatiPoOIDVozaca((int)(long)reader["id_vozaca"]);
				voznja.Datum = DateTime.FromFileTime(reader.GetInt64(7));
				voznja.Vrijeme = (string)reader["vrijeme"];
				voznja.Obavljeno = ((bool)reader["obavljeno"]);

				lista.Add(voznja);
			}
			c.Dispose();
			return lista;
		}

		public static void obrisiVoznju(Voznja n) {
			SqliteCommand c = BazaPodataka.con.CreateCommand();

			c.CommandText = string.Format("	DELETE from Voznja WHERE id = '{0}' ", n.id);

			c.ExecuteNonQuery();
			c.Dispose();
		}

		public static List<Voznja> DohvatiPoNarucitelju(string narucitelj) {
			var lista = new List<Voznja>();

			SqliteCommand c = BazaPodataka.con.CreateCommand();

			c.CommandText = string.Format(@"SELECT 	id, narucitelj, kontakt, pocetna_lokacija, zavrsna_lokacija, cijena, 
													id_vozaca, datum, vrijeme, obavljeno FROM Voznja 
											WHERE narucitelj LIKE '%{0}%'", narucitelj);

			SqliteDataReader reader = c.ExecuteReader();

			while (reader.Read()) {
				Voznja voznja = new Voznja();
				voznja.id = (long)reader["id"];
				voznja.Naziv_osobe = (string)reader["narucitelj"];
				voznja.Kontakt = (string)reader["kontakt"];
				voznja.Pocetna_lokacija = (string)reader["pocetna_lokacija"];
				voznja.Zavrsna_lokacija = (string)reader["zavrsna_lokacija"];
				voznja.Cijena = (long)reader["cijena"];
				voznja.Radnik = DBVozaci.DohvatiPoOIDVozaca((int)(long)reader["id_vozaca"]);
				voznja.Datum = DateTime.FromFileTime(reader.GetInt64(7));
				voznja.Vrijeme = (string)reader["vrijeme"];
				voznja.Obavljeno = ((bool)reader["obavljeno"]);

				lista.Add(voznja);
			}
			c.Dispose();
			return lista;
		}

		public static List<Voznja> DohvatiPoNaruciteljuPotvrgene(string narucitelj) {
			var lista = new List<Voznja>();

			SqliteCommand c = BazaPodataka.con.CreateCommand();

			c.CommandText = string.Format(@"SELECT 	id, narucitelj, kontakt, pocetna_lokacija, zavrsna_lokacija, 
													cijena, id_vozaca, datum, vrijeme, obavljeno 
											FROM Voznja 
											WHERE narucitelj LIKE '%{0}%' AND obavljeno = '{1}'", narucitelj, 1);

			SqliteDataReader reader = c.ExecuteReader();

			while (reader.Read()) {
				Voznja voznja = new Voznja();
				voznja.id = (long)reader["id"];
				voznja.Naziv_osobe = (string)reader["narucitelj"];
				voznja.Kontakt = (string)reader["kontakt"];
				voznja.Pocetna_lokacija = (string)reader["pocetna_lokacija"];
				voznja.Zavrsna_lokacija = (string)reader["zavrsna_lokacija"];
				voznja.Cijena = (long)reader["cijena"];
				voznja.Radnik = DBVozaci.DohvatiPoOIDVozaca((int)(long)reader["id_vozaca"]);
				voznja.Datum = DateTime.FromFileTime(reader.GetInt64(7));
				voznja.Vrijeme = (string)reader["vrijeme"];
				voznja.Obavljeno = ((bool)reader["obavljeno"]);

				lista.Add(voznja);
			}
			c.Dispose();
			return lista;
		}
	}
}