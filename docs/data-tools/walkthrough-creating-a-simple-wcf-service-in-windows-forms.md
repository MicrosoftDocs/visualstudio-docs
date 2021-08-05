---
title: Create a simple WCF Service in Windows Forms
description: In this walkthrough, create a Windows Communication Foundation (WCF) service in Visual Studio, test it, and then access it from a Windows Forms application.
ms.date: 11/04/2016
ms.custom: SEO-VS-2020
ms.topic: conceptual
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- WCF, walkthrough [Visual Studio]
- WCF, Visual Studio tools for
- WCF services
- WCF services, walkthrough
ms.assetid: 5fef1a64-27a4-4f10-aa57-29023e28a2d6
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: vs-data-tools
ms.workload:
- data-storage
---
# Walkthrough: Create a simple WCF service in Windows Forms

This walkthrough demonstrates how to create a simple Windows Communication Foundation (WCF) service, test it, and then access it from a Windows Forms application.

[!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]

## Create a service

1. Open Visual Studio.

::: moniker range="vs-2017"

2. On the **File** menu, choose **New** > **Project**.

3. In the **New Project** dialog box, expand the **Visual Basic** or **Visual C#** node and choose **WCF**, followed by **WCF Service Library**.

4. Click **OK** to create the project.

   ![The WCF Service Library project](../data-tools/media/wcf1.png)

::: moniker-end

::: moniker range=">=vs-2019"

2. On the start window, choose **Create a new project**.

3. Type **wcf service library** in the search box on the **Create a new project** page. Select either the C# or Visual Basic template for **WCF Service Library**, and then click **Next**.

   ![Create new WCF Service Library project in Visual Studio 2019](media/vs-2019/create-new-wcf-service-library.png)

   > [!TIP]
   > If you don't see any templates, you may need to install the **Windows Communication Foundation** component of Visual Studio. Choose **Install more tools and features** to open Visual Studio Installer. Choose the **Individual components** tab, scroll down to **Development activities**, and then select **Windows Communication Foundation**. Click **Modify**.

4. On the **Configure your new project** page, click **Create**.

::: moniker-end

   > [!NOTE]
   > This creates a working service that can be tested and accessed. The following two steps demonstrate how you might modify the default method to use a different data type. In a real application, you would also add your own functions to the service.

5. In **Solution Explorer**, double-click **IService1.vb** or **IService1.cs**.

   ![The IService1 file](../data-tools/media/wcf2.png)

   Find the following line:

   :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/wcfwalkthrough/cs/iservice1_2.cs" id="Snippet4":::
   :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/wcfwalkthrough/vb/iservice1_2.vb" id="Snippet4":::

   Change the type for the `value` parameter to string:

   :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/wcfwalkthrough/cs/iservice1.cs" id="Snippet1":::
   :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/wcfwalkthrough/vb/iservice1.vb" id="Snippet1":::

   In the above code, note the `<OperationContract()>` or `[OperationContract]` attributes. These attributes are required for any method exposed by the service.

6. In **Solution Explorer**, double-click **Service1.vb** or **Service1.cs**.

   ![The Service1 file](../data-tools/media/wcf3.png)

   Find the following line:

   :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/wcfwalkthrough/vb/service1_2.vb" id="Snippet5":::
   :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/wcfwalkthrough/cs/service1_2.cs" id="Snippet5":::

   Change the type for the `value` parameter to string:

   :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/wcfwalkthrough/cs/service1.cs" id="Snippet2":::
   :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/wcfwalkthrough/vb/service1.vb" id="Snippet2":::

## Test the service

1. Press **F5** to run the service. A **WCF Test Client** form appears and loads the service.

2. In the **WCF Test Client** form, double-click the **GetData()** method under **IService1**. The **GetData** tab appears.

     ![The GetData&#40;&#41; method](../data-tools/media/wcf4.png)

3. In the **Request** box, select the **Value** field and type `Hello`.

     ![The Value field](../data-tools/media/wcf5.png)

4. Click the **Invoke** button. If a **Security Warning** dialog box appears, click **OK**. The result displays in the **Response** box.

     ![The result in the Response box](../data-tools/media/wcf6.png)

5. On the **File** menu, click **Exit** to close the test form.

## Access the Service

### Reference the WCF service

1. On the **File** menu, point to **Add** and then click **New Project**.

2. In the **New Project** dialog box, expand the **Visual Basic** or **Visual C#** node, select **Windows**, and then select **Windows Forms Application**. Click **OK** to open the project.

     ![Windows Forms Application project](../data-tools/media/wcf7.png)

3. Right-click **WindowsApplication1** and click **Add Service Reference**. The **Add Service Reference** dialog box appears.

4. In the **Add Service Reference** dialog box, click **Discover**.

     ![The Add Service Reference dialog box](../data-tools/media/wcf8.png)

     **Service1** displays in the **Services** pane.

5. Click **OK** to add the service reference.

### Build a client application

1. In **Solution Explorer**, double-click **Form1.vb** or **Form1.cs** to open the Windows Forms Designer if it is not already open.

2. From the **Toolbox**, drag a `TextBox` control, a `Label` control, and a `Button` control onto the form.

     ![Adding controls to the form](../data-tools/media/wcf9.png)

3. Double-click the `Button`, and add the following code in the `Click` event handler:

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/wcfwalkthrough/cs/form1.cs" id="Snippet3":::
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/wcfwalkthrough/vb/form1.vb" id="Snippet3":::

4. In **Solution Explorer**, right-click **WindowsApplication1** and click **Set as StartUp Project**.

5. Press **F5** to run the project. Enter some text and click the button. The label displays "You entered:" and shows the text that you entered.

     ![The form showing the result](../data-tools/media/wcf10.png)

## See also

- [Windows Communication Foundation Services and WCF Data Services in Visual Studio](../data-tools/windows-communication-foundation-services-and-wcf-data-services-in-visual-studio.md)
