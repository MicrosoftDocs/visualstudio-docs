---
title: "Deploying a Custom Directive Processor | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "text templates, custom directive processors"
ms.assetid: 80c28722-a630-47b5-923b-024dc3f2c940
caps.latest.revision: 20
author: jillre
ms.author: jillfra
manager: jillfra
---
# Deploying a Custom Directive Processor
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

To use a custom directive processor in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] on any computer, you must register it by one of the methods described in this topic.

 The alternative methods are:

- [Visual Studio Extension (VSIX)](https://msdn.microsoft.com/64ff1452-f7d5-42d9-98b8-76f769f76832). This provides a way to install and uninstall the directive processor both on your own computer and on other computers. Typically, you might package other features in the same VSIX.

- [VSPackage](../extensibility/internals/vspackages.md). If you are defining a VSPackage that contains other features in addition to the directive processor, there is a convenient method of registering the directive processor.

- Set a registry key. In this method, you add a registry entry for the directive processor.

  You need to use one of these methods only if you want to transform your text template in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] or [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)]. If you use a custom host in your own application, your custom host is responsible for finding the directive processors for each directive.

## Deploying a Directive Processor in a VSIX
 You can add a custom directive processor to a [Visual Studio Extension (VSIX)](https://msdn.microsoft.com/64ff1452-f7d5-42d9-98b8-76f769f76832).

 You need to make sure that the following two items are contained in the .vsix file:

- The assembly (.dll) that contains the custom directive processor class.

- A .pkgdef file that registers the directive processor. The root name of the file must be the same as the assembly. For example, your files could be named CDP.dll and CDP.pkgdef.

  To inspect or change the content of a .vsix file, change its file name extension to .zip and then open it. After editing the contents, change the filename back to .vsix.

  There are several ways of creating a .vsix file. The following procedure describes one method.

#### To develop a custom directive processor in a VSIX project

1. Create a VSIX project in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].

    - In the **New Project** dialog box, expand **Visual Basic** or **Visual C#**, then expand **Extensibility**. Click **VSIX Project**.

2. In **source.extension.vsixmanifest**, set the content type and supported editions.

    1. In the VSIX manifest editor, on the **Assets** tab, choose **New** and set the new item’s properties:

         **Content Type** = **VSPackage**

         **Source Project** = \<*the current project*>

    2. Click **Selected Editions** and check the types of installation on which you want the directive processor to be usable.

3. Add a .pkgdef file and set its properties to be included in the VSIX.

    1. Create a text file and name it \<*assemblyName*>.pkgdef.

         \<*assemblyName*> is usually the same as the name of the project.

    2. Select it in Solution Explorer and set its properties as follows:

         **Build Action** = **Content**

         **Copy to Output Directory** = **Copy Always**

         **Include in VSIX** = **True**

    3. Set the name of the VSIX and make sure that the ID is unique.

4. Add the following text to the .pkgdef file.

    ```
    [$RootKey$\TextTemplating]
    [$RootKey$\TextTemplating\DirectiveProcessors]
    [$RootKey$\TextTemplating\DirectiveProcessors\ CustomDirectiveProcessorName]
    @="Custom Directive Processor description"
    "Class"="NamespaceName.ClassName"
    "CodeBase"="$PackageFolder$\AssemblyName.dll"
    ```

     Replace the following names with your own names: `CustomDirectiveProcessorName`, `NamespaceName`, `ClassName`, `AssemblyName`.

5. Add the following references to the project:

    - **Microsoft.VisualStudio.TextTemplating.\*.0**

    - **Microsoft.VisualStudio.TextTemplating.Interfaces.\*.0**

    - **Microsoft.VisualStudio.TextTemplating.VSHost.\*.0**

6. Add your custom directive processor class to the project.

     This is a public class that should implement <xref:Microsoft.VisualStudio.TextTemplating.DirectiveProcessor> or <xref:Microsoft.VisualStudio.TextTemplating.RequiresProvidesDirectiveProcessor>.

#### To install the Custom Directive Processor

1. In Windows Explorer (File Explorer in Windows 8), open the build directory (usually bin\Debug or bin\Release).

