using System;

namespace AplikacijaTaxy {
	
	public class VoziloNode : Gtk.TreeNode{

		public Vozilo vozilo { get;}

		[Gtk.TreeNodeValue(Column = 0)]
		public string Marka;

		[Gtk.TreeNodeValue(Column = 1)]
		public string Model;

		[Gtk.TreeNodeValue(Column = 2)]
		public string Godiste;

		[Gtk.TreeNodeValue(Column = 3)]
		public string Registracija;

		[Gtk.TreeNodeValue(Column = 4)]
		public string Tip;


		public VoziloNode(Vozilo a) {
			this.vozilo = a;
			this.Marka = a.Marka;
			this.Model = a.Model;
			this.Godiste = a.godiste.ToString();
			this.Registracija = a.Registracija;
			this.Tip = a.Tip.ToString();
		}

		public void UpdateVozilo(string mar, string mod, int god, string reg, int tip) {
			vozilo.Marka = mar;
			vozilo.Model = mod;
			vozilo.godiste = god;
			vozilo.Registracija = reg;
			vozilo.Tip = Vozilo.GetTipVrsta(tip);

			Marka = vozilo.Marka;
			Model = vozilo.Model;
			Godiste = vozilo.godiste.ToString();
			Registracija = vozilo.Registracija;
			Tip = vozilo.Tip.ToString();
		}
	}
}
