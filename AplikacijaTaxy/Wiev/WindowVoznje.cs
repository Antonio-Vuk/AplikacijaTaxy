using System;
using Gtk;
using System.Collections.Generic;

namespace AplikacijaTaxy {
	public partial class WindowVoznje : Gtk.Window {

		VoznjaNodeStore prikazVoznji = new VoznjaNodeStore();

		public WindowVoznje() : base(Gtk.WindowType.Toplevel) {
			
			this.Build();
			MainWindow.ForAll<Gtk.Label>((widget) => widget.ModifyFont(Pango.FontDescription.FromString("Arial 12")), this);
			popisVoznji.AppendColumn("Naručitelj", new CellRendererText(), "text", 0).MinWidth = 130;
			popisVoznji.AppendColumn("Kontakt", new CellRendererText(), "text", 1).MinWidth = 130;
			popisVoznji.AppendColumn("Početna lokacija", new CellRendererText(), "text", 2).MinWidth = 130;
			popisVoznji.AppendColumn("Završna lokacija", new CellRendererText(), "text", 3).MinWidth = 130;
			popisVoznji.AppendColumn("Cijena(KN)", new CellRendererText(), "text", 4).MinWidth = 130;
			popisVoznji.AppendColumn("Vozač", new CellRendererText(), "text", 5).MinWidth = 130;
			popisVoznji.AppendColumn("Datum", new CellRendererText(), "text", 6).MinWidth = 130;
			popisVoznji.AppendColumn("Vrijeme", new CellRendererText(), "text", 7);
			var lista_voznji = new List<Voznja>();
			lista_voznji = DBVoznje.DohvatiNePotvrgeneVoznje();
			prikazVoznji.Dodaj(lista_voznji);
			popisVoznji.NodeStore = prikazVoznji;
		}

		protected void WindowVoznjeIzlaz(object sender, EventArgs e) {
			this.Destroy();
		}

		protected void On_Button_Unos_Voznje(object sender, EventArgs e) {
			WindowUnosVoznje ProzorUnosVozila = new WindowUnosVoznje(prikazVoznji);
		}

		protected void OnButtonSveVoznje(object sender, EventArgs e) {
			WindowPregledVoznji ProzorZaPregledavanjeVoznji = new WindowPregledVoznji();
		}

		protected void OnButtonIzmijeniVoznju(object sender, EventArgs e) {
			VoznjaNode voznja = (popisVoznji.NodeSelection.SelectedNode as VoznjaNode);

			if (voznja != null) {
				WindowUnosVoznje unosVoznje = new WindowUnosVoznje(prikazVoznji, voznja);
				unosVoznje.Destroyed += (sender1, e1) => popisVoznji.GrabFocus();
			}
		}

		protected void OnButtonObrisiVoznju(object sender, EventArgs e) {
			VoznjaNode voznja = (popisVoznji.NodeSelection.SelectedNode as VoznjaNode);

			if (voznja != null && Dijalozi.ShowYesNo(this, "Jeste li sigurni da želite obrisati voznju?"))
				prikazVoznji.ObrisiVoznju(voznja);
		}

		protected void OnButtonSearchClicked(object sender, EventArgs e) {
			prikazVoznji.Search(entrySearch.Text);
		}

		protected void OnButtonPotvrdiVoznju(object sender, EventArgs e) {
			VoznjaNode voznja = (popisVoznji.NodeSelection.SelectedNode as VoznjaNode);

			if (voznja != null && Dijalozi.ShowYesNo(this, "Jeste li sigurni da želite potvrditi voznju?"))
				prikazVoznji.PotvrdiVoznju(voznja);
			prikazVoznji.Clear();
			var lista_voznji = new List<Voznja>();
			lista_voznji = DBVoznje.DohvatiNePotvrgeneVoznje();
			prikazVoznji.Dodaj(lista_voznji);
		}
	}
}
