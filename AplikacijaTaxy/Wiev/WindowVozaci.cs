using System;
using Gtk;
using System.Collections.Generic;

namespace AplikacijaTaxy {
	public partial class WindowVozači : Gtk.Window {

		VozacNodeStore prikazVozaca = new VozacNodeStore();

		public WindowVozači() : base(Gtk.WindowType.Toplevel) {
			this.Build();
			MainWindow.ForAll<Gtk.Label>((widget) => widget.ModifyFont(Pango.FontDescription.FromString("Arial 12")), this);

			popisVozaca.AppendColumn("Ime", new CellRendererText(), "text", 0).MinWidth = 130;
			popisVozaca.AppendColumn("Prezime", new CellRendererText(), "text", 1).MinWidth = 130;
			popisVozaca.AppendColumn("OIB", new CellRendererText(), "text", 2).MinWidth = 130;
			popisVozaca.AppendColumn("IBAN", new CellRendererText(), "text", 3).MinWidth = 130;
			popisVozaca.AppendColumn("Kontakt", new CellRendererText(), "text", 4).MinWidth = 130;
			popisVozaca.AppendColumn("Adresa", new CellRendererText(), "text", 5).MinWidth = 130;
			popisVozaca.AppendColumn("Plaća(KN)", new CellRendererText(), "text", 6).MinWidth = 130;
			popisVozaca.AppendColumn("Vozilo", new CellRendererText(), "text", 7).MinWidth = 130;
			var lista_vozaca = new List<Vozac>();
			lista_vozaca = DBVozaci.DohvatiSveVozace();
			prikazVozaca.Dodaj(lista_vozaca);
			popisVozaca.NodeStore = prikazVozaca;
		}

		protected void WindowVozaciIzlaz(object sender, EventArgs e) {
			this.Destroy();
		}

		protected void On_Button_Unos_Vozaca(object sender, EventArgs e) {
			WindowUnosVozaca prozor_unos_vozaca = new WindowUnosVozaca(prikazVozaca);
		}

		protected void OnButtonIzmijeniVozaca(object sender, EventArgs e) {
			VozacNode radnik = popisVozaca.NodeSelection.SelectedNode as VozacNode;

			if (radnik != null) {
				WindowUnosVozaca unosVozaca = new WindowUnosVozaca(prikazVozaca, radnik);
				unosVozaca.Destroyed += (sender1, e1) => popisVozaca.GrabFocus();
			}
		}

		protected void OnClickerObrisiVozaca(object sender, EventArgs e) {
			VozacNode radnik = (popisVozaca.NodeSelection.SelectedNode as VozacNode);

			if (radnik != null && Dijalozi.ShowYesNo(this, "Jeste li sigurni da želite obrisati vozača?"))
				prikazVozaca.ObrisiVozaca(radnik);
		}

		protected void OnButtonSearchClicked(object sender, EventArgs e) {
			prikazVozaca.Search(entrySearch.Text);
		}
	}
}
