---
title: Automate Outlook actions with VSTO add-ins
description: Use VSTO add-ins to automate Microsoft Outlook actions, extend Outlook features, or customize the Outlook user interface (UI).
ms.date: "08/14/2019"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "solutions [Office development in Visual Studio], Outlook"
  - "Office projects [Office development in Visual Studio], Outlook"
  - "Office solutions [Office development in Visual Studio], Outlook"
  - "templates [Office development in Visual Studio], Outlook"
  - "projects [Office development in Visual Studio], Outlook"
  - "Outlook [Office development in Visual Studio]"
  - "e-mail [Office development in Visual Studio], Outlook solutions"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Outlook solutions

  Visual Studio provides project templates you can use to create VSTO Add-ins for Microsoft Office Outlook. You can use VSTO Add-ins to automate Outlook, extend Outlook features, or customize the Outlook user interface (UI). For more information about VSTO Add-ins, see [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md).

 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]

[!include[Add-ins note](includes/addinsnote.md)]

## Create an Outlook VSTO Add-in Project
 Create Outlook projects by using the **Outlook Add-in** project template in the **New Project** dialog box. This template includes required assembly references and project files.

 For more information about how to create a VSTO Add-in project, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md). For more information about the project templates, see [Office project templates overview](../vsto/office-project-templates-overview.md).

## Outlook VSTO Add-in programming model
 When you create an Outlook VSTO Add-in project, Visual Studio generates a class, called `ThisAddIn`, which is the foundation of your solution. This class provides a starting point for writing your code, and it also exposes the object model of Outlook to your VSTO Add-in.

 For more information about the `ThisAddIn` class and other features you can use in a VSTO Add-in, see [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md).

## Automate Outlook by using the Outlook object model
 The Outlook object model exposes many types that you can use to automate Outlook. These types enable you to write code to accomplish common tasks:

- Programmatically create and send e-mail messages.

- Send new meeting requests.

- Search for items in Outlook folders.

  For more information, see [Outlook object model overview](../vsto/outlook-object-model-overview.md).

## Customize the user interface of an Outlook application

|Task|For more information|
|----------|--------------------------|
|Add custom tabs to the Ribbon of an Outlook Inspector.|[Ribbon overview](../vsto/ribbon-overview.md)|
|Add custom groups to a built-in tab in an Outlook Inspector.|[How to: Customize a built-in tab](../vsto/how-to-customize-a-built-in-tab.md)|
|Add a custom task pane that appears in an Outlook Inspector|[Custom task panes](../vsto/custom-task-panes.md).|
|Add a form region that extends or replaces existing Outlook forms.|[Create Outlook form regions](../vsto/creating-outlook-form-regions.md)|

 For more information about customizing the UI of Outlook and other Microsoft Office applications, see [Office UI customization](../vsto/office-ui-customization.md).

## Related topics

|Title|Description|
|-----------|-----------------|
|[Outlook object model overview](../vsto/outlook-object-model-overview.md)|Provides an overview of the objects that are provided by the Outlook object model.|
|[Create Outlook form regions](../vsto/creating-outlook-form-regions.md)|Explains the tools provided by Visual Studio that make it easier for you to design, develop, and debug form regions.|
|[Walkthrough: Create your first VSTO Add-In for Outlook](../vsto/walkthrough-creating-your-first-vsto-add-in-for-outlook.md)|Shows you how to create a VSTO Add-in for Microsoft Office Outlook.|
|[Outlook 2010 in Office development](/previous-versions/office/developer/office-2010/ff458122(v=office.14))|The area of the MSDN Library where you can find articles and reference documentation about developing Outlook solutions (not specific to Office development using Visual Studio).|
