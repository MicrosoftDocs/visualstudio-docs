---
title: "Visual Studio Customer Improvement Program"
description: "Find out how to manage privacy settings in Visual Studio."
ms.custom: ""
ms.date: 05/21/2018
ms.prod: visual-studio-dev15
ms.technology: vs-acquisition
ms.prod: visual-studio-dev15
ms.topic: conceptual
ms.assetid: 7dd75839-1807-4137-911d-fabb2c204d8f
author: TerryGLee
ms.author: tglee
manager: douge
ms.workload:
  - "multiple"
---
# Visual Studio Customer Improvement Program

The Visual Studio Experience Improvement Program (VSEIP) is a program designed to help Microsoft improve Visual Studio over time. 
This program collects information about computer hardware and how people use Visual Studio, without interrupting the users in their tasks at the computer. 
The information that is collected helps Microsoft identify which features to improve. This document will cover how to opt in or out of the VSEIP.

## Choice and Control over the Visual Studio Customer Improvement Program  

The VSEIP is turned on by default. You can turn it off, or back on again, by following the instructions below.  

1. Start Visual Studio.
2. From the Help menu, point to **Send Feedback**, and then click **Settings**.
3. To turn off VSEIP, click **No, I would not like to participate**, and then click **OK**.
   To turn on VSEIP, click **Yes, I am willing to participate**, and then click **OK**.  
  
**Manage the VSEIP by using the registry or Group Policy**  

If you install the Visual Studio Build Tools, you must update the registry to configure the VSEIP. Enterprise customers may construct Group Policy to opt in or out of the VSEIP by setting a registry-based policy. 
The relevant registry key and settings are as follows:  
  
 Key = HKEY_CURRENT_USER\Software\Microsoft\VSCommon\15.0\SQM  
 RegEntry name = OptIn  
 Entry type DWORD:  
-   0 is opted out (turn off the VSEIP)  
-   1 is opted in (turn on the VSEIP)  
  
> [!CAUTION]  
>  Incorrectly editing the registry may severely damage your system. Before making changes to the registry, you should back up any valued data on the computer. You can also use the Last Known Good Configuration startup option if you encounter problems after manual changes have been applied.  
  
 For more information about the information collected, processed, or transmitted by the VSEIP, see the [Microsoft Privacy Statement](https://privacy.microsoft.com/privacystatement).  
 
## See also

* [Talk to us](../ide/talk-to-us.md)
* [How to report a problem with Visual Studio](../ide/how-to-report-a-problem-with-visual-studio-2017.md)  
* [Visual Studio Developer Community](https://developercommunity.visualstudio.com/)  
* [European Union General Data Protection Regulation (GDPR)](https://docs.microsoft.com/microsoft-365/compliance/gdpr)  
* [Microsoft Privacy Statement](https://privacy.microsoft.com/privacystatement)  
