---
title: "Property Pages, JavaScript | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "javascript.project.property.debugging.debuggertype"
  - "javascript.project.property.debugging.requireauthentication"
  - "javascript.project.property.outputpath"
  - "javascript.project.property.debugging.launchapplication"
  - "javascript.project.property.defaultlanguage"
  - "javascript.project.property.debugging.machinename"
  - "javascript.project.property.debugging.allowlocalnetworkloopback"
ms.assetid: a05ab01f-3d5d-4675-a845-eab51807d3a3
caps.latest.revision: 17
author: "kempb"
ms.author: "kempb"
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
# Property Pages, JavaScript
The **Property Pages**provides access to project settings. You can use the pages that appear in the **Property Pages** to change project properties.  
  
 To access the project properties, select a project node in **Solution Explorer**. On the **Project** menu, click **Properties**.  
  
 [!INCLUDE[note_settings_general](../../data-tools/includes/note_settings_general_md.md)]  
  
 The following pages and options appear in the **Property Pages**.  
  
## Configuration and Platform Page  
 Use the following options to select the configuration and platform to display or modify.  
  
 **Configuration**  
 Specifies the configuration settings to display or modify. The settings are **Debug** (default), **Release**, **All Configurations**, or a user-defined configuration. For more information, see [Debug and Release Project Configurations](http://msdn.microsoft.com/en-us/0440b300-0614-4511-901a-105b771b236e).  
  
 **Platform**  
 Specifies the platform settings to display or modify. The settings are **Any CPU** (default for [!INCLUDE[win8_appname_long](../../debugger/includes/win8_appname_long_md.md)] apps), **x64**, **ARM**, **x86**, or a user-defined platform. For more information, see [Debug and Release Project Configurations](http://msdn.microsoft.com/en-us/0440b300-0614-4511-901a-105b771b236e).  
  
## General Page  
 Use the following options to set general properties of the project.  
  
> [!NOTE]
>  Some options are only available in Windows Store apps.  
  
 **Output Path**  
 Specifies the location of the output files for the project's configuration. The path is relative; if you enter an absolute path, the absolute path is saved in the project. The default path is bin\Debug.  
  
 When you use simplified build configurations, the project system determines whether to build a debug or release version. When you click  **Debug**, **Start Debugging** (or press F5)  the build is put in the debug location regardless of the **Output path** you specify. However, the **Build Solution** command on the **Build** menu puts it in the location you specify. To enable advanced build configurations, on the menu bar, choose **Tools**, **Options**. In the **Options** dialog box, expand **Projects and Solutions**, select **General**, and then clear the **Show advanced build configurations** check box. This gives you manual control over all configuration values and whether a debug or release version is built. For more information, see [NIB: General, Projects and Solutions, Options Dialog Box](http://msdn.microsoft.com/en-us/8f8e37e8-b28d-4b13-bfeb-ea4d3312aeca).  
  
 **Default Language**  
 Specifies the default language for the project. The language option selected in **Clock, Language, and Region** in Control Panel specifies the user's preferred language. By specifying a default language for the project, you make sure that the specified default language resources are used if the user’s preferred language does not match the language resources provided in the application.  
  
## Debug Page  
 Use the following options to set properties for debugging behavior in the project.  
  
> [!NOTE]
>  Some options are only available in Windows Store apps.  
  
 **Debugger to Launch**  
 Specifies the default host for the debugger.  
  
-   Select **Local Machine** to start the application on the Visual Studio host computer. For more information, see [Running apps on the local machine](http://go.microsoft.com/fwlink/?LinkId=234912).  
  
-   Select **Simulator** to start the application in the Simulator. For more information, see [Running apps in the simulator](http://go.microsoft.com/fwlink/?LinkId=234913).  
  
-   Select **Remote Machine** to start the application on a remote computer. For more information about remote debugging, see [Running apps on a remote machine](http://go.microsoft.com/fwlink/?LinkId=234914).  
  
 **Launch Application**  
 Specifies whether to start the application when you press F5 or click **Debug**, **Start Debugging**. Select **Yes** to start the application; otherwise, select **No**. If you select **No**, you can still debug the application if you use a different method to start it.  
  
 **Debugger Type**  
 Specifies the types of code to debug. Select **Script Only** to debug JavaScript code. Select **Managed Only** to debug code that is managed by the common language runtime. Select **Native Only** to debug C++ code. Select **Native with Script** to debug C++ and JavaScript. Select **Mixed (Managed and Native)** to debug both managed and C++ code.  
  
 **Allow Local Network Loopback**  
 Specifies whether access to the IP loopback address is allowed for app testing. Select **Yes** to allow use of the loopback address if the client app is on the same machine where the server application is running; otherwise, select **No**. This property is available only if the **Debugger to Launch** property is set to **Remote Machine**.  
  
 **Machine Name**  
 Specifies the name of the remote computer to host the debugger. This property is available only if **Debugger to Launch** is set to **Remote Machine**.  
  
 **Require Authentication**  
 Specifies whether the remote computer requires authentication. This property is available only if **Debugger to Launch** is set to **Remote Machine**.