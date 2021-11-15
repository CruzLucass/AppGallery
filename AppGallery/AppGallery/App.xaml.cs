using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//using AppGallery.XamarinForms.Paginas.PaginaDeNavegacao;
using AppGallery.XamarinForms.Paginas.Modal;
//using AppGallery.XamarinForms.Paginas.PaginaDeCarousel;

namespace AppGallery
{
    public partial class App : Application
    {
        [Obsolete]
        public App()
        {
            InitializeComponent();
            /*
            var pagina = new NavigationPage(
                new Conteudo01()
                );

            var pagina = new Conteudo01();

            */

            /*
             * NAVEGATION TYPE CAROUSEL
            var pagina = new CarouselPage();
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarousel.Conteudo01());
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarousel.Conteudo02());
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarousel.Conteudo03());

            //abre a pagina do meio com principal
            pagina.CurrentPage = pagina.Children[1];

             * NAVEGATION TYPE TABBED
            var pagina = new TabbedPage();
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeAbas.Conteudo01());
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeAbas.Conteudo02());
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeAbas.Conteudo03());

            //abre a pagina do meio com principal
            pagina.CurrentPage = pagina.Children[1];

            MASTER DETAIL VIA PROGRAMAÇÃO
            var pagina = new MasterDetailPage();
            //Menu
            pagina.Master = ;
            //Conteudo
            pagina.Detail = ;
            */





            MainPage = new AppBase.Menu();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
