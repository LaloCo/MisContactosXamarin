using MisContactos.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MisContactos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            listaContactosListView.ItemSelected += ListaContactosListView_ItemSelected;
        }

        private void ListaContactosListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contactoSeleccionado = listaContactosListView.SelectedItem as Contacto;

            Navigation.PushAsync(new DetallesContactoPage(contactoSeleccionado));
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            var Contactos = await Contacto.Read();
            listaContactosListView.ItemsSource = Contactos;

            //using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_Path))
            //{
            //    conn.CreateTable<Contacto>();

            //    var contactos = conn.Table<Contacto>().ToList();

            //    ObservableCollection<Contacto> observableContactos = new ObservableCollection<Contacto>(contactos);

            //    listaContactosListView.ItemsSource = observableContactos;
            //}
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NuevoContactoPage());
        }
    }
}


//! http://bit.ly/2jnNcU3
//! https://github.com/LaloCo/MisContactosXamarin.git