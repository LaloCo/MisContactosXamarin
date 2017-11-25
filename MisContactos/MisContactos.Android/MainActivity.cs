using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;
using Microsoft.WindowsAzure.MobileServices;

namespace MisContactos.Droid
{
    [Activity(Label = "MisContactos", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            string nombreArchivo = "contactos_bd.sqlite";
            string carpeta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            string rutaCompleta = Path.Combine(carpeta, nombreArchivo);

            CurrentPlatform.Init();
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App(rutaCompleta));
        }
    }
}

