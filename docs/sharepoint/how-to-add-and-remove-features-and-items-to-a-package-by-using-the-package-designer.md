---
title: "Package designer: Add & remove features and items to package"
ms.date: "02/02/2017"
ms.topic: "conceptual"
f1_keywords:
  - "VS.SharePointTools.RAD.PackageDesignerDesign"
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
# How to: Add and remove features and items to a package by using the Package Designer
  When you create a SharePoint solution, Visual Studio adds the default SharePoint Features to the package in the solution. Before final deployment, you can add and remove SharePoint project items and Features to modify the SharePoint package.

 Alternatively, you can use the Packaging Explorer to add and remove SharePoint project items. You can also view and change the hierarchy of the SharePoint project items and Features that are put into the package (.wsp). For more information, see [How to: Add and remove features and items to a Package by using the Packaging Explorer](../sharepoint/how-to-add-and-remove-features-and-items-to-a-package-by-using-the-packaging-explorer.md).

## Add features to a SharePoint package
 You can use the Package Designer to add Features to a SharePoint package.

#### To add SharePoint features with the package designer

1. Open the **Package Designer**.

    For more information, see [How to: Customize a SharePoint solution package](../sharepoint/how-to-customize-a-sharepoint-solution-package.md).

2. Add one or more SharePoint Features by performing one or more of the following steps:

   1. Double-click each item in the **Items in the Solution** list that you want to add.

   2. Choose an item that you want to add, and then choose the **Add** button (>).

   3. Choose the **Add All** button (>>) to add all items at once.

      For example, you can double-click an item in the **Items in the Solution** list to add it to the **Items in the Package** list.

      The SharePoint Project Items and Features appear in the **Items in the Package** list.

## Remove Features from a SharePoint Package
 You can use the Package Designer to remove Features to a SharePoint package.

#### To remove SharePoint features with the package designer

1. In the **Items in the Package** list, choose an item that you want to remove, and then choose the **Remove** (<) button, or choose the **Remove All** button (<<) to remove all the items.

     The SharePoint Items appear in the **Items in the Solution** list.

## See also
- [Create SharePoint solution packages](../sharepoint/creating-sharepoint-solution-packages.md)
- [How to: Customize a SharePoint solution package](../sharepoint/how-to-customize-a-sharepoint-solution-package.md)
- [How to: Create a Package](https://msdn.microsoft.com/b24be45c-e91d-49bb-afb0-7b265404214b)
