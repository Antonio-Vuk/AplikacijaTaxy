
// This file has been generated by the GUI designer. Do not modify.
namespace AplikacijaTaxy
{
	public partial class WindowStatistika
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Button button9;

		private global::Gtk.ComboBox comboboxMjeseci;

		private global::Gtk.HBox hbox2;

		private global::Gtk.SpinButton GodinaSpinbutton;

		private global::Gtk.Button stupacButton;

		private global::Gtk.Button pitaButton;

		private global::Gtk.VBox PlotBox;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget AplikacijaTaxy.WindowStatistika
			this.Name = "AplikacijaTaxy.WindowStatistika";
			this.Title = global::Mono.Unix.Catalog.GetString("STATISTIKA");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.BorderWidth = ((uint)(10));
			// Container child AplikacijaTaxy.WindowStatistika.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button9 = new global::Gtk.Button();
			this.button9.WidthRequest = 100;
			this.button9.HeightRequest = 50;
			this.button9.CanFocus = true;
			this.button9.Name = "button9";
			this.button9.UseUnderline = true;
			this.button9.Label = global::Mono.Unix.Catalog.GetString("NAZAD");
			global::Gtk.Image w1 = new global::Gtk.Image();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-ok", global::Gtk.IconSize.Menu);
			this.button9.Image = w1;
			this.hbox1.Add(this.button9);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button9]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.comboboxMjeseci = global::Gtk.ComboBox.NewText();
			this.comboboxMjeseci.AppendText(global::Mono.Unix.Catalog.GetString("Siječanj"));
			this.comboboxMjeseci.AppendText(global::Mono.Unix.Catalog.GetString("Veljača"));
			this.comboboxMjeseci.AppendText(global::Mono.Unix.Catalog.GetString("Ožuljak"));
			this.comboboxMjeseci.AppendText(global::Mono.Unix.Catalog.GetString("Travanj"));
			this.comboboxMjeseci.AppendText(global::Mono.Unix.Catalog.GetString("Svibanj"));
			this.comboboxMjeseci.AppendText(global::Mono.Unix.Catalog.GetString("Lipanj"));
			this.comboboxMjeseci.AppendText(global::Mono.Unix.Catalog.GetString("Srpanj"));
			this.comboboxMjeseci.AppendText(global::Mono.Unix.Catalog.GetString("Kolovoz"));
			this.comboboxMjeseci.AppendText(global::Mono.Unix.Catalog.GetString("Rujan"));
			this.comboboxMjeseci.AppendText(global::Mono.Unix.Catalog.GetString("Listopad"));
			this.comboboxMjeseci.AppendText(global::Mono.Unix.Catalog.GetString("Studeni"));
			this.comboboxMjeseci.AppendText(global::Mono.Unix.Catalog.GetString("Prosinac"));
			this.comboboxMjeseci.WidthRequest = 100;
			this.comboboxMjeseci.Name = "comboboxMjeseci";
			this.comboboxMjeseci.Active = 0;
			this.hbox1.Add(this.comboboxMjeseci);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.comboboxMjeseci]));
			w3.Position = 1;
			w3.Expand = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.GodinaSpinbutton = new global::Gtk.SpinButton(0D, 1E+47D, 1D);
			this.GodinaSpinbutton.WidthRequest = 100;
			this.GodinaSpinbutton.HeightRequest = 50;
			this.GodinaSpinbutton.CanFocus = true;
			this.GodinaSpinbutton.Name = "GodinaSpinbutton";
			this.GodinaSpinbutton.Adjustment.PageIncrement = 10D;
			this.GodinaSpinbutton.ClimbRate = 1D;
			this.GodinaSpinbutton.Numeric = true;
			this.hbox2.Add(this.GodinaSpinbutton);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.GodinaSpinbutton]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.stupacButton = new global::Gtk.Button();
			this.stupacButton.WidthRequest = 100;
			this.stupacButton.CanFocus = true;
			this.stupacButton.Name = "stupacButton";
			this.stupacButton.UseUnderline = true;
			this.stupacButton.Label = global::Mono.Unix.Catalog.GetString("Stupčasti");
			this.hbox2.Add(this.stupacButton);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.stupacButton]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.pitaButton = new global::Gtk.Button();
			this.pitaButton.WidthRequest = 100;
			this.pitaButton.CanFocus = true;
			this.pitaButton.Name = "pitaButton";
			this.pitaButton.UseUnderline = true;
			this.pitaButton.Label = global::Mono.Unix.Catalog.GetString("Pita");
			this.hbox2.Add(this.pitaButton);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.pitaButton]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			this.hbox1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.hbox2]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w8.Position = 0;
			w8.Expand = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.PlotBox = new global::Gtk.VBox();
			this.PlotBox.Name = "PlotBox";
			this.PlotBox.Spacing = 6;
			this.vbox1.Add(this.PlotBox);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.PlotBox]));
			w9.Position = 1;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 554;
			this.DefaultHeight = 465;
			this.Show();
			this.button9.Clicked += new global::System.EventHandler(this.WindowStatistikaIzlaz);
			this.stupacButton.Clicked += new global::System.EventHandler(this.OnButtonStupcastiDijagram);
			this.pitaButton.Clicked += new global::System.EventHandler(this.OnButtonPitaDijagram);
		}
	}
}
