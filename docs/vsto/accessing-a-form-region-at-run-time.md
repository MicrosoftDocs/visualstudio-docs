---
title: "Accessing a Form Region at Run Time | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Inspectors [Office development in Visual Studio]"
  - "Explorers [Office development in Visual Studio]"
  - "form regions [Office development in Visual Studio], accessing at run time"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Accessing a Form Region at Run Time
  
  
|Applies to|  
|----------------|  
|The information in this topic applies only to the following project types and versions of Microsoft Office. For more information, see [Features Available by Office Application and Project Type](../vsto/features-available-by-office-application-and-project-type.md).<br /><br /> **Project type**<br /><br /> -   VSTO Add-in projects<br /><br /> **Microsoft Office version**<br /><br /> -   [!INCLUDE[Outlook_14_short](../vsto/includes/outlook-14-short-md.md)]|  
  
 Use the `Globals` class to access form regions from anywhere within your Outlook project. For more information about the `Globals` class, see [Global Access to Objects in Office Projects](../vsto/global-access-to-objects-in-office-projects.md).  
  
 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]  
  
## Accessing Form Regions That Appear in a Specific Outlook Inspector Window  
 To access all form regions that appear in a specific Outlook Inspector, call the `FormRegions` property of the `Globals` class and pass in an <xref:Microsoft.Office.Interop.Outlook.Inspector> object that represents the Inspector.  
  
 The following example gets the collection of form regions that appear in the Inspector that currently has focus. This example then accesses a form region in the collection named `formRegion1` and sets the text that appears in a text box to `Hello World`.  
  
 [!code-vb[Trin_Outlook_FR_Access#2](../vsto/codesnippet/VisualBasic/Trin_Outlook_FR_Access_O12/ThisAddIn.vb#2)]
 [!code-csharp[Trin_Outlook_FR_Access#2](../vsto/codesnippet/CSharp/Trin_Outlook_FR_Access_O12/ThisAddIn.cs#2)]  
  
## Accessing Form Regions That Appear in a Specific Outlook Explorer Window  
 To access all form regions that appear in a specific Outlook Explorer, call the `FormRegions` property of the `Globals` class and pass in an <xref:Microsoft.Office.Interop.Outlook.Explorer> object that represents the Explorer.  
  
 The following example gets the collection of form regions that appear in the Explorer that currently has focus. This example then accesses a form region in the collection named `formRegion1` and sets the text that appears in a text box to `Hello World`.  
  
 [!code-vb[Trin_Outlook_FR_Access#3](../vsto/codesnippet/VisualBasic/Trin_Outlook_FR_Access_O12/ThisAddIn.vb#3)]
 [!code-csharp[Trin_Outlook_FR_Access#3](../vsto/codesnippet/CSharp/Trin_Outlook_FR_Access_O12/ThisAddIn.cs#3)]  
  
## Accessing All Form Regions  
 To access all form regions that appear in all Explorers and all Inspectors, call the `FormRegions` property of the `Globals` class.  
  
 The following example gets the collection of form regions that appear in all Explorers and all Inspectors. This example then accesses a form region named `formRegion1` and sets the text that appears in a text box to `Hello World`.  
  
 [!code-vb[Trin_Outlook_FR_Access#1](../vsto/codesnippet/VisualBasic/Trin_Outlook_FR_Access_O12/ThisAddIn.vb#1)]
 [!code-csharp[Trin_Outlook_FR_Access#1](../vsto/codesnippet/CSharp/Trin_Outlook_FR_Access_O12/ThisAddIn.cs#1)]  
  
## Accessing Controls on a Form Region  
 To access controls on a form region by using the `Globals` class, you must make the controls accessible to code outside of the form region code file.  
  
### Form Regions Designed in the Form Region Designer  
 For C#, change the modifier of each control that you want to access. To do this, select each control in the form region designer and change the **Modifiers** property to **Internal** or **public** in the **Properties** window. For example, if you change the **Modifier** property of `textBox1` to **Internal**, you can access `textBox1` by typing `Globals.FormRegions.FormRegion1.textBox1`.  
  
 For Visual Basic, you do not need to change the modifier.  
  
### Imported Form Regions  
 When you import a form region that was designed in Outlook, the access modifier of each control on the form region becomes private. Because you cannot use the form region designer to modify an imported form region, there is no way to change the modifier of a control in the **Properties** window.  
  
 To enable access to a control from outside the form region code file, create a property in the form region code file to return that control.  
  
 For more information about how to create properties in C#, see [How to: Declare and Use Read Write Properties &#40;C&#35; Programming Guide&#41;](/dotnet/csharp/programming-guide/classes-and-structs/how-to-declare-and-use-read-write-properties).  
  
 For more information about how to create properties in Visual Basic, see [How to: Create a Property (Visual Basic)](/dotnet/visual-basic/programming-guide/language-features/procedures/how-to-create-a-property).  
  
## See Also  
 [Guidelines for Creating Outlook Form Regions](../vsto/guidelines-for-creating-outlook-form-regions.md)   
 [Walkthrough: Designing an Outlook Form Region](../vsto/walkthrough-designing-an-outlook-form-region.md)   
 [How to: Add a Form Region to an Outlook Add-in Project](../vsto/how-to-add-a-form-region-to-an-outlook-add-in-project.md)   
 [Custom Actions in Outlook Form Regions](../vsto/custom-actions-in-outlook-form-regions.md)   
 [Associating a Form Region with an Outlook Message Class](../vsto/associating-a-form-region-with-an-outlook-message-class.md)   
 [Walkthrough: Importing a Form Region That Is Designed in Outlook](../vsto/walkthrough-importing-a-form-region-that-is-designed-in-outlook.md)   
 [How to: Prevent Outlook from Displaying a Form Region](../vsto/how-to-prevent-outlook-from-displaying-a-form-region.md)   
 [Creating Outlook Form Regions](../vsto/creating-outlook-form-regions.md)   
 [Accessing the Ribbon at Run Time](../vsto/accessing-the-ribbon-at-run-time.md)  
  
  