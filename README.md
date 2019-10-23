# ConfigurationManager

C# object oriented code to translate xml configuration file into Powershell commands

## Description

From an .xml file correctly written, this code can deserialize it to create Objects with attributes corresponding to the xml tags. These attributes are used to construct Powershell commands.
Each object created from the xml file (called ConfigOption) corresponds to a specific set of Powershell commands (ex: commands to configure IP adresses, commands to add Windows Users).
The attributes are used to dynamically construct commands (ex: attribute Name for the name of the Windows user to create).

## Usage

### XML file

<?xml version="1.0" encoding="utf-8" ?>
The first tag of the xml file must be the name of the ConfigGlobal class.
The following tags must match the ConfigGlobal Attributes, and their respective attributes.
The list of configuration options must be enclosed by <Configs><//Configs> tags.
---
Exemple : 
<?xml version="1.0" encoding="utf-8" ?>
<ConfigGlobal>
  <ConfigID>1<//ConfigID>
  <Configs>
    <SubConfigOption>
      <ConfigOptionID>10<//ConfigOptionID>
      <Attr1>Get-Date<//Attr1>
      <Attr2>DisplayHint<//Attr2>
      <Attr3>Date<//Attr3>
    <//SubConfigOption>
  <//Configs>
<//ConfigGlobal>

### Visual Studio build

This project is a Visual Studio 2019 solution.
The packages added are: System.Management.Automation, System.Collections.ObjectModel, System.IO.
Once in visual studio press F7 to build and F5 to Debug.

## Authors

William Occelli - william.occelli@gmail.com

## Project Status

Project in development.
Project started on 20/10/2019.
