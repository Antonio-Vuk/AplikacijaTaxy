using System;
using System.Collections.Generic;
namespace AplikacijaTaxy {
	public partial class WindowUnosVozaca : Gtk.Window {

		private VozacNodeStore prikazVozaca;
		private VozacNode VozacNode;
		private List<Vozilo> Lista_vozila = new List<Vozilo>();

		public WindowUnosVozaca(VozacNodeStore prikazVozaca, VozacNode radnik = null) : base(Gtk.WindowType.Toplevel) {
			this.Build();
			this.prikazVozaca = prikazVozaca;
			this.VozacNode = radnik;
			MainWindow.ForAll<Gtk.Label>((widget) => widget.ModifyFont(Pango.FontDescription.FromString("Arial 12")), this);

			Lista_vozila = DBVozila.DohvatiSvaVozila();
			foreach (var k in Lista_vozila) {
				int i = 0;
				if (DBVozaci.provjeriVozilo((long)k.id)) {
					combobox_VOZILO.InsertText(i, k.Registracija);
				}
				i++;
			}

			if (VozacNode != null) {
				entry_IME.Text = VozacNode.Ime;
				entry_PREZIME.Text = VozacNode.Prezime;
				entryOIB.Text = VozacNode.Oib;
				entry_KONTAKT.Text = VozacNode.Kontakt;
				entry_IBAN.Text = VozacNode.Iban;
				entry_ADRESA.Text = VozacNode.Prebivaliste;
				spinbutton_PLACA.Text = VozacNode.Placa;
			}
			combobox_VOZILO.Active = 0;
		}

		protected void spremiVozaca(object sender, EventArgs e) {
			if (combobox_VOZILO.Active == -1) {
				Dijalozi.showError(this, "Nemate dostupnih vozila");
				return;
			}
			Console.WriteLine(combobox_VOZILO.Active);
			try {
				if (VozacNode != null) {
					prikazVozaca.izmijeniVozaca(VozacNode,
												entry_IME.Text,
											  	entry_PREZIME.Text,
											  	entryOIB.Text,
											  	entry_IBAN.Text,
											  	entry_KONTAKT.Text,
											  	entry_ADRESA.Text,
										  		spinbutton_PLACA.ValueAsInt,
										  		DBVozila.DohvatiPoRegistraciji(combobox_VOZILO.ActiveText));
				}
				else {
					prikazVozaca.dodajNovogVozaca(entry_IME.Text,
											  		entry_PREZIME.Text,
											  		entryOIB.Text,
											  		entry_IBAN.Text,
											  		entry_KONTAKT.Text,
											  		entry_ADRESA.Text,
											  		spinbutton_PLACA.ValueAsInt,
										  			DBVozila.DohvatiPoRegistraciji(combobox_VOZILO.ActiveText));
				}
			}
			catch (ArgumentException ae) {
				Dijalozi.showError(this, ae.Message);
				return;
			}
			this.Destroy();
		}

		protected void On_button_odustani(object sender, EventArgs e) {
			this.Destroy();
		}
	}
}
