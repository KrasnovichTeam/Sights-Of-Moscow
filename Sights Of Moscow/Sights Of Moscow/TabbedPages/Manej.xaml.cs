using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sights_Of_Moscow.TabbedPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Manej : TabbedPage
    {
        public Manej()
        {
            InitializeComponent();
        }
        private void IconLoginImg_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SupTheDeveloper(), true);
        }
    }
}