---
title: "Combine VBA and document-level customizations"
description: Learn how you can use Visual Basic for Applications (VBA) code in a document that is part of a document-level customization for Microsoft Office Word or Excel.
ms.date: "02/02/2017"
ms.topic: how-to
f1_keywords:
  - "VST.VBAInterop.InvalidAssemblyVersion"
  - "VST.VBAInterop.ProjectLoadFailure"
  - "VST.VBAInterop.MissingGUID"
  - "VST.VBAInterop.EnableComCallers"
  - "VST.VBAInterop.PersistVBACode"
  - "VST.VBAInterop.ReferenceAssemblyFromVBA"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "documents [Office development in Visual Studio], Visual Basic for Applications and"
  - "VBA [Office development in Visual Studio]"
  - "Office documents [Office development in Visual Studio], Visual Basic for Applications and"
  - "VBA [Office development in Visual Studio], about VBA and document-level customizations"
  - "managed code [Office development in Visual Studio], Visual Basic for Applications and"
  - "document-level customizations [Office development in Visual Studio], Visual Basic for Applications and"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Combine VBA and document-level customizations

  You can use Visual Basic for Applications (VBA) code in a document that is part of a document-level customization for Microsoft Office Word or Microsoft Office Excel. You can call VBA code in the document from the customization assembly, or you can configure your project to enable VBA code in the document to call code in the customization assembly.

 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]

## Behavior of VBA code in a document-level customization
 When you open your project in Visual Studio, the document is opened in design mode. VBA code does not run when the document is in design mode, so you can work on the document and code without running the VBA code.

 When you run the solution, event handlers in both VBA and the customization assembly pick up events that are raised in the document, and both sets of code run. You cannot determine beforehand which code will run before the other; you must determine this through testing in each individual case. You can get unexpected results if the two sets of code are not carefully coordinated and tested.

## Call VBA code from the customization assembly
 You can call macros in Word documents, and you can call macros and functions in Excel workbooks. To do this, use one of the following methods:

- For Word, call the <xref:Microsoft.Office.Interop.Word._Application.Run%2A> method of the <xref:Microsoft.Office.Interop.Word.Application> class.

- For Excel, call the <xref:Microsoft.Office.Interop.Excel._Application.Run%2A> method of the <xref:Microsoft.Office.Interop.Excel.Application> class.

  For each method, the first parameter identifies the name of the macro or function you want to call, and the remaining optional parameters specify the parameters to pass to the macro or function. The first parameter can have different formats for Word and Excel:

- For Word, the first parameter is a string that can be any combination of template, module, and macro name. If you specify the document name, your code can only run macros in documents related to the current context — not just any macro in any document.

- For Excel, the first parameter can be a string that specifies the macro name, a <xref:Microsoft.Office.Interop.Excel.Range> that indicates where the function is, or a register ID for a registered DLL (XLL) function. If you pass a string, the string will be evaluated in the context of the active sheet.

  The following code example shows how to call a macro named `MyMacro` from a document-level project for Excel. This example assumes that `MyMacro` is defined in `Sheet1`.

### [C#](#tab/csharp)
```csharp
Globals.Sheet1.Application.Run("MyMacro", missing, missing, missing,
    missing, missing, missing, missing, missing, missing, missing,
    missing, missing, missing, missing, missing, missing, missing,
    missing, missing, missing, missing, missing, missing, missing,
    missing, missing, missing, missing, missing, missing);
```

### [VB](#tab/vb)
```vb
Globals.Sheet1.Application.Run("MyMacro")
```
---

> [!NOTE]
> For information about using the global `missing` variable in place of optional parameters in Visual C#, see [Write code in Office solutions](../vsto/writing-code-in-office-solutions.md).

## Call code in document-level customizations from VBA
 You can configure a document-level project for Word or Excel so that Visual Basic for Applications (VBA) code in the document can call code in the customization assembly. This is useful in the following scenarios:

- You want to extend existing VBA code in a document by using features in a document-level customization that is associated with the same document.

- You want to make services that you develop in a document-level customization available to end users who can access the services by writing VBA code in the document.

  The Office development tools in Visual Studio provide a similar feature for VSTO Add-ins. If you are developing a VSTO Add-in, you can call code in your VSTO Add-in from other Microsoft Office solutions. For more information, see [Call code in VSTO Add-ins from other Office solutions](../vsto/calling-code-in-vsto-add-ins-from-other-office-solutions.md).

