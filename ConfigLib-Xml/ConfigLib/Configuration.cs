using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
namespace ConfigLib
{
    public static class Configuration
    {
        public static void Save(ConfigurationData config, string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ConfigurationData));
            using (TextWriter writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, config);
            }
        }

        public static ConfigurationData Load(string fileName)
        {
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException("ConfigurationData file not found.");
            }

            XmlSerializer serializer = new XmlSerializer(typeof(ConfigurationData));
            using (TextReader reader = new StreamReader(fileName))
            {
                return (ConfigurationData)serializer.Deserialize(reader);
            }
        }
    }
}
