---
title: "How to: Add and Remove Additional Assemblies | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
f1_keywords:
  - "VS.SharePointTools.RAD.CustomAssembly"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, packages"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Add and remove additional assemblies
  If a SharePoint package depends on other assemblies for functionality or data, you can add the assemblies to your solution package (.wsp). This way, the SharePoint server makes sure that custom assemblies are installed with a package.

 You can also add and change the safe controls and class resource files associated with the assemblies.

## Add additional assemblies, safe controls, and class resources
 You can add additional assemblies into the SharePoint solution package. Additional assemblies in a sandboxed solution deploy to the global assembly cache, but SharePoint project items in a sandboxed solution are added to the content database. You can also add safe controls and class resources to these additional assemblies. For more information about safe controls, see [Providing Packaging and Deployment Information in Project Items](../sharepoint/providing-packaging-and-deployment-information-in-project-items.md) or "Creating a SafeControl Entry" in [Deploying Web Parts in SharePoint Foundation](/previous-versions/office/developer/sharepoint-2010/cc768621(v=office.14)).

#### To add an existing assembly

1. Open the **Package Designer**. For more information, see [How to: Customize a SharePoint Solution Package](../sharepoint/how-to-customize-a-sharepoint-solution-package.md).

2. Choose the **Advanced** tab.

3. Choose the **Add** button, and then choose **Add Existing Assembly** from the list.

     The **Add Existing Assembly** dialog box appears.

4. Choose the ellipsis (![ASP.NET Mobile Designer ellipse](../sharepoint/media/mwellipsis.gif "ASP.NET Mobile Designer ellipse")), and then choose the assembly that you want to add. We recommend using a relative path to the selected assembly for portability purposes.

5. For the **Deployment Target**, choose the **GlobalAssemblyCache** option button to deploy the assembly to the global assembly cache, or choose the **WebApplication** option button to deploy the assembly to the WebApplication folder on the server that's running SharePoint.

#### To add an assembly from project output

1. Open the **Package Designer**.

     For more information, see [How to: Customize a SharePoint solution package](../sharepoint/how-to-customize-a-sharepoint-solution-package.md).

2. Choose the **Advanced** tab.

3. Choose the **Add** button, and then choose **Add Assembly from Project Output** from the list.

     The **Add Assembly from Project Output** dialog box appears.

4. In the **Source Project** list, and choose the source project that you want to add.

5. For the **Deployment Target**, choose the **GlobalAssemblyCache** option button to deploy the assembly to the global assembly cache, or choose the **WebApplication** option button to deploy the assembly to the WebApplication folder on the server that's running SharePoint.

#### To add a safe control

1. Open the **Edit Existing Assembly** dialog box. To accomplish this, open the Package Designer, choose the **Advanced** tab, choose an assembly, and then choose the **Edit** button.

2. In the **Safe Controls** pane, choose the **Click here to add a new item** button.

3. In the **Assembly Name** column, enter the name of the assembly.

4. In the **Namespace** column, enter the name of the namespace for the safe control.

5. In the **Type Name** column, enter the name of the type.

#### To add a class resource

1. Open the **Edit Existing Assembly** dialog box. To accomplish this, open the Package Designer, choose the **Advanced** tab, choose an assembly, and then choose the **Edit** button.

2. In the **Class Resources** pane, choose the **Click here to add a new item** button.

3. In the **File Name** column, choose the ellipsis (![ASP.NET Mobile Designer ellipse](../sharepoint/media/mwellipsis.gif "ASP.NET Mobile Designer ellipse")), and choose the class resource that you want to add.

## Delete custom assemblies
 You can delete assemblies from a SharePoint package, or delete safe controls and class resources from existing assemblies.

#### To delete an existing assembly

1. Open the **Package Designer**. For more information, see [How to: Customize a SharePoint solution package](../sharepoint/how-to-customize-a-sharepoint-solution-package.md).

2. Choose the **Advanced** tab.

3. In the **Additional Assemblies** pane, choose the custom assembly that you want to delete.

4. Choose the **Delete** button.

#### To delete a safe control for an assembly

1. Open the **Edit Existing Assembly** dialog box. To accomplish this, open the Package Designer, choose the **Advanced** tab, choose an assembly, and then choose the **Edit** button.

2. Choose the safe control that you want to delete.

3. Choose the Delete key.

#### To delete a class resource for an assembly

1. Open the **Edit Existing Assembly** dialog box. To accomplish this, open the Package Designer, choose the **Advanced** tab, choose an assembly, and then choose the **Edit** button.

2. Choose the class resource that you want to delete.

3. Choose the Delete key.

## See also
- [Create SharePoint features](../sharepoint/creating-sharepoint-features.md)
- [How to: Customize a SharePoint Feature](../sharepoint/how-to-customize-a-sharepoint-feature.md)
- [How to: Add and remove items to SharePoint features](../sharepoint/how-to-add-and-remove-items-to-sharepoint-features.md)
