---
title: Registering a Tool Window
description: Learn how you can register your tool windows with Visual Studio using ProvideToolWindowAttribute and ProvideToolWindowVisibilityAttribute.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- tool windows, registering managed
- tool windows, registering
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Register a tool window

You can register your tool windows using <xref:Microsoft.VisualStudio.Shell.ProvideToolWindowAttribute> and  <xref:Microsoft.VisualStudio.Shell.ProvideToolWindowVisibilityAttribute>.

## Example

```csharp

[ProvideToolWindow(typeof(PersistedWindowPane), Style = MsVsShell.VsDockStyle.Tabbed, Window = "3ae79031-e1bc-11d0-8f78-00a0c9110057")]
[ProvideToolWindow(typeof(DynamicWindowPane), PositionX=250, PositionY=250, Width=160, Height=180, Transient=true)]
[ProvideToolWindowVisibility(typeof(DynamicWindowPane), /*UICONTEXT_SolutionExists*/"f1536ef8-92ec-443c-9ed7-fdadf150da82")]
[ProvideMenuResource(1000, 1)]
[PackageRegistration(UseManagedResourcesOnly = true)]
[Guid("01069CDD-95CE-4620-AC21-DDFF6C57F012")]
public class PackageToolWindow : Package
{
```

 In the code above, the <xref:Microsoft.VisualStudio.Shell.ProvideToolWindowAttribute> registers the `PersistedWindowPane` and `DynamicWindowPane` tool windows with Visual Studio. The persisted tool window is docked and tabbed with **Solution Explorer**, and the dynamic window is given a default starting position and size. The dynamic window is made transient, which indicates that it is not created on startup. This writes a `DontForceCreate` value in the `ToolWindows` key in the system registry. For more information, see [Tool window display configuration](/previous-versions/visualstudio/visual-studio-2015/extensibility/tool-window-display-configuration?preserve-view=true&view=vs-2015).