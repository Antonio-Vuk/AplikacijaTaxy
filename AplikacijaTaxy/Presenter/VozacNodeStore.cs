using System;
using System.Collections.Generic;

namespace AplikacijaTaxy {
	
	public class VozacNodeStore : Gtk.NodeStore{
		public VozacNodeStore() : base(typeof(VozacNode)) { }

		public void add(Vozac radnik) {
			this.AddNode(new VozacNode(radnik));
		}
		public void Dodaj(List<Vozac> Lista_Vozaca) {
			foreach (var radnik in Lista_Vozaca) {
				this.add(radnik);
			}
		}
		public void dodajNovogVozaca(string ime, string prezime, string oib, string iban, string broj_m, 
		                             string adresa, long placa, Vozilo auto) {
			Vozac radnik = new Vozac(ime, prezime, oib, iban, broj_m, adresa, placa, auto);
			this.add(radnik);
			DBVozaci.DodajVozaca(ref radnik);
		}
		public void izmijeniVozaca(VozacNode radnik, string ime, string prezime, string oib, string iban, string broj_m, 
		                           string adresa, long placa, Vozilo auto) {
			radnik.UpdateVozac(ime, prezime, oib, iban, broj_m, adresa, placa, auto);
			DBVozaci.IzmijeniVozaca(radnik.vozac);
		}
		public void ObrisiVozaca(VozacNode radnik) {
			this.RemoveNode(radnik);
			DBVozaci.obrisiVozaca(radnik.vozac);
		}
		public void Search(string kljucnaRijec) {
			this.Clear();
			DBVozaci.DohvatiPoImenuVozace(kljucnaRijec).ForEach(radnik => this.AddNode(new VozacNode(radnik)));
		}
	}
}
