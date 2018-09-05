using System;
using Xamarin.Forms;
using XamarinFormsAnimation.Templates.Content;

namespace XamarinFormsAnimation.Templates.Views
{
    public class BaseTemplate<TModel> : BaseTemplate where TModel : CustomTabContent, new()
    {
        public TModel TemPlateModelView { get; set; }
        //public virtual StackLayout TitleBaseContentTab()
        //{
        //    return new StackLayout();
        //}
        //public virtual StackLayout BodyBaseContentTab()
        //{
        //    return new StackLayout();
        //}
        public BaseTemplate()
        {
            //InitializeComponent();
            var model = new TModel();
        }
    }
    public class BaseTemplate : ContentView
    {
        public BaseTemplate()
        {
        }
    }
}
