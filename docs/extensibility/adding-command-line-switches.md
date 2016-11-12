---
title: "Adding Command-Line Switches | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "command-line switches, adding"
  - "command-line switches, retrieving"
  - "IVsAppCommandLine::GetOption method"
  - "command line, switches"
ms.assetid: 8bbbd87e-76fe-4fb5-8ef9-65f5e31967cf
caps.latest.revision: 21
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
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
# Adding Command-Line Switches
You can add command-line switches that apply to your VSPackage when devenv.exe is executed. Use <xref:Microsoft.VisualStudio.Shell.ProvideAppCommandLineAttribute> to declare the name of the switch and its properties. In this example, the MySwitch switch is added for a subclass of VSPackage named **AddCommandSwitchPackage** with no arguments and with the VSPackage loaded automatically.  
  
```c#  
[ProvideAppCommandLine("MySwitch", typeof(AddCommandSwitchPackage), Arguments = "0", DemandLoad = 1)]  
```  
  
 The named parameters are shown in the following table  
  
 Arguments  
 The number of arguments for the switch. Can be “*”, or a list of arguments.  
  
 DemandLoad  
 Load the VSPackage automatically if this is set to 1, otherwise set to 0.  
  
 HelpString  
 The help string or resource ID of the string to display with **devenv /?**.  
  
 Name  
 The switch.  
  
 PackageGuid  
 The GUID of the package.  
  
 The first value of Arguments is usually 0 or 1. A special value of '*' can be used to indicate that the entire remainder of the command line is the argument. This can be useful for debugging scenarios where a user must pass in a debugger command string.  
  
 The DemandLoad value is either `true` (1) or `false` (0) indicates that the VSPackage should be loaded automatically.  
  
 The HelpString value is the resource ID of the string that appears in the devenv /?Help display. This value should be in the form "#nnn" where nnn is an integer. The string value in the resource file should end in a new line character.  
  
 The Name value is the name of the switch.  
  
 The PackageGuid value is the GUID of the package that implements this switch. The IDE uses this GUID to find the VSPackage in the registry to which the command-line switch applies.  
  
## Retrieving Command-Line Switches  
 When your package is loaded, you can retrieve the command-line switches by completing the following steps.  
  
1.  In your VSPackage's <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.SetSite%2A> implementation, call `QueryService` on <xref:Microsoft.VisualStudio.Shell.Interop.SVsAppCommandLine> to get the <xref:Microsoft.VisualStudio.Shell.Interop.IVsAppCommandLine> interface.  
  
2.  Call <xref:Microsoft.VisualStudio.Shell.Interop.IVsAppCommandLine.GetOption%2A> to retrieve the command-line switches that the user entered.  
  
 The following code shows how to find out whether the MySwitch command-line switch was entered by the user:  
  
```c#  
IVsAppCommandLine cmdline = (IVsAppCommandLine)GetService(typeof(SVsAppCommandLine));  
  
int isPresent = 0;  
string optionValue = "";  
  
cmdline.GetOption("MySwitch", out isPresent, out optionValue);  
```  
  
 It is your responsibility to check for your command-line switches each time your package is loaded.  
  
## See Also  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsAppCommandLine>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.SetSite%2A>   
 [Devenv Command Line Switches](../ide/reference/devenv-command-line-switches.md)   
 [CreatePkgDef Utility](../extensibility/internals/createpkgdef-utility.md)   
 [.Pkgdef Files](../extensibility/modifying-the-isolated-shell-by-using-the-dot-pkgdef-file.md)