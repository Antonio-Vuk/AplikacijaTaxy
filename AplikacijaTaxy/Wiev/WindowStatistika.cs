using System;

namespace AplikacijaTaxy {
	public partial class WindowStatistika : Gtk.Window {

		public WindowStatistika() : base(Gtk.WindowType.Toplevel) {
			this.Build();
			MainWindow.ForAll<Gtk.Label>((widget) => widget.ModifyFont(Pango.FontDescription.FromString("Arial 12")), this);
			GodinaSpinbutton.Value = DateTime.Now.Year;
			comboboxMjeseci.Active = DateTime.Now.Month-1;
			pitaButton.Click();

		}
		protected void WindowStatistikaIzlaz(object sender, EventArgs e) {
			this.Destroy();
		}
		private void pocistiPlotBox() {
			var list = PlotBox.AllChildren;
			foreach (Gtk.Widget w in list) {
				PlotBox.Remove(w);
			}
		}
		protected void OnButtonPitaDijagram(object sender, EventArgs e) {
			pocistiPlotBox();
			PlotBox.Add(PresenterStatistika.PieView(comboboxMjeseci.Active+1, GodinaSpinbutton.ValueAsInt));
			PlotBox.ShowAll();
		}
		protected void OnButtonStupcastiDijagram(object sender, EventArgs e) {
			pocistiPlotBox();
			PlotBox.Add(PresenterStatistika.BarView(comboboxMjeseci.Active + 1, GodinaSpinbutton.ValueAsInt));
			PlotBox.ShowAll();
		}
	}
}
