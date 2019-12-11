---
title: "Localizing VSIX Packages | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "localize package"
  - "localize extension"
  - "localized deployment"
ms.assetid: 10e80b13-b39e-466c-a7c8-774a862355af
caps.latest.revision: 14
ms.author: gregvanl
manager: jillfra
---
# Localizing VSIX Packages
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can localize a VSIX package by creating an Extension.vsixlangpack file for each target language and then putting them in the correct folder. When a localized package is installed, the localized name of the extension is displayed together with a localized description. If you supply a localized license file, or a URL that points to localized information, they are also displayed.  
  
 If the content your VSIX package includes a VSPackage that adds menu commands or other UI, see [Localizing Menu Commands](../extensibility/localizing-menu-commands.md) for information about localizing the new UI elements.  
  
## Directory Structure  
 When a user installs an extension, **Extensions and Updates** checks the top level of the VSIX package for a folder whose name matches the Visual Studio locale of the target computer. If **Extensions and Updates** finds a .vsixlangpack file in the folder, it substitutes the localized values in that file for the corresponding values in the .vsixmanifest file. These values are displayed when the extension is being installed. The following example shows the directory structure for a VSIX package that is localized into Spanish (es-ES) and French (fr-FR).  
  
 MyExtension.dll  
  
 Extension.vsixmanifest  
  
 [Content_Types].xml  
  
 es-ES  
  
 Extension.vsixlangpack  
  
 fr-FR  
  
 Extension.vsixlangpack  
  
> [!NOTE]
> The VSIX-supported project templates in the [!INCLUDE[vsipsdk](../includes/vsipsdk-md.md)] generate a VSIX manifest and name it source.extension.vsixmanifest. When Visual Studio builds the project, it copies the content of that file into Extension.VsixManifest in the VSIX package.  
  
## The Extension.vsixlangpack File  
 The Extension.vsixlangpack file follows the [VSIX Language Pack Schema](../extensibility/vsx-language-pack-schema-reference.md). This schema has a [VSIXLanguagePack](../extensibility/vsixlanguagepack-element-vsix-language-pack-schema.md) root element, and these four child elements: [LocalizedName](../extensibility/localizedname-element-vsix-language-pack-schema.md), [LocalizedDescription](../extensibility/localizeddescription-element-vsix-language-pack-schema.md), [MoreInfoURL](../extensibility/moreinfourl-element-vsix-language-pack-schema.md), and [License](../extensibility/license-element-vsix-language-pack-schema.md). These child elements correspond to the `Name`, `Description`, `MoreInfoURL`, and `License` child elements of the `Identifier` element of the Extension.vsixmanifest file.  
  
 When you create a vsixlangpack file, you must set the `Include in Vsix` property to `true`. Otherwise, the localized installation text will be ignored.  
  
#### To set the Include in Vsix property  
  
1. In **Solution Explorer**, right-click the Extension.vsixlangpack file, and then click **Properties**.  
  
2. In the Property Grid, click **Include in Vsix**, and set its value to `true`.  
  
## Example  
  
### Description  
 The following example shows relevant portions of an Extension.vsixmanifest file, together with the corresponding Extension.vsixlangpack file for Spanish. The values from the language pack replace the values from the manifest if the Visual Studio locale of the target computer is set to Spanish.  
  
### Code  
 [Extension.vsixmanifest]  
  
```  
<?xml version="1.0" encoding="utf-8"?>  
<VSIX ...>  
  <Identifier ...>  
    <Name>Family Tree</Name>  
    <Description>This extension places a custom treeview control in the toolbox that is optimized for handling family tree information.</Description>  
    <License>EULA.rtf</License>  
    <MoreInfoURL>http://www.contoso.com/products/FamilyTree.htm</MoreInfoURL>  
    ...  
  </Identifier>  
  <References .../>  
  <Content .../>  
</VSIX>  
```  
  
 [Extension.vsixlangpack]  
  
```  
<?xml version="1.0" encoding="utf-8"?>  
<VsixLanguagePack Version="1.0.0" xmlns="http://schemas.microsoft.com/developer/vsx-schema-lp/2010">  
  <LocalizedName>Arbol de Familia</LocalizedName>  
  <LocalizedDescription> Esta extensión pone control personalizado en la caja de herramientas por manejar información de familia.</LocalizedDescription>  
  <License>es\Eula.rtf</License>  
  <MoreInfoUrl> http://www.contoso.com/products/es/ArbolDeFamilia.htm</MoreInfoUrl>  
</VsixLanguagePack>  
```  
  
## See Also  
 [VSIX LanguagePack Element](../extensibility/vsixlanguagepack-element-vsix-language-pack-schema.md)   
 [Anatomy of a VSIX Package](../extensibility/anatomy-of-a-vsix-package.md)   
 [VSIX Project Template](../extensibility/vsix-project-template.md)
