using System;
using System.Diagnostics;
using XamarinUY.Controls;
using Xamarin.Forms;

namespace XamarinUY.Views
{
    public partial class MeasureCustomCheckBoxView : ContentPage
    {
        readonly Stopwatch _stopWatch;

        public MeasureCustomCheckBoxView()
        {
            _stopWatch = new Stopwatch();
            _stopWatch.Start();

            InitializeComponent();

            //AddItems(100);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _stopWatch.Stop();

            TimeSpan ts = _stopWatch.Elapsed;
            InfoLabel.Text = $"{ts.TotalMilliseconds} ms";
        }

        void AddItems(int numberOfItems)
        {
            for (int i = 0; i < numberOfItems; i++)
            {
                ParentLayout.Children.Add(new CustomCheckBox());
            }
        }
    }
}