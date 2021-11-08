---
title: "How to: Re-enable a VSTO Add-in that has been disabled"
description: Learn how you can use Visual Studio to re-enable a VSTO Add-in that has been disabled in a Microsoft Office application.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
f1_keywords:
  - "VST.Warning.DisabledAddIn"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "disabled add-ins"
  - "add-ins [Office development in Visual Studio], disabled"
  - "add-ins [Office development in Visual Studio], enabling"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Re-enable a VSTO Add-in that has been disabled
  Microsoft Office applications can disable VSTO Add-ins that behave unexpectedly. If an application does not load your VSTO Add-in when you try to debug it, the application might have hard disabled or soft disabled your VSTO Add-in.

 [!INCLUDE[appliesto_allapp](../vsto/includes/appliesto-allapp-md.md)]

## Hard-disabled VSTO Add-ins
 Hard disabling can occur when a VSTO Add-in causes the application to close unexpectedly. It might also occur on your development computer if you stop the debugger while the <xref:Microsoft.Office.Tools.AddIn.Startup> event handler in your VSTO Add-in is executing.

### To re-enable a VSTO Add-in

1. In the application, click the **File** tab.

2. Click the *ApplicationName* **Options** button.

3. In the categories pane, click **Add-ins**.

4. In the details pane, verify that the VSTO Add-in appears in the **Disabled Application Add-ins** list.

     The **Name** column specifies the name of the assembly, and the **Location** column specifies the full path of the application manifest.

5. In the **Manage** box, click **Disabled Items**, and then click **Go**.

6. Select the VSTO Add-in and click **Enable**.

7. Click **Close**.

## Soft-disabled VSTO Add-ins
 Soft disabling can occur when a VSTO Add-in produces an error that does not cause the application to unexpectedly close. For example, an application might soft disable a VSTO Add-in if it throws an unhandled exception while the <xref:Microsoft.Office.Tools.AddIn.Startup> event handler is executing.

> [!NOTE]
> When you re-enable a soft-disabled VSTO Add-in, the application immediately attempts to load the VSTO Add-in. If the problem that initially caused the application to soft disable the VSTO Add-in has not been fixed, the application will soft disable the VSTO Add-in again.

### To re-enable a VSTO Add-in

1. In the application, click the **File** tab.

2. Click the *ApplicationName* **Options** button.

3. In the categories pane, click **Add-ins**.

4. In the details pane, verify that the VSTO Add-in appears in the **Inactive Application Add-ins** list.

     The **Name** column specifies the name of the assembly, and the **Location** column specifies the full path of the application manifest.

5. In the **Manage** box, click **COM Add-ins**, and then click **Go**.

6. In the **COM Add-Ins** dialog box, select the check box next to the disabled VSTO Add-in.

7. Click **OK**.

## See also
- [Build Office solutions](../vsto/building-office-solutions.md)
- [Debug Office projects](../vsto/debugging-office-projects.md)
- [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md)
