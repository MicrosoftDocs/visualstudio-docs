---
title: Use tools windows to view code structure
description: Learn how to use the Class View, Call Hierarchy, Object Browser, and Code Definition tool windows to examine classes and their members in Visual Studio.
ms.date: 09/19/2019
ms.topic: reference
f1_keywords:
- vs.documentoutline.window
- vs.classview
- VS.CodeDefinitionView
- VS.CodeDefinitionWindow
- vs.componentpicker
- vs.callbrowser
helpviewer_keywords:
- document outline window
- Visual Studio, object browser
- call hierarchy
- Visual Studio, document outline window
- code definition window [Visual Studio]
- Visual Studio, class view
- Visual Studio, call hierarchy window
- class view
- object browser
- icons, in Object Browser
- signal icons
- Class View tool, symbols
- graphic symbols
- IntelliSense, icons
- icons, IntelliSense
- symbols, Object Browser icons
- Object Browser, icons in Class View
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# View the structure of code by using different tool windows

::: moniker range="<=vs-2019"

You can examine classes and their members in Visual Studio using various tool windows, including **Class View**, **Call Hierarchy**, **Object Browser**, and **Code Definition** (C++ only). These tool windows can examine code in Visual Studio projects, .NET components, COM components, dynamic-link libraries (DLL), and type libraries (TLB).

::: moniker-end

::: moniker range=">=vs-2022"

You can examine classes and their members in Visual Studio using various tool windows, including **Class View**, **Call Hierarchy**, **Object Browser**, and **Code Definition**. These tool windows can examine code in Visual Studio projects, .NET components, COM components, dynamic-link libraries (DLL), and type libraries (TLB).

::: moniker-end

You can also use **Solution Explorer** to browse the types and members in your projects, search for symbols, view a method's call hierarchy, find symbol references, and more, without having to switch between multiple tool windows.

If you have Visual Studio Enterprise edition, you can use *code maps* to visualize the structure of your code and its dependencies across the entire solution. For more information, see [Map dependencies with code maps](../modeling/map-dependencies-across-your-solutions.md).

## Class View (Visual Basic, C#, C++)

**Class View** is shown as part of **Solution Explorer** and as a separate window. **Class View** displays the elements of an application. The upper pane displays namespaces, types, interfaces, enumerations, and classes, and the lower pane displays the members that belong to the type selected in the upper pane. By using this window, you can move to member definitions in the source code (or in the **Object Browser** if the element is defined outside your solution).

You do not have to compile a project to view its elements in **Class View**. The window is refreshed as you modify the code in your project.

You can add code to your project by selecting the project node and choosing the **Add** button to open the **Add New Item** dialog box. The code is added in a separate file.

If your project is checked in to source code control, every **Class View** element displays an icon that indicates the source code status of the file. Common source code control commands such as **Check Out**, **Check In**, and **Get Latest Version** are also available on the shortcut menu for the element.

### Class View toolbar

The **Class View** toolbar contains the following commands:

|Name|Description|
|-|-|
|**New Folder**|Creates a virtual folder or subfolder in which you can organize frequently used elements. They are saved in the active solution (*.suo*) file. After you rename or delete an element in your code, it might appear in a virtual folder as an error node. To correct this problem, delete the error node. If you renamed an element, you can move it from the project hierarchy into the folder again.|
|**Back**|Navigates to the previously selected item.|
|**Forward**|Navigates to the next selected item.|
|**View Class Diagram** (managed code projects only)|Becomes available when you select a namespace or type in **Class View**. When a namespace is selected, the class diagram shows all the types in it. When a type is selected, the class diagram shows only that type.|

### Class View settings

The **Class View Settings** button on the toolbar has the following settings:

|Name|Description|
|-|-|
|**Show Base Types**|Base types are displayed.|
|**Show Project References**|Project references are displayed.|
|**Show Hidden Types and Members**|Hidden types and members (not intended for use by clients) are displayed in light gray text.|
|**Show Public Members**|Public members are displayed.|
|**Show Protected Members**|Protected members are displayed.|
|**Show Private Members**|Private members are displayed.|
|**Show Other Members**|Other kinds of members are displayed, including internal (or Friend in Visual Basic) members.|
|**Show Inherited Members**|Inherited members are displayed.|

### Class View shortcut menu

The shortcut (or right-click) menu in **Class View** may contain the following commands, depending on the kind of project selected:

