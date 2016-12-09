using System;
using System.Windows;

namespace WpfMultiStyle
{
    /// <summary>
    /// <see cref="System.Windows.Style"/> 的扩展。
    /// </summary>
    public static class StyleExtension
    {
        /// <summary>
        /// 合并指定的 <see cref="System.Windows.Style"/>。
        /// </summary>
        /// <param name="style1"></param>
        /// <param name="style2"></param>
        public static void Merge(this Style style1, Style style2)
        {
            if (style1 == null)
            {
                throw new ArgumentNullException("style1");
            }
            if (style2 == null)
            {
                throw new ArgumentNullException("style2");
            }

            if (style1.TargetType.IsAssignableFrom(style2.TargetType))
            {
                style1.TargetType = style2.TargetType;
            }

            if (style2.BasedOn != null)
            {
                Merge(style1, style2.BasedOn);
            }

            foreach (SetterBase currentSetter in style2.Setters)
            {
                style1.Setters.Add(currentSetter);
            }

            foreach (TriggerBase currentTrigger in style2.Triggers)
            {
                style1.Triggers.Add(currentTrigger);
            }

            // This code is only needed when using DynamicResources.
            foreach (object key in style2.Resources.Keys)
            {
                style1.Resources[key] = style2.Resources[key];
            }
        }
    }
}
