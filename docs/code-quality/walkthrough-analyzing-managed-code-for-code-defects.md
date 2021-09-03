---
title: Walkthrough Analyzing Managed Code for Code Defects | Microsoft Docs
ms.date: 01/29/2018
description: Learn how to use legacy code analysis to analyze .NET managed code assemblies. See how to check for defects and for conformance with .NET design guidelines.
ms.custom: SEO-VS-2020
ms.topic: "conceptual"
helpviewer_keywords:
  - "code analysis [Visual Studio]"
  - "managed code, analyzing"
author: mikadumont
ms.author: midumont
manager: jmartens
ms.technology: vs-ide-code-analysis
ms.workload:
  - "dotnet"
---
# Walkthrough: Use static code analysis to find code defects

In this walkthrough, you'll analyze a managed project for code defects by using legacy code analysis.

This article steps you through the process of using legacy analysis to analyze your .NET managed code assemblies for conformance with the .NET design guidelines.

## Create a class library

1. Open Visual Studio and create a new project from the **Class Library (.NET Framework)** template.

1. Name the project **CodeAnalysisManagedDemo**.

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

## Analyze the project for code defects

1. Select the CodeAnalysisManagedDemo project in **Solution Explorer**.

2. On the **Project** menu, click **Properties**.

   The CodeAnalysisManagedDemo properties page is displayed.

3. Choose the **Code Analysis** tab.

::: moniker range="vs-2017"

4. Make sure that **Enable Code Analysis on Build** is selected.

5. From the **Run this rule set** drop-down list, select **Microsoft All Rules**.

::: moniker-end

::: moniker range=">=vs-2019"

4. Make sure that **Run on build** is selected in the **Binary analyzers** section.

5. From the **Active rules** drop-down list, select **Microsoft All Rules**.

::: moniker-end

6. On the **File** menu, click **Save Selected Items**, and then close the properties pages.

7. On the **Build** menu, click **Build CodeAnalysisManagedDemo**.

    The CodeAnalysisManagedDemo project build warnings are shown in the **Error List** and **Output** windows.

## Correct the code analysis issues

1. On the **View** menu, choose **Error List**.

    Depending on the developer profile that you chose, you might have to point to **Other Windows** on the **View** menu, and then choose **Error List**.

1. In **Solution Explorer**, choose **Show All Files**.

1. Expand the Properties node, and then open the *AssemblyInfo.cs* file.

1. Use the following tips to correct the warnings:

   [CA1014: Mark assemblies with CLSCompliantAttribute](/dotnet/fundamentals/code-analysis/quality-rules/ca1014): Add the code `[assembly: CLSCompliant(true)]` to the end of the AssemblyInfo.cs file.

   [CA1032: Implement standard exception constructors](/dotnet/fundamentals/code-analysis/quality-rules/ca1032): Add the constructor `public demo (String s) : base(s) { }` to the class `demo`.

   [CA1032: Implement standard exception constructors](/dotnet/fundamentals/code-analysis/quality-rules/ca1032): Add the constructor `public demo (String s, Exception e) : base(s, e) { }` to the class `demo`.

   [CA1032: Implement standard exception constructors](/dotnet/fundamentals/code-analysis/quality-rules/ca1032): Add the constructor `protected demo (SerializationInfo info, StreamingContext context) : base(info, context) { }` to the class demo. You'll also need to add a `using` statement for <xref:System.Runtime.Serialization?displayProperty=fullName>.

   [CA1032: Implement standard exception constructors](/dotnet/fundamentals/code-analysis/quality-rules/ca1032): Add the constructor `public demo () : base() { }` to the class `demo`.

   [CA1709: Identifiers should be cased correctly](../code-quality/ca1709.md): Change the casing of the namespace `testCode` to `TestCode`.

   [CA1709: Identifiers should be cased correctly](../code-quality/ca1709.md): Change the name of the member to `Demo`.

   [CA1709: Identifiers should be cased correctly](../code-quality/ca1709.md): Change the name of the member to `Item`.

   [CA1710: Identifiers should have correct suffix](/dotnet/fundamentals/code-analysis/quality-rules/ca1710): Change the name of the class and its constructors to `DemoException`.

   [CA2237: Mark ISerializable types with SerializableAttribute](/dotnet/fundamentals/code-analysis/quality-rules/ca2237): Add the `[Serializable ()]` attribute to the class `demo`.

   [CA2210: Assemblies should have valid strong names](../code-quality/ca2210.md): Sign 'CodeAnalysisManagedDemo' with a strong name key:

   1. On the **Project** menu, choose **CodeAnalysisManagedDemo Properties**.

      The project properties appear.

   1. Choose the **Signing** tab.

   1. Select the **Sign the assembly** check box.

   1. In the **Choose a string name key file** list, select **\<New>**.

      The **Create Strong Name Key** dialog box appears.

   1. For **Key file name**, enter **TestKey**.

   1. Enter a password, and then choose **OK**.

   1. On the **File** menu, choose **Save Selected Items**, and then close the property pages.

   After you complete all the changes, the Class1.cs file should look like the following:

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
