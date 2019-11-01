---
title: "Configure Service Reference Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: reference
f1_keywords:
  - "msvse_wcf.dlg.ConfigureServiceReference"
helpviewer_keywords:
  - "WCF services, Configure Service Reference dialog box"
  - "service references [Visual Studio], configuring behavior"
  - "Configure Service Reference dialog box"
ms.assetid: 25e4c36b-2db6-4e71-9010-b7068255d09d
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: jillfra
---
# Configure Service Reference Dialog Box
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The **Configure Service Reference** dialog box enables you to configure the behavior of [!INCLUDE[vsindigo](../includes/vsindigo-md.md)] services.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose Import and Export Settings on the Tools menu. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).

 To access the **Configure Service Reference** dialog box, right-click a service reference in **Solution Explorer** and choose **Configure Service Reference**. You can also access the dialog box by clicking the **Advanced** button in the **Add Service Reference Dialog Box**.

## Task List

- To change the address where a WCF service is hosted, enter the new address in the **Address** field.

- To change the access level for classes in a WCF client, select an access-level keyword in the **Access level for generated classes** list.

- To call the methods of a WCF service asynchronously, select the **Generate asynchronous operations** check box.

- To generate message contract types in a WCF client, select the **Always generate message contracts** check box.

- To specify list or dictionary collection types for a WCF client, select the types from the **Collection type** and **Dictionary collection type** lists.

- To disable type sharing, clear the **Reuse types in referenced assemblies** check box. To enable type sharing for a subset of referenced assemblies, select the **Reuse types in referenced assemblies** check box, select **Reuse types in specified referenced assemblies**, and select the desired references in the **Referenced assemblies list**.

## UIElement List
 **Address**
 Used to update the Web address where a service reference looks for a service. For example, during development the service may be hosted on a development server then later moved to a production server, necessitating an address change.

> [!NOTE]
> The Address element is not available when the **Configure Service Reference** dialog box is displayed from the **Add Service Reference Dialog Box**.

 **Access level for generated classes**
 Determines the code access level for WCF client classes.

> [!NOTE]
> For Website projects, this option is always set to `Public` and cannot be changed. For more information, see [Troubleshooting Service References](../data-tools/troubleshooting-service-references.md).

 **Generate asynchronous operations**
 Determines whether WCF service methods will be called synchronously (the default) or asynchronously.

 **Generate task-based operations**
 When writing async code, this option allows you to take advantage of the Task Parallel Library (TPL) that was introduced with .Net 4. See [Task Parallel Library (TPL)](https://msdn.microsoft.com/library/dd460717.aspx).

 **Always generate message contracts**
 Determines whether message contract types will be generated for a WCF client. For more information about message contracts, see [Using Message Contracts](https://msdn.microsoft.com/library/1e19c64a-ae84-4c2f-9155-91c54a77c249).

 **Collection type**
 Specifies the list collection type for a WCF client. The default type is <xref:System.Array>.

 **Dictionary collection type**
 Specifies the dictionary collection type for a WCF client. The default type is <xref:System.Collections.Generic.Dictionary%602>.

 **Reuse types in referenced assemblies**
 Determines whether a WCF client will try to reuse that already exist in referenced assemblies instead of generating new types when a service is added or updated. By default, this option is checked.

 **Reuse types in all referenced assemblies**
 When selected, all types in the **Referenced assemblies list** will be reused if possible. By default, this option is selected.

 **Reuse types in specified referenced assemblies**
 When selected, only the selected types in the **Referenced assemblies list** will be reused.

 **Referenced assemblies list**
 Contains a list of referenced assemblies for the project or Web site. When **Reuse types in specified referenced assemblies** is selected, individual assemblies can be selected or cleared.

 **Add Web Reference**
 Displays the [NIB: Add Web Reference Dialog Box](https://msdn.microsoft.com/bdf05776-c591-40af-bfd7-e1e2aa1e87b5).

> [!NOTE]
> This option should be used only for projects that target version 2.0 of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)].

> [!NOTE]
> The **Add Web Reference** button is available only when the **Configure Service Reference** dialog box is displayed from the **Add Service Reference Dialog Box**.

## See Also
 [How to: Add, Update, or Remove a Service Reference](https://msdn.microsoft.com/library/cacc14bd-4455-4a44-be78-d2ac16113dd9)
 [How to: Add a Reference to a Web Service](https://msdn.microsoft.com/library/952e49a1-567e-4a74-8cd7-f2e7b62c3168)
 [Windows Communication Foundation Services and WCF Data Services](../data-tools/configure-service-reference-dialog-box.md)
