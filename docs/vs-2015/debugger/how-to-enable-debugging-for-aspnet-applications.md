---
title: "How to: Enable Debugging for ASP.NET Applications | Microsoft Docs"
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
  - "debugging ASP.NET Web applications"
  - "Web.config configuration file, debug mode"
  - "debugging [Visual Studio], ASP.NET"
ms.assetid: 3beed819-cece-4864-8184-bd410000973a
caps.latest.revision: 40
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Enable Debugging for ASP.NET Applications
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

To enable debugging, you must enable it in both the **Project Properties** page and in the application's web.config file.  
  
> [!NOTE]  
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/library/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
### To enable ASP.NET debugging in the project properties (Visual Basic/C#)  
  
1. In **Solution Explorer**, right-click the name of a Web project and select **Properties**.  
  
2. In the project properties page click the **Web** tab.  
  
3. Under **Debuggers**, select the **ASP.NET** check box.  
  
### To enable debugging in the web.config file  
  
1. Open the web.config file by using any standard text editor or XML parser.  
  
    > [!NOTE]  
    > You cannot access the file remotely by using a Web browser, however. For security reasons, [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] configures Microsoft IIS to help prevent direct browser access to Web.config files. If you try to access a configuration file by using a browser, you will get HTTP access error 403 (forbidden).  
  
2. Web.config is an XML file, and so contains nested sections marked by tags. Locate the `configuration/system.web/compilation` element. If the compilation element does not exist, create it.  
  
3. If the `compilation` element does not contain a `debug` attribute, add the attribute to the element.  
  
4. Make sure the `debug` attribute value is set to `true`.  
  
The web.config file should look like the following example. Note that there can be sections between the configuration and system.web elements  
  
- element sections between the configuration and system.web elements  
  
- element sections between the system.web and compilation elements  
  
- The compilation element can contain other attributes and elements  
  
## Example  
  
```  
<configuration>  
    ...  
    <system.web>  
        <compilation  
            debug="true"  
            ...  
        >  
        ...  
        </compilation>  
    </system.web>  
</configuration>  
```  
  
## Robust Programming  
[!INCLUDE[vstecasp](../includes/vstecasp-md.md)] automatically detects any changes to Web.config files and applies the new configuration settings. You do not have to restart the computer or restart the IIS server for changes to take effect.  
  
A Web site can contain multiple virtual directories and subdirectories, and Web.config files may exist in each one. [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] applications inherit settings from Web.config files at higher levels in the URL path. Hierarchical configuration files allow you to change settings for several [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] applications at the same time, such as for all applications below it in the hierarchy. However, if `debug` is set in a file lower in the hierarchy, it will override the higher value.  
  
For example, you could specify `debug="true"` in www.microsoft.com/aaa/Web.config, and any application in the aaa folder or in any subfolder of aaa will inherit that setting. So if your [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] application is at www.microsoft.com/aaa/bbb, it will inherit that setting, as will any [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] applications in www.microsoft.com/aaa/ccc, www.microsoft.com/aaa/ddd, and so on. The only exception is if one of those applications overrides the setting by means of its own lower Web.config file.  
  
Enabling debug mode will greatly affect the performance of your [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] application. Remember to disable debug mode before you deploy a release application or conduct performance measurements.  
  
## See Also  
[Debugging ASP.NET and AJAX Applications](../debugger/debugging-aspnet-and-ajax-applications.md)  
