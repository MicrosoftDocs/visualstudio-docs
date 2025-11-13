---
title: Visual Studio SDK Glossary
description: This glossary provides definitions for terms that are used in the Visual Studio SDK documentation.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- glossary [Visual Studio SDK]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Visual Studio SDK glossary

This glossary provides definitions for terms that are used in the Visual Studio SDK documentation.

## Terms

**add-in**  
A utility application, driver, or other software added to a primary application. In the Visual Studio integrated development environment (IDE), an add-in is an Automation-based application that extends the capabilities of the IDE.

**automation model**  
The automation model, known in previous versions of Visual Studio as the extensibility model, is a programming interface that gives you access to the underlying routines that drive the IDE. Add-ins, wizards, and macros use objects in the automation model to control or extend the functionality of the IDE.

**command UI context**  
Association of a GUID with the visibility of a UI command or element such as a toolbar. Command UI context is unlike selection context in that it isn't attached to a window.

Command UI context can be used to:
- Assign a GUID to a toolbar that appears when a particular window is activated.
- Assign a GUID to the availability of a command without having to load or run a VSPackage.
- Assign a GUID to affect active key binding.
- Assign a GUID to turn on macro recording.
- Assign a GUID to activate debug mode or to toggle between design and run mode in an editor.

**component**  
Piece of software that can be made part of an application's functionality without that application having any pre-existing information about the software's implementation. Communication between a component and an application is solely through OLE style interfaces.

**component manager**  
A service, `SOleComponentManager`, which provides non-user interface coordination services for top-level components. The `SOleComponentManager` service implements the `IOleComponentManager` interface.

**component UI manager**  
A service, `SOleComponentUIManager`, which provides user interface coordination services. The `SOleComponentUIManager` service implements the `IOleComponentUIManager` and `IOleInPlaceComponentUIManager` interfaces.

**context bag**  
An `IVsUserContext` object (COM object) attached to an environment component. This object holds lookup keywords, **F1** keywords, and attributes that relate to the component. Context bags additionally point to any subcontext bags that are linked to them.

**context provider**  
A component in the IDE that has a context bag associated with it. Such components include a tool window, editor, or project hierarchy.

**designer**  
A programming interface that allows users to manipulate elements of the UI (forms, buttons, and other controls).

**DocData**  
A COM object encapsulating the underlying data of a document in a world where there is document/view separation (for example, in the text editor case, this would be the text buffer underlying all text editor views). If the EditorFactory doesn't supply this object, the IDE manufactures one on its behalf. The responsibility of this object is to manage data persistence and the sharing semantics for multiple views over this same `DocData`. If the `DocData` object supports the `IOleCommandTarget` interface, it's included in the command routing of the UIShell.

**DocObject**  
Technology used to host the UI within a frame provided by the host. More specifically, this term refers to any embedding that supports the `IOleDocument` and related interfaces. This technology has many potential applications such as an implementation detail of COM documents, tool windows in Visual Basic 5.0, ActiveX designers in Visual Basic 6.0, and so on.

**document**  
Used to refer generically to the document as a whole—both the `DocData` and the `DocView`. For example, a DocumentFrame contains a `DocView`, but it also retains a reference to the `DocData` to handle persistence.

**DocView**  
The DocObject/Embedding/WindowPane with which the user interacts to view and manipulate the underlying `DocData`. Users don't take advantage of the Document/View separation that is part of the `DocObject` interface design. Users use an entire DocObject to act as a view instead of using a more abstract (and less formalized) notion of underlying data known as `DocData`. `DocView` objects are always embedded with Document frame objects (MDI child windows) of the IDE.

**DTE**  
The `DTE` (Development Tools Extensibility) object is the top-most access point in the Visual Studio automation model, which allows you to programmatically automate and extend the IDE.

**Dynamic Help window**  
Tool window that is implemented by the IDE and displays a list of lookup keyword or **F1** Help topics.

**editor**  
Code (class, CLSID) that implements the `DocView`. It also implements `DocData` if the view and data separation is supported.

**extension**  
A feature that modifies, customizes, or adds to an IDE. You create extensions using the automation model or VSPackages.

**external editor**  
An editor that isn't specific to the IDE, such as Microsoft Word. It has been registered through its own mechanisms and can be used outside the IDE. If this editor can be embedded, it appears within a window in the IDE. If it can't be embedded, a separate top-level window is created.

**hierarchy**  
Tree of nodes, each node associated with a set of properties.

**independent top-level component**  
A component that uses a modeless top-level window and can operate effectively as a stand-alone application window, but is implemented as an in-process object. Therefore, an independent top-level component must coordinate modality and message loop services with the IDE. In-process objects don't have their own message loop.

**information provider**  
The information provider is a module that can look up keywords and return a list of topics, in the form of `IVsUserContextItem` objects. To provide **F1** and lookup keyword items for the information provider, register your compiled Help file (*.HxS*) with the system. The Help topics in these files provide the list of topics displayed in the Dynamic Help window and shown whether a user presses **F1**.

