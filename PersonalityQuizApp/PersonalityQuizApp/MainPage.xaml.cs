using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using Xamarin.Forms;

namespace PersonalityQuizApp
{
    public partial class MainPage : ContentPage
    {
        int s = 0, t = 0, a = 0, r = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnShowResults_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Results", $"You are:\n" +
                $"{s/6.0*100:F2}% structure-oriented\n" +
                $"{t/6.0*100:F2}% task-oriented\n" +
                $"{a/6.0*100:F2}% action-oriented\n" +
                $"{r/6.0*100:F2}% relationship-oriented", "Close");
        }

        // triggers once a radio button is selected, will trigger twice
        // if a radio button is changed (the check is changed twice)
        private void Question1_CheckChanged(object sender, CheckedChangedEventArgs e)
        {
            // This grabs the sender object (sent by the radio button)
            // and casts it as a RadioButton
            RadioButton selectedButton = (RadioButton)sender;

            // We can then use the cast object (which is now a radio button)
            // to check the value of the object
            CheckSelectedValue(selectedButton.IsChecked, selectedButton.Value.ToString());

        }

        private void Question2_CheckChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton selectedButton = (RadioButton)sender;
            CheckSelectedValue(selectedButton.IsChecked, selectedButton.Value.ToString());
        }

        private void Question3_CheckChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton selectedButton = (RadioButton)sender;
            CheckSelectedValue(selectedButton.IsChecked, selectedButton.Value.ToString());
        }

        private void Question4_CheckChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton selectedButton = (RadioButton)sender;
            CheckSelectedValue(selectedButton.IsChecked, selectedButton.Value.ToString());
        }

        private void Question5_CheckChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton selectedButton = (RadioButton)sender;
            CheckSelectedValue(selectedButton.IsChecked, selectedButton.Value.ToString());
        }

        private void Question6_CheckChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton selectedButton = (RadioButton)sender;
            CheckSelectedValue(selectedButton.IsChecked, selectedButton.Value.ToString());
        }

        private void CheckSelectedValue(bool isChecked, string v)
        {
            if (isChecked)
            {
                switch (v)
                {
                    case "s":
                        s++;
                        break;
                    case "t":
                        t++;
                        break;
                    case "a":
                        a++;
                        break;
                    case "r":
                        r++;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (v)
                {
                    case "s":
                        s--;
                        break;
                    case "t":
                        t--;
                        break;
                    case "a":
                        a--;
                        break;
                    case "r":
                        r--;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
