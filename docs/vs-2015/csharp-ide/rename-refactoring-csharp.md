---
title: "Rename Refactoring (C#) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-general
ms.topic: reference
f1_keywords:
  - "vs.csharp.refactoring.rename"
dev_langs:
  - "CSharp"
helpviewer_keywords:
  - "refactoring [C#], Rename"
  - "Rename refactoring [C#]"
ms.assetid: 268942fc-b142-4dfa-8d90-bedd548c2e4f
caps.latest.revision: 45
author: jillre
ms.author: jillfra
manager: jillfra
---
# Rename Refactoring (C#)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

**Rename** is a refactoring feature in the Visual Studio integrated development environment (IDE) that provides an easy way to rename identifiers for code symbols such as fields, local variables, methods, namespaces, properties, and types. **Rename** can be used to change the names in comments and in strings and to change the declarations and calls of an identifier.

> [!NOTE]
> When using Source Control for Visual Studio, get the latest version of sources before you try to perform rename refactoring.

 Rename refactoring is available from the following Visual Studio features:

|Feature|Behavior of Refactoring in the IDE|
|-------------|----------------------------------------|
|Code Editor|In the Code Editor, rename refactoring is available when you position the cursor on certain types of code symbols. When the cursor is in this position, you can invoke the **Rename** command by typing the keyboard shortcut (CTRL + R, CTRL + R), or by selecting the **Rename** command from a smart tag, shortcut menu, or the **Refactor** menu.|
|Class View|When you select an identifier in Class View, rename refactoring is available from the shortcut menu and **Refactor** menu.|
|Object Browser|When you select an identifier in Object Browser, rename refactoring is only available from the **Refactor** menu.|
|Property Grid of the Windows Forms Designer|In the **Property Grid** of the Windows Forms Designer, changing the name of a control will initiate a rename operation for that control. The **Rename** dialog box will not appear.|
|Solution Explorer|In **Solution Explorer**, a **Rename** command is available on the shortcut menu. If the selected source file contains a class whose class name is the same as the file name, you can use this command to simultaneously rename the source file and execute rename refactoring.<br /><br /> For example, if you create a default Windows-based application and then rename Form1.cs to TestForm.cs, the source file name Form1.cs will change to TestForm.cs and the class Form1 and all references to that class will be renamed to TestForm. **Note:**  The **Undo** command (CTRL+Z) will only undo rename refactoring in the code and will not change the file name back to the original name. <br /><br /> If the selected source file does not contain a class whose name is the same as the file name, the **Rename** command in **Solution Explorer** will only rename the source file and will not execute rename refactoring.|

## Rename Operations
 When you execute **Rename**, the refactoring engine performs a rename operation specific for each code symbol, as described in the following table.

