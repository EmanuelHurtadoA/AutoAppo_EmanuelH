using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AutoAppo_EmanuelH.ViewModels;
namespace AutoAppo_EmanuelH.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppoLoginPage : ContentPage
    {
        UserViewModel viewModel;

        public AppoLoginPage()
        {
            InitializeComponent();

            this.BindingContext = viewModel = new UserViewModel();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            bool R = false;

            if (TxtEmail.Text != null && !string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
                    TxtPassword.Text != null && !string.IsNullOrEmpty(TxtPassword.Text.Trim()))
            {
                try
                {
                    UserDialogs.Instance.ShowLoading("Checking User Access...");
                    await Task.Delay(2000);

                    string email = TxtEmail.Text.Trim();
                    string password = TxtPassword.Text.Trim();

                    R = await viewModel.UserAccessValidation(email,password);
                }
                catch (Exception)
                {

                    throw;
                }
                finally 
                { 
                UserDialogs.Instance.HideLoading();
                }
               


            }
            else 
            {

                await DisplayAlert("Validation Error", "User Email and Password are required", " OK");
                return;

            }

            if (R)
            {
                await DisplayAlert("Validation Ok", "Access Granted", " OK");
                return;
            }
            else
            {
                await DisplayAlert("Validation failed", "Access Denied", " OK");
                return;
            }


        }

        private void BtnSignUp_Clicked(object sender, EventArgs e)
        {

        }
    }
}