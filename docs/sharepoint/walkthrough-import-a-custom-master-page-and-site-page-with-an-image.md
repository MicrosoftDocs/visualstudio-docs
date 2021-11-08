---
title: "Import custom master page & site page with image"
description: In this walkthrough, import a SharePoint custom master page and a site page that has an image into a Visual Studio SharePoint project.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, importing items"
  - "importing items [SharePoint development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# Walkthrough: Import a custom master page and site page with an image
  This walkthrough demonstrates how to import a SharePoint custom master page and a site page that has an image into a [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] SharePoint project.

 This walkthrough shows how to accomplish the following tasks:

- Create a custom master page and a site page by using an image in SharePoint Designer.

- Export a custom master page, image, and site page to a SharePoint solution (*.wsp*) file.

- Import and deploy the *.wsp* file into a [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] SharePoint project by using the Import SharePoint Solution Package project.

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites
 You must have the following components to complete this walkthrough:

- Supported editions of [!INCLUDE[TLA#tla_win](../sharepoint/includes/tlasharptla-win-md.md)] and SharePoint.

- Visual Studio.

- SharePoint Designer 2010.

## Create items in SharePoint Designer
 This example shows how to create three items in SharePoint Designer for export: a custom master page, a site page that references the custom master page, and an image file to appear on the site page. The image is added to the /images/ folder in SharePoint.

#### To create a custom master page in SharePoint Designer

1. In SharePoint Designer, in the Navigation pane, choose the **Master Pages** site object.

2. On the **Master Pages** ribbon, choose **Blank Master Page**.

3. Choose the new master page, and then, on the **Master Pages** ribbon, choose **Edit File**.

4. At the bottom of SharePoint Designer, choose the **Code** tab.

5. Replace the existing markup with the following markup.

    ```aspx-csharp
    <%@ Master Language="C#" %>
    <%@ Register tagprefix="SharePoint" namespace="Microsoft.SharePoint.WebControls" assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
    <html dir="ltr">
    <head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
    <SharePoint:RobotsMetaTag runat="server" __designer:Preview="" __designer:Values="<P N='InDesign' T='False' /><P N='ID' T='ctl00' /><P N='Page' ID='1' /><P N='TemplateControl' ID='2' /><P N='AppRelativeTemplateSourceDirectory' R='-1' />"></SharePoint:RobotsMetaTag>
    <title>Web Page</title>
    </head>
    <body>
    <form id="form1" runat="server">
    <asp:ContentPlaceHolder id="ContentPlaceHolderMain"
            runat="server">
          </asp:ContentPlaceHolder>
    </form>
    </body>
    </html>
    ```

6. Save the page, choose the **Master Pages** tab, and rename the master page as **mybasic1.master**.

## Add an image to the content database in SharePoint Designer
 Now you can add an image to display on the site page. The image is deployed to the SharePoint content database.

#### To add an image to the content database in SharePoint Designer

1. In the Navigation pane, choose the **All Files** site object, and then, in the tree view, choose the **images** folder.

2. On the **All Files** ribbon, choose **Import Files**, choose a file of your choice, and then choose the **OK** button. In this example, the file is named **myimg1.png**.

     Optionally, you can create a subfolder to help organize the images.

3. Close the **Import** dialog box.

## Create a site page
 This basic site page uses the custom master page and displays the image that you added in the previous step.

#### To create a site page

1. In the Navigation pane, choose the **Site Pages** object.

2. On the **Pages** ribbon, choose the **Page** button, choose the **ASPX** page type, and then name the new file **mycontentpage1.aspx**.

     Optionally, you can create a subfolder to help organize the site pages.

3. In the site pages list, choose **MyContentPage1.aspx** to open its properties page, and then, at the bottom of the page, choose the **Edit file** link.

     If a message appears and says that this page doesn't contain any regions that are editable in safe mode and asks whether you want to open this page in advanced mode, choose the **Yes** button.

4. At the bottom of the page, choose the **Code** button.

5. Replace the existing markup with the following markup.

    ```aspx-csharp
    <%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
    <%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
    <%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
    <%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
    <%@ Import Namespace="Microsoft.SharePoint" %>
    <%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
    <%@ Page Language="C#" Inherits="Microsoft.SharePoint.WebControls.LayoutsPageBase" MasterPageFile="../_catalogs/masterpage/mybasic1.master" meta:progid="SharePoint.WebPartPage.Document" %>

    <asp:Content ID="Main" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <img alt="My Image" longdesc="My image from images folder" src="../images/myimg1.png" />
    </asp:Content>
    ```

6. Save the updated site page.

## Export the items from SharePoint
 Export the items from SharePoint to a SharePoint solution (*.wsp*) file.

#### To export items from SharePoint Designer

1. In SharePoint Designer, in the Navigation pane, choose the **Team Site** object, and then, on the **Site** ribbon, choose **Save As Template**.

2. In the **Save as Template** dialog box, enter a file name and template name, select the **Include Content** check box, and then choose the **OK** button.

     This saves the contents of the site in the *.wsp* file.

3. After the solution exports, choose the **Solution Gallery** link to display the list of available solution files.

4. Open the shortcut menu for the new *.wsp* file, and then choose **Save target as** to save it to the system.

## Import the items into Visual Studio
 Import the *.wsp* file into [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)]. After the content is imported, you can customize it, add more items, and then deploy it.

#### To import items from the .wsp file into Visual Studio

1. In [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], create an **Import SharePoint 2010 Solution Package** project.

2. On the **Select items to import** page, under **Module** in the **Type** column, select the check boxes for only the files in the following table for import.

   | File Name | Description |
   |------------------------|-----------------------------------------------|
   | \_catalogsmasterpage\_ | The custom master page. |
   | images_ | The image file in the SharePoint file system. |
   | SitePages_ | The site page. |

3. Choose the **Finish** button to import the selected items.

4. In **Solution Explorer**, choose the \_catalogsmasterpage\_ node, and set the value of its **Deployment Conflict Resolution** property to **Automatic**.

    This helps ensure that any deployment conflicts are resolved automatically.

5. If your new master page has the same name as an existing page, make sure that the existing page is not marked as either a Default Master Page or a Custom Master Page in SharePoint Designer.

    If an existing master page is marked as either Default Master Page or Custom Master Page, you will get a deployment error that states that the master page cannot be deleted. To avoid this problem, do this:

   - If the existing master page is set as Default Master Page, temporarily set another master page as Default Master Page. After you deploy the files to SharePoint, set your new master page as Default Master Page.

   - If the existing master page is set as Custom Master Page, temporarily set another master page as Custom Master Page. After you deploy the files to SharePoint, set your new master page as Custom Master Page.

6. On the menu bar, choose **Build** > **Deploy Solution**.

7. Open the SharePoint site to view the deployed items.

   An alternative way to import files into [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] and deploy them to SharePoint is to add the files into modules in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)]. [!INCLUDE[crdefault](../sharepoint/includes/crdefault-md.md)] [How to: Import a master page or theme](../sharepoint/how-to-import-a-master-page-or-theme.md) and [Use modules to include files in the Solution](../sharepoint/using-modules-to-include-files-in-the-solution.md).

## See also
- [Importing items from an existing SharePoint site](../sharepoint/importing-items-from-an-existing-sharepoint-site.md)
- [Develop SharePoint solutions](../sharepoint/developing-sharepoint-solutions.md)
- [Create reusable controls for web parts or application pages](../sharepoint/creating-reusable-controls-for-web-parts-or-application-pages.md)
