---
title: C# IntelliSense
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
  - "C#, IntelliSense"
  - "IntelliSense [C#]"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "dotnet"
---
# C# IntelliSense

C# IntelliSense is available when coding in the editor, and while debugging in the [Immediate mode](../ide/reference/immediate-window.md) command window.

## Completion lists

The IntelliSense completion lists in C# contain tokens from List Members, Complete Word, and more. It provides quick access to:

- Members of a type or namespace

- Variables, commands, and functions names

- Code snippets

- Language keywords

- Extension methods

The completion list in C# is also smart enough to filter out irrelevant tokens and pre-select a token based on context. For more information, see [Filtered completion lists](#filtered-completion-lists).

### Code snippets in completion lists

In C#, the completion list includes code snippets to help you easily insert predefined bodies of code into your program. Code snippets appear in the completion list as the snippet's [shortcut text](../ide/code-snippets-schema-reference.md#shortcut-element). For more information about code snippets that are available in C# by default, see [C# code snippets](../ide/visual-csharp-code-snippets.md).

### Language keywords in completion lists

In C#, the completion list also includes language keywords. For more information about C# language keywords, see [C# keywords](/dotnet/csharp/language-reference/keywords/index).

### Extension methods in completion lists

In C#, the completion list includes extension methods that are in scope.

> [!NOTE]
> The completion list does not display all extension methods for <xref:System.String> objects.

Extension methods use a different icon than instance methods. For a list icon reference guide, see [Class View and Object Browser icons](../ide/class-view-and-object-browser-icons.md). When an instance method and extension method with the same name are both in scope, the completion list displays the extension method icon.

### Filtered completion lists

IntelliSense removes unnecessary members from the completion list by using filters. C# filters the completion lists that appear for these items:

- **Interfaces and base classes**: IntelliSense automatically removes items from the interface and base class completion lists, in both class declaration base and interface lists and constraint lists. For example, enums do not appear in the completion list for base classes, because enums cannot be used for base classes. The completion list of base classes only contains interfaces and namespaces. If you select an item in the list and then type a comma, IntelliSense removes base classes from the completion list because C# does not support multiple inheritance. The same behavior occurs for constraint clauses also.

- **Attributes**: When you apply an attribute to a type, the completion list is filtered so that the list only contains those types that descend from the namespaces that contain those types, such as <xref:System.Attribute>.

- **Catch clauses**

- **Object initializers**: Only members that can be initialized will appear in the completion list.

- **new keyword**: When you type `new` and then press the **Space**, a completion list appears. An item is automatically selected in the list, based on the context in your code. For example, items are automatically selected in the completion list for declarations and for return statements in methods.

- **enum keyword**: When you press the **Space** after an equal sign for an enum assignment, a completion list appears. An item is automatically selected in the list, based on the context in your code. For example, items are automatically selected in the completion list after you type the keyword return and when you make a declaration.

- **as and is operators**: A filtered completion list is displayed automatically when you press the **Space** after you have typed the `as` or `is` keyword.

- **Events**: When you type the keyword `event`, the completion list only contains delegate types.

- **Parameter help** automatically sorts to the first method overload that matches the parameters as you enter them. If multiple method overloads are available, you can use the up and down arrows to navigate to the next possible overload in the list.

### Most recently used members

IntelliSense remembers the members that you have recently selected in the pop-up [List Members](../ide/using-intellisense.md) box for automatic object name completion. The next time you use **Member List**, the most recently used members are shown at the top. The history of most recently used members is cleared between each Visual Studio session.

### override

When you type [override](/dotnet/csharp/language-reference/keywords/override) and then press **Space**, IntelliSense displays all of the valid base class members that you can override in a pop-up list box. Typing the return type of the method after `override` prompts IntelliSense to only show methods that return the same type. When IntelliSense cannot find any matches, it displays all of the base class members.

### AI-enhanced IntelliSense

[Visual Studio IntelliCode](/visualstudio/intellicode/intellicode-visual-studio) provides artificial intelligence-enhanced IntelliSense completion lists. IntelliCode predicts the most likely correct API to use rather than just presenting an alphabetical list of members. It uses your current code context and patterns to provide the dynamic list.

## Automatic code generation

### Add using

The **Add using** IntelliSense operation automatically adds the required `using` directive to your code file. This feature enables you to maintain your focus on the code you are writing rather than requiring you to shift your focus to another part of the code.

