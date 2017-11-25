using MisContactos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MisContactos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NuevoContactoPage : ContentPage
    {
        public NuevoContactoPage()
        {
            InitializeComponent();
        }

        private void saveButton_Clicked(object sender, EventArgs e)
        {
            Contacto nuevoContacto = new Contacto()
            {
                Nombre = nombreEntry.Text,
                Email = emailEntry.Text,
                Phone = phoneEntry.Text
            };

            //// App.Contactos.Add(nuevoContacto);

            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(App.DB_Path))
            {
                connection.Insert(nuevoContacto);
            }
        }
    }
}