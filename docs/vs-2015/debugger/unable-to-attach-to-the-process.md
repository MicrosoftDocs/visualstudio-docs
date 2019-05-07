---
title: "Unable to Attach to the Process | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.remote.unable2attach"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: 0468de6c-3ff1-4979-a8c6-8afb53f37547
caps.latest.revision: 13
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Unable to Attach to the Process
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Unable to attach to the process. Debugger component on server received access denied while connecting to this machine.  
  
 There are two common scenarios that cause this error:  
  
 **Scenario 1:** Machine A is running Windows XP. Machine B is running Windows Server 2003. The registry on Machine B contains the following DWORD value:  
  
 `HKLM\Software\Microsoft\MachineDebugManager\AllowLaunchAsOtherUser=1`  
  
 User 1 starts a Terminal Server session (session 1) on machine B and starts a managed application from that session.  
  
 User 2, who is administrator on both machines, is logged onto Machine A. From there, he or she tries to attach to an application running in session 1 on Machine B.  
  
 **Scenario 2:** One user is logged onto two machines, A and B, in the same workgroup, using the same password on both machines. The debugger is running on Machine A and trying to attach to a managed application running on Machine B. Machine A has **Network access: Sharing and security model for local accounts** set to **Guest**.  
  
### To solve Scenario 1  
  
- Run the debugger and managed application under the same user account name and password.  
  
### To solve Scenario 2  
  
1. From the **Start** menu, choose **Control Panel**.  
  
2. In Control Panel, double-click **Administrative tools**.  
  
3. In the Administrative tools window, double-click **Local Security Policy**.  
  
4. In the Local Security Policy window, select **Local Policies**.  
  
5. In the **Policies** column, double-click **Network access: Sharing and security model for local accounts**.  
  
6. In the **Network access: Sharing and security model for local accounts** dialog box, change the local security setting to **Classic**, and click **OK**.  
  
    > [!CAUTION]
    > Changing the security model to Classic can result in unexpected access to shared files and DCOM components. If you make this change, a remote user can authenticate with your local user account rather than Guest. If a remote user matches your user name and password, that user will be able to access any folder or DCOM object you have shared out. If you use this security model, make sure that all user accounts on the machine have strong passwords or set up an isolated network island for the debugging and debugged machines to prevent unauthorized access.  
  
7. Close all windows.  
  
## See Also  
 [Debugger Settings and Preparation](../debugger/debugger-settings-and-preparation.md)
