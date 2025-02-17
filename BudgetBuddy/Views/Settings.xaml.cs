﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetBuddy.Properties;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BudgetBuddy.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Settings : ContentPage
	{
	    private SQLiteAsyncConnection _connection;
        string hex1 = "#303030";

		public Settings ()
		{
		    _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            InitializeComponent ();

		}


        private async void Button_Clicked1(object sender, EventArgs e)
        {
            if (BackgroundColor == Color.White)
            {
                await DisplayAlert("Alert", "Het thema is al light!", "OK");
            }
            else
            {
                App.Current.Resources["backgroundColor"] = Color.White;
                App.Current.Resources["textColor"] = Color.FromHex(hex1);
                App.Current.Properties.Remove("savedPropB");
                await App.Current.SavePropertiesAsync();
            }
        }

        private async void Button_Clicked2(object sender, EventArgs e)
        {
            if (App.Current.Properties.ContainsKey("savedPropB"))
            {
                await DisplayAlert("Alert", "Het thema is al dark!", "OK");
            }
            else
            {
                App.Current.Resources["backgroundColor"] = Color.FromHex(hex1);
                App.Current.Resources["textColor"] = Color.White;
                App.Current.Properties.Add("savedPropB", "start");
                await App.Current.SavePropertiesAsync();
            }
        }

	    private void Button_OnClicked(object sender, EventArgs e)
	    {
	        Navigation.PushAsync(new Addcatagory());
        }

	    private void Button_OnClicked3(object sender, EventArgs e)
	    {
            Navigation.PushAsync(new ButtonChange());
	        //await _connection.ExecuteAsync("Update SQL_Buttons SET Value = ? Where Name = ?", "Overzicht", "Button1");

	    }


    }
}