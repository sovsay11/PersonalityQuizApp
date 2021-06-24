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
        // variables to hold response values
        const double questionNumber = 6.0;
        int s = 0, t = 0, a = 0, r = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Displays the results of the quiz to the user and checks
        /// if the user answered all the questions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowResults_Clicked(object sender, EventArgs e)
        {
            if (s + t + a + r != questionNumber)
            {
                DisplayAlert("Error", "Please answer all the questions", "Close");
            }
            else
            {
                DisplayAlert("Results", $"You are:\n" +
                    $"{s / questionNumber * 100:F2}% structure-oriented\n" +
                    $"{t / questionNumber * 100:F2}% task-oriented\n" +
                    $"{a / questionNumber * 100:F2}% action-oriented\n" +
                    $"{r / questionNumber * 100:F2}% relationship-oriented", "Close");
            }
        }

        /// <summary>
        /// Triggers once a radio button is selected, runs the CheckSelectedValue() method
        /// to determine whether the passed in radio button is being checked or unchecked
        /// Note: this method will trigger twice if a radio button is changed (the check is changed twice)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Will determine if the radio button passed in is being checked or unchecked
        /// and then add or subtract values based on that assertion
        /// </summary>
        /// <param name="isChecked"></param>
        /// <param name="v"></param>
        private void CheckSelectedValue(bool isChecked, string v)
        {
            // the radio button is selected, so we add according to the value of the rb
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
            // assume the radio button is being unchecked, so we subtract the value
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
