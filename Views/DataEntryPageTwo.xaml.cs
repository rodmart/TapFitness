using Xamarin.Forms;

namespace TapFitness.Views
{
    public partial class DataEntryPageTwo : ContentPage
    {
        public DataEntryPageTwo()
        {
            InitializeComponent();
        }
		void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			var temp = ((Picker)sender).SelectedIndex;
			switch (temp)
			{
				case 0:
					Globals.activityLevel = "Not Active";
					break;
				case 1:
					Globals.activityLevel = "Somewhat Active";
					break;
				case 2:
					Globals.activityLevel = "Moderately Active";
					break;
				case 3:
					Globals.activityLevel = "Very Active";
					break;
			}
		}
    }
	
}

