---
title: Properties Window Fields and Interfaces
description: Learn about the selection that determines what information is displayed in the Properties window based on the window that has focus in the Visual Studio IDE.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- Properties window, fields and interfaces
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Properties Window Fields and Interfaces

The model for selection to determine what information is displayed in the **Properties** window is based on the window that has focus in the IDE. Every window, and object within the selected window, can have its selection context object pushed to the global selection context. The environment updates the global selection context with values from a window frame when that window has the focus. When the focus changes, so does the selection context.

## Tracking Selection in the IDE
 The window frame or site, owned by the IDE, has a service called <xref:Microsoft.VisualStudio.Shell.Interop.STrackSelection>. The following steps show how a change in a selection, caused by the user either changing focus to another open window or selecting a different project item in **Solution Explorer**, is implemented to change the content displayed in the **Properties** window.

1. The object created by your VSPackage that is sited in the selected window calls <xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider.QueryService%2A> to have <xref:Microsoft.VisualStudio.Shell.Interop.STrackSelection> invoke <xref:Microsoft.VisualStudio.Shell.Interop.ITrackSelection>.

2. The selection container, provided by the selected window, creates its own <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer> object. When the selection changes, the VSPackage calls <xref:Microsoft.VisualStudio.Shell.Interop.ITrackSelection.OnSelectChange%2A> to notify any listeners in the environment, including the **Properties** window, of the change. It also provides access to hierarchy and item information related to the new selection.

3. Calling <xref:Microsoft.VisualStudio.Shell.Interop.ITrackSelection.OnSelectChange%2A> and passing it the selected hierarchy items in the `VSHPROPID_BrowseObject` parameter populates the <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer> object.

4. An object derived from the [IDispatch Interface](/previous-versions/windows/desktop/api/oaidl/nn-oaidl-idispatch) is returned for [__VSHPROPID.VSHPROPID_BrowseObject](<xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID.VSHPROPID_BrowseObject>) for the item requested, and the environment wraps it into an <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer> (see the following step). If the call fails, the environment makes a second call to `IVsHierarchy::GetProperty`, passing it the selection container [__VSHPROPID.VSHPROPID_SelContainer](<xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID.VSHPROPID_SelContainer>) that the hierarchy item or items supply.

    Your project VSPackage does not create <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer> because the environment-supplied window VSPackage that implements it (for example, **Solution Explorer**) constructs <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer> on its behalf.

