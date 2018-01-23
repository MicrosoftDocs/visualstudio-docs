---
title: "Walkthrough: Create a Basic Site Definition Project | Microsoft Docs"
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
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "SharePoint development in Visual Studio, site definitions"
  - "site definitions [SharePoint development in Visual Studio]"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Walkthrough: Create a Basic Site Definition Project
  This walkthrough shows you how to create a basic site definition that contains a visual Web part with some controls on it. For the sake of clarity, the visual Web part that you create has only a few controls. However, you can create more sophisticated SharePoint site definitions that include more functionality.  
  
 This walkthrough demonstrates the following tasks:  
  
-   Creating a site definition by using the [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] project template.  
  
-   Creating a SharePoint site by using a site definition in SharePoint.  
  
-   Adding a visual Web part to the solution.  
  
-   Customizing the site's default.aspx page by adding the new visual Web part to it.  
  
 [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]  
  
## Prerequisites  
 You need the following components to complete this walkthrough:  
  
-   Supported editions of Microsoft Windows and SharePoint. For more information, see Requirements for Developing SharePoint Solutions.  
  
-   Visual Studio.  
  
## Creating a Site Definition Solution  
 First, create the site definition project in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].  
  
#### To create a site definition project  
  
1.  On the menu bar, choose **File**, **New**, **Project**. If your IDE is set to use Visual Basic development settings, on the menu bar, choose **File**, **New Project**.  
  
     The **New Project** dialog box appears.  
  
2.  Expand the **Visual C#** node or the **Visual Basic** node, expand the **SharePoint** node, and then choose the **2010** node.  
  
3.  In the **Templates** list, choose the **SharePoint 2010 Project** template.  
  
4.  In the **Name** box, enter **TestSiteDef**, and then choose the **OK** button.  
  
     The **SharePoint Customization Wizard** appears.  
  
