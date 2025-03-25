---
title: Create a WCF Service in .NET Framework Windows Forms
description: Create a Windows Communication Foundation (WCF) service in Visual Studio, test the service, and access it from a Windows Forms application.
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
ms.topic: how-to
ms.date: 03/19/2025
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- WCF, walkthrough [Visual Studio]
- WCF, Visual Studio tools for
- WCF services
- WCF services, walkthrough

# Customer intent: As a developer, I want to understand how to create a WCF Service in .NET Framework so that I can access it from a Windows Forms app.

---

# Walkthrough: Create a WCF service in .NET Framework Windows Forms

This walkthrough demonstrates how to create a Windows Communication Foundation (WCF) service, test it, and then access it from a .NET Framework Windows Forms application.

[!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]

## Prerequisites

[Visual Studio](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) with the **Windows Communication Foundation** component installed. To install it:

1. Open the **Visual Studio Installer** app, or select **Tools** > **Get Tools and Features** from the Visual Studio menu.
1. In **Visual Studio Installer**, choose **Modify** next to the version of Visual Studio you want to modify.
1. Select the **Individual components** tab, and then choose **Windows Communication Foundation** under **Development activities**.
1. Select **Modify**.

For more information, see [Modify Visual Studio workloads, components, and language packs](../install/modify-visual-studio.md).

## Create a WCF service

To create a WCF service in Visual Studio, follow these steps:

1. In Visual Studio, select **File** > **New** > **Project** from the menu.

2. On the **Create a new project** page, enter **wcf service library** in the search box. Select either the C# or Visual Basic template for **WCF Service Library**, and then select **Next**.

   :::image type="content" alt-text="Screenshot that shows how to create a WCF Service Library project in Visual Studio." source="../data-tools/media/vs-2022/create-new-wcf-service-library.png":::

   > [!TIP]
   > If you don't see any templates, you might need to install the **Windows Communication Foundation** component of Visual Studio. For more information, see [Prerequisites](#prerequisites)

3. On the **Configure your new project** page, verify the settings, and then select **Create**.

   This step creates a working WCF service that you can test and access. The following steps demonstrate how to modify the default method to use a different data type. In a real application, you'd also add your own functions to the service.

4. In **Solution Explorer**, double-click **IService1.cs** or **IService1.vb** in your WCF service library project, depending on which type of project you created.

   :::image type="content" alt-text="Screenshot that shows the IService1 file in Solution Explorer." source="../data-tools/media/wcf2.png":::

5. Find the following line:

   ### [C#](#tab/csharp)

   :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/wcfwalkthrough/cs/iservice1_2.cs" id="Snippet4":::

   ### [VB](#tab/vb)

   :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/wcfwalkthrough/vb/iservice1_2.vb" id="Snippet4":::

   ---

6. Change the type for the `value` parameter to string.

      In this code example, note the `OperationContract` attribute. This attribute is required for any method exposed by the service.

   ### [C#](#tab/csharp)

   :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/wcfwalkthrough/cs/iservice1.cs" id="Snippet1":::

   ### [VB](#tab/vb)

   :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/wcfwalkthrough/vb/iservice1.vb" id="Snippet1":::

   ---

7. In **Solution Explorer**, double-click **Service1.cs** or **Service1.vb**.

   :::image type="content" alt-text="Screenshot that shows the Service1 file in Solution Explorer." source="../data-tools/media/wcf3.png":::

8. In the editor, find the following line:

   ### [C#](#tab/csharp)

   :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/wcfwalkthrough/cs/service1_2.cs" id="Snippet5":::

   ### [VB](#tab/vb)

   :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/wcfwalkthrough/vb/service1_2.vb" id="Snippet5":::

   ---

9. Change the type for the `value` parameter to string, as follows:

   ### [C#](#tab/csharp)

   :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/wcfwalkthrough/cs/service1.cs" id="Snippet2":::

   ### [VB](#tab/vb)

   :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/wcfwalkthrough/vb/service1.vb" id="Snippet2":::

   ---

## Test the WCF service

To test the WCF service you created, follow these steps:

1. Press **F5** to run the service.

   The **WCF Test Client** form appears and loads the service.

1. Under **IService1**, double-click the **GetData()** method.

   The **GetData** tab appears in the **WCF Test Client** form.

   :::image type="content" alt-text="Screenshot that shows the GetData method in the WCF Test Client form." source="../data-tools/media/wcf4.png":::

1. In the **Request** box of the **GetData** tab, select the **Value** field and enter **Hello**.

   :::image type="content" alt-text="Screenshot that shows the Value field in the GetData tab." source="../data-tools/media/wcf5.png":::

1. Select the **Invoke** button. If a **Security Warning** dialog box appears, select **OK**.

   The result displays in the **Response** box.

   :::image type="content" alt-text="Screenshot that shows the result displayed in the Response box in the GetData tab." source="../data-tools/media/wcf6.png":::

1. On the **File** menu, select **Exit** to close the test form.

## Access the WCF service

After you create and test the WCF service, you can reference it from a project and use it to build a client application.

### Reference the WCF service

To reference the WCF service from a project, follow these steps:

1. Select **File** > **Add** > **New Project**.

1. In the **Add a New Project** window, choose either a C# or Visual Basic **Windows Forms App (.NET Framework)** project. Select **Next**, and then **Create** to create the project.

1. In **Solution Explorer**, right-click the project node of the new project, and select **Add** > **Service Reference**.

   The **Add Service Reference** dialog box appears.

1. Select **Discover**.

   :::image type="content" alt-text="Screenshot that shows the Add Service Reference dialog box." source="../data-tools/media/vs-2022/add-service-reference-dialog-box.png":::

     **Service1** displays in the **Services** pane.

1. Select **OK** to add the service reference.

### Build a client application

To use a WCF service reference to build a client application, follow these steps.

1. In **Solution Explorer**, double-click **Form1.cs** or **Form1.vb** in the Windows Forms app.

   The form opens in Windows Forms Designer.

1. Open the **Toolbox** by selecting **View** > **Toolbox** from the menu, or press **Ctrl**+**Alt**+**X** from the keyboard.

1. From the **Toolbox**, drag a **TextBox** control, a **Label** control, and a **Button** control onto the form.

     :::image type="content" alt-text="Screenshot that shows how to add controls to the client application form." source="../data-tools/media/vs-2022/windows-communication-foundation-client-app.png" lightbox="../data-tools/media/vs-2022/windows-communication-foundation-client-app.png":::

1. Double-click the **Button** control, and add the following code in the `Click` event handler:

     ### [C#](#tab/csharp)

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/wcfwalkthrough/cs/form1.cs" id="Snippet3":::

     ### [VB](#tab/vb)

     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/wcfwalkthrough/vb/form1.vb" id="Snippet3":::

     ---

1. In **Solution Explorer**, right-click the project node (for example, **WindowsFormsApp1**), and select **Set as StartUp Project**.

1. Press **F5** to run the project. Enter some text and select the button. The label displays **You entered:**, followed by your text.

   :::image type="content" alt-text="Screenshot that shows the result displayed in the running client application form." source="../data-tools/media/vs-2022/windows-forms-app.png":::

## Related content

- [Windows Communication Foundation Services and WCF Data Services in Visual Studio](../data-tools/windows-communication-foundation-services-and-wcf-data-services-in-visual-studio.md)
