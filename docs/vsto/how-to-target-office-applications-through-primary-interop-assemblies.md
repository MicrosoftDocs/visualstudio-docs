---
title: "Target Office apps through primary interop assemblies"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "assemblies [Office development in Visual Studio], PIA references"
  - "primary interop assemblies [Office development in Visual Studio], adding references to"
  - "Office primary interop assemblies in Visual Studio, adding references to"
  - "Office applications [Office development in Visual Studio], automating"
  - "application development [Office development in Visual Studio], automating"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Target Office applications through primary interop assemblies
  When you create a new Office project, Visual Studio automatically adds references to the Microsoft Office primary interop assemblies (PIAs) that are required to build your project. You must add references to other PIAs in the following scenarios:

- You want to use features of other Microsoft Office applications in your project. For example, you might want to use features of Microsoft Office Excel in a project for Microsoft Office Word.

- You want to automate Microsoft Office applications that do not have dedicated projects in Visual Studio, such as Microsoft Office Access.

  [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## To add a reference to a primary interop assembly

1. Open your Office project and select the project name in **Solution Explorer**.

2. On the **Project** menu, click **Add Reference**.

3. On the **Framework** tab, select the PIA you want in the **Component Name** list. For more information about the available Microsoft Office primary interop assemblies, see [Office primary interop assemblies](../vsto/office-primary-interop-assemblies.md).

     If the project targets the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later, the **Embed Interop Types** property for the assembly reference is set to **True** by default. By using this setting, your solution does not require the PIA on end-user computers. For more information, see [Design and create Office solutions](../vsto/designing-and-creating-office-solutions.md).

    > [!NOTE]
    > In Office projects, always add references to Office PIAs by using the **.NET** tab of the **Add Reference** dialog rather than the **COM** tab. For more information, see [Office primary interop assemblies](../vsto/office-primary-interop-assemblies.md).

4. Click **OK**.

     The assembly name appears in the **References** folder of **Solution Explorer**.

## See also
- [Office primary interop assemblies](../vsto/office-primary-interop-assemblies.md)
- [Write code in Office solutions](../vsto/writing-code-in-office-solutions.md)
- [Develop Office solutions](../vsto/developing-office-solutions.md)
- [How to: Install Office primary interop assemblies](../vsto/how-to-install-office-primary-interop-assemblies.md)
