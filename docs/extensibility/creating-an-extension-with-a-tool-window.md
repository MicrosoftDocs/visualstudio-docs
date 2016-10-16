---
title: "Creating an Extension with a Tool Window"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 585b0a3a-f85b-4f92-81bb-9ca499bb8a89
caps.latest.revision: 5
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
# Creating an Extension with a Tool Window
In this procedure, you learn how to use the VSIX project template and the **Custom Tool Window** item template to create an extension with a tool window.  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../extensibility/installing-the-visual-studio-sdk.md).  
  
### Creating a Tool Window  
  
1.  Create a VSIX project named **FirstWindow**. You can find the VSIX project template in the **New Project** dialog under **Visual C# / Extensibility**.  
  
2.  When the project opens, add a tool window item template named **FirstWindow**. In the **Solution Explorer**, right-click the project node and select **Add / New Item**. In the **Add New Item** dialog, go to **Visual C# / Extensibility** and select **Custom Tool Window**. In the **Name** field at the bottom of the window, change the tool window file name to **FirstWindow.cs**.  
  
3.  Build the project and start debugging.  
  
     The experimental instance of Visual Studio appears. For more information about the experimental instance, see [The Experimental Instance](../extensibility/the-experimental-instance.md).  
  
4.  In the experimental instance, go to **View / Other Windows**.  
  
     You should see a menu item for **FirstWindow**. Click it.  
  
     You should see a tool window with the title **FirstWindow** and a button saying **Click Me!.**