---
title: "Error: Debugging Isn&#39;t Possible Because a Kernel Debugger is Enabled on the System | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
f1_keywords: 
  - "vs.debug.error.kernel_dbg_enabled"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "kernel debugger"
ms.assetid: 630a7abd-3303-4aaa-888a-6de3de14bc01
caps.latest.revision: 26
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Error: Debugging Isn&#39;t Possible Because a Kernel Debugger is Enabled on the System
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When you debug managed code, you might receive the following error message:  
  
```  
Debugging isn't possible because a kernel debugger is enabled on the system  
```  
  
 This message occurs when you try to debug managed code:  
  
- on a [!INCLUDE[win7](../includes/win7-md.md)] or [!INCLUDE[wiprlhext](../includes/wiprlhext-md.md)]system that has been started in debug mode.  
  
- the application uses the CLR version CLR 2.0, 3.0, or 3.5.  
  
## Solution  
  
#### To fix this problem  
  
- Upgrade your application to use CLR version 4.0 or 4.5  
  
     —or—  
  
- Disable kernel debugging and debug in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].  
  
     —or—  
  
- Debug using the Kernel Debugger instead of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].  
  
     —or—  
  
- In the Kernel Debugger, disable user-mode exceptions.  
  
#### To disable kernel debugging in the current session  
  
- At the command prompt, type:  
  
    ```  
    Kdbgctrl.exe -d  
    ```  
  
#### To disable kernel debugging for all sessions (Windows Vista and Windows 7)  
  
1. At the command prompt, type:  
  
    ```  
    bcdedit /debug off   
    ```  
  
2. Restart the computer.  
  
#### To disable kernel debugging for all sessions (other Windows operating systems)  
  
1. Locate boot.ini on your system drive (usually C:\\). The boot.ini file might be hidden and read-only. Therefore, you must use the following command to see it:  
  
    ```  
    dir /ASH  
    ```  
  
2. Open boot.ini using Notepad and remove the following options:  
  
    ```  
    /debug  
    /debugport  
    /baudrate  
    ```  
  
3. Restart the computer.  
  
#### To debug with the Kernel Debugger  
  
1. If the Kernel Debugger is hooked up, you will see a message that asks whether you want to continue to debug. Click the button to continue.  
  
2. You might get a `User break exception(Int 3).` If this occurs, type the following Kernel Debugger command to continue to debug:  
  
     `gn`  
  
## See Also  
 [Debugger Security](../debugger/debugger-security.md)   
 [Debugging Managed Code](../debugger/debugging-managed-code.md)
