---
title: "Property Pages Settings for Web Projects"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugging [Visual Studio], Web applications"
  - "project settings [Visual Studio], debug configurations"
  - "debug builds, project settings"
  - "projects [Visual Studio], debug configurations"
  - "debugging Web applications, project settings"
  - "debug configurations, Web projects"
ms.assetid: 8ec5160a-6408-4f47-8d41-f0e20e79a3b9
caps.latest.revision: 11
ms.author: "mikejo"
manager: "ghogen"
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
# Property Pages Settings for Web Projects
You can change the property settings for a web site debug configuration in the **Property Pages** dialog box, as discussed in [Debug and Release Configurations](../debugger/how-to--set-debug-and-release-configurations.md). The following tables show where to find debugger-related settings in the **Property Pages** dialog box.  
  
### Configuration Properties folder (Start Options category)  
  
|**Setting**|**Description**|  
|-----------------|---------------------|  
|**Start Action**|Heading that groups options related to application startup.|  
|**Use current Page**|Specifies the current page as the starting point for debugging.|  
|**Specific page:**|Specifies the Web page where you want to begin debugging.|  
|**Start external program:**|Specifies the command for launching the program you want to debug.|  
|**Command line arguments:**|Specifies arguments for the command specified above.|  
|**Working directory:**|Specifies the working directory of the program being debugged. In [!INCLUDE[csprcs](../datatools/includes/csprcs_md.md)], the working directory is the directory the application is launched from, \bin\debug by default.|  
|**Start URL**|Specifies the location of the Web application you want to debug.|  
|**Don't open a page. Wait for a request from an external application**|Says to wait for a request from an external application. This option does not launch Internet Explorer or another application. It just prepares for debugging when called by an application.|  
|**Server**|Heading that groups options related to the server to be used.|  
|**Use default Web server**|Says to use the default Web server.|  
|**Use custom server**|Allows you to enter the Base URL to use as the server.|  
|**Debuggers**|Heading that groups options related to type of debugging to be done.|  
|**ASP.NET debugging**|Enables debugging of server pages written for the [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] development platform. You must specify a URL in **Start URL**.|  
|**Native code debugging**|Enables you to debug calls to native (unmanaged) Win32 code from your managed application.|  
|**SQL Server debugging**|Allows debugging of SQL Server database objects.|  
|**Silverlight debugging**|Allows debugging of Silverlight components.|  
  
## See Also  
 [Debugger Settings and Preparation](../debugger/debugger-settings-and-preparation.md)