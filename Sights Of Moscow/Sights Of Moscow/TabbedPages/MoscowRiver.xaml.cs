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
    public partial class MoscowRiver : TabbedPage
    {
        public MoscowRiver()
        {
            InitializeComponent();
        }
        private void IconLoginImg_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SupTheDeveloper(), true);
        }
    }
}