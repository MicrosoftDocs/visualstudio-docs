---
title: "Walkthrough: Creating a Web Part for SharePoint | Microsoft Docs"
description: Create a web part for SharePoint. Web parts let users directly change the content, appearance, and behavior of SharePoint site pages by using a browser.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Web Parts [SharePoint development in Visual Studio], developing"
  - "Web Parts [SharePoint development in Visual Studio], creating"
  - "Web Parts [SharePoint development in Visual Studio], designing"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# Walkthrough: Create a web part for SharePoint

Web Parts enable users to directly modify the content, appearance, and behavior of SharePoint site pages by using a browser. This walkthrough shows you how to create a Web Part by using the **Web Part** item template in Visual Studio 2010.

The Web Part displays employees in a data grid. The user specifies the location of the file that contains the employee data. The user can also filter the data grid so that employees who are managers appear in the list only.

This walkthrough illustrates the following tasks:

- Creating a Web Part by using the Visual Studio **Web Part** item template.

- Creating a property that can be set by the user of the Web Part. This property specifies the location of the employee data file.

- Rendering content in a Web Part by adding controls to the Web Part controls collection.

- Creating a new menu item, referred to as a *verb,* that appears in the verbs menu of the rendered Web part. Verbs enable the user to modify the data that appears in the Web Part.

- Testing the Web Part in SharePoint.

    > [!NOTE]
    > Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).

## Prerequisites

- Supported editions of Microsoft Windows and SharePoint.

- Visual Studio 2017 or Azure DevOps Services.

## Create an empty SharePoint project

First, create a Empty SharePoint project. Later, you will add a Web Part to the project by using the **Web Part** item template.

1. Start [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] by using the **Run as Administrator** option.

2. On the men bar, choose **File** > **New** > **Project**.

3. In the **New Project** dialog box, expand the **SharePoint** node under the language that you want to use, and then choose the **2010** node.

4. In the **Templates** pane, choose **SharePoint 2010 Project**, and then choose the **OK** button.

     The **SharePoint Customization Wizard** appears. This wizard enables you to select the site that you will use to debug the project and the trust level of the solution.

5. Choose the **Deploy as a farm solution** option button, and then choose the **Finish** button to accept the default local SharePoint site.

## Add a web part to the project

Add a **Web Part** item to the project. The **Web Part** item adds the Web Part code file. Later, you will add code to the Web Part code file to render the contents of the Web Part.

1. On the menu bar, choose **Project** > **Add New Item**.

2. In the **Add New Item** dialog box, in the **Installed Templates** pane, expand the **SharePoint** node, and then choose the **2010** node.

3. In the list of SharePoint templates, choose the **Web Part** template, and then choose the **Add** button.

     The **Web Part** item appears in **Solution Explorer**.

## Rendering content in the web part

You can specify which controls you want to appear in the Web Part by adding them to the controls collection of the Web Part class.

