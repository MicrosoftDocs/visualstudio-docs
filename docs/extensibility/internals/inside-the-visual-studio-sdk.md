---
title: Inside the Visual Studio SDK
description: Learn about the extensions in the Visual Studio SDK, including Visual Studio architecture, components, services, schemas, and utilities. 
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- roadmap, Visual Studio integration SDK
- Visual Studio integration SDK roadmap
- integration roadmap, Visual Studio SDK
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Inside the Visual Studio SDK

This section provides in-depth information about Visual Studio extensions, including Visual Studio architecture, components, services, schemas, utilities, and the like.

## Extensibility Architecture
 The following illustration shows the Visual Studio extensibility architecture. VSPackages provide application functionality, which is shared across the IDE as services. The standard IDE also offers a broad range of services, such as <xref:Microsoft.VisualStudio.Shell.Interop.SVsUIShell>, which provide access to the IDE windowing functionality.

![Environment Architecture graphic](../../extensibility/internals/media/environment.gif "environment")
 
Generalized view of the Visual Studio architecture

## VSPackages
 VSPackages are software modules that make up and extend Visual Studio with UI elements, services, projects, editors, and designers. VSPackages are the central architectural unit of Visual Studio. For more information, see [VSPackages](../../extensibility/internals/vspackages.md).

## Visual Studio Shell
 The Visual Studio shell provides basic functionality and support cross-communication among its component VSPackages and MEF extensions. For more information, see [Visual Studio Shell](../../extensibility/internals/visual-studio-shell.md).

## User Experience Guidelines
 If you are planning to design new features for Visual Studio, you should take a look at these guidelines for design and usability tips: [Visual Studio User Experience Guidelines](../../extensibility/ux-guidelines/visual-studio-user-experience-guidelines.md).

## Commands
 Commands are functions that accomplish tasks, such as printing a document, refreshing a view, or creating a new file.

 When you extend Visual Studio, you can create commands and register them with the Visual Studio shell. You can specify how these commands will appear in the IDE, for example, on a menu or toolbar. Typically a custom command appears on the **Tools** menu, and a command for displaying a tool window would appear on the **Other Windows** submenu of the **View** menu.

 When you create a command, you must also create an event handler for it. The event handler determines when the command is visible or enabled, lets you modify its text, and guarantees that the command responds appropriately when it is activated. In most instances, the IDE handles commands by using the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface. Commands in Visual Studio are handled starting with the innermost command context, based on the local selection, and proceeding to the outermost context, based on the global selection. Commands added to the main menu are immediately available for scripting.

 For more information, see [Commands, Menus, and Toolbars](../../extensibility/internals/commands-menus-and-toolbars.md).

## Menus and Toolbars
 Menus and toolbars provide a way for users to invoke commands. Menus are rows or columns of commands that typically are displayed as individual text items at the top a tool window. Submenus are secondary menus that appear when a user clicks commands that include a small arrow. Context menus appear when a user right-clicks certain UI elements. Some common menu names are **File**, **Edit**, **View**, and **Window**. For more information, see [Extending Menus and Commands](../../extensibility/extending-menus-and-commands.md).

 Toolbars are rows or columns of buttons and other controls, such as combo boxes, list boxes, and text boxes. Toolbar buttons typically have icon images, such as a folder icon for an **Open File** command or a printer for a **Print** command. All toolbar elements are associated with commands. When you click a toolbar button, its associated command runs. In the case of a drop-down control, each item in the drop-down list is associated with a different command. Some toolbar controls, such as a splitter control, are hybrids. One side of the control is a toolbar button and the other side is a down arrow that displays several commands when it is clicked.

## Tool Windows
 Tool windows are used in the IDE to display information. **Toolbox**, **Solution Explorer**, **Properties** window, and **Web Browser** are examples of tool windows.

 Tool windows typically offer various controls with which the user can interact. For instance, the **Properties** window lets the user set properties of objects that serve a particular purpose. The **Properties** window is specialized in this sense, but also general because it can be used in many different situations. Similarly, the **Output** window is specialized because it provides text-based output, but general because many subsystems in Visual Studio can use it to provide output to the Visual Studio user.

 Consider the following picture of Visual Studio, which contains several tool windows:

 ![Screen shot](../../extensibility/internals/media/t1gui.png "T1gui")

 Some of the tool windows are docked together on a single pane that displays the Solution Explorer tool window and hides the other tool windows but makes them available by clicking tabs. The picture shows two other tool windows, the **Error List** and **Output** window, docked together on a single pane.

 Also shown is the main document pane, which shows several editor windows. Although tool windows typically have just one instance (for example, you can open only one **Solution Explorer**), editor windows can have multiple instances, each of which is used to edit a separate document but all of which are docked in the same pane. The picture shows a document pane that has two editor windows, one form designer window. All the windows in the document pane are available by clicking tabs, but the editor window that contains EditorPane.cs file is visible and active.

 When you extend Visual Studio, you can create tool windows that let Visual Studio users interact with your extension. You can also create your own editors that let Visual Studio users edit documents. Because your tool windows and editors will be integrated into Visual Studio, you do not have to program them to dock or appear on a tab correctly. When they are correctly registered in Visual Studio, they will automatically have the typical features of tool windows and document windows in Visual Studio. For more information, see [Extending and Customizing Tool Windows](../../extensibility/extending-and-customizing-tool-windows.md).

