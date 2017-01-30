using System;
using Gtk;
using AplikacijaTaxy;

public partial class MainWindow : Gtk.Window {
	
	public MainWindow() : base(Gtk.WindowType.Toplevel) {
		Build();
		MainWindow.ForAll<Gtk.Label>((widget) => widget.ModifyFont(Pango.FontDescription.FromString("Arial 15")), this);
	}


	protected void OnDeleteEvent(object sender, DeleteEventArgs a){
		Application.Quit();
		a.RetVal = true;
	}

	protected void WindowVozača(object sender, EventArgs e) {
		WindowVozači ProzorVozača = new WindowVozači();
	}

	protected void WindowVozila(object sender, EventArgs e) {
		WindowVozila ProzorVozila = new WindowVozila();
	}

	protected void WindowVoznje(object sender, EventArgs e) {
		WindowVoznje ProzorVoznji = new WindowVoznje();
	}

	protected void WindowStatistika(object sender, EventArgs e) {
		WindowStatistika ProzorStatistika = new WindowStatistika();
	}

	protected void ZatvoriAplikaciju(object sender, EventArgs e) {
		OnDeleteEvent(sender, new DeleteEventArgs());
	}

	public static void ForAll<T>(Callback c, Container parent) where T : Gtk.Widget {
		if (parent is Container) {
			var containerParent = parent;
			containerParent.Forall((widget) => {
				if (widget is T) {
					c.Invoke(widget);
				}
				else if (widget is Container) {
					ForAll<T>(c, (Container)widget);
				}
			});
		}
	}
}
