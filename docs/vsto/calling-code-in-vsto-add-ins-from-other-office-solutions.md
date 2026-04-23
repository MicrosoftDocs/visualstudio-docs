---
title: "Call code in VSTO Add-ins from other Office solutions"
description: Learn how you can expose an object in your VSTO Add-in to other solutions, including other Microsoft Office solutions.
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "VBA [Office development in Visual Studio], calling code in application-level add-ins"
  - "application-level add-ins [Office development in Visual Studio], calling code from other solutions"
  - "calling add-in code"
  - "add-ins [Office development in Visual Studio], calling code from other solutions"
  - "interoperability [Office development in Visual Studio]"
  - "calling code from VBA"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Call code in VSTO Add-ins from other Office solutions

  You can expose an object in your VSTO Add-in to other solutions, including other Microsoft Office solutions. This is useful if your VSTO Add-in provides a service that you want to enable other solutions to use. For example, if you have a VSTO Add-in for Microsoft Office Excel that performs calculations on financial data from a Web service, other solutions can perform these calculations by calling into the Excel VSTO Add-in at run time.

 [!INCLUDE[appliesto_allapp](../vsto/includes/appliesto-allapp-md.md)]

 There are two main steps in this process:

- In your VSTO Add-in, expose an object to other solutions.

- In another solution, access the object exposed by your VSTO Add-in, and call members of the object.

## Types of solutions that can call code in an add-in
 You can expose an object in a VSTO Add-in to the following types of solutions:

- Visual Basic for Applications (VBA) code in a document that is loaded in the same application process as your VSTO Add-in.

- Document-level customizations that are loaded in the same application process as your VSTO Add-in.

- Other VSTO Add-ins created by using the Office project templates in Visual Studio.

- COM VSTO Add-ins (that is, VSTO Add-ins that implement the <xref:Extensibility.IDTExtensibility2> interface directly).

- Any solution that is running in a different process than your VSTO Add-in (these types of solutions are also named *out-of-process clients*). These include applications that automate an Office application, such as a Windows Forms or console application, and VSTO Add-ins that are loaded in a different process.

## Expose objects to other solutions
 To expose an object in your VSTO Add-in to other solutions, perform the following steps in your VSTO Add-in:

1. Define a class that you want to expose to other solutions.

2. Override the <xref:Microsoft.Office.Tools.AddInBase.RequestComAddInAutomationService%2A> method in the `ThisAddIn` class. Return an instance of the class that you want to expose to other solutions.

### Define the class you want to expose to other solutions
 At a minimum, the class you want to expose must be public, it must have the <xref:System.Runtime.InteropServices.ComVisibleAttribute> attribute set to **true**, and it must expose the [IDispatch](/previous-versions/windows/desktop/api/oaidl/nn-oaidl-idispatch) interface.

 The recommended way to expose the [IDispatch](/previous-versions/windows/desktop/api/oaidl/nn-oaidl-idispatch) interface is to perform the following steps:

1. Define an interface that declares the members that you want to expose to other solutions. You can define this interface in your VSTO Add-in project. However, you might want to define this interface in a separate class library project if you want to expose the class to non-VBA solutions, so that the solutions that call your VSTO Add-in can reference the interface without referencing your VSTO Add-in project.

2. Apply the <xref:System.Runtime.InteropServices.ComVisibleAttribute> attribute to this interface, and set this attribute to **true**.

3. Modify your class to implement this interface.

4. Apply the <xref:System.Runtime.InteropServices.ClassInterfaceAttribute> attribute to your class, and set this attribute to the **None** value of the <xref:System.Runtime.InteropServices.ClassInterfaceType> enumeration.

