using System;
using MyBetterPlugin;
using MyPlugin;
using Xamarin.Forms;


namespace MultiLibrary
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            lblVersion.Text = CrossEnvironment.Current.Version;

            lblBetterVersion.Text = CrossBetterEnvironment.Current.Version;
        }
    }
}
