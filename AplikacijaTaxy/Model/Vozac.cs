using System;
namespace AplikacijaTaxy {
	public class Vozac {

		public long? id { get; set;}
		private string ime;
		private string prezime;
		private string oib;
		private string iban;
		private string broj_mobitela;
		private string adresa;
		public long? placa { get; set; }
		private Vozilo auto;

		public Vozac(string i, string p, string o, string ib, string br_mob, string a, long zarada, Vozilo automobil) {
			this.Ime = i;
			this.Prezime = p;
			this.Oib = o;
			this.Iban = ib;
			this.Broj_mobitela = br_mob;
			this.Adresa = a;
			this.placa = zarada;
			this.auto = automobil;
		}

		public Vozac() { }

		public string Ime {
			get {return ime;}
			set {
				if (value.Equals(""))
					throw new ArgumentException("Niste unijeli ime!");
				ime = value;
			}
		}
		public string Prezime {
			get {return prezime;}
			set {
				if (value.Equals(""))
					throw new ArgumentException("Niste unijeli prezime!");
				prezime = value;
			}
		}
		public string Iban {
			get {return iban;}
			set {
				if (value.Equals(""))
					throw new ArgumentException("Niste unijeli IBAN!");

				if (!DBVozaci.provjeriIban(id, value))
					throw new ArgumentException("Iban je vec unesen!");
				iban = value;
			}
		}
		public string Broj_mobitela {
			get {return broj_mobitela;}
			set {
				if (value.Equals("") || (value.Length < 8))
					throw new ArgumentException("Broj mobitela je nepravilan!");

				if(!DBVozaci.provjeriBroj_mobitela(id, value))
					throw new ArgumentException("Broj mobitela je vec unesen!");
				broj_mobitela = value;
			}
		}
		public string Adresa {
			get {return adresa;}
			set {
				if (value.Equals(""))
					throw new ArgumentException("Niste unijeli adresu!");
				adresa = value;
			}
		}
		public Vozilo Auto {
			get {return auto;}
			set {
				auto = value;
			}
		}
		public string Oib {
			get {return oib;}
			set {
				if ((value.Length < 10 || value.Length > 11) || value.Contains(" "))
					throw new ArgumentException("Oib je nepravilan!");
				
				if (!DBVozaci.provjeriOib(id, value))
					throw new ArgumentException("Oib je vec unesen!");
				oib = value;
			}
		}
	}
}
