using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Temperature_Converter.CommonObjects;


namespace Temperature_Converter.Utils
{
    public class ClassDataTemplateSelector : DataTemplateSelector
    {

        [DefaultValue(ViewTypeId.Simple)]
        public ViewTypeId ViewTypeId { get; set; }

        [DefaultValue(ViewTypeId.Simple)]
        public ViewTypeId FallbackViewTypeId { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            DataTemplate dt = null;
            DataTemplate template;
            // try get the data template for the item

            if (item is null) return null;
            string typeName = item.GetType().Name;
            var dataTemplateName = string.Format("{0}:{1}", item.GetType().Name, this.ViewTypeId);
            return this.GetDataTemplate(typeName, dataTemplateName, out template) ? template : null;

        }
        public DataTemplate ContainerViewTemplate { get; set; }


        private static readonly Dictionary<string, Uri> _classUrIs = new Dictionary<string, Uri>(1000)
        {
         {
             "Celsius", new Uri("/Temperature_Converter;component/Views/DataTemplates/Celsius.xaml", UriKind.Relative)
         },
         {
             "Fahrenheit", new Uri("/Temperature_Converter;component/Views/DataTemplates/Fahrenheit.xaml", UriKind.Relative)
         },
         {
             "TemperatureViewModel", new Uri("/Temperature_Converter;component/Views/DataTemplates/TemperatureViewModel.xaml", UriKind.Relative)
         },

        };
        private bool GetDataTemplate(string typeName, string dataTemplateName, out DataTemplate dataTemplate)
        {
            dataTemplate = null;
            if (_classUrIs.ContainsKey(typeName))
            {
                Uri classUri;
                if (_classUrIs.TryGetValue(typeName, out classUri))
                {
                    {
                        var resourceDictionary = (ResourceDictionary)Application.LoadComponent(classUri);
                        if (resourceDictionary.Contains(dataTemplateName))
                        {
                            dataTemplate = resourceDictionary[dataTemplateName] as DataTemplate;
                            {
                                return true;
                            }
                        }
                    }
                }

            }
            return false;
        }
    }
}
