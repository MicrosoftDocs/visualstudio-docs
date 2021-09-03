---
title: "How to: Add and Remove Feature Dependencies | Microsoft Docs"
description: Review how to add and remove feature dependencies to your SharePoint solution using the Feature Designer in Visual Studio.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
f1_keywords:
  - "MICROSOFT.VISUALSTUDIO.SHAREPOINT.DESIGNERS.CUSTOMDEPENDENCYWINDOW"
  - "VS.SHAREPOINTTOOLS.RAD.FEATUREDESIGNERDEPENDENCY"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, features"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# How to: Add and remove feature dependencies
  Your SharePoint Feature may depend on other Features for functionality or data. In these cases, you can mark these other Features as dependencies for your Feature. This way, the SharePoint server ensures that dependent Features are activated before your Feature is activated.

## Add dependencies
 You can add other Features in your solution as dependencies. This way, you can make sure that required Features are installed and activated before your feature is installed.

#### To add a dependency on a feature in the solution

1. Open the Feature Designer, expand the **Feature Activation Dependencies** node, and then choose the **Add** button.

2. In the **Add Feature Activation Dependencies** dialog box, choose the **Add a dependency on features in the solution** option button, choose the title of the feature that you want to add as a dependency, and then choose the **Add** button.

     You can add more than one feature by choosing multiple titles while choosing the **Ctrl** key.

## Addi custom dependencies
 You can add Features that are already deployed on a SharePoint server as a dependency. This way, the SharePoint activation process checks to make sure that all dependent Features are activated before your Feature is installed.

#### To add a dependency by the feature ID

1. Open the Feature Designer, expand the **Feature Activation Dependencies** node, and then choose the **Add** button.

2. In the **Add Feature Activation Dependencies** dialog box, choose the **Add a custom dependency** option button.

3. In the **Feature ID** text box, enter the GUID for the Feature that you want to mark as an activation dependency, and then choose the **Add** button.

## Edit custom dependencies
 You can edit custom dependencies that you added previously. However, dependent Features that are in your solution can only be removed, not edited.

#### To change a dependency on a feature in the solution

1. Open the Feature Designer, and then expand the **Feature Activation Dependencies** node.

2. Choose the name of the feature that you want to edit, and then choose the **Edit** button.

3. In the **Edit Custom Feature Activation Dependency** dialog box, change the title, Feature ID, or description, and then choose the **Submit** button.

## Remove dependencies

#### To remove a dependency on a feature in the solution

1. In the Feature Designer, expand the **Feature Activation Dependencies** node, choose the name of the feature that you want to remove, and then choose the **Remove** button.

## See also
- [Create SharePoint features](../sharepoint/creating-sharepoint-features.md)
- [How to: Customize a SharePoint feature](../sharepoint/how-to-customize-a-sharepoint-feature.md)
- [How to: Add and remove items to SharePoint features](../sharepoint/how-to-add-and-remove-items-to-sharepoint-features.md)
