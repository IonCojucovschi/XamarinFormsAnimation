using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinFormsAnimation.Templates.Content;
using System.Collections;

namespace XamarinFormsAnimation.Templates.Views
{
    public partial class CustomTabView : BaseTemplate<CustomTabContent>
    {
        public StackLayout BodyBaseContentTab { get; set; }
        public StackLayout TitleBaseContentTab { get; set; }


        public CustomTabView()
        {
            InitializeComponent();
            BodyBaseContentTab = GetBodyBaseContentTab();
            TitleBaseContentTab = GetTitleBaseContent();
        }

        public StackLayout GetTitleBaseContent()
        {
            return TitleBaseContent;
        }
        public StackLayout GetBodyBaseContentTab()
        {
            return BodyBaseContent;
        }
    }
}
