---
title: "Using Modules to Include Files in the Solution | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "SharePoint development in Visual Studio, deployment modules"
  - "SharePoint development in Visual Studio, modules"
  - "modules [SharePoint development in Visual Studio]"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Using Modules to Include Files in the Solution
  There may be times when you may want to deploy files to the SharePoint server regardless of their file type, such as new master pages. To do this, you can use *Modules* (not to be confused with [!INCLUDE[vbprvb](../sharepoint/includes/vbprvb-md.md)] code modules). Modules are containers for files in a SharePoint solution. When the solution is deployed, the files in the module are copied to the specified folders on the SharePoint server.  
  
## Module Items and Elements  
 To create a module, add it to a project by choosing it in the **Add New Item** dialog box. Then, modify its Elements.xml file to include the names of the files you want to deploy, where they are located on the system, and where they should be copied on the SharePoint server.  
  
 Here is an example of the Elements.xml file for a module:  
  
```  
<?xml version="1.0" encoding="utf-8"?>  
<Elements xmlns="http://schemas.microsoft.com/sharepoint/">  
    <Module Name="Module1">  
        <File Path="Module1\Sample.txt" Url="Module1/Sample.txt" />  
    </Module>  
</Elements>  
  
```  
  
 Newly-created modules contain the following default files:  
  
|File Name|Description|  
|---------------|-----------------|  
|Elements.xml|The definition file for the module.|  
|Sample.txt|A placeholder file that serves as an example of a file in the module.|  
  
 The Elements.xml file contains the following elements:  
  
|Element Name|Description|  
|------------------|-----------------|  
|Elements|Contains all of the elements defined in the module.|  
|Module|The module element has a single attribute, *Name*, that specifies the name of the module in the format `<Module Name="Module1">`.<br /><br /> Note that if you change the name of the module (or its *Folder Name* property), you must manually update the name in the Module element.<br /><br /> If you specify a subdirectory for the file(s) in the Module element, [!INCLUDE[sharepointShort](../sharepoint/includes/sharepointshort-md.md)] (WSS) will automatically create a matching directory structure for them.|  
|File|The File element has two parameters, *Path* and *Url*.<br /><br /> - Path: The name and location of the file in the SharePoint solution. The format is, `Path="Module1\Sample.txt"`.<br /><br /> - Url: The location where the file will be deployed on the SharePoint server. The format is, `Url="Module1/Sample.txt"`.<br /><br /> - Type: An optional attribute that has two settings: *GhostableInLibrary* and *Ghostable*. The format is, `Type="GhostableInLibrary"`. Specifying *GhostableInLibrary* means the file will be added to a document library in SharePoint together with a list item to accompany the file when it is added to the library. Specifying *Ghostable* causes the file to be added to SharePoint outside the document library.|  
  
 Each file that you want to deploy requires a separate `<File>` element entry in Elements.xml.  
  
## See Also  
 [How to: Include Files by Using a Module](../sharepoint/how-to-include-files-by-using-a-module.md)   
 [how to: provision a file](http://go.microsoft.com/fwlink/?LinkID=144271)   
 [Developing SharePoint Solutions](../sharepoint/developing-sharepoint-solutions.md)   
 [Creating Web Parts for SharePoint](../sharepoint/creating-web-parts-for-sharepoint.md)   
 [Packaging and Deploying SharePoint Solutions](../sharepoint/packaging-and-deploying-sharepoint-solutions.md)  
  
  