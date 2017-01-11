using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FloatingActionButtonOrnek
{
    public partial class ListOrnek : ContentPage
    {
        public ListOrnek()
        {
            InitializeComponent();          

            var items = new List<string>();
            for (int i = 0; i < 30; i++)
            {
                items.Add(string.Format("Ürün {0}", i));
            }

            list.ItemsSource = items;
        }

        void FloatButtonTapped(object sender, EventArgs e)
        {
            DisplayAlert("Uyarı", "Floating Buton Tıklandı!", "Tamam");
        }
    }
}
