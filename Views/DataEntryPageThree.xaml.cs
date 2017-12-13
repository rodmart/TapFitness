using Xamarin.Forms;

namespace TapFitness.Views
{
    public partial class DataEntryPageThree : ContentPage
    {
        public DataEntryPageThree()
        {
            InitializeComponent();
        }
        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var temp = ((Picker)sender).SelectedIndex;
            switch (temp)
            {
                case 0:
                    Globals.TimeLevel = "20 Minutes";
                    break;
                case 1:
                    Globals.TimeLevel = "30 Minutes";
                    break;
                case 2:
                    Globals.TimeLevel = "45 Minutes";
                    break;
                case 3:
                    Globals.TimeLevel = "1 Hour";
                    break;
            }
        }
    }
}

