---
title: "Remove Parameters Refactoring (C#) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-general
ms.topic: reference
f1_keywords:
  - "vs.csharp.refactoring.remove"
dev_langs:
  - "CSharp"
helpviewer_keywords:
  - "parameters [C#], removing"
  - "refactoring [C#], Remove Parameters"
  - "Remove Parameters refactoring [C#]"
ms.assetid: f4fc3265-0ef8-4398-a691-c338178697a6
caps.latest.revision: 24
author: jillre
ms.author: jillfra
manager: jillfra
---
# Remove Parameters Refactoring (C#)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

`Remove Parameters` is a refactoring operation that provides an easy way to remove parameters from methods, indexers, or delegates. Remove Parameters changes the declaration; at any locations where the member is called, the parameter is removed to reflect the new declaration.

 You perform the Remove Parameters operation by first positioning the cursor on a method, indexer, or delegate. While the cursor is in position, to invoke the Remove `Parameters` operation, click the **Refactor** menu, press the keyboard shortcut, or select the command from the shortcut menu.

> [!NOTE]
> You cannot remove the first parameter in an extension method.

### To remove parameters

1. Create a console application named `RemoveParameters`, and then replace `Program` with the following code.

    ```csharp
    class A
    {
        // Invoke on 'A'.
        public A(string s, int i) { }
    }

    class B
    {
        void C()
        {
            // Invoke on 'A'.
            A a = new A("a", 2);
        }
    }
    ```

2. Place the cursor on method `A`, either in the method declaration or the method call.

3. From the **Refactor** menu, select **Remove Parameters** to display the **Remove Parameters** dialog box.

     You can also type the keyboard shortcut CTRL+R, V to display the **Remove Parameters** dialog box.

     You can also right-click the cursor, point to **Refactor**, and then click **Remove Parameters** to display the **Remove Parameters** dialog box.

4. Using the **Parameters** field, position the cursor on `int i`, and then click **Remove**.

5. Click **OK**.

6. In the **Preview Changes — Remove Parameters** dialog box, click **Apply**.

## Remarks
 You can remove parameters from a method declaration or a method call. Position the cursor in the method declaration or delegate name and invoke Remove Parameters.

> [!CAUTION]
> Remove Parameters enables you to remove a parameter that is referenced in the body of the member, but it does not remove the references to that parameter in the method body. This can introduce build errors into your code. However, you can use the **Preview Changes** dialog box to review your code before executing the refactoring operation.

 If a parameter being removed is modified during the call to a method, the removal of the parameter will also remove the modification. For example, if a method call is changed from

```csharp
MyMethod(param1++, param2);
```

 to

```csharp
MyMethod(param2);
```

 by the refactoring operation, `param1` will not be incremented.

## See Also
 [Refactoring (C#)](../csharp-ide/refactoring-csharp.md)