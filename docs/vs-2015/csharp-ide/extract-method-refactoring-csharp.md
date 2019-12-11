---
title: "Extract Method Refactoring (C#) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-general
ms.topic: reference
f1_keywords:
  - "vs.csharp.refactoring.extractmethod"
dev_langs:
  - "CSharp"
helpviewer_keywords:
  - "refactoring [C#], Extract Method"
  - "Extract Method refactoring operation [C#]"
ms.assetid: eeba11df-a815-4bec-9c21-8a831891b783
caps.latest.revision: 29
author: jillre
ms.author: jillfra
manager: jillfra
---
# Extract Method Refactoring (C#)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

**Extract Method** is a refactoring operation that provides an easy way to create a new method from a code fragment in an existing member.

 Using **Extract Method**, you can create a new method by extracting a selection of code from inside the code block of an existing member. The new, extracted method contains the selected code, and the selected code in the existing member is replaced with a call to the new method. Turning a fragment of code into its own method lets you quickly and accurately reorganize code for better reuse and readability.

 **Extract Method** has the following benefits:

- Encourages best coding practices by emphasizing discrete, reusable methods.

- Encourages self-documenting code through good organization.

     When descriptive names are used, high-level methods can read more like a series of comments.

- Encourages the creation of finer-grained methods to simplify overriding.

- Reduces code duplication.

### To use Extract Method

1. Create a console application named `ExtractMethod`, and then replace `Program` with the following example code.

    ```csharp
    class A
    {
        const double PI = 3.141592;

        double CalculatePaintNeeded(double paintPerUnit, double radius)
        {
            // Select any of the following:
            // 1. The entire next line of code.
            // 2. The right-hand side of the next line of code.
            // 3. Just "PI *" of the right-hand side of the next line
            //    of code (to see the prompt for selection expansion).
            // 4.  All code within the method body.
            // ...Then invoke Extract Method.

            double area = PI * radius * radius;

            return area / paintPerUnit;
        }
    }
    ```

2. Select the code fragment you want to extract:

    ```csharp
    double area = PI * radius * radius;
    ```

3. On the **Refactor** menu, click **Extract Method**.

     The **Extract Method** dialog box appears.

     Alternatively, you can also type the keyboard shortcut CTRL+R, M to display the **Extract Method** dialog box.

     You can also right-click the selected code, point to **Refactor**, and then click **Extract Method** to display the **Extract Method** dialog box.

4. Specify a name for the new method, such as `CircleArea`, in the **New Method Name** box.

     A preview of the new method signature displays under **Preview Method Signature**.

5. Click **OK**.

## Remarks
 When you use the **Extract Method** command, the new method is inserted following the source member in the same class.

## Partial Types
 If the class is a partial type, then **Extract Method** generates the new method immediately following the source member. **Extract Method** determines the signature of the new method, creating a static method when no instance data is referenced by the code in the new method.

## Generic Type Parameters
 When you extract a method that has an unconstrained generic type parameter, the generated code will not add the `ref` modifier to that parameter unless a value is assigned to it. If the extracted method will support reference types as the generic type argument, then you should manually add the `ref` modifier to the parameter in the method signature.

## Anonymous Methods
 If you try to extract part of an anonymous method that includes a reference to a local variable that is either declared or referenced outside the anonymous method, then Visual Studio will warn you about potential semantic changes.

 When an anonymous method uses the value of a local variable, the value is obtained at the moment the anonymous method is executed. When an anonymous method is extracted into another method, the value of the local variable is obtained at the moment of the call to the extracted method.

 The following example illustrates this semantic change. If this code is executed, then **11** will be printed to the console. If you use **Extract Method** to extract the region of code that is marked by code comments into its own method and then execute the refactored code, then **10** will be printed to the console.

```csharp
class Program
{
    delegate void D();
    D d;
    static void Main(string[] args)
    {
        Program p = new Program();
        int i = 10;
        /*begin extraction*/
            p.d = delegate { Console.WriteLine(i++); };
        /*end extraction*/
        i++;
        p.d();
    }
}
```

 To work around this situation, make the local variables that are used in the anonymous method fields of the class.

## See Also
 [Refactoring (C#)](../csharp-ide/refactoring-csharp.md)