|Code Symbol|Rename Operation|
|-----------------|----------------------|
|Field|Changes the declaration and usages of the field to the new name.|
|Local variable|Changes the declaration and usages of the variable to the new name.|
|Method|Changes the name of the method and all references to that method to the new name. **Note:**  When you rename an extension method, the rename operation propagates to all instances of the method that are in scope, regardless of whether the extension method is being used as a static method or an instance method. For more information, see [Extension Methods](https://msdn.microsoft.com/library/175ce3ff-9bbf-4e64-8421-faeb81a0bb51).|
|Namespace|Changes the name of the namespace to the new name in the declaration, all `using` statements, and fully qualified names. **Note:**  When renaming a namespace, [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] also updates the **Default Namespace** property on the **Application** page of the **Project Designer**. This property cannot be reset by selecting **Undo** from the **Edit** menu. To reset the **Default Namespace** property value, you must modify the property in the **Project Designer**. For more information, see [Application Page](../ide/reference/application-page-project-designer-csharp.md).|
|Property|Changes the declaration and usages of the property to the new name.|
|Type|Changes all declarations and all usages of the type to the new name, including constructors and destructors. For partial types, the rename operation will propagate to all parts.|

#### To rename an identifier

1. Create a console application named `RenameIdentifier`, and then replace `Program` with the following example code.

    ```csharp
    class ProtoClassA
    {
        // Invoke on 'MethodB'.
        public void MethodB(int i, bool b) { }
    }

    class ProtoClassC
    {
        void D()
        {
            ProtoClassA MyClassA = new ProtoClassA();

            // Invoke on 'MethodB'.
            MyClassA.MethodB(0, false);
        }
    }
    ```

2. Place the cursor on `MethodB`, either in the method declaration or the method call.

3. From the **Refactor** menu, select **Rename**. The **Rename** dialog box appears.

     You can also right-click the cursor, point to **Refactor** on the context menu, and then click **Rename** to display the **Rename** dialog box.

4. In the **New Name** field, type `MethodC`.

5. Select the **Search in Comments** check box.

6. Click **OK**.

7. In the **Preview Changes** dialog box, click **Apply**.

#### To rename an identifier using smart tags

1. Create a console application named `RenameIdentifier`, and then replace `Program` with the following example code.

    ```csharp
    class ProtoClassA
    {
        // Invoke on 'MethodB'.
        public void MethodB(int i, bool b) { }
    }

    class ProtoClassC
    {
        void D()
        {
            ProtoClassA MyClassA = new ProtoClassA();

            // Invoke on 'MethodB'.
            MyClassA.MethodB(0, false);
        }
    }
    ```

2. In the declaration for `MethodB`, type or backspace over the method identifier. A smart tag prompt will appear below this identifier.

    > [!NOTE]
    > You can only invoke rename refactoring using smart tags at the declaration of an identifier.

3. Type the keyboard shortcut SHIFT+ALT+F10, and then press the DOWN ARROW to display the smart tag menu.

     -or-

     Move the mouse pointer over the smart tag prompt to display the smart tag. Then move the mouse pointer over the smart tag and click the DOWN ARROW to display the smart tag menu.

4. Select the **Rename '\<identifer1>' to '\<identifier2>'** menu item to invoke rename refactoring without a preview of the changes to your code. All references to **\<identifer1>** will automatically be updated to **\<identifier2>**.

     -or-

     Select the **Rename with preview** menu item to invoke rename refactoring with a preview of the changes to your code. The **Preview Changes** dialog box will appear.

## Remarks

## Renaming Implemented or Overridden Members
 When you **Rename** a member that either implements/overrides or is implemented/overridden by members in other types, [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] displays a dialog box that says the rename operation will cause cascading updates. If you click **Continue**, the refactoring engine recursively finds and renames all members in base and derived types that have implements/overrides relationships with the member being renamed.

 The following code example contains members with implements/overrides relationships.

 [!code-csharp[CsUsingCsIDERefactor#1](../snippets/csharp/VS_Snippets_VBCSharp/CsUsingCsIDERefactor/CS/Class1.cs#1)]

 In the previous example, renaming `C.Method()` also renames `Ibase.Method()` because `C.Method()` implements `Ibase.Method()`. Next, the refactor engine recursively sees that `Ibase.Method()` is implemented by `Derived.Method()` and renames `Derived.Method()`. The refactor engine does not rename `Base.Method()`, because `Derived.Method()` does not override `Base.Method()`. The refactoring engine stops here unless you have **Rename overloads** checked in the **Rename** dialog box.

 If **Rename overloads** is checked, the refactor engine renames `Derived.Method(int i)` because it overloads `Derived.Method()`, `Base.Method(int i)` because it is overridden by `Derived.Method(int i)`, and `Base.Method()` because it is an overload of `Base.Method(int i)`.

> [!NOTE]
> When you rename a member that was defined in a referenced assembly, a dialog box explains that renaming will cause build errors.

## Renaming Properties of Anonymous Types
 When you rename a property in anonymous types, the rename operation will propagate to properties in other anonymous types that have the same properties. The following examples illustrate this behavior.

```csharp
var a = new { ID = 1};
var b = new { ID = 2};
```

 In the preceding code, renaming `ID` will change `ID` in both statements because they have the same underlying anonymous type.

```csharp
var companyIDs =
    from c in companylist
    select new { ID = c.ID, Name = c.Name};

var orderIDs =
    from o in orderlist
    select new { ID = o.ID, Item = o.Name};
```

 In the preceding code, renaming `ID` will only rename one instance of `ID` because `companyIDs` and `orderIDs` do not have the same properties.

## See Also
 [Refactoring (C#)](../csharp-ide/refactoring-csharp.md)
 [Anonymous Types](https://msdn.microsoft.com/library/59c9d7a4-3b0e-475e-b620-0ab86c088e9b)