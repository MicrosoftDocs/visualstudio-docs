---
title: "Define a custom modeling toolbox item | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "UML - extending, customizing the toolbox"
ms.assetid: a2463606-1100-40ac-97f3-5ba22ca47b7c
caps.latest.revision: 33
author: jillre
ms.author: jillfra
manager: jillfra
---
# Define a custom modeling toolbox item
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

To make it easy to create an element or group of elements according to a pattern that you often use, you can add new tools to the toolbox of modeling diagrams in Visual Studio. You can distribute these toolbox items to other Visual Studio users.

 To see which versions of Visual Studio support this feature, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

 A custom tool creates one or more new elements in a diagram. For example, you could make a custom tool to create elements such as these:

- A package linked to the .NET profile, and a class with the .NET stereotype.

- A pair of classes linked by an association to represent the Observer pattern.

> [!NOTE]
> You can use this method to create element tools. That is, you can create tools that you drag from the toolbox onto a diagram. You cannot create connector tools.

## <a name="DefineTool"></a> Defining a Custom Modeling Tool

#### To define a custom modeling tool

1. Create a UML diagram that contains an element or group of elements.

    - These elements can have relationships between them, and can have subsidiary elements such as ports, attributes, operations or pins.

2. Save the diagram using the name that you want to give the new tool. On the **File** menu, use **Save…As**.

3. Using Windows Explorer, copy the two diagram files to the following folder or any subfolder:

     *YourDocuments* **\Visual Studio\Architecture Tools\Custom Toolbox Items**

    - Create this folder if it does not already exist. You might have to create both **Architecture Tools** and **Custom Toolbox Items**.

    - Copy both diagram files, one with a name that ends "…**diagram**" and the other with a name that ends "…**diagram.layout**"

    - You can make as many custom tools as you like. Use one diagram for each tool.

