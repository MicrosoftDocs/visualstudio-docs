---
title: Create your own custom task pane
description: Explore custom task panes and create your own task pane and provide users with a familiar interface to access your solution's features.
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office development in Visual Studio, task panes"
  - "user interface panels [Office development in Visual Studio]"
  - "task panes [Office development in Visual Studio]"
  - "user interfaces [Office development in Visual Studio], custom task panes"
  - "custom task panes [Office development in Visual Studio], creating"
  - "task panes [Office development in Visual Studio]. multiple application windows"
  - "custom task panes [Office development in Visual Studio], multiple application windows"
  - "task panes [Office development in Visual Studio], creating"
  - "application-level add-ins [Office development in Visual Studio], custom task panes"
  - "multiple applications windows with custom task panes [Office development in Visual Studio]"
  - "add-ins [Office development in Visual Studio], custom task panes"
  - "custom task panes [Office development in Visual Studio]"
  - "task panes [Office development in Visual Studio], about custom task panes"
  - "custom task panes [Office development in Visual Studio], about custom task panes"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Custom task panes

  Task panes are user interface panels that are typically docked to one side of a window in a Microsoft Office application. Custom task panes give you a way to create your own task pane and provide users with a familiar interface to access your solution's features. For example, the interface can contain controls that run code to modify documents or display data from a data source.

 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]

> [!NOTE]
> A custom task pane differs from the actions pane. The actions pane is part of document-level customizations for Microsoft Office Word and Microsoft Office Excel. For more information, see [Actions pane overview](../vsto/actions-pane-overview.md).

## Benefits of custom task panes
 Custom task panes let you integrate your features into a familiar user interface. You can create a custom task pane quickly by using Visual Studio tools.

### Familiar user interface
 Users of applications in the Microsoft Office system are already familiar with using task panes such as the **Styles and Formatting** task pane in Word. Custom task panes behave like other task panes in the Microsoft Office system. Users can dock custom task panes to different sides of the application window, or they can drag custom task panes to any location in the window. You can create a VSTO Add-in that displays multiple custom task panes at the same time, and users can control each task pane individually.

### Windows forms support
 The user interface of a custom task pane that you create by using the Office development tools in Visual Studio is based on Windows Forms controls. You can use the familiar Windows Forms Designer to design the user interface for a custom task pane. You can also use the data binding support in Windows Forms to bind a data source to controls on the task pane.

## Create a custom task pane
 You can create a basic custom task pane in two steps:

1. Create a user interface for your custom task pane by adding Windows Forms controls to a <xref:System.Windows.Forms.UserControl> object.

2. Instantiate the custom task pane by passing the user control to the <xref:Microsoft.Office.Tools.CustomTaskPaneCollection> object in your VSTO Add-in. This collection returns a new <xref:Microsoft.Office.Tools.CustomTaskPane> object that you can use to modify the appearance of the task pane and respond to user events.

   For more information, see [How to: Add a custom task pane to an application](../vsto/how-to-add-a-custom-task-pane-to-an-application.md).

### Create the user interface
 All custom task panes that are created by using the Office development tools in Visual Studio contain a <xref:System.Windows.Forms.UserControl> object. This user control provides the user interface of your custom task pane. You can create the user control at design time or at run time. If you create the user control at design time, you can use the Windows Forms Designer to construct the user interface of your task pane.

### Instantiate the custom task pane
 After you create a user control that contains the user interface of the custom task pane, you have to instantiate a <xref:Microsoft.Office.Tools.CustomTaskPane>. To do this, pass the user control to the <xref:Microsoft.Office.Tools.CustomTaskPaneCollection> in your VSTO Add-in by calling one of the <xref:Microsoft.Office.Tools.CustomTaskPaneCollection.Add%2A> methods. This collection is exposed as the `CustomTaskPanes` field of the `ThisAddIn` class. The following code example is intended to be run from the `ThisAddIn` class.

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_TaskPaneBasic/ThisAddIn.cs" id="Snippet2":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_TaskPaneBasic/ThisAddIn.vb" id="Snippet2":::
 ---

 The <xref:Microsoft.Office.Tools.CustomTaskPaneCollection.Add%2A> methods return a new <xref:Microsoft.Office.Tools.CustomTaskPane> object. You can use this object to modify the appearance of the task pane and to respond to user events.

