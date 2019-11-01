---
title: "Reorder Parameters Refactoring (C#) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-general
ms.topic: reference
f1_keywords:
  - "vs.csharp.refactoring.reorder"
dev_langs:
  - "CSharp"
helpviewer_keywords:
  - "refactoring [C#], Reorder Parameters"
  - "Reorder Parameters refactoring [C#]"
ms.assetid: 4dabf21a-a9f0-41e9-b11b-55760cf2bd90
caps.latest.revision: 26
author: jillre
ms.author: jillfra
manager: jillfra
---
# Reorder Parameters Refactoring (C#)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

`Reorder Parameters` is a Visual C# refactoring operation that provides an easy way to change the order of the parameters for methods, indexers, and delegates. `Reorder Parameters` changes the declaration, and at any locations where the member is called, the parameters are rearranged to reflect the new order.

 To perform the `Reorder Parameters` operation, put the cursor on or next to a method, indexer, or delegate. When the cursor is in position, invoke the `Reorder Parameters` operation by pressing the keyboard shortcut, or by clicking the command from the shortcut menu.

> [!NOTE]
> You cannot reorder the first parameter in an extension method.

### To reorder parameters

1. Create a class library named `ReorderParameters`, and then replace `Class1` with the following example code.

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

3. On the **Refactor** menu, click **Reorder Parameters**.

     The **Reorder Parameters** dialog box appears.

4. In the **Reorder Parameters** dialog box, select `int i` in the **Parameters** list, and then click the down button.

     Alternatively, you can drag `int i` after `bool b` in the **Parameters** list.

5. In the **Reorder Parameters** dialog box, click **OK**.

     If the **Preview reference changes** option is selected in the **Reorder Parameters** dialog box, the **Preview Changes - Reorder Parameters** dialog box will appear. It provides a preview of the changes in the parameter list for `MethodB` in both the signature and the method call.

    1. If the **Preview Changes - Reorder Parameters** dialog box appears, click **Apply**.

         In this example, the method declaration and all the method call sites for `MethodB` are updated.

## Remarks
 You can reorder parameters from a method declaration or a method call. Position the cursor on or next to the method or delegate declaration but not in the body.

## See Also
 [Refactoring (C#)](../csharp-ide/refactoring-csharp.md)