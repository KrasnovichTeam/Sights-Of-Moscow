using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sights_Of_Moscow.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sights_Of_Moscow
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public static Client client = new Client();
        public LoginPage()
        {
            InitializeComponent();
        }
        private void RigistrationPageBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrationPage(), true);
        }
        private async void LoginBtn_Clicked(object sender, EventArgs e)
        {
            var lst = App.Db.GetClients();
            bool state = false;

            foreach (var item in lst)
            {
                if (LoginEntry == null && PasswordEntry == null)
                {
                    await DisplayAlert("Уведомление", "Не правилный логин или пароль", "Ok");
                }
                else if (item.Nickname == LoginEntry.Text)
                {
                    if (item.Password == PasswordEntry.Text && state == false)
                    {
                        state = true;
                        var a = new NavigationPage(new MenuPage());
                        a.BarTextColor = Color.Black;
                        await Navigation.PushModalAsync(a);
                        await DisplayAlert("Привет Пользователь", $"ваш никнейм - {LoginEntry.Text}", "ОК");
                    }
                }
            }            
            if (!state)
            await DisplayAlert("Уведомление", "Не правилный логин или пароль", "Ok");
        }
    }
}