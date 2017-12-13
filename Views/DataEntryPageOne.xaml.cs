using Xamarin.Forms;

namespace TapFitness.Views
{
    public partial class DataEntryPageOne : ContentPage
    {
        public DataEntryPageOne()
        {
            InitializeComponent();

        }

		void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
		{
            var temp = ((Picker)sender).SelectedIndex;
            switch(temp){
                case 0:
                    Globals.fitnessGoals = "Lose weight healthy";
                    break;
                case 1:
					Globals.fitnessGoals = "Gain weight healthy";
					break;
                case 2:
					Globals.fitnessGoals = "Same weight but healthy";
					break;
            }
		}
    }
}

