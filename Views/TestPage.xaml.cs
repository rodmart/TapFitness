using Xamarin.Forms;
using System;
namespace TapFitness.Views
{
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();
        }
        public async void Button_OnClicked(object sender, EventArgs e)
        {
            await MainGrid.TranslateTo(150, 200, 1000, Easing.Linear);
            await MainGrid.RotateTo(360, 800, Easing.SinOut);
            await MainGrid.TranslateTo(-50, -20, 1000, Easing.Linear);
            await MainGrid.TranslateTo(80, 200, 1000, Easing.Linear);
            await MainGrid.RotateTo(720, 800, Easing.SinOut);
            await MainGrid.FadeTo(.5, 600, Easing.CubicOut);
            await MainGrid.LayoutTo(new Rectangle(-150,-50,300, 100));
        }
    }
}

