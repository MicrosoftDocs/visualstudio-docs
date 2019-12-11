---
title: "Windows Communication Foundation Services and WCF Data Services"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
helpviewer_keywords:
  - "services, WCF Data"
  - "WCF services, binding to"
  - "WCF services, asynchronous service methods"
  - "service references [Visual Studio]"
  - "WCF Data Services"
  - "asynchronous calls"
  - "service references [Visual Studio], type sharing"
  - "endpoints [WCF]"
  - "asynchronous service methods"
  - "service references [Visual Studio] endpoints"
  - "WCF services, type sharing"
  - "Windows Communication Foundation, in Visual Studio"
  - "services, WCF"
  - "WCF service, Visual Studio"
  - "data services, WCF"
  - "services, in Visual Studio"
  - "data binding [Visual Studio], WCF"
  - "service endpoints [Visual Studio]"
  - "service references [Visual Studio], asynchronous calls"
  - "services, Windows Communication Foundation"
  - "type sharing in WCF services"
  - "WCF services, endpoints"
  - "service method, called asynchronously[Visual Studio]"
ms.assetid: d56f12cb-e139-4fec-b3e4-488383356642
caps.latest.revision: 29
author: jillre
ms.author: jillfra
manager: jillfra
---
# Windows Communication Foundation Services and WCF Data Services in Visual Studio
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Visual Studio provides tools for working with Windows Communication Foundation (WCF) and [!INCLUDE[ssAstoria](../includes/ssastoria-md.md)], Microsoft technologies for creating distributed applications. This topic provides an introduction to services from a [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] perspective. For the full documentation, see [WCF Data Services 4.5](https://msdn.microsoft.com/library/73d2bec3-7c92-4110-b905-11bb0462357a).

## What Is WCF?
 [!INCLUDE[vsindigo](../includes/vsindigo-md.md)] is a unified framework for creating secure, reliable, transacted, and interoperable distributed applications. It replaces older interprocess communication technologies such as ASMX Web services, .NET Remoting, Enterprise Services (DCOM), and MSMQ. WCF brings together the functionality of all those technologies under a unified programming model. This simplifies the experience of developing distributed applications.

#### What are WCF Data Services
 [!INCLUDE[ssAstoria](../includes/ssastoria-md.md)] is an implementation of the Open Data (OData) Protocol standard.  WCF Data Services lets you expose tabular data as a set of REST APIs, allowing you to return data using standard HTTP verbs such as GET, POST, PUT or DELETE. On the server side, WCF Data Services are being superseded by [ASP.NET Web API](https://dotnet.microsoft.com/apps/aspnet/apis) for creating new OData services. The WCF Data Services client library continues to be a good choice for consuming OData services in a .NET application from Visual Studio (**Project &#124; Add Service Reference**) . For more information, see [WCF Data Services 4.5](https://go.microsoft.com/fwlink/?LinkID=119952).

### WCF Programming Model
 The WCF Programming model is based on communication between two entities: a WCF service and a WCF client. The programming model is encapsulated in the <xref:System.ServiceModel> namespace in the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)].

