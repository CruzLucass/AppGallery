using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Paginas.PaginaDeMenuLateral
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [Obsolete]
    public partial class MenuLateral : MasterDetailPage
    {
        public MenuLateral()
        {
            InitializeComponent();
        }

        private void AbriPagina01(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Conteudo01());

            //desabilita menu depois do click
            IsPresented = false;
        }

        private void AbriPagina02(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Conteudo02());
            IsPresented = false;
        }

        private void AbriPagina03(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Conteudo03());
            IsPresented = false;
        }
    }
}