---
title: "How to: Mark Controls as Safe Controls | Microsoft Docs"
description: Mark controls as safe controls in the Safe Control Entries property of a SharePoint project item or in the Package Designer when you add an assembly.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, safe controls"
  - "SharePoint development in Visual Studio, advanced packaging tools"
  - "safe controls [SharePoint development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# How to: Mark controls as safe controls
  For security, SharePoint differentiates between Web controls that are protected against script injection and Web controls that are not. Protected controls, or *safe controls*, can be accessed by untrusted users. You can mark controls as safe in the Safe Control Entries property of a SharePoint project item or in the **Package Designer** when you add an assembly to the package. For more information, see

- [web.config file Settings Change](/previous-versions/office/developer/sharepoint-2007/bb802890(v=office.12)) and [Registering a Web Part Assembly as a Safe Control](/previous-versions/office/developer/sharepoint2003/dd587360(v=office.11)).

> [!IMPORTANT]
> These procedures are for illustrative purposes. Mark controls safe only if you are certain that they are secure.

## Marking Safe Controls in the Safe Control Entries Property

#### To mark controls as safe or unsafe in the safe control entries property

1. Create a SharePoint solution with a Visual Web Part project.

2. Add two controls to the Web part: a text box and a button. Leave the names at their default values, TextBox1 and Button1, respectively.

3. Add two entries to the Web part's **Safe Control Entries** property. To do this, choose the ellipsis (![ASP.NET Mobile Designer ellipse](../sharepoint/media/mwellipsis.gif "ASP.NET Mobile Designer ellipse")) button next to the **Safe Control Entries** property in the **Properties** window.

     The **Safe Control Entries** dialog box appears.

4. In the **Safe Control Entries** dialog box, choose the **Add** button twice to add two safe control entries to the **Members** pane: one for the button and one for the text box.

5. Choose the first safe control entry, and then change the value of its **Safe** property to **False**, its **Type Name** property to **Button1**, and its **Safe Against Script** property to **False**.

     This step identifies the button control as an unsafe control.

6. Choose the second safe control entry in the list. Leave the value of its **Safe** property as **True** and set its **Type Name** property to **TextBox1** and its **Safe Against Script** property to **True**.

     The text box control is now marked as a control that is safe against script injection.

7. Choose the **OK** button to close the dialog box.

## Marking Safe Controls in the Package Designer

#### To mark controls as safe or unsafe in the Package Designer

1. Create a SharePoint solution with a Visual Web Part project.

2. Add two controls to the Web part: a text box and a button. Leave the names at their default values, TextBox1 and Button1, respectively.

     Take note of the namespace of the control because it is used later.

3. On the menu bar, choose **Build** > **Build Solution** to build the project.

4. Create another SharePoint solution.

5. In **Solution Explorer**, open the shortcut menu for the *Package.Package* file, and then choose **Open** to open the **Package Designer**.

6. In the **Package Designer**, choose the **Advanced** tab.

7. Under **Additional Assemblies**, choose the **Add** button, and then choose **Add Existing Assembly** from the list.

8. In the **Add Existing Assembly** dialog box, choose the ellipsis (![ASP.NET Mobile Designer ellipse](../sharepoint/media/mwellipsis.gif "ASP.NET Mobile Designer ellipse")) button next to **Source Path**.

9. Choose the assembly from the SharePoint solution that you created in Step 1, and then choose the **Open** button.

10. For this example, leave the **Deployment Target** option as GlobalAssemblyCache.

     This step causes the assembly to deploy to the system Global Assembly Cache (GAC). If you want the assembly to deploy to the Web application (Bin) folder, select that option instead. For more information, see [Deploying Web Parts in SharePoint Foundation](/previous-versions/office/developer/sharepoint-2010/cc768621(v=office.14)).

11. In the **Safe Controls** box, choose the **Click here to add a new item** button.

12. Enter the values for the properties from the following table.

    |Property Name|Value|
    |-------------------|-----------|
    |Namespace|The fully-qualified namespace for the control, such as **BdcModelProject1.VisualWebPart1**.|
    |Type Name|Button1|
    |Assembly Name|A strong assembly name, such as: Microsoft.Office.SharePoint.ClientExtensions, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c.|
    |Safe|Clear the **Safe** check box.|
    |Safe Against Script|Leave the **Safe Against Script** check box clear.|

    > [!NOTE]
    > The **Assembly Name** value for assemblies added through the **Advanced** tab of the **Package Designer** cannot be a token, it must be a strongly-named assembly. For more information, see [Creating and Using Strong-Named Assemblies](/previous-versions/dotnet/netframework-4.0/xwb8f617(v=vs.100)).

13. Choose the **Tab** key to create another safe control entry.

14. Choose the **Click here to add a new item** button again.

15. Enter the values for the properties from the following table.

    |Property Name|Value|
    |-------------------|-----------|
    |Namespace|The fully-qualified namespace for the control, such as **BdcModelProject1.VisualWebPart1**.|
    |Type Name|TextBox1|
    |Assembly Name|A strong assembly name, such as: Microsoft.Office.SharePoint.ClientExtensions, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c.|
    |Safe|Select the **Safe** check box.|
    |Safe Against Script|Select the **Safe Against Script** check box.|

16. Choose the **Tab** key, and then choose the **OK** button to close the dialog box.

## See also
- [Provide packaging and deployment information in project items](../sharepoint/providing-packaging-and-deployment-information-in-project-items.md)
- [Package and deploying SharePoint solutions](../sharepoint/packaging-and-deploying-sharepoint-solutions.md)
