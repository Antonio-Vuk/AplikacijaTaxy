using System;
using System.Collections.Generic;

namespace AplikacijaTaxy {
	
	public class VoziloNodeStore : Gtk.NodeStore {
		public VoziloNodeStore() : base(typeof(VoziloNode)) { }

		public void add(Vozilo a) {
			this.AddNode(new VoziloNode(a));		
		}

		public void Dodaj(List<Vozilo> Lista_Vozila) {
			foreach (var a in Lista_Vozila) {
				this.add(a);
			}
		}

		public void dodajNovoVozilo(string marka, string model, int godiste, string registracija, int tip){
			Vozilo novoVozilo = new Vozilo(marka, model, godiste, registracija, Vozilo.GetTipVrsta(tip));
			this.add(novoVozilo);
			DBVozila.DodajVozilo(marka, model, godiste, registracija, tip);
		}

		public void IzmjeniVozilo(VoziloNode vozilo, string marka, string model, int godiste, string registracija, int tip){
			vozilo.UpdateVozilo(marka, model, godiste, registracija, tip);
			DBVozila.IzmijeniVozilo(marka, model, godiste, registracija, tip, vozilo.ID);
		}

		public void ObrisiVozilo(VoziloNode n) {
			this.RemoveNode(n);
			DBVozila.obrisiVozilo(n.vozilo);
		}

		public void Search(string kljucnaRijec) {
			this.Clear();
			DBVozila.DohvatiPoMarki(kljucnaRijec).ForEach(auto => this.AddNode(new VoziloNode(auto)));
		}
	}
}