|Name|Description|
|-|-|
|**Go To Definition**|Finds the definition of the element in the source code, or in the **Object Browser**, if the element is not defined in the open project.|
|**Browse Definition**|Displays the selected item in the **Object Browser**.|
|**Find All References**|Finds the currently selected object item and displays the results in a **Find Results** window.|
|**Filter To Type** (managed code only)|Displays only the selected type or namespace. You can remove the filter by choosing the **Clear Find** (**X**) button next to the **Find** box.|
|**Copy**|Copies the fully qualified name of the item.|
|**Sort Alphabetically**|Lists types and members alphabetically by name.|
|**Sort by Member Type**|Lists types and members in order by type (such that classes precede interfaces, interfaces precede delegates, and methods precede properties).|
|**Sort by Member Access**|Lists types and members in order by access type, such as public or private.|
|**Group by Member Type**|Sorts types and members into groups by object type.|
|**Go To Declaration** (C++ code only)|Displays the declaration of the type or member in the source code, if available.|
|**Go To Definition**|Displays the definition of the type or member in the source code, if available.|
|**Go To Reference**|Displays a reference to the type or member in the source code, if available.|
|**View Call Hierarchy**|Displays the selected method in the **Call Hierarchy** window.|

## Call Hierarchy window (Visual Basic, C#, C++)

The **Call Hierarchy** window shows where a given method or property is called. It also lists the methods that are called from that method. You can view multiple levels of the call graph, which shows the caller-callee relationships among the methods in a specified scope.

You can display the **Call Hierarchy** window by selecting a method (or property or constructor) in the editor and then choosing **View Call Hierarchy** on the shortcut menu. The display should resemble the following image:

![Call Hierarchy window in Visual Studio](../ide/media/multiplenodes.png)

By using the drop-down list on the toolbar, you can specify the scope of the hierarchy: the solution, current project, or current document.

The main pane displays the calls to and from the method, and the **Call Sites** pane displays the location of the selected call. For members that are virtual or abstract, an **Overrides method name** node appears. For interface members, an **Implements method name** node appears.

The **Call Hierarchy** window does not find method group references, which include places where a method is added as an event handler or is assigned to a delegate. To find these references, use the **Find All References** command.

The shortcut menu in the **Call Hierarchy** window contains the following commands:

|Name|Description|
|-|-|
|**Add as New Root**|Adds the selected node as a new root node.|
|**Remove Root**|Removes the selected root node from the tree view pane.|
|**Go to Definition**|Navigates to the original definition of a method.|
|**Find All References**|Finds in the project all the references to the selected method.|
|**Copy**|Copies the selected node (but not its subnodes).|
|**Refresh**|Refreshes the information.|

## <a name="BKMK_ObjectBrowser"></a> Object Browser

The **Object Browser** window displays descriptions of the code in your projects.

You can filter the components you want to view by using the drop-down list at the top of the window. Custom components can include managed code executables, library assemblies, type libraries, and *.ocx* files. It is not possible to add C++ custom components.

Custom settings are saved in the Visual Studio user application directory, *%APPDATA%\Microsoft\VisualStudio\16.0\ObjBrowEX.dat*.

The left pane of the **Object Browser** shows assemblies. You can expand the assemblies to display the namespaces they contain, and then expand the namespaces to display the types they contain. When you select a type, its members (such as properties and methods) are listed in the right pane. The lower right pane displays detailed information about the selected item.

You can search for a specific item by using the **Search** box at the top of the window. Searches are case-insensitive. Search results are displayed in the left pane. To clear a search, choose the **Clear Search** (**X**) button next to the **Search** box.

The **Object Browser** keeps track of the selections you have made, and you can navigate among your selections by using the **Forward** and **Back** buttons on the toolbar.

You can use the **Object Browser** to add an assembly reference to an open solution by selecting an item (assembly, namespace, type, or member) and choosing the **Add Reference** button on the toolbar.

### Object Browser settings

By using the **Object Browser Settings** button on the toolbar, you can specify one of the following views:

|Name|Description|
|-|-|
|**View Namespaces**|Displays namespaces rather than physical containers, in the left pane. Namespaces stored in multiple physical containers are merged.|
|**View Containers**|Displays physical containers rather than namespaces, in the left pane. **View Namespaces** and **View Containers** are mutually exclusive settings.|
|**Show Base Types**|Displays base types.|
|**Show Hidden Types and Members**|Displays hidden types and members (not intended for use by clients), in light gray text.|
|**Show Public Members**|Displays public members.|
|**Show Protected Members**|Displays protected members.|
|**Show Private Members**|Displays private members.|
|**Show Other Members**|Displays other types of members, including internal (or Friend in Visual Basic) members.|
|**Show Inherited Members**|Displays inherited members.|
|**Show Extension Methods**|Displays extension methods.|

### Object Browser shortcut menu commands

The shortcut (or right-click) menu in **Object Browser** may contain the following commands, depending on the kind of item selected:

|Name|Description|
|-|-|
|**Browse Definition**|Shows the primary node for the selected item.|
|**Find All References**|Finds the currently selected object item and displays the results in a **Find Results** window.|
|**Filter To Type**|Displays only the selected type or namespace. You can remove the filter by choosing the **Clear Search** button.|
|**Copy**|Copies the fully qualified name of the item.|
|**Remove**|If the scope is a custom component set, removes the selected component from the scope.|
|**Sort Alphabetically**|Lists types and members alphabetically by name.|
|**Sort by Object Type**|Lists types and members in order by type (such that classes precede interfaces, interfaces precede delegates, and methods precede properties).|
|**Sort by Object Access**|Lists types and members in order by access type, such as public or private.|
|**Group by Object Type**|Sorts types and members into groups by object type.|
|**Go To Declaration** (C++ projects only)|Displays the declaration of the type or member in the source code, if available.|
|**Go To Definition**|Displays the definition of the type or member in the source code, if available.|
|**Go To Reference**|Displays a reference to the type or member in the source code, if available.|
|**View Call Hierarchy**|Displays the selected method in the **Call Hierarchy** window.|

::: moniker range="<=vs-2019"

## Code Definition window (C++)

The **Code Definition** window displays the definition of a selected C++ type or member in the active project. The type or member can be selected in the code editor or in a code view window.

Although this window is read-only, you can set breakpoints or bookmarks in it. To modify the displayed definition, choose **Edit Definition** on the shortcut menu. This opens the source file in the code editor and moves the insertion point to the line where the definition begins.

> [!NOTE]
> The **Code Definition** window can only be used with C++ code.

::: moniker-end

::: moniker range=">=vs-2022"

## Code Definition window

The **Code Definition** window displays the definition of a selected C++, C#, or Visual Basic type or member in the active project. The type or member can be selected in the code editor or in a code view window.

Although this window is read-only, you can set breakpoints or bookmarks in it. To modify the displayed definition, choose **Edit Definition** on the shortcut menu. This opens the source file in the code editor and moves the insertion point to the line where the definition begins.

::: moniker-end

### Code Definition shortcut menu

The shortcut (or right-click) menu in the **Code Definition** window may contain the following commands:

|Name|Description|
|-|-|
|**Quick Actions and Refactorings**||
|**Rename**||
|**Generate Graph of Include Files**||
|**Peek Definition**||
|**Go To Definition**|Finds the definition (or definitions, for partial classes) and displays them in a **Find Results** window.|
|**Go To Declaration**||
|**Find All References**|Finds the references to the type or member in the solution.|
|**View Call Hierarchy**|Displays the method in the **Call Hierarchy** window.|
|**Toggle Header / Code File**||
|**Run Tests**|If there are unit tests in the project, runs the tests for the selected code.|
|**Debug Tests**||
|**Breakpoint**|Inserts a breakpoint (or a tracepoint).|
|**Run to Cursor**|Runs the program in debug mode to the location of the cursor.|
|**Snippet**||
|**Cut**, **Copy**, **Paste**||
|**Annotation**||
|**Outlining**|Standard outlining commands.|
|**Rescan**||
|**Edit Definition**|Moves the insertion point to the definition in the code window.|
|**Choose Encoding**|Opens the **Encoding** window so that you can set an encoding for the file.|

## Document Outline window

You can use the **Document Outline** window in conjunction with designer views, such as the designer for a XAML page or a Windows Form designer, or with HTML pages. This window displays the elements in a tree view, so that you can view the logical structure of the form or page and find controls that are deeply embedded or hidden.

## Related links

- [Working with resource files (C++)](/cpp/windows/working-with-resource-files)
- [Resources in .NET apps (.NET Framework)](/dotnet/framework/resources/index)
- [Manage application resources](managing-application-resources-dotnet.md)