1. In **Solution Explorer**, open *WebPart1.vb* (in Visual Basic) or *WebPart1.cs* (in C#).

     The Web Part code file opens in Code Editor.

2. Add the following directives to the top of the Web Part code file.

     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/spext_webpart/webpart1/webpart1.cs" id="Snippet1":::
     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/spext_webpart/webpart1/webpart1.vb" id="Snippet1":::

3. Add the following code to the `WebPart1` class. This code declares the following fields:

   - A data grid to display employees in the Web Part.

   - Text that appears on the control that is used to filter the data grid.

   - A label that displays an error if the data grid is unable to display data.

   - A string that contains the path of the employee data file.

     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/spext_webpart/webpart1/webpart1.cs" id="Snippet2":::
     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/spext_webpart/webpart1/webpart1.vb" id="Snippet2":::

4. Add the following code to the `WebPart1` class. This code adds a custom property named `DataFilePath` to the Web Part. A custom property is a property that can be set in SharePoint by the user. This property gets and sets the location of a XML data file that is used to populate the data grid.

     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/spext_webpart/webpart1/webpart1.cs" id="Snippet3":::
     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/spext_webpart/webpart1/webpart1.vb" id="Snippet3":::

5. Replace the `CreateChildControls` method with the following code. This code performs the following tasks:

   - Adds the data grid and label that you declared in the previous step.

   - Binds the data grid to an XML file that contains employee data.

     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/spext_webpart/webpart1/webpart1.cs" id="Snippet4":::
     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/spext_webpart/webpart1/webpart1.vb" id="Snippet4":::

6. Add the following method to the `WebPart1` class. This code performs the following tasks:

   - Creates a verb that appears in the Web Part verbs menu of the rendered Web part.

   - Handles the event that is raised when the user chooses the verb in the verbs menu. This code filters the list of employees that appears in the data grid.

     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/spext_webpart/webpart1/webpart1.cs" id="Snippet5":::
     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/spext_webpart/webpart1/webpart1.vb" id="Snippet5":::

## Test the web part

When you run the project, the SharePoint site opens. The Web Part is automatically added to the Web Part Gallery in SharePoint. You can add the Web Part to any Web Part page.

1. Paste the following XML into a Notepad file. This XML file contains the sample data that will appear in the Web Part.

    ```xml
    <?xml version="1.0" encoding="utf-8" ?>
        <employees xmlns="http://schemas.microsoft.com/vsto/samples">
           <employee>
               <name>David Hamilton</name>
               <hireDate>2001-05-11</hireDate>
               <title>Sales Associate</title>
           </employee>
           <employee>
               <name>Karina Leal</name>
               <hireDate>1999-04-01</hireDate>
               <title>Manager</title>
           </employee>
           <employee>
               <name>Nancy Davolio</name>
               <hireDate>1992-05-01</hireDate>
               <title>Sales Associate</title>
           </employee>
           <employee>
               <name>Steven Buchanan</name>
               <hireDate>1955-03-04</hireDate>
               <title>Manager</title>
           </employee>
           <employee>
               <name>Suyama Michael</name>
               <hireDate>1963-07-02</hireDate>
               <title>Sales Associate</title>
           </employee>
        </employees>
    ```

2. In Notepad, on the menu bar, choose **File** > **Save As**.

3. In the **Save As** dialog box, in the **Save as type** list, choose **All Files**.

4. In the **File name** box, enter **data.xml**.

5. Choose any folder by using the **Browse Folders** button, and then choose the **Save** button.

6. In Visual Studio, choose the **F5** key.

     The SharePoint site opens.

7. On the **Site Actions** menu, choose **More Options**.

8. In the **Create** page, choose the **Web Part Page** type, then choose the **Create** button.

9. In the **New Web Part Page** page, name the page **SampleWebPartPage.aspx**, and then choose the **Create** button.

     The Web Part page appears.

10. Select any zone on the Web Part page.

11. At the top of the page, choose the **Insert** tab, and then choose the **Web Part** button.

12. In the **Categories** pane, choose the **Custom** folder, choose the **WebPart1** Web Part, and then choose the **Add** button.

     The Web Part appears on the page.

## Test the custom property

To populate the data grid that appears in the Web Part, specify the path of the XML file that contains data about each employee.

1. Choose the arrow that appears on the right side of the Web Part, and then choose **Edit Web Part** from the menu that appears.

     A pane that contains properties for the Web Part appears on the right side of the page.

2. In the pane, expand the **Miscellaneous** node, enter the path of the XML file that you created earlier, choose the **Apply** button, and then choose the **OK** button.

     Verify that a list of employees appears in the Web Part.

## Test the web part verb

Show and hide employees that are not managers by selecting an item that appears in the Web Part verbs menu.

1. Choose the arrow that appears on the right side of the Web Part, and then choose **Show Managers Only** from the menu that appears.

     Only employees who are managers appear in the Web Part.

2. Choose the arrow again, and then choose **Show All Employees** from the menu that appears.

     All employees appear in the Web Part.

## See also

[Create web parts for SharePoint](../sharepoint/creating-web-parts-for-sharepoint.md)
[How to: Create a SharePoint web part](../sharepoint/how-to-create-a-sharepoint-web-part.md)
[How to: Create a SharePoint web part by Using a Designer](../sharepoint/how-to-create-a-sharepoint-web-part-by-using-a-designer.md)
[Walkthrough: Create a web part for SharePoint by using a designer](../sharepoint/walkthrough-creating-a-web-part-for-sharepoint-by-using-a-designer.md)
