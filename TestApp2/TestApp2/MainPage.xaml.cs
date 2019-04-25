using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestApp2
{
    public partial class MainPage : ContentPage
    {

        const String DEFAULT_USERNAME = "diego2102";
        const String DEFAULT_PASSWORD = "password";

        public MainPage()
        {
            InitializeComponent();
        }

        async private void SignInButton_Clicked(object sender, EventArgs e)
        {
            if ( (UsernameField.Text == DEFAULT_USERNAME) && (PasswordField.Text == DEFAULT_PASSWORD) )
            {
                await Navigation.PushModalAsync(new MainScreen());

            }
            else if ((UsernameField.Text != DEFAULT_USERNAME) && (PasswordField.Text != DEFAULT_PASSWORD))
            {
                Console.WriteLine("Incorrect Username and Password.");
            }
            else if (UsernameField.Text != DEFAULT_USERNAME)
            {
                Console.WriteLine("Incorrect Username");
            }
            else
            {
                Console.WriteLine("Incorrect Password");
            }

        }
    }
}
