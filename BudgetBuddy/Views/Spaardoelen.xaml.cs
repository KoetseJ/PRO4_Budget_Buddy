﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BudgetBuddy.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Spaardoelen : ContentPage
	{
		public Spaardoelen ()
		{
			InitializeComponent ();
		}

		private void Handle_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new Spaardoelen_Toevoegen());
		}
	}
}