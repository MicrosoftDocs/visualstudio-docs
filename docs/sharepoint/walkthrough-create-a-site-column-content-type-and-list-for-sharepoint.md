---
title: "Create site column, content type, and list for SharePoint"
titleSuffix: ""
description: In this walkthrough, create a custom site column (field), custom content type that uses the site column, and list that uses the content type in SharePoint.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
f1_keywords:
  - "VS.SharePointTools.ListDesigner.GeneralMessageHelp"
  - "Microsoft.VisualStudio.SharePoint.Designers.ListDesigner.ViewModels.ListViewModel.SortingAndGrouping"
  - "VS.SharePointTools.ListDesigner.SortingGrouping"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, list definitions"
  - "SharePoint development in Visual Studio, list instances"
  - "SharePoint development in Visual Studio, fields"
  - "SharePoint development in Visual Studio, content types"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# Walkthrough: Create a site column, content type, and list for SharePoint
  The following procedures demonstrate how to create custom SharePoint site columns—or *fields*—as well as a content type that uses the site columns. It also shows how to create a list that uses the new content type.

 This walkthrough includes the following tasks:

- [Create custom site columns](#create-custom-site-columns).

- [Create a custom content type](#create-a-custom-content-type).

- [Create a list](#create-a-list).

- [Test the application](#test-the-application).

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites
 You need the following components to complete this walkthrough:

- Supported editions of Windows and SharePoint.

- [!INCLUDE[vsprvs-current](../sharepoint/includes/vsprvs-current-md.md)]

## Create custom site columns
 This example creates a list for managing patients in a hospital. First, you must create a SharePoint project in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] and add site columns to it, as follows.

#### To create the project

1. On the [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] **File** menu, choose **New** > **Project**.
::: moniker range="=vs-2017"
2. In the **New Project** dialog box, under either **Visual C#** or **Visual Basic**, expand the **Office/SharePoint** node, and then select **SharePoint Solutions**.

3. In the **Templates** pane, choose the **SharePoint Empty Project** for the particular version of SharePoint you have installed. For example, if you have SharePoint 2016 install select the **SharePoint 2016 - Empty Project** template.  

4. Change the name of the project to **Clinic**, and then choose the **OK** button.

5. On the **Specify the site and security level for debugging** dialog, enter the URL for the local SharePoint site to which you want to add the new custom field item, or use the default location (`http://<`*SystemName*`>/)`.

6. In the **What is the trust level for this SharePoint solution?** section, use the default value **Deploy as a sandboxed solution**.

     For more information about sandboxed and farm solutions, see [Sandboxed solution considerations](../sharepoint/sandboxed-solution-considerations.md).

7. Choose the **Finish** button. The project is now listed in **Solution Explorer**.
::: moniker-end
::: moniker range=">=vs-2019"
2.  On the **Create a New Project** dialog select the **SharePoint Empty Project** for the particular version of SharePoint you have installed. For example, if you have SharePoint 2016 install select the **SharePoint 2016 - Empty Project** template.
    [!INCLUDE[new-project-dialog-search](../sharepoint/includes/new-project-dialog-search-md.md)]

3. Change the name of the project to **Clinic**, and then choose the **Create** button.

4. On the **Specify the site and security level for debugging** dialog, enter the URL for the local SharePoint site to which you want to add the new custom field item, or use the default location (`http://<`*SystemName*`>/)`.

5. In the **What is the trust level for this SharePoint solution?** section, use the default value **Deploy as a sandboxed solution**.

     For more information about sandboxed and farm solutions, see [Sandboxed solution considerations](../sharepoint/sandboxed-solution-considerations.md).

6. Choose the **Finish** button. The project is now listed in **Solution Explorer**.
::: moniker-end

#### To add site columns

1. Add a new site column. To do this, in **Solution Explorer**, right-click on the **Clinic** project, and then choose **Add** > **New Item**.

2. In the **Add New Item** dialog box, choose **Site Column**, change the name to **PatientName**, and then choose the **Add** button.

3. In the site column's *Elements.xml* file, leave the **Type** setting as **Text**, change the **Group** setting to **Clinic Site Columns**. When complete, the site column's *Elements.xml* file should look like the following example.

    ```xml
    <Field
         ID="{f9ba60d1-5631-41fb-b016-a38cf48eef63}"
         Name="PatientName"
         DisplayName="Patient Name"
         Type="Text"
         Required="FALSE"
         Group="Clinic Site Columns">
    </Field>
    ```

    > [!TIP]
    > Visual Studio will automatically add a space in the DisplayName for you if you use camel casing in the name of the Site Column.
    > It's recommended not to use spaces in the Site Column name as it may cause issues when you try to deploy the solution to SharePoint.

4. Using the same procedure, add two more site columns to the project: **PatientID** (Type = "Integer") and **DoctorName** (Type = "Text"). Set their Group value to **Clinic Site Columns**.

## Create a custom content type
 Next, create a content type—based on the Contacts content type—that includes the site columns that you created in the previous procedure. By basing a content type on an existing content type, you can save time because the base content type provides several site columns for use in the new content type.

#### To create a custom content type

1. Add a content type to the project. To do this, in **Solution Explorer**, choose the project node

2. On the menu bar, choose **Project** > **Add New Item**.

3. Under either **Visual C#** or **Visual Basic**, expand the **SharePoint** node, and then choose the **2010** node.

4. In the **Templates** pane, choose the **Content Type** template, change the name to **Patient Info**, and then choose the **Add** button.

     The **SharePoint Customization Wizard** opens.

5. In the **Which base content type should this content type inherit from** list, choose **Contact** as the content type on which to base the new content type, and then choose the **Finish** button.

     Doing this gives you access to other potentially useful site columns in the Contact content type, in addition to the site columns that you defined previously.

6. After the Content Type designer appears, in the **Columns** tab, add the three site columns that you defined previously: **Patient Name**, **Patient ID**, and **Doctor Name**. To add these columns, choose the first list box in the site columns list under **Display Name**, and then choose each site column in the list one at a time.

    > [!TIP]
    > To choose the site columns more quickly, filter the list by entering the first few letters of the name of the column.

7. In addition to the three custom site columns, add the **Comments** site column from the site columns list.

8. Select the **Required** check box for the **Patient Name** and **Patient ID** site columns to make them required fields.

9. On the **Content Type** tab, make sure that the content type name is **Patient Info**, and then change the description to **Patient information card**.

10. Change **Group Name** to **Clinic Content Types**, and leave the other settings at their default values.

11. On the menu bar, choose **File** > **Save All**, and then close the Content Type designer.

## Create a list
 Now, create a list that uses the new content type and site columns.

#### To create a list

1. Add a list to the project. To do this, in **Solution Explorer**, choose the project node.

2. On the menu bar, choose **Project** > **Add New Item**.

3. Under either **Visual C#** or **Visual Basic**, expand the **SharePoint** node.

4. In the **Templates** pane, choose the **List** template, change the name to **Patients**, and then choose the **Add** button.

5. Leave the **Customize the list based on** setting as **Default (Custom List)**, and then choose the **Finish** button.

6. In the List Designer, choose the **Content Types** button to display the **Content Type Settings** dialog box.

7. Choose the new row, choose the **Patient Info** content type in the list of content types, and then choose the **OK** button.

     Doing this adds all of the site columns from the **Patient Info** content type into the list.

8. Delete all of the site columns in the list except for the following:

    - Patient ID

    - Patient Name

    - Home Phone

    - E-Mail

    - Doctor Name

    - Comments

9. Under **Column Display Name**, choose an empty row, add a custom list column, and name it **Hospital**. Leave its data type as **Single Line of Text**.

     The custom list column applies only to this list. When you add a custom list column to a list, a new list content type, including all the columns added into the list, is created and set as the default list.

    > [!TIP]
    > If you choose a column from the list of site columns, an existing site column is used. However, if you enter a column name value without choosing any columns in the list, a custom list column is created, even if a column with the same name already exists in the list.

     Optionally, rather than setting the data type for the custom list column to **Single Line of Text**, you could instead set the data type for this column to Lookup, and its values would be retrieved from a table or another list. For information about Lookup columns, see [List Relationships in SharePoint 2010](/previous-versions/msp-n-p/ff798514(v=pandp.10)) and [Lookups and List Relationships](/previous-versions/office/developer/sharepoint-2010/ff623048(v=office.14)).

10. Next to the **Patient ID** and **Patient Name** boxes, select the **Required** check box.

11. On the **Views** tab, choose an empty row to create a view. Enter **Patient Details** in a blank row under the **View Name** column.

     On the **Views** tab, you can specify the columns that you want to appear in the SharePoint list.

12. Choose the new **Patient Details** row, and then choose the **Set as Default** button.

     The new view is now the default view for the list.

13. Add the following columns to the **Selected Columns** list in the following order:

    - Patient ID

    - Patient Name

    - Home Phone

    - E-Mail

    - Doctor Name

    - Hospital

    - Comments

14. In the **Properties** list, choose the **Sorting and Grouping** property, and then choose the ellipsis button ![Ellipsis Icon](../sharepoint/media/ellipsisicon.gif "Ellipsis Icon") to display the **Sorting and Grouping** dialog box.

15. In the **Column Name** list, choose **Patient Name**, make sure that the **Sorting** column is set to **Ascending**, and then choose the **OK** button.

## Test the application
 Now that the custom site columns, content type, and list are ready, deploy them to SharePoint, and run the application to test it.

#### To test the application

1. On the menu bar, choose **File** > **Save All**.

2. Choose the **F5** key to run the application.

     The application is compiled, and then its features are deployed to SharePoint and activated.

3. On the Quick Navigation bar, choose the **Patients** link to display the **Patients** list.

     The column names in the list should match those that you entered on the **Views** tab in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

4. Choose the **Add new item** link to create a patient information card.

5. Enter information into the fields, and then choose the **Save** button.

     The new record appears in the list.

## See also
- [Create site columns, content types, and lists for SharePoint](../sharepoint/creating-site-columns-content-types-and-lists-for-sharepoint.md)
- [Develop SharePoint solutions](../sharepoint/developing-sharepoint-solutions.md)
- [How to: Create a Custom Field Type](/previous-versions/office/developer/sharepoint-2010/bb862248(v=office.14))
- [Content Types](/previous-versions/office/developer/sharepoint-2010/ms479905(v=office.14))
- [Columns](/previous-versions/office/developer/sharepoint-2010/ms196085(v=office.14))
