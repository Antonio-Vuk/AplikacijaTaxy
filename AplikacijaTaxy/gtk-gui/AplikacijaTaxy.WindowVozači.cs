
// This file has been generated by the GUI designer. Do not modify.
namespace AplikacijaTaxy
{
	public partial class WindowVozači
	{
		private global::Gtk.VBox vbox5;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Button button11;

		private global::Gtk.Entry entrySearch;

		private global::Gtk.Button button4;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.NodeView popisVozaca;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Button button12;

		private global::Gtk.Button button14;

		private global::Gtk.Button button_UNOS_VOZACA;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget AplikacijaTaxy.WindowVozači
			this.Name = "AplikacijaTaxy.WindowVozači";
			this.Title = global::Mono.Unix.Catalog.GetString("VOZAČI");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.BorderWidth = ((uint)(10));
			// Container child AplikacijaTaxy.WindowVozači.Gtk.Container+ContainerChild
			this.vbox5 = new global::Gtk.VBox();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.button11 = new global::Gtk.Button();
			this.button11.WidthRequest = 150;
			this.button11.HeightRequest = 50;
			this.button11.CanFocus = true;
			this.button11.Name = "button11";
			this.button11.UseUnderline = true;
			this.button11.Label = global::Mono.Unix.Catalog.GetString("NAZAD");
			global::Gtk.Image w1 = new global::Gtk.Image();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-ok", global::Gtk.IconSize.Menu);
			this.button11.Image = w1;
			this.hbox6.Add(this.button11);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.button11]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.entrySearch = new global::Gtk.Entry();
			this.entrySearch.WidthRequest = 200;
			this.entrySearch.HeightRequest = 45;
			this.entrySearch.CanFocus = true;
			this.entrySearch.Name = "entrySearch";
			this.entrySearch.IsEditable = true;
			this.entrySearch.InvisibleChar = '●';
			this.hbox6.Add(this.entrySearch);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.entrySearch]));
			w3.PackType = ((global::Gtk.PackType)(1));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.button4 = new global::Gtk.Button();
			this.button4.WidthRequest = 45;
			this.button4.HeightRequest = 45;
			this.button4.CanFocus = true;
			this.button4.Name = "button4";
			this.button4.UseUnderline = true;
			global::Gtk.Image w4 = new global::Gtk.Image();
			w4.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-find", global::Gtk.IconSize.Menu);
			this.button4.Image = w4;
			this.hbox6.Add(this.button4);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.button4]));
			w5.PackType = ((global::Gtk.PackType)(1));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox5.Add(this.hbox6);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox6]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.popisVozaca = new global::Gtk.NodeView();
			this.popisVozaca.CanFocus = true;
			this.popisVozaca.Name = "popisVozaca";
			this.GtkScrolledWindow.Add(this.popisVozaca);
			this.vbox5.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.GtkScrolledWindow]));
			w8.Position = 1;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.button12 = new global::Gtk.Button();
			this.button12.WidthRequest = 150;
			this.button12.HeightRequest = 50;
			this.button12.CanFocus = true;
			this.button12.Name = "button12";
			this.button12.UseUnderline = true;
			this.button12.Label = global::Mono.Unix.Catalog.GetString("UKLONI");
			global::Gtk.Image w9 = new global::Gtk.Image();
			w9.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-remove", global::Gtk.IconSize.Menu);
			this.button12.Image = w9;
			this.hbox7.Add(this.button12);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.button12]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.button14 = new global::Gtk.Button();
			this.button14.WidthRequest = 150;
			this.button14.Sensitive = false;
			this.button14.CanFocus = true;
			this.button14.Name = "button14";
			this.button14.UseUnderline = true;
			this.button14.Label = global::Mono.Unix.Catalog.GetString("IZMJENA");
			this.hbox7.Add(this.button14);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.button14]));
			w11.PackType = ((global::Gtk.PackType)(1));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.button_UNOS_VOZACA = new global::Gtk.Button();
			this.button_UNOS_VOZACA.WidthRequest = 150;
			this.button_UNOS_VOZACA.HeightRequest = 0;
			this.button_UNOS_VOZACA.CanFocus = true;
			this.button_UNOS_VOZACA.Name = "button_UNOS_VOZACA";
			this.button_UNOS_VOZACA.UseUnderline = true;
			this.button_UNOS_VOZACA.Label = global::Mono.Unix.Catalog.GetString("UNOS");
			global::Gtk.Image w12 = new global::Gtk.Image();
			w12.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-add", global::Gtk.IconSize.Menu);
			this.button_UNOS_VOZACA.Image = w12;
			this.hbox7.Add(this.button_UNOS_VOZACA);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.button_UNOS_VOZACA]));
			w13.PackType = ((global::Gtk.PackType)(1));
			w13.Position = 2;
			w13.Expand = false;
			w13.Fill = false;
			this.vbox5.Add(this.hbox7);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox7]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			this.Add(this.vbox5);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 1087;
			this.DefaultHeight = 580;
			this.Show();
			this.button11.Clicked += new global::System.EventHandler(this.WindowVozaciIzlaz);
			this.button4.Clicked += new global::System.EventHandler(this.OnButtonSearchClicked);
			this.button12.Clicked += new global::System.EventHandler(this.OnClickerObrisiVozaca);
			this.button_UNOS_VOZACA.Clicked += new global::System.EventHandler(this.On_Button_Unos_Vozaca);
			this.button14.Clicked += new global::System.EventHandler(this.OnButtonIzmijeniVozaca);
		}
	}
}
