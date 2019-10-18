---
title: "Advanced Compiler Settings Dialog Box (Visual Basic) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords: 
  - "vb.ProjectPropertiesAdvancedCompile"
helpviewer_keywords: 
  - "Advanced Compiler Settings dialog box"
ms.assetid: 1f81133a-293f-4dba-bc1c-8baafb01d857
caps.latest.revision: 52
author: gewarren
ms.author: gewarren
manager: jillfra
---
# Advanced Compiler Settings Dialog Box (Visual Basic)
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Use the **AdvancedCompiler Settings** dialog box of the **Project Designer** to specify the project's advanced build-configuration properties. This dialog box applies to Visual Basic projects only.  
  
### To access this dialog box  
  
1. In **Solution Explorer**, choose a project node (not the **Solution** node).  
  
2. On the **Project** menu, click **Properties**. When the **Project Designer** appears, click the **Compile** tab.  
  
3. On the [Compile Page, Project Designer (Visual Basic)](../../ide/reference/compile-page-project-designer-visual-basic.md), select the **Configuration** and **Platform**. In simplified build configurations, the **Configuration** and **Platform** lists are not displayed. For more information, see [Debug and Release Project Configurations](https://msdn.microsoft.com/0440b300-0614-4511-901a-105b771b236e).  
  
4. Click **Advanced Compile Options**.  
  
   [!INCLUDE[note_settings_general](../../includes/note-settings-general-md.md)]  
  
## Optimizations  
 The following options specify optimizations that can in some cases make a program file smaller, make a program run faster, or speed up the build process.  
  
 **Remove integer overflow checks**  
 By default, this check box is cleared to enable integer overflow checking. Select this check box to remove integer overflow checking. If you select this check box, integer calculations might be faster. However, if you remove overflow checking and data type capacities overflow, incorrect results might be stored without an error being raised.  
  
 If overflow conditions are checked and an integer operation overflows, an <xref:System.OverflowException> exception is thrown. If overflow conditions are not checked, integer operation overflows do not throw an exception.  
  
 **Enable optimizations**  
 By default, this check box is cleared to disable compiler optimizations. Select this check box to enable compiler optimizations. Compiler optimizations make your output file smaller, faster, and more efficient. However, because optimizations cause code rearrangement in the output file, compiler optimizations can make debugging difficult.  
  
 **DLL base address**  
 This text box displays the default DLL base address in hexadecimal format. In Class Library and Control Library projects, you can use this text box to specify the base address to be used when the DLL is created.  
  
 **Generate debug info**  
 Select **None**, **Full**, or **pdb-only** from the list. **None** specifies that no debugging information be generated. **Full** specifies that full debugging information be generated, and **pdb-only** specifies that only PDB debugging information be generated. By default, this option is set to **Full**.  
  
## Compilation Constants  
 Conditional compilation constants have an effect similar to that of using a [#Const](https://msdn.microsoft.com/library/707669e5-23f9-4f17-8622-a0d534429386) preprocessor directive in a source file, except that constants defined are public and apply to all files in the project. You can use conditional compilation constants together with the [#If...Then...#Else](https://msdn.microsoft.com/library/10bba104-e3fd-451b-b672-faa472530502) directive to compile source files conditionally. See [Conditional Compilation](https://msdn.microsoft.com/library/9c35e55e-7eee-44fb-a586-dad1f1884848).  
  
 **Define DEBUG constant**  
 By default, this check box is selected, specifying that a DEBUG constant be set.  
  
 **Define TRACE constant**  
 By default, this check box is selected, specifying that a TRACE constant be set.  
  
 **Custom constants**  
 Enter any custom constants for your application in this text box. Entries should be delimited by commas, using this form: **Name1="Value1",Name2="Value2",Name3="Value3"**.  
  
## Other Settings  
 **Generate serialization assemblies**  
 This setting specifies whether the compiler will create XML serialization assemblies. Serialization assemblies can improve the startup performance of <xref:System.Xml.Serialization.XmlSerializer> if you have used that class to serialize types in your code. By default, this option is set to **Auto**, which specifies that serialization assemblies be generated only if you have used <xref:System.Xml.Serialization.XmlSerializer> to encode types in your code to XML. **Off** specifies that serialization assemblies never be generated, regardless of whether your code uses <xref:System.Xml.Serialization.XmlSerializer>. **On** specifies that serialization assemblies always be generated. Serialization assemblies are named `TypeName`.XmlSerializers.dll.  
  
## See also  
 [Compile Page, Project Designer (Visual Basic)](../../ide/reference/compile-page-project-designer-visual-basic.md)
