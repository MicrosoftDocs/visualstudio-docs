---
title: Windows Communication Foundation and Data Services
description: Explore Windows Communication Foundation (WCF) Services and WCF Data Services in Visual Studio, and create distributed applications.
ms.date: 07/03/2025
ms.topic: concept-article
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- services, WCF Data
- WCF services, binding to
- WCF services, asynchronous service methods
- service references [Visual Studio]
- WCF Data Services
- asynchronous calls
- service references [Visual Studio], type sharing
- endpoints [WCF]
- asynchronous service methods
- service references [Visual Studio] endpoints
- WCF services, type sharing
- Windows Communication Foundation, in Visual Studio
- services, WCF
- WCF service, Visual Studio
- data services, WCF
- services, in Visual Studio
- data binding [Visual Studio], WCF
- service endpoints [Visual Studio]
- service references [Visual Studio], asynchronous calls
- services, Windows Communication Foundation
- type sharing in WCF services
- WCF services, endpoints
- service method, called asynchronously[Visual Studio]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
#customer intent: As a developer, I want to explore WCF Services and WCF Data Services in Visual Studio, so I can create distributed applications.
---

# Windows Communication Foundation Services and WCF Data Services in Visual Studio

Visual Studio provides tools for working with Windows Communication Foundation (WCF) and WCF Data Services, Microsoft technologies for creating distributed applications. This article provides an introduction to services from a Visual Studio perspective. For the full documentation, see [WCF Data Services 4.5](/dotnet/framework/data/wcf/index).

Windows Communication Foundation (WCF) is a unified framework for creating secure, reliable, transacted, and interoperable distributed applications. It replaces older interprocess communication technologies such as ASMX web services, .NET Remoting, Enterprise Services (Distributed Component Object Model (DCOM)), and Microsoft Message Queue (MSMQ). WCF brings together the functionality of all these technologies under a unified programming model. This approach simplifies the experience of developing distributed applications.

## WCF Data Services

