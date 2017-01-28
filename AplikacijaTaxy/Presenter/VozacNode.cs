using System;

namespace AplikacijaTaxy {
	public class VozacNode : Gtk.TreeNode {
		
		public Vozac vozac { get; }

		[Gtk.TreeNodeValue(Column = 0)]
		public string Ime;

		[Gtk.TreeNodeValue(Column = 1)]
		public string Prezime;

		[Gtk.TreeNodeValue(Column = 2)]
		public string Oib;

		[Gtk.TreeNodeValue(Column = 3)]
		public string Iban;

		[Gtk.TreeNodeValue(Column = 4)]
		public string Kontakt;

		[Gtk.TreeNodeValue(Column = 5)]
		public string Prebivaliste;

		[Gtk.TreeNodeValue(Column = 6)]
		public string Placa;

		[Gtk.TreeNodeValue(Column = 7)]
		public string Vozilo;

		public VozacNode(Vozac radnik) {
			this.vozac = radnik;
			this.Ime = radnik.Ime;
			this.Prezime = radnik.Prezime;
			this.Oib = radnik.Oib;
			this.Iban = radnik.Iban;
			this.Kontakt = radnik.Broj_mobitela;
			this.Prebivaliste = radnik.Adresa;
			this.Placa = radnik.placa.ToString();
			this.Vozilo = radnik.Auto.Marka + "  " + radnik.Auto.Model;
		}
		public void UpdateVozac(string ime, string prezime, string oib, string iban, string broj_m, string adresa, long placa, Vozilo auto) {
			vozac.Ime = ime;
			vozac.Prezime = prezime;
			vozac.Oib = oib;
			vozac.Iban = iban;
			vozac.Broj_mobitela = broj_m;
			vozac.Adresa = adresa;
			vozac.placa = placa;
			vozac.Auto = auto;

			Ime = vozac.Ime;
			Prezime = vozac.Prezime;
			Oib = vozac.Oib;
			Iban = vozac.Iban;
			Kontakt = vozac.Broj_mobitela;
			Prebivaliste = vozac.Adresa;
			Placa = vozac.placa.ToString();
			Vozilo = vozac.Auto.Marka + "  " + vozac.Auto.Model;
		}
	}
}
