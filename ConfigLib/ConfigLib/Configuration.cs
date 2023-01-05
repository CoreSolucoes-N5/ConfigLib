using System;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace ConfigLib
{
    public class Configuration
    {
        // The path to the configuration file.
        private readonly string _configurationFilePath;

        // The configuration data.
        public ConfigurationData Data { get; set; }

        public Configuration(string configurationFilePath)
        {
            _configurationFilePath = configurationFilePath;
        }

        // Loads the configuration from the specified file.
        public void Load()
        {
            // Determine the file extension.
            string extension = Path.GetExtension(_configurationFilePath);

            // Load the configuration based on the file extension.
            switch (extension)
            {
                case ".txt":
                    LoadText();
                    break;
                case ".xml":
                    LoadXml();
                    break;
                case ".json":
                    LoadJson();
                    break;
                default:
                    throw new Exception("Invalid configuration file extension.");
            }
        }

        // Saves the configuration to the specified file.
        public void Save()
        {
            // Determine the file extension.
            string extension = Path.GetExtension(_configurationFilePath);

            // Save the configuration based on the file extension.
            switch (extension)
            {
                case ".txt":
                    SaveText();
                    break;
                case ".xml":
                    SaveXml();
                    break;
                case ".json":
                    SaveJson();
                    break;
                default:
                    throw new Exception("Invalid configuration file extension.");
            }
        }

        // Loads the configuration from a text file.
        private void LoadText()
        {
            // Read the text file.
            string[] lines = File.ReadAllLines(_configurationFilePath);

            // Parse the configuration data from the text.
            ConfigurationData data = new ConfigurationData();
            foreach (string line in lines)
            {
                if (line.StartsWith("Setting1:"))
                {
                    data.Setting1 = line.Substring("Setting1:".Length);
                }
                else if (line.StartsWith("Setting2:"))
                {
                    data.Setting2 = int.Parse(line.Substring("Setting2:".Length));
                }
                // Add additional parsing logic for other settings here.
            }

            // Set the configuration data.
            Data = data;
        }

        // Saves the configuration to a text file.
        private void SaveText()
        {
            // Write the configuration data to a string array.
            string[] lines = new string[]
            {
            "Setting1:" + Data.Setting1,
            "Setting2:" + Data.Setting2.ToString(),
                // Add additional lines for other settings here.
            };

            // Write the string array to the text file.
            File.WriteAllLines(_configurationFilePath, lines);
        }

        // Loads the configuration from an XML file.
        // Loads the configuration from a JSON file.
        private void LoadJson()
        {
            // Read the JSON file.
            string json = File.ReadAllText(_configurationFilePath);

            // Deserialize the JSON data to a ConfigurationData object.
            ConfigurationData data = JsonConvert.DeserializeObject<ConfigurationData>(json);

            // Set the configuration data.
            Data = data;
        }

        // Saves the configuration to an XML file.
        private void SaveXml()
        {
            // Create an XML serializer.
            XmlSerializer serializer = new XmlSerializer(typeof(ConfigurationData));

            // Serialize the configuration data to an XML string.
            StringWriter stringWriter = new StringWriter();
            serializer.Serialize(stringWriter, Data);
            string xml = stringWriter.ToString();

            // Write the XML string to the file.
            File.WriteAllText(_configurationFilePath, xml);
        }

        // Saves the configuration to a JSON file.
        private void SaveJson()
        {
            // Serialize the configuration data to a JSON string.
            string json = JsonConvert.SerializeObject(Data);

            // Write the JSON string to the file.
            File.WriteAllText(_configurationFilePath, json);
        }
    }
}
