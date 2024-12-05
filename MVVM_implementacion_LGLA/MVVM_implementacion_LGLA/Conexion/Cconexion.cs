using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace MVVM_implementacion_LGLA.Conexion
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvmlgla-default-rtdb.firebaseio.com/");
    }
}
