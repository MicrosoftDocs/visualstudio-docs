---
title: Properties Window Buttons
description: Learn about buttons displayed by default on the toolbar for the Properties window and about the implementation of the buttons.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- Properties window, buttons
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Properties Window Buttons

Depending on the development language and the product type, certain buttons are displayed by default on the toolbar for the **Properties** window. In all cases, the **Categorized**, **Alphabetized**, **Properties**, and **Property Pages** buttons are displayed. In Visual C# and Visual Basic, the **Events** button is also displayed. In certain Visual C++ projects, the **VC++ Messages** and the **VC Overrides** buttons are displayed. Additional buttons may be displayed for other project types. For more information about buttons in the **Properties** window, see [Properties Window](../../ide/reference/properties-window.md).

## Implementation of Properties Window Buttons
 When you click the **Categorized** button, Visual Studio calls the <xref:Microsoft.VisualStudio.Shell.Interop.ICategorizeProperties> interface on the object that has focus to sort its properties by category. <xref:Microsoft.VisualStudio.Shell.Interop.ICategorizeProperties> is implemented on the `IDispatch` object that is presented to the **Properties** window.

 There are 11 predefined property categories, which have negative values. You can define custom categories, but we recommend that you assign them positive values to distinguish them from the predefined categories.

 The <xref:Microsoft.VisualStudio.Shell.Interop.ICategorizeProperties.MapPropertyToCategory%2A> method returns the appropriate property category value for the specified property. The <xref:Microsoft.VisualStudio.Shell.Interop.ICategorizeProperties.GetCategoryName%2A> method returns a string that contains the category name. You only have to provide support for custom category values because Visual Studio knows the standard property category values.

 When you click the **Alphabetized** button, the properties are displayed in alphabetical order by name. The names are retrieved by `IDispatch` according to a localized sorting algorithm.

 When the **Properties** window is open, the **Properties** button is automatically shown as selected. In other parts of the environment, the same button is displayed, and you can click it to show the **Properties** window.

 The **Property Pages** button is unavailable if `ISpecifyPropertyPages` is not implemented for the selected object. Property pages display configuration-dependent properties that are typically associated with solutions and projects, but they can be also be associated with project items (for example, in Visual C++).

> [!NOTE]
> You cannot add toolbar buttons to the **Properties** window by using unmanaged code. To add a toolbar button, you must create a managed object that derives from <xref:System.Windows.Forms.Design.PropertyTab>.

## See also
- [Extending Properties](../../extensibility/internals/extending-properties.md)
