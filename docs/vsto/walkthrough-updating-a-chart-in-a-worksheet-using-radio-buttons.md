---
title: "Update chart in worksheet using radio buttons"
description: Learn the basics of using radio buttons on a Microsoft Excel worksheet to give the user a way to quickly switch between options.
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "worksheets, updating using managed controls"
  - "controls [Office development in Visual Studio], updating worksheets"
  - "worksheets, using radio buttons"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Walkthrough: Updating a Chart in a Worksheet Using Radio Buttons

  This walkthrough shows the basics of using radio buttons on a Microsoft Office Excel worksheet to give the user a way to quickly switch between options. In this case, the options change the style of a chart.

 [!INCLUDE[appliesto_xlalldoc](../vsto/includes/appliesto-xlalldoc-md.md)]

 To see the result as a completed sample, see the Excel Controls Sample at [Office development samples and walkthroughs](../vsto/office-development-samples-and-walkthroughs.md).

 This walkthrough illustrates the following tasks:

- Adding a group of radio buttons to a worksheet.

- Changing the chart style when an option is selected.

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

-  Excel 2013  or  Excel 2010 .

## Add a chart to a worksheet
 You can create an Excel Workbook project that customizes an existing workbook. In this walkthrough, you will add a chart to a workbook and then use this workbook in a new Excel solution. The data source in this walkthrough is a worksheet named **Data for Chart**.

### To add the data

1. Open Microsoft Excel.

2. Right-click the **Sheet3** tab, and then click **Rename** on the shortcut menu.

3. Rename the sheet to **Data for Chart**.

4. Add the following data to **Data for Chart** with cell A4 being the upper left corner, and E8 the lower right corner.

   |Region / Quarter|Q1|Q2|Q3|Q4|
   |-|--------|--------|--------|--------|
   |West|500|550|550|600|
   |East|600|625|675|700|
   |North|450|470|490|510|
   |South|800|750|775|790|

   Next, add a chart to the first worksheet to display the data.

### To add a chart in Excel

1. On the **Insert** tab, in the **Charts** group, click **Column**, and then click **All Chart Types**.

2. In the **Insert Chart** dialog box, click **OK**.

3. On the **Design** tab, in the **Data** group, click **Select Data**.

4. In the **Select Data Source** dialog box, click in the **Chartdata range** box and clear any default selection.

5. In the **Data for Chart** sheet, select the block of cells that contains the numbers, which includes A4 in the upper left corner to E8 in the lower right corner.

6. In the **Select Data Source** dialog box, click **OK**.

7. Reposition the chart so that the upper right corner aligns with cell **E2**.

8. Save your file to drive C and name it **ExcelChart.xlsx**.

9. Exit Excel.

## Create a new project
 In this step, you will create an Excel Workbook project based on the **ExcelChart** workbook.

### To create a new project

1. Create an Excel Workbook project with the name **My Excel Chart**. In the wizard, select **Copy an existing document**.

     For more information, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

2. Click the **Browse** button and browse to the workbook you created earlier in this walkthrough.

3. Click **OK**.

     Visual Studio opens the new Excel workbook in the designer and adds the **My Excel Chart** project to **Solution Explorer**.

## Set properties of the chart
 When you create a new Excel Workbook project that uses an existing workbook, host controls are automatically created for all named ranges, list objects, and charts in the workbook. You can change the name of the <xref:Microsoft.Office.Tools.Excel.Chart> control by using the **Properties** window.

### To change the name of the Chart control

1. Select the <xref:Microsoft.Office.Tools.Excel.Chart> control in the designer and change the following properties in the **Properties** Window.

    |Property|Value|
    |--------------|-----------|
    |**Name**|**dataChart**|
    |**HasLegend**|**false**|

## Add controls
 This worksheet uses radio buttons to give users a way to quickly change the chart style. However, radio buttons need to be exclusive—when one button is selected, no other button in the group can be selected at the same time. This behavior does not happen by default when you add several radio buttons to a worksheet.

 One way to add this behavior is to group the radio buttons on a user control, write your code behind the user control, and then add the user control to the worksheet.

### To add a user control

1. Select the **My Excel Chart** project in **Solution Explorer**.

2. On the **Project** menu, click **Add New Item**.

3. In the **Add New Item** dialog box, click **User Control**, name the control **ChartOptions,** and click **Add**.

### To add radio buttons to the user control

1. If the user control is not visible in the designer, double-click **ChartOptions** in **Solution Explorer**.

2. From the **Common Controls** tab of the **Toolbox**, drag a **Radio Button** control to the user control, and change the following properties.

   | Property | Value |
   |----------|------------------|
   | **Name** | **columnChart** |
   | **Text** | **Column Chart** |

