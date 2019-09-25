---
title: "Access a form region at run time"
ms.date: 02/02/2017
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Inspectors [Office development in Visual Studio]"
  - "Explorers [Office development in Visual Studio]"
  - "form regions [Office development in Visual Studio], accessing at run time"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Access a form region at run time

|Applies to|
|----------------|
|The information in this topic applies only to the following project types and versions of Microsoft Office. For more information, see [Features available by Office application and project type](../vsto/features-available-by-office-application-and-project-type.md).<br /><br /> **Project type**<br /><br /> -   VSTO Add-in projects<br /><br /> **Microsoft Office version**<br /><br /> -   [!INCLUDE[Outlook_14_short](../vsto/includes/outlook-14-short-md.md)]|

 Use the `Globals` class to access form regions from anywhere within your Outlook project. For more information about the `Globals` class, see [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md).

 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]

## Access form regions that appear in a specific Outlook Inspector window
 To access all form regions that appear in a specific Outlook Inspector, call the `FormRegions` property of the `Globals` class and pass in an <xref:Microsoft.Office.Interop.Outlook.Inspector> object that represents the Inspector.

 The following example gets the collection of form regions that appear in the Inspector that currently has focus. This example then accesses a form region in the collection named `formRegion1` and sets the text that appears in a text box to `Hello World`.

 [!code-vb[Trin_Outlook_FR_Access#2](../vsto/codesnippet/VisualBasic/Trin_Outlook_FR_Access_O12/ThisAddIn.vb#2)]
 [!code-csharp[Trin_Outlook_FR_Access#2](../vsto/codesnippet/CSharp/Trin_Outlook_FR_Access_O12/ThisAddIn.cs#2)]

## Access form regions that appear in a specific Outlook Explorer window
 To access all form regions that appear in a specific Outlook Explorer, call the `FormRegions` property of the `Globals` class and pass in an <xref:Microsoft.Office.Interop.Outlook.Explorer> object that represents the Explorer.

 The following example gets the collection of form regions that appear in the Explorer that currently has focus. This example then accesses a form region in the collection named `formRegion1` and sets the text that appears in a text box to `Hello World`.

 [!code-vb[Trin_Outlook_FR_Access#3](../vsto/codesnippet/VisualBasic/Trin_Outlook_FR_Access_O12/ThisAddIn.vb#3)]
 [!code-csharp[Trin_Outlook_FR_Access#3](../vsto/codesnippet/CSharp/Trin_Outlook_FR_Access_O12/ThisAddIn.cs#3)]

## Access all form regions
 To access all form regions that appear in all Explorers and all Inspectors, call the `FormRegions` property of the `Globals` class.

 The following example gets the collection of form regions that appear in all Explorers and all Inspectors. This example then accesses a form region named `formRegion1` and sets the text that appears in a text box to `Hello World`.

 [!code-vb[Trin_Outlook_FR_Access#1](../vsto/codesnippet/VisualBasic/Trin_Outlook_FR_Access_O12/ThisAddIn.vb#1)]
 [!code-csharp[Trin_Outlook_FR_Access#1](../vsto/codesnippet/CSharp/Trin_Outlook_FR_Access_O12/ThisAddIn.cs#1)]

## Access controls on a form region
 To access controls on a form region by using the `Globals` class, you must make the controls accessible to code outside of the form region code file.

### Form regions designed in the form region designer
 For C#, change the modifier of each control that you want to access. To do this, select each control in the form region designer and change the **Modifiers** property to **Internal** or **public** in the **Properties** window. For example, if you change the **Modifier** property of `textBox1` to **Internal**, you can access `textBox1` by typing `Globals.FormRegions.FormRegion1.textBox1`.

 For Visual Basic, you do not need to change the modifier.

### Imported form regions
 When you import a form region that was designed in Outlook, the access modifier of each control on the form region becomes private. Because you cannot use the form region designer to modify an imported form region, there is no way to change the modifier of a control in the **Properties** window.

 To enable access to a control from outside the form region code file, create a property in the form region code file to return that control.

 For more information about how to create properties in C#, see [How to: Declare and use read write properties &#40;C&#35; programming guide&#41;](/dotnet/csharp/programming-guide/classes-and-structs/how-to-declare-and-use-read-write-properties).

 For more information about how to create properties in Visual Basic, see [How to: Create a property (Visual Basic)](/dotnet/visual-basic/programming-guide/language-features/procedures/how-to-create-a-property).

## See also
- [Guidelines to create Outlook form regions](../vsto/guidelines-for-creating-outlook-form-regions.md)
- [Walkthrough: Design an Outlook form region](../vsto/walkthrough-designing-an-outlook-form-region.md)
- [How to: Add a form region to an Outlook Add-in project](../vsto/how-to-add-a-form-region-to-an-outlook-add-in-project.md)
- [Custom actions in Outlook form regions](../vsto/custom-actions-in-outlook-form-regions.md)
- [Associate a form region with an Outlook message class](../vsto/associating-a-form-region-with-an-outlook-message-class.md)
- [Walkthrough: Import a form region that is designed in Outlook](../vsto/walkthrough-importing-a-form-region-that-is-designed-in-outlook.md)
- [How to: Prevent Outlook from displaying a form region](../vsto/how-to-prevent-outlook-from-displaying-a-form-region.md)
- [Create Outlook form regions](../vsto/creating-outlook-form-regions.md)
- [Access the Ribbon at run time](../vsto/accessing-the-ribbon-at-run-time.md)
