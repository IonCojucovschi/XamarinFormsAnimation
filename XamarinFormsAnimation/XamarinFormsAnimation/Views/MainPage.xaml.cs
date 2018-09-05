using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsAnimation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            var itemsPage = new ItemsPage() { Title = "Items Page" };
            var about1 = new ItemsPage() { Title = "About 1 Page" };
            var about2 = new ItemsPage() { Title = "about 2 Page" };
            this.Children.Add(new NavigationPage(itemsPage) { Title = "111" });
            this.Children.Add(new NavigationPage(about1) { Title = "222" });
            this.Children.Add(new NavigationPage(about2) { Title = "333" });

        }
    }
}