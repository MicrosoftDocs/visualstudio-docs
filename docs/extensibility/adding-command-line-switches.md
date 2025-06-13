---
title: Adding Command-Line Switches
description: Learn how to add command-line switches that are applied to a VSPackage when the devenv.exe command is executed.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- command-line switches, adding
- command-line switches, retrieving
- IVsAppCommandLine::GetOption method
- command line, switches
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Add command-line switches

You can add command-line switches that apply to your VSPackage when *devenv.exe* is executed. Use <xref:Microsoft.VisualStudio.Shell.ProvideAppCommandLineAttribute> to declare the name of the switch and its properties. In this example, the MySwitch switch is added for a subclass of VSPackage named **AddCommandSwitchPackage** with no arguments and with the VSPackage loaded automatically.

```csharp
[ProvideAppCommandLine("MySwitch", typeof(AddCommandSwitchPackage), Arguments = "0", DemandLoad = 1)]
```

 The named parameters are shown in the following descriptions.

|Name|Description|
|-|-|
| Arguments | The number of arguments for the switch. Can be "*", or a list of arguments. |
| DemandLoad | Load the VSPackage automatically if this is set to 1, otherwise set to 0. |
| HelpString | The help string or resource ID of the string to display with **devenv /?**. |
| Name | The switch. |
| PackageGuid | The GUID of the package. |

 The first value of Arguments is usually 0 or 1. A special value of '*' can be used to indicate that the entire remainder of the command line is the argument. This can be useful for debugging scenarios where a user must pass in a debugger command string.

 The DemandLoad value is either `true` (1) or `false` (0) indicates that the VSPackage should be loaded automatically.

 The HelpString value is the resource ID of the string that appears in the **devenv /?** Help display. This value should be in the form "#nnn" where nnn is an integer. The string value in the resource file should end in a new line character.

 The Name value is the name of the switch.

 The PackageGuid value is the GUID of the package that implements this switch. The IDE uses this GUID to find the VSPackage in the registry to which the command-line switch applies.

## Retrieve command-line switches
 When your package is loaded, you can retrieve the command-line switches by completing the following steps.

1. In your VSPackage's <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.SetSite%2A> implementation, call `QueryService` on <xref:Microsoft.VisualStudio.Shell.Interop.SVsAppCommandLine> to get the <xref:Microsoft.VisualStudio.Shell.Interop.IVsAppCommandLine> interface.

2. Call <xref:Microsoft.VisualStudio.Shell.Interop.IVsAppCommandLine.GetOption%2A> to retrieve the command-line switches that the user entered.

   The following code shows how to find out whether the MySwitch command-line switch was entered by the user:

```csharp
IVsAppCommandLine cmdline = (IVsAppCommandLine)GetService(typeof(SVsAppCommandLine));

int isPresent = 0;
string optionValue = "";

cmdline.GetOption("MySwitch", out isPresent, out optionValue);
```

 It is your responsibility to check for your command-line switches each time your package is loaded.

## Related content
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsAppCommandLine>
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.SetSite%2A>
- [Devenv command-line switches](../ide/reference/devenv-command-line-switches.md)
- [CreatePkgDef utility](../extensibility/internals/createpkgdef-utility.md)
- [.Pkgdef files](https://devblogs.microsoft.com/visualstudio/whats-a-pkgdef-and-why/)
