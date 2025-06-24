---
title: Configure Service Reference Dialog Box
description: Use the Configure Service Reference dialog box in Visual Studio to configure the behavior of Windows Communication Foundation (WCF) services.
ms.date: 11/04/2016
ms.topic: ui-reference
f1_keywords:
- msvse_wcf.dlg.ConfigureServiceReference
helpviewer_keywords:
- WCF services, Configure Service Reference dialog box
- service references [Visual Studio], configuring behavior
- Configure Service Reference dialog box
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Configure Service Reference dialog box

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

The **Configure Service Reference** dialog box enables you to configure the behavior of Windows Communication Foundation (WCF) services.

To access the **Configure Service Reference** dialog box, right-click a service reference in **Solution Explorer** and choose **Configure Service Reference**. You can also access the dialog box by clicking the **Advanced** button in the **Add Service Reference Dialog Box**.

## Task list

- To change the address where a WCF service is hosted, enter the new address in the **Address** field.

- To change the access level for classes in a WCF client, select an access-level keyword in the **Access level for generated classes** list.

- To call the methods of a WCF service asynchronously, select the **Generate asynchronous operations** checkbox.

- To generate message contract types in a WCF client, select the **Always generate message contracts** checkbox.

- To specify list or dictionary collection types for a WCF client, select the types from the **Collection type** and **Dictionary collection type** lists.

- To disable type sharing, clear the **Reuse types in referenced assemblies** checkbox. To enable type sharing for a subset of referenced assemblies, select the **Reuse types in referenced assemblies** checkbox, select **Reuse types in specified referenced assemblies**, and select the desired references in the **Referenced assemblies list**.

## UIElement list

**Address**

Updates the web address where a service reference looks for a service. For example, during development, the service might be hosted on a development server and then later moved to a production server, necessitating an address change.

> [!NOTE]
> The Address element is not available when the **Configure Service Reference** dialog box is displayed from the **Add Service Reference Dialog Box**.

**Access level for generated classes**

Determines the code access level for WCF client classes.

> [!NOTE]
> For Website projects, this option is always set to `Public` and cannot be changed. For more information, see [Troubleshooting service references](/troubleshoot/developer/visualstudio/tools-utilities/troubleshooting-service-references).

**Generate asynchronous operations**

Determines whether WCF service methods is called synchronously (the default) or asynchronously.

**Generate task-based operations**

When writing async code, this option lets you take advantage of the Task Parallel Library (TPL) that was introduced with .NET 4. See [Task Parallel Library (TPL)](/dotnet/standard/parallel-programming/task-parallel-library-tpl).

**Always generate message contracts**

Determines whether message contract types are generated for a WCF client. For more information about message contracts, see [Using message contracts](/dotnet/framework/wcf/feature-details/using-message-contracts).

**Collection type**

Specifies the list collection type for a WCF client. The default type is <xref:System.Array>.

**Dictionary collection type**

Specifies the dictionary collection type for a WCF client. The default type is <xref:System.Collections.Generic.Dictionary%602>.

**Reuse types in referenced assemblies**

Determines whether a WCF client tries to reuse what already exists in referenced assemblies instead of generating new types when a service is added or updated. By default, this option is checked.

**Reuse types in all referenced assemblies**

When selected, all types in the **Referenced assemblies list** are reused if possible. By default, this option is selected.

**Reuse types in specified referenced assemblies**

When selected, only the selected types in the **Referenced assemblies list** are reused.

**Referenced assemblies list**

Contains a list of referenced assemblies for the project or website. When you select **Reuse types in specified referenced assemblies**, you can select or clear individual assemblies.

**Add Web Reference**

Displays the **Add Web Reference** dialog box.

> [!NOTE]
> This option should only be used for projects that target version 2.0 of the .NET Framework.
>
> [!NOTE]
> The **Add Web Reference** button is only available when the **Configure Service Reference** dialog box is displayed from the **Add Service Reference Dialog Box**.

## See also

- [How to: Add a reference to a web service](how-to-add-update-or-remove-a-wcf-data-service-reference.md)
- [Windows Communication Foundation Services and WCF Data Services](../data-tools/configure-service-reference-dialog-box.md)
