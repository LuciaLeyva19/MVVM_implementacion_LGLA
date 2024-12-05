using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MVVM_implementacion_LGLA.VistaModelo.VMpokemon;
using MVVM_implementacion_LGLA.Vista.Pokemon;

namespace MVVM_implementacion_LGLA.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listapokemon : ContentPage
    {
        public Listapokemon()
        {
            InitializeComponent();
            BindingContext = new VMlistapokemon(Navigation);
         
        }

       
    }
}