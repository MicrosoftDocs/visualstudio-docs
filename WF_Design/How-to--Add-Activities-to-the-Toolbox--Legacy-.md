---
title: "How to: Add Activities to the Toolbox (Legacy)"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: b66ea29c-120b-40ba-8a61-c1c8240850fa
caps.latest.revision: 5
manager: erikre
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
# How to: Add Activities to the Toolbox (Legacy)
When building a workflow solution with the legacy Windows Workflow Designer that targets the .NET Framework version 3.5 or the WinFX, custom activities can be added to the workflow project and their designers placed in the **Toolbox** for easy access. You can also add activities directly to the **Toolbox** from a dynamic-link library (DLL).  
  
### To add an activity to the Toolbox from a DLL  
  
1.  Right-click the Toolbox window surface under **Windows Workflow**, and then click **Choose Items**.  
  
2.  In the **Choose Toolbox Items** dialog box, click the **System.Activities Components** tab, and then click **Browse** from the lower right-hand side of the window.  
  
3.  Select the DLL from the file directory that contains the implementation of the custom activity to add to the **Toolbox**, and then click **Open**.  
  
4.  Click **OK** to finish adding the activity to the Toolbox.  
  
## See Also  
 [Using the Legacy Activity Designer](../WF_Design/Using-the-Legacy-Activity-Designer.md)   
 [Legacy Workflow Activities](../WF_Design/Legacy-Workflow-Activities.md)