To initiate the **Add using** operation, position the cursor on a type reference that cannot be resolved. For example, when you create a console application and then add `XmlReader` to the body of the `Main` method, a red squiggle appears on that line of code because the type reference cannot be resolved. You can then invoke the **Add using** through the **Quick Actions**. The **Quick Actions** are only visible when the cursor is positioned on the unbound type.

![Add using, quick action expanded image](../ide/media/addusing-quickaction.png)

Click the error light bulb icon, and then choose **using System.Xml;** to automatically add the using directive.

### Remove and sort usings

The **Remove and Sort Usings** option sorts and removes `using` and `extern` declarations without changing the behavior of the source code. Over time, source files may become bloated and difficult to read because of unnecessary and unorganized `using` directives. The **Remove and Sort Usings** option compacts source code by removing unused `using` directives, and improves readability by sorting them. On the **Edit** menu, choose **IntelliSense**, and then choose **Organize Usings**.

### Implement interface

IntelliSense provides an option to help you implement an [interface](/dotnet/csharp/language-reference/keywords/interface) while working in the code editor. Normally, to implement an interface properly, you must create a method declaration for every member of the interface in your class. Using IntelliSense, after you type the name of an interface in a class declaration, a **Quick Actions** light bulb is displayed. The light bulb gives you the option to implement the interface automatically, using explicit or implicit naming. Under explicit naming, the method declarations carry the name of the interface. Under implicit naming, the method declarations do not indicate the interface to which they belong. An explicitly named interface method can only be accessed through an interface instance, and not through a class instance. For more information, see [Explicit interface implementation](/dotnet/csharp/programming-guide/interfaces/explicit-interface-implementation).

Implement Interface generates the minimum number of method stubs that's required to satisfy the interface. If a base class implements parts of the interface, then those stubs aren't regenerated.

### Implement abstract base class

IntelliSense provides an option to help you implement members of an abstract base class automatically while working in the code editor. Normally, to implement members of an abstract base class requires creating a new method definition for each method of the abstract base class in your derived class. Using IntelliSense, after typing the name of an abstract base class in a class declaration, a **Quick Actions** light bulb is displayed. The light bulb gives you the option to implement the base class methods automatically.

The method stubs that are generated by the **Implement Abstract Base Class** feature are modeled by the code snippet defined in the file *MethodStub.snippet*. Code snippets are modifiable. For more information, see [Walkthrough: Create a code snippet](../ide/walkthrough-creating-a-code-snippet.md).

### Generate from usage

The **Generate From Usage** feature enables you to use classes and members before you define them. You can generate a stub for any class, constructor, method, property, field, or enum that you want to use but have not yet defined. You can generate new types and members without leaving your current location in code. This minimizes interruption to your workflow.

A red wavy underline appears under each undefined identifier. When you rest the mouse pointer on the identifier, an error message appears in a tooltip. To display the appropriate options, you can use one of the following procedures:

- Click the undefined identifier. A **Quick Actions** error light bulb appears under the identifier. Click the error light bulb.

- Click the undefined identifier, and then press **Ctrl**+**.** (**Ctrl** + period).

- Right-click the undefined identifier, and then click **Quick Actions and Refactorings**.

The options that appear can include the following:

- **Generate property**

- **Generate field**

- **Generate method**

- **Generate class**

- **Generate new type** (for a class, struct, interface, or enum)

## Generate event handlers

In the code editor, IntelliSense can help you hook up methods (event handlers) to event fields.

When you type the `+=` operator after an event field in a *.cs* file, IntelliSense prompts you with the option to press the **Tab** key. This inserts a new instance of a delegate that points to the method handling the event.

![Button Auto Hook Up](../ide/media/vxautohookup.gif)

If you press **Tab**, IntelliSense automatically finishes the statement for you and displays the event handler reference as selected text in the code editor. To complete the automatic event hookup, IntelliSense prompts you to press the **Tab** key again to create an empty stub for the event handler.

![Generate Event Handler](../ide/media/vxgenerateeventhandler.gif)

> [!NOTE]
> If a new delegate that is created by IntelliSense references an existing event handler, IntelliSense communicates this information in the tooltip. You can then modify this reference; the text is already selected in the code editor. Otherwise, automatic event hookup is complete at this point.

If you press **Tab**, IntelliSense stubs out a method with the correct signature and puts the cursor in the body of your event handler.

> [!NOTE]
> Use the **Navigate Backward** command on the **View** menu (**Ctrl**+**-**) to go back to the event hookup statement.

## See also

- [Use IntelliSense](../ide/using-intellisense.md)
- [Visual Studio IDE](../get-started/visual-studio-ide.md)