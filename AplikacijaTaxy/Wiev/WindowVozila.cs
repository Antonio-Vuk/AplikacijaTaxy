using System;
using Gtk;
using System.Collections.Generic;

namespace AplikacijaTaxy {
	public partial class WindowVozila : Gtk.Window {
		
		VoziloNodeStore prikazVozila = new VoziloNodeStore();

		public WindowVozila() : base(Gtk.WindowType.Toplevel) {
			
			this.Build();
			MainWindow.ForAll<Gtk.Label>((widget) => widget.ModifyFont(Pango.FontDescription.FromString("Arial 12")), this);
			popisVozila.AppendColumn("Marka", new CellRendererText(), "text", 0).MinWidth = 130;
			popisVozila.AppendColumn("Model", new CellRendererText(), "text", 1).MinWidth = 130;
			popisVozila.AppendColumn("Godište", new CellRendererText(), "text", 2).MinWidth = 130;
			popisVozila.AppendColumn("Reg", new CellRendererText(), "text", 3).MinWidth = 130;
			popisVozila.AppendColumn("Vrsta", new CellRendererText(), "text", 4).MinWidth = 130;
			var lista_vozila = new List<Vozilo>();
			lista_vozila = DBVozila.DohvatiSvaVozila();
			prikazVozila.Dodaj(lista_vozila);
			popisVozila.NodeStore = prikazVozila;
		}

		protected void UnosVozila(object sender, EventArgs e) {
			WindowUnosVozila unosvozila = new WindowUnosVozila(prikazVozila);
		}

		protected void WindowVozilaIzlaz(object sender, EventArgs e) {
			this.Destroy();
		}

		protected void IzmjenaVozila(object sender, EventArgs e) {
			VoziloNode vozilo = popisVozila.NodeSelection.SelectedNode as VoziloNode;

			if (vozilo != null) {
				WindowUnosVozila unosvozila = new WindowUnosVozila(prikazVozila, vozilo);
				unosvozila.Destroyed += (sender1, e1) => popisVozila.GrabFocus();
			}
		}

		protected void obrisiVozilo(object sender, EventArgs e) {
			VoziloNode auto = (popisVozila.NodeSelection.SelectedNode as VoziloNode);

			if (auto != null && Dijalozi.ShowYesNo(this, "Jeste li sigurni da želite obrisati vozilo?"))
				prikazVozila.ObrisiVozilo(auto);
		}

		protected void OnButtonSearchClicked(object sender, EventArgs e) {
			prikazVozila.Search(entrySearch.Text);
		}
	}
}
