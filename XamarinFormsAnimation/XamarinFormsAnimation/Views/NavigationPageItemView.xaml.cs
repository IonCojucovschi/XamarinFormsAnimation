using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsAnimation.Views
{
    public partial class NavigationPageItemView<TPage> : NavigationPage where TPage : ContentPage
    {
        public NavigationPageItemView()
        {

            ///  this.BindingContext = new TPage() { Title = typeof(TPage) };
        }
    }
}
