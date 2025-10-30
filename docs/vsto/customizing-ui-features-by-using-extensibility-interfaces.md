---
title: "Customize UI features By using extensibility interfaces"
description: Learn that the Office development tools in Visual Studio provide extensibility interfaces that help you customize UI features.
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "ICustomTaskPaneConsumer interface"
  - "IRibbonExtensibility interface"
  - "UI customizing [Office development in Visual Studio]"
  - "user interfaces [Office development in Visual Studio], customizing"
  - "application-level add-ins [Office development in Visual Studio], extensibility interfaces"
  - "customizing UI features [Office development in Visual Studio]"
  - "FormRegionStartup interface"
  - "add-ins [Office development in Visual Studio], extensibility interfaces"
  - "extensibility interfaces [Office development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Customize UI features by using extensibility interfaces

  The Office development tools in Visual Studio provide classes and designers that handle many implementation details when you use them to create custom task panes, ribbon customizations, and Outlook form regions in a VSTO Add-in. However, you can also implement the *extensibility interface* for each feature yourself if you have special requirements.

 [!INCLUDE[appliesto_allapp](../vsto/includes/appliesto-allapp-md.md)]

 Microsoft Office defines a set of extensibility interfaces that COM VSTO Add-ins can implement to customize certain features, such as the ribbon. These interfaces provide full control over the features they provide access to. However, implementing these interfaces requires some knowledge of COM interoperability in managed code. In some cases, the programming model of these interfaces is also not intuitive for developers who are accustomed to the .NET Framework.

 When you create a VSTO Add-in by using the Office project templates in Visual Studio, you do not have to implement the extensibility interfaces to customize features like the ribbon. The  Visual Studio Tools for Office runtime  implements these interfaces for you. Instead, you can use more intuitive classes and designers provided by Visual Studio. However, you can still implement the extensibility interfaces directly in your VSTO Add-in if you want to.

 For more information about the classes and designers that Visual Studio provides for these features, see [Custom task panes](../vsto/custom-task-panes.md), [Ribbon designer](../vsto/ribbon-designer.md), and [Create Outlook form regions](../vsto/creating-outlook-form-regions.md).

## Extensibility interfaces you can implement in a VSTO Add-in
 The following table lists the extensibility interfaces you can implement and the applications that support them.

|Interface|Description|Applications|
|---------------|-----------------|------------------|
|<xref:Microsoft.Office.Core.IRibbonExtensibility>|Implement this interface to customize the ribbon UI. **Note:**  You can add a **Ribbon (XML)** item to a project to generate a default <xref:Microsoft.Office.Core.IRibbonExtensibility> implementation in your VSTO Add-in. For more information, see [Ribbon XML](../vsto/ribbon-xml.md).|Excel<br /><br />  InfoPath 2013 <br /><br /> InfoPath 2010<br /><br /> Outlook<br /><br /> PowerPoint<br /><br /> Project<br /><br /> Visio<br /><br /> Word|
|<xref:Microsoft.Office.Core.ICustomTaskPaneConsumer>|Implement this interface to create a custom task pane.|Excel<br /><br /> Outlook<br /><br /> PowerPoint<br /><br /> Word|
|<xref:Microsoft.Office.Interop.Outlook.FormRegionStartup>|Implement this interface to create an Outlook form region.|Outlook|

 There are several other extensibility interfaces that are defined by Microsoft Office, such as <xref:Microsoft.Office.Core.IBlogExtensibility>, <xref:Microsoft.Office.Core.EncryptionProvider>, and <xref:Microsoft.Office.Core.SignatureProvider>. Visual Studio does not support implementing these interfaces in a VSTO Add-in created by using the Office project templates.

## Use extensibility interfaces
 To customize a UI feature by using an extensibility interface, implement the appropriate interface in your VSTO Add-in project. Then, override the <xref:Microsoft.Office.Tools.AddInBase.RequestService%2A> method to return an instance of the class that implements the interface.

 For a sample application that demonstrates how to implement the <xref:Microsoft.Office.Core.IRibbonExtensibility>, <xref:Microsoft.Office.Core.ICustomTaskPaneConsumer>, and <xref:Microsoft.Office.Interop.Outlook.FormRegionStartup> interfaces in a VSTO Add-in for Outlook, see the UI Manager Sample in [Office development samples](../vsto/office-development-samples.md).

### Example of implementing an extensibility interface
 The following code example demonstrates a simple implementation of the <xref:Microsoft.Office.Core.ICustomTaskPaneConsumer> interface to create a custom task pane. This example defines two classes:

- The `TaskPaneHelper` class implements <xref:Microsoft.Office.Core.ICustomTaskPaneConsumer> to create and display a custom task pane.

- The `TaskPaneUI` class provides the UI of the task pane. The attributes for the `TaskPaneUI` class make the class visible to COM, which enables Microsoft Office applications to discover the class. In this example, the UI is an empty <xref:System.Windows.Forms.UserControl>, but you can add controls by modifying the code.

  > [!NOTE]
  > To expose the `TaskPaneUI` class to COM, you must also set the **Register for COM Interop** property for the project.

  ### [C#](#tab/csharp)
  :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_SimpleExtensibilityInterface/ThisAddIn.cs" id="Snippet1":::

  ### [VB](#tab/vb)
  :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_SimpleExtensibilityInterface/ThisAddIn.vb" id="Snippet1":::
  ---

  For more information about implementing <xref:Microsoft.Office.Core.ICustomTaskPaneConsumer>, see [Create custom task panes in the 2007 Office system](/previous-versions/office/developer/office-2007/aa338197(v=office.12)) in the Microsoft Office documentation.

### Example of overriding the RequestService method
 The following code example demonstrates how to override the <xref:Microsoft.Office.Tools.AddInBase.RequestService%2A> method to return an instance of the `TaskPaneHelper` class from the previous code example. It checks the value of the *serviceGuid* parameter to determine which interface is being requested, and then returns an object that implements that interface.

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_SimpleExtensibilityInterface/ThisAddIn.cs" id="Snippet2":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_SimpleExtensibilityInterface/ThisAddIn.vb" id="Snippet2":::
 ---

## Related content
- [Office development samples and walkthroughs](../vsto/office-development-samples-and-walkthroughs.md)
- [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md)
- [Develop Office solutions](../vsto/developing-office-solutions.md)
- [Call code in VSTO Add-ins from other Office solutions](../vsto/calling-code-in-vsto-add-ins-from-other-office-solutions.md)
- [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md)
- [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md)
