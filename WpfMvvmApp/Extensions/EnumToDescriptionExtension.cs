using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvmApp.Helpers
{
    public static class EnumToDescriptionExtension
    {
        public static string ToDescription(this Enum source)
        {
            FieldInfo fi = source.GetType().GetField(source.ToString());
            var att = (DescriptionAttribute)fi.GetCustomAttribute(typeof(DescriptionAttribute));
            if (att != null)
            {
                return att.Description;
            }
            else
            {
                return source.ToString();
            }
        }
    }
}
