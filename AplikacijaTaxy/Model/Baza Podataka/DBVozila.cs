using Mono.Data.Sqlite;
using System.Collections.Generic;
using System;

namespace AplikacijaTaxy {
	public static class DBVozila{
		static DBVozila() {
			SqliteCommand com = BazaPodataka.con.CreateCommand();

			com.CommandText = @"CREATE TABLE IF NOT EXISTS Vozila (
				id integer primary key autoincrement,
				marka nvarchar(32) NOT NULL,
				model nvarchar(32) NOT NULL,
				godiste long NOT NULL,
                registracija nvarchar(32) NOT NULL,
				tip integer NOT NULL,
				CONSTRAINT registracija_unigue UNIQUE(registracija))";

			com.ExecuteNonQuery();
			com.Dispose();
		}

		public static bool provjeriRegistraciju(long? id, string registracija) {

			SqliteCommand countCommand = BazaPodataka.con.CreateCommand();
			string idString = "-1";
			if (id != null) idString = id.ToString();

			countCommand.CommandText = string.Format(@"SELECT COUNT(*) 
											FROM Vozila 
											WHERE registracija = '{0}' AND id != {1}", registracija, idString);
			long count = (long)countCommand.ExecuteScalar();
			countCommand.Dispose();

			if (count == 0) {
				return true;
			}
			return false;
		}

		public static Vozilo DohvatiPoRegistraciji(string registracija) {

			SqliteCommand c = BazaPodataka.con.CreateCommand();

			c.CommandText = string.Format(@"SELECT id, marka, model, godiste, registracija, tip 
											FROM Vozila 
											WHERE registracija = '{0}'", registracija);

			SqliteDataReader reader = c.ExecuteReader();

			Vozilo auto = new Vozilo();

			while (reader.Read()) {
				auto.id = (long)reader["id"];
				auto.Marka = (string)reader["marka"];
				auto.Model = (string)reader["model"];
				auto.godiste = (long)reader["godiste"];
				auto.Registracija = (string)reader["registracija"];
				auto.Tip = Vozilo.GetTipVrsta((long)reader["tip"]);
			}
			c.Dispose();
			return auto;
		}
		public static Vozilo DohvatiPoIDVozila(int id) {

			SqliteCommand c = BazaPodataka.con.CreateCommand();
			c.CommandText = string.Format(@"SELECT id, marka, model, godiste, registracija, tip 
											FROM Vozila WHERE id = '{0}'", id);
			SqliteDataReader reader = c.ExecuteReader();

			Vozilo auto = new Vozilo();
			while (reader.Read()) {
				auto.id = (long)reader["id"];
				auto.Marka = (string)reader["marka"];
				auto.Model = (string)reader["model"];
				auto.godiste = (long)reader["godiste"];
				auto.Registracija = (string)reader["registracija"];
				auto.Tip = Vozilo.GetTipVrsta((long)reader["tip"]);
			}
			c.Dispose();
			return auto;
		}
		public static List<Vozilo> DohvatiSvaVozila(){
			var lista = new List<Vozilo>();

			SqliteCommand c = BazaPodataka.con.CreateCommand();
			c.CommandText = string.Format(@"SELECT id, marka, model, godiste, registracija, tip 
											FROM Vozila");
			SqliteDataReader reader = c.ExecuteReader();

			while (reader.Read()){
				Vozilo auto = new Vozilo();
				auto.id = (long)reader["id"];
				auto.Marka = (string)reader["marka"];
				auto.Model = (string)reader["model"];
				auto.godiste = (long)reader["godiste"];
				auto.Registracija = (string)reader["registracija"];
				auto.Tip = Vozilo.GetTipVrsta((long)reader["tip"]);
				lista.Add(auto);
			}
			c.Dispose();
			return lista;
		}
		public static void DodajVozilo(string marka, string model, long godiste, string registracija, int tip) {
			SqliteCommand c = BazaPodataka.con.CreateCommand();

			c.CommandText = string.Format(@"INSERT INTO Vozila (marka, model, godiste, registracija, tip)
			VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", marka, model, godiste, registracija, tip);
			c.ExecuteNonQuery();
			c.Dispose();
		}

		public static void IzmijeniVozilo(string marka, string model, long godiste, string registracija, int tip, int id) {
			SqliteCommand c = BazaPodataka.con.CreateCommand();

			c.CommandText = string.Format(@"UPDATE Vozila SET	marka = '{0}', 
																model = '{1}', 
																godiste = '{2}',
																registracija = '{3}',
																tip = '{4}' 
											WHERE id = '{5}'", marka, model, godiste, registracija, tip, id);
			c.ExecuteNonQuery();
			c.Dispose();
		}
		public static List<Vozilo> DohvatiPoMarki(string kljucnaRijec) {
			var lista = new List<Vozilo>();

			SqliteCommand c = BazaPodataka.con.CreateCommand();

			c.CommandText = string.Format(@"SELECT id, marka, model, godiste, registracija, tip 
											FROM Vozila
			                              	WHERE marka LIKE '%{0}%'", kljucnaRijec);

			SqliteDataReader reader = c.ExecuteReader();

			while (reader.Read()) {
				Vozilo auto = new Vozilo();
				auto.id = (long)reader["id"];
				auto.Marka = (string)reader["marka"];
				auto.Model = (string)reader["model"];
				auto.godiste = (long)reader["godiste"];
				auto.Registracija = (string)reader["registracija"];
				auto.Tip = Vozilo.GetTipVrsta((long)reader["tip"]);
				lista.Add(auto);
			}
			c.Dispose();
			return lista;
		}
		public static void obrisiVozilo(Vozilo auto) {
			SqliteCommand c = BazaPodataka.con.CreateCommand();

			c.CommandText = string.Format("	DELETE from Vozila " +
			                              "WHERE id = '{0}' ", auto.id);
			c.ExecuteNonQuery();
			c.Dispose();
		}
	}
}
