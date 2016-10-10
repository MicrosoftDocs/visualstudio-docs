---
title: "Updating Property Values in the Properties Window"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 9358e8c3-b9d2-4fd4-aaab-cf48d1526db4
caps.latest.revision: 9
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Updating Property Values in the Properties Window
There are two ways to keep the **Properties** window in sync with property value changes. The first is to call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell?qualifyHint=False> interface, which provides access to basic windowing functionality, including access to and creation of tool and document windows provided by the environment. The following steps describe this synchronization process.  
  
## Updating Property Values Using IVsUIShell  
  
#### To update property values using the IVsUIShell interface  
  
1.  Call <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell?qualifyHint=False> (through <xref:Microsoft.VisualStudio.Shell.Interop.SVsUIShell?qualifyHint=False> service) any time that VSPackages, projects, or editors need to create or enumerate tool or document windows.  
  
2.  Implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.RefreshPropertyBrowser?qualifyHint=False> to keep the **Properties** window in sync with property changes for a project (or any other selected object being browsed by the **Properties** window) without implementing <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPointContainer?qualifyHint=False> and firing <xref:Microsoft.VisualStudio.OLE.Interop.IPropertyNotifySink.OnChanged?qualifyHint=False> events.  
  
3.  Implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy?qualifyHint=False> methods <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.AdviseHierarchyEvents?qualifyHint=False> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.UnadviseHierarchyEvents?qualifyHint=False> to establish and disable, respectively, client notification of hierarchy events without requiring the hierarchy to implement <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPointContainer?qualifyHint=False>.  
  
## Updating Property Values Using IConnection  
 The second way to keep the **Properties** window in sync with property value changes is to implement `IConnection` on the connectable object to indicate the existence of the outgoing interfaces. If you wish to localize the property name, derive your object from <xref:System.ComponentModel.ICustomTypeDescriptor?qualifyHint=False>. The <xref:System.ComponentModel.ICustomTypeDescriptor?qualifyHint=False> implementation can modify the property descriptors it returns and change the name of a property. To localize the description, create an attribute which derives from <xref:System.ComponentModel.DescriptionAttribute?qualifyHint=False> and override the Description property.  
  
#### Considerations in implementing the IConnection interface  
  
1.  `IConnection` provides access to an enumerator sub-object with the <xref:Microsoft.VisualStudio.OLE.Interop.IEnumConnectionPoints?qualifyHint=False> interface. It also provides access to all the connection point sub-objects, each of which implements the <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPoint?qualifyHint=False> interface.  
  
2.  Any browse object is responsible for implementing an <xref:Microsoft.VisualStudio.OLE.Interop.IPropertyNotifySink?qualifyHint=False> event. The **Properties** window will advise for the event set through `IConnection`.  
  
3.  A connection point controls how many connections (one or more) it allows in its implementation of <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPoint.Advise?qualifyHint=False>. A connection point that allows only one interface can return <xref:Microsoft.VisualStudio.VSConstants.E_NOTIMPL?qualifyHint=False> from the <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPoint.EnumConnections?qualifyHint=False> method.  
  
4.  A client can call the `IConnection` interface to obtain access to an enumerator sub-object with the <xref:Microsoft.VisualStudio.OLE.Interop.IEnumConnectionPoints?qualifyHint=False> interface. The <xref:Microsoft.VisualStudio.OLE.Interop.IEnumConnectionPoints?qualifyHint=False> interface can then be called to enumerate connection points for each outgoing interface ID (IID).  
  
5.  `IConnection` can also be called to obtain access to connection point sub-objects with the <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPoint?qualifyHint=False> interface for each outgoing IID. Through the <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPoint?qualifyHint=False> interface, a client starts or terminates an advisory loop with the connectable object and the client's own sync. The client can also call the <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPoint?qualifyHint=False> interface to obtain an enumerator object with the <xref:Microsoft.VisualStudio.OLE.Interop.IEnumConnections?qualifyHint=False> interface to enumerate the connections that it knows about.  
  
## See Also  
 [Announcing Property Window Selection Tracking](../VS_not_in_toc/Announcing-Property-Window-Selection-Tracking.md)   
 [Extending Properties](../Topic/Extending%20Properties.md)