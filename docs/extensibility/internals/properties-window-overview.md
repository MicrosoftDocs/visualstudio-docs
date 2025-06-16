---
title: Properties Window Overview
description: Learn about the interfaces used to interact with the Properties window in the Visual Studio IDE in this overview.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- Properties window
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Properties Window Overview

The **Properties** window is used to display properties for objects selected in the two main types of windows available in the Visual Studio integrated development environment (IDE). These two types of windows are:

- Tool windows such as Solution Explorer, Class View, and Object browser

- Document windows containing such editors and designers as the forms designer, XML editor, and HTML editor

## Using the Properties Window
 The **Properties** window displays the properties of single or multiple selected items. If multiple items are selected, the intersection of all properties for all selected objects is displayed.

 Events related to a selected object within a form design window or HTML editor using COM+ metadata are displayed in the **Properties** window. For example, you can select a button and display its associated events, such as an `OnClick` event, which can be linked to that button.

 Events displayed in the **Properties** window are primarily used with objects that are bound to code. If you are editing a file format that does not have anything to do with code, you are not going to have any events. Events are only displayed in the **Properties** window when there is a binding between running code and certain events associated with specific objects. An example of this would be code behind a selected object that executes when that object is activated.

 The following table lists the primary interfaces used by the **Properties** window.

|Interface Name|Description|
|--------------------|-----------------|
|<xref:Microsoft.VisualStudio.Shell.Interop.ICategorizeProperties>|Provides a list of categories to the **Properties** window and maps each property to a category.|
|[IDispatch Interface](/previous-versions/windows/desktop/api/oaidl/nn-oaidl-idispatch)|Exposes an object's methods and properties to programming tools and other applications that support automation.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IProvidePropertyBuilder>|Provides ellipsis (...) buttons called *builders* that open modal dialog windows implemented by the object itself. Used when a value is not easily typed by the user in a text field. For example, it might be used to open a color picker that determines the RGB value for you.|
|<xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer>|Provides access to objects used to update information displayed in the **Properties** window. <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer> is implemented by VSPackages for each window that contains selectable objects with related properties to be displayed.|
|<xref:Microsoft.VisualStudio.OLE.Interop.ITypeInfo>|Provides information about the type of an object such as methods of an interface and fields of a structure.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsMonitorSelection>|Enables VSPackages to receive notification of selection events and to retrieve information about the current project hierarchy, item, element value, and command UI context.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsMultiItemSelect>|Provides the environment with access to multiple selections.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsPerPropertyBrowsing>|Used to provide localized names on some properties displayed in the **Properties** window.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsSelectionEvents>|Notifies registered VSPackages of changes to the current selection, element value, or command UI context.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackSelectionEx>|Notifies the environment of a change in the current selection and provides access to hierarchy and item information relating to the new selection.|

 For further information on `IDispatch`, see the MSDN library.

## See also
- [Extending Properties](../../extensibility/internals/extending-properties.md)
- [Properties Window Fields and Interfaces](../../extensibility/internals/properties-window-fields-and-interfaces.md)
