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
    public partial class DetallesContactoPage : ContentPage
    {
        Contacto Contacto;
        public DetallesContactoPage(Contacto contacto)
        {
            InitializeComponent();

            Contacto = contacto;

            nombreLabel.Text = Contacto.Nombre;
            phoneLabel.Text = Contacto.Phone;
            emailLabel.Text = Contacto.Email;
        }
    }
}