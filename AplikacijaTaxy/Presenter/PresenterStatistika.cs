using OxyPlot;
using OxyPlot.Series;
using OxyPlot.GtkSharp;
using OxyPlot.Axes;
using System.Collections.Generic;

namespace AplikacijaTaxy {
	public static class PresenterStatistika {
		
		public static PlotView PieView(int mjesec, int godina) {

			var myModel = new PlotModel {Title = "Statistika: " +mjesec+". mjesec "+godina+". godine" };
			var series = new PieSeries { StrokeThickness = 2.0, InsideLabelPosition = 0.8, AngleSpan = 360, StartAngle = 0 };

			foreach (KeyValuePair<string, long> s in DBVozaci.ZaradaRadnika(mjesec,godina)) {
				series.Slices.Add(new PieSlice(s.Key, s.Value));
			}
			myModel.Series.Add(series);
			var pv = new PlotView();
			pv.Model = myModel;

			return pv;
		}

		public static PlotView BarView(int mjesec, int godina) {
			var items = new List<ColumnItem>();
			var kat = new List<string>();
			var list = DBVozaci.ZaradaRadnika(mjesec, godina);

			foreach (KeyValuePair<string, long> t in list) {
				var b = new ColumnItem(t.Value);
				items.Add(b);
				kat.Add(t.Key);
			}

			if (list.Count > 1) {
				int i = 0;
				var listaBoja = OxyPalettes.Cool(list.Count).Colors;
				foreach (ColumnItem cI in items) {
					cI.Color = listaBoja[i];
					i++;
				}
			}

			var barSeries = new ColumnSeries() {
				ItemsSource = items,
				LabelPlacement = LabelPlacement.Base,
				LabelFormatString = "{0:.00} kn"
			};

			var model = new PlotModel { Title = "Statistika: " + mjesec + ". mjesec " + godina + ". godine" };

			model.Series.Add(barSeries);

			model.Axes.Add(new CategoryAxis {
				Position = AxisPosition.Bottom,
				Key = "Datum",
				ItemsSource = kat

			});

			model.Axes.Add(new LinearAxis {
				Position = AxisPosition.Left,
			});

			var pv = new PlotView();
			pv.Model = model;
			return pv;
		}
	}
}
