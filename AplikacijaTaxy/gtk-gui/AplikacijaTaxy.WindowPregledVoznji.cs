
// This file has been generated by the GUI designer. Do not modify.
namespace AplikacijaTaxy
{
	public partial class WindowPregledVoznji
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Button button1;

		private global::Gtk.Entry entrySearch;

		private global::Gtk.Button button2;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.NodeView popisVoznji;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget AplikacijaTaxy.WindowPregledVoznji
			this.Name = "AplikacijaTaxy.WindowPregledVoznji";
			this.Title = global::Mono.Unix.Catalog.GetString("PREGLED SVIH VOZNJI");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.BorderWidth = ((uint)(10));
			// Container child AplikacijaTaxy.WindowPregledVoznji.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button1 = new global::Gtk.Button();
			this.button1.WidthRequest = 150;
			this.button1.HeightRequest = 50;
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString("NAZAD");
			this.hbox1.Add(this.button1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entrySearch = new global::Gtk.Entry();
			this.entrySearch.WidthRequest = 200;
			this.entrySearch.HeightRequest = 50;
			this.entrySearch.CanFocus = true;
			this.entrySearch.Name = "entrySearch";
			this.entrySearch.IsEditable = true;
			this.entrySearch.InvisibleChar = '●';
			this.hbox1.Add(this.entrySearch);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.entrySearch]));
			w2.PackType = ((global::Gtk.PackType)(1));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button2 = new global::Gtk.Button();
			this.button2.WidthRequest = 50;
			this.button2.HeightRequest = 0;
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			global::Gtk.Image w3 = new global::Gtk.Image();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-find", global::Gtk.IconSize.Menu);
			this.button2.Image = w3;
			this.hbox1.Add(this.button2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button2]));
			w4.PackType = ((global::Gtk.PackType)(1));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.popisVoznji = new global::Gtk.NodeView();
			this.popisVoznji.CanFocus = true;
			this.popisVoznji.Name = "popisVoznji";
			this.GtkScrolledWindow.Add(this.popisVoznji);
			this.vbox1.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
			w7.Position = 1;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 987;
			this.DefaultHeight = 548;
			this.Show();
			this.button1.Clicked += new global::System.EventHandler(this.OnButtonNazad);
			this.button2.Clicked += new global::System.EventHandler(this.OnButtonSearchClicked);
		}
	}
}
