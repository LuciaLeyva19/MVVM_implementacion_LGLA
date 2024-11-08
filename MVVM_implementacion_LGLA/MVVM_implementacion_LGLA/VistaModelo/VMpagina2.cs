using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM_implementacion_LGLA.Modelo;
using Xamarin.Forms;
using System.Globalization;

namespace MVVM_implementacion_LGLA.VistaModelo
{
    public class VMpagina2 : BaseViewModel
    {
        #region
        string _Texto;
        public List<Musuarios> listausuarios {  get; set; }
        #endregion
        #region CONSTRUCTOR 
        public VMpagina2(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarusuarios();
        }

        #endregion

        #region OBJETOS
        public void Mostrarusuarios()
        {
            listausuarios = new List<Musuarios>
            {
                new Musuarios
                {
                    Nombre = "Lucia",
                    Imagen = "https://i.ibb.co/TBCb5vS/fantasma-personalizado.png"
                },
                new Musuarios
                {
                    Nombre = "Nicol",
                    Imagen = "https://i.ibb.co/b3B4y4p/monstruo.png"
                },
                new Musuarios
                {
                    Nombre = "Jose Luis",
                    Imagen = "https://i.ibb.co/Nm9TLxz/frankestein.png"
                }
            };
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand Volvercommand => new Command (async () => await ProcesoAsyncrono());
        //public Icommand ProcesoSimpcommand => new command (procesoSimple);
        #endregion

    }
}
