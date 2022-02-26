﻿using Sights_Of_Moscow.TabbedPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sights_Of_Moscow
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }
        async void OpenMinin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OsnovaPhoto(), true);
        }
        async void OpenSobor(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sobor(), true);
        }
        async void OpenRedSquare(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RedSquare(), true);
        }
        async void OpenChram(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Chram(), true);
        }
    }
}