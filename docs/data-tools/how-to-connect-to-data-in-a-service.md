---
title: 'How to: Connect to Data in a Service'
description: Connect your app to data returned from a service by running the Data Source Configuration Wizard and selecting Service on the Choose a Data Source Type page.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- data [Visual Studio], connecting to web services
- data sources, creating from web services
- data [Visual Studio], reading from web services
- reading data, from web services
- web services, reading data
- web services, as data sources
- web services, connecting
ms.assetid: a6b54353-05fe-4e5c-8631-90231fc95504
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: vs-data-tools
ms.workload:
- data-storage
---
# How to: Connect to data in a service

You connect your application to the data returned from a service by running the [Data Source Configuration Wizard](../data-tools/media/data-source-configuration-wizard.png) and selecting **Service** on the **Choose a Data Source Type** page.

Upon completion of the wizard, a service reference is added to your project and is immediately available in the [Data Sources window](add-new-data-sources.md#data-sources-window).

> [!NOTE]
> The items that appear in the **Data Sources** window are dependent on the information that the service returns. Some services might not provide enough information for the **Data Source Configuration Wizard** to create bindable objects. For example, if the service returns an untyped dataset, no items appear in the **Data Sources** window upon completing the wizard. This is because untyped datasets do not provide schema, so the wizard does not have enough information to create the data source.

[!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]

## To connect your application to a service

1. On the **Data** menu, click **Add New Data Source**.

2. Select **Service** on the **Choose a Data Source Type** page, and then click **Next**.

3. Enter the address of the service you want to use, or click **Discover** to locate services in the current solution, and then click **Go**.

4. Optionally, you can type a new **Namespace** in place of the default value.

    > [!NOTE]
    > Click **Advanced** to open the [Configure Service Reference dialog box](../data-tools/configure-service-reference-dialog-box.md).

5. Click **OK** to add a service reference to your project.

6. Click **Finish**.

     The data source is added to the **Data Sources** window.

## Next steps

To add functionality to your application, select an item in the **Data Sources** window and drag it onto a form to create bound controls. For more information, see [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md).

## See also

- [Bind WPF controls to a WCF data service](../data-tools/bind-wpf-controls-to-a-wcf-data-service.md)
- [Windows Communication Foundation Services and WCF data services in Visual Studio](../data-tools/windows-communication-foundation-services-and-wcf-data-services-in-visual-studio.md)
