---
title: "Walkthrough: Creating a SharePoint Application Page | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "application pages [SharePoint development in Visual Studio], developing"
  - "application pages [SharePoint development in Visual Studio], creating"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Walkthrough: Create a SharePoint application page

An application page is a specialized form of an ASP.NET page. Application pages contain content that's merged with a SharePoint master page. For more information, see [Create application pages for SharePoint](../sharepoint/creating-application-pages-for-sharepoint.md).

This walkthrough shows you how to create an application page and then debug it by using a local SharePoint site. This page shows all items that each user has created or modified in all sites on the server farm.

This walkthrough illustrates the following tasks:

- Creating a SharePoint project.
- Adding an application page to the SharePoint project.
- Adding ASP.NET controls to the application page.
- Adding code behind the ASP.NET controls.
- Testing the application page.

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).

## Prerequisites

- Supported editions of Windows and SharePoint.

## Create a SharePoint project

First, create an **Empty SharePoint Project**. Later, you will add an **Application Page** item to this project.

1. Start [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

2. Open the **New Project** dialog box, expand the **Office/SharePoint** node under the language that you want to use, and then choose the **SharePoint Solutions** node.

3. In the **Visual Studio Installed Templates** pane, choose the **SharePoint 2010 - Empty Project** template. Name the project **MySharePointProject**, and then choose the **OK** button.

     The **SharePoint Customization Wizard** appears. This wizard enables you to select the site that you will use to debug the project and the trust level of the solution.

4. Choose the **Deploy as a farm solution** option button, and then choose the **Finish** button to accept the default local SharePoint site.

## Create an application page

To create an application page, add an **Application Page** item to the project.

1. In **Solution Explorer**, choose the **MySharePointProject** project.

2. On the menu bar, choose **Project** > **Add New Item**.

3. In the **Add New Item** dialog box, choose the **Application Page (Farm Solution Only** template.

4. Name the page **SearchItems**, and then choose the **Add** button.

     The Visual Web Developer designer displays the application page in **Source** view where you can see the page's HTML elements. The designer displays the markup for several <xref:System.Web.UI.WebControls.Content> controls. Each control maps to a <xref:System.Web.UI.WebControls.ContentPlaceHolder> control that is defined in the default application master page.

## Design the layout of the application page

The Application Page item enables you to use a designer to add ASP.NET controls to the application page. This designer is the same designer used in Visual Web Developer. Add a label, a radio button list, and a table to the **Source** view of the designer, and then set properties just as you would when you design any standard ASP.NET page.

1. On the menu bar, choose **View** > **Toolbox**.

2. In the Standard node of the **Toolbox**, perform one of the following steps:

    - Open the shortcut menu for the **Label** item, choose **Copy**, open the shortcut menu for the line under the **PlaceHolderMain** content control in the designer, and then choose **Paste**.

    - Drag the **Label** item from the **Toolbox** onto the body of the **PlaceHolderMain** content control.

3. Repeat the previous step to add a **DropDownList** item and a **Table** item to the **PlaceHolderMain** content control.

4. On the designer, change the value of the `Text` attribute of the label control to **Show All Items**.

5. On the designer, replace the `<asp:DropDownList>` element with the following XML.

    ```xml
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true"
     OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem Text="Created by me" Value="Author"></asp:ListItem>
        <asp:ListItem Text="Modified by me" Value="Editor"></asp:ListItem>
    </asp:DropDownList>
    ```

## Handle the events of controls on the page

Handle controls in an application page just as you would any ASP.NET page. In this procedure, you will handle the `SelectedIndexChanged` event of the drop-down list.

1. On the **View** menu, choose **Code**.

     The application page code file opens in the Code Editor.

2. Add the following method to the `SearchItems` class. This code handles the <xref:System.Web.UI.WebControls.ListControl.SelectedIndexChanged> event of the <xref:System.Web.UI.WebControls.DropDownList> by calling a method that you will create later in this walkthrough.

     [!code-vb[SP_ApplicationPage#5](../sharepoint/codesnippet/VisualBasic/sp_applicationpage/layouts/sp_applicationpage/SearchItems.aspx.vb#5)]
     [!code-csharp[SP_ApplicationPage#5](../sharepoint/codesnippet/CSharp/sp_applicationpage/layouts/sp_applicationpage/SearchItems.aspx.cs#5)]

3. Add the following statements to the top of the application page code file.

     [!code-vb[SP_ApplicationPage#1](../sharepoint/codesnippet/VisualBasic/sp_applicationpage/layouts/sp_applicationpage/SearchItems.aspx.vb#1)]
     [!code-csharp[SP_ApplicationPage#1](../sharepoint/codesnippet/CSharp/sp_applicationpage/layouts/sp_applicationpage/SearchItems.aspx.cs#1)]

4. Add the following method to the `SearchItems` class. This method iterates through all sites on the server farm and searches for items created or modified by the current user.

     [!code-vb[SP_ApplicationPage#2](../sharepoint/codesnippet/VisualBasic/sp_applicationpage/layouts/sp_applicationpage/SearchItems.aspx.vb#2)]
     [!code-csharp[SP_ApplicationPage#2](../sharepoint/codesnippet/CSharp/sp_applicationpage/layouts/sp_applicationpage/SearchItems.aspx.cs#2)]

5. Add the following method to the `SearchItems` class. This method displays items created or modified by the current user in the table.

     [!code-vb[SP_ApplicationPage#3](../sharepoint/codesnippet/VisualBasic/sp_applicationpage/layouts/sp_applicationpage/SearchItems.aspx.vb#3)]
     [!code-csharp[SP_ApplicationPage#3](../sharepoint/codesnippet/CSharp/sp_applicationpage/layouts/sp_applicationpage/SearchItems.aspx.cs#3)]

## Test the application page

When you run the project, the SharePoint site opens and the application page appears.

1. In **Solution Explorer**, open the shortcut menu for the application page, and then choose **Set as Startup Item**.

2. Choose the **F5** key.

     The SharePoint site opens.

3. On the application page, choose the **Modified by me** option.

     The application page refreshes and displays all items that you've modified in all sites on the server farm.

4. On the application page, choose **Created by me** in the list.

     The application page refreshes and displays all items that you have created in all sites on the server farm.

## Next steps

For more information about SharePoint application pages, see [Create application pages for SharePoint](../sharepoint/creating-application-pages-for-sharepoint.md).

You can learn more about how to design SharePoint page content by using the Visual Web Designer from these topics:

- [Create web parts for SharePoint](../sharepoint/creating-web-parts-for-sharepoint.md).

- [Create reusable controls for web parts or application pages](../sharepoint/creating-reusable-controls-for-web-parts-or-application-pages.md).

## See also

[How to: Create an application page](../sharepoint/how-to-create-an-application-page.md)
[Application _layouts Page Type](/previous-versions/office/aa979604(v=office.14))
