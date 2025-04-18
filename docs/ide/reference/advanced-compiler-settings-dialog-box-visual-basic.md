---
title: Advanced Compiler Settings Dialog Box (Visual Basic)
description: Learn how you can use the Advanced Compiler Settings dialog box to specify the project's advanced build-configuration properties.
ms.date: 11/04/2016
ms.subservice: compile-build
ms.topic: reference
f1_keywords:
- vb.ProjectPropertiesAdvancedCompile
helpviewer_keywords:
- Advanced Compiler Settings dialog box
ms.custom: "ide-ref"
author:ghogen
ms.author: ghogen
manager: ghogen
monikerRange: 'vs-2019'
---
# Advanced Compiler Settings Dialog Box (Visual Basic)

Use the **AdvancedCompiler Settings** dialog box of the **Project Designer** to specify the project's advanced build-configuration properties. This dialog box applies to Visual Basic projects only.

## To access this dialog box

1. In **Solution Explorer**, choose a project node (not the **Solution** node).

2. On the **Project** menu, click **Properties**. When the **Project Designer** appears, click the **Compile** tab.

3. On the [Compile Page, Project Designer (Visual Basic)](../../ide/reference/compile-page-project-designer-visual-basic.md), select the **Configuration** and **Platform**. In simplified build configurations, the **Configuration** and **Platform** lists are not displayed. For more information, see [How to: Set debug and release configurations](../../debugger/how-to-set-debug-and-release-configurations.md).

4. Click **Advanced Compile Options**.

[!INCLUDE[note_settings_general](../../data-tools/includes/note_settings_general_md.md)]

## Optimizations

The following options specify optimizations that can in some cases make a program file smaller, make a program run faster, or speed up the build process.

**Remove integer overflow checks**

This check box is cleared, by default, to enable integer overflow checking. Select this check box to remove integer overflow checking. If you select this check box, integer calculations might be faster. However, if you remove overflow checking and data type capacities overflow, incorrect results might be stored without an error being raised.

If overflow conditions are checked and an integer operation overflows, an <xref:System.OverflowException> exception is thrown. If overflow conditions are not checked, integer operation overflows don't throw an exception.

**Enable optimizations**

This check box is cleared, by default, to disable compiler optimizations. Select this check box to enable compiler optimizations. Compiler optimizations make your output file smaller, faster, and more efficient. However, because optimizations cause code rearrangement in the output file, compiler optimizations can make debugging difficult.

 **DLL base address**

This text box displays the default DLL base address in hexadecimal format. In Class Library and Control Library projects, you can use this text box to specify the base address to be used when the DLL is created.

 **Generate debug info**

Select **None**, **Full**, or **pdb-only** from the list. **None** specifies that no debugging information be generated. **Full** specifies that full debugging information be generated, and **pdb-only** specifies that only PDB debugging information should be generated. The default value for this option is **Full**.

## Compilation Constants

Conditional compilation constants have an effect similar to that of using a [#Const](/dotnet/visual-basic/language-reference/directives/const-directive) preprocessor directive in a source file, except that constants defined are public and apply to all files in the project. You can use conditional compilation constants together with the [#If...Then...#Else](/dotnet/visual-basic/language-reference/directives/if-then-else-directives) directive to compile source files conditionally. See [Conditional Compilation](/dotnet/visual-basic/programming-guide/program-structure/conditional-compilation).

 **Define DEBUG constant**

By default, this check box is selected, specifying that a DEBUG constant be set.

 **Define TRACE constant**

By default, this check box is selected, specifying that a TRACE constant be set.

 **Custom constants**

Enter any custom constants for your application in this text box. Entries should be delimited by commas, using this form: **Name1="Value1",Name2="Value2",Name3="Value3"**.

## Other Settings

**Generate serialization assemblies**

This setting specifies whether the compiler will create XML serialization assemblies. Serialization assemblies can improve the startup performance of <xref:System.Xml.Serialization.XmlSerializer> if you've used that class to serialize types in your code. The default value for this option is **Auto**. **Auto** specifies that serialization assemblies be generated only if you've used <xref:System.Xml.Serialization.XmlSerializer> to encode types in your code to XML. **Off** specifies that serialization assemblies never be generated, regardless of whether your code uses <xref:System.Xml.Serialization.XmlSerializer>. **On** specifies that serialization assemblies always be generated. Serialization assemblies are named `TypeName`.XmlSerializers.dll.

## See also

- [Compile Page, Project Designer (Visual Basic)](../../ide/reference/compile-page-project-designer-visual-basic.md)
