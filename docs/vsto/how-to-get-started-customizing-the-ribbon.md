---
title: "How to: Get started customizing the ribbon"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "custom Ribbon, adding Ribbon to project"
  - "Ribbon [Office development in Visual Studio], adding"
  - "Ribbon [Office development in Visual Studio], customizing"
  - "customizing the Ribbon, adding Ribbon to project"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Get started customizing the ribbon
  To customize the Ribbon of a Microsoft Office application, add a **Ribbon (Visual Designer)** or **Ribbon (XML)** item to an Office project.

 [!INCLUDE[appliesto_ribbon](../vsto/includes/appliesto-ribbon-md.md)]

### To add a ribbon to a project

1. On the **Project** Menu, click **Add New Item**.

2. In the **Add New Item** dialog box, select **Ribbon (Visual Designer)** or **Ribbon (XML)**. For more information about these templates, see [Ribbon overview](../vsto/ribbon-overview.md).

3. In the **Name** box, type a name for the Ribbon item.

    Names cannot contain the following characters:

   - Pound (#)

   - Percent (%)

   - Ampersand (&)

   - Asterisk (*)

   - Vertical bar (|)

   - Backslash (\\)

   - Colon (:)

   - Double quotation mark (")

   - Less than (\<)

   - Greater than (>)

   - Question mark (?)

   - Forward slash (/)

   - Leading or trailing spaces (' ')

   - Names reserved for Windows or DOS such as ("nul", "aux", "con", "com1", "lpt1", and so on)

4. Click **OK**.

   The Ribbon item appears in **Solution Explorer**. For information about the next steps, see [Ribbon overview](../vsto/ribbon-overview.md).

## See also
- [Access the Ribbon at run time](../vsto/accessing-the-ribbon-at-run-time.md)
- [Ribbon Designer](../vsto/ribbon-designer.md)
- [Ribbon XML](../vsto/ribbon-xml.md)
- [Walkthrough: Create a custom tab by using the Ribbon Designer](../vsto/walkthrough-creating-a-custom-tab-by-using-the-ribbon-designer.md)
- [Walkthrough: Create a custom tab by using Ribbon XML](../vsto/walkthrough-creating-a-custom-tab-by-using-ribbon-xml.md)
