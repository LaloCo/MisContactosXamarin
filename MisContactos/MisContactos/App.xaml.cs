using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MisContactos
{
    public partial class App : Application
    {
        public static ObservableCollection<Model.Contacto> Contactos;

        public static string DB_Path;
        public App()
        {
            InitializeComponent();

            Contactos = new ObservableCollection<Model.Contacto>();

            MainPage = new NavigationPage(new MisContactos.MainPage());
        }

        public App(string ruta_db)
        {
            InitializeComponent();

            DB_Path = ruta_db;

            Contactos = new ObservableCollection<Model.Contacto>();

            MainPage = new NavigationPage(new MisContactos.MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
