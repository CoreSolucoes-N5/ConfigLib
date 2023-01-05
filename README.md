# ConfigLib
Libraria para configuração para guardar em XML, JSON e ficheiros de Texto. (Verificações incluidas)

![image](https://user-images.githubusercontent.com/50460047/210865932-0edf38b1-0fef-41f1-8084-67f88a91a613.png)

## string vConfigurationFilePath;
## ConfigurationData vData { get; set; }
The configuration data.

## Configuration(string pConfigurationFilePath)
Inicializador

## public void Load()
Loads the configuration from the specified file.

## public void Save()
Saves the configuration to the specified file.

## private void LoadText()
Loads the configuration from a text file.

## private void SaveText()
Saves the configuration to a text file.

## private void LoadJson()
Loads the configuration from a JSON file.

## private void SaveXml()
Saves the configuration to an XML file.

## private void LoadXml()
Loads the configuration from a XML file.

## private void SaveJson()
Saves the configuration to a JSON file.
