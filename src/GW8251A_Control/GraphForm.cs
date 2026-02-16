using ScottPlot;
using ScottPlot.WinForms;

namespace GW8251A_Control;

public class GraphForm : Form
{
    private readonly FormsPlot _plot;
    private readonly List<double> _times = new();
    private readonly List<double> _values = new();
    private DateTime _startTime;

    public GraphForm()
    {
        Text = "GW-8251A Live Graph";
        Size = new Size(800, 450);
        StartPosition = FormStartPosition.CenterScreen;
        BackColor = SystemColors.ControlDarkDark;

        _plot = new FormsPlot
        {
            Dock = DockStyle.Fill
        };

        _plot.Plot.FigureBackground.Color = ScottPlot.Color.FromHex("#333333");
        _plot.Plot.DataBackground.Color = ScottPlot.Color.FromHex("#1a1a1a");
        _plot.Plot.Axes.Color(ScottPlot.Color.FromHex("#cccccc"));
        _plot.Plot.Grid.MajorLineColor = ScottPlot.Color.FromHex("#444444");

        _plot.Plot.Axes.Bottom.Label.Text = "Time (s)";
        _plot.Plot.Axes.Left.Label.Text = "Value";

        Controls.Add(_plot);

        _startTime = DateTime.Now;
    }

    public void ResetData()
    {
        _times.Clear();
        _values.Clear();
        _startTime = DateTime.Now;
        RefreshPlot();
    }

    public void AddDataPoint(double value)
    {
        if (InvokeRequired)
        {
            Invoke(() => AddDataPoint(value));
            return;
        }

        double elapsed = (DateTime.Now - _startTime).TotalSeconds;
        _times.Add(elapsed);
        _values.Add(value);

        RefreshPlot();
    }

    private void RefreshPlot()
    {
        _plot.Plot.Clear();

        if (_times.Count > 1)
        {
            var scatter = _plot.Plot.Add.Scatter(_times.ToArray(), _values.ToArray());
            scatter.LineWidth = 2;
            scatter.Color = ScottPlot.Color.FromHex("#00ff00");
            scatter.MarkerSize = 0;
        }

        _plot.Plot.Axes.AutoScale();
        _plot.Refresh();
    }

    public bool AllowClose { get; set; }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        // Hide instead of close so data is preserved (unless app is shutting down)
        if (e.CloseReason == CloseReason.UserClosing && !AllowClose)
        {
            e.Cancel = true;
            Hide();
        }
        base.OnFormClosing(e);
    }
}
