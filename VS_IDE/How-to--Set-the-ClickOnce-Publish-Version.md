---
title: "How to: Set the ClickOnce Publish Version"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-deployment
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 06f15504-6385-40a6-b01d-cd90ca36dc73
caps.latest.revision: 9
manager: wpickett
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# How to: Set the ClickOnce Publish Version
The ClickOnce `Publish Version` property determines whether or not the application that you are publishing will be treated as an update. Each time version is incremented, the application will be published as an update.  
  
 The `Publish Version` property can be set on the **Publish** page of the **Project Designer**.  
  
> [!NOTE]
>  There is a project option that will automatically increment the `Publish Version` property each time the application is published; this option is enabled by default. For more information, see [How to: Automatically Increment the ClickOnce Publish Version](../VS_IDE/How-to--Automatically-Increment-the-ClickOnce-Publish-Version.md).  
  
### To change the Publish Version  
  
1.  With a project selected in **Solution Explorer**, on the **Project** menu click **Properties**.  
  
2.  Click the **Publish** tab.  
  
3.  In **Publish Version** field, increment the **Major**, **Minor**, **Build**, or **Revision** version numbers.  
  
    > [!NOTE]
    >  You should never decrement a version number; doing so could cause unpredictable update behavior.  
  
## See Also  
 [Choosing a ClickOnce Update Strategy](../VS_IDE/Choosing-a-ClickOnce-Update-Strategy.md)   
 [How to: Automatically Increment the ClickOnce Publish Version](../VS_IDE/How-to--Automatically-Increment-the-ClickOnce-Publish-Version.md)   
 [Publishing ClickOnce Applications](../VS_IDE/Publishing-ClickOnce-Applications.md)   
 [How to: Publish a ClickOnce Application using the Publish Wizard](../VS_IDE/How-to--Publish-a-ClickOnce-Application-using-the-Publish-Wizard.md)