5. The environment invokes the methods of <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer> to get the objects based on the `IDispatch` interface to fill in the **Properties** window.

   When a value in the **Properties** window is changed, VSPackages implement `IVsTrackSelectionEx::OnElementValueChangeEx` and `IVsTrackSelectionEx::OnSelectionChangeEx` to report the change to the element value. The environment then invokes <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell> or <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPointContainer> to keep the information displayed in the **Properties** window synchronized with the property values. For more information, see [Updating Property Values in the Properties Window](#updating-property-values-in-the-properties-window).

   In addition to selecting a different project item in **Solution Explorer** to display properties related to that item, you can also choose a different object from within a form or document window using the drop-down list available on the **Properties** window. For more information, see [Properties Window Object List](../../extensibility/internals/properties-window-object-list.md).

   You can change the way information is displayed in the **Properties** window grid from alphabetical to categorical, and, if available, you can also open a property page for a selected object by clicking the appropriate buttons on the **Properties** window. For more information, see [Properties Window Buttons](../../extensibility/internals/properties-window-buttons.md) and [Property Pages](../../extensibility/internals/property-pages.md).

   Finally, the bottom of the **Properties** window also contains a description of the field selected in the **Properties** window grid. For more information, see [Getting Field Descriptions from the Properties Window](#getting-field-descriptions-from-the-properties-window).

## <a name="updating-property-values-in-the-properties-window"></a> Updating Property Values in the Properties Window
There are two ways to keep the **Properties** window in sync with property value changes. The first is to call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell> interface, which provides access to basic windowing functionality, including access to and creation of tool and document windows provided by the environment. The following steps describe this synchronization process.

### Updating Property Values Using IVsUIShell

#### To update property values using the IVsUIShell interface

1. Call <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell> (through <xref:Microsoft.VisualStudio.Shell.Interop.SVsUIShell> service) any time that VSPackages, projects, or editors need to create or enumerate tool or document windows.

2. Implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.RefreshPropertyBrowser%2A> to keep the **Properties** window in sync with property changes for a project (or any other selected object being browsed by the **Properties** window) without implementing <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPointContainer> and firing <xref:Microsoft.VisualStudio.OLE.Interop.IPropertyNotifySink.OnChanged%2A> events.

3. Implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> methods <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.AdviseHierarchyEvents%2A> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.UnadviseHierarchyEvents%2A> to establish and disable, respectively, client notification of hierarchy events without requiring the hierarchy to implement <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPointContainer>.

### Updating Property Values Using IConnection
 The second way to keep the **Properties** window in sync with property value changes is to implement `IConnection` on the connectable object to indicate the existence of the outgoing interfaces. If you wish to localize the property name, derive your object from <xref:System.ComponentModel.ICustomTypeDescriptor>. The <xref:System.ComponentModel.ICustomTypeDescriptor> implementation can modify the property descriptors it returns and change the name of a property. To localize the description, create an attribute which derives from <xref:System.ComponentModel.DescriptionAttribute> and override the Description property.

#### Considerations in implementing the IConnection interface

1. `IConnection` provides access to an enumerator sub-object with the <xref:Microsoft.VisualStudio.OLE.Interop.IEnumConnectionPoints> interface. It also provides access to all the connection point sub-objects, each of which implements the <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPoint> interface.

2. Any browse object is responsible for implementing an <xref:Microsoft.VisualStudio.OLE.Interop.IPropertyNotifySink> event. The **Properties** window will advise for the event set through `IConnection`.

3. A connection point controls how many connections (one or more) it allows in its implementation of <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPoint.Advise%2A>. A connection point that allows only one interface can return <xref:Microsoft.VisualStudio.VSConstants.E_NOTIMPL> from the <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPoint.EnumConnections%2A> method.

4. A client can call the `IConnection` interface to obtain access to an enumerator sub-object with the <xref:Microsoft.VisualStudio.OLE.Interop.IEnumConnectionPoints> interface. The <xref:Microsoft.VisualStudio.OLE.Interop.IEnumConnectionPoints> interface can then be called to enumerate connection points for each outgoing interface ID (IID).

5. `IConnection` can also be called to obtain access to connection point sub-objects with the <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPoint> interface for each outgoing IID. Through the <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPoint> interface, a client starts or terminates an advisory loop with the connectable object and the client's own sync. The client can also call the <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPoint> interface to obtain an enumerator object with the <xref:Microsoft.VisualStudio.OLE.Interop.IEnumConnections> interface to enumerate the connections that it knows about.

## <a name="getting-field-descriptions-from-the-properties-window"></a> Getting Field Descriptions from the Properties Window
At the bottom of the **Properties** window, a description area displays information related to the selected property field. This feature is turned on by default. If you want to hide the description field, right-click the **Properties** window and click **Description**. Doing so also removes the check mark next to the **Description** title in the menu window. You can display the field again by following the same steps to toggle **Description** back on.

 The information in the description field comes from <xref:Microsoft.VisualStudio.OLE.Interop.ITypeInfo>. Each method, interface, coclass, and so on can have an unlocalized `helpstring` attribute in the type library. The **Properties** window retrieves the string from <xref:Microsoft.VisualStudio.OLE.Interop.ITypeInfo.GetDocumentation%2A>.

### To specify localized help strings

1. Add the `helpstringdll` attribute to the library statement in the type library (`typelib`).

   > [!NOTE]
   > This step is optional if the type library is in an object library (.olb) file.

2. Specify `helpstringcontext` attributes for the strings. You can also specify `helpstring` attributes.

    These attributes are distinct from the `helpfile` and `helpcontext` attributes, which are contained in actual .chm file Help topics.

   To retrieve the description information to be displayed for the highlighted property name, the **Properties** window calls <xref:System.Runtime.InteropServices.ComTypes.ITypeInfo2.GetDocumentation2%2A> for the property that is selected, specifying the desired `lcid` attribute for the output string. Internally, <xref:System.Runtime.InteropServices.ComTypes.ITypeInfo2> finds the .dll file specified in the `helpstringdll` attribute and calls `DLLGetDocumentation` on that .dll file with the specified context and `lcid` attribute.

   The signature and implementation of `DLLGetDocumentation` are:

```cpp
STDAPI DLLGetDocumentation
(
   ITypeLib * /* ptlib */,
   ITypeInfo * /* ptinfo */,
   LCID /* lcid */,
   DWORD dwCtx,
   BSTR * pbstrHelpString
);
```

 The `DLLGetDocumentation` function must be an export defined in the .def file for the DLL.

 Internally, an .olb file is created which is actually a DLL. This DLL contains one resource, the type library (.tlb) file, and one exported function, `DLLGetDocumentation`.

 In the case of .olb files, the `helpstringdll` attribute is optional because it is the same file that contains the .tlb file itself.

 To get strings to show up in the **Descriptions** pane, therefore, the minimum you have to do is specify the `helpstring` attribute in the type library. If you want those strings to be localized, you have to specify the `helpstringdll` (optional) attribute and the `helpstringcontext` (required) attribute and implement `DLLGetDocumentation`.

 There are no additional interfaces that need to be implemented when getting localized information through idl's `helpstringcontext` attribute and `DLLGetDocumentation`.

 Another way of obtaining the localized name and description of a property is by implementing <xref:Microsoft.VisualStudio.Shell.Interop.IVsPerPropertyBrowsing.GetLocalizedPropertyInfo%2A>. For more information relating to the implementation of this method, see [Properties Window Fields and Interfaces](../../extensibility/internals/properties-window-fields-and-interfaces.md).

## See also

- [Extending Properties](../../extensibility/internals/extending-properties.md)
