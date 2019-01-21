using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Code;
using System.ComponentModel;

namespace WebApplication2.CustomHtmlHelpers
{
    public static class CustomHtmlHelpers
    {
        public static MvcHtmlString TableColumns (Type model)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[").AppendLine();
                                    
            IList<PropertyInfo> props = new List<PropertyInfo>(model.GetProperties());
            foreach (PropertyInfo prop in props)
            {
                string propName = prop.Name;
                string displayName = DecodeCamelCase(prop.Name);
                try
                {
                    var displayNameAttr = prop.GetCustomAttributes(typeof(DisplayNameAttribute), true).Cast<DisplayNameAttribute>().Single();
                    if (displayNameAttr != null)
                    {
                        displayName = displayNameAttr.DisplayName;
                    }
                }
                catch
                {

                }
                bool showColumn = true;
                try
                {
                    var hideInListViewAttr = prop.GetCustomAttributes(typeof(HideInListViewAttribute), true).Cast<HideInListViewAttribute>().Single();
                    if (hideInListViewAttr != null)
                    {
                        showColumn = false;
                    }
                }
                catch
                {

                }
                if(showColumn)
                    sb.Append("{ 'data': '" + propName + "', 'name': '" + propName + "', 'title': '" + displayName + "' },").AppendLine();                
            }
            sb.Append("]");
            return MvcHtmlString.Create(sb.ToString());
        }

        private static string DecodeCamelCase(string camelCase)
        {
            var startIndex = 0;
            List<string> wordList = new List<string>();
            for(int i = 1; i < camelCase.Length; i++)
            {
                char c = camelCase.ElementAt(i);
                if (char.IsUpper(c))
                {                    
                    if(i - startIndex > 1)
                    {
                        wordList.Add(camelCase.Substring(startIndex, i - startIndex));
                        startIndex = i;
                    }                    
                }
            }

            if(startIndex > 0 && camelCase.Length - startIndex > 0)
            {
                wordList.Add(camelCase.Substring(startIndex, camelCase.Length - startIndex));
            }

            var decoded = "";
            foreach(string word in wordList)
            {
                decoded = decoded + word + " ";
            }

            if (string.IsNullOrEmpty(decoded))
                decoded = camelCase;

            return decoded.TrimEnd();
        }
    }
}