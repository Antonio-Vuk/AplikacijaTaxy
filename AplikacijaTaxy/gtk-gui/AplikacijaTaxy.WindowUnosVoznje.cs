
// This file has been generated by the GUI designer. Do not modify.
namespace AplikacijaTaxy
{
	public partial class WindowUnosVoznje
	{
		private global::Gtk.HBox hbox1;

		private global::Gtk.VBox vbox1;

		private global::Gtk.Label label1;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.Label label6;

		private global::Gtk.Label label7;

		private global::Gtk.Label label8;

		private global::Gtk.VBox vbox2;

		private global::Gtk.Entry entry_NazivOsobe;

		private global::Gtk.Entry entry_Kontakt;

		private global::Gtk.Entry entry_PocetnaLokacija;

		private global::Gtk.Entry entry_ZavrsnaLokacija;

		private global::Gtk.SpinButton spinbutton_Cijena;

		private global::Gtk.ComboBox combobox_Vozac;

		private global::Gtk.Entry entry_Vrijeme;

		private global::Gtk.Calendar calendar;

		private global::Gtk.VBox vbox3;

		private global::Gtk.Fixed fixed1;

		private global::Gtk.Button button2;

		private global::Gtk.Button button3;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget AplikacijaTaxy.WindowUnosVoznje
			this.Name = "AplikacijaTaxy.WindowUnosVoznje";
			this.Title = global::Mono.Unix.Catalog.GetString("UNOS VOZNJE");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.BorderWidth = ((uint)(10));
			// Container child AplikacijaTaxy.WindowUnosVoznje.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.WidthRequest = 150;
			this.label1.HeightRequest = 50;
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("NAZIV OSOBE");
			this.vbox1.Add(this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.HeightRequest = 50;
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("KONTAKT(mob)");
			this.vbox1.Add(this.label2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label2]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.HeightRequest = 50;
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("POČETNA LOKACIJA");
			this.vbox1.Add(this.label3);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label3]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.HeightRequest = 50;
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("ZAVRŠNA LOKACIJA");
			this.vbox1.Add(this.label4);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label4]));
			w4.Position = 3;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.HeightRequest = 50;
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("CIJENA");
			this.vbox1.Add(this.label5);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label5]));
			w5.Position = 4;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label();
			this.label6.HeightRequest = 50;
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("VOZAC");
			this.vbox1.Add(this.label6);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label6]));
			w6.Position = 5;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label();
			this.label7.HeightRequest = 50;
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("VRIJEME");
			this.vbox1.Add(this.label7);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label7]));
			w7.Position = 6;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label();
			this.label8.HeightRequest = 180;
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("DATUM");
			this.vbox1.Add(this.label8);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label8]));
			w8.Position = 7;
			w8.Expand = false;
			w8.Fill = false;
			this.hbox1.Add(this.vbox1);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox1]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.entry_NazivOsobe = new global::Gtk.Entry();
			this.entry_NazivOsobe.WidthRequest = 200;
			this.entry_NazivOsobe.HeightRequest = 50;
			this.entry_NazivOsobe.CanFocus = true;
			this.entry_NazivOsobe.Name = "entry_NazivOsobe";
			this.entry_NazivOsobe.IsEditable = true;
			this.entry_NazivOsobe.InvisibleChar = '●';
			this.vbox2.Add(this.entry_NazivOsobe);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.entry_NazivOsobe]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.entry_Kontakt = new global::Gtk.Entry();
			this.entry_Kontakt.HeightRequest = 50;
			this.entry_Kontakt.CanFocus = true;
			this.entry_Kontakt.Name = "entry_Kontakt";
			this.entry_Kontakt.IsEditable = true;
			this.entry_Kontakt.InvisibleChar = '●';
			this.vbox2.Add(this.entry_Kontakt);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.entry_Kontakt]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.entry_PocetnaLokacija = new global::Gtk.Entry();
			this.entry_PocetnaLokacija.HeightRequest = 50;
			this.entry_PocetnaLokacija.CanFocus = true;
			this.entry_PocetnaLokacija.Name = "entry_PocetnaLokacija";
			this.entry_PocetnaLokacija.IsEditable = true;
			this.entry_PocetnaLokacija.InvisibleChar = '●';
			this.vbox2.Add(this.entry_PocetnaLokacija);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.entry_PocetnaLokacija]));
			w12.Position = 2;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.entry_ZavrsnaLokacija = new global::Gtk.Entry();
			this.entry_ZavrsnaLokacija.HeightRequest = 50;
			this.entry_ZavrsnaLokacija.CanFocus = true;
			this.entry_ZavrsnaLokacija.Name = "entry_ZavrsnaLokacija";
			this.entry_ZavrsnaLokacija.IsEditable = true;
			this.entry_ZavrsnaLokacija.InvisibleChar = '●';
			this.vbox2.Add(this.entry_ZavrsnaLokacija);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.entry_ZavrsnaLokacija]));
			w13.Position = 3;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.spinbutton_Cijena = new global::Gtk.SpinButton(100D, 50000D, 10D);
			this.spinbutton_Cijena.HeightRequest = 50;
			this.spinbutton_Cijena.CanFocus = true;
			this.spinbutton_Cijena.Name = "spinbutton_Cijena";
			this.spinbutton_Cijena.Adjustment.PageIncrement = 50D;
			this.spinbutton_Cijena.ClimbRate = 1D;
			this.spinbutton_Cijena.Numeric = true;
			this.spinbutton_Cijena.SnapToTicks = true;
			this.spinbutton_Cijena.Value = 500D;
			this.vbox2.Add(this.spinbutton_Cijena);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.spinbutton_Cijena]));
			w14.Position = 4;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.combobox_Vozac = global::Gtk.ComboBox.NewText();
			this.combobox_Vozac.HeightRequest = 50;
			this.combobox_Vozac.Name = "combobox_Vozac";
			this.vbox2.Add(this.combobox_Vozac);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.combobox_Vozac]));
			w15.Position = 5;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.entry_Vrijeme = new global::Gtk.Entry();
			this.entry_Vrijeme.HeightRequest = 50;
			this.entry_Vrijeme.CanFocus = true;
			this.entry_Vrijeme.Name = "entry_Vrijeme";
			this.entry_Vrijeme.IsEditable = true;
			this.entry_Vrijeme.InvisibleChar = '●';
			this.vbox2.Add(this.entry_Vrijeme);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.entry_Vrijeme]));
			w16.Position = 6;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.calendar = new global::Gtk.Calendar();
			this.calendar.HeightRequest = 180;
			this.calendar.CanFocus = true;
			this.calendar.Name = "calendar";
			this.calendar.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
			this.vbox2.Add(this.calendar);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.calendar]));
			w17.Position = 7;
			w17.Expand = false;
			w17.Fill = false;
			this.hbox1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox2]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			this.vbox3.BorderWidth = ((uint)(10));
			// Container child vbox3.Gtk.Box+BoxChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.WidthRequest = 0;
			this.fixed1.HeightRequest = 135;
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			this.vbox3.Add(this.fixed1);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.fixed1]));
			w19.Position = 0;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.button2 = new global::Gtk.Button();
			this.button2.WidthRequest = 150;
			this.button2.HeightRequest = 100;
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			this.button2.Label = global::Mono.Unix.Catalog.GetString("SPREMI");
			global::Gtk.Image w20 = new global::Gtk.Image();
			w20.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-apply", global::Gtk.IconSize.Menu);
			this.button2.Image = w20;
			this.vbox3.Add(this.button2);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.button2]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			w21.Padding = ((uint)(15));
			// Container child vbox3.Gtk.Box+BoxChild
			this.button3 = new global::Gtk.Button();
			this.button3.HeightRequest = 100;
			this.button3.CanFocus = true;
			this.button3.Name = "button3";
			this.button3.UseUnderline = true;
			this.button3.Label = global::Mono.Unix.Catalog.GetString("ODUSTANI");
			global::Gtk.Image w22 = new global::Gtk.Image();
			w22.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-cancel", global::Gtk.IconSize.Menu);
			this.button3.Image = w22;
			this.vbox3.Add(this.button3);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.button3]));
			w23.Position = 2;
			w23.Expand = false;
			w23.Fill = false;
			this.hbox1.Add(this.vbox3);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox3]));
			w24.Position = 2;
			w24.Expand = false;
			w24.Fill = false;
			this.Add(this.hbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 561;
			this.DefaultHeight = 592;
			this.Show();
			this.button2.Clicked += new global::System.EventHandler(this.OnButtonSpremiVoznju);
			this.button3.Clicked += new global::System.EventHandler(this.On_Button_OdustaniOdUnosaVoznje);
		}
	}
}
