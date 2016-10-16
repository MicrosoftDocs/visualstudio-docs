---
title: "Visual Studio Command Table (.Vsct) Files"
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
  - "VSCT files, overview"
  - "Visual Studio command table configuration files (VSCT), overview"
ms.assetid: 1313adb4-add4-4e74-90e2-f4be522f5259
caps.latest.revision: 22
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
# Visual Studio Command Table (.Vsct) Files
A command table configuration file is a text file that describes the set of commands that a VSPackage contains. The [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] command table (VSCT) compiler compiles XML-based configuration files (.vsct files) into binary command table output (.cto) files. The resultant .cto files are the same as those that are created by using the command table (CTC) compiler to compile .ctc configuration files. However, XML-based .vsct files has some advantages, such as an XML editor and XML IntelliSense.  
  
 To learn more about the syntax and semantics of .vsct files, see [Designing XML Command Table (.Vsct) Files](../extensibility/designing-xml-command-table--.vsct--files.md)  
  
## In This Section  
 [Designing XML Command Table (.Vsct) Files](../extensibility/designing-xml-command-table--.vsct--files.md)  
 Describes how to design .vsct files.  
  
 [How to: Create a .Vsct File](../extensibility/how-to--create-a-.vsct-file.md)  
 Compares the methods for creating a .vsct file. Describes the process for manually creating a new .vsct file.  
  
## Related Sections  
 [VSCT XML Schema Reference](../extensibility/vsct-xml-schema-reference.md)  
 Provides details about each section of the command table XML configuration file.  
  
 [Command Table Configuration (.Ctc) Files](assetId:///3413dda1-f372-4669-bcf0-c64d3463842c)  
 Presents an overview of the deprecated .ctc file format.  
  
 [How VSPackages Add User Interface Elements](../extensibility/how-vspackages-add-user-interface-elements.md)  
 Describes the command table format specification.  
  
 [Resources in VSPackages](../extensibility/resources-in-vspackages.md)  
 Describes how to use managed and unmanaged resources in managed VSPackages.  
  
 [Commands, Menus, and Toolbars](../extensibility/commands--menus--and-toolbars.md)  
 Explains how to create a UI that includes menus, toolbars, and command combo boxes.