2. If you want to install the directive processor on another computer, copy the .vsix file to the other computer.

3. Double-click the .vsix file. The [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Extension Installer appears.

4. Restart [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. You will now be able to run text templates that contain directives that refer to the custom directive processor. Each directive is of this form:

     `<#@ CustomDirective Processor="CustomDirectiveProcessorName" parameter1="value1" … #>`

#### To uninstall or temporarily disable the custom directive processor

1. In the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] **Tools** menu, click **Extension Manager**.

2. Select the VSIX that contains the directive processor, and then click **Uninstall** or **Disable**.

### Troubleshooting a Directive Processor in a VSIX
 If the directive processor does not work, the following suggestions might help:

- The Processor name that you specify in the custom directive should match the `CustomDirectiveProcessorName` that you specified in the .pkgdef file.

- Your `IsDirectiveSupported` method must return `true` when it is passed the name of your `CustomDirective`.

- If you cannot see the extension in Extension Manager, but the system will not allow you to install it, delete the extension from **%localappdata%\Microsoft\VisualStudio\\\*.0\Extensions\\**.

- Open the .vsix file and inspect its contents. To open it, change the filename extension to .zip. Verify that it contains the .dll, .pkgdef, and extension.vsixmanifest files. The extension.vsixmanifest file should contain the appropriate list in the SupportedProducts node, and should also contain a VsPackage node under the Content node:

     `<Content>`

     `<VsPackage>CustomDirectiveProcessor.dll</VsPackage>`

     `</Content>`

## Deploying a Directive Processor in a VSPackage
 If your directive processor is part of a VSPackage that will be installed in the GAC, you can have the system generate the .pkgdef file for you.

 Place the following attribute on your package class:

```
[ProvideDirectiveProcessor(typeof(DirectiveProcessorClass), "DirectiveProcessorName", "Directive processor description.")]
```

> [!NOTE]
> This attribute is placed on the package class, not the directive processor class.

 The .pkgdef file will be generated when you build the project. When you install the VSPackage, the .pkgdef file will register the directive processor.

 Verify that the .pkgdef file appears in the build folder, which is usually bin\Debug or bin\Release. If it does not appear, open the .csproj file in a text editor, and remove the following node: `<GeneratePkgDefFile>false</GeneratePkgDefFile>`.

 For more information, see [VSPackages](../extensibility/internals/vspackages.md).

## Setting a Registry Key
 This method of installing a custom directive processor is the least preferred. It does not provide a convenient way enable and disable the directive processor, and does not provide a method of distributing the directive processor to other users.

> [!CAUTION]
> Incorrectly editing the registry can severely damage your system. Before making changes to the registry, be sure to back up any valued data on the computer.

#### To register a directive processor by setting a registry key

1. Run `regedit`.

2. In regedit, navigate to

    **HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\\\*.0\TextTemplating\DirectiveProcessors**

    If you want to install the directive processor in the experimental version of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], insert "Exp" after "11.0".

3. Add a registry key that has the same name as the directive processor class.

   - In the registry tree, right-click the **DirectiveProcessors** node, point to **New**, and then click **Key**.

4. In the new node, add string values for Class and CodeBase or Assembly, according to the following tables.

   1. Right-click the node that you created, point to **New**, and then click **String Value**.

   2. Edit the name of the value.

   3. Double-click the name and edit the data.

   If the custom directive processor is not in the GAC, the registry subkeys should look like the following table:

|Name|Type|Data|
|----------|----------|----------|
|(Default)|REG_SZ|(value not set)|
|Class|REG_SZ|**\<Namespace Name>.\<Class Name>**|
|CodeBase|REG_SZ|**\<Your Path>\\<Your Assembly Name\>**|

 If the assembly is in the GAC, the registry subkeys should look like the following table:

|Name|Type|Data|
|----------|----------|----------|
|(Default)|REG_SZ|(value not set)|
|Class|REG_SZ|\<**Your Fully Qualified Class Name**>|
|Assembly|REG_SZ|\<**Your Assembly Name in the GAC**>|

## See Also
 [Creating Custom T4 Text Template Directive Processors](../modeling/creating-custom-t4-text-template-directive-processors.md)
