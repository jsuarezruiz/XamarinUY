using System;
using Xamarin.Forms;

namespace XamarinUY.Views
{
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();
        }

        void OnCustomRendererButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MeasureRendererCheckBoxView());
        }

        void OnCustomButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MeasureCustomCheckBoxView());
        }

        void OnSkiaButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MeasureSkiaCheckBoxView());
        }

        void OnTemplatedButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MeasureTemplatedCheckBoxView());
        }
    }
}