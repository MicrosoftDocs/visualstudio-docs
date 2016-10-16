---
title: "How to: Create a .Vsct File"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "VSCT files, creating"
ms.assetid: b955f51c-f9f9-49c3-a8e4-63b6eb0e0341
caps.latest.revision: 19
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Create a .Vsct File
There are several ways to create an XML-based Visual Studio Command Table configuration (.vsct) file.  
  
-   You can create a new VSPackage in the [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] Package Template.  
  
-   You can use the XML-based command table configuration compiler, Vsct.exe, to generate a file from an existing .ctc file.  
  
-   You can use Vsct.exe to generate a .vsct file from an existing .cto file.  
  
-   You can manually create a new .vsct file.  
  
 This topic explains how to manually create a new .vsct file.  
  
### To manually create a new .vsct file  
  
1.  Start [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)].  
  
2.  On the **File** menu, point to **New**, and then click **File**.  
  
3.  In the **Templates** pane, click **XML File** and then click **Open**.  
  
4.  On the **View** menu, click **Properties Window** to display the properties of the XML file.  
  
5.  In the **Properties** window, click the Browse (…) button on the Schemas property.  
  
6.  In the list of XSD schemas, select the vsct.xsd schema. If it is not in the list, click **Add** and then find the file on a local drive. Click **OK** when you are finished.  
  
7.  In the XML file, type `<CommandTable` and then press TAB. Close the tag by typing `>`.  
  
     This creates a basic .vsct file.  
  
8.  Fill in the elements of the XML file that you want to add, according to the [VSCT Schema](../extensibility/vsct-xml-schema-reference.md). For more information, see [Authoring .Vsct Files](../extensibility/authoring-.vsct-files.md)  
  
## Compiling the Code  
 Simply adding a .vsct file to a project does not cause it to compile. You must incorporate it in the build process.  
  
### To add a .vsct file to project compilation  
  
1.  Open your project file in the editor. If the project is loaded, you must unload it first.  
  
2.  Add an [ItemGroup element](../reference/itemgroup-element--msbuild-.md) that contains a VSCTCompile element, as shown in the following example.  
  
    ```xml  
    <ItemGroup>  
      <VSCTCompile Include="TopLevelMenu.vsct">  
        <ResourceName>Menus.ctmenu</ResourceName>  
      </VSCTCompile>  
    </ItemGroup>  
  
    ```  
  
     The ResourceName element should always be set to `Menus.ctmenu`.  
  
3.  If your project contains a .resx file, add an EmbeddedResource element that contains a MergeWithCTO element, as shown in the following example.  
  
    ```xml  
    <EmbeddedResource Include="VSPackage.resx">  
      <MergeWithCTO>true</MergeWithCTO>  
      <ManifestResourceName>VSPackage</ManifestResourceName>  
    </EmbeddedResource>  
  
    ```  
  
     This markup should go inside the ItemGroup element that contains embedded resources.  
  
4.  Open the package file, usually named *ProjectName*Package.cs or *ProjectName*Package.vb, in the editor.  
  
5.  Add a ProvideMenuResource attribute to the package class, as shown in the following example.  
  
    ```c#  
    [ProvideMenuResource("Menus.ctmenu", 1)]  
    ```  
  
     The first parameter value must match the value of the ResourceName attribute you defined in the project file.  
  
## See Also  
 [Authoring .Vsct Files](../extensibility/authoring-.vsct-files.md)   
 [Visual Studio Command Table (.Vsct) Files](../extensibility/visual-studio-command-table--.vsct--files.md)   
 [How to: Create a .Vsct File from an Existing .Ctc File](../misc/how-to--create-a-.vsct-file-from-an-existing-.ctc-file.md)   
 [How to: Create a .Vsct File from an Existing .Cto File](../misc/how-to--create-a-.vsct-file-from-an-existing-.cto-file.md)   
 [VSCT XML Schema Reference](../extensibility/vsct-xml-schema-reference.md)