---
title: "How to: Show Add-in user interface errors"
description: Learn how you can use Visual Studio to programmatically show VTSO Add-in user interface errors in Microsoft Office applications.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "add-ins [Office development in Visual Studio], user interface errors"
  - "errors [Office development in Visual Studio], user interface errors"
  - "user interfaces [Office development in Visual Studio], errors"
  - "application-level add-ins [Office development in Visual Studio], user interface errors"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Show Add-in user interface errors
  By default, if a VSTO Add-in attempts to manipulate the Microsoft Office user interface (UI) and fails, no error message is displayed. However, you can configure Microsoft Office applications to display messages for errors that relate to the UI. You can use these messages to help determine why a custom ribbon does not appear, or why a ribbon appears but no controls appear.

 [!INCLUDE[appliesto_ribbon](../vsto/includes/appliesto-ribbon-md.md)]

## To show VSTO Add-in user interface errors

1. Start the application.

2. Click the **File** tab.

3. Click **Options**.

4. In the categories pane, click **Advanced**.

5. In the details pane, select **Show VSTO Add-in user interface errors**, and then click **OK**.

    > [!NOTE]
    > For Outlook, the **Show VSTO Add-in user interface errors** checkbox is located in the **Developer** section of the details pane. For other applications, the checkbox is located in the **General** section of the details pane.

## See also
- [Office UI customization](../vsto/office-ui-customization.md)
- [Create Outlook form regions](../vsto/creating-outlook-form-regions.md)
- [Ribbon overview](../vsto/ribbon-overview.md)
- [Actions pane overview](../vsto/actions-pane-overview.md)
