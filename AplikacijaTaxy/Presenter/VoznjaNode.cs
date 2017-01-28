using System;
namespace AplikacijaTaxy {
	public class VoznjaNode : Gtk.TreeNode{

		public Voznja voznja { get; }

		[Gtk.TreeNodeValue(Column = 0)]
		public string Naručitelj;

		[Gtk.TreeNodeValue(Column = 1)]
		public string Kontakt;

		[Gtk.TreeNodeValue(Column = 2)]
		public string OD;

		[Gtk.TreeNodeValue(Column = 3)]
		public string DO;

		[Gtk.TreeNodeValue(Column = 4)]
		public string Cijena;

		[Gtk.TreeNodeValue(Column = 5)]
		public string Vozač;

		[Gtk.TreeNodeValue(Column = 6)]
		public string Datum;

		[Gtk.TreeNodeValue(Column = 7)]
		public string Vrijeme;

		public VoznjaNode(Voznja a) {
			this.voznja = a;
			this.Naručitelj = a.Naziv_osobe;
			this.Kontakt = a.Kontakt;
			this.OD = a.Pocetna_lokacija;
			this.DO = a.Zavrsna_lokacija;
			this.Cijena = a.Cijena.ToString();
			this.Vozač = a.Radnik.Ime + " " + a.Radnik.Prezime;
			this.Datum = a.Datum.ToString().Substring(0, a.Datum.ToString().Length - 8);
			this.Vrijeme = a.Vrijeme;
		}

		public void UpdateVoznja(string nar, string kon, string poc_lok, string zav_lok, long cijena, Vozac zaposlenik, 
		                         DateTime date, string vrijeme) {
			voznja.Naziv_osobe = nar;
			voznja.Kontakt = kon;
			voznja.Pocetna_lokacija = poc_lok;
			voznja.Zavrsna_lokacija = zav_lok;
			voznja.Cijena = cijena;
			voznja.Radnik = zaposlenik;
			voznja.Datum = date;
			voznja.Vrijeme = vrijeme;

			Naručitelj = voznja.Naziv_osobe;
			Kontakt = voznja.Kontakt;
			OD = voznja.Pocetna_lokacija;
			DO = voznja.Zavrsna_lokacija;
			Cijena = voznja.Cijena.ToString();
			Vozač = voznja.Radnik.Ime + " " + voznja.Radnik.Prezime;
			Datum = voznja.Datum.ToString().Substring(0, voznja.Datum.ToString().Length - 8);
			Vrijeme = voznja.Vrijeme;
		}
	}
}
