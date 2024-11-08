using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MVVM_implementacion_LGLA;
using MVVM_implementacion_LGLA.VistaModelo;

namespace MVVM_implementacion_LGLA.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            BindingContext = new VMpagina2(Navigation);
        }
    }
}