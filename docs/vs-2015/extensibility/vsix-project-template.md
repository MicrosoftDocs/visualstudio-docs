---
title: "VSIX Project Template | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "deploy packages"
  - "publish extension"
ms.assetid: b6c82167-e2a5-4cff-8c8b-2d72e2a9092c
caps.latest.revision: 22
ms.author: gregvanl
manager: jillfra
---
# VSIX Project Template
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can use the VSIX Project template to wrap one or more Visual Studio extensions in a VSIX project, and then publish the package on the [Visual Studio Marketplace](https://marketplace.visualstudio.com/) Web site.  
  
 VSIX deployment supports VSPackages, assemblies, MEF components, project templates, item templates, toolbox controls, and custom extension types.  
  
> [!NOTE]
> To use VSIX projects, you must install the Visual Studio SDK. For more information about the Visual Studio SDK, see [Visual Studio SDK](../extensibility/visual-studio-sdk.md).  
  
## Where to Find the VSIX Project Template  
 The VSIX Project template is available in the **New Project** dialog box. Expand either the **Visual Basic** node or the **Visual C#** node, and then choose **Extensibility**.  
  
> [!TIP]
> You should make sure that .NET Framework 4.5 or higher is specified in the dropdown at the top of the **New Project** dialog box.  
  
## Uses of the VSIX Project Template  
 The VSIX project template has two main uses:  
  
- To deploy project templates, item templates, and other extensions that do not already have VSIX support.  
  
- To wrap the outputs of multiple extensions into one deployment package.  
  
  You do not have to use the VSIX Project template to deploy VSPackages or other kinds of extensions that already have VSIX support.  
  
## Packaging an Extension in an Empty VSIX Project  
 You can package an existing extension, or an extension that does not already have VSIX support, by wrapping it in an empty VSIX project. The extension to be wrapped must be of a type that is supported by the [VSIX schema](../extensibility/vsix-extension-schema-2-0-reference.md).  
  
#### To package an extension by using a VSIX project  
  
1. Build the projects that make up your extension.  
  
2. Create a VSIX project by using the **VSIX Project** template.  
  
     Source.extension.vsixmanifest opens in **Manifest Designer**.  
  
3. On the **Assets** tab, choose the **New** button.  
  
     The **Add New Asset** dialog box appears.  
  
4. In the **Type** list, choose the type of extension to add.  
  
5. To add an extension or content element that's included in the current solution (for example, an item template or a compiled assembly), perform the following steps:  
  
    1. In the **Source** list, choose **A project in current solution**.  
  
    2. In the **Project** list, choose the name of the extension.  
  
    3. In the **Embed in this folder** box, enter the name of a folder in which to embed the asset, and then choose the **OK** button.  
  
6. To add an extension or content element that isn't included in the current solution, perform the following steps:  
  
    1. In the **Source** list box, choose **File on filesystem**.  
  
    2. In the **Path** field, enter the full path to the compiled or compressed extension file, or use the **Browse** button to browse to the file.  
  
    3. In the **Embed in this folder** box, enter the name of a folder in which to embed the asset, and then choose the **OK** button.  
  
7. If you want your package to include additional extensions, add them in the same manner.  
  
8. Build the solution.  
  
     [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] builds a .vsix file that contains a VSIX manifest file, a [Content_Types].xml file, and all of the extension assets that you added to the project.  
  
## See also  
 [VSIX Extension Schema 2.0 Reference](../extensibility/vsix-extension-schema-2-0-reference.md)   
 [Finding and Using Visual Studio Extensions](../ide/finding-and-using-visual-studio-extensions.md)
