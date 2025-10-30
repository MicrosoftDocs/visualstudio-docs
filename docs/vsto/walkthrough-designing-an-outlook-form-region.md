---
title: "Walkthrough: Design an Outlook form region"
description: Learn how you can design a custom Microsoft Outlook form region that appears as a new page in the Inspector window of a contact item.
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "form regions [Office development in Visual Studio], creating"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Walkthrough: Design an Outlook form region

  Custom form regions extend standard or custom Microsoft Office Outlook forms. In this walkthrough, you will design a custom form region that appears as a new page in the Inspector window of a contact item. This form region displays a map of each address that is listed for the contact, by sending the address information to the Windows Live Local Search Web site. For information about form regions, see [Create Outlook form regions](../vsto/creating-outlook-form-regions.md).

 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]

 This walkthrough illustrates the following tasks:

- Creating a new Outlook VSTO Add-in project.

- Adding a form region to the VSTO Add-in project.

- Designing the layout of the form region.

- Customizing the behavior of the form region.

- Testing the Outlook form region.

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

-  Outlook 2010  or newer.

  ![link to video](../vsto/media/playvideo.gif "link to video") For a video version of this topic, see [Video how to: Design an Outlook form region](/previous-versions/visualstudio/visual-studio-2008/cc837160(v=vs.90)).

## Create a new Outlook VSTO Add-in project
 First create a basic VSTO Add-in project.

### To create a new Outlook VSTO Add-in project

1. In Visual Studio, create an Outlook VSTO Add-in project with the name **MapItAddIn**.

2. In the **New Project** dialog box, select **Create directory for solution**.

3. Save the project to any directory.

     For more information, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

## Add a form region to the Outlook VSTO Add-in project
 An Outlook VSTO Add-in solution can contain one or more Outlook form region items. Add a form region item to your project by using the **New Outlook Form Region** wizard.

### To add a form region to the Outlook VSTO Add-in project

1. In **Solution Explorer**, select the **MapItAddIn** project.

2. On the **Project** menu, click **Add New Item**.

3. In the **Add New Item** dialog box, select **Outlook Form Region**, name the file **MapIt**, and then click **Add**.

     The **NewOutlook Form Region** wizard starts.

4. On the **Select how you want to create the form region** page, click **Design a new form region**, and then click **Next**.

5. On the **Select the type of form region you want to create** page, click **Separate**, and then click **Next**.

     A *separate* form region adds a new page to an Outlook form. For more information about form region types, see [Create Outlook form regions](../vsto/creating-outlook-form-regions.md).

6. On the **Supply descriptive text and select your display preferences** page, type **Map It** in the **Name** box.

     This name appears on the Ribbon of the Inspector window when the contact item is open.

7. Select **Inspectors that are in compose mode** and **Inspectors that are in read mode**, and then click **Next**.

8. On the **Identify the message classes that will display this form region** page, clear **Mail Message**, select **Contact**, and then click **Finish**.

     A *MapIt.cs* or *MapIt.vb* file is added to your project.

## Design the layout of the form region
 Develop form regions visually by using the *form region designer*. You can drag managed controls to the form region designer surface. Use the designer and the **Properties** window to adjust control layout and appearance.

### To design the layout of the form region

1. In **Solution Explorer**, expand the **MapItAddIn** project, and then double-click *MapIt.cs* or *MapIt.vb* to open the Form Region Designer.

2. Right-click the designer, and then click **Properties**.

3. In the **Properties** window, set **Size** to **664, 469**.

     This ensures that the form region will be large enough to display a map.

4. On the **View** menu, click **Toolbox**.

5. From the **Common Controls** tab of the **Toolbox**, add a **WebBrowser** to the form region.

     The **WebBrowser** will display a map of each address that is listed for the contact.

## Customize the behavior of the form region
 Add code to form region event handlers to customize the way a form region behaves at run time. For this form region, the code examines the properties of an Outlook item and determines whether to display the Map It form region. If it displays the form region, the code navigates to Windows Live Local Search and loads a map of each address listed in the Outlook contact item.

### To customize the behavior of the form region

