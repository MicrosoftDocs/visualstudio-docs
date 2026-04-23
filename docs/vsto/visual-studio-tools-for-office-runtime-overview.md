---
title: "Visual Studio Tools for Office runtime overview"
description: Explore the Visual Studio 2010 Tools for Microsoft Office runtime, including supported versions, Office extensions for the .NET Framework, and the solution loader. 
ms.date: "02/02/2017"
ms.topic: concept-article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office runtime [Office development in Visual Studio], about Office runtime"
  - "VSTOLoader.dll"
  - "runtime loader [Office development in Visual Studio]"
  - "Office runtime [Office development in Visual Studio], assemblies"
  - "Office runtime [Office development in Visual Studio]"
  - "runtime [Office development in Visual Studio], assemblies"
  - "vstoee.dll"
  - "Visual Studio Tools for Office runtime"
  - "Office solutions [Office development in Visual Studio], runtime"
  - "solutions [Office development in Visual Studio], runtime"
  - "versions [Office development in Visual Studio], runtime"
  - "assemblies [Office development in Visual Studio], runtime"
  - "runtime [Office development in Visual Studio], about VSTO runtime"
  - "solution loader [Office development in Visual Studio]"
  - "runtime [Office development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Visual Studio Tools for Office runtime overview

  To run solutions that are created by using the Microsoft Office developer tools in Visual Studio, the Visual Studio 2010 Tools for Office runtime must be installed on end-user computers. For more information, see [How to: Install the Visual Studio Tools for Office runtime redistributable](../vsto/how-to-install-the-visual-studio-tools-for-office-runtime-redistributable.md). The Visual Studio 2010 Tools for Office runtime consists of two main components:

