---
title: "Walkthrough: Creating a Custom Editor | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "editors [Visual Studio SDK], custom - create"
ms.assetid: d090abb6-d99f-4083-a3db-cd16bf81ce7d
caps.latest.revision: 17
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
# Walkthrough: Creating a Custom Editor
The VSPackage project template can create a simple custom editor in C++.  The VSPackage project template no longer supports C# or Visual Basic projects. For more information, see [Visual Studio SDK](../extensibility/visual-studio-sdk.md).  
  
## Prerequisites  
 To follow this walkthrough, you must install the Visual Studio SDK. For more information, see [Installing the Visual Studio SDK](../extensibility/installing-the-visual-studio-sdk.md).  
  
## The Visual Studio Package Project Template  
 The Visual Studio Package project template can be found in the **New Project** dialog in the C++ Extensibility folder  
  
### To create a VSPackage using the Visual Studio Package template  
  
1.  Create a project with the Visual Studio Package template.  
  
2.  Select the **Custom Editor** option and click **Next**. The **Editor Options** page is displayed.  
  
3.  Type the name of your editor in the **Editor Name** box. Type the file extension that you want to be associated with your editor in the **File Extension** box. Your editor is available for files with this extension. The file extension is registered for Visual Studio only, not for Windows. Type the default file name for new documents created with your editor in the **Default File Name** box.  
  
4.  Click **Finish** to create your VSPackage in the folder that you specified.  
  
### To test your custom editor  
  
1.  On the **File** menu, point to **New** and then click **File**.  
  
2.  In the **Installed Templates** pane of the **New File** dialog box, select the file template, then the file type you just registered.  
  
3.  Click **Open** to view and edit the document.  
  
     The editor supports cut-and-paste, find-and-replace, and open-and-load operations.  
  
## See Also  
 [VSPackages](../extensibility/internals/vspackages.md)