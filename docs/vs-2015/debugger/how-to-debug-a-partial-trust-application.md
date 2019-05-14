---
title: "How to: Debug a Partial Trust Application | Microsoft Docs"
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
  - "debugging [Visual Studio], partial trust applications"
  - "partial trust applications"
  - "security [Visual Studio], partial trust applications"
ms.assetid: 9d30ad92-28ce-4b21-91d8-698474cddf64
caps.latest.revision: 28
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Debug a Partial Trust Application
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Applies to Windows and console applications.  
  
 [ClickOnce Security and Deployment](../deployment/clickonce-security-and-deployment.md) makes it easy to deploy partial trust applications that take advantage of [Code Access Security](https://msdn.microsoft.com/library/859af632-c80d-4736-8d6f-1e01b09ce127) to limit access to resources on a machine.  
  
 Debugging a partial-trust application can be a challenge, because partial trust applications have different security permissions (and therefore behave differently) depending on where they are installed from. If installed from the internet, a partial trust application will have few permissions. If installed from a local intranet, it will have more permissions, and if installed from the local computer, it will have full permissions. You may also have custom zones, with custom permissions. You may need to debug a partial trust application under any or all of these conditions. Fortunately, Visual Studio makes this easy as well.  
  
 Before you start a debug session in Visual Studio, you can choose the zone you want to simulate an application installed from. When you start debugging, the application will have permissions appropriate to a partial trust application installed from that zone. This enables you to see the behavior of the application as it would appear to a user who downloaded it from that zone.  
  
 If the application attempts to perform an action it does not have permission for, an exception occurs. At that point, the Exception Assistant gives you the chance to add an extra permission, which allows you to restart the debugging session with sufficient permissions to avoid the problem.  
  
 Later, you can go back and see which permissions you added during debugging. If you had to add a permission while debugging, it probably indicates that you need to add a User Consent Prompt at that point in your code.  
  
> [!NOTE]
> Debugger visualizers require greater privileges than are allowed by a partial trust application. Visualizers will not load when you are stopped in code with partial trust. To debug using a visualizer, you must run the code with full trust.  
  
### To choose a zone for your partial-trust application  
  
1. From the **Project** menu, choose _Projectname_**Properties**.  
  
2. In the *Projectname* property pages, click the **Security** page.  
  
3. Select **Enable ClickOnce Security Settings**.  
  
4. Under **Zone your application will be installed from**, click the drop-down listbox and choose the zone you want to simulate the application being installed from.  
  
     The **Permissions required by the application** grid shows all available permissions. The check mark indicates permissions granted to your application.  
  
5. If the zone you choose was **(Custom)**, select the correct custom settings in the **Setting** column of the **Permissions** grid.  
  
6. Click **OK** to close the property pages.  
  
### To add an extra permission when a security exception occurs  
  
1. The **Exception Assistant** dialog box appears with the message: **SecurityException was unhandled.**  
  
2. In the **Exception Assistant** dialog box, under **Actions**, click **Add Permission to the Project**.  
  
3. The **Restart Debug** dialog box appears.  
  
    - If you want to restart the debugging session with the new permission, click **Yes**.  
  
    - If you don't want to restart yet, click **No**.  
  
### To view extra permissions added while debugging  
  
1. From the **Project** menu, choose _Projectname_**Properties**.  
  
2. In the *Projectname* property pages, click the **Security** page.  
  
3. Look at the **Permissions required by the application** grid. Any extra permission you added has two icons in the **Included** column: the normal checkmark, which all included permissions have, and an additional icon, which looks like a balloon containing the letter "i".  
  
4. Use the vertical scrollbar to view the entire **Permissions required by the application** grid.  
  
## See Also  
 [ClickOnce Security and Deployment](../deployment/clickonce-security-and-deployment.md)   
 [Debugger Security](../debugger/debugger-security.md)
