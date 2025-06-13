---
title: Properties Display Grid
description: Learn where the property names and property values fields are found in the grid in the Properties window and how to work with the grid in extending properties.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- properties [Visual Studio SDK], grid
author: maiak
ms.author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
---
# Properties display grid

The **Properties** window displays fields within a grid. The left column contains the property names; the right column contains the property values.

## Work with the grid

The two-column list shows configuration-independent properties that can be changed at design time and their current settings. Note that all properties might not be shown. A property can be set as hidden, for example, by implementing the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPerPropertyBrowsing.HideProperty%2A> method. Specifically, to hide properties that have child properties:

1. Set the `pfDisplay` parameter in <xref:Microsoft.VisualStudio.Shell.Interop.IVsPerPropertyBrowsing.DisplayChildProperties%2A> to `FALSE`.

2. Set the `pfHide` parameter in <xref:Microsoft.VisualStudio.Shell.Interop.IVsPerPropertyBrowsing.HideProperty%2A> to `TRUE`.

To push information to the **Properties** window, the IDE uses <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer>. <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer> is called by VSPackages for each window that contains selectable objects with related properties to be displayed in the **Properties** window. **Solution Explorer**'s implementation of <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer> calls `GetProperty` using [__VSHPROPID.VSHPROPID_BrowseObject](<xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID.VSHPROPID_BrowseObject>) in your project hierarchy to acquire the browsable objects in the hierarchy.

If your VSPackage does not support [__VSHPROPID.VSHPROPID_BrowseObject](<xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID.VSHPROPID_BrowseObject>), the IDE attempts to use <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.GetProperty%2A> using the value for [__VSHPROPID.VSHPROPID_SelContainer](<xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID.VSHPROPID_SelContainer>) that the hierarchy item or items supply.

Your project VSPackage does not need to create <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer> because the IDE-supplied window package that implements it (for example, **Solution Explorer**) constructs <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer> on its behalf.

<xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer> consists of three methods that are called by the IDE:

- <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer.CountObjects%2A> contains the number of objects selected to be displayed in the **Properties** window.

- <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer.GetObjects%2A> returns the `IDispatch` objects that are selected to be displayed in the **Properties** window.

- <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer.SelectObjects%2A> makes it possible for any of the objects returned by <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer.GetObjects%2A> to be selected by the user. This allows the VSPackage to visually update the selection displayed to the user in the UI.

The **Properties** window extracts information from the `IDispatch` objects to retrieve the properties being browsed. The Properties browser uses `IDispatch` to ask the object what properties it supports by querying `ITypeInfo`, which is obtained from `IDispatch::GetTypeInfo`. The browser then uses these values to populate the **Properties** window and change the values for individual properties displayed in the grid. The properties information is maintained within the object itself.

Because the returned objects support `IDispatch`, the caller can obtain information such as the object's name by calling either `IDispatch::Invoke` or `ITypeInfo::Invoke` with a predefined dispatch identifier (DISPID) that represents the desired information. Declared DISPIDs are negative to ensure they do not conflict with user-defined identifiers.

The **Properties** window displays different types of fields depending on the attributes of specific properties of a selected object. These fields include edit boxes, drop-down lists, and links to custom editor dialog boxes.

- Values contained in an enumerated list are retrieved by a <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer.GetObjects%2A> query to `IDispatch`. Values obtained from an enumerated list can be changed in the properties grid by double-clicking the field name, or by clicking the value and selecting the new value from the drop-down list. For properties that have predefined settings from enumerated lists, double-clicking the property name in the Properties list cycles through the available choices. For predefined properties with only two choices, such as true/false, double-click the property name to switch between the choices.

- If <xref:Microsoft.VisualStudio.Shell.Interop.IVsPerPropertyBrowsing.HasDefaultValue%2A> is `false`, indicating that the value has been changed, the value is displayed in bold text. <xref:Microsoft.VisualStudio.Shell.Interop.IVsPerPropertyBrowsing.CanResetPropertyValue%2A> is used to determine if the value can be reset to the original value. If so, you can change back to the default by right-clicking the value and choosing **Reset** from the menu displayed. Otherwise, you have to change the value back to the default manually. <xref:Microsoft.VisualStudio.Shell.Interop.IVsPerPropertyBrowsing> also allows you to localize and hide the names of properties displayed during design time, but does not affect the property names displayed during run time.

- Clicking the ellipsis (...) button displays a list of property values from which the user can select (such as a color picker or font list). <xref:Microsoft.VisualStudio.Shell.Interop.IProvidePropertyBuilder> provides these values.

## See also

- [Extend properties](../../extensibility/internals/extending-properties.md)
