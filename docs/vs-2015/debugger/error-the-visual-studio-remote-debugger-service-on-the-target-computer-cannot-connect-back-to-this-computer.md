---
title: "Error: The Visual Studio Remote Debugger service on the target computer cannot connect back to this computer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
f1_keywords: 
  - "vs.debug.error.service_access_denied_oncallback"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: 89ecf99d-66bf-4da0-a840-aa95b0be1702
caps.latest.revision: 15
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Error: The Visual Studio Remote Debugger service on the target computer cannot connect back to this computer
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This error means that the Visual Studio Remote Debugger service is running under a user account that cannot authenticate when it tries to connect to the computer that you are debugging from.  
  
 The following table shows what accounts can access the computer:  
  
|||||  
|-|-|-|-|  
||LocalSystem account|Domain account|Local accounts that have the same username and password on both computers|  
|Both computers on the same domain|Yes|Yes|Yes|  
|Both computers on domains that have two-way trust|No|No|Yes|  
|One or both computers on a workgroup|No|No|Yes|  
|Computers on different domains|No|No|Yes|  
  
 In addition:  
  
- The account you run the Visual Studio Remote Debugger service under should be an administrator on the remote computer so that it can debug any process.  
  
- The account also has to be granted the `Log on as a service` privilege on the remote computer that is using the **Local Security Policy** administrative tool.  
  
- If you are using a local account access the computer, you must run the Visual Studio Remote Debugger service under a local account.  
  
### To correct this error  
  
1. Make sure the Visual Studio Remote Debugger service is correctly set up on the remote computer. For more information, see [Set Up the Remote Tools on the Device](https://msdn.microsoft.com/library/90f45630-0d26-4698-8c1f-63f85a12db9c).  
  
2. Run the remote debugger service under an account that can access the debugger host computer, as shown in the previous table.  
  
### To add "Log on as a service" privilege  
  
1. On the **Start** menu, choose **Control Panel**.  
  
2. In Control Panel, choose **Classic View**, if necessary.  
  
3. Double-click **Administrative Tools**.  
  
4. In the Administrative Tools window, double-click **Local Security Policy**.  
  
5. In the **Local Security Settings** window, expand the **Local Policies** folder.  
  
6. Click **User Rights Assignment**.  
  
7. In the **Policy** column, double-click **Log on as a service** to view current local Group Policy assignments in the **Log on as a service** dialog box.  
  
8. To add new users, click the **Add User or Group** button.  
  
9. When you are finished adding users, click **OK**.  
  
### To work around this error  
  
- Run the Remote Debugging Monitor as an application instead of a service.  
  
## See Also  
 [Remote Debugging Errors and Troubleshooting](../debugger/remote-debugging-errors-and-troubleshooting.md)   
 [Remote Debugging](../debugger/remote-debugging.md)