> [!NOTE]
> This feature cannot be used in Word template projects. It can be used only in Word document, Excel workbook, or Excel template projects.

## Requirements
 Before you can enable VBA code to call into the customization assembly, your project must meet the following requirements:

- The document must have one of the following file name extensions:

  - For Word: *.docm* or *.doc*

  - For Excel: *.xlsm*, *.xltm*, *.xls*, or *.xlt*

- The document must already contain a VBA project that has VBA code in it.

- VBA code in the document must be allowed to run without prompting the user to enable macros. You can trust VBA code to run by adding the location of the Office project to the list of trusted locations in the Trust Center settings for Word or Excel.

- The Office project must contain at least one public class that contains one or more public members that you are exposing to VBA.

     You can expose methods, properties, and events to VBA. The class that you expose can be a host item class (such as `ThisDocument` for Word, or `ThisWorkbook` and `Sheet1` for Excel) or another class that you define in your project. For more information about host items, see [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md).

## Enable VBA code to call into the customization assembly
 There are two different ways that you can expose members in a customization assembly to VBA code in the document:

- You can expose members of a host item class in a Visual Basic project to VBA. To do this, set the **EnableVbaCallers** property of the host item to **True** in the **Properties** window while the host item (that is, the document, worksheet, or workbook) is open in the designer. Visual Studio automatically performs all of the work required to enable VBA code to call members of the class.

