using System;
using System.Collections.Generic;

namespace AplikacijaTaxy {
	public class VoznjaNodeStore : Gtk.NodeStore {
		public VoznjaNodeStore() : base(typeof(VoznjaNode)) { }

		public void add(Voznja voznja) {
			this.AddNode(new VoznjaNode(voznja));
		}

		public void Dodaj(List<Voznja> Lista_Voznji) {
			foreach (var a in Lista_Voznji) {
				this.add(a);
			}
		}
		public void dodajNovuVoznju(string nar, string kon, string poc_lok, string zav_lok, long cijena, Vozac zaposlenik, 
		                            DateTime date, string vrijeme) {
			Voznja novaVoznja = new Voznja(nar, kon, poc_lok, zav_lok, cijena, zaposlenik, date, vrijeme);
			this.add(novaVoznja);
			DBVoznje.DodajVoznju(nar, kon, poc_lok, zav_lok, cijena, (int)zaposlenik.id, date, vrijeme);
		}
		public void izmijeniVoznju(VoznjaNode voznja, string nar, string kon, string poc_lok, string zav_lok, long cijena, 
		                           Vozac zaposlenik, DateTime date, string vrijeme) {
			voznja.UpdateVoznja(nar, kon, poc_lok, zav_lok, cijena, zaposlenik, date, vrijeme);
			DBVoznje.IzmijeniVoznju(nar, kon, poc_lok, zav_lok, cijena, (int)zaposlenik.id, date, vrijeme, voznja.ID);
		}
		public void ObrisiVoznju(VoznjaNode n) {
			this.RemoveNode(n);
			DBVoznje.obrisiVoznju(n.voznja);
		}
		public void Search(string kljucnaRijec) {
			this.Clear();
			DBVoznje.DohvatiPoNarucitelju(kljucnaRijec).ForEach(voznja => this.AddNode(new VoznjaNode(voznja)));
		}
		public void PotvrdiVoznju(VoznjaNode n) {
			DBVoznje.potvrdiVoznju((long)n.voznja.id);
		}
		public void SearchPotvrgene(string kljucnaRijec) {
			this.Clear();
			DBVoznje.DohvatiPoNaruciteljuPotvrgene(kljucnaRijec).ForEach(voznja => this.AddNode(new VoznjaNode(voznja)));
		}
	}
}
