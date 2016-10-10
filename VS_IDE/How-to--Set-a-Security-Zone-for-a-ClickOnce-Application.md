---
title: "How to: Set a Security Zone for a ClickOnce Application"
ms.custom: na
ms.date: 10/05/2016
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
ms.assetid: d3dac454-518a-44d7-a76e-ccb7b9c3a150
caps.latest.revision: 18
manager: wpickett
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
# How to: Set a Security Zone for a ClickOnce Application
When setting code access security permissions for a ClickOnce application, you need to start with a base set of permissions on the **Security** page of the **Project Designer**.  
  
 In most cases, you can also choose the **Internet** zone which contains a limited set of permissions, or the **Local Intranet** zone which contains a greater set of permissions. If your application requires custom permissions, you can do so by choosing the **Custom** security zone. For more information about setting custom permissions, see [How to: Set Custom Permissions for a ClickOnce Application](../VS_IDE/How-to--Set-Custom-Permissions-for-a-ClickOnce-Application.md).  
  
### To set a security zone  
  
1.  With a project selected in **Solution Explorer**, on the **Project** menu click **Properties**.  
  
2.  Click the **Security** tab.  
  
3.  Select the **Enable ClickOnce Security Settings** check box.  
  
4.  Select the **This is a partial trust application** option button.  
  
     The controls in the **ClickOnce security permissions** section are enabled.  
  
5.  In the **Zone your application will be installed from** drop-down list, select a security zone.  
  
## See Also  
 [How to: Set Custom Permissions for a ClickOnce Application](../VS_IDE/How-to--Set-Custom-Permissions-for-a-ClickOnce-Application.md)   
 [Securing ClickOnce Applications](../VS_IDE/Securing-ClickOnce-Applications.md)   
 [Code Access Security for ClickOnce Applications](../VS_IDE/Code-Access-Security-for-ClickOnce-Applications.md)   
 [Securing ClickOnce Applications](../VS_IDE/Securing-ClickOnce-Applications.md)