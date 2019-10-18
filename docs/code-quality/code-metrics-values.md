---
title: Calculate code metrics
ms.date: 11/02/2018
ms.topic: "conceptual"
helpviewer_keywords:
  - "code metrics [Visual Studio]"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Code metrics values

The increased complexity of modern software applications also increases the difficulty of making the code reliable and maintainable. Code metrics is a set of software measures that provide developers better insight into the code they are developing. By taking advantage of code metrics, developers can understand which types and/or methods should be reworked or more thoroughly tested. Development teams can identify potential risks, understand the current state of a project, and track progress during software development.

Developers can use Visual Studio to generate code metrics data that measure the complexity and maintainability of their managed code. Code metrics data can be generated for an entire solution or a single project.

For information about how to generate code metrics data in Visual Studio, see [How to: Generate code metrics data](../code-quality/how-to-generate-code-metrics-data.md).

## Software measurements

The following list shows the code metrics results that Visual Studio calculates:

- **Maintainability Index** - Calculates an index value between 0 and 100 that represents the relative ease of maintaining the code. A high value means better maintainability. Color coded ratings can be used to quickly identify trouble spots in your code. A green rating is between 20 and 100 and indicates that the code has good maintainability. A yellow rating is between 10 and 19 and indicates that the code is moderately maintainable. A red rating is a rating between 0 and 9 and indicates low maintainability. For more information, see the [Maintainability index range and meaning](https://blogs.msdn.microsoft.com/codeanalysis/2007/11/20/maintainability-index-range-and-meaning/) blog post.

- **Cyclomatic Complexity** - Measures the structural complexity of the code. It is created by calculating the number of different code paths in the flow of the program. A program that has complex control flow requires more tests to achieve good code coverage and is less maintainable. For more information, see the [Wikipedia entry for cyclomatic complexity](https://wikipedia.org/wiki/Cyclomatic_complexity).

- **Depth of Inheritance** - Indicates the number of different classes that inherit from one another, all the way back to the base class. Depth of Inheritance is similar to class coupling in that a change in a base class can affect any of its inherited classes. The higher this number, the deeper the inheritance and the higher the potential for base class modifications to result in a breaking change. For Depth of Inheritance, a low value is good and a high value is bad.

- **Class Coupling** - Measures the coupling to unique classes through parameters, local variables, return types, method calls, generic or template instantiations, base classes, interface implementations, fields defined on external types, and attribute decoration. Good software design dictates that types and methods should have high cohesion and low coupling. High coupling indicates a design that is difficult to reuse and maintain because of its many interdependencies on other types. For more information, see the [Class coupling](https://blogs.msdn.microsoft.com/zainnab/2011/05/25/code-metrics-class-coupling/) blog post.

- **Lines of Code** - Indicates the approximate number of lines in the code. The count is based on the IL code and is therefore not the exact number of lines in the source code file. A high count might indicate that a type or method is trying to do too much work and should be split up. It might also indicate that the type or method might be hard to maintain.

   > [!NOTE]
   > The [command-line version](../code-quality/how-to-generate-code-metrics-data.md#command-line-code-metrics) of the code metrics tool counts actual lines of code because it analyzes the source code instead of IL.

## Anonymous methods

An *anonymous method* is just a method that has no name. Anonymous methods are most frequently used to pass a code block as a delegate parameter. Code metrics results for an anonymous method that's declared in a member, such as a method or accessor, are associated with the member that declares the method. They are not associated with the member that calls the method.

## Generated code

Some software tools and compilers generate code that is added to a project and that the project developer either does not see or should not change. Mostly, Code Metrics ignores generated code when it calculates the metrics values. This enables the metrics values to reflect what the developer can see and change.

Code generated for Windows Forms is not ignored, because it is code that the developer can see and change.

## Next steps

- [How to: Generate code metrics data](../code-quality/how-to-generate-code-metrics-data.md)
- [Use the Code Metrics Results window](../code-quality/working-with-code-metrics-data.md)
