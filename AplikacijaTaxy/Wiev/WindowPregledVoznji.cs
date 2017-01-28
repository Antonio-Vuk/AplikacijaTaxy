using System;
using System.Collections.Generic;
using Gtk;
namespace AplikacijaTaxy {
	public partial class WindowPregledVoznji : Gtk.Window {

		VoznjaNodeStore prikazVoznji = new VoznjaNodeStore();

		public WindowPregledVoznji() : base(Gtk.WindowType.Toplevel) {
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
			lista_voznji = DBVoznje.DohvatiPotvrgeneVoznje();
			prikazVoznji.Dodaj(lista_voznji);
			popisVoznji.NodeStore = prikazVoznji;
		}

		protected void OnButtonNazad(object sender, EventArgs e) {
			this.Destroy();
		}

		protected void OnButtonSearchClicked(object sender, EventArgs e) {
			prikazVoznji.SearchPotvrgene(entrySearch.Text);
		}
	}
}