- The Office extensions for the .NET Framework. These components are managed assemblies that provide the communication layer between your solution and the Microsoft Office application. For more information, see [Understand the Office extensions for the .NET Framework](#officeextensions).

- The Office solution loader. This component is a set of unmanaged DLLs that Office applications use to load the runtime and your solutions. For more information, see [Understand the Office solution loader](#UnmanagedLoader).

  The runtime can be installed in several different ways. Depending on the configuration of the computer, different runtime components are installed when you install the runtime. For more information, see [Visual Studio Tools for Office runtime installation scenarios](../vsto/visual-studio-tools-for-office-runtime-installation-scenarios.md).

## <a name="officeextensions"></a> Understand the Office extensions for the .NET Framework
 The Visual Studio 2010 Tools for Office runtime includes Office extensions for the .NET Framework 3.5, the .NET Framework 4 and later. Solutions that target each version of the .NET Framework use the appropriate extensions for that version.

 These extensions consist of assemblies that your solutions use to automate and extend Office applications. When you create an Office project, Visual Studio automatically adds references to the assemblies that are used for the project type and the target .NET Framework of the project. For more information about the assemblies in the Office extensions, see [Assemblies in the Visual Studio Tools for Office runtime](../vsto/assemblies-in-the-visual-studio-tools-for-office-runtime.md).

### Design differences in the Office extensions
 Most of the types that you use in the Office extensions for the .NET Framework 3.5 are classes. These are the same classes that were included in previous versions of the  Visual Studio Tools for Office runtime . In contrast, most of the types that you use in the Office extensions for the .NET Framework 4 or later are interfaces. For example, when you target the .NET Framework 4 or later, the <xref:Microsoft.Office.Tools.Excel.Worksheet> and <xref:Microsoft.Office.Tools.Word.Document> types are interfaces instead of classes.

 In most cases, the code you write in Office solutions is the same whether your solution targets the .NET Framework 3.5 or the .NET Framework 4. However, certain features require different code when you target different versions of the .NET Framework. For more information, see [Migrate Office solutions to the .NET Framework 4 or later](../vsto/migrating-office-solutions-to-the-dotnet-framework-4-or-later.md).

### Interfaces in the Office extensions for the .NET Framework 4 or later
 Most of the interfaces in the Office extensions for the .NET Framework 4 or later are not intended to be implemented by user code. The only interfaces you can implement directly have names that begin with the letter **I**, such as <xref:Microsoft.Office.Tools.Excel.ISmartTagExtension>.

 All interfaces that do not begin with the letter **I** are implemented internally by the Visual Studio 2010 Tools for Office runtime, and these interfaces might change in future releases. To create objects that implement these interfaces, use methods provided by the `Globals.Factory` object in your project. For example, to get an object that implements the <xref:Microsoft.Office.Tools.Excel.SmartTag> interface, use the `Globals.Factory.CreateSmartTag` method. For more information about `Globals.Factory`, see [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md).

### Enable type equivalence and embedded types in projects that target the .NET Framework 4 or later
 Because the object model of the Office extensions for the .NET Framework 4 or later are based on interfaces, you can use the type equivalence feature in both Visual C# and Visual Basic in Visual Studio to embed type information from the  Visual Studio Tools for Office runtime  into your solution. This feature enables Office solutions and the  Visual Studio Tools for Office runtime  to version independently of each other. For example, if your solution uses the <xref:Microsoft.Office.Tools.Word.Document> interface as an embedded type and the next version of the runtime adds members to the <xref:Microsoft.Office.Tools.Word.Document> interface, your solution will still work with the next version of the runtime. If your solution does not use the <xref:Microsoft.Office.Tools.Word.Document> interface as an embedded type, then your solution will no longer work with the next version of the runtime.

 By default, the type equivalence feature is not enabled when you create an Office project that targets the .NET Framework 4 or later. If you want to enable this feature, set the **Embed Interop Types** property of any of the following assembly references in your project to **True**:

- Microsoft.Office.Tools.dll

- Microsoft.Office.Tools.Common.dll

- Microsoft.Office.Tools.Excel.dll

- Microsoft.Office.Tools.Outlook.dll

- Microsoft.Office.Tools.Word.dll

  After you make this change, type information for all of the runtime types used by the project is embedded into the solution assembly when you build the project. This embedded type information, rather than the type information in the referenced assemblies, are used by the solution at run time.

## <a name="UnmanagedLoader"></a> Understand the Office solution loader
 The Visual Studio Tools for Office runtime includes several unmanaged DLLs that Office applications use to load the runtime and Office solutions. Although you should never have to work with these DLLs directly, knowing the purposes of these DLLs can help you better understand the architecture of Office solutions.

 For information about how these components are used during the load process, see [Architecture of document-level customizations](../vsto/architecture-of-document-level-customizations.md) and [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md).

### VSTOEE.dll
 When a user opens a document-level customization or starts a VSTO Add-in, the Office application calls into *VSTOEE.dll* to perform the tasks required to load the  Visual Studio Tools for Office runtime .

 *VSTOEE.dll* makes sure that the correct version of the  Visual Studio Tools for Office runtime  is loaded for the solution and the installed version of Office. Although multiple versions of the  Visual Studio Tools for Office runtime  can be installed on the same computer, only one instance of *VSTOEE.dll* is installed at a time. This is the *VSTOEE.dll* that was included with the latest version of the runtime installed on the computer. For more information about the different versions of the  Visual Studio Tools for Office runtime  that can be used for other solutions, see [Run solutions in different versions of Microsoft Office](../vsto/running-solutions-in-different-versions-of-microsoft-office.md).

### VSTOLoader.dll
 After *VSTOEE.dll* loads the appropriate version of the  Visual Studio Tools for Office runtime , *VSTOLoader.dll* performs most of the work that is required to load the solution assembly. *VSTOLoader.dll* does several things:

- It creates an application domain for each solution assembly.

- It performs a set of security checks to verify that the solution assembly has permission to run.

- It loads the version of the Office extensions for the .NET Framework that is required by the solution.

  *VSTOLoader.dll* also does several things that are specific to VSTO Add-ins:

- It implements the <xref:Extensibility.IDTExtensibility2> interface. <xref:Extensibility.IDTExtensibility2> is a COM interface that all VSTO Add-ins for Microsoft Office applications must implement. This interface defines methods that the application calls to communicate with the VSTO Add-in.

- It implements the IManagedAddin interface. This interface is used by Office applications to help load VSTO Add-ins. For more information, see [IManagedAddin interface](../vsto/imanagedaddin-interface.md).

## Understand the 32-bit and 64-bit versions of the runtime
 There are separate 64-bit and 32-bit versions of the Visual Studio 2010 Tools for Office runtime. These versions of the runtime are used to run solutions in 64-bit and 32-bit editions Office. The following table shows which version of the runtime is required for each combination of Windows and Office.

|Edition of Windows|Edition of Microsoft Office|Required version of the Visual Studio Tools for Office runtime|
|------------------------|---------------------------------|--------------------------------------------------------------------|
|32-bit|32-bit|32-bit|
|64-bit|32-bit|64-bit|
|64-bit|64-bit|64-bit|

 When you install Office, the required version of the  Visual Studio Tools for Office runtime  is installed along with Office. For example, when you install the 64-bit edition of Office on a 64-bit version of Windows, the 64-bit version of the  Visual Studio Tools for Office runtime  is also installed. For more information about installing the  Visual Studio Tools for Office runtime  with Office, see [Visual Studio Tools for Office runtime installation scenarios](../vsto/visual-studio-tools-for-office-runtime-installation-scenarios.md).

 The 64-bit version of Office can also run Office solutions that were created by using project templates for the 2007 Microsoft Office system in Visual Studio 2008. However, it cannot run Office solutions created by using project templates for Microsoft Office 2003 in Visual Studio 2008, or Office solutions created by using Visual Studio 2005. For more information, see [Run solutions in different versions of Microsoft Office](../vsto/running-solutions-in-different-versions-of-microsoft-office.md).

## Repair the Visual Studio 2010 Tools for Office runtime
 If you need to repair the runtime, open **Programs and Features** or **Add or Remove Programs** in the Control Panel, select **Microsoft Visual Studio 2010 Tools for Office Runtime** in the list of programs, and then click **Uninstall**. The setup program that runs enables you to repair the runtime. If you click **Change**, you are not given an option for repairing the runtime.

## Related content
- [Visual Studio Tools for Office runtime installation scenarios](../vsto/visual-studio-tools-for-office-runtime-installation-scenarios.md)
- [Assemblies in the Visual Studio Tools for Office runtime](../vsto/assemblies-in-the-visual-studio-tools-for-office-runtime.md)
- [Architecture of Office solutions in Visual Studio](../vsto/architecture-of-office-solutions-in-visual-studio.md)
- [Architecture of document-level customizations](../vsto/architecture-of-document-level-customizations.md)
- [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md)
- [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md)
- [Upgrade and migrate Office solutions](../vsto/upgrading-and-migrating-office-solutions.md)
