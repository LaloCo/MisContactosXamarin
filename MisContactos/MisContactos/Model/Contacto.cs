using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisContactos.Model
{
    public class Contacto
    {
        public static MobileServiceClient MobileService =
            new MobileServiceClient(
            "http://miscontactosxamarin.azurewebsites.net"
        );

        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public static async Task<bool> Insert(Contacto contacto)
        {
            try
            {
                await MobileService.GetTable<Contacto>().InsertAsync(contacto);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static async Task<ObservableCollection<Contacto>> Read()
        {
            try
            {
                var contactos = await MobileService.GetTable<Contacto>().ToListAsync();

                ObservableCollection<Contacto> observableContactos = new ObservableCollection<Contacto>(contactos);

                return observableContactos;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}


// https://github.com/LaloCo/MisContactosXamarin.git