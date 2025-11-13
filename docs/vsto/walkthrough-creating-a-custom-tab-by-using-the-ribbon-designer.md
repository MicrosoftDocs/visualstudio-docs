---
title: Create a custom tab by using the Ribbon Designer
description: Create an actions pane with a custom tab by using the Ribbon Designer, add and position controls, and configure button actions to hide and display the pane.
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "actions panes [Office development in Visual Studio], controlling from Ribbon"
  - "Ribbon [Office development in Visual Studio], customizing"
  - "Ribbon Designer [Office development in Visual Studio]"
  - "customizing the Ribbon, tabs"
  - "custom Ribbon, tabs"
  - "Custom tab [Office development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Walkthrough: Create a custom tab by using the Ribbon Designer

  By using the Ribbon Designer, you can create a custom tab and then add and position controls on it.

 [!INCLUDE[appliesto_xlalldoc](../vsto/includes/appliesto-xlalldoc-md.md)]

 This walkthrough illustrates the following tasks:

- [Create actions panes](#BKMK_CreateActionsPanes).

- [Create a custom tab](#BKMK_CreateCustomTab).

- [Hide and show actions panes by using buttons on the custom tab](#BKMK_HideShowActionsPane).

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

- Microsoft Excel

## Create an Excel workbook project
 The steps for using the Ribbon Designer are almost identical for all Office applications. This example uses an Excel workbook.

### To create an Excel workbook project

- Create an Excel workbook project with the name **MyExcelRibbon**. For more information, see [How to: Create Office Projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

     Visual Studio opens the new workbook in the designer and adds the **MyExcelRibbon** project to **Solution Explorer**.

## <a name="BKMK_CreateActionsPanes"></a> Create actions panes
 Add two custom actions panes to the project. You will later add buttons that show and hide these actions panes to the custom tab.

### To create actions panes

1. On the **Project** menu, choose **Add New Item**.

2. In the **Add New Item** dialog box, select **ActionsPaneControl**, and then choose **Add**.

     The **ActionsPaneControl1.cs** or **ActionsPaneControl1.vb** file opens in the designer.

3. From the **Common Controls** tab of the **Toolbox**, add a label to the designer surface.

4. In the **Properties** window, set the **Text** property of label1 to **Actions Pane 1**.

5. Repeat steps 1 through 5 to create a second actions pane and label. Set the **Text** property of the second label to **Actions Pane 2**.

## <a name="BKMK_CreateCustomTab"></a> Create a custom tab
 One of the Office application design guidelines is that users should always have control of the Office application UI. To add this capability for the actions panes, you can add buttons that show and hide each actions pane from a custom tab on the ribbon. To create a custom tab, add a **Ribbon (Visual Designer)** item to the project. The designer helps you add and position controls, set control properties, and handle control events.

### To create a custom tab

1. On the **Project** menu, choose **Add New Item**.

2. In the **Add New Item** dialog box, select **Ribbon (Visual Designer)**.

3. Change the name of the new ribbon to **MyRibbon**, and choose **Add**.

     The **MyRibbon.cs** or **MyRibbon.vb** file opens in the Ribbon Designer and displays a default tab and group.

4. In the Ribbon Designer, choose the default tab.

5. In the **Properties** window, expand the **ControlId** property, and then set the **ControlIdType** property to **Custom**.

6. Set the **Label** property to **My Custom Tab**.

7. In the Ribbon Designer, choose **group1**.

8. In the **Properties** window, set **Label** to **Actions Pane Manager**.

9. From the **Office Ribbon Controls** tab of the **Toolbox**, drag a button onto **group1**.

10. Select **button1**.

11. In the **Properties** window, set **Label** to **Show Actions Pane 1**.

12. Add a second button to **group1**, and set the **Label** property to **Show Actions Pane 2**.

13. From the **Office Ribbon Controls** tab of the **Toolbox**, drag a **ToggleButton** control onto **group1**.

14. Set the **Label** property to **Hide Actions Pane**.

## <a name="BKMK_HideShowActionsPane"></a> Hide and show actions panes by using buttons on the custom tab
 The last step is to add code that responds to the user. Add event handlers for the <xref:Microsoft.Office.Tools.Ribbon.RibbonButton.Click> events of the two buttons and the <xref:Microsoft.Office.Tools.Ribbon.RibbonToggleButton.Click> event of the toggle button. Add code to these event handlers to enable hiding and showing the actions panes.

### To hide and show actions panes by using buttons in the custom tab

1. In **Solution Explorer**, open the shortcut menu for *MyRibbon.cs* or *MyRibbon.vb*, and then choose **View Code**.

2. Add the following code to the top of the `MyRibbon` class. This code creates two actions pane objects.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_Ribbon_Custom_Tab/MyRibbon.cs" id="Snippet1":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_Ribbon_Custom_Tab/MyRibbon.vb" id="Snippet1":::
     ---

3. Replace the `MyRibbon_Load` method with the following code. This code adds the actions pane objects to the <xref:Microsoft.Office.Tools.ActionsPane.Controls%2A> collection and hides the objects from view. The Visual C# code also attaches delegates to several ribbon control events.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_Ribbon_Custom_Tab/MyRibbon.cs" id="Snippet2":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_Ribbon_Custom_Tab/MyRibbon.vb" id="Snippet2":::
     ---

4. Add the following three event handler methods to the `MyRibbon` class. These methods handle the <xref:Microsoft.Office.Tools.Ribbon.RibbonButton.Click> events of the two buttons and the <xref:Microsoft.Office.Tools.Ribbon.RibbonToggleButton.Click> event of the toggle button. The event handlers for button1 and button2 show alternate actions panes. The event handler for toggleButton1 shows and hides the active actions pane.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_Ribbon_Custom_Tab/MyRibbon.cs" id="Snippet3":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_Ribbon_Custom_Tab/MyRibbon.vb" id="Snippet3":::
     ---

## Test the custom Tab
 When you run the project, Excel starts, and the **My Custom Tab** tab appears on the ribbon. Choose the buttons on **My Custom Tab** to show and hide the actions panes.

### To test the custom tab

1. Press **F5** to run your project.

2. Choose the **My Custom Tab** tab.

3. In the **Custom Actions Pane Manager** group, choose **Show Actions Pane 1**.

     The actions pane appears and displays the label **Actions Pane 1**.

4. Choose **Show Actions Pane 2**.

     The actions pane appears and displays the label **Actions Pane 2**.

5. Choose **Hide Actions Pane**.

     The actions panes are no longer visible.

## Next steps
 You can learn more about how to customize the Office UI from these topics:

- Add context-based UI to any document-level customization. For more information, see [Actions pane overview](../vsto/actions-pane-overview.md).

- Extend a standard or custom Microsoft Office Outlook form. For more information, see [Walkthrough: Design an Outlook form region](../vsto/walkthrough-designing-an-outlook-form-region.md).

## Related content
- [Access the ribbon at run time](../vsto/accessing-the-ribbon-at-run-time.md)
- [Ribbon overview](../vsto/ribbon-overview.md)
- [Ribbon Designer](../vsto/ribbon-designer.md)
- [Customize a ribbon for Outlook](../vsto/customizing-a-ribbon-for-outlook.md)
- [How to: Get started customizing the ribbon](../vsto/how-to-get-started-customizing-the-ribbon.md)
- [How to: Change the position of a tab on the ribbon](../vsto/how-to-change-the-position-of-a-tab-on-the-ribbon.md)
- [How to: Customize a built-in tab](../vsto/how-to-customize-a-built-in-tab.md)
- [How to: Add controls to the backstage view](../vsto/how-to-add-controls-to-the-backstage-view.md)
- [Ribbon object model overview](../vsto/ribbon-object-model-overview.md)