#### WCF Service
 A WCF service is based on an interface that defines a contract between the service and the client. It is marked with a <xref:System.ServiceModel.ServiceContractAttribute> attribute, as shown in the following code:

 [!code-csharp[WCFWalkthrough#6](../snippets/csharp/VS_Snippets_VBCSharp/wcfwalkthrough/cs/iservice1.cs#6)]
 [!code-vb[WCFWalkthrough#6](../snippets/visualbasic/VS_Snippets_VBCSharp/wcfwalkthrough/vb/iservice1.vb#6)]

 [!code-csharp[WCFWalkthrough#1](../snippets/csharp/VS_Snippets_VBCSharp/wcfwalkthrough/cs/iservice1.cs#1)]
 [!code-vb[WCFWalkthrough#1](../snippets/visualbasic/VS_Snippets_VBCSharp/wcfwalkthrough/vb/iservice1.vb#1)]

 You define functions or methods that are exposed by a WCF service by marking them with a <xref:System.ServiceModel.OperationContractAttribute> attribute. In addition, you can expose serialized data by marking a composite type with a <xref:System.Runtime.Serialization.DataContractAttribute> attribute. This enables data binding in a client.

 After an interface and its methods are defined, they are encapsulated in a class that implements the interface. A single WCF service class can implement multiple service contracts.

 A WCF service is exposed for consumption through what is known as an *endpoint*. The endpoint provides the only way to communicate with the service; you cannot access the service through a direct reference as you would with other classes.

 An endpoint consists of an address, a binding, and a contract. The address defines where the service is located; this could be a URL, an FTP address, or a network or local path. A binding defines the way that you communicate with the service. WCF bindings provide a versatile model for specifying a protocol such as HTTP or FTP, a security mechanism such as Windows Authentication or user names and passwords, and much more. A contract includes the operations that are exposed by the WCF service class.

 Multiple endpoints can be exposed for a single WCF service. This enables different clients to communicate with the same service in different ways. For example, a banking service might provide one endpoint for employees and another for external customers, each using a different address, binding, and/or contract.

#### WCF Client
 A WCF client consists of a *proxy* that enables an application to communicate with a WCF service, and an endpoint that matches an endpoint defined for the service. The proxy is generated on the client side in the app.config file and includes information about the types and methods that are exposed by the service. For services that expose multiple endpoints, the client can select the one that best fits its needs, for example, to communicate over HTTP and use Windows Authentication.

 After a WCF client has been created, you reference the service in your code just as you would any other object. For example, to call the `GetData` method shown earlier, you would write code that resembles the following:

 [!code-csharp[WCFWalkthrough#3](../snippets/csharp/VS_Snippets_VBCSharp/wcfwalkthrough/cs/form1.cs#3)]
 [!code-vb[WCFWalkthrough#3](../snippets/visualbasic/VS_Snippets_VBCSharp/wcfwalkthrough/vb/form1.vb#3)]

## WCF Tools in Visual Studio
 [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] provides tools to help you create both WCF services and WCF clients. For a walkthrough that demonstrates the tools, see [Walkthrough: Creating a simple WCF Service in Windows Forms](../data-tools/walkthrough-creating-a-simple-wcf-service-in-windows-forms.md).

### Creating and Testing WCF Services
 You can use the WCF [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] templates as a foundation to quickly create your own service. You can then use WCF Service Auto Host and WCF Test Client to debug and test the service. These tools together provide a fast and convenient debug and testing cycle, and eliminate the requirement to commit to a hosting model at an early stage.

#### WCF Templates
 WCF [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] templates provide a basic class structure for service development. Several WCF templates are available in the **Add New Project** dialog box. These include WCF Service Library projects, WCF Service Web Sites, and WCF Service Item templates.

 When you select a template, files are added for a service contract, a service implementation, and a service configuration. All necessary attributes are already added, creating a simple "Hello World" type of service, and you did not have to write any code. You will, of course, want to add code to provide functions and methods for your real world service, but the templates provide the basic foundation.

 To learn more about WCF templates, see [WCF Visual Studio Templates](https://msdn.microsoft.com/library/6a608575-3535-4190-89da-911e24c8374f).

#### WCF Service Host
 When you start the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] debugger (by pressing F5) for a WCF service project, the WCF Service Host tool is automatically started to host the service locally. WCF Service Host enumerates the services in a WCF service project, loads the project’s configuration, and instantiates a host for each service that it finds.

 By using WCF Service Host, you can test a WCF service without writing extra code or committing to a specific host during development.

 To learn more about WCF Service Host, see [WCF Service Host (WcfSvcHost.exe)](https://msdn.microsoft.com/library/8643a63d-a357-4c39-bd6c-cdfdf71e370e).

#### WCF Test Client
 The WCF Test Client tool enables you to input test parameters, submit that input to a WCF service, and view the response that the service sends back. It provides a convenient service testing experience when you combine it with WCF Service Host. The tool can be found in the \Common7\IDE folder, which for Visual Studio 2015 installed in drive C: is here: **C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\\**.

 When you press F5 to debug a WCF service project, WCF Test Client opens and displays a list of service endpoints that are defined in the configuration file. You can test the parameters and start the service, and repeat this process to continuously test and validate your service.

 To learn more about WCF Test Client, see [WCF Test Client (WcfTestClient.exe)](https://msdn.microsoft.com/library/d4302855-677f-4640-aa90-c5d785d72fb7).

### Accessing WCF Services in Visual Studio
 [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] simplifies the task of creating WCF clients, automatically generating a proxy and an endpoint for services that you add by using the **Add Service Reference** dialog box. All necessary configuration information is added to the app.config file. Most of the time, all that you have to do is instantiate the service in order to use it.

 The **Add Service Reference** dialog box enables you to enter the address for a service or to search for a service that is defined in your solution. The dialog box returns a list of services and the operations provided by those services. It also enables you to define the namespace by which you will reference the services in code.

 The **Configure Service References** dialog box enables you to customize the configuration for a service. You can change the address for a service, specify access level, asynchronous behavior, and message contract types, and configure type reuse.

## How to: Select a Service Endpoint
 Some Windows Communication Foundation (WCF) services expose multiple endpoints through which a client may communicate with the service. For example, a service might expose one endpoint that uses an HTTP binding and user name / password security and a second endpoint that uses FTP and Windows Authentication. The first endpoint might be used by applications that access the service from outside a firewall, whereas the second might be used on an intranet.

 In such a case, you can specify the `endpointConfigurationName` as a parameter to the constructor for a service reference.

 [!INCLUDE[note_settings_general](../includes/note-settings-general-md.md)]

#### To select a service endpoint

1. Add a reference to a WCF service by right-clicking the project node in Solution Explorer and choosing **Add service reference**

2. In the Code Editor, add a constructor for the service reference:

    ```vb
    Dim proxy As New ServiceReference.Service1Client(
    ```

    ```csharp
    ServiceReference.Service1Client proxy = new ServiceReference.Service1Client(
    ```

    > [!NOTE]
    > Replace *ServiceReference* with the namespace for the service reference and replace *Service1Client* with the name of the service.

3. An IntelliSense list will be displayed with the overloads for the constructor. Select the `endpointConfigurationName As String` overload.

4. Following the overload, type `=` *ConfigurationName*, where *ConfigurationName* is the name of the endpoint that you want to use.

    > [!NOTE]
    > If you do not know the names of the available endpoints, you can find them in the app.config file.

#### To find the available endpoints for a WCF service

1. In **Solution Explorer**, right-click the app.config file for the project that contains the service reference and then click **Open**. The file will appear in the Code Editor.

2. Search for the `<Client>` tag in the file.

3. Search underneath the `<Client>` tag for a tag that starts with `<Endpoint>`.

     If the service reference provides multiple endpoints, there will be two or more `<Endpoint` tags.

4. Inside the `<EndPoint>` tag you will find a `name="`*SomeService*`"` parameter (where *SomeService* represents an endpoint name). This is the name for the endpoint that can be passed to the `endpointConfigurationName As String` overload of a constructor for a service reference.

## How to: Call a Service Method Asynchronously
 Most methods in Windows Communication Foundation (WCF) services may be called either synchronously or asynchronously. Calling a method asynchronously enables your application to continue to work while the method is being called when it operates over a slow connection.

 By default, when a service reference is added to a project it is configured to call methods synchronously. You can change the behavior to call methods asynchronously by changing a setting in the **Configure Service Reference** dialog box.

> [!NOTE]
> This option is set on a per-service basis. If one method for a service is called asynchronously, all methods must be called asynchronously.

 [!INCLUDE[note_settings_general](../includes/note-settings-general-md.md)]

#### To call a service method asynchronously

1. In **Solution Explorer**, select the service reference.

2. On the **Project** menu, click **Configure Service Reference**.

3. In the **Configure Service Reference** dialog box, select the **Generate asynchronous operations** check box.

## How to: Bind Data Returned by a Service
 You can bind data returned by a Windows Communication Foundation (WCF) service to a control just as you can bind any other data source to a control. When you add a reference to a WCF service, if the service contains composite types that return data, they are automatically added to the **Data Sources** window.

#### To bind a control to single data field returned by a WCF service

1. On the **Data** menu, click **Show Data Sources**. The **Data Sources** window will appear.

2. In the **Data Sources** window, expand the node for your service reference. Any composite types returned by the service will be displayed.

3. Expand a node for a type. The data fields for that type will be displayed.

4. Select a field and click the drop-down arrow to display a list of controls that are available for the data type.

5. Click the type of control that you want to bind to.

6. Drag the field onto a form. The control will be added to the form together with a <xref:System.Windows.Forms.BindingSource> component and a <xref:System.Windows.Forms.BindingNavigator> component.

7. Repeat steps 4 though 6 for any other fields that you want to bind.

#### To bind a control to composite type returned by a WCF service

1. On the **Data** menu, select **Show Data Sources**. The **Data Sources** window will appear.

2. In the **Data Sources** window, expand the node for your service reference. Any composite types returned by the service will be displayed.

3. Select a node for a type and click the drop-down arrow to display a list of available options.

4. Click either **DataGridView** to display the data in a grid or **Details** to display the data in individual controls.

5. Drag the node onto the form. The controls will be added to the form together with a <xref:System.Windows.Forms.BindingSource> component and a <xref:System.Windows.Forms.BindingNavigator> component.

## How to: Configure a Service to Reuse Existing Types
 When a service reference is added to a project, any types defined in the service are generated in the local project. In many cases, this creates duplicate types when a service uses common [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] types or when types are defined in a shared library.

 To avoid this problem, types in referenced assemblies are shared by default. If you want to disable type sharing for one or more assemblies, you can do so in the **Configure Service References** dialog box.

#### To disable type sharing in a single assembly

1. In **Solution Explorer**, select the service reference.

2. On the **Project** menu, click **Configure Service Reference**.

3. In the **Configure Service References** dialog box, select **Reuse types in specified referenced assemblies**.

4. Select the check box for each assembly in which you want to enable type sharing. To disable type sharing for an assembly, leave the check box cleared.

#### To disable type sharing in all assemblies

1. In **Solution Explorer**, select the service reference.

2. On the **Project** menu, click **Configure Service Reference**.

3. In the **Configure Service References** dialog box, clear the **Reuse types in referenced assemblies** check box.

## Related Topics

|Title|Description|
|-----------|-----------------|
|[Walkthrough: Creating a simple WCF Service in Windows Forms](../data-tools/walkthrough-creating-a-simple-wcf-service-in-windows-forms.md)|Provides a step-by-step demonstration of creating and using WCF services in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].|
|[Walkthrough: Creating a WCF Data Service with WPF and Entity Framework](../data-tools/walkthrough-creating-a-wcf-data-service-with-wpf-and-entity-framework.md)|Provides a step-by-step demonstration of how to create and use [!INCLUDE[ssAstoria](../includes/ssastoria-md.md)] in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].|
|[Using the WCF Development Tools](https://msdn.microsoft.com/library/054adb87-c244-4d5a-83d1-0b2b44bd454b)|Discusses how to create and test WCF services in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].|
|[How to: Add, Update, or Remove a Service Reference](https://msdn.microsoft.com/library/cacc14bd-4455-4a44-be78-d2ac16113dd9)|Describes how to add, update, or remove WCF services from a project.|
|[How to: Add, Update, or Remove a WCF Data Service Reference](../data-tools/how-to-add-update-or-remove-a-wcf-data-service-reference.md)|Discusses how to reference and use [!INCLUDE[ssAstoria](../includes/ssastoria-md.md)] in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].|
|[Troubleshooting Service References](../data-tools/troubleshooting-service-references.md)|Presents some common errors that can occur with service references and how to prevent them.|
|[Debugging WCF Services](../debugger/debugging-wcf-services.md)|Describes common debugging problems and techniques you might encounter when debugging WCF services.|
|[Windows Communication Foundation Authentication Service Overview](https://msdn.microsoft.com/library/6e121a28-89e8-4974-88a8-70aaa6a7d52b)|Describes how to use WCF to provide a role service for a Web site.|
|[Walkthrough: Creating an N-Tier Data Application](../data-tools/walkthrough-creating-an-n-tier-data-application.md)|Provides step-by-step instructions for creating a typed dataset and separating the TableAdapter and dataset code into multiple projects.|
|[Configure Service Reference Dialog Box](../data-tools/configure-service-reference-dialog-box.md)|Describes the user interface elements of the **Configure Service Reference** dialog box.|

## Reference
 <xref:System.ServiceModel>

 <xref:System.Data.Services>

## See Also
 [Visual Studio data tools for .NET](../data-tools/visual-studio-data-tools-for-dotnet.md)
