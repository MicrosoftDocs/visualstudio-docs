---
title: Extend Office and SharePoint with an app or add-in 
description: Extend Microsoft Office and SharePoint by creating a lightweight app or add-in that users download from the Office Store.
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office applications [Office development in Visual Studio], about developing applications"
  - "Office development in Visual Studio"
  - "Office projects"
  - "Visual Studio Tools for Office, see Office development in Visual Studio"
  - "Office applications [Office development in Visual Studio]"
  - "Office Business Applications"
  - "applications [Office development in Visual Studio]"
  - "programming [Office development in Visual Studio]"
  - "VSTO, see Office development in Visual Studio"
  - "Office, development with Visual Studio"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Office and SharePoint development in Visual Studio

  You can extend Microsoft Office and SharePoint by creating a lightweight app or add-in that users download from the [Office Store](https://store.office.com/) or an organizational catalog, or by creating a .NET Framework-based solution that users install on a computer.

 In this topic:

- [Create add-ins for Office and SharePoint](#Apps)

- [Create a VSTO Add-in](#Add-ins)

- [Create a SharePoint solution](#Solutions)

## <a name="Apps"></a> Create add-ins for Office and SharePoint
 Office 2013 and SharePoint 2013 introduce a new add-in model that helps you build, distribute, and monetize add-ins that extend Office and SharePoint.  These add-ins can run in Office or SharePoint Online, and users can interact with them from many devices.

 Find out how to use the new [Office Add-in model](/office/dev/add-ins/overview/office-add-ins) to extend the Office experience for your users.

 These add-ins have small footprints compared to VSTO add-ins and solutions, and you can build them by using almost any web programming technology such as HTML5, JavaScript, CSS3, and XML.  To get started, use the Office Developer Tools in Visual Studio, which lets you create projects, write code, and run your add-ins in a browser.

 ![Apps for Office and SharePoint conceptual model](../vsto/media/officeandsharepointapps2015.png "Apps for Office and SharePoint conceptual model")

### Build an Office Add-in
 To extend the functionality of Office, build an Office add-in. It's basically a webpage that's hosted in an Office application such as Excel, Word, Outlook, and PowerPoint. Your app can add functionality to documents, worksheets, email messages, appointments, presentations, and projects.

 You can sell your app in the Office Store.  The [Office Store](https://store.office.com/) makes it easy to monetize your add-ins, manage updates, and track telemetry. You can also publish your app to users through an app catalog in SharePoint, or on Exchange Server.

 The following app for Office shows worksheet data in a Bing map.

 ![Content app for Office](../vsto/media/appforoffice.png "Content app for Office")

 **Learn more**

|To|See|
|--------|---------|
|Learn more about Office add-ins, and then build one.|[Office add-ins](/office/dev/add-ins/publish/publish)|
|Compare the different ways in which you can extend Office, and decide whether you should use an app or an Office add-in.|[Roadmap for Office Add-ins, VSTO, and VBA](/archive/blogs/officeapps/roadmap-for-apps-for-office-vsto-and-vba)|

### Build a SharePoint Add-in
 To extend SharePoint for your users, build a SharePoint add-in. It's basically a small, easy-to-use, stand-alone application that solves a need for your users or business.

 You can sell your app for SharePoint in the [Office Store](https://store.office.com/). You can also publish your add-in to users through an add-in catalog in SharePoint.  Site owners can install, upgrade, and uninstall your add-in on their SharePoint sites without the help of a farm server or site collection administrator.

 Here's an example of an app for SharePoint that helps users manage business contacts.

 ![Business contact manager app for SharePoint](../vsto/media/appforsharepoint.png "Business contact manager app for SharePoint")

 **Learn more**

|To|See|
|--------|---------|
|Learn more about SharePoint add-ins, and then build one.|[SharePoint Add-ins](/sharepoint/dev/sp-add-ins/sharepoint-add-ins)|
|Compare add-ins for SharePoint with traditional SharePoint solutions.|[SharePoint Add-ins compared with SharePoint solutions](/sharepoint/dev/general-development/sharepoint-server-application-lifecycle-management)|
|Choose whether to build a SharePoint add-in or a SharePoint solution.|[Decide between SharePoint Add-ins and SharePoint solutions](/sharepoint/dev/general-development/sharepoint-server-application-lifecycle-management)|

## <a name="Add-ins"></a> Create a VSTO Add-in
 Create a VSTO add-in to target Office 2007 or Office 2010, or to extend Office 2013 and Office 2016 beyond what's possible with Office add-ins. VSTO add-ins run only on the desktop. Users have to install VSTO add-ins, so they're typically more difficult to deploy and support.  However, your VSTO add-in can be integrated more closely with Office. For example, it can add tabs and controls to the Office Ribbon and perform advanced automation tasks such as merging documents or modifying charts. You can leverage the .NET Framework and use C# and Visual Basic to interact with Office objects.

 Here's an example what a VSTO add-in can do. This VSTO add-in adds Ribbon controls, a custom task pane, and a dialog box to PowerPoint.

 ![PowerPoint Add-in solution](../vsto/media/powerpointaddin.png "PowerPoint add-in solution")

 **Learn more**

|To|Read|
|--------|----------|
|Compare the different ways in which you can extend Office, and decide whether you should use a VSTO add-in or an Office add-in.|[Roadmap for Office Add-ins, VSTO, and VBA](/archive/blogs/officeapps/roadmap-for-apps-for-office-vsto-and-vba)|
|Create a VSTO add-in.|[VSTO add-ins build with Visual Studio](create-vsto-add-ins-for-office-by-using-visual-studio.md)|

## <a name="Solutions"></a> Create a SharePoint solution
 Create a SharePoint solution to target SharePoint Foundation 2010 and SharePoint Server 2010, or to extend SharePoint 2013 and SharePoint 2016 in ways beyond what's possible with a SharePoint add-in.

 SharePoint solutions require on-premises SharePoint farm servers. Administrators must install them, and because solutions execute in SharePoint, they can affect the performance of the server. However, solutions provide deeper access to SharePoint objects. Also, when you build a SharePoint solution, you can leverage the .NET Framework and use C# and Visual Basic to interact with SharePoint objects.

 **Learn more**

|To|See|
|--------|---------|
|Compare SharePoint solutions with SharePoint add-ins.|[SharePoint Add-ins compared with SharePoint solutions](/sharepoint/dev/general-development/sharepoint-server-application-lifecycle-management)|
|Create a SharePoint solution.|[Create SharePoint solutions](../sharepoint/create-sharepoint-solutions.md)|
