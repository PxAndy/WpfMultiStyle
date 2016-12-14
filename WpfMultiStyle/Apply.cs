using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfMultiStyle
{
    /// <summary>
    /// 通过附加属性使元素应用多个样式。
    /// </summary>
    public class Apply
    {
        public static string GetMultiStyle(DependencyObject obj)
        {
            return (string)obj.GetValue(MultiStyleProperty);
        }

        public static void SetMultiStyle(DependencyObject obj, string value)
        {
            obj.SetValue(MultiStyleProperty, value);
        }
        
        public static readonly DependencyProperty MultiStyleProperty = DependencyProperty.RegisterAttached("MultiStyle", typeof(string), typeof(Apply), new PropertyMetadata(null, new PropertyChangedCallback(OnMultiStyleChanged)));
        
        public static void OnMultiStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var newValue = (string)e.NewValue;
            var fe = d as FrameworkElement;
            Style result = new Style();

            if (newValue.HasValue())
            {
                var styleKeys = newValue.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var key in styleKeys)
                {
                    var style = fe.TryFindResource(key) as Style;

                    if (style != null)
                    {
                        result.Merge(style);
                    }
                }

                fe.Style = result;
            }
        }
    }
}
