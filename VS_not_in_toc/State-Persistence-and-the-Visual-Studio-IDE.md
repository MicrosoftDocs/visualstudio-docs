---
title: "State Persistence and the Visual Studio IDE"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: fdd49bb1-ed3b-4428-b685-de65c3215c1c
caps.latest.revision: 24
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# State Persistence and the Visual Studio IDE
The **Import/Export Settings** command on the **Tools** menu of the integrated development environment (IDE) imports and exports customizations of the Visual Studio environment. The Visual Studio settings APIs in the Visual Studio SDK enable a VSPackage to define one or more settings categories (groups of state variables) to be persisted when a user chooses the **Import/Export Settings** command.  
  
 A GUID uniquely identifies each settings category and is defined in its own registry entry, referred to as a *Custom Settings Point*.  
  
> [!NOTE]
>  The standard implementations of the **ToolsOptions** pages, the **Toolbox**, and the `Microsoft.VisualStudio.Shell.DialogPage` automatically provide support for persistence. The settings API can override the default mechanism. For more information, see [Extending the Toolbox](../VS_not_in_toc/Extending-the-Toolbox.md), [Options Pages](../VS_not_in_toc/Options-Pages.md), and <xref:Microsoft.VisualStudio.Shell.DialogPage?qualifyHint=False>.  
  
## In This Section  
 [Support for User Settings](../Topic/Support%20for%20User%20Settings.md)  
 Describes the registry settings (Custom Settings Point) and attributes used to specify a Visual Studio settings implementation used by a given VSPackage.  
  
 [How to: Export Settings By Using Interop Assemblies](../VS_not_in_toc/How-to--Export-Settings-By-Using-Interop-Assemblies.md)  
 Provides a detailed description of how to implement support for saving configuration data by using the Visual Studio settings mechanism for interop assembly based VSPackages.  
  
 [How to: Use Interop Assemblies to Import Settings](../VS_not_in_toc/How-to--Use-Interop-Assemblies-to-Import-Settings.md)  
 Provides a detailed description of how to implement support for retrieving configuration data by using the Visual Studio settings mechanism for interop assembly based VSPackages.  
  
 [Exporting Settings](../VS_not_in_toc/Exporting-Settings.md)  
 Includes a detailed description of how to implement support for saving configuration data by using the Visual Studio settings mechanism for Managed Package Framework based VSPackages.  
  
 [Importing Settings](../VS_not_in_toc/Importing-Settings.md)  
 Provides a detailed description of how to implement support for retrieving configuration data by using the Visual Studio settings mechanism for Managed Package Framework based VSPackages.  
  
## Related Sections  
 [Working with Settings](assetId:///4c0a56ab-6091-4ebc-9dc7-52c40846bacb)  
 Describes how to manage the export/import sections of the IDE.  
  
 [Options Pages](../VS_not_in_toc/Options-Pages.md)  
 Describes the support that the Visual Studio SDK automatically provides for managing existing or creating new **Tools Options** pages.  
  
 [Extending the Toolbox](../VS_not_in_toc/Extending-the-Toolbox.md)  
 Explains the support that the Visual Studio SDK automatically provides for managing or extending the **Toolbox**.  
  
 [Extending User Settings and Options](../Topic/Extending%20User%20Settings%20and%20Options.md)  
 Describes how to program your VSPackage to obtain and preserve user preferences.