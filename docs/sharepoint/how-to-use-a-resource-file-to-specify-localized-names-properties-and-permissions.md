---
title: "How to use a Resource File in a SharePoint project | Microsoft Docs"
titleSuffix: ""
description: Use a resource file in a SharePoint project so that you can provide localized names, define properties, and apply permissions for objects defined in a BDC model.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Business Data Connectivity service [SharePoint development in Visual Studio], localize strings"
  - "BDC [SharePoint development in Visual Studio], localize strings"
  - "BDC [SharePoint development in Visual Studio], resource file"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], resource strings"
  - "BDC [SharePoint development in Visual Studio], properties"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], properties"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], resource file"
  - "BDC [SharePoint development in Visual Studio], resource strings"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# How to use a Resource File in a SharePoint project

  By using a resource file, you can provide localized names, define properties, and apply permissions tor objects that are defined in a Business Data Connectivity (BDC) model. To specify this information, you add a **Business Data Connectivity Resource** item to a project that contains a **Business Data Connectivity Model** item. Then you specify names, properties and permissions by editing the XML for the resource file.

### To add a BDC resource file to a SharePoint project

1. In **Solution Explorer**, expand the folder for the SharePoint project, and then choose the folder that contains the BDC model.

2. On the menu bar, choose **Project** > **Add New Item**.

3. Expand the **SharePoint** node, and then choose the **2010** node.

4. In the **Add New Item** dialog box, choose **Business Data Connectivity Resource Item**.

5. In the **Name** box, specify the name of the resource file, and then choose the **Add** button.

     A resource file that has the .bdcr extension is added to the project and opened for editing.

6. Add XML to define the localized names, properties, and permissions that you want to apply the BDC model.

     For information about how to define these elements, see [Model and Resource Files](/previous-versions/office/developer/sharepoint-2010/aa674515(v=office.14)).

## See also
- [How to: Add an existing BDC model file to a SharePoint project](../sharepoint/how-to-add-an-existing-bdc-model-file-to-a-sharepoint-project.md)
- [Create a business data connectivity model](../sharepoint/creating-a-business-data-connectivity-model.md)
- [How to: Create a BDC model](../sharepoint/how-to-create-a-bdc-model.md)
- [How to: Include a custom assembly in a BDC feature](../sharepoint/how-to-include-a-custom-assembly-in-a-bdc-feature.md)
- [Integrating business data into SharePoint](../sharepoint/integrating-business-data-into-sharepoint.md)
