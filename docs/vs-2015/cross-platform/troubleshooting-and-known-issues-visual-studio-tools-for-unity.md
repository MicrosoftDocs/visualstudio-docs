---
title: "Troubleshooting and Known Issues (Visual Studio Tools for Unity) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-unity-tools
ms.topic: troubleshooting
ms.assetid: 8f5db192-8d78-4627-bd07-dbbc803ac554
caps.latest.revision: 7
author: conceptdev
ms.author: crdun
manager: jillfra
---
# Troubleshooting and Known Issues (Visual Studio Tools for Unity)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In this section, you'll find solutions to common issues with Visual Studio Tools for Unity, descriptions of known issues, and learn how you can help improve Visual Studio Tools for Unity by reporting errors.  
  
## Troubleshooting  
 To resolve some common issues with Visual Studio Tools for Unity, see the following sections.  
  
### Migrating from UnityVS to Visual Studio Tools for Unity  
 If you're migrating from UnityVS to Visual Studio Tools for Unity, you'll need to generate new Visual Studio solutions for your Unity projects.  
  
##### To migrate your Unity project from UnityVS 1.8 to Visual Studio Tools for Unity 1.9  
  
1. Delete the old solution and project files from your Unity project. In the root directory of your Unity project, locate the Visual Studio .sln and .*proj files and delete them all.  
  
2. Import the Visual Studio Tools for Unity package into your Unity project. For information on how to import the VSTU package, see Configure Visual Studio Tools for Unity on the [Getting Started](../cross-platform/getting-started-with-visual-studio-tools-for-unity.md) page.  
  
3. Generate the new solution and project files. If you want to generate them now, in the Unity Editor, on the main menu, choose **Visual Studio Tools**, **Generate Project Files**. Otherwise, you can skip this step if you want; Visual Studio Tools for Unity will generate the new files automatically when you choose **Visual Studio Tools**, **Open in Visual Studio**.  
  
### Visual Studio won't load the solution that Visual Studio Tools for Unity created  
 For more information, see [the answer to this stackoverflow question](https://stackoverflow.com/questions/20086755/unityvs-visual-studio-can-not-open/24035907#24035907).  
  
### On Windows 8, Visual Studio asks to download the Unity target framework  
 UnityVS requires the .net framework 3.5, which isn't installed by default on Windows 8. To fix this issue, follow the instructions to download and install the .net framework 3.5.  
  
## Known Issues  
 There are known issues in Visual Studio Tools for Unity that result from how the debugger interacts with Unity's older version of the C# compiler. We're working to help fix these problems, but you might experience the following issues in the meantime.  
  
- When debugging, Unity sometimes crashes.  
  
- When debugging, Unity sometimes freezes.  
  
- Stepping into and out of methods sometimes behaves incorrectly, especially in iterators or within switch statements.  
  
## Reporting Errors  
 Please help us improve the quality of Visual Studio Tools for Unity by sending error reports when you experience crashing, freezes, or other errors. This helps us investigate and fix problems in Visual Studio Tools for Unity. Thank you!  
  
### How to report an error when Visual Studio freezes  
 There are reports that Visual Studio sometimes freezes when debugging with Visual Studio Tools for Unity, but we need more data to understand this problem. You can help us investigate by following the steps below.  
  
##### To report that Visual Studio freezes while debugging with Visual Studio Tools for Unity  
  
1. Open a new instance of Visual Studio.  
  
2. Open the Attach to Process dialog. In the new instance of Visual Studio, on the main menu, choose **Debug**, **Attach to Process**.  
  
3. Attach the debugger to the frozen instance of Visual Studio. In the **Attach to Process** dialog, select the frozen instance of Visual Studio from the **Available Processes** table, then choose the **Attach** button.  
  
4. Pause the Debugger. In the new instance of Visual Studio, on the main menu, choose **Debug**, **Break All** or just press **Ctrl+Alt+Break**.  
  
5. Create a thread-dump. In the Command window, enter the following command and press **Enter**.  
  
   ```powershell  
   Debug.ListCallStack /AllThreads /ShowExternalCode  
   ```  
  
    You might need to make the **Command** window visible first. In Visual Studio, on the main menu, choose **View**, **Other Windows**, **Command Window**.  
  
6. Finally, send the thread-dump to [vstusp@microsoft.com](mailto:vstusp@microsoft.com), along with a description of what you were doing when Visual Studio became frozen.