3. Add a second radio button to the user control, and change the following properties.

   | Property | Value |
   |----------|---------------|
   | **Name** | **barChart** |
   | **Text** | **Bar Chart** |

4. Add a third radio button to the user control, and change the following properties.

   | Property | Value |
   |----------|----------------|
   | **Name** | **lineChart** |
   | **Text** | **Line Chart** |

5. Add a fourth radio button to the user control, and change the following properties.

   |Property|Value|
   |--------------|-----------|
   |**Name**|**areaBlockChart**|
   |**Text**|**Area Block Chart**|

   Next, write the code to update the chart when a radio button is clicked.

## Change the chart style when a radio button is selected
 Now you can add the code to change the chart style. To do this, create a public event on the user control, add a property to set the selection type, and create an event handler for the `CheckedChanged` event of each of the radio buttons.

### To create an event and property on a user control

1. In **Solution Explorer**, right-click the user control, and then click **View Code**.

2. Add code to the `ChartOptions` class to create a `SelectionChanged` event and the `Selection` property.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingControlsExcelCS/ChartOptions.cs" id="Snippet13":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/my excel chart/ChartOptions.vb" id="Snippet13":::
     ---

### To handle the CheckedChanged event of the radio buttons

1. Set the chart type in the `CheckedChanged` event handler of the `areaBlockChart` radio button and then raise the event.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingControlsExcelCS/ChartOptions.cs" id="Snippet14":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/my excel chart/ChartOptions.vb" id="Snippet14":::
     ---

2. Set the chart type in the `CheckedChanged` event handler of the `barChart` radio button.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingControlsExcelCS/ChartOptions.cs" id="Snippet15":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/my excel chart/ChartOptions.vb" id="Snippet15":::
     ---

3. Set the chart type in the `CheckedChanged` event handler of the `columnChart` radio button.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingControlsExcelCS/ChartOptions.cs" id="Snippet16":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/my excel chart/ChartOptions.vb" id="Snippet16":::
     ---

4. Set the chart type in the `CheckedChanged` event handler of the `lineChart` radio button.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingControlsExcelCS/ChartOptions.cs" id="Snippet17":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/my excel chart/ChartOptions.vb" id="Snippet17":::
     ---

5. In C#, you must add event handlers for the radio buttons. You can add the code to the `ChartOptions` constructor, beneath the call to `InitializeComponent`. For information about how to create event handlers, see [How to: Create event handlers in Office projects](../vsto/how-to-create-event-handlers-in-office-projects.md).

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingControlsExcelCS/ChartOptions.cs" id="Snippet18":::

## Add the user control to the worksheet
 When you build the solution, the new user control is automatically added to the **Toolbox**. You can then drag the control from the **Toolbox** to your worksheet.

### To add the user control your worksheet

1. On the **Build** menu, click **Build Solution**.

     The **ChartOptions** user control is added to the **Toolbox**.

2. In **Solution Explorer**, right-click **Sheet1.vb** or **Sheet1.cs**, and then click **View Designer**.

3. Drag the **ChartOptions** control from the **Toolbox** to the worksheet.

     A new control named `my_Excel_Chart_ChartOptions1` is added to your project.

4. Change the name of the control to **ChartOptions1**.

## Change the chart type
 To change the chart type, create an event handler that sets the style according to the option selected in the user control.

### To change the type of chart that is displayed in the worksheet

1. Add the following event handler to the `Sheet1` class.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingControlsExcelCS/Sheet1.cs" id="Snippet19":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/my excel chart/Sheet1.vb" id="Snippet19":::
     ---

2. In C#, you must add an event handler for the user control to the <xref:Microsoft.Office.Tools.Excel.Worksheet.Startup> event as shown below. For information about how to create event handlers, see [How to: Create event handlers in Office projects](../vsto/how-to-create-event-handlers-in-office-projects.md).

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingControlsExcelCS/Sheet1.cs" id="Snippet20":::

## Test the application
 You can now test your workbook to verify that the chart is styled correctly when you select a radio button.

### To test your workbook

1. Press **F5** to run your project.

2. Select various radio buttons.

3. Confirm that the chart style changes to match the selection.

## Next steps
 This walkthrough shows the basics of using radio buttons and chart styles on worksheets. Here are some tasks that might come next:

- Deploying the project. For more information, see [Deploy an Office solution](../vsto/deploying-an-office-solution.md).

- Using a button to populate a text box. For more information, see [Walkthrough: Display text in a text box in a worksheet using a button](../vsto/walkthrough-displaying-text-in-a-text-box-in-a-worksheet-using-a-button.md).

- Change formatting on a worksheet by using check boxes. 

## Related content
- [Walkthroughs using Excel](../vsto/walkthroughs-using-excel.md)