5. If you want to expose this class to out-of-process clients, you might also need to do the following:

   - Derive the class from <xref:System.Runtime.InteropServices.StandardOleMarshalObject>. For more information, see [Expose classes to out-of-process clients](#outofproc).

   - Set the **Register for COM interop** property in the project where you define the interface. This property is necessary only if you want to enable clients to use early binding to call into the VSTO Add-in.

   The following code example demonstrates an `AddInUtilities` class with an `ImportData` method that can be called by other solutions. To see this code in the context of a larger walkthrough, see [Walkthrough: Call code in a VSTO Add-in from VBA](../vsto/walkthrough-calling-code-in-a-vsto-add-in-from-vba.md).

   ### [C#](#tab/csharp)
   :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_AddInInteropWalkthrough/AddInUtilities.cs" id="Snippet3":::

   ### [VB](#tab/vb)
   :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_AddInInteropWalkthrough/AddInUtilities.vb" id="Snippet3":::
   ---

### Expose classes to VBA
 When you perform the steps provided above, VBA code can call only the methods that you declare in the interface. VBA code cannot call any other methods in your class, including methods that your class obtains from base classes such as <xref:System.Object>.

 You can alternatively expose the [IDispatch](/previous-versions/windows/desktop/api/oaidl/nn-oaidl-idispatch) interface by setting the <xref:System.Runtime.InteropServices.ClassInterfaceAttribute> attribute to the AutoDispatch or AutoDual value of the <xref:System.Runtime.InteropServices.ClassInterfaceType> enumeration. If you expose the interface, you do not have to declare the methods in a separate interface. However, VBA code can call any public and non-static methods in your class, including methods obtained from base classes such as <xref:System.Object>. In addition, out-of-process clients that use early binding cannot call your class.

### <a name="outofproc"></a> Expose classes to out-of-process clients
 If you want to expose a class in your VSTO Add-in to out-of-process clients, you should derive the class from <xref:System.Runtime.InteropServices.StandardOleMarshalObject> to ensure that out-of-process clients can call your exposed VSTO Add-in object. Otherwise, attempts to get an instance of your exposed object in an out-of-process client might fail unexpectedly.

 This failure is because all calls into the object model of an Office application must be made on the main UI thread, but calls from an out-of-process client to your object will arrive on an arbitrary RPC (remote procedure call) thread. The COM marshaling mechanism in the .NET Framework will not switch threads, and it will instead attempt to marshal the call to your object on the incoming RPC thread instead of the main UI thread. If your object is an instance of a class that derives from <xref:System.Runtime.InteropServices.StandardOleMarshalObject>, incoming calls to your object are automatically marshaled to the thread where the exposed object was created, which will be the main UI thread of the host application.

 For more information about using threads in Office solutions, see [Threading support in Office](../vsto/threading-support-in-office.md).

### Override the RequestComAddInAutomationService method
 The following code example demonstrates how to override <xref:Microsoft.Office.Tools.AddInBase.RequestComAddInAutomationService%2A> in the `ThisAddIn` class in your VSTO Add-in. The example assumes that you have defined a class named `AddInUtilities` that you want to expose to other solutions. To see this code in the context of a larger walkthrough, see [Walkthrough: Call code in a VSTO Add-in from VBA](../vsto/walkthrough-calling-code-in-a-vsto-add-in-from-vba.md).

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_AddInInteropWalkthrough/ThisAddIn.cs" id="Snippet1":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_AddInInteropWalkthrough/ThisAddIn.vb" id="Snippet1":::
 ---

 When your VSTO Add-in is loaded, the  Visual Studio Tools for Office runtime  calls the <xref:Microsoft.Office.Tools.AddInBase.RequestComAddInAutomationService%2A> method. The runtime assigns the returned object to the COMAddIn.Object property of a <xref:Microsoft.Office.Core.COMAddIn> object that represents your VSTO Add-in. This <xref:Microsoft.Office.Core.COMAddIn> object is available to other Office solutions, and to solutions that automate Office.

## Access objects from other solutions
 To call the exposed object in your VSTO Add-in, perform the following steps in the client solution:

1. Get the <xref:Microsoft.Office.Core.COMAddIn> object that represents the exposed VSTO Add-in. Clients can access all of the available VSTO Add-ins by using the `Application.COMAddIns` property in the object model of the host Office application.

2. Access the COMAddIn.Object property of the <xref:Microsoft.Office.Core.COMAddIn> object. This property returns the exposed object from the VSTO Add-in.

3. Call the members of the exposed object.

   The way that you use the return value of the COMAddIn.Object property is different for VBA clients and non-VBA clients. For out-of-process clients, additional code is necessary to avoid a possible race condition.

### Access objects from VBA solutions
 The following code example demonstrates how to use VBA to call a method that is exposed by a VSTO Add-in. This VBA macro calls a method named `ImportData` that is defined in a VSTO Add-in that is named **ExcelImportData**. To see this code in the context of a larger walkthrough, see [Walkthrough: Call code in a VSTO Add-in from VBA](../vsto/walkthrough-calling-code-in-a-vsto-add-in-from-vba.md).

```vb
Sub CallVSTOMethod()
    Dim addIn As COMAddIn
    Dim automationObject As Object
    Set addIn = Application.COMAddIns("ExcelImportData")
    Set automationObject = addIn.Object
    automationObject.ImportData
End Sub
```

### Access objects from non-VBA solutions
 In a non-VBA solution, you must cast the COMAddIn.Object property value to the interface it implements, and then you can call the exposed methods on the interface object. The following code example demonstrates how to call the `ImportData` method from a different VSTO Add-in that was created by using the Office developer tools in Visual Studio.

### [C#](#tab/csharp)
```csharp
object addInName = "ExcelImportData";
Office.COMAddIn addIn = Globals.ThisAddIn.Application.COMAddIns.Item(ref addInName);
ExcelImportData.IAddInUtilities utilities = (ExcelImportData.IAddInUtilities)addIn.Object;
utilities.ImportData();
```

### [VB](#tab/vb)
```vb
Dim addIn As Office.COMAddIn = Globals.ThisAddIn.Application.COMAddIns.Item("ExcelImportData")
Dim utilities As ExcelImportData.IAddInUtilities = TryCast( _
    addIn.Object, ExcelImportData.IAddInUtilities)
utilities.ImportData()
```
---

 In this example, if you try to cast the value of the COMAddIn.Object property to the `AddInUtilities` class rather than the `IAddInUtilities` interface, the code will throw an <xref:System.InvalidCastException>.

## Related content
- [Program VSTO Add-Ins](../vsto/programming-vsto-add-ins.md)
- [Walkthrough: Call code in a VSTO Add-in from VBA](../vsto/walkthrough-calling-code-in-a-vsto-add-in-from-vba.md)
- [Develop Office solutions](../vsto/developing-office-solutions.md)
- [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md)
- [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md)
- [Customize UI features by using extensibility interfaces](../vsto/customizing-ui-features-by-using-extensibility-interfaces.md)
