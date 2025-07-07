---
title: Application Patterns for Visual Studio
description: Learn about the difference between document windows, tool windows, and modeless dialogs, including window usage patterns for new features for Visual Studio.
ms.date: 04/26/2017
ms.topic: reference
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Application Patterns for Visual Studio

## <a name="BKMK_WindowInteractions"></a> Window interactions

The two main window types used in Visual Studio are document editors and tool windows. Rare, but possible, are large modeless dialogs. Although these are all modeless in the shell, their patterns are fundamentally different. This section covers the difference between document windows, tool windows, and modeless dialogs. Modal dialog patterns are covered in [Dialogs](../../extensibility/ux-guidelines/application-patterns-for-visual-studio.md#BKMK_Dialogs).

### Comparing window usage patterns
**Document windows** are almost always displayed within the document well. This gives the document editor a "center stage" to arrange supplemental tool windows around.

A **tool window** is most often displayed as a separate, smaller window collapsed against the edge of the IDE. This can be visible, hidden, or auto-hidden. However, sometimes tool windows are presented within the document well, by unchecking the **Window/Docking** property on the window. This results in more real estate, but also a common design decision: when attempting to integrate into Visual Studio, you must decide whether your feature should display a tool window or a document window.

**Modeless dialogs** are discouraged in Visual Studio. Most modeless dialogs are, by definition, floating tool windows and should be implemented that way. Modeless dialogs are allowed in cases where the size of a normal tool window docked to the side of the shell would be too limiting. They are also allowed in cases where the user would be likely to move the dialog to a secondary monitor.

Think carefully about which container type you need. Common usage pattern considerations for UI design are in the following table.

||Document window|Tool window|Modeless dialog|
|-|---------------------|-----------------|---------------------|
| **Position** | Always positioned within the document well and does not dock around the edges of the IDE. It can be "pulled off" so that it floats separately from the main shell. | Generally tab-docked around the edges of the IDE, but can be customized to be floating, auto-hidden (unpinned), or docked within the document well.|Large floating window separate from the IDE. |
| **Commit model** | *Delayed commit*<br /><br /> In order to save the data in a document, the user must issue the **File &gt; Save**, **Save As**, or **Save All** command. A document window has the concept of the data within it being "dirtied" then committed to one of the save commands. When closing a document window, all contents are either saved to disk or lost. | *Immediate commit*<br /><br /> There is no save model. For inspector tool windows that assist in editing a file, the file must be open in the active editor or designer, and the editor or designer owns the save. | *Delayed or immediate commit*<br /><br /> Most often, a large modeless dialog requires an action to commit changes and allows for a "Cancel" operation, which rolls back any changes made within the dialog session.  This differentiates a modeless dialog from a tool window in that tool windows always have an immediate commit model. |
| **Visibility** | *Open/Create (file) and Close*<br /><br /> Opening a document windows is done through either opening an existing document or using a template to create a new document. There is no "Open \<specific editor>" command. | *Hide and show*<br /><br /> Single-instance tool windows can be hidden or shown. Contents and states within the tool window persist whether in view or hidden. Multi-instance tool windows can be closed as well as hidden. When a multi-instance tool window is closed, the content and state within the tool window is discarded. | *Launched from a command*<br /><br /> Dialogs are launched from a task-based command. |
| **Instances** | *Multi-instance*<br /><br /> Several editors can be open at the same time and editing different files, while some editors also allow the same file to be open in more than one editor (using the **Window &gt; New Window** command).<br /><br /> A single editor may be editing one or multiple files at the same time (Project Designer). | *Single- or multi-instance*<br /><br /> Contents change to reflect context (as in the Property Browser) or push focus/context to other windows (Task List, Solution Explorer).<br /><br /> Both single-instance and multi-instance tool windows should be associated with the active document window unless there is a compelling reason not to. | *Single-instance* |
| **Examples** | **Text editors**, like the code editor<br /><br /> **Design surfaces**, like a form designer or a modeling surface<br /><br /> **Control layouts similar to dialogs**, like the Manifest Designer | The **Solution Explorer** provides a solution and projects contained within the solution<br /><br /> The **Server Explorer** provides a hierarchical view of servers and data connections that the user chooses to open in the window. Opening an object from the database hierarchy, like a query, opens a document window and allows the user to edit the query.<br /><br /> The **Property Browser** displays properties for the object selected either in a document window or another tool window. The properties are presented either in a hierarchical grid view or in complex dialog-like controls and allow the user to set the values for those properties. | |

## <a name="BKMK_ToolWindows"></a> Tool windows

Tool windows support the user's work that happens in document windows. They can be used to display a hierarchy that represents a fundamental root object that Visual Studio provides and can manipulate.

When considering a new tool window in the IDE, authors should:

- Use task-appropriate existing tool windows and not create new ones with similar functionality. New tool windows should only be created if they offer a significantly different "tool" or functionality that can't be integrated into a similar window, or by turning an existing window into a pivoting hub.

- Use a standard command bar, if needed, at the top of the tool window.

- Be consistent with patterns already present in other tool windows for control presentation and keyboard navigation.

- Be consistent with control presentation in other tool windows.

- Make document-specific tool windows auto-visible when possible, so that they appear only when the parent document is activated.

- Ensure their window content is navigable by the keyboard (support arrow keys).

#### Tool window states
Visual Studio tool windows have different states, some of which are user-activated (like the auto-hide feature). Other states, like auto-visible, allow tool windows to appear in the correct context and hide when not needed. There are five tool window states in total.

- **Docked/pinned** tool windows can be attached to any of the four sides of the document area. The pushpin icon appears in the tool window title bar. The tool window can be docked horizontally or vertically along the edge of the shell and other tool windows, and can also be tab-linked.

- **Auto-hidden** tool windows are unpinned. The window can slide out of sight, leaving a tab (with the name of the tool window and its icon) on the edge of the document area. The tool window slides out when a user hovers over the tab.

- **Auto-visible** tool windows automatically appear when another piece of UI, like an editor, is launched or gains focus.

- **Floating** tool windows hover outside the IDE. This is useful for multi-monitor configurations.

- **Tabbed document** tool windows can be docked within the document well. This is useful for large tool windows, like the Object Browser, that need more real estate than docking to the edges of the frame allows.

![Tool window states in Visual Studio](../../extensibility/ux-guidelines/media/0702-01_toolwindowstates.png "0702-01_ToolWindowStates")<br />Tool window states in Visual Studio

#### Single-instance and multi-instance
Tool windows are either single-instance or multi-instance. Some single-instance tool windows might be associated with the active document window, while multi-instance tool windows might not. Multi-instance tool windows respond to the **Window &gt; New Window** command by creating a new instance of the window. The following image illustrates a tool window enabling the New Window command when an instance of the window is active:

![Tool window enabling 'New Window' command when an instance of the window is active](../../extensibility/ux-guidelines/media/0702-02_toolwindowenablingcommand.png "0702-02_ToolWindowEnablingCommand")<br />Tool window enabling 'New Window' command when an instance of the window is active

Single-instance tool windows can be hidden or shown, while multi-instance tool windows can be closed as well as hidden. All tool windows can be docked, tab-linked, floating, or set as a Multiple-Document Interface (MDI) child window (similar to a document window). All tool windows should respond to the appropriate window management commands in the Window menu:

![Window management commands in the Visual Studio Window menu](../../extensibility/ux-guidelines/media/0702-03_windowmanagementcontrols.png "0702-03_WindowManagementControls")<br />Window management commands in the Visual Studio Window menu

#### Document-specific tool windows
Some tool windows are designed to change based on a given type of document. These windows continually update to reflect functionality applicable to the active document window in the IDE.

Examples of tool windows whose contents change to reflect the selected editor are the Toolbox and the Document Outline. These windows show a watermark when an editor has focus that does not offer context to the window.

#### Navigable list tool windows
Some tool windows display a list of navigable items the user can interact with. In this type of window, there should always be feedback for the current item in the list, even if the window is inactive. The list should respond to the **GoToNextLocation** and **GoToPrevLocation** commands by also changing the currently selected item in the window

Examples of navigable list tool windows are the Solution Explorer and the Find Results window.

### Tool window types

#### Common tool windows and their functions

**Hierarchical tool windows**

| Tool window | Function |
| --- | --- |
| Solution Explorer | A hierarchical tree that displays a list of documents contained in projects, miscellaneous files, and solution items. The display of the items within projects is defined by the package that owns the project type (for example, reference-based, directory-based, or mixed-mode types). |
| Class View | A hierarchical tree of the classes and various elements in the working set of documents, independent of the files themselves. |
| Server Explorer | A hierarchical tree that displays all the servers and data connections in the solution. |
| Document Outline | The hierarchical structure of the active document. |

**Grid tool windows**

| Tool window | Function |
| --- | --- |
| Properties | A grid that displays a list of properties for the selected object, along with value pickers to edit those properties. |
| Task List | A grid that allows the user to create/edit/delete tasks and comments. |

**Content tool windows**

| Tool window | Function |
| --- | --- |
| Help | A window that allows users access to various methods of getting help, from "How Do I?" videos to MSDN forums. |
| Dynamic Help | A tool window that displays links to help topics applicable to the current selection. |
| Object Browser | A two-column frameset with a list of hierarchical object components in the left pane and the object's properties and methods in the right column. |

**Dialog tool windows**

| Tool window | Function |
| --- | --- |
| Find | A dialog that allows the user to find or find and replace in various files within the solution. |
| Advanced Find | A dialog that allows the user to find or find and replace in various files within the solution. |

**Other tool windows**

| Tool window | Function |
| --- | --- |
| Toolbox | The tool window used to store elements that will be dropped onto design surfaces, providing a consistent drag-source for all designers. |

**Debugger tool windows**

| Tool window | Function |
| --- | --- |
| Autos ||
| Immediate ||
| Output | The output window can be used whenever you have textual events or status to declare. |
| Memory ||
| Breakpoints ||
| Running ||
| Documents ||
| Call Stack ||
| Locals ||
| Watches ||
| Disassembly ||
| Registers ||
| Threads ||

## <a name="BKMK_DocumentEditorConventions"></a> Document editor conventions

### Document interactions
The "document well" is the largest space within the IDE and is where the user generally has focused their attention in order to complete their tasks, assisted by supplemental tool windows. Document editors represent the fundamental units of work that the user opens and saves within Visual Studio. They retain a strong sense of selection tied to Solution Explorer or other active hierarchy windows. The user should be able to point to one of those hierarchy windows and know where the document is contained and its relationship to either the solution, the project, or another root object provided by a Visual Studio package.

Document editing requires a consistent user experience. To allow the user to focus on the task at hand instead of on window management and finding commands, select a document view strategy that best fits the user tasks for editing that document type.

#### Common interactions for the document well

- Maintain a consistent interaction model in the common **New File** and **Open File** experiences.

- Update related functionality in related windows and menus when the document window opens.

- Menu commands are appropriately integrated into common menus like **Edit**, **Format**, and **View** menus. If a substantial amount of specialized commands are available, then a new menu can be created. This new menu should be visible only when the document has focus.

- An embedded toolbar may be placed at the top of the editor. This is preferable to having a separate toolbar that appears outside the editor.

- Always maintain a selection in the Solution Explorer or similar active hierarchy window.

- Double-clicking a document in the Solution Explorer should perform the same action as **Open**.

- If more than one editor can be used on a document type, the user should be able to override or reset the default action on a given document type using the **Open With** dialog box by right-clicking on the file and selecting **Open With** from the shortcut menu.

- Don't build a wizard in a document well.

### User expectations for specific document types
There are several different basic types of document editors and each has a set of interactions that are consistent with others of the same type.

- **Text-based editor:** code editor, log files

- **Design surface:** WPF forms designer, Windows forms

- **Dialog-style editor:** Manifest Designer, project properties

- **Model designer:** workflow designer, codemap, architecture diagram, progression

There are also several non-editor types that use the document well. While they don't edit documents themselves, they do need to follow standard interactions for document windows.

- **Reports:** IntelliTrace report, Hyper-V report, profiler report

- **Dashboard:** Diagnostics Hub

#### Text-based editors

- The document participates in the preview tab model, allowing for previewing the document without opening it.

- The structure of the document may be represented within a companion tool window, such as a document outline.

- IntelliSense (if appropriate) will behave consistently with other code editors.

- Pop-ups or assistive UI follow similar styles and patterns for existing similar UI, such as CodeLens.

- Messages regarding document status will be presented in an infobar control at the top of the document or in the status bar.

- The user must be able to customize the appearance of fonts and colors using a **Tools > Options** page, either the shared Fonts and Colors page or one specific to the editor.

#### Design surfaces

- An empty designer should have a watermark on the surface indicating how to get started.

- View-switching mechanisms will follow existing patterns such as double-click to open a code editor, or tabs within the document window allowing interaction with both panes.

- Adding elements to the design surface should be done via the Toolbox, unless a highly specific tool window is required.

- Items on the surface will follow a consistent selection model.

- Embedded toolbars contain document-specific commands only, not common commands such as **Save**.

#### Dialog-style editors

- Control layout should follow normal dialog layout conventions.

- Tabs within the editor should not match the appearance of the document tabs, they should match one of the two allowed interior tab styles.

- Users must be able to interact with the controls using keyboard only; either by activating the editor and tabbing through controls or by using standard mnemonics.

- The designer should use the common Save model. No overall Save or commit buttons should be placed on the surface, although other buttons may be appropriate.

#### Model designers

- An empty designer should have a watermark on the surface indicating how to get started.

- Adding elements to the design surface should be done via the Toolbox.

- Items on the surface will follow a consistent selection model.

- Embedded toolbars contain document-specific commands only, not common commands such as **Save**.

- A legend may appear on the surface, either indicative or a watermark.

- The user must be able to customize the appearance of the fonts/colors using a **Tools > Options** page, either the shared Fonts and Colors page or one specific to the editor.

#### Reports

- Reports are typically information-only and don't participate in the Save model. However, they may include interaction such as links to other relevant information or sections that expand and collapse.

- Most commands on the surface should be hyperlinks, not buttons.

- Layout should include a header and follow the standard report layout guidelines.

#### Dashboards

- Dashboards don't have an interaction model themselves, but serve as a means to offer a variety of other tools.

- They do not participate in the Save model.

- Users must be able to interact with the controls using keyboard only, either by activating the editor and tabbing through controls or by using standard mnemonics.

## <a name="BKMK_Dialogs"></a> Dialogs

### Introduction
Dialogs in Visual Studio should typically support one discrete unit of the user's work and then be dismissed.

If you have determined that you need a dialog, you have three choices, in order of preference:

1. Integrate your features into one of the shared dialogs in Visual Studio.

2. Create your own dialog using a pattern found in an existing similar dialog.

3. Create a new dialog, following interaction and layout guidelines.

This section describes how to choose the correct dialog pattern within Visual Studio workflows and the common conventions for dialog design.

### Themes
Dialogs in Visual Studio follow one of two basic styles:

#### Standard (unthemed)
The majority of dialogs are standard utility dialogs and should be unthemed. Do not re-template common controls or attempt to create stylized "modern" buttons or controls. Controls and chrome appearance follow [standard Windows Desktop interaction guidelines for dialog boxes](/windows/desktop/uxguide/win-dialog-box).

#### Themed
Specialty "signature" dialogs may be themed. Themed dialogs have a distinct appearance, which also has some special interaction patterns associated with the style. Theme your dialog only if it meets these requirements:

- The dialog is a common experience that will be seen and used often or by many users (for example, the **New Project** dialog.

- The dialog contains prominent product brand elements (for example, the **Account Settings** dialog).

- The dialog appears as an integral part of a larger flow that includes other themed dialogs (for example, the **Add Connected Service** dialog).

- The dialog is an important part of an experience that plays a strategic role in promoting or differentiating a product version.

When creating a themed dialog, use the appropriate environment colors and follow the correct layout and interaction patterns. (See [Layout for Visual Studio](../../extensibility/ux-guidelines/layout-for-visual-studio.md).)

### Dialog design
Well-designed dialogs take the following elements into consideration:

- The user task being supported

- The dialog text style, language, and terminology

- Control choice and UI conventions

- Visual layout specification and control alignment

- Keyboard access

#### Content organization
Consider the differences between these basic types of dialogs:

- [Simple dialogs](../../extensibility/ux-guidelines/application-patterns-for-visual-studio.md#BKMK_SimpleDialogs) present controls in a single modal window. The presentation might include variations of complex control patterns, including a field picker or an icon bar.

- [Layered dialogs](../../extensibility/ux-guidelines/application-patterns-for-visual-studio.md#BKMK_LayeredDialogs) are used to make the most of screen real estate when a single piece of UI comprises multiple groups of controls. The dialog's groupings are "layered" through tab controls, navigation list controls, or buttons so that the user can choose which grouping to see at any given moment.

- [Wizards](../../extensibility/ux-guidelines/application-patterns-for-visual-studio.md#BKMK_Wizards) are useful for directing the user through a logical sequence of steps toward the completion of a task. A series of choices are offered in sequential panels, sometimes introducing different workflows ("branches") dependent on a choice made in the previous panel.

#### <a name="BKMK_SimpleDialogs"></a> Simple dialogs
A simple dialog is a presentation of controls in a single modal window. This presentation might include variations of complex control patterns, such as a field picker. For simple dialogs, follow the standard general layout as well as any specific layout required for complex control groupings.

![>Create Strong Name Key is an example of a simple dialog in Visual Studio.](../../extensibility/ux-guidelines/media/0704-01_createstrongnamekey.png "0704-01_CreateStrongNameKey")<br />Create Strong Name Key is an example of a simple dialog in Visual Studio.

#### <a name="BKMK_LayeredDialogs"></a> Layered dialogs
Layered dialogs include tabs, dashboards, and embedded trees. They are used to maximize real estate when there are multiple groups of controls offered in a single piece of UI. The groupings are layered so that the user can choose which grouping to see at any one time.

In the most straightforward case, the mechanism for switching between groupings is a tab control. There are several alternatives available. See Prioritizing and layering for how to choose the most appropriate style.

The **Tools &gt; Options** dialog is an example of a layered dialog using an embedded tree:

![Tools > Options is an example of a layered dialog in Visual Studio.](../../extensibility/ux-guidelines/media/0704-02_toolsoptions.png "0704-02_ToolsOptions")<br />Tools > Options is an example of a layered dialog in Visual Studio.

#### <a name="BKMK_Wizards"></a> Wizards
Wizards are useful for directing the user through a logical sequence of steps in the completion of a task. A series of choices are offered in sequential panels, and the user must continue through each step before proceeding to the next. Once sufficient defaults are available, the **Finish** button is enabled.

 Modal wizards are used for tasks that:

- Contain branching, where different paths are offered depending on user choices

- Contain dependencies between steps, where subsequent steps depend on user input from the preceding step(s)

- Are sufficiently complex that the UI should be used to explain the choices offered and the possible outcomes in each step

- Are transactional, requiring a set of steps to be completed in its entirety before any changes are committed

### Common conventions
To achieve optimal design and functionality with your dialogs, follow these conventions on dialog size, position, standards, control configuration and alignment, UI text, title bars, control buttons, and access keys.

For layout-specific guidelines, see [Layout for Visual Studio](../../extensibility/ux-guidelines/layout-for-visual-studio.md).

#### Size
Dialogs should fit within a minimum 1024x768 screen resolution, and initial dialog size should not exceed 900x700 pixels. Dialogs may be resizable, but it is not a requirement.

There are two recommendations for resizable dialogs:

1. That a minimum size is a defined for the dialog that will optimize for the control set without clipping, and adjust to accommodate reasonable localization growth.

2. That the user-scaled size persists from session to session. For example, if the user scales a dialog to 150%, then a subsequent launch of the dialog will display at 150%.

#### Position
Dialogs must appear centered within the IDE on first launch. The last position of non-resizable dialogs doesn't need to be persisted, so they will appear centered on subsequent launches.

For resizable dialogs, the size should be persisted on subsequent launches. For resizable modal dialogs, the position doesn't need to be persisted. Displaying them centered within the IDE prevents the possibility of the dialog appearing in an unpredictable or unusable position when the user's display configuration has changed.

For modeless dialogs that can be repositioned, the user's position should be maintained on subsequent launches, as the dialog might be used frequently as an integral part of a larger workflow.

When dialogs must spawn other dialogs, the topmost dialog should cascade to the right and down from the parent so that it's obvious to the user that they've navigated to a new place.

#### Modality
Being modal means that users are required to complete or cancel the dialog before continuing. Since modal dialogs block the user from interacting with other parts of the environment, your feature's task flow should use them as sparingly as possible. When a modal operation is necessary, Visual Studio has a number of shared dialogs you can integrate your features into. If you must create a new dialog, follow the interaction pattern of an existing dialog with similar functionality.

When users need to perform two activities at once, like **Find** and **Replace** while writing new code, the dialog should be modeless so that the user can easily switch between them. Visual Studio generally uses tool windows for this kind of editor-supporting linked task.

#### Control configuration
Be consistent with existing control configurations that accomplish the same thing in Visual Studio.

#### Title bars

- The text in the title bar must reflect the name of the command that launched it.

- No icon should be used in dialog title bars. In cases where the system requires one, use the Visual Studio logo.

- Dialogs should not have minimize or maximize buttons.

- Help buttons in the title bar have been deprecated. Do not add them to new dialogs. When they do exist, they should launch a Help topic that is conceptually relevant to the task.

  ![Guideline specifications for title bars in Visual Studio dialogs](../../extensibility/ux-guidelines/media/0704-03_titlebarspecs.png "0704-03_TitleBarSpecs")<br />Guideline specifications for title bars in Visual Studio dialogs

#### Control buttons
In general, **OK**, **Cancel**, and **Help** buttons should be arranged horizontally in the lower right corner of the dialog. The alternate vertical stack is permitted if a dialog has several other buttons at the bottom of the dialog that would present visual confusion with the control buttons.

![Acceptable configurations for control buttons in Visual Studio dialogs](../../extensibility/ux-guidelines/media/0704-04_controlbuttonconfig.png "0704-04_ControlButtonConfig")<br />Acceptable configurations for control buttons in Visual Studio dialogs

The dialog must include a default control button. This is a button that is invoked by pressing the Enter key - see [Button IsDefault](http://dotnet/api/system.windows.controls.button.isdefault?view=netframework-4.7.2)
.To determine the best command to use as the default, choose from the following options (listed in order of precedence):

- Choose the safest and most secure command as the default. This means choosing the command most likely to prevent data loss and avoid unintended system access.

- If data loss and security aren't factors, then choose the default command based on convenience. Including the most likely command as the default will improve the user's workflow when the dialog supports frequent or repetitive tasks.

Avoid choosing a permanently destructive action for the default command. If such a command is present, choose a safer command as the default instead.

#### Access keys
Do not use access keys for **OK** or **Cancel**. Enter and Escape shortcuts can be set with [Button IsDefault](http://dotnet/api/system.windows.controls.button.isdefault?view=netframework-4.7.2) and [Button IsCancel](http://dotnet/api/system.windows.controls.button.iscancel?view=netframework-4.7.2) respectively.

#### Imagery
Use images sparingly in dialogs. Don't use large icons in dialogs merely to use up space. Use images only if they are an important part of conveying the message to the user, like warning icons or status animations.

### <a name="BKMK_PrioritizingAndLayering"></a> Prioritizing and layering

#### Prioritizing your UI
It might be necessary to bring certain UI elements to the forefront and place more advanced behavior and options (including obscure commands) into dialogs. Bring commonly used functionality to the forefront by making room for it, and by making it visible by default in the UI with a text label when the dialog is shown.

#### Layering your UI
If you have determined that a dialog is necessary but the related functionality you want to present to the user goes beyond what can be displayed in a simple dialog, then you need to layer your UI. The most common layering methods Visual Studio uses are tabs and hallways or dashboards. In some cases, regions that can expand and collapse might be appropriate. Adaptive UI is generally not recommended in Visual Studio.

There are advantages and disadvantages to different methods of layering UI through tab-like controls. Review the list below to ensure that you are choosing a layering technique that is appropriate to your situation.

##### Tabbing

| Switching mechanism | Advantages and appropriate use | Disadvantages and inappropriate use |
| --- | --- | --- |
| Tab control | Logically group dialog pages into related sets<br /><br />Useful for fewer than five (or the number of tabs that fit in one row across the dialog) pages of related controls in dialog<br /><br />Tab labels must be short: one or two words that can easily identify the content<br /><br />A common system dialog style<br /><br />Example: **File Explorer &gt; Item Properties** | Making descriptive short labels can be difficult<br /><br />Generally doesn't scale past five tabs in one dialog<br /><br />Inappropriate if you have too many tabs for one row (use an alternative layering technique)<br /><br />Not extensible |
| Sidebar navigation | Simple switching device that can accommodate more categories than tabs<br /><br />Flat list of categories (no hierarchy)<br /><br />Extensible<br /><br />Example: **Customize... &gt; Add Command** | Not a good use of horizontal space if there are fewer than three groups<br /><br />Task might be better suited to a drop-down |
| Tree control | Allows for unlimited categories<br /><br />Allows for grouping and/or hierarchy of categories<br /><br />Extensible<br /><br />Example: **Tools &gt; Options** | Heavily nested hierarchies can cause excessive horizontal scrolling<br /><br />Visual Studio has an overabundance of tree views |
| Wizard | Helps with task completion by guiding the user through task-based, sequential steps: the wizard represents a high-level task and the individual panels represent subtasks needed to accomplish the overall task<br /><br />Useful when the task crosses Ui boundaries, as when the user would otherwise have to use multiple editors and tool windows to complete the task<br /><br />Useful when the task requires branching<br /><br />Useful when the task contains dependencies between steps<br /><br />Useful when several similar tasks with one decision fork can be presented in one dialog to reduce the number of different similar dialogs | Inappropriate for any task that doesn't require a sequential workflow<br /><br />Users can become overwhelmed and confused by a wizard with too many steps<br /><br />Wizards have inherently limited screen real estate |

##### Hallways or dashboards
Hallways and dashboards are dialogs or panels that serve as launching points to other dialogs and windows. The well-designed "hallway" immediately surfaces only the most common options, commands, and settings, allowing the user to readily accomplish common tasks. Like a real-world hallway provides doorways to access the rooms behind them, here the less-common UI is collected into separate "rooms" (often other dialogs) of related functionality that can be accessed from the main hallway.

Alternatively, a UI that offers all available functionality in a single collection rather than refactoring the less-common functionality into separate locations is simply a dashboard.

![Hallway concept for exposing additional UI in Outlook](../../extensibility/ux-guidelines/media/0704-08_hallway.png "0704-08_Hallway")<br />Hallway concept for exposing additional UI in Outlook

##### Adaptive UI
Showing or hiding UI based on usage or a user's self-reported experience is another way of presenting necessary UI while hiding other portions. This is not recommended in Visual Studio, as the algorithms for deciding when to show or hide UI can be tricky, and the rules will always be wrong for some set of cases.

## <a name="BKMK_Projects"></a> Projects

### Projects in the Solution Explorer
Most projects are classified as reference-based, directory-based, or mixed. All three types of projects are supported simultaneously in the Solution Explorer. The root of the user experience in working with projects takes place inside this window. Although different project nodes are reference, directory, or mixed-mode type projects, there is a common interaction pattern that should be applied as a starting point before diverging into project-specific user patterns.

Projects should always:

- Support the ability to add project folders to organize project contents

- Maintain a consistent model for project persistence

Projects should also maintain consistent interaction models for:

- Removing project items

- Saving documents

- Project property editing

- Editing the project in an alternate view

- Drag-and-drop operations

### Drag-and-drop interaction model
Projects typically classify themselves as reference-based (able to persist only references to project items in storage), directory-based (able to persist only project items physically stored within a project's hierarchy), or mixed (able to persist references or physical items). The IDE accommodates all three types of projects simultaneously within the **Solution Explorer**.

From a drag-and-drop perspective, the following characteristics should apply to each type of project within the **Solution Explorer**:

- **Reference-based project:** The key point is that the project is dragging around a reference to an item in storage. When a reference-based project acts as a source for a move operation, it should only remove the reference to the item from the project. The item should not actually be deleted from the hard drive. When a reference-based project acts as a target for a move (or copy) operation, it should add a reference to the original source item without making a private copy of the item.

- **Directory-based project:** From a drag-and-drop point of view, the project is dragging around the physical item rather than a reference. When a directory-based project acts as a source for a move operation, it should end up deleting the physical item from the hard drive as well as removing it from the project. When a directory-based project acts as a target for a move (or copy) operation, it should make a copy of the source item in its target location.

- **Mixed-target project:** From a drag-and-drop point of view, the behavior of this type of project is based on the nature of the item being dragged (either a reference to an item in storage or the item itself). The correct behavior for references and physical items are described above.

If there were only one type of project in the **Solution Explorer**, then drag-and-drop operations would be straightforward. Because each project system has the ability to define its own drag-and-drop behavior, certain guidelines (based on the Windows Explorer drag-and-drop behavior) should be followed to ensure a predictable user experience:

- An unmodified drag operation in the **Solution Explorer** (when neither Ctrl nor Shift keys are held down) should result in a move operation.

- Shift-drag operation should also result in a move operation.

- Ctrl-drag operation should result in a copy operation.

- Reference-based and mixed project systems support the notion of adding a link (or reference) to the source item. When these projects are the target of a drag-and-drop operation (when **Ctrl + Shift** is held down), it should result in a reference to the item being added to the project

Not all drag-and-drop operations are sensible across combinations of reference-based, directory-based, and mixed projects. In particular, it is problematic to pretend to allow a move operation between a directory-based source project and reference-based target project because the source directory-based project will have to delete the source item upon completion of the move. The target reference-based project would then end up with a reference to a deleted item.

It's also misleading to pretend to allow a copy operation between these types of projects because the target reference-based project should not make an independent copy of the source item. Similarly, Ctrl + Shift dragging to a directory-based target project should not be allowed because a directory-based project is unable to persist references. In cases where the drag-and-drop operation is not supported, the IDE should disallow the drop and show the user the no-drop cursor (shown in the pointer table below).

To properly implement drag-and-drop behavior, the source project of the drag needs to communicate its nature to the target project. (For example, is it reference- or directory-based?) This information is indicated by the clipboard format that's offered by the source. As the source of a drag (or clipboard copy operation) a project should offer either `CF_VSREFPROJECTITEMS` or `CF_VSSTGPROJECTITEMS` respectively, depending on whether the project is reference-based or directory-based. Both of these formats have the same data content, which is similar to the Windows `CF_HDROP` format except that lists of strings, instead of being filenames, are a double-`NULL` terminated list of `Projref` strings (as returned from `IVsSolution::GetProjrefOfItem` or `::GetProjrefOfProject` as appropriate).

As the target of a drop (or clipboard paste operation), a project should accept both `CF_VSREFPROJECTITEMS` and `CF_VSSTGPROJECTITEMS`, though the exact handling of the drag-and-drop operation varies depending on the nature of the target project and the source project. The source project declares its nature by whether it offers `CF_VSREFPROJECTITEMS` or `CF_VSSTGPROJECTITEMS`. The target of the drop understands its own nature and thus has enough information to make decisions as to whether a move, copy, or link should be performed. The user also modifies which drag-and-drop operation should be performed by pressing the Ctrl, Shift, or both Ctrl and Shift keys. It is important for the drop target to properly indicate which operation will be performed in advance in its `DragEnter` and `DragOver` methods. The **Solution Explorer** automatically knows whether the source project and the target project are the same project.

Dragging project items across instances of Visual Studio (for example, from one instance of devenv.exe to another) is specifically not supported. The **Solution Explorer** also directly disables this.

The user should always be able to determine the effect of a drag-and-drop operation by selecting an item, dragging it to the target location, and observing which of the following mouse pointers appears before the item is dropped:

| Mouse pointer | Command | Description |
| :---: | --- | --- |
| ![Mouse "no drop" icon](../../extensibility/ux-guidelines/media/0706-01_mousenodrop.png "0706-01_MouseNoDrop") | No drop | Item cannot be dropped to the specified location. |
| ![Mouse "copy" icon](../../extensibility/ux-guidelines/media/0706-02_mousecopy.png "0706-02_MouseCopy") | Copy | Item will be copied to the target location. |
| ![Mouse "move" icon](../../extensibility/ux-guidelines/media/0706-03_mousemove.png "0706-03_MouseMove") | Move | Item will be moved to the target location. |
| ![Mouse "add reference" icon](../../extensibility/ux-guidelines/media/0706-04_mouseaddref.png "0706-04_MouseAddRef") | Add reference | A reference to the selected item will be added to the target location. |

#### Reference-based projects
 The following table summarizes the drag-and-drop (as well as cut/copy/paste) operations that should be performed based on the nature of the source item and modifier keys pressed for referenced-based target projects:

| Modifier | Category | Source item: Reference/Link | Source item: Physical item or file system (`CF_HDROP`) |
| --- | --- | --- | --- |
| No modifier | Action | Move | Link |
| No modifier | Target | Adds reference to original item | Adds reference to original item |
| No modifier | Source | Deletes reference to original item | Retains original item |
| No modifier | Result | `DROPEFFECT_MOVE` is returned as action from `::Drop` and item remains in original location in storage | `DROPEFFECT_LINK` is returned as action from `::Drop` and item remains in original location in storage |
| Shift+Drag | Action | Move | No drop |
| Shift+Drag | Target | Adds reference to original item | No drop |
| Shift+Drag | Source | Deletes reference to original item | No drop |
| Shift+Drag | Result | `DROPEFFECT_MOVE` is returned as action from `::Drop` and item remains in original location in storage | No drop |
| Ctrl+Drag | Action | Copy | No drop |
| Ctrl+Drag | Target | Adds reference to original item | No drop |
| Ctrl+Drag | Source | Retains reference to original item | No drop |
| Ctrl+Drag | Result | `DROPEFFECT_COPY` is returned as action from `::Drop` and item remains in original location in storage | No drop |
| Ctrl+Shift+Drag | Action | Link | Link |
| Ctrl+Shift+Drag | Target | Adds reference to original item | Adds reference to original item |
| Ctrl+Shift+Drag | Source | Retains reference to original item | Retains original item |
| Ctrl+Shift+Drag | Result | `DROPEFFECT_LINK` is returned as action from `::Drop` and item remains in original location in storage | `DROPEFFECT_LINK` is returned as action from `::Drop` and item remains in original location in storage |
| Ctrl+Shift+Drag | Note | Same as drag-and-drop behavior for shortcuts in Windows Explorer. ||
| Cut/Paste | Action | Move | Link |
| Cut/Paste | Target | Adds reference to original item | Adds reference to original item |
| Cut/Paste | Source | Retains reference to original item|Retains original item |
| Cut/Paste | Result | Item remains in original location in storage | Item remains in original location in storage |
| Copy/Paste | Action | Copy | Link |
| Copy/Paste | Source | Adds reference to original item | Adds reference to original item |
| Copy/Paste | Result | Retains reference to original item | Retains original item |
| Copy/Paste | Action | Item remains in original location in storage | Item remains in original location in storage |

#### Directory-based projects
The following table summarizes the drag-and-drop (as well as cut/copy/paste) operations that should be performed based on the nature of the source item and modifier keys pressed for directory-based target projects:

| Modifier | Category | Source item: Reference/Link | Source item: Physical item or file system (`CF_HDROP`) |
|-----------------|----------| - | - |
| No modifier | Action | Move | Move |
| No modifier | Target | Copies item to target location | Copies item to target location |
| No modifier | Source | Deletes reference to original item | Deletes reference to original item |
| Shift+Drag | Action | Move | Move |
| Shift+Drag | Target | Copies item to target location | Copies item to target location |
| Shift+Drag | Source | Deletes reference to original item | Deletes item from original location |
| Shift+Drag | Result | `DROPEFFECT_MOVE` is returned as action from `::Drop` and item remains in original location in storage | `DROPEFFECT_MOVE` is returned as action from `::Drop` and item remains in original location in storage |
| Ctrl+Drag | Action | Copy | Copy |
| Ctrl+Drag | Target | Copies item to target location | Copies item to target location |
| Ctrl+Drag | Source | Retains reference to original item | Retains reference to original item |
| Ctrl+Drag | Result | `DROPEFFECT_COPY` is returned as action from `::Drop` and item remains in original location in storage | `DROPEFFECT_COPY` is returned as action from `::Drop` and item remains in original location in storage |
| Ctrl+Shift+Drag | | No drop | No drop |
| Cut/Paste | Action | Move | Move |
| Cut/Paste | Target | Copies item to target location | Copies item to target location |
| Cut/Paste | Source | Deletes reference to original item | Deletes item from original location |
| Cut/Paste | Result | Item remains in original location in storage | Item is deleted from original location in storage |
| Copy/Paste | Action | Copy | Copy |
| Copy/Paste | Target | Adds reference to original item | Copies item to target location |
| Copy/Paste | Source | Retains original item | Retains original item |
| Copy/Paste | Result | Item remains in original location in storage | Item remains in original location ins storage |

#### Mixed-target projects
The following table summarizes the drag-and-drop (as well as cut/copy/paste) operations that should be performed based on the nature of the source item and modifier keys pressed for mixed-target projects:

| Modifier | Category | Source item: Reference/Link | Source item: Physical item or file system (`CF_HDROP`) |
| --- | --- | --- | --- |
| No modifier | Action | Move | Move |
| No modifier | Target | Adds reference to original item | Copies item to target location |
| No modifier | Source | Deletes reference to original item | Deletes reference to original item |
| No modifier | Result | `DROPEFFECT_ MOVE` is returned as action from `::Drop` and item remains in original location in storage | `DROPEFFECT_ MOVE` is returned as action from `::Drop` and item is deleted from original location in storage |
| Shift+Drag | Action | Move | Move |
| Shift+Drag | Target | Adds reference to original item | Copies item to target location |
| Shift+Drag | Source | Deletes reference to original item | Deletes item from original location |
| Shift+Drag | Result | `DROPEFFECT_ MOVE` is returned as action from `::Drop` and item remains in original location in storage | `DROPEFFECT_ MOVE` is returned as action from `::Drop` and item is deleted from original location in storage |
| Ctrl+Drag | Action | Copy | Copy |
| Ctrl+Drag | Target | Adds reference to original item | Copies item to target location |
| Ctrl+Drag | Source | Retains reference to original item | Retains original item |
| Ctrl+Drag | Result | `DROPEFFECT_ COPY` is returned as action from `::Drop` and item remains in original location in storage | `DROPEFFECT_ COPY` is returned as action from `::Drop` and item remains in original location in storage |
| Ctrl+Shift+Drag | Action | Link | Link |
| Ctrl+Shift+Drag | Target | Adds reference to original item | Adds reference to original source item |
| Ctrl+Shift+Drag | Source | Retains reference to original item | Retains original item |
| Ctrl+Shift+Drag | Result | `DROPEFFECT_ LINK` is returned as action from `::Drop` and item remains in original location in storage | `DROPEFFECT_ LINK` is returned as action from `::Drop` and item remains in original location in storage |
| Cut/Paste | Action | Move | Move |
| Cut/Paste | Target | Copies item to target location | Copies item to target location |
| Cut/Paste | Source | Deletes reference to original item | Deletes item from original location |
| Cut/Paste | Result | Item remains in original location in storage | Item is deleted from original location in storage |
| Copy/Paste | Action | Copy | Copy |
| Copy/Paste | Target | Adds reference to original item | Copies item to target location |
| Copy/Paste | Source | Retains original item | Retains original item |
| Copy/Paste | Result | Item remains in original location in storage | Item remains in original location in storage |

These details should be taken into consideration when implementing dragging in the **Solution Explorer**:

- Design for multiple selection scenarios.

- File names (full path) must be unique across the target project or the drop should not be allowed.

- Folder names must be unique (case-insensitive) at the level they are being dropped.

- There are behavior differences between files that are open or closed at time of drag (not mentioned in scenarios above).

- Top-level files behave slightly differently than files in folders.

Another issue to be aware of is how to handle move operations on items that have open designers or editors. The expected behavior is as follows (this applies to all project types):

1. If the open editor/designer does not have any unsaved changes, then the editor/designer window should be silently closed.

2. If the open editor/designer does have unsaved changes, then the source of the drag should wait for the drop to occur and then ask the user to save the uncommitted changes in the open documents before closing the window with a prompt similar to the following:

    ```
    ==========================================================
         One or more open documents have unsaved changes.
    Do you want to save uncommitted changes before proceeding?
                      [Yes]  [No]  [Cancel]
    ==========================================================
    ```

This gives the user the opportunity to save work in progress before the target makes its copies. A new method `IVsHierarchyDropDataSource2::OnBeforeDropNotify` has been added to enable this handling.

The target will then copy the state of the item as it is in storage (not including the unsaved changes in the editor if the user chose **No**). After the target has completed its copying (in `IVsHierarchyDropDataSource::Drop`), the source is given the opportunity to complete the delete portion of the move operation (in `IVsHierarchyDropDataSource::OnDropNotify`).

Any editors with unsaved changes should be left open. For those documents with unsaved changes, this means that the copy portion of the move operation will be performed but the delete portion will be aborted. In a multiple selection scenario when the user chooses **No**, those documents with unsaved changes should not be closed or removed, but those without unsaved changes should be closed and removed.
