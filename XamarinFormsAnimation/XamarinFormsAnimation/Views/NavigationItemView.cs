using System;

using Xamarin.Forms;

namespace XamarinFormsAnimation.Views
{
    public class NavigationItemView : ContentPage
    {
        public NavigationItemView()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

