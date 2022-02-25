using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Sights_Of_Moscow.Models;
using Sights_Of_Moscow.db;

namespace Sights_Of_Moscow
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.White;
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.Black;
        }
        private void IconLoginImg_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SupTheDeveloper(), true);
        }
        private async void MenuPage_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (NicknameEntry != null && EmailEntry != null && PasswordEntry != null)
                {
                    App.Db.SaveClient(new Client(NicknameEntry.Text, EmailEntry.Text, PasswordEntry.Text));
                    await Navigation.PushModalAsync(new NavigationPage(new MenuPage()));
                }
                else 
                {
                    await DisplayAlert("Уведомление", "Введите в поля данные!", "Ok");
                }
            }
            catch
            {
                await DisplayAlert("Уведомление", "Не удалось зарегистрироваться", "Ok");
            }
        }
    }
}