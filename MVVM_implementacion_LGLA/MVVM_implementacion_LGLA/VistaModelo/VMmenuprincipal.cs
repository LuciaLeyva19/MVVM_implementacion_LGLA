using MVVM_implementacion_LGLA.Modelo;
using MVVM_implementacion_LGLA.Vista;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_LGLA.VistaModelo
{
    class VMmenuprincipal : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Mmenuprincipal> listausuarios { get; set; }
        #endregion
        #region CONSTRUCTOR 
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarusuarios();
        }

        #endregion

        #region OBJETOS
        public void Mostrarusuarios()
        {
            listausuarios = new List<Mmenuprincipal>
            {
                new Mmenuprincipal
                {
                    Pagina = "Entry, datepicker, picker, label, navegacion",
                    Icono = "https://i.ibb.co/TBCb5vS/fantasma-personalizado.png"
                },
                new Mmenuprincipal
                {
                    Pagina = "CollectionView sin enlace a base de datos",
                    Icono = "https://i.ibb.co/b3B4y4p/monstruo.png"
                },
                new Mmenuprincipal
                {
                    Pagina = "Crud pokemon",
                    Icono = "https://i.ibb.co/Nm9TLxz/frankestein.png"
                }
            };
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public async Task Navegar(Mmenuprincipal parametros)
        {
            string pagina;
            pagina = parametros.Pagina;
            if (pagina.Contains("Entry, datapicker"))
            {
                await Navigation.PushAsync(new Page1());
            }
            if (pagina.Contains("CollectionView sin enlace"))
            {
                await Navigation.PushAsync(new Page2());
            }
            if (pagina.Contains("Crud pokemon"))
            {
                await Navigation.PushAsync(new Crudpokemon());
            }
        }
        #endregion
        #region COMANDOS
        public ICommand Volvercommand => new Command(async () => await ProcesoAsyncrono());
        //public Icommand ProcesoSimpcommand => new command (procesoSimple);
        public ICommand Alertacommand => new Command<Mmenuprincipal>(async (p) => await Navegar(p));
        #endregion
    }
}