**in-place component**  
A VSPackage object that implements the `IOleInPlaceComponent` interface to manage a window that is visually contained within a document window owned by the IDE. In-place components don't participate in standard OLE menu-merging; instead they integrate their user interface elements into the IDE.

There are two types of in-place components: hardwired in-place components and component controls.

Hardwired in-place components have menus, toolbars, and commands that are integrated tightly into the user interface of the IDE, appearing as if they were built directly into the IDE.

Component controls don't have any of their own user interface elements integrated into the IDE; instead they use the IDE's menus, commands, and toolbars. For example, the Bold command could be used to bold a selected word within a rich text control embedded in a form. However, component controls can request that dynamically installed component-specific UI elements be displayed.

**language service**  
A set of objects that allows VSPackage developers to implement features of computer language code editors, such as text marking and colorizing.

**Miscellaneous Files project**  
Project used to house open files that aren't in any project. The list of items in this project isn't persisted.

**project**  
Projects are made up of hierarchy objects, or COM objects that implement the `IVsHierarchy` interface.

**project-specific designer or editor**  
A designer that can't be used independently of project type. All project-specific designers must enter their Editor Factory information in the registry. The IDE then can instantiate the designer whenever a certain file type is opened in a particular project.

**project-type window**  
A window that constantly tracks the currently active project hierarchy and item from the global selection context. Project-type windows use the `SVsTrackSelectionEx` service to alert the IDE of changes and to display feedback to the user. Solution Explorer is an example of a project-type window.

**Properties window**  
Formerly Property Browser.

**reference-based projects**  
Project that doesn't require the files for the project to be in the same directory. Instead, references to files from other unrelated directories are stored and maintained by the project itself.

**running document table**  
Internal structure by which the IDE maintains the list of all currently open documents. The list includes all open documents in memory regardless of whether the documents are currently being edited. A document is any item that is saved, including stored procedures opened in an editor, files in a project or the main project file (for example, *.vcproj file).

**selection context**  
Data that is part of the detail of every window in the IDE and is used to track active selections. Selection context consists of:

- Pointer to the `IVsHierarchy` interface of the project hierarchy
- Item identifier of the project item.
- Pointer to the `ISelectionContainer` interface providing access to properties for the active objects.
- Array of element values.

**service**  
A contract for a set of COM interfaces that resides in a single COM object. When you create a service, which is identified by a GUID, you define the set of COM interfaces that carries out the service. COM objects use services to communicate with one another.

**solution**  
Group of related projects with which a user works.

**standard designer**  
A designer that can be used independent of project type. All standard designers must enter their Editor Factory information in the registry. The IDE then can instantiate the designer whenever a file with a specific extension is opened. The data must persist to a file.

**standard editor**  
Editor that can be used independent of any particular project type. Such editors have EditorFactories registered in the registry. This allows the IDE to locate and invoke the editor.

**standard OS editor**  
An embedding that isn't Visual Studio-specific. It is registered using the well-known Win32 keys (for example, the Win32 Explorer knows how to invoke). If such an editor can be embedded, the editor still shows up in its place in the IDE. Otherwise, a separate top-level window is created for such editors.

**subcontext bag**  
An `IVsUserContext` object linked to a context bag. The object holds lookup keywords, **F1** keywords, and attributes for a selection within an IDE component. Examples of subcontext include a command in a tool window, or a keyword in an editor.

**Task list**  
Tool window that is implemented by the IDE and displays a list of active tasks.

**text buffer**  
Common name for the object `VSTextBuffer`.

**Text view**  
Common name for the object `VSTextView`.

**tool top-level component**  
A component that operates as a modeless popup window, coordinating tightly with the user interface of the IDE. Like independent top-level components, tool top-level components must also coordinate modality and message loop services with the IDE.

**top-level component**  
A VSPackage object that manages a modeless top-level window instead of the client area of an IDE window. Top-level components implement the `IOleComponent` interface to take advantage of message loop services such as access to idle time.

**UI active**  
A VSPackage object that is visible and currently has focus.

**UI hierarchy**  
A COM object that implements the `IVsUIHierarchy` interface to allow the display of a hierarchy. The UI hierarchy window implements the `ISelectionContainer` interface to update the Properties window; other project-type windows can use this implementation, if desired.

**VSCT**  
Visual Studio Command Table. The .vsct file contains information about the placement and behaviors of menus, toolbars, and commands in XML format.

**VSPackage**  
An installable piece of software that extends the Visual Studio IDE by contributing one or more of the following items: user interface, services, project types, or editor/designer. A VSPackage consists of a COM object that implements the `IVsPackage` interface and one or more other COM objects that implement other interfaces to support selection and other features. In addition, a VSPackage has specific registration requirements.
