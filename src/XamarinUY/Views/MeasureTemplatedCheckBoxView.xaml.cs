using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace XamarinUY.Views
{
    public partial class MeasureTemplatedCheckBoxView : ContentPage
    {
        readonly Stopwatch _stopWatch;

        public MeasureTemplatedCheckBoxView()
        {
            _stopWatch = new Stopwatch();
            _stopWatch.Start();

            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _stopWatch.Stop();

            TimeSpan ts = _stopWatch.Elapsed;
            InfoLabel.Text = $"{ts.TotalMilliseconds} ms";
        }
    }
}