5.  On the **Specify the site and security level for debugging** page, enter the URL for the SharePoint site where you want to debug the site definition, or use the default location (http://*System Name*/).  
  
6.  In the **What is the trust level for this SharePoint solution?** section, choose the **Deploy as a farm solution** option button.  
  
     All site definition projects must be deployed as farm solutions. For more information about sandboxed solutions versus farm solutions, see [Sandboxed Solution Considerations](../sharepoint/sandboxed-solution-considerations.md).  
  
7.  Choose the **Finish** button.  
  
     The project appears in **Solution Explorer**.  
  
8.  In **Solution Explorer**, choose the project node, and then, on the menu bar, choose **Project**, **Add New Item**.  
  
9. Under either **Visual C#** or **Visual Basic**, expand the **SharePoint** node, and then choose the **2010** node.  
  
10. In the **Templates** pane, choose the **Site Definition** template, leave the **Name** as **SiteDefinition1**, and then choose the **Add** button.  
  
## Create a Visual Web Part  
 Next, create a visual Web part to appear on the site definition's main page.  
  
#### To create a visual Web part  
  
1.  In **Solution Explorer**, choose the **Show All Files** button.  
  
2.  Choose the **SiteDefinition1** project node, and then, on the menu bar, choose **Project**, **Add New Item**.  
  
     The **Add New Item** dialog box appears.  
  
3.  Expand the **Visual C#** node or the **Visual Basic** node, expand the **SharePoint** node, and then choose the **2010** node.  
  
4.  In the list of templates, choose the **Visual Web Part** template, keep the default name VisualWebPart1, and then choose the **Add** button.  
  
     The VisualWebPart1.ascx file opens.  
  
5.  At the bottom of VisualWebPart1.ascx, add the following markup to add three controls to the form: a text box, a button, and a label:  
  
    ```  
    <table>  
      <tr>  
        <td>  
          <asp:TextBox runat="server" ID="tbName"></asp:TextBox>  
        </td>  
        <td>  
          <asp:Button runat="server" ID="btnSubmit" Text = "Change Label Text" OnClick="btnSubmit_Click"></asp:Button>  
        </td>  
        <td>  
          <asp:Label runat="server" ID="lblName"></asp:Label>  
        </td>  
      </tr>  
    </table>  
    ```  
  
6.  Under VisualWebPart1.ascx, open the VisualWebPart1.ascx.cs file (for [!INCLUDE[csprcs](../sharepoint/includes/csprcs-md.md)]) or VisualWebPart1.ascx.vb (for [!INCLUDE[vbprvb](../sharepoint/includes/vbprvb-md.md)]) , and then add the following code:  
  
     [!code-vb[SP_SimpleSiteDef#1](../sharepoint/codesnippet/VisualBasic/testsitedefvb/sitedefinition/visualwebpart1/visualwebpart1usercontrol.ascx.vb#1)]
     [!code-csharp[SP_SimpleSiteDef#1](../sharepoint/codesnippet/CSharp/testsitedef/sitedefinition/visualwebpart1/visualwebpart1usercontrol.ascx.cs#1)]  
  
     This code adds functionality for the web part's button click.  
  
## Add the Visual Web Part to the Default ASPX Page  
 Next, add the visual Web part to the site definition's default ASPX page.  
  
#### To add a visual Web part to the default ASPX page  
  
1.  Open the default.aspx page, and then add the following line under the `WebPartPages` tag:  
  
    ```  
    <%@ Register Tagprefix="MyWebPartControls" Namespace="TestSiteDef.VisualWebPart1" Assembly="$SharePoint.Project.AssemblyFullName$" %>  
    ```  
  
     This line associates the name MyWebPartControls with the Web part and its code. The *Namespace* parameter matches the namespace that's used in the VisualWebPart1.ascx code file.  
  
2.  After the `</asp:Content>` element, replace the entire `ContentPlaceHolderId="PlaceHolderMain"` section and its contents with the following code:  
  
    ```  
    <asp:Content ID="Content1" ContentPlaceHolderId="PlaceHolderMain" runat="server">  
        <MyWebPartControls:VisualWebPart1 runat="server" />      
    </asp:Content>  
    ```  
  
     This code creates a reference to the visual Web part that you created earlier.  
  
3.  In **Solution Explorer**, open the shortcut menu for the **SiteDefinition1** node, and then choose **Set as Startup Item**.  
  
## Deploy and Run the Site Definition Solution  
 Next, deploy the project to SharePoint, and then run the project.  
  
#### To deploy and run the site definition  
  
-   On the menu bar, choose **Build**, **Deploy TestSiteDef**.  
  
-   Choose the F5 key.  
  
     Visual Studio compiles the code, adds its features, packages all of the files into a SharePoint solution (WSP) file, and deploys the WSP file to SharePoint Server. SharePoint then installs the files and then activates the features.  
  
## Create a Site Based on the Site Definition  
 Next, create a site by using the new site definition.  
  
#### To create a site by using the site definition  
  
1.  On the SharePoint site, the New SharePoint Site page appears.  
  
2.  In the **Title and Description** section, enter **My New Site** for the title and a description of the site.  
  
3.  In the **Web Site Address** section, enter **mynewsite** in the **URL name** box.  
  
4.  In the **Template** section, choose the **SharePoint Customizations** tab.  
  
5.  In the **Select a template** list, choose **SiteDefinition1**.  
  
6.  Leave the other settings at their default values, and then choose the **Create** button.  
  
     The new site appears.  
  
## Test the New Site  
 Next, test the new site to verify whether it works correctly.  
  
#### To test the new site  
  
-   On the default ASPX page, enter some text, and then choose the **Change Label Text** button next to the text box.  
  
     The text appears in the label on the right side of the button.  
  
## See Also  
 [How to: Create an Event Receiver](../sharepoint/how-to-create-an-event-receiver.md)   
 [Developing SharePoint Solutions](../sharepoint/developing-sharepoint-solutions.md)  
  
  