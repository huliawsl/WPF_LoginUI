using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPF_LoginUI
{
    public class CustomButton:Button
    {
        CornerRadius CornerRadius;


        public CornerRadius cornerRadius
        {
            get { return (CornerRadius)GetValue(cornerRadiusProperty); }
            set { SetValue(cornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for cornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty cornerRadiusProperty =
            DependencyProperty.Register("cornerRadius", typeof(CornerRadius), typeof(CustomButton));


    }
}
