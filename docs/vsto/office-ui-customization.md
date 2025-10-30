---
title: Customize the UI for Office applications
description: Customize the user interface (UI) of Microsoft Office applications by using the Office developer tools in Visual Studio.
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "menus [Office development in Visual Studio], customizing"
  - "actions panes [Office development in Visual Studio], creating"
  - "WPF [Office development in Visual Studio]"
  - "toolbars [Office development in Visual Studio], customizing"
  - "Office applications [Office development in Visual Studio], UI customization"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Office UI customization

  You can customize the user interface (UI) of Microsoft Office applications by using the Office developer tools in Visual Studio. This topic describes the UI features that you can customize in the following sections:

- [Comparison of UI features](#Comparison)

- [Actions panes and custom task panes](#Actions)

- [Custom Ribbon UI](#Ribbon)

- [Backstage view](#Backstage)

- [Outlook form regions](#FormRegion)

- [Controls on documents](#Controls)

- [Shortcut menus](#Shortcut)

## <a name="Comparison"></a> Comparison of UI Features
 The following table compares the main UI features that you can customize in Microsoft Office projects.

|Feature|Supported project types|Supported Microsoft Office applications|
|-------------|-----------------------------|---------------------------------------------|
|Actions pane|Document-level customizations|Excel<br /><br /> Word|
|Custom task panes|VSTO Add-ins|Excel<br /><br />  InfoPath 2013 <br /><br />  InfoPath 2010 <br /><br /> Outlook<br /><br /> PowerPoint<br /><br /> Word|
|Custom Ribbon UI|Document-level customizations<br /><br /> VSTO Add-ins|Excel<br /><br />  InfoPath 2013 <br /><br />  InfoPath 2010 <br /><br /> Outlook<br /><br /> PowerPoint<br /><br /> Project<br /><br /> Word<br /><br /> Visio|
|Backstage view|Document-level customizations<br /><br /> VSTO Add-ins|Excel<br /><br />  InfoPath 2013 .<br /><br />  InfoPath 2010 <br /><br /> Outlook<br /><br /> PowerPoint<br /><br /> Project<br /><br /> Word<br /><br /> Visio|
|Outlook form regions|VSTO Add-ins|Outlook|
|Controls on documents|Document-level customizations<br /><br /> VSTO Add-ins|Excel<br /><br /> Word|
|Shortcut menus|Document-level customizations<br /><br /> VSTO Add-ins|Excel<br /><br />  InfoPath 2013 <br /><br />  InfoPath 2010 <br /><br /> Outlook<br /><br /> PowerPoint<br /><br /> Project<br /><br /> Word<br /><br /> Visio<br /><br /> Excel|

## <a name="Actions"></a> Actions panes and custom task panes
 Task panes are user interface panels that are typically docked to one side of a window in a Microsoft Office application. Almost all Microsoft Office applications include built-in task panes. An example of a task pane is the Help task pane in Word.

 The Office development tools in Visual Studio provide two different ways to customize task panes:

- You can add an actions pane to a document-level customization. By default, the actions pane is displayed on the right side of the application, to the right of the document. However, the actions pane can also be displayed to the left, top, or bottom of the document.

- You can add a custom task pane to a VSTO Add-in. Users can dock custom task panes to different sides of the application window, or they can drag custom task panes to any location in the window.

  Actions panes and custom task panes provide functionality by hosting a variety of controls to help users with tasks such as data entry. Compared to a Ribbon group, actions panes and custom task panes provide a much larger area to include text and controls.

  For more information about actions panes, see [Actions pane overview](../vsto/actions-pane-overview.md). For more information about custom task panes, see [Custom task panes](../vsto/custom-task-panes.md).

## <a name="Ribbon"></a> Custom Ribbon UI
 You can customize the Ribbon UI to expose functionality that you add to applications in Office. The Ribbon is a way to organize related commands (in the form of controls) so that they are easier to find. You can create your own Ribbon tabs and groups to give users access to functionality that you provide in your solution. Most of the features that were accessed by using the menus and toolbars in earlier versions of the Microsoft Office system can now be accessed by using the Ribbon.

 For more information, see [Ribbon overview](../vsto/ribbon-overview.md).

## <a name="Backstage"></a> Backstage view
 In Office applications, clicking the **File** tab opens the Backstage view. The Backstage view provides a UI that combines file-level tasks and actions, and replaces similar functionality available from the Microsoft Office button in the 2007 Microsoft Office system. The Backstage view is fully extensible by using XML.

 Visual Studio does not provide a designer or APIs for customizing the Backstage view. However, if you add a **Ribbon (XML)** item to your Office project, you can add XML to the Ribbon XML file to customize the Backstage view. For more information about **Ribbon (XML)** items, see [Ribbon XML](../vsto/ribbon-xml.md).

 For more information about customizing the Backstage view, see [Introduction to the Office 2010 Backstage view for developers](/previous-versions/office/developer/office-2010/ee691833(v=office.14)) and [Customize the Office 2010 Backstage view for developers](/previous-versions/office/developer/office-2010/ee815851(v=office.14)).

## <a name="FormRegion"></a> Outlook form regions
 Use form regions to add custom functionality to standard Microsoft Office Outlook forms. You can create form regions that extend any existing form with additional fields or controls. If you create a new form region by using the Office development tools in Visual Studio, you can use only Windows Forms controls on the form region. If you import a form region that was designed in Outlook, then you can use only native Outlook controls.

 You can create form regions that occupy different areas of the Outlook UI. For example, adjoining form regions are displayed at the bottom of the first page of a form, and each adjoining form region is collapsible. You can also add a separate form region that is displayed as a full additional form page and that can appear on any existing standard form or custom form.

 For more information, see [Create Outlook form regions](../vsto/creating-outlook-form-regions.md).

## <a name="Controls"></a> Controls on documents
 You can add a variety of controls to Word documents and Excel worksheets. For example, you might want to add a date picker control to a document so the user can enter dates in a standard format, or put a button on a worksheet to send data to a database.

 When you develop document-level projects for Excel or Word, you can use the Visual Studio designer to add controls to the document or workbook in your project at design time, or you can programmatically add controls at run time. When you develop VSTO Add-in projects for Excel or Word, you can programmatically add controls to any open document or workbook at run time.

 For more information, see [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md) and [Windows forms controls on Office documents overview](../vsto/windows-forms-controls-on-office-documents-overview.md).

## <a name="Shortcut"></a> Shortcut Menus
 A shortcut menu appears when you right-click in a document or an application window. You can set a shortcut menu to appear after an event takes place, such as when a user right-clicks a document, workbook, or host control. You can add a number of different menu commands or controls to a shortcut menu. Create shortcut menus by using XML. If you add a **Ribbon (XML)** item to your Office project, you can add XML to the Ribbon XML file to create shortcut menus. For more information about using XML to create shortcut menus, see [How to: Add commands to shortcut menus](../vsto/how-to-add-commands-to-shortcut-menus.md).

## Related content
- [Ribbon overview](../vsto/ribbon-overview.md)
- [Windows forms controls on Office documents overview](../vsto/windows-forms-controls-on-office-documents-overview.md)
- [Actions pane overview](../vsto/actions-pane-overview.md)
- [Create Outlook form regions](../vsto/creating-outlook-form-regions.md)
- [Custom task panes](../vsto/custom-task-panes.md)
- [Use WPF controls in Office solutions](../vsto/using-wpf-controls-in-office-solutions.md)
- [How to: Show the Developer tab on the Ribbon](../vsto/how-to-show-the-developer-tab-on-the-ribbon.md)
- [How to: Show Add-in user interface errors](../vsto/how-to-show-add-in-user-interface-errors.md)
- [Walkthrough: Collect data using a Windows form](../vsto/walkthrough-collecting-data-using-a-windows-form.md)
