using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentApp.Extensions
{
    public class StandardImage : IMarkupExtension
    {
        public string ResourceId
        {
            get;
            set;
        }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return ImageSource.FromResource(ResourceId);;
        }
    }
}
