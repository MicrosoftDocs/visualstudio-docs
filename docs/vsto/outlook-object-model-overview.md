---
title: "Outlook Object Model Overview | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VST.ProjectItem.OutlookAddin"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Outlook [Office development in Visual Studio], object model overview"
  - "object models [Office development in Visual Studio], Office"
  - "objects [Office development in Visual Studio], Office object models"
  - "object models [Office development in Visual Studio], Outlook"
  - "Office object models"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Outlook Object Model Overview
  To develop VSTO Add-ins for Microsoft Office Outlook, you can interact with the objects that are provided by the Outlook object model. The Outlook object model provides classes and interfaces that represent items in the user interface. For example, the <xref:Microsoft.Office.Interop.Outlook.Application> object represents the entire application, the <xref:Microsoft.Office.Interop.Outlook.MAPIFolder> object represents a folder that contains e-mail messages or other items, and the <xref:Microsoft.Office.Interop.Outlook.MailItem> object represents an e-mail message.  
  
 This topic provides a brief overview of some of the main objects in the Outlook object model. For resources where you can learn more about the entire Outlook object model, see [Using the Outlook Object Model Documentation](#refdoc).  
  
 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]  
  
 ![link to video](../vsto/media/playvideo.gif "link to video") For a related video demonstration, see [How Do I: Use Outlook to Create a Custom Task Report?](http://go.microsoft.com/fwlink/?LinkID=130315).  
  
## Accessing Objects in an Outlook Project  
 Outlook provides many objects with which you can interact. To use the object model effectively, you should be familiar with the following top-level objects:  
  
-   <xref:Microsoft.Office.Interop.Outlook.Application>  
  
-   <xref:Microsoft.Office.Interop.Outlook.Explorer>  
  
-   <xref:Microsoft.Office.Interop.Outlook.Inspector>  
  
-   <xref:Microsoft.Office.Interop.Outlook.MAPIFolder>  
  
-   <xref:Microsoft.Office.Interop.Outlook.MailItem>  
  
-   <xref:Microsoft.Office.Interop.Outlook.AppointmentItem>  
  
-   <xref:Microsoft.Office.Interop.Outlook.TaskItem>  
  
-   <xref:Microsoft.Office.Interop.Outlook.ContactItem>  
  
### Application Object  
 The <xref:Microsoft.Office.Interop.Outlook.Application> object represents the Outlook application, and it is the highest-level object in the Outlook object model. Some of the most important members of this object include:  
  
-   The [CreateItem](http://msdn.microsoft.com/en-us/771707fb-5f34-473d-9fdf-09a6a7f55ece) method which you can use to create a new item such as an e-mail message, task, or appointment.  
  
-   The <xref:Microsoft.Office.Interop.Outlook._Application.Explorers%2A> property, which you can use to access the windows that display the contents of a folder in the Outlook user interface (UI).  
  
-   The <xref:Microsoft.Office.Interop.Outlook._Application.Inspectors%2A> property, which you can use to access the windows that display the contents of a single item, such as an e-mail message or meeting request.  
  
 To get an instance of the <xref:Microsoft.Office.Interop.Outlook.Application> object, use the Application field of the `ThisAddIn` class in your project. For more information, see [Programming VSTO Add-Ins](../vsto/programming-vsto-add-ins.md).  
  
> [!NOTE]  
>  To help avoid security warnings when you use properties and methods that are blocked by the Outlook object model guard, get Outlook objects from the Application field of the `ThisAddIn` class. For more information, see [Specific Security Considerations for Office Solutions](../vsto/specific-security-considerations-for-office-solutions.md).  
  
### Explorer Object  
 The <xref:Microsoft.Office.Interop.Outlook.Explorer> object represents a window that displays the contents of a folder that contains items such as e-mail messages, tasks, or appointments. The <xref:Microsoft.Office.Interop.Outlook.Explorer> object includes methods and properties that you can use to modify the window, and events that are raised when the window changes.  
  
 To get an <xref:Microsoft.Office.Interop.Outlook.Explorer> object, do one of the following:  
  
-   Use the <xref:Microsoft.Office.Interop.Outlook._Application.Explorers%2A> property of the <xref:Microsoft.Office.Interop.Outlook.Application> object to access all of the <xref:Microsoft.Office.Interop.Outlook.Explorer> objects in Outlook.  
  
-   Use the <xref:Microsoft.Office.Interop.Outlook._Application.ActiveExplorer%2A> method of the <xref:Microsoft.Office.Interop.Outlook.Application> object to get the <xref:Microsoft.Office.Interop.Outlook.Explorer> that currently has focus.  
  
-   Use the GetExplorer method of the <xref:Microsoft.Office.Interop.Outlook.MAPIFolder> object to get the <xref:Microsoft.Office.Interop.Outlook.Explorer> for the current folder.  
  
### Inspector Object  
 The <xref:Microsoft.Office.Interop.Outlook.Inspector> object represents a window that displays a single item such as an e-mail message, task, or appointment. The <xref:Microsoft.Office.Interop.Outlook.Inspector> object includes methods and properties that you can use to modify the window, and events that are raised when the window changes.  
  
 To get an <xref:Microsoft.Office.Interop.Outlook.Inspector> object, do one of the following:  
  
-   Use the <xref:Microsoft.Office.Interop.Outlook._Application.Inspectors%2A> property of the <xref:Microsoft.Office.Interop.Outlook.Application> object to access all of the <xref:Microsoft.Office.Interop.Outlook.Inspector> objects in Outlook.  
  
-   Use the <xref:Microsoft.Office.Interop.Outlook._Application.ActiveInspector%2A> method of the <xref:Microsoft.Office.Interop.Outlook.Application> object to get the <xref:Microsoft.Office.Interop.Outlook.Inspector> that currently has focus.  
  
-   Use the GetInspector method of a specific item, such as a <xref:Microsoft.Office.Interop.Outlook.MailItem> or <xref:Microsoft.Office.Interop.Outlook.AppointmentItem>, to retrieve the Inspector that is associated with it.  
  
### MAPIFolder Object  
 The <xref:Microsoft.Office.Interop.Outlook.MAPIFolder> object represents a folder that contains e-mail messages, contacts, tasks, and other items. Outlook provides 16 default <xref:Microsoft.Office.Interop.Outlook.MAPIFolder> objects.  
  
 The default <xref:Microsoft.Office.Interop.Outlook.MAPIFolder> objects are defined by the <xref:Microsoft.Office.Interop.Outlook.OlDefaultFolders> enumeration values. For example,  
  
 Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderInbox corresponds to the **Inbox** folder in Outlook.  
  
 For an example that shows how to access a default <xref:Microsoft.Office.Interop.Outlook.MAPIFolder> and create a new <xref:Microsoft.Office.Interop.Outlook.MAPIFolder>, see [How to: Programmatically Create Custom Folder Items](../vsto/how-to-programmatically-create-custom-folder-items.md).  
  
### MailItem Object  
 The <xref:Microsoft.Office.Interop.Outlook.MailItem> object represents an e-mail message. <xref:Microsoft.Office.Interop.Outlook.MailItem> objects are usually in folders, such as **Inbox**, **Sent Items**, and **Outbox**. <xref:Microsoft.Office.Interop.Outlook.MailItem> exposes properties and methods that can be used to create and send e-mail messages.  
  
 For an example that shows how to create an e-mail message, see [How to: Programmatically Create an E-Mail Item](../vsto/how-to-programmatically-create-an-e-mail-item.md).  
  
### AppointmentItem Object  
 The <xref:Microsoft.Office.Interop.Outlook.AppointmentItem> object represents a meeting, a one-time appointment, or a recurring appointment or meeting in the **Calendar** folder. The <xref:Microsoft.Office.Interop.Outlook.AppointmentItem> object includes methods that perform actions such as responding to or forwarding meeting requests, and properties that specify meeting details such as the location and time.  
  
 For an example that shows how to create an appointment, see [How to: Programmatically Create a Meeting Request](../vsto/how-to-programmatically-create-a-meeting-request.md).  
  
### TaskItem Object  
 The <xref:Microsoft.Office.Interop.Outlook.TaskItem> object represents a task to be performed within a specified time frame. <xref:Microsoft.Office.Interop.Outlook.TaskItem> objects are located in the **Tasks** folder.  
  
 To create a task, use the [CreateItem](http://msdn.microsoft.com/en-us/771707fb-5f34-473d-9fdf-09a6a7f55ece) method of the <xref:Microsoft.Office.Interop.Outlook.Application> object, and pass in the value <xref:Microsoft.Office.Interop.Outlook.OlItemType.olTaskItem> for the parameter.  
  
### ContactItem Object  
 The <xref:Microsoft.Office.Interop.Outlook.ContactItem>object represents a contact in the **Contacts** folder. <xref:Microsoft.Office.Interop.Outlook.ContactItem> objects contain a variety of contact information for the people they represent, such as street addresses, e-mail addresses, and phone numbers.  
  
 For an example that shows how to create a new contact, see [How to: Programmatically Add an Entry to Outlook Contacts](../vsto/how-to-programmatically-add-an-entry-to-outlook-contacts.md). For an example that shows how to search for an existing contact, see [How to: Programmatically Search for a Specific Contact](../vsto/how-to-programmatically-search-for-a-specific-contact.md).  
  
##  <a name="refdoc"></a> Using the Outlook Object Model Documentation  
 For complete information about the Outlook object model, you can refer to the Outlook primary interop assembly (PIA) reference and the VBA object model reference.  
  
### Primary Interop Assembly Reference  
 The Outlook PIA reference documents the types in the primary interop assemblies for Outlook 2010. For more information, see [Outlook 2010 Primary Interop Assembly Reference](http://go.microsoft.com/fwlink/?LinkId=189580).  
  
 In addition to providing information for all of the types in the PIAs, this documentation also provides additional information about the structure of the PIAs and code examples for common Outlook automation tasks.  
  
### VBA Object Model Reference  
 The VBA object model reference documents the Outlook object model as it is exposed to Visual Basic for Applications (VBA) code. For more information, see [Outlook 2010 Object Model Reference](http://go.microsoft.com/fwlink/?LinkId=199769).  
  
 All of the objects and members in the VBA object model reference correspond to types and members in the Outlook PIA. For example, the Inspector object in the VBA object model reference corresponds to the <xref:Microsoft.Office.Interop.Outlook.Inspector> object in the Outlook PIA. Although the VBA object model reference provides code examples for most properties, methods, and events, you must translate the VBA code in this reference to Visual Basic or Visual C# if you want to use them in an Outlook VSTO Add-In project that you create by using Visual Studio.  
  
### Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Working with Contact Items](../vsto/working-with-contact-items.md)|Provides topics that show how to perform tasks with contacts.|  
|[Working with Mail Items](../vsto/working-with-mail-items.md)|Provides topics that show how to perform tasks with mail items.|  
|[Working with Folders](../vsto/working-with-folders.md)|Provides topics that show how to perform tasks with folders.|  
|[Working with Calendar Items](../vsto/working-with-calendar-items.md)|Provides topics that show how to perform tasks with calendar items.|  
|[How to: Programmatically Determine the Current Outlook Item](../vsto/how-to-programmatically-determine-the-current-outlook-item.md)|Shows how to display the name of the current folder and some information about the selected item.|  
  