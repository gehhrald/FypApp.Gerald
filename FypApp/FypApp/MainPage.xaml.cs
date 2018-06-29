using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FypApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Login_Click(object sender, EventArgs e)
        {
            if(Validate())
            {
                DisplayAlert("Login", "Successfully logged in", "Ok!");
                //Navigation.PushAsync(new UserMainPage());
                App.Current.MainPage = new UserMainPage();
            }
            else
            {
                DisplayAlert("Login", "Failed to logged in", "Try again");
            }
            
        }

        private bool Validate()
        {
            if(!string.IsNullOrEmpty(username.Text) && !string.IsNullOrEmpty(password.Text))
            {
                return true;
            }
            return false;
        }
    }
}
