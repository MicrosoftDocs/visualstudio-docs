---
title: Choose Toolbox Items, WPF Components
description: Learn how to use the WPF Components tab to display the Windows Presentation Foundation controls available for selection on your local computer.
ms.date: 06/21/2017
ms.topic: reference
f1_keywords:
- vs.chooseitems.wpfcomponents
helpviewer_keywords:
- WPF Components tab, Choose Toolbox Items dialog box
- Choose Toolbox Items dialog box, WPF Components tab
ms.custom: "ide-ref"
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Choose Toolbox items, WPF components

This tab of the **Choose Toolbox Items** dialog box displays a list of Windows Presentation Foundation (WPF) controls available on your local computer. To display this list, select **Choose Toolbox Items** from the **Tools** menu to display the **Choose Toolbox Items** dialog box, and then select its **WPF Components** tab. To sort the components listed, select any column heading.

- When the check box next to a component is selected, an icon for that component will be displayed in the **Toolbox**.

    > [!TIP]
    > To add a WPF control to a project document that's open for editing, drag its **Toolbox** icon onto the Design view surface. Default markup and code for the component are inserted into your project, ready for you to modify. For more information, see [Toolbox](../../ide/reference/toolbox.md).

- When the check box next to a component is cleared, the corresponding icon will be removed from **Toolbox**.

    > [!NOTE]
    > The .NET components installed on your computer remain available whether or not icons for them are displayed in the **Toolbox**.

The columns on the **WPF Components** tab contain the following information:

**Name**

Lists the names of WPF controls for which entries exist in your computer's registry.

**Namespace**

Displays the hierarchy of the [.NET API](/dotnet/api/?view=netframework-4.7&preserve-view=true) namespace that defines the structure of the component. Sort on this column to list the available components within each .NET namespace installed on your computer.

**Assembly Name**

Displays the name of the .NET assembly that includes the namespace for each component. Sort on this column to list the namespaces contained in each .NET assembly installed on your computer.

**Directory**

Displays the location of the .NET assembly. The default location for all assemblies is the Global Assembly Cache. For further information on the Global Assembly Cache, see [Work with assemblies and the Global Assembly Cache](/dotnet/framework/app-domains/working-with-assemblies-and-the-gac).

## UIElement List

### Filter

Filters the list of WPF controls based on the string you provide in the text box. All matches from any of the four columns are shown.

**Clear**

Clears the filter string.

**Browse**

Opens the **Open** dialog box, which lets you navigate to assemblies which contain WPF controls. Use this to load assemblies which are not located in the Global Assembly Cache.

**Language**

Shows the localized language of the assembly which contains the selected WPF control.

## Limitations

Adding a custom control or <xref:System.Windows.Controls.UserControl> to the Toolbox has the following limitations:

- Works only for custom controls defined outside the current project.

- Does not update correctly when you change the solution configuration from Debug to Release, or from Release to Debug. This is because the reference is not a project reference, but is for the assembly on disk instead. If the control is part of the current solution, when you change from Debug to Release, your project continues to reference the Debug version of the control.

In addition, if design-time metadata is applied to the custom control and this metadata specifies that the [Microsoft.Windows.Design.ToolboxBrowsableAttribute](/previous-versions/visualstudio/visual-studio-2010/bb547991(v=vs.100)) is set to `false`, the control does not appear in the Toolbox.

You can reference your controls directly in XAML view by mapping the namespace and assembly for your control.

## See also

- [Toolbox](../../ide/reference/toolbox.md)
- [Get started with WPF](../../designers/getting-started-with-wpf.md)
