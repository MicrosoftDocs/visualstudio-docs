---
title: Properties Window Object List
description: Learn about the interfaces used to interact with the object list in the Properties window in the Visual Studio IDE.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- Properties window, object list
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Properties Window Object List

The object list in the **Properties** window is a drop-down list that allows you to change the selection to other objects available within one or more selected windows. Selecting a different object from within this list triggers a call to <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer.SelectObjects%2A> to inform the environment that a new object has been selected. The information displayed in the **Properties** window is then changed to show the properties associated with the newly selected object.

## The Object List
 The object list consists of two fields: the object name (displayed in bold) and the object type.

 The object name displayed to the left of the object type in bold is retrieved from the object itself using the `Name` property provided by the <xref:Microsoft.VisualStudio.OLE.Interop.IProvideClassInfo> interface. <xref:Microsoft.VisualStudio.OLE.Interop.IProvideClassInfo.GetClassInfo%2A>, the only method on <xref:Microsoft.VisualStudio.OLE.Interop.IProvideClassInfo>, returns <xref:Microsoft.VisualStudio.OLE.Interop.ITypeInfo> for that interface's coclass. The **Properties** window uses <xref:Microsoft.VisualStudio.OLE.Interop.IProvideClassInfo> to get the name of the coclass, which is displayed as the object name in the drop-down list.

 If the object does not have a `Name` property, a name is not displayed in the Name area of the object list. You can add a Name property to the object if you want the name displayed in the object list.

 If the COM object does not implement <xref:Microsoft.VisualStudio.OLE.Interop.IProvideClassInfo>, the **Properties** window displays the interface name in place of the object name on the left side of the list.

## See also
- [Extending Properties](../../extensibility/internals/extending-properties.md)
