using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SerializationWithXml
{
    public class XmlSerializer
    {
        public static string Serialize(object obj)
        {
            StringBuilder sb = new StringBuilder();
            SerializeObject(sb, obj, obj.GetType().Name,0);
            return sb.ToString();
        }

        private static void SerializeObject(StringBuilder sb, object obj, string parentElement, int indentLevel)
        {
            if (obj == null)
            {
                if (parentElement != null)
                {
                    AppendIndentation(sb, indentLevel);
                    sb.AppendLine($"<{parentElement}></{parentElement}>");
                }
                return;
            }

            Type objType = obj.GetType();
            PropertyInfo[] properties = objType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            if (parentElement != null)
            {
                AppendIndentation(sb, indentLevel);
                sb.AppendLine($"<{parentElement}>");
            }

            foreach (var prop in properties)
            {
                if (prop.GetIndexParameters().Length > 0) continue;  // Skip indexers

                object value = prop.GetValue(obj);
                string propertyName = prop.Name;

                if (value == null)
                {
                    AppendIndentation(sb, indentLevel + 1);
                    sb.AppendLine($"<{propertyName}></{propertyName}>");
                }
                else if (IsSimpleType(value.GetType()))
                {
                    AppendIndentation(sb, indentLevel + 1);
                    sb.AppendLine($"<{propertyName}>{value}</{propertyName}>");
                }
                else if (IsCollection(value.GetType()) && !(value is string))  // Handle array or collection (excluding strings)
                {
                    IEnumerable collection = (IEnumerable)value;

                    if (propertyName == "Tags")  // Special handling for Tags property (array of strings)
                    {
                        AppendIndentation(sb, indentLevel + 1);
                        sb.AppendLine($"<{propertyName}>");

                        foreach (var item in collection)
                        {
                            AppendIndentation(sb, indentLevel + 2);
                            sb.AppendLine($"<String>{item}</String>");  // Wrap each string in <String> element
                        }
                    }
                    else
                    {
                        AppendIndentation(sb, indentLevel + 1);
                        sb.AppendLine($"<{propertyName}>");
                        if (propertyName == "Tags")
                        {
                            break;
                        }
                        else
                        {
                            foreach (var item in collection)
                            {
                                if (item == null)
                                {
                                    AppendIndentation(sb, indentLevel);
                                    sb.AppendLine("");
                                }
                                else
                                {
                                    SerializeObject(sb, item, item.GetType().Name, indentLevel + 2);  // Serialize each item as a generic "Item"

                                }

                            }
                        }

                    }
                    AppendIndentation(sb, indentLevel + 1);
                    sb.AppendLine($"</{propertyName}>");
                }
                else
                {
                    SerializeObject(sb, value, propertyName, indentLevel + 1);  // Recursively serialize complex objects
                }
            }

            if (parentElement != null)
            {
                AppendIndentation(sb, indentLevel);
                sb.AppendLine($"</{parentElement}>");
            }
        }

        private static bool IsSimpleType(Type type)
        {
            return type.IsPrimitive || type == typeof(string) || type == typeof(DateTime) || type == typeof(decimal);
        }

        private static bool IsCollection(Type type)
        {
            return typeof(IEnumerable).IsAssignableFrom(type) && type != typeof(string);
        }

        private static void AppendIndentation(StringBuilder sb, int indentLevel)
        {
            sb.Append(new string(' ', indentLevel));
        }
    }

}
