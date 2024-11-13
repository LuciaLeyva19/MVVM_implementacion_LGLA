﻿using MVVM_implementacion_LGLA.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_implementacion_LGLA.Vista
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPrincipal : ContentPage
	{
		public MenuPrincipal ()
		{
			InitializeComponent ();
			BindingContext = new VMmenuprincipal(Navigation);
		}
	}
}