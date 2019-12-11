---
title: "Working with Visual C++ Code (Class Designer) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
f1_keywords:
  - "vs.classdesigner.cpplimitation"
helpviewer_keywords:
  - "Visual C++, Class Designer"
  - "Class Designer, Visual C++ support"
  - "Class Designer, limitations"
  - "Class Designer, tasks in Visual C++"
  - "Visual C++, class diagrams"
  - "C++, class diagrams"
  - "C++, Class Designer"
ms.assetid: f5b40921-2ef7-4de0-b595-45b44c79ffa6
caps.latest.revision: 27
author: jillre
ms.author: jillfra
manager: jillfra
---
# Working with Visual C++ Code (Class Designer)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Class Designer displays a visual design surface called a *class diagram* that provides a visual representation of the code elements in your project. You can use class diagrams to design and visualize classes and other types in a project.

 Class Designer supports the following C++ code elements:

- Class (resembles a managed class shape, except that it can have multiple inheritance relationships)

- Anonymous class (displays Class View's generated name for the anonymous type)

- Template class

- Struct

- Enum

- Macro (displays the post-processed view of the macro)

- Typedef

> [!NOTE]
> This is not the same as the UML class diagram, which you can create in a Modeling Project. For more information, see [UML Class Diagrams: Reference](../modeling/uml-class-diagrams-reference.md).

## Troubleshooting Type Resolution and Display Issues

### Location of Source Files
 Class Designer does not keep track of the location of source files. Therefore, if you modify your project structure or move source files in your project, Class Designer can lose track of the type (especially the source type of a typedef, base classes, or association types). You might receive an error such as **Class Designer is unable to display this type**. If you do, drag the modified or relocated source code to the class diagram again to redisplay it.

### Update and Performance Issues
 For Visual C++ projects, it might take 30 to 60 seconds for a change in the source file to appear in the class diagram. This delay might also cause Class Designer to throw the error **No types were found in the selection**. If you receive an error such as this, click **Cancel** in the error message and wait for the code element to appear in Class View. After you do this, Class Designer should be able to display the type.

 If a class diagram does not update with changes you have made in the code, you might need to close the diagram and open it again.

### Type Resolution Issues
 Class Designer might not be able to resolve types for the following reasons:

- The type is in a project or assembly that is not referenced from the project that contains the class diagram. To correct this error, add a reference to the project or assembly that contains the type. For more information, see [NIB How to: Add or Remove References By Using the Add Reference Dialog Box](https://msdn.microsoft.com/3bd75d61-f00c-47c0-86a2-dd1f20e231c9).

- The type is not in the correct scope, so Class Designer cannot locate it. Ensure that the code is not missing a `using`, `imports`, or `#include` statement. Also make sure that you have not moved the type (or a related type) out of the namespace in which it was originally located.

- The type does not exist (or has been commented out). To correct this error, make sure that you have not commented out or deleted the type.

- The type is located in a library referenced by an #import directive. A possible workaround is to manually add the generated code (the .tlh file) to an #include directive into the header file.

  The error you are most likely to see for a type resolution issue is **Code could not be found for one or more shapes in class diagram '\<element>'**. This error message does not necessarily indicate that your code is in error. It indicates only that class designer was unable to display your code. Try the following measures.

- Ensure that the type exists. Ensure that you have not unintentionally commented out or deleted the source code.

- Ensure that Class Designer supports the type that you entered. See [Limitations for C++ Code Elements](#limitations).

- Try to resolve the type. The type might be in a project or assembly that is not referenced from the project that contains the class diagram. To correct this error, add a reference to the project or assembly that contains the type. For more information, see [NIB How to: Add or Remove References By Using the Add Reference Dialog Box](https://msdn.microsoft.com/3bd75d61-f00c-47c0-86a2-dd1f20e231c9).

- Ensure that the type is in the correct scope so that Class Designer can locate it. Make sure that the code is not missing a `using`, `imports`, or `#include` statement. Also make sure that you have not moved the type (or a related type) out of the namespace in which it was originally located.

### Troubleshooting Other Error Messages
 You can find assistance with troubleshooting errors and warnings in the Microsoft Developer Network (MSDN) public forums. See the [Visual Studio Class Designer Forum](https://go.microsoft.com/fwlink/?linkid=160754).

## <a name="limitations"></a> Limitations for C++ Code Elements

- When a Visual C++ project is loaded, Class Designer functions in a read-only manner. You can change the class diagram, but you cannot save changes from the class diagram back to the source code.

- Class Designer supports only native C++ semantics. For Visual C++ projects that are compiled into managed code, Class Designer will only visualize code elements that are native types. Therefore, you can add a class diagram to a project, but Class Designer will not allow you to visualize elements in which the `IsManaged` property is set to `true` (that is, value types and reference types).

- For Visual C++ projects, the Class Designer reads only the definition of the type. For example, assume that you define a type in a header (.h) file and define its members in an implementation (.cpp) file. If you invoke "View Class Diagram" on the implementation (.cpp) file, Class Designer displays nothing. As another example, if you invoke "View Class Diagram" on a .cpp file that uses an `#include` statement to include other files but does not contain any actual class definitions, Class Designer again displays nothing.

- IDL (.idl) files, which define COM interfaces and type libraries, do not display in diagrams unless they are compiled to native C++ code.

- Class Designer does not support global functions and variables.

- Class Designer does not support unions. This is a special type of class in which the memory allocated is only the amount necessary for the union's largest data member.

- Class Designer does not display basic data types such as `int` and `char`.

- Class Designer does not display types that are defined outside the current project if the project does not have correct references to those types.

- Class Designer can display nested types but not the relationships between a nested type and other types.

- Class Designer cannot display types that are void or that derive from a void type.

## See Also
 [Designing and Viewing Classes and Types](../ide/designing-and-viewing-classes-and-types.md)
 [Working with Classes and Other Types (Class Designer)](../ide/working-with-classes-and-other-types-class-designer.md)
 [Working with Class Diagrams (Class Designer)](../ide/working-with-class-diagrams-class-designer.md)
 [Designing Classes and Types (Class Designer)](../ide/designing-classes-and-types-class-designer.md)
 [Additional Information About Class Designer Errors](../ide/additional-information-about-class-designer-errors.md)
 [Visual C++ Classes in Class Designer](../ide/visual-cpp-classes-in-class-designer.md)
 [Visual C++ Structures in Class Designer](../ide/visual-cpp-structures-in-class-designer.md)
 [Visual C++ Enumerations in Class Designer](../ide/visual-cpp-enumerations-in-class-designer.md)
 [Visual C++ Typedefs in Class Designer](../ide/visual-cpp-typedefs-in-class-designer.md)
