---
title: "How to: Expose code to VBA in a Visual Basic project"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "VBA [Office development in Visual Studio], exposing code in document-level customizations"
  - "document-level customizations [Office development in Visual Studio], exposing code"
  - "Visual Basic [Office development in Visual Studio], exposing code to VBA"
  - "exposing code to VBA"
  - "host items [Office development in Visual Studio], exposing code to VBA"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Expose code to VBA in a Visual Basic project
  You can expose code in a [!INCLUDE[vbprvb](../sharepoint/includes/vbprvb-md.md)] project to Visual Basic for Applications (VBA) code if you want the two types of code to interact with each other.

 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]

 The Visual Basic process is different from the Visual C# process. For more information, see [How to: Expose code to VBA in a Visual C&#35; project](../vsto/how-to-expose-code-to-vba-in-a-visual-csharp-project.md).

 The process is different for code in a host item class than it is for code in other classes:

- [Expose code in a host item class](#HostItemCode)

- [Expose code that is not in a host item class](#NonHostItem)

## <a name="HostItemCode"></a> Expose code in a host item class
 To enable VBA code to call Visual Basic code in a host item class, set the **EnableVbaCallers** property of the host item to **True**.

 For a walkthrough that demonstrates how to expose a method of a host item class and then call it from VBA, see [Walkthrough: Call code from VBA in a Visual Basic project](../vsto/walkthrough-calling-code-from-vba-in-a-visual-basic-project.md). For more information about host items, see [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md).

#### To expose code in a host item to VBA

1. Open or create a document-level [!INCLUDE[vbprvb](../sharepoint/includes/vbprvb-md.md)] project that is based on a Word document, Excel workbook, or Excel template that supports macros, and that already contains VBA code.

     For more information about the document file formats that support macros, see [Combine VBA and document-level customizations](../vsto/combining-vba-and-document-level-customizations.md).

    > [!NOTE]
    > This feature cannot be used in Word template projects.

2. Ensure that VBA code in the document is allowed to run without prompting the user to enable macros. You can trust VBA code to run by adding the location of the Office project to the list of trusted locations in the Trust Center settings for Word or Excel.

3. Add the property, method, or event that you want to expose to VBA to one of the host item classes in your project, and declare the new member as **Public**. The name of the class depends on the application:

    - In a Word project, the host item class is named `ThisDocument` by default.

    - In an Excel project, the host item classes are named `ThisWorkbook`, `Sheet1`, `Sheet2`, and `Sheet3` by default.

4. Set the **EnableVbaCallers** property for the host item to **True**. This property is available in the **Properties** window when the host item is open in the designer.

     After you set this property, Visual Studio automatically sets the **ReferenceAssemblyFromVbaProject** property to **True**.

    > [!NOTE]
    > If the workbook or document does not already contain VBA code, or if VBA code in the document is not trusted to run, you will receive an error message when you set the **EnableVbaCallers** property to **True**. This is because Visual Studio cannot modify the VBA project in the document in this situation.

5. Click **OK** in the message that is displayed. This message reminds you that if you add VBA code to the workbook or document while you are running the project from [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], the VBA code will be lost the next time you build the project. This is because the document in the build output folder is overwritten every time you build the project.

     At this point, Visual Studio configures the project so that the VBA project can call into the assembly. Visual Studio also adds a property named `CallVSTOAssembly` to the `ThisDocument`, `ThisWorkbook`, `Sheet1`, `Sheet2`, or `Sheet3` module in the VBA project. You can use this property to access public members of the class that you exposed to VBA.

6. Build the project.

## <a name="NonHostItem"></a> Expose code that is not in a host item class
 To enable VBA code to call Visual Basic code that is not in a host item class, modify the code so it is visible to VBA.

### To expose code that is not in a host item class to VBA

1. Open or create a document-level [!INCLUDE[vbprvb](../sharepoint/includes/vbprvb-md.md)] project that is based on a Word document, Excel workbook, or Excel template that supports macros, and that already contains VBA code.

     For more information about the document file formats that support macros, see [Combine VBA and document-level customizations](../vsto/combining-vba-and-document-level-customizations.md).

    > [!NOTE]
    > This feature cannot be used in Word template projects.

2. Ensure that VBA code in the document is allowed to run without prompting the user to enable macros. You can trust VBA code to run by adding the location of the Office project to the list of trusted locations in the Trust Center settings for Word or Excel.

3. Add the member that you want to expose to VBA to a public class in your project, and declare the new member as **public**.

4. Apply the following <xref:System.Runtime.InteropServices.ComVisibleAttribute> and <xref:Microsoft.VisualBasic.ComClassAttribute> attributes to the class that you are exposing to VBA. These attributes make the class visible to VBA.

    ```vb
    <Microsoft.VisualBasic.ComClass()> _
    <System.Runtime.InteropServices.ComVisibleAttribute(True)> _
    ```

5. Override the **GetAutomationObject** method of a host item class in your project to return an instance of the class that you are exposing to VBA. The following code example assumes that you are exposing a class named `DocumentUtilities` to VBA.

    ```vb
    Protected Overrides Function GetAutomationObject() As Object
        Return New DocumentUtilities()
    End Function
    ```

6. Open the document (for Word) or worksheet (for Excel) designer in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

7. In the **Properties** window, select the **ReferenceAssemblyFromVbaProject** property, and change the value to **True**.

    > [!NOTE]
    > If the workbook or document does not already contain VBA code, or if VBA code in the document is not trusted to run, you will receive an error message when you set the **ReferenceAssemblyFromVbaProject** property to **True**. This is because Visual Studio cannot modify the VBA project in the document in this situation.

8. Click **OK** in the message that is displayed. This message reminds you that if you add VBA code to the workbook or document while you are running the project from [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], the VBA code will be lost the next time you build the project. This is because the document in the build output folder is overwritten every time you build the project.

     At this point, Visual Studio configures the project so that the VBA project can call into the assembly. Visual Studio also adds a method named `GetManagedClass` to the VBA project. You can call this method from anywhere in the VBA project to access the class that you exposed to VBA.

9. Build the project.

## See also
- [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md)
- [Design and create Office solutions](../vsto/designing-and-creating-office-solutions.md)
- [Combine VBA and document-level customizations](../vsto/combining-vba-and-document-level-customizations.md)
- [Walkthrough: Call code from VBA in a Visual Basic project](../vsto/walkthrough-calling-code-from-vba-in-a-visual-basic-project.md)
- [How to: Expose code to VBA in a Visual C&#35; project](../vsto/how-to-expose-code-to-vba-in-a-visual-csharp-project.md)
