using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PersonalityQuizApp
{
    public partial class MainPage : ContentPage
    {
        string value;
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnShowResults_Clicked(object sender, EventArgs e)
        {

        }

        private void Question1_CheckChanged(object sender, CheckedChangedEventArgs e)
        {
            // This grabs the sender object (sent by the radio button)
            // and casts it as a RadioButton
            RadioButton selectedButton = (RadioButton)sender;

            // We can then use the cast object (which is now a radio button)
            // to check the value of the object
            if (selectedButton.IsChecked)
            {
                // Assuming the radio button is selected, we can display its value
                value = selectedButton.Value.ToString();
                DisplayAlert(value, value, "Close");
            }
        }
    }
}
