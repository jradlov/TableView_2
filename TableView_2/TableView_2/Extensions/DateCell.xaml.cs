using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TableView_2.Extensions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DateCell : ViewCell
    {
        public static readonly BindableProperty myLabelProperty =
            BindableProperty.Create("myLabel", typeof(string), typeof(DateCell));

        // GetValue & SetValue are BindableObject methods
        // BindableObject is a top class in Xamarin
        public string myLabel
        {
            get { return (string)GetValue(myLabelProperty); }
            set { SetValue(myLabelProperty, value); }
        }

        public DateCell()
        {
            InitializeComponent();

            // no need to add Binding Source in xaml for myLabel if do this:
            BindingContext = this;
        }
    }
}