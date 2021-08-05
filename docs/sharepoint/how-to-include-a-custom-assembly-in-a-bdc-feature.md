---
title: "How to: Include a Custom Assembly in a BDC Feature | Microsoft Docs"
description: Include custom assemblies in a business data connectivity (BDC) feature so that your project can reference assemblies from other projects in the same solution.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
f1_keywords:
  - "VS.SharePointTools.BDC.Add_Assemblies_Dialog"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Business Data Connectivity service [SharePoint development in Visual Studio], add reference"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], custom assembly"
  - "BDC [SharePoint development in Visual Studio], custom assembly"
  - "BDC [SharePoint development in Visual Studio], add reference"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# How to: Include a custom assembly in a BDC feature
  Your project can reference assemblies from other projects in the same solution. However, you must add these assemblies to the feature file of the project by using the **Assign referenced assemblies to LobSystems** dialog box.

### To include a custom assembly in a business data connectivity (BDC) feature

1. In **Solution Explorer**, choose the folder that contains the BDC model.

2. On the **View** menu, click **Properties Window**.

3. In the **Properties** window, choose the **Assemblies** property, and then the ellipsis button (![ASP.NET Mobile Designer ellipse](../sharepoint/media/mwellipsis.gif "ASP.NET Mobile Designer ellipse")).

     The **Assign referenced assemblies to LobSystems** dialog box appears.

4. In the **Select an Assembly** list, choose the custom assembly.

    > [!NOTE]
    > Assemblies only appear in the **Assign referenced assemblies to LobSystems** dialog box if you have added a reference to the project that contains the assembly. For more information, see [How to: Add or Remove References By Using the Add Reference Dialog Box](/previous-versions/wkze6zky(v=vs.140)).

5. In the **Reference Properties** group, open the list that appears for the **LobSystem Scope** property, choose the LOB System of the methods that use the custom assembly, and then choose the **OK** button.

    > [!NOTE]
    > To debug code in the custom assembly, you must add the assembly to the solution package. For more information, see [How to: Add and remove additional assemblies](../sharepoint/how-to-add-and-remove-additional-assemblies.md).

## See also
- [How to: Use a resource file to specify localized names, properties, and permissions](../sharepoint/how-to-use-a-resource-file-to-specify-localized-names-properties-and-permissions.md)
- [How to: Add an existing BDC model file to a SharePoint project](../sharepoint/how-to-add-an-existing-bdc-model-file-to-a-sharepoint-project.md)
- [Create a business data connectivity model](../sharepoint/creating-a-business-data-connectivity-model.md)
- [How to: Create a BDC model](../sharepoint/how-to-create-a-bdc-model.md)
- [Integragte business data into SharePoint](../sharepoint/integrating-business-data-into-sharepoint.md)