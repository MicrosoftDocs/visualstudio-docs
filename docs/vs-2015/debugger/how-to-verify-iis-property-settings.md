---
title: "How to: Verify IIS Property Settings | Microsoft Docs"
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
  - "IIS, property settings"
  - "debugging Web applications, troubleshooting"
  - "IIS administration tool"
  - "Web applications, setting properties"
  - "properties [debugger], setting with IIS administration tool"
ms.assetid: 9efc50bf-02fb-4750-9b3e-f03c38f10d8b
caps.latest.revision: 15
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Verify IIS Property Settings
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can set the properties for a Web application using the IIS administration tool. These properties must be set correctly for the application to run, so verifying these settings is often a necessary step in troubleshooting.  
  
> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
### To check IIS settings for the Web application  
  
1. Open the **Administrative Tools** window: On the **Start** menu, point to **Programs**, and then click **Administrative Tools**. If **Administrative Tools** does not appear in the **Programs** menu, then look for it in the **Control Panel**.  
  
    - On Windows 2000, select **Internet Services Manager**.  
  
    - On Windows XP, select **Internet Information Services**.  
  
    - On Windows Server 2003, double-click **Manage Your Server**.  
  
         The **Manage Your Server** window opens. Under **Application Server**, click **Manage this application server**.  
  
         The **Application Server** window opens. Open the **Internet Information Services (IIS) Manager** node in the left pane.  
  
2. In the dialog box, click the tree control node for your machine. Click the **Web Sites** node, and select the Web application's node. It will either be a Web site node, and thus a sibling of the **Default Web Site** node, or a virtual directory node underneath an existing Web site node.  
  
3. Right-click the Web application, and on the shortcut menu, click **Properties**.  
  
4. Verify the security settings for the Web application:  
  
    1. In the Web application **Properties** window, click the **Directory Security** tab, and click **Edit**.  
  
    2. In the **Authentication Methods** dialog box, select **Enable Anonymous Access** and **Integrated Windows authentication** if they are not already selected.  
  
    3. Click **OK** to close the **Authentication Methods** dialog box.  
  
5. For an ATL Server application, verify that the DEBUG verb is associated with your ISAPI extension. For more information, see [How to: Associate DEBUG Verb with Extension](https://msdn.microsoft.com/50d261d3-4bd4-41c0-b44e-3591086f121e).  
  
6. For an [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] application, make sure the virtual folder for the application has an Application Name set in **Internet Information Services (IIS) Manager**, **Internet Services Manager** or **Internet Information Services**.  
  
    1. In the Web application **Properties** window, select the **Directory** tab, if the application is in a virtual directory, or the **Home Directory** tab, if the application is in a Web site.  
  
    2. Verify that the name in the **Local path** matches the name of the directory where the application was actually deployed.  
  
    3. Under **Application Settings**, type the name of the root directory that contains the application.  
  
    4. Click **OK** to close the **Properties** dialog box.  
  
7. For an [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] application, click the **ASP.NET** tab and verify that the correct version of [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] is specified.  
  
8. Click **OK** to close the **Properties** dialog box.  
  
9. Click **OK** to close the **Internet Information Services (IIS) Manager**, **Internet Services Manager**, or **Internet Information Services** dialog box.  
  
## See Also  
 [Troubleshooting](../debugger/debugging-web-applications-troubleshooting.md)
