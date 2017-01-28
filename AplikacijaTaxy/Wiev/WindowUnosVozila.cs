using System;

namespace AplikacijaTaxy {
	public partial class WindowUnosVozila : Gtk.Window {
		private VoziloNodeStore prikazVozila;
		private VoziloNode voziloNode;

		public WindowUnosVozila(VoziloNodeStore prikazVozila, VoziloNode vozilo = null) : base(Gtk.WindowType.Toplevel) {
			this.Build();
			this.prikazVozila = prikazVozila;
			this.voziloNode = vozilo;
			if (voziloNode != null) { //napuni unos
				UnosMarke.Text = voziloNode.Marka;
				LabelModel.Text = voziloNode.Model;
				unosGodineAuta.Value = int.Parse( voziloNode.Godiste);
				LabelRegistracija.Text = voziloNode.Registracija;
				combobox1.Active = Vozilo.GetTipInt(voziloNode.vozilo.Tip);
			}
			MainWindow.ForAll<Gtk.Label>((widget) => widget.ModifyFont(Pango.FontDescription.FromString("Arial 12")), this);
			unosGodineAuta.Adjustment.Upper = DateTime.Now.Year;
		}

		protected void SpremiVozilo(object sender, EventArgs e) {
			try {
				if (voziloNode != null) {//Update
					prikazVozila.IzmjeniVozilo(voziloNode,
											   UnosMarke.Text,
											   LabelModel.Text,
											   unosGodineAuta.ValueAsInt,
											   LabelRegistracija.Text,
											   combobox1.Active);
				}
				else {//Novi
					prikazVozila.dodajNovoVozilo(UnosMarke.Text,
												 LabelModel.Text,
												 unosGodineAuta.ValueAsInt,
												 LabelRegistracija.Text,
					                             combobox1.Active);
					}
			}catch (ArgumentException ae){
				Dijalozi.showError(this, ae.Message);
				return;
			}
			this.Destroy();
		}
		protected void OdustaniOdUnosa(object sender, EventArgs e) {
			this.Destroy();
		}
	}
}
