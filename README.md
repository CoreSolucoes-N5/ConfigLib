# ConfigLib
Libraria para configuração para guardar em XML, JSON e ficheiros de Texto. (Verificações incluidas)
# Descrição 
A biblioteca em questão é uma ferramenta de configuração que permite aos desenvolvedores armazenar e gerenciar configurações de seus aplicativos em diferentes formatos de arquivo, incluindo XML, JSON e arquivos de texto. Com a biblioteca, os desenvolvedores podem criar arquivos de configuração facilmente e salvá-los em um dos formatos suportados, permitindo que os usuários personalizem o comportamento de seus aplicativos de acordo com suas preferências.

A biblioteca oferece uma interface simples e intuitiva para acessar e modificar configurações de arquivo, permitindo que os desenvolvedores personalizem as configurações com base nas necessidades específicas de seus aplicativos. Os usuários podem facilmente ler e gravar configurações em um formato que seja adequado para eles, facilitando a compreensão e modificação das configurações do aplicativo.

Além disso, a biblioteca também oferece recursos avançados de validação de dados, para garantir que as configurações sejam armazenadas corretamente e possam ser lidas sem erros. Isso ajuda a evitar problemas de corrupção de arquivo e outros erros de configuração que possam afetar negativamente a experiência do usuário.

Em resumo, a biblioteca de configuração oferece aos desenvolvedores uma maneira simples e eficiente de gerenciar configurações de aplicativos em diferentes formatos de arquivo, permitindo que os usuários personalizem seus aplicativos de acordo com suas preferências individuais.
# Imagens 
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
