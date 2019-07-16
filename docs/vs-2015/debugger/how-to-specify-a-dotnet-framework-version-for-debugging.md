---
title: "How to: Specify a .NET Framework Version For Debugging | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - ".NET Framework, specifying version for debugging"
  - "debugging [Visual Studio], specifying .NET Framework version"
ms.assetid: 7a4893ba-4620-4774-893f-378d4ca28893
caps.latest.revision: 12
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Specify a .NET Framework Version For Debugging
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The [!INCLUDE[vs_dev11_long](../includes/vs-dev11-long-md.md)] debugger supports debugging older versions of the Microsoft [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] as well as the current version. If you start an application from Visual Studio, the debugger can always identify the correct version of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] for the application you are debugging. If the application is already running and you use **Attach to**, the debugger may not always be able to identify an older version of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)]. If this happens, you will get an error message that says,  
  
 The debugger has made an incorrect assumption about the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] version your application is going to use.  
  
 In these rare cases, you can set a registry key to indicate to the debugger which version to use.  
  
### To specify a .NET Framework version for debugging  
  
1. Look in the directory Windows\Microsoft.NET\Framework to find the versions of the .NET Framework installed on your machine. The version numbers look something like this:  
  
     `V1.1.4322`  
  
     Identify the correct version number and make a note of it.  
  
2. Start the **Registry Editor** (regedit).  
  
3. In the **Registry Editor**, open the HKEY_LOCAL_MACHINE folder.  
  
4. Navigate to: HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\10.0\AD7Metrics\Engine\\{449EC4CC-30D2-4032-9256-EE18EB41B62B}  
  
     If the key does not exist, right-click HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\10.0\AD7Metrics\Engine, and click **New Key**. Name the new key `{449EC4CC-30D2-4032-9256-EE18EB41B62B}`.  
  
5. After navigating to {449EC4CC-30D2-4032-9256-EE18EB41B62B}, look in the **Name** column, and find the CLRVersionForDebugging key.  
  
    1. If the key does not exist, right-click {449EC4CC-30D2-4032-9256-EE18EB41B62B}, and click **New String Value**. Then right-click the new string value, click **Rename**, and type `CLRVersionForDebugging`.  
  
6. Double-click **CLRVersionForDebugging**.  
  
7. In the **Edit String** box, type the .NET Framework version number in the **Value** box. For example: V1.1.4322  
  
8. Click **OK**.  
  
9. Close the **Registry Editor**.  
  
     If you still get an error message when you start to debug, verify that you have entered the version number correctly in the registry. Also verify that you are using a version of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] supported by Visual Studio. The debugger is compatible with the current .NET Framework version and previous versions, but may not be forward compatible with future versions.  
  
## See Also  
 [Debugger Settings and Preparation](../debugger/debugger-settings-and-preparation.md)
