using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Data_Entry
{
  public class App : Application
  {
    public App ()
    {
      MainPage = new NavigationPage(new MainPage()); // Navigate to the MainPage we just added before
      }
  protected override void OnStart ()
  {
      // Handle when your app starts
  }
  
  protected override voide OnSleep ()
  {
      // Handle when your app sleeps
  }
  
  protected override voide OnResume()
  {
      // Handle when your app resumes
  }
