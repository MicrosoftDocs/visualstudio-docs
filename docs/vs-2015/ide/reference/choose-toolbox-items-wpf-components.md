---
title: "Choose Toolbox Items, WPF Components | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "vs.chooseitems.wpfcomponents"
helpviewer_keywords:
  - "WPF Components tab, Choose Toolbox Items dialog box"
  - "Choose Toolbox Items dialog box, WPF Components tab"
ms.assetid: 6ce1d178-88c0-4295-8915-59fdeedabb11
caps.latest.revision: 17
author: jillre
ms.author: jillfra
manager: jillfra
---
# Choose Toolbox Items, WPF Components
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

This tab of the **Choose Toolbox Items** dialog box displays a list of Windows Presentation Foundation (WPF) controls available on your local computer. To display this list, select **Choose Toolbox Items** from the **Tools** menu to display the **Choose Toolbox Items** dialog box, and then select its **WPF Components** tab. To sort the components listed, select any column heading.

- When the check box next to a component is selected, an icon for that component will be displayed in the **Toolbox**.

  > [!TIP]
  > To add an instance of a WPF control to a project document open for editing, drag its **Toolbox** icon onto the Design view surface. Default markup and code for the component are inserted into your project, ready for you to modify. For more information, see [How to: Manage the Toolbox Window](https://msdn.microsoft.com/a022c3fe-298c-4a59-a48f-b050da90ebc2) and [How to: Manipulate Toolbox Tabs](https://msdn.microsoft.com/21285050-cadd-455a-b1f5-a2289a89c4db).

- When the check box next to a component is cleared, the corresponding icon will be removed from the **Toolbox.**

  > [!NOTE]
  > The .NET Framework components installed on your computer remain available whether or not icons for them are displayed in the **Toolbox**.

  The columns on the **WPF Components** tab contain the following information:

  Name
  Lists the names of WPF controls for which entries exist in your computer's registry.

  Namespace
  Displays the hierarchy of the [NIB: .NET Framework Class Library](https://msdn.microsoft.com/6c4f3a62-6a0f-41f2-9d52-ee0b13686f29) namespace that defines the structure of the component. Sort on this column to list the available components within each .NET Framework namespace installed on your computer.

  Assembly Name
  Displays the name of the .NET Framework assembly that includes the namespace for each component. Sort on this column to list the namespaces contained in each .NET Framework assembly installed on your computer.

  Directory
  Displays the location of the .NET Framework assembly. The default location for all assemblies is the Global Assembly Cache. For further information on the Global Assembly Cache, see [Working with Assemblies and the Global Assembly Cache](https://msdn.microsoft.com/library/8a18e5c2-d41d-49ef-abcb-7c27e2469433).

## UIElement List
 **Filter**
 Filters the list of WPF controls based on the string you provide in the text box. All matches from any of the four columns are shown.

 **Clear**
 Clears the filter string.

 **Browse**
 Opens the **Open** dialog box, which lets you navigate to assemblies which contain WPF controls. Use this to load assemblies which are not located in the Global Assembly Cache.

 **Language**
 Shows the localized language of the assembly which contains the selected WPF control.

## Limitations
 Adding a custom control or <xref:System.Windows.Controls.UserControl> to the Toolbox has the following limitations.

- Works only for custom controls defined outside the current project.

- Does not update correctly when you change the solution configuration from Debug to Release, or from Release to Debug. This is because the reference is not a project reference, but is for the assembly on disk instead. If the control is part of the current solution, when you change from Debug to Release, your project continues to reference the Debug version of the control.

  In addition, if design-time metadata is applied to the custom control and this metadata specifies that the [ToolboxBrowsableAttribute](/previous-versions/visualstudio/visual-studio-2010/bb547991(v=vs.100)) is set to `false`, the control does not appear in the Toolbox.

  You can reference your controls directly in XAML view by mapping the namespace and assembly for your control. For more information, see [How to: Import a Namespace into XAML](https://msdn.microsoft.com/6cda7c7a-369c-47dd-9c2d-13a35dcf737c).

## See also

- [Choose Toolbox Items Dialog Box (Visual Studio)](https://msdn.microsoft.com/bd07835f-18a8-433e-bccc-7141f65263bb)
- [Toolbox](../../ide/reference/toolbox.md)
- [How to: Use a Third-Party WPF Control in a WPF Application](https://msdn.microsoft.com/f4c0b601-3818-4f9f-85e5-77905f3b427f)
- [WPF Designer](https://msdn.microsoft.com/c6c65214-8411-4e16-b254-163ed4099c26)