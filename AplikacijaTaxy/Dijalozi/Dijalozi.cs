using Gtk;
namespace AplikacijaTaxy {
	
	public static class Dijalozi {
		public static void showError(Gtk.Window prozor, string message) { 
			Dialog d = new Gtk.MessageDialog(prozor, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, message);
			//d.SetPosition(WindowPosition.Center);
			d.Run();
			d.Destroy();
		}

		public static bool ShowYesNo(Window prozor, string message) {
			Dialog d = new Gtk.MessageDialog(prozor, DialogFlags.Modal, MessageType.Question, ButtonsType.None, message);
			d.AddButton("Da", Gtk.ResponseType.Yes);
			d.AddButton("Ne", Gtk.ResponseType.No);
			//d.SetPosition(WindowPosition.Center);

			ResponseType rt = (ResponseType)d.Run();
			d.Destroy();

			if (rt == ResponseType.Yes) return true;
			return false;
		}
	}
}