WCF Data Services is an implementation of the Open Data (Open Data Protocol (OData)) Protocol standard. WCF Data Services lets you expose tabular data as a set of REST APIs, which allows you to return data by using standard HTTP commands like `GET`, `POST`, `PUT`, and `DELETE`. On the server side, [ASP.NET Web API](https://dotnet.microsoft.com/apps/aspnet/apis) supersedes WCF Data Services for creating new OData services. The WCF Data Services client library continues to be a good choice for consuming OData services in a .NET application from Visual Studio (**Project** > **Add Service Reference**). For more information, see [WCF Data Services 4.5](/dotnet/framework/data/wcf).

## WCF programming model

The WCF programming model is based on communication between two entities: a WCF service and a WCF client. The programming model is encapsulated in the <xref:System.ServiceModel> namespace in .NET.

## WCF service

A WCF service is based on an interface that defines a contract between the service and the client. The service is marked with a <xref:System.ServiceModel.ServiceContractAttribute> attribute, as shown in the following code:

### [C#](#tab/csharp)

:::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/wcfwalkthrough/cs/iservice1.cs" id="Snippet6":::

### [VB](#tab/vb)

:::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/wcfwalkthrough/vb/iservice1.vb" id="Snippet6":::
---

You define functions or methods that are exposed by a WCF service by marking them with an <xref:System.ServiceModel.OperationContractAttribute> attribute.

### [C#](#tab/csharp)

:::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/wcfwalkthrough/cs/iservice1.cs" id="Snippet1":::

### [VB](#tab/vb)

:::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/wcfwalkthrough/vb/iservice1.vb" id="Snippet1":::
---

You can also expose serialized data by marking a composite type with a <xref:System.Runtime.Serialization.DataContractAttribute> attribute, which enables data binding in a client.

After an interface and its methods are defined, they're encapsulated in a class that implements the interface. A single WCF service class can implement multiple service contracts.

A WCF service is exposed for consumption through what is known as an *endpoint*. The endpoint provides the only way to communicate with the service. You can't access the service through a direct reference as you do other classes.

An endpoint consists of an address, a binding, and a contract. The address defines where the service is located, such as a URL, a File Transfer Protocol (FTP) address, or a network or local path. A binding defines the way you communicate with the service. WCF bindings provide a versatile model for specifying a protocol like HTTP or FTP with a security mechanism like Windows Authentication or user names and passwords. A contract includes the operations exposed by the WCF service class.

Multiple endpoints can be exposed for a single WCF service. This approach enables different clients to communicate with the same service in different ways. For example, a banking service might provide one endpoint for employees and another for external customers, where each uses a different address, binding, or contract.

### WCF client

A WCF client consists of a *proxy* that enables an application to communicate with a WCF service, and an endpoint that matches an endpoint defined for the service. The proxy is generated on the client side in the *app.config* file and includes information about the types and methods that are exposed by the service. For services that expose multiple endpoints, the client can select the one that best fits its needs, for example, to communicate over HTTP and use Windows Authentication.

After a WCF client is created, you reference the service in your code just as you do any other object. For example, to call the `GetData` method shown earlier, you write code that resembles the following example:

### [C#](#tab/csharp)

:::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/wcfwalkthrough/cs/form1.cs" id="Snippet3":::

### [VB](#tab/vb)

:::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/wcfwalkthrough/vb/form1.vb" id="Snippet3":::
---

## WCF tools in Visual Studio

Visual Studio provides tools to help you create both WCF services and WCF clients. For more information, see [Walkthrough: Creating a simple WCF service in Windows Forms](../data-tools/walkthrough-creating-a-simple-wcf-service-in-windows-forms.md).

### Create and test WCF services

You can use the WCF Visual Studio templates as a foundation to quickly create your own service. You can then use WCF Service Auto Host and WCF Test Client to debug and test the service. These tools provide a fast and convenient debug and testing cycle, and eliminate the requirement to commit to a hosting model at an early stage.

#### WCF templates

WCF Visual Studio templates provide a basic class structure for service development. Several WCF templates are available in the **Add New Project** dialog, including WCF service library projects, WCF service websites, and WCF Service item templates.

When you select a template, files are added for a service contract, a service implementation, and a service configuration. All necessary attributes are already added, creating a simple "Hello World" type of service, and you didn't have to write any code. You can add code to provide functions and methods for your real world service, but the templates provide the basic foundation.

For more information, see [WCF Visual Studio templates](/dotnet/framework/wcf/wcf-vs-templates).

#### WCF Service Host

When you start the Visual Studio Debugger (by selecting **F5**) for a WCF service project, the WCF Service Host tool is automatically started to host the service locally. The tool enumerates the services in a WCF service project, loads the project's configuration, and instantiates a host for each service it finds.

The tool helps you test a WCF service without writing extra code or committing to a specific host during development. For more information, see [WCF service host (WcfSvcHost.exe)](/dotnet/framework/wcf/wcf-service-host-wcfsvchost-exe).

#### WCF Test Client

The WCF Test Client tool enables you to input test parameters, submit the input to a WCF service, and view the response from the service. The tool provides a convenient service testing experience when you combine it with WCF Service Host. The folder location of the tool is *%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Enterprise\Common7\IDE*.

When you select **F5** to debug a WCF service project, WCF Test Client opens and displays a list of service endpoints defined in the configuration file. You can test the parameters and start the service, and repeat this process to continuously test and validate your service. For more information, see [WCF Test Client (WcfTestClient.exe)](/dotnet/framework/wcf/wcf-test-client-wcftestclient-exe).

### Access WCF services in Visual Studio

Visual Studio simplifies the task of creating WCF clients by automatically generating a proxy and endpoint for services you add in the **Add Service Reference** dialog. All necessary configuration information is added to the *app.config* file. Most of the time, all you have to do is instantiate the service to start using it.

In the **Add Service Reference** dialog, you specify the address for a service or search for a service defined in your solution. The system returns a list of services and operations provided by the services. You can also define the namespace for referencing the services in code.

In the **Configure Service References** dialog, you customize the configuration for a service. You can change the address for a service, specify access level, asynchronous behavior, and message contract types, and configure type reuse.

## Service endpoint

Some WCF services expose multiple endpoints through which clients can communicate with the service. A service might expose one endpoint that uses an HTTP binding with a user name and password security and a second endpoint that uses FTP with Windows Authentication. The first endpoint is used by applications to access the service from outside a firewall, whereas the second can be used in an intranet.

In this scenario, you specify the `endpointConfigurationName` parameter with the constructor for a service reference.

[!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]

### Select service endpoint

Select a service endpoint by following these steps:

1. Add a reference to a WCF service by right-clicking the project node in **Solution Explorer** and selecting **Add service reference**.

1. In the Code Editor, add a constructor for the service reference. Replace `ServiceReference` with the namespace for the service reference, and replace `Service1Client` with the name of the service.

   ### [C#](#tab/csharp)

   ```csharp
   ServiceReference.Service1Client proxy = new ServiceReference.Service1Client(
   ```

   ### [VB](#tab/vb)

   ```vb
   Dim proxy As New ServiceReference.Service1Client(
   ```

   ---

1. When you enter the code, an IntelliSense list displays that includes the overloads for the constructor. Select the `endpointConfigurationName As String` overload.

1. After you select the overload, enter `="<ServiceEndpoint>"`, where `<ServiceEndpoint>` is the name of the endpoint service you want to use.

   > [!TIP]
   > The names of the available endpoints are defined in the *app.config* file.

### Find available endpoints for WCF service

To find the available endpoints for a WCF service, follow these steps:

1. In **Solution Explorer**, right-click the *app.config* file for the project that contains the service reference, and then select **Open**. The file opens in the Code Editor.

1. Search for the `<Client>` tag in the file.

1. In the `<Client>` tag section, search for a nested tag that starts with `<Endpoint>`.

   When the service reference provides multiple endpoints, there are two or more `<Endpoint>` tags.

1. In the `<EndPoint>` tag definition, locate the `name="<ServiceEndpoint>"` parameter (where `<ServiceEndpoint>` represents an endpoint name for the service). This value is the name for the service endpoint that can be passed to the `endpointConfigurationName As String` overload of a constructor for a service reference.

## Call service methods asynchronously

Most methods in WCF services can be called synchronously or asynchronously. When you call a method asynchronously, your application can continue to work while the method is being called. This approach is useful when the system operates over a slow connection.

When a service reference is added to a project, the default configuration is to call methods synchronously. You can change the behavior to call methods asynchronously in the **Configure Service Reference** dialog.

The option is set on a **per-service** basis. If one method for a service is called asynchronously, all methods must be called asynchronously.

[!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]

### Call a method asynchronously

To call a service method asynchronously, follow these steps:

1. In **Solution Explorer**, select the service reference.

1. Select **Project** > **Configure Service Reference**.

1. In the **Configure Service Reference** dialog, select the **Generate asynchronous operations** checkbox.

## Bind data returned by service

You can bind data returned by a WCF service to a control just as you bind any other data source to a control. When you add a reference to a WCF service, if the service contains composite types that return data, they're automatically added to the **Data Sources** window.

### Bind control to data field returned by WCF service

To bind a control to a single data field returned by a WCF service, use these steps:

1. Select **Data** > **Show Data Sources**. The **Data Sources** window opens.

1. In the **Data Sources** window, expand the node for your service reference. Any composite types returned by the service display.

1. Expand a type node and view the data fields for the type.

1. Select a field and expand the dropdown list to see the list of available controls for the data type.

1. Select the type of control to which you want to bind.

1. Drag the field onto a form. The control is added to the form along with a <xref:System.Windows.Forms.BindingSource> component and a <xref:System.Windows.Forms.BindingNavigator> component.

1. Repeat steps 4 though 6 and bind any other fields.

### Bind control to composite type returned by WCF service

To bind a control to a composite type returned by a WCF service, follow these steps:

1. Select **Data** > **Show Data Sources**. The **Data Sources** window opens.

1. In the **Data Sources** window, expand the node for your service reference. Any composite types returned by the service display.

1. Select a node for a type and expand the dropdown list to see the list of available options.

1. Select **DataGridView** and view the data in a grid, or select **Details** and view the data by using individual controls.

1. Drag the node onto the form. The controls are added to the form along with a <xref:System.Windows.Forms.BindingSource> component and a <xref:System.Windows.Forms.BindingNavigator> component.

## Configure services to reuse existing types

When a service reference is added to a project, any types defined in the service are generated in the local project. In many cases, this approach creates duplicate types when a service uses common .NET types or when types are defined in a shared library.

To avoid this problem, types in referenced assemblies are shared by default. If you want to disable type sharing for one or more assemblies, change the settings in the **Configure Service References** dialog.

### Disable type sharing in one assembly

You can disable type sharing in a single assembly by following these steps:

1. In **Solution Explorer**, select the service reference.

1. Select **Project** > **Configure Service Reference**.

1. In the **Configure Service References** dialog, select the **Reuse types in specified referenced assemblies** checkbox.

1. Select the checkbox for each assembly where you want to enable type sharing. To disable type sharing for an assembly, leave the checkbox cleared.

### Disable type sharing in all assemblies

You can also disable type sharing in all assemblies with the following steps:

1. In **Solution Explorer**, select the service reference.

1. Select **Project** > **Configure Service Reference**.

1. In the **Configure Service References** dialog, clear the **Reuse types in referenced assemblies** checkbox.

## Explore similar concepts

The following articles describe concepts and procedures related to WCF services and WCF data services.

| Title | Description |
| - | - |
| [Walkthrough: Create a basic WCF service in Windows Forms](../data-tools/walkthrough-creating-a-simple-wcf-service-in-windows-forms.md) | Provides a step-by-step demonstration of creating and using WCF services in Visual Studio. |
| [Walkthrough: Create a WCF data service with WPF and Entity Framework](../data-tools/walkthrough-creating-a-wcf-data-service-with-wpf-and-entity-framework.md) | Provides a step-by-step demonstration of how to create and use WCF Data Services in Visual Studio. |
| [Use the WCF development tools](/dotnet/framework/wcf/using-the-wcf-development-tools) | Describes how to create and test WCF services in Visual Studio. |
| [How to: Add, update, or remove a WCF data service reference](../data-tools/how-to-add-update-or-remove-a-wcf-data-service-reference.md) | Describes how to use the Add Service Reference dialog to search for WCF Data Services in the solution. |
| [Troubleshoot service references](../data-tools/troubleshooting-service-references.md) | Presents some common errors that can occur with service references and how to prevent them. |
| [Debug WCF services](../debugger/debugging-wcf-services.md) | Describes common debugging problems and techniques you might encounter when debugging WCF services. |
| [Walkthrough: Create an n-tier data application](../data-tools/walkthrough-creating-an-n-tier-data-application.md) | Provides step-by-step instructions for creating a typed dataset and separating the TableAdapter and dataset code into multiple projects. |
| Review the [Configure Service Reference dialog](../data-tools/configure-service-reference-dialog-box.md) | Describes the user interface elements of the **Configure Service Reference** dialog. |

## Related content

- [Visual Studio data tools for .NET](../data-tools/visual-studio-data-tools-for-dotnet.md)
- <xref:System.ServiceModel> namespace
- <xref:System.Data.Services> namespace
