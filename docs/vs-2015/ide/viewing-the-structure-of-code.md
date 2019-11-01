---
title: "Viewing the Structure of Code | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
f1_keywords:
  - "vs.documentoutline.window"
  - "vs.objectbrowser"
  - "vs.classview"
  - "VS.CodeDefinitionView"
  - "VS.CodeDefinitionWindow"
  - "vs.componentpicker"
  - "vs.callbrowser"
helpviewer_keywords:
  - "document outline window."
  - "Visual Studio, object browser"
  - "Visual Studio, code definition window"
  - "call hierarchy"
  - "Visual Studio, document outline window"
  - "code definition window"
  - "Visual Studio, class view"
  - "Visual Studio, call hierarchy window"
  - "class view"
  - "object browser"
ms.assetid: e6064f58-5ad9-4f05-8c3f-12e994b6583f
caps.latest.revision: 32
author: jillre
ms.author: jillfra
manager: jillfra
---
# Viewing the Structure of Code
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can examine the objects and members in Visual Studio projects, and the objects and members in .NET Framework components, COM components, dynamic-link libraries (DLL), and type libraries (TLB).

 The following sections of this document describe the different code structure windows.

 [Class View (Visual Basic, C#, C++)](#BKMK_ClassView)

 [Call Hierarchy (Visual Basic, C#, C++)](#BKMK_CallHierarchy)

 [Object Browser](#BKMK_ObjectBrowser)

 [Code Definition Window (C#, C++)](#BKMK_CodeDefinition)

 You can also use **Solution Explorer** to browse the types and members in your projects, search for symbols, view a method’s Call Hierarchy, find symbol references, and more without having to switch between the multiple tool windows listed previously.

 If you have Visual Studio Enterprise you can use code maps to visualize the structure of your code and its dependencies across the entire solution, and drill down to parts of the code that interest you. For more information, see [Map dependencies across your solutions](../modeling/map-dependencies-across-your-solutions.md).

> [!NOTE]
> The Visual Studio edition and the settings you are using may affect the features in the IDE. They might differ from those described in this topic.

## <a name="BKMK_ClassView"></a> Class View (Visual Basic, C#, C++)
 **Class View** is shown as part of **Solution Explorer** as well as in a separate window. The **Class View** window displays the elements of an application. The upper pane displays namespaces, types, interfaces, enumerations, and classes, and the lower pane displays the members that belong to the type selected in the upper pane. By using this window, you can move to member definitions in the source code (or in the **Object Browser** if the element is defined outside your solution).

 You do not have to compile a project to view its elements in **Class View**. The window is refreshed as you modify the code in your project.

 You can add code to your project by selecting the project node and choosing the **Add** button to open the **Add New Item** dialog box. The code is added in a separate file.

 If your project is checked in to source code control, every **Class View** element displays an icon that indicates the source code status of the file. Common source code control commands such as **Check Out**, **Check In**, and **Get Latest Version** are also available on the shortcut menu for the element.

### Class View Toolbar
 The Class View toolbar contains the following commands.

|||
|-|-|
|**New Folder**|Creates a virtual folder or subfolder in which you can organize frequently-used elements. They are saved in the active solution (.suo) file. After you rename or delete an element in your code, it might appear in a virtual folder as an error node. To correct this problem, delete the error node. If you renamed an element, you can move it from the project hierarchy into the folder again.|
|**Back**|Navigates to the previously selected item.|
|**Forward**|Navigates to the next selected item.|
|**View Class Diagram** (managed code projects only)|Becomes available when you select a namespace or type in **Class View**. When a namespace is selected, the class diagram shows all the types in it. When a type is selected, the class diagram shows only that type.|

### Class View Settings
 The **Class View Settings** button on the toolbar has the following settings.

|||
|-|-|
|**Show Base Types**|Base types are displayed.|
|**Show Derived Types**|Derived types are displayed.|
|**Show Hidden Types and Members**|Hidden types and members (not intended for use by clients) are displayed in light gray text.|
|**Show Public Members**|Public members are displayed.|
|**Show Protected Members**|Protected members are displayed.|
|**Show Private Members**|Private members are displayed.|
|**Show Other Members**|Other kinds of members are displayed, including internal (or Friend in Visual Basic) members.|
|**Show Inherited Members**|Inherited members are displayed.|
|**Show Extension Methods**|Extension methods are displayed.|

### Class View Shortcut Menu
 The shortcut menu in **Class View** may contain the following commands, depending on the kind of project selected.

|||
|-|-|
|**Go To Definition**|Finds the definition of the element in the source code, or in the **Object Browser**, if the element is not defined in the open project.|
|**Browse Definition**|Displays the selected item in the **Object Browser**.|
|**Find All References**|Finds the currently selected object item and displays the results in a **Find Results** window.|
|**Filter To Type** (managed code only)|Displays only the selected type or namespace. You can remove the filter by choosing the **Clear Find** (X) button next to the **Find** box.|
|**Copy**|Copies the fully qualified name of the item.|
|**Sort Alphabetically**|Lists types and members alphabetically by name.|
|**Sort by Member Type**|Lists types and members in order by type (such that classes precede interfaces, interfaces precede delegates, and methods precede properties).|
|**Sort by Member Access**|Lists types and members in order by access type, such as public or private.|
|**Group by Member Type**|Sorts types and members into groups by object type.|
|**Go To Declaration** (C++ code only)|Displays the declaration of the type or member in the source code, if available.|
|**Go To Definition**|Displays the definition of the type or member in the source code, if available.|
|**Go To Reference**|Displays a reference to the type or member in the source code, if available.|
|**View Call Hierarchy**|Displays the selected method in the **Call Hierarchy** window.|

## <a name="BKMK_CallHierarchy"></a> Call Hierarchy (Visual Basic, C#, C++)
 The **Call Hierarchy** window shows where a given method (or property or constructor) is called, and lists the methods that are called from that method. You can view multiple levels of the call graph, which shows the caller/callee relationships among the methods in a specified scope.

 You can display the **Call Hierarchy** window by selecting a method (or property or constructor) and then choosing **View Class Hierarchy** on the shortcut menu. The display should resemble the following picture.

 ![Call Hierarchy Multiple Nodes Open](../ide/media/multiplenodes.png "MultipleNodes")
Call Hierarchy window

 By using the drop-down list on the toolbar, you can specify the scope of the hierarchy: the solution, the current project, or the current document.

 The main pane displays the calls to and from the method, and the **Call Sites** pane displays the location of the selected call. For members that are virtual or abstract, an **Overrides method name** node appears. For interface members, an **Implements method name** node appears.

 The **Call Hierarchy** window does not find method group references, which include places where a method is added as an event handler or is assigned to a delegate. To find these references, use the **Find All References** command.

 The shortcut menu in the **Call Hierarchy** window contains the following commands.

|||
|-|-|
|**Add as New Root**|Adds the selected node as a new root node.|
|**Remove Root**|Removes the selected root node from the tree view pane.|
|**Go to Definition**|Navigates to the original definition of a method.|
|**Find All References**|Finds in the project all the references to the selected method.|
|**Copy**|Copies the selected node (but not its sub-nodes).|
|**Refresh**|Refreshes the information.|

## <a name="BKMK_ObjectBrowser"></a> Object Browser
 The **Object Browser** displays descriptions of the code in your projects.

 You can filter what you want to view in the **Object Browser**. By using the drop-down list at the top of the window, you can choose among the following options:

- Any .NET Framework

- Silverlight

- The active solution

- A custom set of components

  Custom components can include managed code executables, library assemblies, type libraries, and .ocx files. It is not possible to add C++ custom components. Custom settings are saved in the Visual Studio user application directory, %APPDATA%\Roaming\Microsoft\VisualStudio\11.0\ObjBrowEX.dat.

  The left pane of the **Object Browser** shows physical containers such as .NET Framework and COM components. You can expand the container nodes to display the namespaces they contain, and then expand the namespaces to display the types they contain. When you select a type, its members (such as properties and methods) are listed in the right pane. The lower right pane displays detailed information about the selected item.

  You can search for a specific item by using the **Search** box at the top of the window. Searches are case-insensitive. Search results are displayed in the left pane. To clear a search, choose the **Clear Search** (X) button next to the **Search** box.

  The **Object Browser** keeps track of the selections you have made, and you can navigate among your selections by using the **Forward** and **Back** buttons on the toolbar.

  You can use the **Object Browser** to add an assembly reference to an open solution by selecting an item (assembly, namespace, type, or member) and choosing the **Add Reference** button on the toolbar.

### Object Browser Settings
 By using the **Object Browser Settings** button on the toolbar, you can specify one of the following views.

|||
|-|-|
|**View Namespaces**|Displays namespaces rather than physical containers, in the left pane. Namespaces stored in multiple physical containers are merged.|
|**View Containers**|Displays physical containers rather than namespaces, in the left pane. **View Namespaces** and **View Containers** are mutually exclusive settings.|
|**Show Base Types**|Displays base types.|
|**Show Derived Types**|Displays derived types.|
|**Show Hidden Types and Members**|Displays hidden types and members (not intended for use by clients), in light gray text.|
|**Show Public Members**|Displays public members.|
|**Show Protected Members**|Displays protected members.|
|**Show Private Members**|Displays private members.|
|**Show Other Members**|Displays other types of members, including internal (or Friend in Visual Basic) members.|
|**Show Inherited Members**|Displays inherited members.|
|**Show Extension Methods**|Displays extension methods.|

### Object Browser Shortcut Menu Commands
 The shortcut menu in the **Object Browser** may contain the following commands, depending on the kind of item selected.

|||
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

## <a name="BKMK_CodeDefinition"></a> Code Definition Window (C#, C++)
 The **Code Definition** window displays the definition of a selected type or member in the active project. The type or member can be selected in the code editor or in a code view window.

 Although this window is read-only, you can set breakpoints or bookmarks in it. To modify the displayed definition, choose **Edit Definition** on the shortcut menu. This opens the source file in the code editor and moves the insertion point to the line where the definition begins.

### Code Definition Shortcut Menu
 The shortcut menu in the **Code Definition** window may contain the following commands, depending on the programming language.

|||
|-|-|
|**Create Unit Tests**|Creates unit tests for the selected element.|
|**Generate Sequence Diagram**|When a method is selected, generates a sequence diagram.|
|**Create Private Accessor**|If a unit test is present in the solution, generates a method that the test uses to access the code.|
|**Go To Definition**|Finds the definition (or definitions, for partial classes) and displays them in a **Find Results** window.|
|**Find All References**|Finds the references to the type or member in the solution.|
|**View Call Hierarchy**|Displays the method in the **Call Hierarchy** window.|
|**Show Calling Tests**|If there are unit tests in the project, shows the tests that call the selected code.|
|**Run Calling Tests**|If there are unit tests in the project, runs the tests for the selected code.|
|**Breakpoint**|Inserts a breakpoint (or a tracepoint).|
|**Run to Cursor**|Runs the program in debug mode to the location of the cursor.|
|**Copy**|Copies the selected line.|
|**Outlining**|Standard outlining commands.|
|**Edit Definition**|Moves the insertion point to the definition in the code window.|
|**Choose Encoding**|Opens the **Encoding** window so that you can set an encoding for the file.|

### Document Outline Window
 You can use the **Document Outline** window in conjunction with designer views, such as the designer for a XAML page or a Windows Form designer, or with HTML pages. This window displays the elements in a tree view so that you can view the logical structure of the form or page and find controls that are deeply embedded or hidden.

## See Also
 [Class View and Object Browser Icons](../ide/class-view-and-object-browser-icons.md)
