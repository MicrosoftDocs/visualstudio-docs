---
title: "How to: Connect to Data in a Service | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords:
  - "data [Visual Studio], connecting to Web services"
  - "data sources, creating from Web services"
  - "data [Visual Studio], reading from Web services"
  - "reading data, from Web services"
  - "Web services, reading data"
  - "Web services, as data sources"
  - "Web services, connecting"
ms.assetid: a6b54353-05fe-4e5c-8631-90231fc95504
caps.latest.revision: 35
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Connect to Data in a Service
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You connect your application to the data returned from a service by running the [Data Source Configuration Wizard](https://msdn.microsoft.com/library/c4df7de5-5da0-4064-940c-761dd6d9e28f) and selecting **Service** on the **Choose a Data Source Type** page.

 Upon completion of the wizard, a service reference is added to your project and is immediately available in the [Data Sources Window](https://msdn.microsoft.com/library/0d20f699-cc95-45b3-8ecb-c7edf1f67992).

> [!NOTE]
> The items that appear in the **Data Sources** window are dependent on the information that the service returns. Some services might not provide enough information for the **Data Source Configuration Wizard** to create bindable objects. For example, if the service returns an untyped dataset, then no items appear in the **Data Sources Window** upon completing the wizard. This is because untyped datasets do not provide schema, so the wizard does not have enough information to create the data source.

 [!INCLUDE[note_settings_general](../includes/note-settings-general-md.md)]

### To connect your application to a service

1. On the **Data** menu, click **Add New Data Source**.

2. Select **Service** on the **Choose a Data Source Type** page, and then click **Next**.

3. Enter the address of the service you want to use, or click **Discover** to locate services in the current solution, and then click **Go**.

4. Optionally, a new **Namespace** can be typed in place of the default value.

    > [!NOTE]
    > Click **Advanced** to open the [Configure Service Reference Dialog Box](../data-tools/configure-service-reference-dialog-box.md).

5. Click **OK** to add a service reference to your project.

6. Click **Finish**.

     The data source is added to the **Data Sources** window.

## Next Steps

#### To add functionality to your application

- Select an item in the **Data Sources** window and drag it onto a form to create bound controls. For more information, see [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md).

## See Also
 [Bind WPF controls to a WCF data service](../data-tools/bind-wpf-controls-to-a-wcf-data-service.md)
 [Windows Communication Foundation Services and WCF Data Services in Visual Studio](../data-tools/windows-communication-foundation-services-and-wcf-data-services-in-visual-studio.md)
