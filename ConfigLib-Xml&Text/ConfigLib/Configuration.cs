using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ConfigLib
{
    public static class ConfigurationHelper
    {
        public static void SaveXml(Configuration config, string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Configuration));
            using (TextWriter writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, config);
            }
        }

        public static Configuration LoadXml(string fileName)
        {
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException("Configuration file not found.");
            }

            XmlSerializer serializer = new XmlSerializer(typeof(Configuration));
            using (TextReader reader = new StreamReader(fileName))
            {
                return (Configuration)serializer.Deserialize(reader);
            }
        }

        public static void SaveText(Configuration config, string fileName)
        {
            using (TextWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(config.Setting1);
                writer.WriteLine(config.Setting2);
            }
        }

        public static Configuration LoadText(string fileName)
        {
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException("Configuration file not found.");
            }

            Configuration config = new Configuration();
            using (TextReader reader = new StreamReader(fileName))
            {
                config.Setting1 = reader.ReadLine();
                config.Setting2 = int.Parse(reader.ReadLine());
            }

            return config;
        }
    }
}
