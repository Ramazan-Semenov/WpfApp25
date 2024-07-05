using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace DataGridExt
{

    /// <summary>
    /// Provides binding utility extension methods.
    /// </summary>
    public static class BindingUtilities
    {
        /// <summary>
        /// The value to boolean converter.
        /// </summary>
        private static readonly ValueToBooleanConverter ValueToBooleanConverter = new ValueToBooleanConverter();

        /// <summary>
        /// Binds the IsEnabled property of the specified element to the specified property and value.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="path">The path.</param>
        /// <param name="parameter">The converter parameter (optional).</param>
        /// <param name="bindingSource">The binding source (optional).</param>
        public static void SetIsEnabledBinding(this FrameworkElement element, string path, object parameter = null, object bindingSource = null)
        {
            if (path == null)
            {
                throw new ArgumentNullException(nameof(path));
            }

            var binding = new Binding(path);
            if (bindingSource != null)
            {
                binding.Source = bindingSource;
            }

            if (parameter != null)
            {
                binding.ConverterParameter = parameter;
                binding.Converter = ValueToBooleanConverter;
            }

            element.SetBinding(UIElement.IsEnabledProperty, binding);
        }
    }
}
