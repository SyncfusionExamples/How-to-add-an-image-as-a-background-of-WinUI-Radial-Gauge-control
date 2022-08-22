using Microsoft.UI.Xaml;
using Syncfusion.UI.Xaml.Gauges;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BackgroundContent
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void RadialAxis_LabelPrepared(object sender, LabelPreparedEventArgs e)
        {
            if (e.LabelText == "90")
            {
                e.LabelText = "E";
            }
            else if (e.LabelText == "360")
            {
                e.LabelText = string.Empty;
            }
            else
            {
                if (e.LabelText == "0")
                {
                    e.LabelText = "N";
                }
                else if (e.LabelText == "180")
                {
                    e.LabelText = "S";
                }
                else if (e.LabelText == "270")
                {
                    e.LabelText = "W";
                }
            }
        }
        public void Dispose()
        {
            this.axis.LabelPrepared -= this.RadialAxis_LabelPrepared;
            this.gauge.Dispose();
        }
    }
}
