---
title: "Walkthrough: Analyzing Managed Code for Code Defects | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
helpviewer_keywords:
  - "code analysis, walkthroughs"
  - "managed code, analyzing"
  - "code analysis tool, walkthroughs"
ms.assetid: 22b99f49-1924-4fb5-a421-c8b23e5d5cd4
caps.latest.revision: 47
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# Walkthrough: Analyzing Managed Code for Code Defects
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In this walkthrough, you analyze a managed project for code defects by using the code analysis tool.

 This walkthrough will step you through the process of using code analysis to analyze your .NET managed code assemblies for conformance with the Microsoft .NET Framework Design Guidelines.

 In this walkthrough, you:

- Analyze and correct code defect warnings.

## Prerequisites

- [!INCLUDE[vsPreLong](../includes/vsprelong-md.md)].

## Create a class library

#### To create a class library

1. On the **File** menu of [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)], click **New** and then click **Project**.

2. In the **New Project** dialog box, under **Project Types**, click **Visual C#**.

3. Under **Templates**, select **Class Library**.

4. In the **Name** text box, type **CodeAnalysisManagedDemo** and then click **OK**.

5. After the project is created, open the Class1.cs file.

6. Replace the existing text in Class1.cs with the following code:

     `//CodeAnalysisManagedDemo //Class1.cs using System;  namespace testCode {          public class demo : Exception     {                  public static void Initialize(int size) { }         protected static readonly int _item;         public static int item { get { return _item; } }     } }`

7. Save the Class1.cs file.

## Analyze the project

#### To analyze a managed project for code defects

1. Select the CodeAnalysisManagedDemo project in **Solution Explorer**.

2. On the **Project** menu, click **Properties**.

     The CodeAnalysisManagedDemo properties page is displayed.

3. Click **CodeAnalysis**.

4. Make sure that  **Enable Code Analysis on Build (defines CODE_ANALYSIS constant**) is checked.

5. From the **Run this rule set** drop-down list, select **Microsoft All Rules**.

6. On the **File** menu, click **Save Selected Items**, and then close the ManagedDemo properties pages.

7. On the **Build** menu, click **Build ManagedDemo**.

     The CodeAnalysisManagedDemo project build warnings are reported in the **Code Analysis** and **Output** windows.

     If the **Code Analysis** window does not appear, on the **Analyze** menu, choose **Windows** and then **choose Code Analysis**.

## Correct the Code Analysis Issues

#### To correct code analysis rule violations

1. On the **View** menu, click **Error List**.

     Depending on the developer profile that you chose, you might have to point to **Other Windows** on the **View** menu, and then click **Error List**.

2. In **Solution Explorer**, click **Show All Files**.

3. Next, expand the Properties node, and then open the AssemblyInfo.cs file.

4. Use the following  to correct warnings:

- [CA1014: Mark assemblies with CLSCompliantAttribute](../code-quality/ca1014-mark-assemblies-with-clscompliantattribute.md): Microsoft.Design: 'demo' should be marked with the CLSCompliantAttribute, and its value should be true.

  - Add the code `using``System;` to the AssemblyInfo.cs file.

       Next, add the code `[assembly: CLSCompliant(true)]` to the end of the AssemblyInfo.cs file.

       Rebuild the project.

- [CA1032: Implement standard exception constructors](../code-quality/ca1032-implement-standard-exception-constructors.md): Microsoft.Design: Add the following constructor to this class: public demo(String)

  - Add the constructor `public demo (String s) : base(s) { }` to the class `demo`.

- [CA1032: Implement standard exception constructors](../code-quality/ca1032-implement-standard-exception-constructors.md): Microsoft.Design: Add the following constructor to this class: public demo(String, Exception)

  - Add the constructor `public demo (String s, Exception e) : base(s, e) { }` to the class `demo`.

- [CA1032: Implement standard exception constructors](../code-quality/ca1032-implement-standard-exception-constructors.md): Microsoft.Design: Add the following constructor to this class: protected demo(SerializationInfo, StreamingContext)

  - Add the code `using System.Runtime.Serialization;` to the beginning of the Class1.cs file.

       Next, add the constructor `protected demo (SerializationInfo info, StreamingContext context) : base(info, context) { } to the class demo.`

       Rebuild the project.

- [CA1032: Implement standard exception constructors](../code-quality/ca1032-implement-standard-exception-constructors.md): Microsoft.Design: Add the following constructor to this class: public demo()

  - Add the constructor `public demo () : base() { }` to the class `demo`**.**

       Rebuild the project.

- [CA1709: Identifiers should be cased correctly](../code-quality/ca1709-identifiers-should-be-cased-correctly.md): Microsoft.Naming: Correct the casing of namespace name 'testCode' by changing it to 'TestCode'.

  - Change the casing of the namespace `testCode` to `TestCode`.

- [CA1709: Identifiers should be cased correctly](../code-quality/ca1709-identifiers-should-be-cased-correctly.md): Microsoft.Naming: Correct the casing of type name 'demo' by changing it to 'Demo'.

  - Change the name of the member to `Demo`.

- [CA1709: Identifiers should be cased correctly](../code-quality/ca1709-identifiers-should-be-cased-correctly.md): Microsoft.Naming: Correct the casing of member name 'item' by changing it to 'Item'.

  - Change the name of the member to `Item`.

- [CA1710: Identifiers should have correct suffix](../code-quality/ca1710-identifiers-should-have-correct-suffix.md): Microsoft.Naming: Rename 'testCode.demo' to end in 'Exception'.

  - Change the name of the class and its constructors to `DemoException`.

- [CA2210: Assemblies should have valid strong names](../code-quality/ca2210-assemblies-should-have-valid-strong-names.md): Sign 'ManagedDemo' with a strong name key.

  - On the **Project** menu, click **ManagedDemo Properties**.

       The project properties appear.

       Click **Signing**.

       Select the **Sign the assembly** check box.

       In the **Choose a string name key file** list, select **\<New…>**.

       The **Create Strong Name Key** dialog box appears.

       In the **Key file name**, type TestKey.

       Enter a password and then click **OK**.

       On the **File** menu, click **Save Selected Items**, and then close the property pages.

       Rebuild the project.

- [CA2237: Mark ISerializable types with SerializableAttribute](../code-quality/ca2237-mark-iserializable-types-with-serializableattribute.md): Microsoft.Usage: Add a [Serializable] attribute to type 'demo' as this type implements ISerializable.

  - Add the `[Serializable ()]` attribute to the class `demo`.

       Rebuild the project.

  After you complete the changes, the Class1.cs file should look like the following:

```
//CodeAnalysisManagedDemo
//Class1.cs
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

## Exclude Code Analysis Warnings

#### To exclude code defect warnings

1. For each of the remaining warnings, do the following:

   1. In the Code Analysis window, select the warning.

   2. Choose **Actions**, then choose **Suppress Message**, and then choose **In Project Suppression File**.

      For more information, see [How to: Suppress Warnings by Using the Menu Item](../code-quality/how-to-suppress-warnings-by-using-the-menu-item.md)

2. Rebuild the project.

    The project builds without any warnings or errors.