4. (Optional) Create a **.tbxinfo** file as described in [How to Define the Properties of Custom Tools](#tbxinfo), and add it to the same directory. This allows you to define a toolbox icon, tooltip, and so on.

    - A single **.tbxinfo** file can be used to define several tools. It can refer to diagram files that are in subfolders.

5. Restart Visual Studio. The additional tool will appear in the toolbox for the appropriate type of diagram.

### What the Custom Tool will Replicate
 A custom tool will replicate most of the features of the source diagram:

- Names. When an item is created from the toolbox, a number is added to the end of the name if necessary to avoid duplicate names in the same namespace.

- Colors, sizes and shapes

- Stereotypes and package profiles

- Property values such as Is Abstract

- Linked work items

- Multiplicities and other properties of relationships

- The relative positions of shapes.

  The following features will not be preserved in a custom tool:

- Simple shapes. These are shapes that are not related to model elements, that you can draw on some kinds of diagrams.

- Connector routing. If you route connectors manually, the routing will not be preserved when your tool is used. The positions of some nested shapes, such as Ports, are not preserved relative to their owners.

## <a name="tbxinfo"></a> How to Define the Properties of Custom Tools
 A toolbox information (**.tbxinfo**) file allows you to specify a toolbox name, icon, tooltip, tab, and help keyword for one or more custom tools. Give it any name, such as **MyTools.tbxinfo**.

 The general form of the file is as follows:

```
<?xml version="1.0" encoding="utf-8" ?>
<customToolboxItems xmlns="http://schemas.microsoft.com/visualstudio/[version]/ArchitectureTools/CustomToolboxItems">
  <customToolboxItem fileName="MyObserverTool.classdiagram">
    <displayName>
       <value>Observer Pattern</value>
    </displayName>
    <tabName>
       <value>UML Class Diagram</value>
    </tabName>
    <image><bmp fileName="ObserverPatternIcon.bmp"/></image>
    <f1Keyword>
      <value>ObserverPatternHelp</value>
    </f1Keyword>
    <tooltip>
       <value>Create a pair of classes</value>
    </tooltip>
  </customToolboxItem>
</customToolboxItems>
```

 The value of each item can be either:

- As shown in the example, `<bmp fileName="…"/>` for the toolbox icon and `<value>string</value>` for the other items.

  \- or -

- `<resource fileName="Resources.dll"`

   `baseName="Observer.resources" id="Observer.tabname" />`

   In this case, you supply a compiled assembly in which the string values have been compiled as resources.

  Add a `<customToolboxItem>` node for each toolbox item you want to define.

  The nodes in the **.tbxinfo** file are as follows. There is a default value for each node.

|Node name|Defines|
|---------------|-------------|
|displayName|The name of the toolbox item.|
|tabName|The toolbox tab in which the item should appear. You can specify either the name of the regular tab for this type of diagram, or a separate name.|
|image|The location of the bitmap (**.bmp**) file, which must have height and width of 16, and a color depth of 24 bits.|
|f1Keyword|The keyword that locates a help topic.|
|tooltip|A tooltip for this tool.|

 You can edit the bitmap file in Visual Studio, and set its height and width to 16 in the Properties window.

> [!NOTE]
> If you start to use a .tbxinfo file after experimenting with using diagram files on their own, you might find that the toolbox contains both the old and the new versions of a toolbox item. This can also occur if the name of the diagram file was mistyped in the .tbxinfo file. If this occurs, on the shortcut menu of the toolbox choose **Reset Toolbox**. The custom toolbox items will disappear. Restart Visual Studio, and the correct custom items will appear.

## <a name="Extension"></a> How to Distribute Toolbox Items in a Visual Studio Extension
 You can distribute toolbox items to other [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] users by packaging them into a Visual Studio Extension (VSIX). You can package commands, profiles, and other extensions into the same VSIX file. For more information, see [Deploying Visual Studio Extensions](https://go.microsoft.com/fwlink/?LinkId=160780).

 The usual way to build a Visual Studio extension is to use the VSIX project template. To do this, you must have installed [!INCLUDE[vsipsdk](../includes/vsipsdk-md.md)].

#### To add a Toolbox Item to a Visual Studio extension

1. [Create and test one or more custom tools](#DefineTool).

2. [Create a .tbxinfo file](#tbxinfo) that references the tools.

3. Open an existing Visual Studio extension project.

     \- or -

     Define a new Visual Studio extension project.

    1. On the **File** menu, choose **New**, **Project**.

    2. In the **New Project** dialog box, under **Installed Templates**, choose **Visual C#**, **Extensibility**, **VSIX project**.

4. Add your toolbox definitions to the project. Include the **.tbxinfo** file, the diagram files, bitmap files, and any resource files, and make sure that they are included in the VSIX.

    - In Solution Explorer, on the shortcut menu of the VSIX project, choose **Add**, **Existing Item**. In the dialog box, set **Objects of Type: All Files**. Locate the files, select them all, and then choose **Add**.

        > [!NOTE]
        > In this project, you cannot open the diagram files in the model editor.

5. Set the following properties of all the files that you have just added. You can set their properties at the same time by selecting them all in Solution Explorer. Be careful not to change the properties of the other files in the project.

     **Copy to Output Directory** = **Copy Always**

     **Build Action** = **Content**

     **Include in VSIX** = **true**

6. Open **source.extension.vsixmanifest**. It opens in the extension manifest editor.

7. Under **Metadata**, add a description for the custom tools.

     Under **Assets**, choose **New** and then set the fields in the dialog as follows:

    - **Type** = **Custom Extension Type**

    - Type = `Microsoft.VisualStudio.ArchitectureTools.CustomToolboxItems`

        > [!NOTE]
        > This is not one of the options in the drop-down list. You have to enter it by using the keyboard.

    - **Source** = **File on filesystem**.

    - **Path** = your **.tbxinfo** file, for example **MyTools.tbxinfo**

8. Build the project.

9. **To verify that the extension works**, press F5. The experimental instance of Visual Studio starts.

     In the experimental instance, create or open a UML diagram of the relevant type. Verify that your new tool appears in the toolbox and that it creates elements correctly.

10. **To obtain a VSIX file for deployment:** In Windows Explorer, open the folder **.\bin\Debug** or **.\bin\Release** to find the **.vsix** file. This is a [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] Extension file. It can be installed on your computer, and also sent to other Visual Studio users.

#### To install custom tools from a Visual Studio Extension

1. Open the `.vsix` file in Windows Explorer or in Visual Studio.

2. Choose **Install** in the dialog box that appears.

3. To uninstall or temporarily disable the extension, open **Extensions and Updates** from the **Tools** menu.

## Localization
 You can make an extension that, when it is installed on another computer, will display tool names and tooltips in the language of the target computer.

#### To provide versions of the tool in more than one language

1. Create a Visual Studio Extension project that contains one or more custom tools.

    In the **.tbxinfo** file, use the resource file method to define the tool's `displayName`, toolbox `tabName`, and the tooltip. Create a resource file in which these strings are defined, compile it into an assembly, and refer to it from the tbxinfo file.

2. Create additional assemblies that contain resource files with strings in other languages.

3. Place each additional assembly in a folder whose name is the culture code for the language. For example, place a French version of the assembly inside a folder that is named **fr**.

4. You should use a neutral culture code, typically two letters, not a specific culture such as `fr-CA`. For more information about culture codes, see [CultureInfo.GetCultures method](https://go.microsoft.com/fwlink/?LinkId=160782), which provides a complete list of culture codes.

5. Build the Visual Studio Extension, and distribute it.

6. When the extension is installed on another computer, the version of the resource file for the user's local culture will be automatically loaded. If you have not provided a version for the user's culture, the default resources will be used.

   You cannot use this method to install different versions of the prototype diagram. The names of elements and connectors will be the same in every installation.

## Other Toolbox Operations
 Ordinarily, in [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)], you can personalize the toolbox by renaming tools, moving them to different toolbox tabs, and deleting them. But these changes do not persist for custom modeling tools created with the procedures that are described in this topic. When you restart [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)], custom tools will reappear with their defined names and toolbox locations.

 Furthermore, your custom tools will disappear if you perform the **Reset Toolbox** command. However, they will reappear when you restart [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)].

## See Also
 [Extend UML models and diagrams](../modeling/extend-uml-models-and-diagrams.md)
 [Define a profile to extend UML](../modeling/define-a-profile-to-extend-uml.md)
 [Define a menu command on a modeling diagram](../modeling/define-a-menu-command-on-a-modeling-diagram.md)
 [Define validation constraints for UML models](../modeling/define-validation-constraints-for-uml-models.md)
