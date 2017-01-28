using Gtk;

namespace AplikacijaTaxy {
	class MainClass {
		public static void Main(string[] args) {

			BazaPodataka.OtvoriKonekciju();

			Application.Init();
			Gtk.Settings.Default.SetLongProperty("gtk-button-images", 1, "");
			MainWindow win = new MainWindow();
			//win.SetPosition(WindowPosition.CenterAlways);
			win.Show();
			Application.Run();
			BazaPodataka.ZatvoriKonekciju();
		}
	}
}