### Control the task pane in multiple windows
 Custom task panes are associated with a document frame window, which presents a view of a document or item to the user. The task pane is visible only when the associated window is visible.

 To determine which window displays the custom task pane, use the appropriate <xref:Microsoft.Office.Tools.CustomTaskPaneCollection.Add%2A> method overload when you create the task pane:

- To associate the task pane with the active window, use the <xref:Microsoft.Office.Tools.CustomTaskPaneCollection.Add%2A> method.

- To associate the task pane with a document that is hosted by a specified window, use the <xref:Microsoft.Office.Tools.CustomTaskPaneCollection.Add%2A> method.

  Some Office applications require explicit instructions for when to create or display your task pane when more than one window is open. This makes it important to consider where to instantiate the custom task pane in your code to ensure that the task pane appears with the appropriate documents or items in the application. For more information, see [Manage custom task panes in application windows](#Managing).

## Access the application from the Task Pane
 If you want to automate the application from the user control, you can directly access the object model by using `Globals.ThisAddIn.Application` in your code. The static `Globals` class provides access to the `ThisAddIn` object. The `Application` field of this object is the entry point into the object model of the application.

 For more information about the `Application` field of the `ThisAddIn` object, see [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md). For a walkthrough that demonstrates how to automate an application from a custom task pane, see [Walkthrough: Automatic an application from a custom task pane](../vsto/walkthrough-automating-an-application-from-a-custom-task-pane.md). For more information about the `Globals` class, see [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md).

## Manage the user interface of the Task Pane
 After you create the task pane, you can use properties and events of the <xref:Microsoft.Office.Tools.CustomTaskPane> object to control the user interface of the task pane and to respond when the user changes the task pane.

### Make the custom Task Pane visible
 By default, the task pane is not visible. To make the task pane visible, you must set the <xref:Microsoft.Office.Tools.CustomTaskPane.Visible%2A> property to **true**.

 Users can close a task pane at any time by clicking the **Close** button (X) in the corner of the task pane. However, there is no default way for users to open the custom task pane again. If a user closes a custom task pane, that user cannot view the custom task pane again unless you provide a way to display it.

 If you create a custom task pane in your VSTO Add-in, you should also create a UI element, such as a button, that users can click to display or hide your custom task pane. If you create a custom task pane in a Microsoft Office application that supports customizing the Ribbon, you can add a control group to the Ribbon with a button that displays or hides your custom task pane. For a walkthrough that demonstrates how to do this, see [Walkthrough: Synchronize a custom task pane with a Ribbon button](../vsto/walkthrough-synchronizing-a-custom-task-pane-with-a-ribbon-button.md).

 If you create a custom task pane in a Microsoft Office application that does not support customizing the Ribbon, you can add a <xref:Microsoft.Office.Core.CommandBarButton> that displays or hides your custom task pane.

### Modify the appearance of the task pane
 You can control the size and location of a custom task pane by using properties of the <xref:Microsoft.Office.Tools.CustomTaskPane> object. You can make many other changes to the appearance of a custom task pane by using properties of the <xref:System.Windows.Forms.UserControl> object that is contained in the custom task pane. For example, you can specify a background image for a custom task pane by using the <xref:System.Windows.Forms.Control.BackgroundImage%2A> property of the user control.

 The following table lists the changes you can make to a custom task pane by using <xref:Microsoft.Office.Tools.CustomTaskPane> properties.

|Task|Property|
|----------|--------------|
|To change the size of the task pane|<xref:Microsoft.Office.Tools.CustomTaskPane.Height%2A><br /><br /> <xref:Microsoft.Office.Tools.CustomTaskPane.Width%2A>|
|To change the location of the task pane|<xref:Microsoft.Office.Tools.CustomTaskPane.DockPosition%2A>|
|To hide the task pane or make it visible|<xref:Microsoft.Office.Tools.CustomTaskPane.Visible%2A>|
|To prevent the user from changing the location of the task pane|<xref:Microsoft.Office.Tools.CustomTaskPane.DockPositionRestrict%2A>|

### Program custom task pane events
 You might want your VSTO Add-in to respond when the user modifies the custom task pane. For example, if the user changes the orientation of the pane from vertical to horizontal, you might want to reposition the controls.

 The following table lists the events that you can handle to respond to changes that the user makes to the custom task pane.

|Task|Event|
|----------|-----------|
|To respond when the user changes the location of the task pane.|<xref:Microsoft.Office.Tools.CustomTaskPane.DockPositionChanged>|
|To respond when the user hides the task pane or makes it visible.|<xref:Microsoft.Office.Tools.CustomTaskPane.VisibleChanged>|

## Clean up resources used by the task pane
 After you create a custom task pane, the <xref:Microsoft.Office.Tools.CustomTaskPane> object remains in memory as long as your VSTO Add-in is running. The object remains in memory even after the user clicks the **Close** button (X) in the corner of the task pane.

 To clean up resources used by the task pane while the VSTO Add-in is still running, use the <xref:Microsoft.Office.Tools.CustomTaskPaneCollection.Remove%2A> or <xref:Microsoft.Office.Tools.CustomTaskPaneCollection.RemoveAt%2A> methods. These methods remove the specified <xref:Microsoft.Office.Tools.CustomTaskPane> object from the `CustomTaskPanes` collection, and they call the `Dispose` method of the object.

 The  Visual Studio Tools for Office runtime  automatically cleans up resources used by the custom task pane when the VSTO Add-in is unloaded. Do not call the <xref:Microsoft.Office.Tools.CustomTaskPaneCollection.Remove%2A> or <xref:Microsoft.Office.Tools.CustomTaskPaneCollection.RemoveAt%2A> methods in the `ThisAddIn_Shutdown` event handler in your project. These methods will throw an <xref:System.ObjectDisposedException>, because the  Visual Studio Tools for Office runtime  cleans up resources used by the <xref:Microsoft.Office.Tools.CustomTaskPane> object before `ThisAddIn_Shutdown` is called. For more information about `ThisAddIn_Shutdown`, see [Events in Office projects](../vsto/events-in-office-projects.md).

## <a name="Managing"></a> Manage custom task panes in multiple application windows
 When you create a custom task pane in an application that uses multiple windows to display documents and other items, you need to take extra steps to ensure that the task pane is visible when the user expects it to be.

 Custom task panes in all applications are associated with a document frame window, which presents a view of a document or item to the user. The task pane is visible only when the associated window is visible. However, not all applications use document frame windows the same way.

 The following application groups have different development requirements:

- [Outlook](#Outlook)

- [Word, InfoPath, and PowerPoint](#WordAndInfoPath)

## <a name="Outlook"></a> Outlook
 When you create a custom task pane for Outlook, the custom task pane is associated with a specific Explorer or Inspector window. Explorers are windows that display the contents of a folder, and Inspectors are windows that display an item such as an email message or a task.

 If you want to display a custom task pane with multiple Explorer or Inspector windows, you need to create a new instance of the custom task pane when an Explorer or Inspector window opens. To do this, handle an event that is raised when an Explorer or Inspector window is created, and then create the task pane in the event handler. You can also handle Explorer and Inspector events to hide or display task panes depending on which window is visible.

 To associate the task pane with a specific Explorer or Inspector, use the <xref:Microsoft.Office.Tools.CustomTaskPaneCollection.Add%2A> method to create the task pane, and pass the <xref:Microsoft.Office.Interop.Outlook.Explorer> or <xref:Microsoft.Office.Interop.Outlook.Inspector> object to the *window* parameter. For more information about creating custom task panes, see [Custom task panes overview](../vsto/custom-task-panes.md).

- <xref:Microsoft.Office.Interop.Outlook.ExplorersEvents_Event.NewExplorer>

- <xref:Microsoft.Office.Interop.Outlook.ExplorerEvents_10_Event.Activate>

- <xref:Microsoft.Office.Interop.Outlook.ExplorerEvents_10_Event.Close>

- <xref:Microsoft.Office.Interop.Outlook.ExplorerEvents_10_Event.Deactivate>

  To monitor the state of Inspector windows, you can handle the following Inspector-related events:

- <xref:Microsoft.Office.Interop.Outlook.InspectorsEvents_Event.NewInspector>

- <xref:Microsoft.Office.Interop.Outlook.InspectorEvents_10_Event.Activate>

- <xref:Microsoft.Office.Interop.Outlook.InspectorEvents_10_Event.Close>

- <xref:Microsoft.Office.Interop.Outlook.InspectorEvents_10_Event.Deactivate>

### Prevent multiple instances of a custom task pane in Outlook
 To prevent Outlook windows from displaying multiple instances of a custom task pane, explicitly remove the custom task pane from the `CustomTaskPanes` collection of the `ThisAddIn` class when each window is closed. Call the <xref:Microsoft.Office.Tools.CustomTaskPaneCollection.Remove%2A> method in an event that is raised when a window is closed, such as <xref:Microsoft.Office.Interop.Outlook.ExplorerEvents_10_Event.Close> or <xref:Microsoft.Office.Interop.Outlook.InspectorEvents_10_Event.Close>.

 If you do not explicitly remove the custom task pane, Outlook windows might display multiple instances of the custom task pane. Outlook sometimes recycles windows, and recycled windows retain references to any custom task panes that were attached to them.

## <a name="WordAndInfoPath"></a> Word, InfoPath, and PowerPoint
 Word, InfoPath, and PowerPoint display each document in a different document frame window. When you create a custom task pane for these applications, the custom task pane is associated only with a specific document. If the user opens a different document, the custom task pane is hidden until the earlier document is visible again.

 If you want to display a custom task pane with multiple documents, create a new instance of the custom task pane when the user creates a new document or opens an existing document. To do this, handle events that are raised when a document is created or opened, and then create the task pane in the event handlers. You can also handle document events to hide or display task panes depending on which document is visible.

 To associate the task pane with a specific document window, use the <xref:Microsoft.Office.Tools.CustomTaskPaneCollection.Add%2A> method to create the task pane, and pass a <xref:Microsoft.Office.Interop.Word.Window> (for Word),  <xref:Microsoft.Office.Interop.InfoPath.WindowObject> (for InfoPath), or [DocumentWindow](/previous-versions/office/developer/office-2010/ff762047(v=office.14)) (for PowerPoint) to the *window* parameter.

### Word events
 To monitor the state of document windows in Word, you can handle the following events:

- <xref:Microsoft.Office.Interop.Word.ApplicationEvents4_Event.DocumentBeforeClose>

- <xref:Microsoft.Office.Interop.Word.ApplicationEvents4_Event.DocumentOpen>

- <xref:Microsoft.Office.Interop.Word.ApplicationEvents4_Event.NewDocument>

- <xref:Microsoft.Office.Interop.Word.ApplicationEvents4_Event.WindowActivate>

- <xref:Microsoft.Office.Interop.Word.ApplicationEvents4_Event.WindowDeactivate>

### InfoPath events
 To monitor the state of document windows in InfoPath, you can handle the following events:

- <xref:Microsoft.Office.Interop.InfoPath._ApplicationEvents_Event.NewXDocument>

- <xref:Microsoft.Office.Interop.InfoPath._ApplicationEvents_Event.WindowActivate>

- <xref:Microsoft.Office.Interop.InfoPath._ApplicationEvents_Event.WindowDeactivate>

- <xref:Microsoft.Office.Interop.InfoPath._ApplicationEvents_Event.XDocumentBeforeClose>

- <xref:Microsoft.Office.Interop.InfoPath._ApplicationEvents_Event.XDocumentOpen>

### PowerPoint events
 To monitor the state of document windows in PowerPoint, you can handle the following events:

- [Microsoft.Office.Interop.PowerPoint.EApplication_Event.AfterNewPresentation](/previous-versions/office/developer/office-2010/ff761105(v%3doffice.14))

- [Microsoft.Office.Interop.PowerPoint.EApplication_Event.AfterPresentationOpen](/previous-versions/office/developer/office-2010/ff762843(v%3doffice.14))

- [Microsoft.Office.Interop.PowerPoint.EApplication_Event.NewPresentation](/previous-versions/office/developer/office-2010/ff761498(v%3doffice.14))

- [Microsoft.Office.Interop.PowerPoint.EApplication_Event.PresentationOpen](/previous-versions/office/developer/office-2010/ff760423(v=office.14))

- [Microsoft.Office.Interop.PowerPoint.EApplication_Event.WindowActivate](/previous-versions/office/developer/office-2010/ff761153(v=office.14))

- [Microsoft.Office.Interop.PowerPoint.EApplication_Event.WindowDeactivate](/previous-versions/office/developer/office-2010/ff763093(v=office.14))

## Related content
- [How to: Add a custom task pane to an application](../vsto/how-to-add-a-custom-task-pane-to-an-application.md)
- [Walkthrough: Automate an application from a custom task pane](../vsto/walkthrough-automating-an-application-from-a-custom-task-pane.md)
- [Walkthrough: Synchronize a custom task pane with a Ribbon button](../vsto/walkthrough-synchronizing-a-custom-task-pane-with-a-ribbon-button.md)
- [Walkthrough: Display custom task panes with email messages in Outlook](../vsto/walkthrough-displaying-custom-task-panes-with-e-mail-messages-in-outlook.md)
