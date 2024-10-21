using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_implementacion_LGLA.VistaModelo
{
    internal class VMpatron : BaseViewModel
    {
        #region VARIABLES 
        string _Texto;
        #endregion
        #region CONSTRUCTOR

        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; } 
            set { SetValue(ref _Texto, value);}
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrong()
        {

        }
        public void ProcesoSimple()
        {

        }
        #endregion
    }
}


