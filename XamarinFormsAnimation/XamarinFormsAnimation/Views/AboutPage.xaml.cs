using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsAnimation.ViewModels;

namespace XamarinFormsAnimation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            this.BindingContext = new AboutViewModel();
        }
    }
}