---
title: "Overview of Visual Studio Tools for Unity | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-unity-tools
ms.topic: overview
ms.assetid: b4231bb9-45c4-4c77-ac3c-d05033b26393
caps.latest.revision: 6
ms.author: crdun
manager: "crdun"
---
# Overview of Visual Studio Tools for Unity
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In this section, you'll learn more about the features Visual Studio Tools for Unity offers, and how you can use them to become more productive with Unity.  
  
 With Visual Studio Tools for Unity (*VSTU*), you can use Visual Studio to write game and editor scripts in C# and then use its powerful debugger to find and fix errors. The latest release of VSTU includes syntax coloring for Unity's ShaderLab shader language, better debugger visualizations, and improved code generation for the MonoBehavior wizard. VSTU also brings your Unity project files, console messages, and the ability to start your game into Visual Studio so you can spend less time switching to and from the Unity Editor while writing code.  
  
 Continue reading to learn more about these features.  
  
## Integration with Unity  
 Visual Studio Tools for Unity wouldn't be a productivity enhancer if you had to switch back and forth between the Unity editor and Visual Studio all the time. That's why Visual Studio Tools for Unity makes it easy to keep doing work without leaving Visual Studio.  
  
- The **Unity Project Explorer** displays your entire Unity project inside Visual Studio using the same hierarchy displayed in the Unity editor.  
  
- Unity console integration displays output from the Unity console right inside Visual Studio's error window.  
  
- Start debugging your game from Visual Studio – no need to switch back to Unity, just press F5.  
  
## Superior Debugging  
 Connect Visual Studio's powerful debugger to your Unity game to debug your C# scripts and DLLs regardless of whether it's running standalone or in the Unity editor. You can use all the debugging features you expect from Visual Studio.  
  
- Breakpoints, including conditional breakpoints.  
  
- Evaluate complex expressions in the Watch window.  
  
- Inspect and modify the value of variables and arguments.  
  
- Drill down into complex objects and data structures.  
  
  You can even debug your Unity game while it runs on another machine on your network.  
  
## Productivity  
 In addition to Visual Studio's established productivity for writing and refactoring code in C#, Visual Studio Tools for Unity provides extra productivity features for Unity developers.  
  
- Syntax coloring for the Unity's ShaderLab language helps you spot mistakes in your shaders before they become bugs. Just open your ShaderLab files in Visual Studio.  
  
- The MonoBehavior wizard allows you to browse a list of Unity behaviors and creates boilerplate code for behaviors you might not be familiar with. Press CTRL+SHIFT+M.  
  
- Once you're familiar with the Unity behaviors you use most, the Quick MonoBehavior wizard puts them right at your fingertips. Press CTRL+ALT+Q.  
  
- Access Unity documentation from Visual Studio. Just highlight the API call you want to learn about, then press CTRL+ALT+M, CTRL+H.  
  
- Access all these features and more with keyboard shortcuts.  
  
## Visual Studio tools for Unity API  
 Customize and extend the behavior of Visual Studio Tools for Unity using the provided APIs.  
  
- Visual Studio Tools for Unity registers a log callback so it can stream the Unity console to Visual Studio. If you have editor scripts that log information, you can plug them into the same callback to send your messages to Visual Studio. For more information, see the Log Callback example.  
  
- You can change how Visual Studio Tools for Unity generates project files by using the Unity style callback ProjectFileGeneration. For more information, see the Project File Generation example.  
  
## See Also  
 [Unity Homepage](https://unity.com/)
