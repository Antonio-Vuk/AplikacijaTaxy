using System;
using Mono.Data.Sqlite;
using System.Collections.Generic;

namespace AplikacijaTaxy {
	public static class DBVozaci {
		static DBVozaci() {
			SqliteCommand com = BazaPodataka.con.CreateCommand();

			com.CommandText = @"CREATE TABLE IF NOT EXISTS Vozaci (
				id integer primary key autoincrement,
				ime nvarchar(32) NOT NULL,
				prezime nvarchar(32) NOT NULL,
				oib nvarchar(32) NOT NULL,
                iban nvarchar(32) NOT NULL,
				broj_mobitela nvarchar(32) NOT NULL,
				adresa nvarchar(32) NOT NULL,
				placa long NOT NULL,
				id_vozila integer NOT NULL,
				FOREIGN KEY(id_vozila) REFERENCES Vozila(id),
				CONSTRAINT oib_unigue UNIQUE(oib),
				CONSTRAINT iban_unigue UNIQUE(iban),
				CONSTRAINT broj_mobitela_unigue UNIQUE(broj_mobitela),
				CONSTRAINT id_vozila_unigue UNIQUE(id_vozila))";

			com.ExecuteNonQuery();
			com.Dispose();
		}

		public static bool provjeriVozilo(long id) {
			SqliteCommand countCommand = BazaPodataka.con.CreateCommand();

			countCommand.CommandText = string.Format(@"SELECT COUNT(*) 
											FROM Vozaci 
											WHERE id_vozila = '{0}'", id);
			long count = (long)countCommand.ExecuteScalar();
			countCommand.Dispose();

			if (count == 0) {
				return true;
			}
			return false;
		}

		public static bool provjeriOib(long? id, string oib) {
			SqliteCommand countCommand = BazaPodataka.con.CreateCommand();
			string idString = "-1";
			if (id != null) idString = id.ToString();

			countCommand.CommandText = string.Format(@"SELECT COUNT(*) 
											FROM Vozaci 
											WHERE oib = '{0}' AND id != {1}", oib, idString);
			long count = (long)countCommand.ExecuteScalar();
			countCommand.Dispose();

			if (count == 0) {
				return true;
			}
			return false;
		}
		public static bool provjeriIban(long? id, string iban) {
			SqliteCommand countCommand = BazaPodataka.con.CreateCommand();
			string idString = "-1";
			if (id != null) idString = id.ToString();

			countCommand.CommandText = string.Format(@"SELECT COUNT(*) 
											FROM Vozaci 
											WHERE iban = '{0}' AND id != {1}", iban, idString);
			long count = (long)countCommand.ExecuteScalar();
			countCommand.Dispose();

			if (count == 0) {
				return true;
			}
			return false;
		}
		public static bool provjeriBroj_mobitela(long? id, string broj_mobitela) {
			SqliteCommand countCommand = BazaPodataka.con.CreateCommand();
			string idString = "-1";
			if (id != null) idString = id.ToString();

			countCommand.CommandText = string.Format(@"SELECT COUNT(*) 
											FROM Vozaci 
											WHERE broj_mobitela = '{0}' AND id != {1}", broj_mobitela, idString);
			long count = (long)countCommand.ExecuteScalar();
			countCommand.Dispose();

			if (count == 0) {
				return true;
			}
			return false;
		}

		public static List<Vozac> DohvatiSveVozace() {
			var lista = new List<Vozac>();

			SqliteCommand c = BazaPodataka.con.CreateCommand();

			c.CommandText = string.Format(@"SELECT id, ime, prezime, oib, iban, broj_mobitela, adresa, placa, id_vozila 
											FROM Vozaci");

			SqliteDataReader reader = c.ExecuteReader();

			while (reader.Read()) {
				Vozac radnik = new Vozac();
				radnik.id = (long)reader["id"];
				radnik.Ime = (string)reader["ime"];
				radnik.Prezime = (string)reader["prezime"];
				radnik.Oib = (string)reader["oib"];
				radnik.Iban = (string)reader["iban"];
				radnik.Broj_mobitela = (string)reader["broj_mobitela"];
				radnik.Adresa = (string)reader["adresa"];
				radnik.placa = (long)reader["placa"];
				radnik.Auto = DBVozila.DohvatiPoIDVozila((int)(long)reader["id_vozila"]);

				lista.Add(radnik);
			}
			c.Dispose();
			return lista;
		}
		public static void DodajVozaca(ref Vozac v) {
			SqliteCommand c = BazaPodataka.con.CreateCommand();

			c.CommandText = string.Format(@"INSERT INTO Vozaci (ime, prezime, oib, iban, broj_mobitela, adresa, placa, id_vozila)
				VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", v.Ime, v.Prezime, v.Oib, v.Iban, v.Broj_mobitela, v.Adresa, v.placa, v.Auto.id);

			c.ExecuteNonQuery();

			c.CommandText = "SELECT last_insert_rowid()";
			v.id = (long)c.ExecuteScalar();

			c.Dispose();
		}

		public static void IzmijeniVozaca(Vozac v) {
			SqliteCommand c = BazaPodataka.con.CreateCommand();

			c.CommandText = string.Format(@"UPDATE Vozaci SET	ime = '{0}', 
																prezime = '{1}', 
																oib = '{2}',
																iban = '{3}',
																broj_mobitela = '{4}',
																adresa = '{5}',
																placa = '{6}',
																id_vozila = '{7}'
											WHERE id = '{8}'", v.Ime, v.Prezime, v.Oib, v.Iban, v.Broj_mobitela, v.Adresa, v.placa, v.Auto.id, v.id);
			c.ExecuteNonQuery();
			c.Dispose();
		}

		public static void obrisiVozaca(Vozac radnik) {
			SqliteCommand c = BazaPodataka.con.CreateCommand();

			c.CommandText = string.Format("	DELETE from Vozaci WHERE id = '{0}' ", radnik.id);

			c.ExecuteNonQuery();
			c.Dispose();
		}
		public static List<Vozac> DohvatiPoImenuVozace(string kljucna_rijec) {
			var lista = new List<Vozac>();

			SqliteCommand c = BazaPodataka.con.CreateCommand();

			c.CommandText = string.Format(@"SELECT id, ime, prezime, oib, iban, broj_mobitela, adresa, placa, id_vozila 
											FROM Vozaci 	
											WHERE ime LIKE '%{0}%'", kljucna_rijec);

			SqliteDataReader reader = c.ExecuteReader();

			while (reader.Read()) {
				Vozac radnik = new Vozac();
				radnik.id = (long)reader["id"];
				radnik.Ime = (string)reader["ime"];
				radnik.Prezime = (string)reader["prezime"];
				radnik.Oib = (string)reader["oib"];
				radnik.Iban = (string)reader["iban"];
				radnik.Broj_mobitela = (string)reader["broj_mobitela"];
				radnik.Adresa = (string)reader["adresa"];
				radnik.placa = (long)reader["placa"];
				radnik.Auto = DBVozila.DohvatiPoIDVozila((int)(long)reader["id_vozila"]);

				lista.Add(radnik);
			}
			c.Dispose();
			return lista;
		}
		public static Vozac DohvatiPoOibuVozaca(string oib) {
			SqliteCommand c = BazaPodataka.con.CreateCommand();

			c.CommandText = string.Format(@"SELECT id, ime, prezime, oib, iban, broj_mobitela, adresa, placa, id_vozila 
											FROM Vozaci 
											WHERE oib = '{0}'", oib);

			SqliteDataReader reader = c.ExecuteReader();
			Vozac radnik = new Vozac();
			while (reader.Read()) {
				radnik.id = (long)reader["id"];
				radnik.Ime = (string)reader["ime"];
				radnik.Prezime = (string)reader["prezime"];
				radnik.Oib = (string)reader["oib"];
				radnik.Iban = (string)reader["iban"];
				radnik.Broj_mobitela = (string)reader["broj_mobitela"];
				radnik.Adresa = (string)reader["adresa"];
				radnik.placa = (long)reader["placa"];
				radnik.Auto = DBVozila.DohvatiPoIDVozila((int)(long)reader["id_vozila"]);
			}
			c.Dispose();
			return radnik;
		}
		public static Vozac DohvatiPoOIDVozaca(int id) {
			SqliteCommand c = BazaPodataka.con.CreateCommand();

			c.CommandText = string.Format(@"SELECT id, ime, prezime, oib, iban, broj_mobitela, adresa, placa, id_vozila 
											FROM Vozaci 
											WHERE id = '{0}'", id);

			SqliteDataReader reader = c.ExecuteReader();
			Vozac radnik = new Vozac();
			while (reader.Read()) {
				radnik.id = (long)reader["id"];
				radnik.Ime = (string)reader["ime"];
				radnik.Prezime = (string)reader["prezime"];
				radnik.Oib = (string)reader["oib"];
				radnik.Iban = (string)reader["iban"];
				radnik.Broj_mobitela = (string)reader["broj_mobitela"];
				radnik.Adresa = (string)reader["adresa"];
				radnik.placa = (long)reader["placa"];
				radnik.Auto = DBVozila.DohvatiPoIDVozila((int)(long)reader["id_vozila"]);
			}
			c.Dispose();
			return radnik;
		}
		public static Dictionary<string, long> ZaradaRadnika(int mjesec, int godina) {
			var Lista = new Dictionary<string, long>();

			SqliteCommand c = BazaPodataka.con.CreateCommand();
			DateTime odDatum = new DateTime(godina, mjesec, 1);
			odDatum.AddDays(-1);

			DateTime doDatum = new DateTime(godina, mjesec + 1, 1);


			c.CommandText = string.Format(@"SELECT 	SUM(cijena) as suma,vozaci.ime as ime ,vozaci.prezime as prezime
											FROM Voznja,vozaci
											WHERE datum < '{0}' AND datum > '{1}'
											AND id_vozaca = vozaci.id 
											Group by vozaci.id", doDatum.ToFileTime(),odDatum.ToFileTime());

			SqliteDataReader reader = c.ExecuteReader();


			while(reader.Read()) {
				long suma = (long)reader["suma"];
				string ime = (string)reader["ime"];
				string prezime = (string)reader["prezime"];

				Lista.Add(ime + " " + prezime, suma);
			}
			return Lista;
		}
	}
}
