using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginPage
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, EventArgs e)
        {
            if (this.password.Text == null && this.user.Text == null)
            {
                DisplayAlert("Error", "No username or password inserted", "OK");
            }
            else if (this.user.Text == null)
            {
                DisplayAlert("Error", "No username inserted", "OK");
            }
            else if (this.password.Text == null)
            {
                DisplayAlert("Error", "No password inserted", "OK");
            }
            else
            {
                DisplayAlert("Bien", $"Welcome {this.user.Text}, to the fantastic worl of Xamarin!", "OK");
            }

        }

    }
}