- You can expose members in any public class in a Visual C# project, or members in a non-host item class in a Visual Basic project, to VBA. This option provides you with more freedom to choose which classes you expose to VBA, but it also requires more manual steps.

   To do this, you must perform the following main steps:

  1. Expose the class to COM.

  2. Override the **GetAutomationObject** method of a host item class in your project to return an instance of the class that you are exposing to VBA.

  3. Set the **ReferenceAssemblyFromVbaProject** property of any host item class in the project to **True**. This embeds the customization assembly's type library into the assembly and adds a reference to the type library to the VBA project in the document.

  For detailed instructions, see [How to: Expose code to VBA in a Visual Basic project](../vsto/how-to-expose-code-to-vba-in-a-visual-basic-project.md) and [How to: Expose code to VBA in a Visual C&#35; project](../vsto/how-to-expose-code-to-vba-in-a-visual-csharp-project.md).

  The **EnableVbaCallers** and **ReferenceAssemblyFromVbaProject** properties are available only in the **Properties** window at design time; they cannot be used at run time. To view the properties, open the designer for a host item in Visual Studio. For more information about the specific tasks that Visual Studio performs when you set these properties, see [Tasks performed by the host item properties](#PropertyTasks).

> [!NOTE]
> If the workbook or document does not already contain VBA code or if VBA code in the document is not trusted to run, you will receive an error message when you set the **EnableVbaCallers** or **ReferenceAssemblyFromVbaProject** property to **True**. This is because Visual Studio cannot modify the VBA project in the document in this situation.

## Use members in VBA code to call into the customization assembly
 After you configure your project to enable VBA code to call into the customization assembly, Visual Studio adds the following members to the VBA project in the document:

- For all projects, Visual Studio adds a global method named `GetManagedClass`.

- For Visual Basic projects in which you expose members of a host item class by using the **EnableVbaCallers** property, Visual Studio also adds a property named `CallVSTOAssembly` to the `ThisDocument`, `ThisWorkbook`, `Sheet1`, `Sheet2`, or `Sheet3` module in the VBA project.

  You can use the `CallVSTOAssembly` property or `GetManagedClass` method to access public members of the class that you exposed to VBA code in the project.

> [!NOTE]
> While you develop and deploy your solution, there are several different copies of the document where you can add the VBA code. For more information, see [Guidelines for adding VBA code to the document](#Guidelines).

### Use the CallVSTOAssembly property in a Visual Basic project
 Use the `CallVSTOAssembly` property to access public members that you added to the host item class. For example, the following VBA macro calls a method named `MyVSTOMethod` that is defined in the `Sheet1` class in an Excel workbook project.

```vb
Sub MyMacro()
    Sheet1.CallVSTOAssembly.MyVSTOMethod()
End Sub
```

 This property is a more convenient way to call into the customization assembly than using the `GetManagedClass` method directly. `CallVSTOAssembly` returns an object that represents the host item class that you exposed to VBA. The members and method parameters of the returned object appear in IntelliSense.

 The `CallVSTOAssembly` property has a declaration that is similar to the following code. This code assumes that you have exposed the `Sheet1` host item class in an Excel workbook project named `ExcelWorkbook1` to VBA.

```vb
Property Get CallVSTOAssembly() As ExcelWorkbook1.Sheet1
    Set CallVSTOAssembly = GetManagedClass(Me)
End Property
```

### Use the GetManagedClass method
 To use the global `GetManagedClass` method, pass in the VBA object that corresponds to the host item class that contains your override of the **GetAutomationObject** method. Then, use the returned object to access the class that you exposed to VBA.

 For example, the following VBA macro calls a method named `MyVSTOMethod` that is defined in the `Sheet1` host item class in an Excel workbook project named `ExcelWorkbook1`.

```vb
Sub CallVSTOMethod
    Dim VSTOSheet1 As ExcelWorkbook1.Sheet1
    Set VSTOSheet1 = GetManagedClass(Sheet1)
    VSTOSheet1.MyVSTOMethod
End Sub
```

 The `GetManagedClass` method has the following declaration.

```vb
GetManagedClass(pdispInteropObject Object) As Object
```

 This method returns an object that represents the class that you exposed to VBA. The members and method parameters of the returned object appear in IntelliSense.

## <a name="Guidelines"></a> Guidelines for adding VBA code to the document
 There are several different copies of the document where you can add VBA code that calls into the document-level customization.

 As you develop and test your solution, you can write VBA code in the document that opens while you debug or run your project in Visual Studio (that is, the document in the build output folder). However, any VBA code you add to this document will be overwritten the next time that you build the project, because Visual Studio replaces the document in the build output folder with a copy of the document from the main project folder.

 If you want to save the VBA code that you add to the document while debugging or running the solution, copy the VBA code into the document in the project folder. For more information about the build process, see [Build office solutions](../vsto/building-office-solutions.md).

 When you are ready to deploy your solution, there are three main document locations in which you can add the VBA code.

### In the project folder on the development computer
 This location is convenient if you have complete control over both the VBA code in the document and the customization code. Because the document is on the development computer, you can easily modify the VBA code if you change the customization code. VBA code that you add to this copy of the document remains in the document when you build, debug, and publish your solution.

 You cannot add the VBA code to the document while it is open in the designer. You must first close the document in the designer, and then open the document directly in Word or Excel.

> [!CAUTION]
> If you add VBA code that runs when the document is opened, in rare cases this code might corrupt the document or prevent it from opening in the designer.

### In the publish or installation folder
 In some cases, it might be suitable to add the VBA code to the document in the publish or installation folder. For example, you might choose this option if the VBA code is written and tested by a different developer on a computer that does not have Visual Studio installed.

 If users install the solution directly from the publish folder, you must add the VBA code to the document every time you publish the solution. Visual Studio overwrites the document in the publish location when you publish the solution.

 If users install the solution from an installation folder that is different from the publish folder, you can avoid adding the VBA code in the document every time you publish the solution. When a publish update is ready to be moved from the publish folder to the installation folder, copy all of the files to the installation folder except for the document.

### On the end-user computer
 If the end users are VBA developers who are calling into services that you provide in the document-level customization, you can tell them how to call your code by using the `CallVSTOAssembly` property or the `GetManagedClass` method in their copies of the document. When you publish updates to the solution, VBA code in the document on the end-user computer will not be overwritten, because the document is not modified by publish updates.

## <a name="PropertyTasks"></a> Tasks performed by the host item properties
 When you use the **EnableVbaCallers** and **ReferenceAssemblyFromVbaProject** properties, Visual Studio performs different sets of tasks.

### EnableVbaCallers
 When you set the **EnableVbaCallers** property of a host item to **True** in a Visual Basic project, Visual Studio performs the following tasks:

1. It adds the <xref:Microsoft.VisualBasic.ComClassAttribute> and <xref:System.Runtime.InteropServices.ComVisibleAttribute> attributes to the host item class.

2. It overrides the **GetAutomationObject** method of the host item class.

3. It sets the **ReferenceAssemblyFromVbaProject** property of the host item to **True**.

   When you set the **EnableVbaCallers** property back to **False**, Visual Studio performs the following tasks:

4. It removes the <xref:Microsoft.VisualBasic.ComClassAttribute> and <xref:System.Runtime.InteropServices.ComVisibleAttribute> attributes from the `ThisDocument` class.

5. It removes the **GetAutomationObject** method from the host item class.

   > [!NOTE]
   > Visual Studio does not automatically set the **ReferenceAssemblyFromVbaProject** property back to **False**. You can set this property to **False** manually by using the **Properties** window.

### ReferenceAssemblyFromVbaProject
 When the **ReferenceAssemblyFromVbaProject** property of any host item in a Visual Basic or Visual C# project is set to **True**, Visual Studio performs the following tasks:

1. It generates a type library for the customization assembly and embeds the type library in the assembly.

2. It adds a reference to the following type libraries in the VBA project in the document:

   - The type library for your customization assembly.

   - The Microsoft Visual Studio Tools for Office Execution Engine 9.0 Type Library. This type library is included in the  Visual Studio Tools for Office runtime .

   When the **ReferenceAssemblyFromVbaProject** property is set back to **False**, Visual Studio performs the following tasks:

3. It removes the type library references from the VBA project in the document.

4. It removes the embedded type library from the assembly.

## Troubleshoot
 The following table lists some common errors and suggestions for fixing the errors.

|Error|Suggestion|
|-----------|----------------|
|After you set the **EnableVbaCallers** or **ReferenceAssemblyFromVbaProject** property, an error message states that the document does not contain a VBA project, or you do not have permission to access the VBA project in the document.|Ensure that the document in the project contains at least one VBA macro, the VBA project has sufficient trust to run, and the VBA project is not protected by a password.|
|After you set the **EnableVbaCallers** or **ReferenceAssemblyFromVbaProject** property, an error message states that the <xref:System.Runtime.InteropServices.GuidAttribute> declaration is missing or corrupted.|Ensure that the <xref:System.Runtime.InteropServices.GuidAttribute> declaration is located in the *AssemblyInfo.cs* or *AssemblyInfo.vb* file in your project, and that this attribute is set to a valid GUID.|
|After you set the **EnableVbaCallers** or **ReferenceAssemblyFromVbaProject** property, an error message states that the version number specified by the <xref:System.Reflection.AssemblyVersionAttribute> is not valid.|Ensure that the <xref:System.Reflection.AssemblyVersionAttribute> declaration in the *AssemblyInfo.cs* or *AssemblyInfo.vb* file in your project is set to a valid assembly version number. For information about valid assembly version numbers, see the <xref:System.Reflection.AssemblyVersionAttribute> class.|
|After you rename the customization assembly, VBA code that calls into the customization assembly stops working.|If you change the name of the customization assembly after you expose it to VBA code, the link between the VBA project in the document and your customization assembly is broken. To fix this issue, change the **ReferenceFromVbaAssembly** property in your project to **False** and then back to **True**, and then replace any references to the old assembly name in the VBA code with the new assembly name.|

## Related content
- [How to: Expose code to VBA in a Visual Basic project](../vsto/how-to-expose-code-to-vba-in-a-visual-basic-project.md)
- [How to: Expose code to VBA in a Visual C&#35; project](../vsto/how-to-expose-code-to-vba-in-a-visual-csharp-project.md)
- [Walkthrough: Call code from VBA in a Visual Basic project](../vsto/walkthrough-calling-code-from-vba-in-a-visual-basic-project.md)
- [Walkthrough: Call code from VBA in a Visual C&#35; project](../vsto/walkthrough-calling-code-from-vba-in-a-visual-csharp-project.md)
- [Design and create Office solutions](../vsto/designing-and-creating-office-solutions.md)
- [VBA and Office solutions in Visual Studio compared](../vsto/vba-and-office-solutions-in-visual-studio-compared.md)
- [Program document-level customizations](../vsto/programming-document-level-customizations.md)
