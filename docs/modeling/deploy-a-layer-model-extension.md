---
title: "Deploy a layer model extension"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "layer diagrams, deploying extensions"
  - "layer models, deploying extensions"
ms.assetid: 00a4675b-d20e-487e-8fd5-be2b1e0ba238
caps.latest.revision: 27
ms.author: "ahomer"
manager: "kamrani"
translation.priority.ht: 
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
# Deploy a layer model extension
Other users of Visual Studio can install layer modeling extensions that you create by using Visual Studio.  
  
## Installing your extension  
 Your extension is compiled to a VSIX file, which you can install on other computers. You can also install it on your development computer, to make the extension available in the main instance of Visual Studio.  
  
#### To install the extension  
  
1.  In the project that contains **source.vsix.manifest**, open **bin\\\*** in File Explorer.  
  
2.  Copy the **\*.vsix** file to the computer on which you want to install the extension.  
  
3.  On the target computer, double-click the *.vsix file in Windows Explorer.  
  
     The VSIX installer opens.  
  
#### To uninstall the extension  
  
1.  In Visual Studio, on the **Tools** menu, click **Extensions and Updates**.  
  
2.  Click the name of the extension and then click **Uninstall**.  
  
## Installing an Extension on a Team Foundation Build Server  
 [!INCLUDE[esprbuild](../codequality/includes/esprbuild_md.md)] servers do not normally have Visual Studio installed, and so you cannot install the VSIX by double-clicking it. The installation of [!INCLUDE[esprbuild](../codequality/includes/esprbuild_md.md)] includes some components that allow a VSIX extension to run, but you must install the extension manually.  
  
#### To install your layer extension on a [!INCLUDE[esprbuild](../codequality/includes/esprbuild_md.md)] Server  
  
1.  Copy the **.vsix** files from your development computer to the [!INCLUDE[esprbuild](../codequality/includes/esprbuild_md.md)] computer.  
  
     Place the VSIX file in one of the following locations:  
  
    -   To install for all users and services:  
  
         %ProgramFiles%\Microsoft Visual Studio [version]\Common7\IDE\Extensions\Microsoft  
  
    -   To install only for the network service that runs [!INCLUDE[esprbuild](../codequality/includes/esprbuild_md.md)]:  
  
         %WinDir%\ServiceProfiles\NetworkService\AppData\Local\Microsoft\VisualStudio\\[version]\Extensions\Microsoft  
  
    -   If you have configured [!INCLUDE[esprbuild](../codequality/includes/esprbuild_md.md)] to run in interactive mode as a particular user, you can install just for that user:  
  
         %LocalAppData%\Microsoft\VisualStudio\\[version]\Extensions\Microsoft  
  
        > [!NOTE]
        >  %LocalAppData% is typically *DriveName*:Users*UserName*AppDataLocal.  
  
2.  Expand each VSIX file into a folder in the same location:  
  
    1.  Change the file name extension from **.vsix** to **.zip**.  
  
    2.  Extract the content of the .zip file to a folder.  
  
    3.  Delete the .zip file  
  
3.  Restart [!INCLUDE[esprbuild](../codequality/includes/esprbuild_md.md)].