using System;
namespace AplikacijaTaxy {
	public class Vozilo {
		
		public enum Vrsta {
			Auto,
			Kombi
		}

		public long? id { get; set;}
		private string marka;
		private string model;
		public long? godiste { get; set;}
		private string registracija;
		private Vrsta tip;

		public Vozilo(string marka, string model, int godiste, string reg, Vrsta tip) {
			this.Marka = marka;
			this.Model = model;
			this.godiste = godiste;
			this.Registracija = reg;
			this.Tip = tip;
		}

		public Vozilo() { }

		public string Marka {
			get {return marka;}
			set {
				if (value.Equals(""))
					throw new ArgumentException("Marka nije unesena!");
				marka = value;
			}
		}
		public string Model {
			get {return model;}
			set {
				if(value.Equals(""))
					throw new ArgumentException("Model nije unesen!");
				model = value;
			}
		}
		public string Registracija {
			get {return registracija;}
			set {
				if (value.Equals(""))
					throw new ArgumentException("Registracija nije unesena!");
				
				if(!DBVozila.provjeriRegistraciju(id, value))
					throw new ArgumentException("Registracija je već unesena!");

				if (value.Contains(" ")) {
					throw new ArgumentException("Registracija je nepravilno unesena!");
				}
				registracija = value;
			}
		}
		public Vrsta Tip {
			get {return tip;}
			set {
				tip = value;
			}
		}
		public static int GetTipInt(Vrsta tip) {
			int t;
			switch (tip) {
				case Vrsta.Auto: t = 0; break;
				case Vrsta.Kombi: t = 1; break;
				default: t = 0; break;
			}
			return t;
		}
		public static Vrsta GetTipVrsta(int tip) {
			Vrsta t;
			switch (tip) {
				case 0: t = Vrsta.Auto; break;
				case 1: t = Vrsta.Kombi; break;
				default: t = Vrsta.Auto; break;
			}
			return t;
		}
		public static Vrsta GetTipVrsta(long tip) {
			Vrsta t;
			switch (tip) {
				case 0: t = Vrsta.Auto; break;
				case 1: t = Vrsta.Kombi; break;
				default: t = Vrsta.Auto; break;
			}
			return t;
		}
	}
}