1. In **Solution Explorer**, right-click *MapIt.cs* or *MapIt.vb*, and then click **View Code**.

    *MapIt.cs* or *MapIt.vb* opens in the Code Editor.

2. Expand the **Form Region Factory** code region.

    The form region factory class named `MapItFactory` is exposed.

3. Add the following code to the `MapItFactory_FormRegionInitializing` event handler. This event handler is called when the user opens a contact item. The following code determines whether the contact item contains an address. If the contact item does not contain an address, this code sets the <xref:System.ComponentModel.CancelEventArgs.Cancel%2A> property of the <xref:Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs> class to **true** and the form region is not displayed. Otherwise, the VSTO Add-in raises the <xref:Microsoft.Office.Tools.Outlook.FormRegionControl.FormRegionShowing> event and displays the form region.

    ### [C#](#tab/csharp)
    :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_Outlook_FR_Separate_O12/MapIt.cs" id="Snippet1":::

    ### [VB](#tab/vb)
    :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_Outlook_FR_Separate_O12/MapIt.vb" id="Snippet1":::
    ---

4. Add the following code to the <xref:Microsoft.Office.Tools.Outlook.FormRegionControl.FormRegionShowing> event handler. This code performs the following tasks:

   - Concatenates each address in the contact item and creates a URL string.

   - Calls the <xref:System.Windows.Forms.WebBrowser.Navigate%2A> method of the <xref:System.Windows.Forms.WebBrowser> object and passes the URL string as a parameter.

     The Local Search Web site appears in the Map It form region and presents each address in the scratch pad.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_Outlook_FR_Separate_O12/MapIt.cs" id="Snippet2":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_Outlook_FR_Separate_O12/MapIt.vb" id="Snippet2":::
     ---

## Test the Outlook form region
 When you run the project, Visual Studio opens Outlook. Open a contact item to view the Map It form region. The Map It form region appears as a page in the form of any contact item that contains an address.

### To test the Map It form region

1. Press **F5** to run the project.

     Outlook opens.

2. In Outlook, on the **Home** tab, click **New Items**, and then click **Contact**.

3. In the contact form, type **Ann Beebe** as the contact name, and then specify the following three addresses.

    |Address Type|Address|
    |------------------|-------------|
    |**Business**|**4567 Main St. Buffalo, NY**|
    |**Home**|**1234 North St. Buffalo, NY**|
    |**Other**|**3456 Main St. Seattle, WA**|

4. Save and close the contact item.

5. Reopen the **Ann Beebe** contact item.

    In Outlook, this can be done in the **Find** group by either opening the Address Book for Contacts or typing Ann Beebe into **Search People**.

6. In the **Show** group of the item's Ribbon, click **Map It** to open the Map It form region.

     The Map It form region appears, and displays the Local Search Web site. The **Business**, **Home**, and **Other** addresses appear in the scratch pad. In the scratch pad, select an address that you want to map.

## Next steps
 You can learn more about how to customize the UI of an Outlook application from these topics:

- To learn about how to customize the ribbon of an Outlook item, see [Customize a ribbon for Outlook](../vsto/customizing-a-ribbon-for-outlook.md).

## Related content
- [Access a form region at run time](../vsto/accessing-a-form-region-at-run-time.md)
- [Create Outlook form regions](../vsto/creating-outlook-form-regions.md)
- [Guidelines to create Outlook form regions](/previous-versions/visualstudio/visual-studio-2017/vsto/guidelines-for-creating-outlook-form-regions)
- [Walkthrough: Import a form region that is designed in Outlook](/previous-versions/visualstudio/visual-studio-2017/vsto/walkthrough-importing-a-form-region-that-is-designed-in-outlook)
- [How to: Add a form region to an Outlook Add-in project](../vsto/how-to-add-a-form-region-to-an-outlook-add-in-project.md)
- [Associate a form region with an Outlook message class](../vsto/associating-a-form-region-with-an-outlook-message-class.md)
- [Custom actions in Outlook form regions](/previous-versions/visualstudio/visual-studio-2017/vsto/custom-actions-in-outlook-form-regions)
- [How to: Prevent Outlook from displaying a form region](/previous-versions/visualstudio/visual-studio-2017/vsto/how-to-prevent-outlook-from-displaying-a-form-region)
