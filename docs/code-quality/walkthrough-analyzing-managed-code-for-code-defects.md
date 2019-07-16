---
title: Walkthrough Analyzing Managed Code for Code Defects | Microsoft Docs
ms.date: 01/29/2018
ms.topic: "conceptual"
helpviewer_keywords:
  - "code analysis [Visual Studio]"
  - "managed code, analyzing"
author: mikadumont
ms.author: midumont
manager: jillfra
ms.workload:
  - "dotnet"
---
# Walkthrough: Use static code analysis to find code defects

In this walkthrough, you'll analyze a managed project for code defects by using the code analysis tool.

This walkthrough steps you through the process of using static code analysis to analyze your .NET managed code assemblies for conformance with the .NET design guidelines.

## Create a class library

### To create a class library

1. On the **File** menu, choose **New** > **Project**.

1. In the **New Project** dialog box, expand **Installed** > **Visual C#**, and then choose **Windows Desktop**.

1. Choose the **Class Library (.NET Framework)** template.

1. In the **Name** text box, type **CodeAnalysisManagedDemo** and then click **OK**.

1. After the project is created, open the *Class1.cs* file.

1. Replace the existing text in Class1.cs with the following code:

   ```csharp
   using System;

   namespace testCode
   {
       public class demo : Exception
       {
           public static void Initialize(int size) { }
           protected static readonly int _item;
           public static int item { get { return _item; } }
       }
   }
   ```

1. Save the Class1.cs file.

## Analyze the project

### To analyze a managed project for code defects

1. Select the CodeAnalysisManagedDemo project in **Solution Explorer**.

1. On the **Project** menu, click **Properties**.

     The CodeAnalysisManagedDemo properties page is displayed.

1. Choose the **Code Analysis** tab.

1. Make sure that **Enable Code Analysis on Build** is checked.

1. From the **Run this rule set** drop-down list, select **Microsoft All Rules**.

1. On the **File** menu, click **Save Selected Items**, and then close the properties pages.

1. On the **Build** menu, click **Build CodeAnalysisManagedDemo**.

    The CodeAnalysisManagedDemo project build warnings are shown in the **Error List** and **Output** windows.

## Correct the code analysis issues

### To correct code analysis rule violations

1. On the **View** menu, choose **Error List**.

    Depending on the developer profile that you chose, you might have to point to **Other Windows** on the **View** menu, and then choose **Error List**.

1. In **Solution Explorer**, choose **Show All Files**.

1. Expand the Properties node, and then open the *AssemblyInfo.cs* file.

1. Use the following tips to correct the warnings:

   [CA1014: Mark assemblies with CLSCompliantAttribute](../code-quality/ca1014-mark-assemblies-with-clscompliantattribute.md): Microsoft.Design: 'demo' should be marked with the CLSCompliantAttribute, and its value should be true.

   1. Add the code `using System;` to the AssemblyInfo.cs file.

   1. Next, add the code `[assembly: CLSCompliant(true)]` to the end of the AssemblyInfo.cs file.

   [CA1032: Implement standard exception constructors](../code-quality/ca1032-implement-standard-exception-constructors.md): Microsoft.Design: Add the following constructor to this class: public demo(String)

   1. Add the constructor `public demo (String s) : base(s) { }` to the class `demo`.

   [CA1032: Implement standard exception constructors](../code-quality/ca1032-implement-standard-exception-constructors.md): Microsoft.Design: Add the following constructor to this class: public demo(String, Exception)

   1. Add the constructor `public demo (String s, Exception e) : base(s, e) { }` to the class `demo`.

   [CA1032: Implement standard exception constructors](../code-quality/ca1032-implement-standard-exception-constructors.md): Microsoft.Design: Add the following constructor to this class: protected demo(SerializationInfo, StreamingContext)

   1. Add the code `using System.Runtime.Serialization;` to the beginning of the Class1.cs file.

   1. Next, add the constructor `protected demo (SerializationInfo info, StreamingContext context) : base(info, context) { } to the class demo.`

   [CA1032: Implement standard exception constructors](../code-quality/ca1032-implement-standard-exception-constructors.md): Microsoft.Design: Add the following constructor to this class: public demo()

   1. Add the constructor `public demo () : base() { }` to the class `demo`**.**

   [CA1709: Identifiers should be cased correctly](../code-quality/ca1709-identifiers-should-be-cased-correctly.md): Microsoft.Naming: Correct the casing of namespace name 'testCode' by changing it to 'TestCode'.

   1. Change the casing of the namespace `testCode` to `TestCode`.

   [CA1709: Identifiers should be cased correctly](../code-quality/ca1709-identifiers-should-be-cased-correctly.md): Microsoft.Naming: Correct the casing of type name 'demo' by changing it to 'Demo'.

   1. Change the name of the member to `Demo`.

   [CA1709: Identifiers should be cased correctly](../code-quality/ca1709-identifiers-should-be-cased-correctly.md): Microsoft.Naming: Correct the casing of member name 'item' by changing it to 'Item'.

   1. Change the name of the member to `Item`.

   [CA1710: Identifiers should have correct suffix](../code-quality/ca1710-identifiers-should-have-correct-suffix.md): Microsoft.Naming: Rename 'testCode.demo' to end in 'Exception'.

   1. Change the name of the class and its constructors to `DemoException`.

   [CA2210: Assemblies should have valid strong names](../code-quality/ca2210-assemblies-should-have-valid-strong-names.md): Sign 'CodeAnalysisManagedDemo' with a strong name key.

   1. On the **Project** menu, choose **CodeAnalysisManagedDemo Properties**.

      The project properties appear.

   1. Choose the **Signing** tab.

   1. Select the **Sign the assembly** check box.

   1. In the **Choose a string name key file** list, select **\<New...>**.

      The **Create Strong Name Key** dialog box appears.

   1. In the **Key file name**, type TestKey.

   1. Enter a password and then choose **OK**.

   1. On the **File** menu, choose **Save Selected Items**, and then close the property pages.

   [CA2237: Mark ISerializable types with SerializableAttribute](../code-quality/ca2237-mark-iserializable-types-with-serializableattribute.md): Microsoft.Usage: Add a [Serializable] attribute to type 'demo' as this type implements ISerializable.

   1. Add the `[Serializable ()]` attribute to the class `demo`.

   After you complete the changes, the Class1.cs file should look like the following:

   ```csharp
   using System;
   using System.Runtime.Serialization;

   namespace TestCode
   {
       [Serializable()]
       public class DemoException : Exception
       {
           public DemoException () : base() { }
           public DemoException(String s) : base(s) { }
           public DemoException(String s, Exception e) : base(s, e) { }
           protected DemoException(SerializationInfo info, StreamingContext context) : base(info, context) { }

           public static void Initialize(int size) { }
           protected static readonly int _item;
           public static int Item { get { return _item; } }
       }
   }
   ```

1. Rebuild the project.

## Exclude code analysis warnings

1. For each of the remaining warnings, do the following:

    1. Select the warning in the **Error List**.

    1. From the right-click menu (context menu), choose **Suppress** > **In Suppression File**.

1. Rebuild the project.

     The project builds without any warnings or errors.

## See also

[Code analysis for managed code](../code-quality/code-analysis-for-managed-code-overview.md)