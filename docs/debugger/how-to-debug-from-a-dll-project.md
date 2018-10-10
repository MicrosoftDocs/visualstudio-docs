---
title: "How to: Debug from a DLL Project | Microsoft Docs"
ms.custom: ""
ms.date: "05/24/2018"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
dev_langs: 
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords: 
  - "DLL projects, debugging"
  - "debugging DLLs"
  - "DLLs, debugging projects"
  - "debugging [Visual Studio], DLLs"
ms.assetid: 40a94339-d3f7-4ab9-b8a1-b8cf82942f44
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "multiple"
---
# How to: Debug from a DLL project in Visual Studio
One way to debug a DLL project is to specify the calling app in the properties of the DLL project. Then you can start debugging from the DLL project itself. For this method to work, the DLL must be where the app expects to find it. If it is not, the app might find and load a different version of the DLL, which won't contain your breakpoints. For other methods of debugging DLLs, see [Debugging DLL projects](../debugger/debugging-dll-projects.md).
  
If a managed DLL is called by native code and you want to debug both, you can specify that in the project properties. The C++ property pages differ from the C# and Visual Basic property pages. For more information, see [How to: Debug in mixed mode](../debugger/how-to-debug-in-mixed-mode.md).   

## To specify the calling application in a C++ project  
  
1. Select the C++ project in **Solution Explorer** and click the **Properties** icon, press **Alt**+**Enter**, or right-click and choose **Properties**.
   
1. In the **\<Project> Property Pages** dialog box, make sure that the **Configuration** field at the top of the window is set to **Debug**. 
   
1. Select **Configuration Properties** > **Debugging**.  
   
1. In the **Debugger to launch** list, choose either **Local Windows Debugger** or **Remote Windows Debugger**.  
   
1. In the **Command** or **Remote Command** box, add the fully-qualified path and filename of the calling app, such as an *.exe* file.
   
   ![Debug Properties window](../debugger/media/dbg-debugging-properties-dll.png "Debug Properties window")  
   
1. Add any necessary program arguments to the **Command Arguments** box.  
   
1. Select **OK**.
   
   ![Enable mixed mode debugging](../debugger/media/dbg-mixed-mode-from-native.png "Enable mixed mode debugging")

## To specify the calling application in a C# or Visual Basic project  
  
1.  Right-click the project node in the **Solution Explorer** and select **Properties**, and then select the **Debug** tab.

2.  Make sure that the **Configuration** field at the top of the window is set to **Debug**.

3.  For .NET Framework, select **Start external program**, and add the fully-qualified path and name of the calling app.

4.  For .NET Core, select **Executable** from the **Launch** list, and then add the fully-qualified path and name of the calling app in the **Executable** field. 
  
    Add any necessary command line arguments in the **Command line arguments** (or **Application arguments**) field.

    ![Debug Properties window](../debugger/media/dbg-debugging-properties-dll-csharp.png "Debug Properties window") 

5.  You can also call an app as a URL. You might want to do this if you are debugging a managed DLL used by a local ASP.NET application.  
  
     Under **Start Action**, select **Start browser with URL** and fill in the URL.
  
### To start debugging from the DLL project  
  
1.  Set breakpoints in the DLL project, and make sure that the **Solutions Configuration** field is set to **Debug**. 

2.  Right-click the DLL project and choose **Set as Startup Project**. 

3.  Start debugging (press **F5**, click the green **Start** arrow, or select **Debug** > **Start Debugging**).

    If you aren't able to hit the breakpoints, make sure that your DLL output (by default, the **project\Debug** folder) is in a location that the calling app expects to find it.
  
## See also  
 [Debugging DLL projects](../debugger/debugging-dll-projects.md)   
 [Project settings for  C# debug configurations](../debugger/project-settings-for-csharp-debug-configurations.md)   
 [Project settings for a Visual Basic debug configuration](../debugger/project-settings-for-a-visual-basic-debug-configuration.md)   
 [Project settings for a C++ debug configuration](../debugger/project-settings-for-a-cpp-debug-configuration.md)