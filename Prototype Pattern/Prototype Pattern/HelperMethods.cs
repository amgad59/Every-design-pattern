using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prototype_Pattern.Prototype_Pattern
{
    public static class HelperMethods
    {
        public static T DeepCopy<T>(this T self)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(ms, self);
                ms.Position = 0;
                return (T)serializer.Deserialize(ms);
            }
        }
    }
}
