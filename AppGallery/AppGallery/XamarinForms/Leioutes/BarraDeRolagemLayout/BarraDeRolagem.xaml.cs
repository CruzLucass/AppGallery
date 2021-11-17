using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Leioutes.BarraDeRolagemLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarraDeRolagem : ContentPage
    {
        public BarraDeRolagem()
        {
            InitializeComponent();
        }

        //faz a tela rola para a segunda label do scroll
        private void RolarParaSegundaLabel(object sender, EventArgs e)
        {
            BarraRolagem.ScrollToAsync(SegundaLabel, ScrollToPosition.Start, true);
        }

        private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            Posicao.Text = e.ScrollX + "-" + e.ScrollY;
        }
    }
}