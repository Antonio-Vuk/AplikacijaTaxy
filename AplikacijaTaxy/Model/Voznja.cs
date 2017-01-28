using System;

namespace AplikacijaTaxy {
	public class Voznja {

		public long? id { get; set; }
		private string naziv_osobe;
		private string kontakt;
		private string pocetna_lokacija;
		private string zavrsna_lokacija;
		private long? cijena;
		private Vozac radnik;
		private DateTime datum;
		private string vrijeme;
		private bool obavljeno;

		public Voznja(string n, string k, string p, string z, long c, Vozac zaposlenik, DateTime d, string v) {
			this.Naziv_osobe = n;
			this.Kontakt = k;
			this.Pocetna_lokacija = p;
			this.Zavrsna_lokacija = z;
			this.Cijena = c;
			this.Radnik = zaposlenik;
			this.Datum = d;
			this.Vrijeme = v;
			this.Obavljeno = false;
		}

		public Voznja() { }

		public string Naziv_osobe {
			get { return naziv_osobe; }
			set {
				if (value.Equals(""))
					throw new ArgumentException("Niste unijeli naziv osobe!");
				naziv_osobe = value;
			}
		}
		public string Kontakt {
			get { return kontakt; }
			set {
				if (value.Equals(""))
					throw new ArgumentException("Niste unijeli broj mobitela!");
				kontakt = value;
			}
		}
		public string Pocetna_lokacija {
			get { return pocetna_lokacija; }
			set {
				if (value.Equals(""))
					throw new ArgumentException("Niste unijeli pocetnu lokaciju!");
				pocetna_lokacija = value;
			}
		}
		public string Zavrsna_lokacija {
			get { return zavrsna_lokacija; }
			set {
				if (value.Equals(""))
					throw new ArgumentException("Niste unijeli zavrsnu lokaciju!");
				zavrsna_lokacija = value;
			}
		}
		public long? Cijena {
			get { return cijena; }
			set { 
				cijena = value; 
			}
		}
		public Vozac Radnik {
			get { return radnik; }
			set { radnik = value; }
		}
		public DateTime Datum {
			get { return datum; }
			set {
				datum = value;
			}
		}
		public string Vrijeme {
			get { return vrijeme; }
			set {if (value.Equals("") || (value.Length != 5) || !(value.Contains(":")))
					throw new ArgumentException("Vrijeme nije ispravno!");
				vrijeme = value;
			}
		}
		public bool Obavljeno {
			get { return obavljeno; }
			set {
				obavljeno = value;
			}
		}
	}
}
