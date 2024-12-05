using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_implementacion_LGLA.Datos;
using MVVM_implementacion_LGLA.Modelo;

namespace MVVM_implementacion_LGLA.VistaModelo.VMpokemon
{
    public class VMregistropokemoncs : BaseViewModel
    {
        #region VARIABLES 
        string _Txtcolorfondo;
        string _Txtpoder;
        string _Txtnombre;
        string _Txtnro;
        string _Txticono;
        string _TxtColorPoder;
        #endregion
        #region CONSTRUCTOR

        public VMregistropokemoncs(INavigation navigation)
        {
            Navigation = navigation;
        }

        #endregion
        #region OBJETOS
        public string Txtcolorfondo
        {
            get { return _Txtcolorfondo; ; }
            set { SetValue(ref _Txtcolorfondo, value); }
        }

        public string Txtpoder
        {
            get { return _Txtpoder; ; }
            set { SetValue(ref _Txtpoder, value); }
        }

        public string Txtnombre
        {
            get { return _Txtnombre; ; }
            set { SetValue(ref _Txtnombre, value); }
        }

        public string Txtnro
        {
            get { return _Txtnro; ; }
            set { SetValue(ref _Txtnro, value); }
        }

        public string Txticono
        {
            get { return _Txticono; ; }
            set { SetValue(ref _Txticono, value); }
        }

        public string TxtColorPoder
        {
            get { return _TxtColorPoder; ; }
            set { SetValue(ref _TxtColorPoder, value); }
        }


        #endregion
        #region PROCESOS
        public async Task Insertar ()
        {
            var funcion = new Dpokemon();
            var parametros = new Mpokemon();
            parametros.Colorfondo = Txtcolorfondo;
            parametros.Colorpoder = TxtColorPoder;
            parametros.Icono = Txticono;
            parametros.Nombre = Txtnombre;
            parametros.NroOrden = Txtnro;
            parametros.Poder = Txtpoder;

            await funcion.Insertarpokemon (parametros);
            await Volver();
        }
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }
        #endregion

        #region COMANDOS
        public ICommand InsertarCommand => new Command (async()=>await Insertar());
        public ICommand Volvercommand => new Command(async () => await Volver());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
