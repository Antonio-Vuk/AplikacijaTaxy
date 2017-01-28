using System;
using System.Collections.Generic;
namespace AplikacijaTaxy {
	public partial class WindowUnosVoznje : Gtk.Window {

		private VoznjaNodeStore prikazVoznji;
		private VoznjaNode voznjaNode;
		private List<Vozac> Lista_vozaca = new List<Vozac>();

		public WindowUnosVoznje(VoznjaNodeStore prikazVoznji, VoznjaNode voznja = null) : base(Gtk.WindowType.Toplevel) {
			this.Build();
			this.prikazVoznji = prikazVoznji;
			this.voznjaNode = voznja;
			MainWindow.ForAll<Gtk.Label>((widget) => widget.ModifyFont(Pango.FontDescription.FromString("Arial 12")), this);
			calendar.Date = DateTime.Now;
			Lista_vozaca = DBVozaci.DohvatiSveVozace();
			foreach (var vozac in Lista_vozaca) {
				int i = 0;
				combobox_Vozac.InsertText(i, vozac.Oib);
				i++;
			}
			combobox_Vozac.Active = 0;
			calendar.Date = DateTime.Now;
			if (voznja != null) {
				entry_NazivOsobe.Text = voznja.Naručitelj;
				entry_Kontakt.Text = voznja.Kontakt;
				entry_PocetnaLokacija.Text = voznja.OD;
				entry_ZavrsnaLokacija.Text = voznja.DO;
				spinbutton_Cijena.Text = voznja.Cijena;
				entry_Vrijeme.Text = voznja.Vrijeme;
			}
		}
		protected void OnButtonSpremiVoznju(object sender, EventArgs e) {
			if (calendar.Date.AddDays(1) < DateTime.Now) { 
				Dijalozi.showError(this, "Datum je vec protekao");
				return;
			}
			try {
				if (voznjaNode != null) {
					prikazVoznji.izmijeniVoznju(voznjaNode,
												entry_NazivOsobe.Text,
												entry_Kontakt.Text,
												entry_PocetnaLokacija.Text,
												entry_ZavrsnaLokacija.Text,
												spinbutton_Cijena.ValueAsInt,
												DBVozaci.DohvatiPoOibuVozaca(combobox_Vozac.ActiveText),
												calendar.Date,
												entry_Vrijeme.Text);
				}
				else {
					prikazVoznji.dodajNovuVoznju(entry_NazivOsobe.Text,
												 entry_Kontakt.Text,
												 entry_PocetnaLokacija.Text,
												 entry_ZavrsnaLokacija.Text,
												 spinbutton_Cijena.ValueAsInt,
												 DBVozaci.DohvatiPoOibuVozaca(combobox_Vozac.ActiveText),
												 calendar.Date,
												 entry_Vrijeme.Text);
				}
			}
			catch (ArgumentException ae) {
				Dijalozi.showError(this, ae.Message);
				return;
			}
			this.Destroy();
		}
		protected void On_Button_OdustaniOdUnosaVoznje(object sender, EventArgs e) {
			this.Destroy();
		}
	}
}
