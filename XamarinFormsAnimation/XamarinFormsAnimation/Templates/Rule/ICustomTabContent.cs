using System;
using System.Security.Cryptography.X509Certificates;
namespace XamarinFormsAnimation.Templates.Rule
{
    public interface ICustomTabContent<Title, Boddy>
    {
        Title TitleContent { get; set; }
        Boddy BoddyContent { get; set; }



    }
}
