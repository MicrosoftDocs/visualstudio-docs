---
title: "How to: Add a form region to an Outlook Add-in project"
ms.date: "02/02/2017"
ms.topic: "conceptual"
f1_keywords:
  - "VSTO.NewFormRegionWizard.Page1"
  - "VSTO.NewFormRegionWizard.Page3"
  - "VSTO.NewFormRegionWizard.Page2"
  - "VSTO.NewFormRegionWizard.Page0"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "form regions [Office development in Visual Studio], adding"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Add a form region to an Outlook Add-in project
  Create a form region to extend a standard or custom Microsoft Office Outlook form by using the **New Outlook Form Region** wizard. You can create a new form region and design the user interface in Visual Studio, or you can import a form region that was designed in Outlook and add Visual Basic or C# code.

 If you have an Outlook form region that you used in another Outlook project, you can reuse it in your current Outlook VSTO Add-in project by using the **Add Existing Item** dialog box. For more information, see [Create Outlook form regions](../vsto/creating-outlook-form-regions.md).

 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]

### To add a new form region to an Outlook project

1. Open or create an Outlook VSTO Add-in project in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)]. For more information, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

2. In **Solution Explorer**, select the Outlook VSTO Add-in project node.

3. On the **Project** menu, click **Add New Item**.

4. In the **Add New Item** dialog box, select **Outlook Form Region**.

5. Type a name for the form region in the **Name** box, and then click **Add**.

     The **NewOutlook Form Region** wizard starts.

6. On the **Select how you want to create the form region** page, select whether you want to design the form region by dragging managed controls onto a visual designer or import a form region that was designed in Outlook.

    > [!NOTE]
    > If you choose to import a form region that was designed in Outlook, then you must specify the location of an Outlook Form Storage (*.ofs*) file. You cannot add managed controls to a form region that you design in Outlook; you can only add code behind the existing UI. For more information, see [Create Outlook form regions](../vsto/creating-outlook-form-regions.md).

7. On the **Select the type of form region you want to create** page, review the form region types and select one, and then click **Next**. For more information about form region types, see [Create Outlook form regions](../vsto/creating-outlook-form-regions.md).

8. On the **Supply descriptive text and select your display preferences** page, in the **Name** box, type a name for the form region. For the replacement and replace-all form region types, the **Title** and **Description** boxes are also available.

     For information about where the name, title, and description appear in Outlook when you deploy the form region, see [Create Outlook form regions](../vsto/creating-outlook-form-regions.md).

9. Select one or more display modes in which you want the form region to appear.

     All form region types can appear in Inspectors, in compose mode (for creating items) and in read mode (for viewing items). Adjoining, replacement, and replace-all form region types can also appear in the Reading Pane.

10. Click **Next**.

11. On the **Identify the message classes that will display this form region** page, select standard Outlook message classes or type the names of one or more custom message classes, and then click **Finish**. For more information, see [Associate a form region with an Outlook message class](../vsto/associating-a-form-region-with-an-outlook-message-class.md).

## See also
- [Access a form region at run time](../vsto/accessing-a-form-region-at-run-time.md)
- [Outlook solutions](../vsto/outlook-solutions.md)
- [Create Outlook form regions](../vsto/creating-outlook-form-regions.md)
- [Guidelines for create Outlook form regions](../vsto/guidelines-for-creating-outlook-form-regions.md)
- [Walkthrough: Design an Outlook form region](../vsto/walkthrough-designing-an-outlook-form-region.md)
- [Walkthrough: Import a form region that is designed in Outlook](../vsto/walkthrough-importing-a-form-region-that-is-designed-in-outlook.md)
- [Custom actions in Outlook form regions](../vsto/custom-actions-in-outlook-form-regions.md)