## Document Windows
 A document window is a framed child window of a multiple-document interface (MDI) window. Document windows typically are used to host text editors, form editors (also known as designers), or editing controls, but they can also host other functional types. The **New File** dialog box includes examples of document windows that Visual Studio provides.

 Most editors are specific to a programming language or to a file type, such as HTML pages, framesets, C++ files, or header files. By selecting a template in the **New File** dialog box, a user dynamically creates a document window for the editor for the file type that is associated with the template. A document window is also created when a user opens an existing file.

 Document windows are restricted to the MDI client area. Each document window has a tab on the top, and tab order is linked to other windows that may be open in the MDI area. Right-clicking the tab of a document window displays a shortcut menu that includes options to split the MDI area into multiple horizontal or vertical tab groups. Splitting the MDI area enables multiple files to be viewed at the same time. For more information, see [Document Windows](../../extensibility/internals/document-windows.md).

## Editors
 The Visual Studio editor allows you to customize it and use it for your own type of content by means of the Managed Extensibility Framework (MEF). In many cases you will not need to create a VSPackage to extend the editor, although if you want to include features from the shell (for example, a menu command or a shortcut key), you can combine a MEF extension with a VSPackage.

 You can also create a custom editor, for example if you wish to read and write to a database, or if you wish to use a designer. You can also use an external editor such as Notepad or Microsoft WordPad. For more information, see [Editor and Language Service Extensions](../../extensibility/editor-and-language-service-extensions.md).

## Language Services
 If you want the Visual Studio editor to support new programming keywords or even a new programming language, you create a language service. Each language service may implement certain editor features fully, partially, or not at all. Depending on how it is configured, the language service can provide syntax highlighting, brace matching, IntelliSense support, and other features in the editor.

 At the heart of a language service are a parser and a scanner. A scanner (or lexer) divides a source file into elements that are known as tokens, and a parser establishes the relationships among those tokens. When you create a language service, you must implement the parser and the scanner so that Visual Studio can understand the tokens and grammar of the language. You can create managed or unmanaged language services. For more information, see [Legacy Language Service Extensibility](/previous-versions/visualstudio/visual-studio-2017/extensibility/internals/legacy-language-service-extensibility).

## Projects

In Visual Studio, projects are the containers that developers use to organize and build the source code and other resources. Projects let you organize, build, debug, and deploy source code, references to Web services and databases, and other resources. VSPackages can extend the Visual Studio project system by providing project types, project subtypes, and custom tools.

Projects may also be gathered together in a *solution*, which is a grouping of one or more projects that work together to create an application. Project and status information that pertains to the solution is stored in two solution files, the text-based [solution (.sln) file](solution-dot-sln-file.md) and the binary [solution user option (.suo) file](solution-user-options-dot-suo-file.md). These files are similar to the group (.vbg) files that were used in earlier versions of Visual Basic, and the workspace (.dsw) and user options (.opt) files that were used in earlier versions of C++.

For more information, see [Projects](../../extensibility/internals/projects.md) and [Solutions](../../extensibility/internals/solutions-overview.md).

## Project and Item Templates
 Visual Studio includes predefined project templates and project item templates. You can also make your own templates or acquire templates from the community, and then integrate them into Visual Studio. The [MSDN Code Gallery](https://code.msdn.microsoft.com/site/search?query=visual%20studio) is the place to go for templates and extensions.

 Templates contain the project structure and basic files that are required to build a particular kind of application, control, library, or class. When you want to develop software that resembles one of the templates, create a project that is based on the template and then modify the files in that project.

> [!NOTE]
> This template architecture is not supported for Visual C++ projects.

 For more information, see [Adding Project and Project Item Templates](../../extensibility/internals/adding-project-and-project-item-templates.md).

## Properties and Options
 The **Properties** window displays the properties of single or multiple selected items: [Extending Properties](../../extensibility/internals/extending-properties.md) Options pages contain sets of options that pertain to a particular component, such as a programming language or a VSPackage: [Options and Options Pages](../../extensibility/internals/options-and-options-pages.md). Settings are generally UI-related features that can be imported and exported: [Support for User Settings](../../extensibility/internals/support-for-user-settings.md).

## Visual Studio Services
 A service provides a specific set of interfaces for components to consume. Visual Studio provides a set of services that can be used by any components, including extensions. For example, Visual Studio services enable tool windows to be shown or hidden dynamically, enable access to Help, status bar, or UI events. The Visual Studio editor also provides services that can be imported by editor extensions. For more information, see [Using and Providing Services](../../extensibility/using-and-providing-services.md).

## Debugger
 The debugger is the user interface to the language-specific debugging components. If you have created a new language service, you will need to create a specific debug engine to hook in to the debugger. For more information, see [Visual Studio Debugger Extensibility](../../extensibility/debugger/visual-studio-debugger-extensibility.md).

## Source Control
 For information about implementing a source control plug-in or VSPackage, see [Source Control](../../extensibility/internals/source-control.md).

## Wizards
 You can create a wizard in conjunction with a new project type, so that the wizard can help your users make the right decisions when they create a new project of that type. For more information, see [Wizards](../../extensibility/internals/wizards.md).

## Custom Tools
 Custom tools let you associate a tool with an item in a project and run that tool whenever the file is saved. For more information, see [Custom Tools](../../extensibility/internals/custom-tools.md).

## VSSDK Utilities
 The VSSDK includes a set of utilities that you may need in order to work with different aspects of VSPackages. For more information, see [VSSDK Utilities](../../extensibility/internals/vssdk-utilities.md).

## Using Windows Installer
 In some cases you may need to use the Windows Installer rather than the VSIX installer: for example, you may need to write to the registry. For information about using Windows Installer with your extensions, see [Installing VSPackages With Windows Installer](../../extensibility/internals/installing-vspackages-with-windows-installer.md).

## Help Viewer
 You can integrate your own help and F1 pages into the Help Viewer. For more information, see [Microsoft Help Viewer SDK](/previous-versions/visualstudio/visual-studio-2017/extensibility/internals/microsoft-help-viewer-sdk).
