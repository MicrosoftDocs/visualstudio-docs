---
title: "Packaging Explorer: Add & remove features & items to package"
titleSuffix: ""
description: Add and remove features and items to a SharePoint package by using the Packaging Explorer in Visual Studio.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
f1_keywords:
  - "VS.SharePointTools.RAD.PackagingExplorer"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, packages"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# How to: Add and remove features and items to a Package by using the Packaging Explorer
  To configure a package to deploy SharePoint items and Features, you can use the Packaging Explorer. You can adjust the SharePoint project items and Features inside your .wsp file.

 Alternatively, you can use the Packaging Designer to view and re-order the Features to change the activation order. For more information, see [How to: Add and remove features and items to a package by using the Package Designer](../sharepoint/how-to-add-and-remove-features-and-items-to-a-package-by-using-the-package-designer.md).

## Open the Packaging Explorer
 You can use the following procedure to open the Packaging Explorer, if your Visual Studio solution has at least one SharePoint project. Alternatively, the Packaging Explorer opens automatically when you view a Feature or package designer. After you close all Feature and package designers, the Packaging Explorer also closes.

#### To open the Packaging Explorer

1. On the menu bar, choose **View** > **Other Windows** > **Packaging Explorer**.

     The **Packaging Explorer** appears in the **Toolbox**.

## Adding a feature to a package
 You can add new and existing Features to a Package by using the Packaging Explorer.

#### To add a SharePoint feature

1. Open the **Packaging Explorer**, open the shortcut menu for the project, and then choose **Add Feature**.

#### To move an existing SharePoint Feature

1. Open the **Packaging Explorer**, and then perform one of the following steps:

    - Drag a **Feature** from one project to another project.

    - Open the shortcut menu for a Feature, choose **Cut**, open the shortcut menu for the project to which you want to move the Feature, and then choose **Paste**.

    > [!NOTE]
    > Use this procedure if you have more than one SharePoint project in your solution.

## Validate a feature or package
 You can identify potential problems in the SharePoint Features and packages by validating the files. Warnings and errors are displayed in the Output window and Error List window.

#### To validate a SharePoint feature or package

1. Open the **Packaging Explorer**.

2. Open a shortcut menu for a Feature or package, and then choose **Validate**.

## See also
- [Package and deploy SharePoint solutions](../sharepoint/packaging-and-deploying-sharepoint-solutions.md)
