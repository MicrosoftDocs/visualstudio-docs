---
title: Working with C++ Code (Class Designer)
description: Learn how to use class diagrams to design and visualize C++ code element, classes, and other types in a project.
ms.custom: SEO-VS-2020
ms.date: 06/21/2017
ms.topic: conceptual
f1_keywords:
- vs.classdesigner.cpplimitation
helpviewer_keywords:
- C++, Class Designer
- Class Designer, C++ support
- Class Designer, limitations
- Class Designer, tasks in C++
- C++, class diagrams
- C++, class diagrams
- C++, Class Designer
ms.assetid: f5b40921-2ef7-4de0-b595-45b44c79ffa6
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- cplusplus
---
# Work with C++ code in Class Designer

**Class Designer** displays a visual design surface called a *class diagram* that provides a visual representation of the code elements in your project. You can use class diagrams to design and visualize classes and other types in a project.

**Class Designer** supports the following C++ code elements:

- Class (resembles a managed class shape, except that it can have multiple inheritance relationships)

- Anonymous class (displays Class View's generated name for the anonymous type)

- Template class

- Struct

- Enum

- Macro (displays the post-processed view of the macro)

- Typedef

> [!NOTE]
> This is not the same as the UML class diagram, which you can create in a Modeling Project. For more information, see [UML Class Diagrams: Reference](../../modeling/what-s-new-for-design-in-visual-studio.md).

## Troubleshoot type resolution and display issues

### Location of source files

**Class Designer** does not keep track of the location of source files. Therefore, if you modify your project structure or move source files in your project, **Class Designer** can lose track of the type (especially the source type of a typedef, base classes, or association types). You might receive an error such as **Class Designer is unable to display this type**. If you do, drag the modified or relocated source code to the class diagram again to redisplay it.

### Update and performance issues

For C++ projects, it might take 30 to 60 seconds for a change in the source file to appear in the class diagram. This delay might also cause **Class Designer** to throw the error **No types were found in the selection**. If you receive an error such as this, click **Cancel** in the error message and wait for the code element to appear in **Class View**. After you do this, **Class Designer** should be able to display the type.

If a class diagram does not update with changes you have made in the code, you might need to close the diagram and open it again.

### Type resolution issues

**Class Designer** might not be able to resolve types for the following reasons:

- The type is in a project or assembly that is not referenced from the project that contains the class diagram. To correct this error, add a reference to the project or assembly that contains the type. For more information, see [Managing references in a project](../managing-references-in-a-project.md).

- The type is not in the correct scope, so **Class Designer** cannot locate it. Ensure that the code is not missing a `using`, `imports`, or `#include` statement. Also make sure that you have not moved the type (or a related type) out of the namespace in which it was originally located.

- The type does not exist (or has been commented out). To correct this error, make sure that you have not commented out or deleted the type.

- The type is located in a library referenced by an #import directive. A possible workaround is to manually add the generated code (the .tlh file) to an #include directive into the header file.

- Ensure that **Class Designer** supports the type that you entered. See [Limitations for C++ Code Elements](#limitations-for-c-code-elements).

The error you are most likely to see for a type resolution issue is **Code could not be found for one or more shapes in class diagram '\<element>'**. This error message does not necessarily indicate that your code is in error. It indicates only that class designer was unable to display your code. Try the following measures:

- Ensure that the type exists. Ensure that you have not unintentionally commented out or deleted the source code.

- Try to resolve the type. The type might be in a project or assembly that is not referenced from the project that contains the class diagram. To correct this error, add a reference to the project or assembly that contains the type. For more information, see [Managing references in a project](../managing-references-in-a-project.md).

- Ensure that the type is in the correct scope so that Class Designer can locate it. Make sure that the code is not missing a `using`, `imports`, or `#include` statement. Also make sure that you have not moved the type (or a related type) out of the namespace in which it was originally located.

### Troubleshoot other error messages

You can find assistance with troubleshooting errors and warnings in the Microsoft Developer Network (MSDN) public forums. See the [Visual Studio Class Designer Forum](https://social.msdn.microsoft.com/Forums/en-US/home?forum=vsclassdesigner).

## Limitations for C++ code elements

- When a C++ project is loaded, **Class Designer** functions in a read-only manner. You can change the class diagram, but you cannot save changes from the class diagram back to the source code.

- **Class Designer** supports only native C++ semantics. For C++ projects that are compiled into managed code, **Class Designer** will only visualize code elements that are native types. Therefore, you can add a class diagram to a project, but **Class Designer** will not allow you to visualize elements in which the `IsManaged` property is set to `true` (that is, value types and reference types).

- For C++ projects, the **Class Designer** reads only the definition of the type. For example, assume that you define a type in a header (.h) file and define its members in an implementation (.cpp) file. If you invoke "View Class Diagram" on the implementation (.cpp) file, **Class Designer** displays nothing. As another example, if you invoke "View Class Diagram" on a .cpp file that uses an `#include` statement to include other files but does not contain any actual class definitions, **Class Designer** again displays nothing.

- IDL (.idl) files, which define COM interfaces and type libraries, do not display in diagrams unless they are compiled to native C++ code.

- **Class Designer** does not support global functions and variables.

- **Class Designer** does not support unions. This is a special type of class in which the memory allocated is only the amount necessary for the union's largest data member.

- **Class Designer** does not display basic data types such as `int` and `char`.

- **Class Designer** does not display types that are defined outside the current project if the project does not have correct references to those types.

- **Class Designer** can display nested types but not the relationships between a nested type and other types.

- **Class Designer** cannot display types that are void or that derive from a void type.

## See also

- [Designing and Viewing Classes and Types](designing-and-viewing-classes-and-types.md)
- [Additional Information About Class Designer Errors](additional-information-about-errors.md)
- [C++ Classes in Class Designer](visual-cpp-classes.md)
- [C++ Structures in Class Designer](visual-cpp-structures.md)
- [C++ Enumerations in Class Designer](visual-cpp-enumerations.md)
- [C++ Typedefs in Class Designer](visual-cpp-typedefs.md)
