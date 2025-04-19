---
title: Windows Communication Foundation and Data Services
description: Explore Windows Communication Foundation (WCF) Services and WCF Data Services in Visual Studio, and create distributed applications.
ms.date: 11/01/2023
ms.topic: overview
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
---

# Windows Communication Foundation Services and WCF Data Services in Visual Studio

Visual Studio provides tools for working with Windows Communication Foundation (WCF) and WCF Data Services, Microsoft technologies for creating distributed applications. This topic provides an introduction to services from a Visual Studio perspective. For the full documentation, see [WCF Data Services 4.5](/dotnet/framework/data/wcf/index).

## What Is WCF?

Windows Communication Foundation (WCF) is a unified framework for creating secure, reliable, transacted, and interoperable distributed applications. It replaces older interprocess communication technologies such as ASMX web services, .NET Remoting, Enterprise Services (Distributed Component Object Model (DCOM)), and Microsoft Message Queue (MSMQ). WCF brings together the functionality of all those technologies under a unified programming model. This simplifies the experience of developing distributed applications.

### What are WCF Data Services

WCF Data Services is an implementation of the Open Data (Open Data Protocol (OData)) Protocol standard. WCF Data Services lets you expose tabular data as a set of REST APIs, allowing you to return data using standard HTTP verbs such as GET, POST, PUT, or DELETE. On the server side, WCF Data Services are being superseded by [ASP.NET Web API](https://dotnet.microsoft.com/apps/aspnet/apis) for creating new OData services. The WCF Data Services client library continues to be a good choice for consuming OData services in a .NET application from Visual Studio (**Project** > **Add Service Reference**). For more information, see [WCF Data Services 4.5](/dotnet/framework/data/wcf).

### WCF programming model

The WCF programming model is based on communication between two entities: a WCF service and a WCF client. The programming model is encapsulated in the <xref:System.ServiceModel> namespace in .NET.

### WCF Service

A WCF service is based on an interface that defines a contract between the service and the client. It is marked with a <xref:System.ServiceModel.ServiceContractAttribute> attribute, as shown in the following code:

### [C#](#tab/csharp)

:::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/wcfwalkthrough/cs/iservice1.cs" id="Snippet6":::

### [VB](#tab/vb)

:::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/wcfwalkthrough/vb/iservice1.vb" id="Snippet6":::
---

You define functions or methods that are exposed by a WCF service by marking them with a <xref:System.ServiceModel.OperationContractAttribute> attribute.

### [C#](#tab/csharp)

:::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/wcfwalkthrough/cs/iservice1.cs" id="Snippet1":::

### [VB](#tab/vb)

:::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/wcfwalkthrough/vb/iservice1.vb" id="Snippet1":::
---

In addition, you can expose serialized data by marking a composite type with a <xref:System.Runtime.Serialization.DataContractAttribute> attribute. This enables data binding in a client.

After an interface and its methods are defined, they are encapsulated in a class that implements the interface. A single WCF service class can implement multiple service contracts.

A WCF service is exposed for consumption through what is known as an *endpoint*. The endpoint provides the only way to communicate with the service; you cannot access the service through a direct reference as you would with other classes.

An endpoint consists of an address, a binding, and a contract. The address defines where the service is located; this could be a URL, a File Transfer Protocol (FTP) address, or a network or local path. A binding defines the way that you communicate with the service. WCF bindings provide a versatile model for specifying a protocol such as HTTP or FTP, a security mechanism such as Windows Authentication or user names and passwords, and much more. A contract includes the operations that are exposed by the WCF service class.

Multiple endpoints can be exposed for a single WCF service. This enables different clients to communicate with the same service in different ways. For example, a banking service might provide one endpoint for employees and another for external customers, each using a different address, binding, and/or contract.

### WCF client

A WCF client consists of a *proxy* that enables an application to communicate with a WCF service, and an endpoint that matches an endpoint defined for the service. The proxy is generated on the client side in the *app.config* file and includes information about the types and methods that are exposed by the service. For services that expose multiple endpoints, the client can select the one that best fits its needs, for example, to communicate over HTTP and use Windows Authentication.

After a WCF client has been created, you reference the service in your code just as you would any other object. For example, to call the `GetData` method shown earlier, you would write code that resembles the following:

### [C#](#tab/csharp)

:::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/wcfwalkthrough/cs/form1.cs" id="Snippet3":::

### [VB](#tab/vb)

:::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/wcfwalkthrough/vb/form1.vb" id="Snippet3":::
---

## WCF tools in Visual Studio

Visual Studio provides tools to help you create both WCF services and WCF clients. For a walkthrough that demonstrates the tools, see [Walkthrough: Creating a simple WCF service in Windows Forms](../data-tools/walkthrough-creating-a-simple-wcf-service-in-windows-forms.md).

### Create and test WCF services

You can use the WCF Visual Studio templates as a foundation to quickly create your own service. You can then use WCF Service Auto Host and WCF Test Client to debug and test the service. These tools together provide a fast and convenient debug and testing cycle, and eliminate the requirement to commit to a hosting model at an early stage.

#### WCF Templates

WCF Visual Studio templates provide a basic class structure for service development. Several WCF templates are available in the **Add New Project** dialog box. These include WCF service library projects, WCF service websites, and WCF Service item templates.

When you select a template, files are added for a service contract, a service implementation, and a service configuration. All necessary attributes are already added, creating a simple "Hello World" type of service, and you did not have to write any code. You will, of course, want to add code to provide functions and methods for your real world service, but the templates provide the basic foundation.

To learn more about WCF templates, see [WCF Visual Studio templates](/dotnet/framework/wcf/wcf-vs-templates).

#### WCF service host

When you start the Visual Studio debugger (by pressing **F5**) for a WCF service project, the WCF Service Host tool is automatically started to host the service locally. WCF Service Host enumerates the services in a WCF service project, loads the project's configuration, and instantiates a host for each service that it finds.

By using WCF Service Host, you can test a WCF service without writing extra code or committing to a specific host during development.

To learn more about WCF Service Host, see [WCF service host (WcfSvcHost.exe)](/dotnet/framework/wcf/wcf-service-host-wcfsvchost-exe).

#### WCF test client

The WCF Test Client tool enables you to input test parameters, submit that input to a WCF service, and view the response that the service sends back. It provides a convenient service testing experience when you combine it with WCF Service Host. Find the tool in the *%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Enterprise\Common7\IDE* folder.

When you press **F5** to debug a WCF service project, WCF Test Client opens and displays a list of service endpoints that are defined in the configuration file. You can test the parameters and start the service, and repeat this process to continuously test and validate your service.

To learn more about WCF Test Client, see [WCF test client (WcfTestClient.exe)](/dotnet/framework/wcf/wcf-test-client-wcftestclient-exe).

### Accessing WCF services in Visual Studio

Visual Studio simplifies the task of creating WCF clients, automatically generating a proxy and an endpoint for services that you add by using the **Add Service Reference** dialog box. All necessary configuration information is added to the *app.config* file. Most of the time, all that you have to do is instantiate the service in order to use it.

The **Add Service Reference** dialog box enables you to enter the address for a service or to search for a service that is defined in your solution. The dialog box returns a list of services and the operations provided by those services. It also enables you to define the namespace by which you will reference the services in code.

The **Configure Service References** dialog box enables you to customize the configuration for a service. You can change the address for a service, specify access level, asynchronous behavior, and message contract types, and configure type reuse.

## Select a service endpoint

Some Windows Communication Foundation (WCF) services expose multiple endpoints through which a client might communicate with the service. For example, a service might expose one endpoint that uses an HTTP binding and user name and password security and a second endpoint that uses FTP and Windows Authentication. The first endpoint might be used by applications that access the service from outside a firewall, whereas the second might be used on an intranet.

In such a case, you can specify the `endpointConfigurationName` as a parameter to the constructor for a service reference.

[!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]

### To select a service endpoint

1. Add a reference to a WCF service by right-clicking the project node in **Solution Explorer** and choosing **Add service reference**.

2. In the Code Editor, add a constructor for the service reference:

    ### [C#](#tab/csharp)

    ```csharp
    ServiceReference.Service1Client proxy = new ServiceReference.Service1Client(
    ```

    ### [VB](#tab/vb)

    ```vb
    Dim proxy As New ServiceReference.Service1Client(
    ```

    ---

    > [!NOTE]
    > Replace *ServiceReference* with the namespace for the service reference and replace *Service1Client* with the name of the service.

3. An IntelliSense list displays that includes the overloads for the constructor. Select the `endpointConfigurationName As String` overload.

4. Following the overload, type `=` *ConfigurationName*, where *ConfigurationName* is the name of the endpoint that you want to use.

    > [!NOTE]
    > If you do not know the names of the available endpoints, you can find them in the *app.config* file.

### To find the available endpoints for a WCF service

1. In **Solution Explorer**, right-click the **app.config** file for the project that contains the service reference, and then select **Open**. The file appears in the Code Editor.

2. Search for the `<Client>` tag in the file.

3. Search underneath the `<Client>` tag for a tag that starts with `<Endpoint>`.

     If the service reference provides multiple endpoints, there will be two or more `<Endpoint` tags.

4. Inside the `<EndPoint>` tag, you will find a `name="`*SomeService*`"` parameter (where *SomeService* represents an endpoint name). This is the name for the endpoint that can be passed to the `endpointConfigurationName As String` overload of a constructor for a service reference.

## Call a service method asynchronously

Most methods in Windows Communication Foundation (WCF) services might be called either synchronously or asynchronously. Calling a method asynchronously enables your application to continue to work while the method is being called when it operates over a slow connection.

By default, when a service reference is added to a project, it is configured to call methods synchronously. You can change the behavior to call methods asynchronously by changing a setting in the **Configure Service Reference** dialog box.

> [!NOTE]
> This option is set on a per-service basis. If one method for a service is called asynchronously, all methods must be called asynchronously.

[!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]

### To call a service method asynchronously

1. In **Solution Explorer**, select the service reference.

2. On the **Project** menu, click **Configure Service Reference**.

3. In the **Configure Service Reference** dialog box, select the **Generate asynchronous operations** checkbox.

## Bind data returned by a service

You can bind data returned by a Windows Communication Foundation (WCF) service to a control just as you can bind any other data source to a control. When you add a reference to a WCF service, if the service contains composite types that return data, they are automatically added to the **Data Sources** window.

### To bind a control to single data field returned by a WCF service

1. On the **Data** menu, click **Show Data Sources**.

   The **Data Sources** window appears.

2. In the **Data Sources** window, expand the node for your service reference. Any composite types returned by the service display.

3. Expand a node for a type. The data fields for that type appear.

4. Select a field and click the dropdown list arrow to display a list of controls that are available for the data type.

5. Click the type of control to which you want to bind.

6. Drag the field onto a form. The control is added to the form, together with a <xref:System.Windows.Forms.BindingSource> component and a <xref:System.Windows.Forms.BindingNavigator> component.

7. Repeat steps 4 though 6 for any other fields that you want to bind.

### To bind a control to composite type returned by a WCF service

1. On the **Data** menu, select **Show Data Sources**. The **Data Sources** window appears.

2. In the **Data Sources** window, expand the node for your service reference. Any composite types returned by the service display.

3. Select a node for a type and click the dropdown list arrow to display a list of available options.

4. Click either **DataGridView** to display the data in a grid or **Details** to display the data in individual controls.

5. Drag the node onto the form. The controls are added to the form, together with a <xref:System.Windows.Forms.BindingSource> component and a <xref:System.Windows.Forms.BindingNavigator> component.

## Configure a service to reuse existing types

When a service reference is added to a project, any types defined in the service are generated in the local project. In many cases, this creates duplicate types when a service uses common .NET types or when types are defined in a shared library.

To avoid this problem, types in referenced assemblies are shared by default. If you want to disable type sharing for one or more assemblies, you can do so in the **Configure Service References** dialog box.

### To disable type sharing in a single assembly

1. In **Solution Explorer**, select the service reference.

2. On the **Project** menu, click **Configure Service Reference**.

3. In the **Configure Service References** dialog box, select **Reuse types in specified referenced assemblies**.

4. Select the checkbox for each assembly in which you want to enable type sharing. To disable type sharing for an assembly, leave the checkbox cleared.

### To disable type sharing in all assemblies

1. In **Solution Explorer**, select the service reference.

2. On the **Project** menu, click **Configure Service Reference**.

3. In the **Configure Service References** dialog box, clear the **Reuse types in referenced assemblies** checkbox.

## Related topics

| Title | Description |
| - | - |
| [Walkthrough: Creating a simple WCF Service in Windows Forms](../data-tools/walkthrough-creating-a-simple-wcf-service-in-windows-forms.md) | Provides a step-by-step demonstration of creating and using WCF services in Visual Studio. |
| [Walkthrough: Creating a WCF data service with WPF and Entity Framework](../data-tools/walkthrough-creating-a-wcf-data-service-with-wpf-and-entity-framework.md) | Provides a step-by-step demonstration of how to create and use WCF Data Services in Visual Studio. |
| [Using the WCF development tools](/dotnet/framework/wcf/using-the-wcf-development-tools) | Discusses how to create and test WCF services in Visual Studio. |
| | [How to: Add, update, or remove a WCF Data Service reference](../data-tools/how-to-add-update-or-remove-a-wcf-data-service-reference.md) |
| [Troubleshooting service references](../data-tools/troubleshooting-service-references.md) | Presents some common errors that can occur with service references and how to prevent them. |
| [Debugging WCF services](../debugger/debugging-wcf-services.md) | Describes common debugging problems and techniques you might encounter when debugging WCF services. |
| [Walkthrough: Creating an n-tier data application](../data-tools/walkthrough-creating-an-n-tier-data-application.md) | Provides step-by-step instructions for creating a typed dataset and separating the TableAdapter and dataset code into multiple projects. |
| [Configure Service Reference dialog box](../data-tools/configure-service-reference-dialog-box.md) | Describes the user interface elements of the **Configure Service Reference** dialog box. |

## Reference

- <xref:System.ServiceModel>
- <xref:System.Data.Services>

## See also

- [Visual Studio data tools for .NET](../data-tools/visual-studio-data-tools-for-dotnet.md)
