---
title: Keyboard shortcuts
description: Learn about the default keyboard shortcuts in Visual Studio that allow you to access a variety of commands and windows.
ms.date: 09/9/2024
ms.topic: reference
helpviewer_keywords:
- shortcut keys [Visual Studio], keyboard binding schemes
- keyboard binding schemes [Visual Studio]
- Help [Visual Studio], shortcut keys
- keyboard shortcuts [Visual Studio], keyboard binding schemes
- keyboard shortcuts
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Keyboard shortcuts in Visual Studio

You can access a variety of [commands](reference/visual-studio-commands.md) and windows in Visual Studio by choosing the appropriate keyboard shortcut. This page lists the default command shortcuts for the **General** profile, which you might have chosen when you installed Visual Studio. No matter which profile you chose, you can [identify the shortcut](identifying-and-customizing-keyboard-shortcuts-in-visual-studio.md#identify-a-keyboard-shortcut) for a command by opening the **Options** dialog box, expanding the **Environment** node, and then choosing **Keyboard**. You can also [customize your shortcuts](identifying-and-customizing-keyboard-shortcuts-in-visual-studio.md#customize-a-keyboard-shortcut) by assigning a different shortcut to any given command.

For a list of common keyboard shortcuts and other productivity information, see:

- [Keyboard tips](../ide/productivity-shortcuts.md)
- [Productivity tips](../ide/productivity-features.md)

For more information about accessibility in Visual Studio, see [Accessibility tips and tricks](../ide/reference/accessibility-tips-and-tricks.md) and [How to: Use the keyboard exclusively](../ide/reference/how-to-use-the-keyboard-exclusively.md).

The keyboard shortcuts in Visual Studio may vary depending on your keyboard layout and language settings. You can [identify the keyboard shortcut for a command](identifying-and-customizing-keyboard-shortcuts-in-visual-studio.md#identify-a-keyboard-shortcut) or [customize your keyboard shortcut](identifying-and-customizing-keyboard-shortcuts-in-visual-studio.md#customize-a-keyboard-shortcut). See the [Dev Community ticket](https://developercommunity.visualstudio.com/t/Issue-with-New-Ctrl---Comment-Shortc/10725157?q=keyboard+language&ftype=idea&stateGroup=active) related to this issue for more information.

## Printable shortcut cheatsheet

Click to get our [printable keyboard shortcut cheatsheet for Visual Studio](https://visualstudio.microsoft.com/keyboard-shortcuts.pdf).

[:::image type="content" source="media/default-keyboard-shortcuts-in-visual-studio/visual-studio-keyboard-shortcut-cheatsheet.png" alt-text="Printable cheatsheet for keyboard shortcuts.":::](https://visualstudio.microsoft.com/keyboard-shortcuts.pdf)

<a name="popular"></a>
## Popular keyboard shortcuts for Visual Studio

All shortcuts in this section apply globally unless otherwise specified. The *Global* context means that the shortcut is applicable in any tool window in Visual Studio.

> [!TIP]
> You can [look up the shortcut](identifying-and-customizing-keyboard-shortcuts-in-visual-studio.md) for any command by opening the **Options** dialog box, expanding the **Environment** node, and then choosing **Keyboard**.

- [Build](#bkmk_build-popular-shortcuts)
- [Debug](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_debug-popular-shortcuts)
- [Edit](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_edit-popular-shortcuts)
- [File](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_file-popular-shortcuts)
- [Project](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_project-popular-shortcuts)
- [Refactor](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_refactor-popular-shortcuts)
- [Tools](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_tools-popular-shortcuts)
- [View](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_view-popular-shortcuts)
- [Window](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_window-popular-shortcuts)

#### <a name="bkmk_build-popular-shortcuts"></a> Build: popular shortcuts

|Commands|Keyboard shortcuts |Command ID|
|-|-|-|
|Build solution|**Ctrl+Shift+B** | Build.BuildSolution |
|Cancel|**Ctrl+Break** | Build.Cancel |
|Compile|**Ctrl+F7** | Build.Compile |
|Run code analysis on solution|**Alt+F11**| Build.RunCodeAnalysisonSolution |

#### <a name="bkmk_debug-popular-shortcuts"></a> Debug: popular shortcuts

|Commands|Keyboard shortcuts [Special contexts]|Command ID|
|-|-|-|
|Break at function|**Ctrl+B**| Debug.BreakatFunction |
|Break all|**Ctrl+Alt+Break**| Debug.BreakAll |
|Delete all breakpoints|**Ctrl+Shift+F9**| Debug.DeleteAllBreakpoints |
|Exceptions|**Ctrl+Alt+E**| Debug.Exceptions |
|Quick watch|**Ctrl+Alt+Q**<br /><br />or **Shift+F9**| Debug.QuickWatch |
|Restart|**Ctrl+Shift+F5**| Debug.Restart |
|Run to cursor|**Ctrl+F10**| Debug.RunToCursor |
|Set next statement|**Ctrl+Shift+F10**| Debug.SetNextStatement |
|Start|**F5**| Debug.Start |
|Start without debugging|**Ctrl+F5**| Debug.StartWithoutDebugging |
|Step into|**F11**| Debug.StepInto |
|Step out|**Shift+F11**| Debug.StepOut |
|Step over|**F10**| Debug.StepOver |
|Stop debugging|**Shift+F5**| Debug.StopDebugging |
|Toggle breakpoint|**F9**| Debug.ToggleBreakpoint |

#### <a name="bkmk_edit-popular-shortcuts"></a> Edit: popular shortcuts

|Commands|Keyboard shortcuts [Special contexts]|Command ID|
|-|-|-|
|Break line|**Enter** [Text Editor, Report Designer, Windows Forms Designer]<br /><br />or **Shift+Enter** [Text Editor]| Edit.BreakLine |
|Collapse to definitions|**Ctrl+M**, **Ctrl+O** [Text Editor]| Edit.CollapseToDefinitions |
|Comment selection|**Ctrl+K**, **Ctrl+C** [Text Editor]| Edit.CommentSelection |
|Complete word|**Alt+Right Arrow** [Text Editor, Workflow Designer]<br /><br />or **Ctrl+Spacebar** [Text Editor, Workflow Designer]<br /><br />or **Ctrl+K**, **W** [Workflow Designer]<br /><br />or **Ctrl+K, Ctrl+W** [Workflow Designer]| Edit.CompleteWord |
|Copy|**Ctrl+C**<br /><br />or **Ctrl+Insert**| Edit.Copy |
|Cut|**Ctrl+X**<br /><br />or **Shift+Delete**| Edit.Cut |
|Delete|**Delete** [Team Explorer]<br /><br />or **Shift+Delete** [Sequence Diagram, UML Activity Diagram, Layer Diagram]<br /><br />or **Ctrl+Delete** [Class Diagram]| Edit.Delete |
|Find|**Ctrl+F**| Edit.Find |
|Find all references|**Shift+F12**| Edit.FindAllReferences |
|Find in files|**Ctrl+Shift+F**| Edit.FindinFiles |
|Find next|**F3**| Edit.FindNext |
|Find next selected|**Ctrl+F3**| Edit.FindNextSelected |
|Format document|**Ctrl+K, Ctrl+D** [Text Editor]| Edit.FormatDocument |
|Format selection|**Ctrl+K, Ctrl+F** [Text Editor]| Edit.FormatSelection |
|Go to|**Ctrl+G**| Edit.GoTo |
|Go to declaration|**Ctrl+F12**| Edit.GoToDeclaration |
|Go to definition|**F12**| Edit.GoToDefinition |
|Go to find combo|**Ctrl+D**| Edit.GoToFindCombo |
|Go to next location|**F8**| Edit.GoToNextLocation |
|Insert snippet|**Ctrl+K**, **Ctrl+X**| Edit.InsertSnippet |
|Insert tab|**Tab** [Report Designer, Windows Forms Designer, Text Editor]| Edit.InsertTab |
|Line cut|**Ctrl+L** [Text Editor]| Edit.LineCut |
|Line down extend column|**Shift+Alt+Down Arrow** [Text Editor]| Edit.LineDownExtendColumn |
|Line open above|**Ctrl+Enter** [Text Editor]| Edit.LineOpenAbove |
|List members|**Ctrl+J** [Text Editor, Workflow Designer]<br /><br />or **Ctrl+K, Ctrl+L** [Workflow Designer]<br /><br />or **Ctrl+K, L** [Workflow Designer]| Edit.ListMembers |
|Navigate to|**Ctrl+,**| Edit.NavigateTo |
|Open file|**Ctrl+Shift+G**| Edit.OpenFile |
|Overtype mode|**Insert** [Text Editor]| Edit.OvertypeMode |
|Parameter info|**Ctrl+Shift+Spacebar** [Text Editor, Workflow Designer]<br /><br />or **Ctrl+K, Ctrl+P** [Workflow Designer]<br /><br />or **Ctrl+K, P** [Workflow Designer]| Edit.ParameterInfo |
|Paste|**Ctrl+V**<br /><br />or **Shift+Insert**| Edit.Paste |
|Peek definition|**Alt+F12** [Text Editor]| Edit.PeekDefinition |
|Redo|**Ctrl+Y**<br /><br />or **Shift+Alt+Backspace**<br /><br />or **Ctrl+Shift+Z**| Edit.Redo |
|Replace|**Ctrl+H**| Edit.Replace |
|Select all|**Ctrl+A**| Edit.SelectAll |
|Select current word|**Ctrl+W** [Text Editor]| Edit.SelectCurrentWord |
|Selection cancel|**Esc** [Text Editor, Report Designer, Settings Designer, Windows Forms Designer, Managed Resources Editor]| Edit.SelectionCancel |
|Remove and sort usings|**Ctrl+R, Ctrl+G** [Text Editor]| EditorContextMenus.CodeWindow.RemoveAndSort |
|Surround with|**Ctrl+K, Ctrl+S** <br>(available only in Visual Studio 2019 and earlier)| Edit.SurroundWith |
|Tab left|**Shift+Tab** [Text Editor, Report Designer, Windows Forms Editor]| Edit.TabLeft |
|Toggle all outlining|**Ctrl+M, Ctrl+L** [Text Editor]| Edit.ToggleAllOutlining |
|Toggle bookmark|**Ctrl+K, Ctrl+K** [Text Editor]| Edit.ToggleBookmark |
|Toggle completion mode|**Ctrl+Alt+Space** [Text Editor]| Edit.ToggleCompletionMode |
|Toggle line comment|**Ctrl+/** [Text Editor] <br>(available in [Visual Studio 2022 version 17.11 or later](/visualstudio/releases/2022/release-notes))<br /><br />or **Ctrl+K, Ctrl+/** [Text Editor] | Edit.ToggleLineComment |
|Toggle outlining expansion|**Ctrl+M, Ctrl+M** [Text Editor]| Edit.ToggleOutliningExpansion |
|Uncomment selection|**Ctrl+K, Ctrl+U** [Text Editor]| Edit.UncommentSelection |
|Undo|**Ctrl+Z**<br /><br />or **Alt+Backspace**| Edit.Undo |
|Word delete to end|**Ctrl+Delete** [Text Editor]| Edit.WordDeleteToEnd |
|Word delete to start|**Ctrl+Backspace** [Text Editor]| Edit.WordDeleteToStart |

#### <a name="bkmk_file-popular-shortcuts"></a> File: popular shortcuts

|Commands|Keyboard shortcuts [Special contexts]|Command ID|
|-|-|-|
|Exit|**Alt+F4**| File.Exit |
|New file|**Ctrl+N**| File.NewFile |
|New project|**Ctrl+Shift+N**| File.NewProject |
|New web site|**Shift+Alt+N**| File.NewWebSite |
|Open file|**Ctrl+O**| File.OpenFile |
|Open project|**Ctrl+Shift+O**| File.OpenProject |
|Open web site|**Shift+Alt+O**| File.OpenWebSite |
|Rename|**F2** [Team Explorer]| File.Rename |
|Save all|**Ctrl+Shift+S**| File.SaveAll |
|Save selected items|**Ctrl+S**| File.SaveSelectedItems |
|View in browser|**Ctrl+Shift+W**| File.ViewinBrowser |

#### <a name="bkmk_project-popular-shortcuts"></a> Project: popular shortcuts

|Commands|Keyboard shortcuts [Special contexts]|Command ID|
|-|-|-|
|Add existing item|**Shift+Alt+A**| Project.AddExistingItem |
|Add new item|**Ctrl+Shift+A**| Project.AddNewItem |

#### <a name="bkmk_refactor-popular-shortcuts"></a> Refactor: popular shortcuts

|Command|Keyboard shortcut [Special contexts]|Command ID|
|-|-|-|
|Extract method|**Ctrl+R, Ctrl+M**| Refactor.ExtractMethod |

#### <a name="bkmk_tools-popular-shortcuts"></a> Tools: popular shortcuts

|Command|Keyboard shortcut [Special contexts]|Command ID|
|-|-|-|
|Attach to process|**Ctrl+Alt+P**| Tools.AttachtoProcess |

#### <a name="bkmk_view-popular-shortcuts"></a> View: popular shortcuts

|Commands|Keyboard shortcuts [Special contexts]|Command ID|
|-|-|-|
|Class view|**Ctrl+Shift+C**| View.ClassView |
|Edit label|**F2**| View.EditLabel |
|Error list|**Ctrl+\\, Ctrl+E**<br /><br />or **Ctrl+\\, E**| View.ErrorList |
|Navigate backward|**Ctrl+-**| View.NavigateBackward |
|Navigate forward|**Ctrl+Shift+-**| View.NavigateForward |
|Object browser|**Ctrl+Alt+J**| View.ObjectBrowser |
|Output|**Ctrl+Alt+O**| View.Output |
|Properties window|**F4**| View.PropertiesWindow |
|Refresh|**F5** [Team Explorer]| View.Refresh |
|Server explorer|**Ctrl+Alt+S**| View.ServerExplorer |
|Show smart tag|**Ctrl+.**<br /><br />or **Shift+Alt+F10** [HTML Editor Design View]| View.ShowSmartTag |
|Solution explorer|**Ctrl+Alt+L**| View.SolutionExplorer |
|TFS Team Explorer|**Ctrl+\\, Ctrl+M**| View.TfsTeamExplorer |
|Toolbox|**Ctrl+Alt+X**| View.Toolbox |
|View code|**Enter** [Class Diagram]<br /><br />or **F7** [Settings Designer]| View.ViewCode |
|View designer|**Shift+F7** [HTML Editor Source View]| View.ViewDesigner |

#### <a name="bkmk_window-popular-shortcuts"></a> Window: popular shortcuts

|Commands|Keyboard shortcuts [Special contexts]|Command ID|
|-|-|-|
|Activate document window|**Esc**| Window.ActivateDocumentWindow |
|Close document window|**Ctrl+F4**| Window.CloseDocumentWindow |
|Next document window|**Ctrl+F6**| Window.NextDocumentWindow |
|Next document window nav|**Ctrl+Tab**| Window.NextDocumentWindowNav |
|Next split pane|**F6**| Window.NextSplitPane |

## Global shortcuts

These keyboard shortcuts are *global*, which means that you can use them when any Visual Studio window has focus.

- [Analyze](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_analyze-global-shortcuts)
- [Architecture](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_architecture-global-shortcuts)
- [Azure](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_windowsazure-global-shortcuts)
- [Build](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_build-global-shortcuts)
- [Class View context menus](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_classview-global-shortcuts)
- [Debug](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_debug-global-shortcuts)
- [Debug context menus](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_debugger-global-shortcuts)
- [Diagnostics Hub](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_diagnostics-global-shortcuts)
- [Edit](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_edit-global-shortcuts)
- [Editor context menus](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_editorContext-global-shortcuts)
- [File](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_file-global-shortcuts)
- [Help](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_help-global-shortcuts)
- [Load test](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_loadtest-global-shortcuts)
- [Other context menus](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_otherContext-global-shortcuts)
- [Project](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_project-global-shortcuts)
- [Project and Solution context menus](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_projectContext-global-shortcuts)
- [Refactor](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_refactor-global-shortcuts)
- [Solution Explorer](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_solutionexplorerGLOBAL)
- [Team](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_team-global-shortcuts)
- [Team Foundation context menus](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_TFcontext-global-shortcuts)
- [Test](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_test-global-shortcuts)
- [Test Explorer](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_testexplorerGLOBAL)
- [Tools](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_tools-global-shortcuts)
- [View](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_view-global-shortcuts)
- [Window](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_window-global-shortcuts)

### <a name="bkmk_analyze-global-shortcuts"></a> Analyze: global shortcuts

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Navigate backward|**Shift+Alt+3**| Analyze.NavigateBackward |
|Navigate forward|**Shift+Alt+4**| Analyze.NavigateForward |

### <a name="bkmk_architecture-global-shortcuts"></a> Architecture: global shortcuts

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|New diagram|**Ctrl+\\, Ctrl+N**| Architecture.NewDiagram |

### <a name="bkmk_windowsazure-global-shortcuts"></a> Azure: global shortcuts

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Retry mobile service script operation|**Ctrl+Num \*, Ctrl+R**| WindowsAzure.RetryMobileServiceScriptOperation |
|Show mobile service script error details|**Ctrl+Num \*, Ctrl+D**| WindowsAzure.ShowMobileServiceScriptErrorDetails |

### <a name="bkmk_build-global-shortcuts"></a> Build: global shortcuts

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Build selection|**Ctrl+B** (Visual Studio 2019)| Build.BuildSelection |
|Build solution|**Ctrl+Shift+B**| Build.BuildSolution |
|Cancel|**Ctrl+Break**| Build.Cancel |
|Compile|**Ctrl+F7**| Build.Compile |
|Run code analysis  on solution|**Alt+F11**| Build.RunCodeAnalysisonSolution |

### <a name="bkmk_classview-global-shortcuts"></a> Class View context menus: global shortcuts

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Properties|**Alt+Enter**| ClassViewContextMenus.ClassViewMultiselectProjectreferencesItems.Properties |

### <a name="bkmk_debug-global-shortcuts"></a> Debug: global shortcuts

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Apply code changes|**Alt+F10**| Debug.ApplyCodeChanges |
|Attach  to process|**Ctrl+Alt+P**| Debug.AttachtoProcess |
|Autos|**Ctrl+Alt+V, A**| Debug.Autos |
|Break all|**Ctrl+Alt+Break**| Debug.BreakAll |
|Breakpoints|**Ctrl+Alt+B**| Debug.Breakpoints |
|Call stack|**Ctrl+Alt+C**| Debug.CallStack |
|Delete all breakpoints|**Ctrl+Shift+F9**| Debug.DeleteAllBreakpoints |
|Launch|**Alt+F2**| Debug.DiagnosticsHub.Launch |
|Disassembly|**Ctrl+Alt+D**| Debug.Disassembly |
|Dom explorer|**Ctrl+Alt+V, D**| Debug.DOMExplorer |
|Enable breakpoint|**Ctrl+F9**| Debug.EnableBreakpoint |
|Exceptions|**Ctrl+Alt+E**| Debug.Exceptions |
|Function breakpoint|**Ctrl+K, B** (Visual Studio 2019)<br />**Ctrl**+**B** (Visual Studio 2017)| Debug.FunctionBreakpoint |
|Go to previous call or IntelliTrace event|**Ctrl+Shift+F11**| Debug.GoToPreviousCallorIntelliTraceEvent |
|Start diagnostics|**Alt+F5**| Debug.Graphics.StartDiagnostics |
|Immediate|**Ctrl+Alt+I**| Debug.Immediate |
|IntelliTrace calls|**Ctrl+Alt+Y, T**| Debug.IntelliTraceCalls |
|IntelliTrace events|**Ctrl+Alt+Y, F**| Debug.IntelliTraceEvents |
|JavaScript console|**Ctrl+Alt+V, C**| Debug.JavaScriptConsole |
|Locals|**Ctrl+Alt+V, L**| Debug.Locals |
|Process combo|**Ctrl+5**| Debug.LocationToolbar.ProcessCombo |
|Stack frame combo|**Ctrl+7**| Debug.LocationToolbar.StackFrameCombo |
|Thread combo|**Ctrl+6**| Debug.LocationToolbar.ThreadCombo |
|Toggle current thread flagged state|**Ctrl+8**| Debug.LocationToolbar.ToggleCurrentThreadFlaggedState |
|Toggle flagged threads|**Ctrl+9**| Debug.LocationToolbar.ToggleFlaggedThreads |
|Memory 1|**Ctrl+Alt+M, 1**| Debug.Memory1 |
|Memory 2|**Ctrl+Alt+M, 2**| Debug.Memory2 |
|Memory 3|**Ctrl+Alt+M, 3**| Debug.Memory3 |
|Memory 4|**Ctrl+Alt+M, 4**| Debug.Memory4 |
|Modules|**Ctrl+Alt+U**| Debug.Modules |
|Parallel stacks|**Ctrl+Shift+D, S**| Debug.ParallelStacks |
|Parallel watch 1|**Ctrl+Shift+D, 1**| Debug.ParallelWatch1 |
|Parallel watch 2|**Ctrl+Shift+D, 2**| Debug.ParallelWatch2 |
|Parallel watch 3|**Ctrl+Shift+D, 3**| Debug.ParallelWatch3 |
|Parallel watch 4|**Ctrl+Shift+D, 4**| Debug.ParallelWatch4 |
|Processes|**Ctrl+Alt+Z**| Debug.Processes |
|Quick watch|**Shift+F9** or **Ctrl+Alt+Q**| Debug.QuickWatch |
|Re attach  to process|**Shift+Alt+P**| Debug.ReattachtoProcess |
|Refresh windowsapp|**Ctrl+Shift+R**| Debug.RefreshWindowsapp |
|Registers|**Ctrl+Alt+G**| Debug.Registers |
|Restart|**Ctrl+Shift+F5**| Debug.Restart |
|Run to cursor|**Ctrl+F10**| Debug.RunToCursor |
|Set next statement|**Ctrl+Shift+F10**| Debug.SetNextStatement |
|Show call stack on code map|**Ctrl+Shift+`**| Debug.ShowCallStackonCodeMap |
|Show next statement|**Alt+Num** *| Debug.ShowNextStatement |
|Start|**F5**| Debug.Start |
|Start windows phone application analysis|**Alt+F1**| Debug.StartWindowsPhoneApplicationAnalysis |
|Start without debugging|**Ctrl+F5**| Debug.StartWithoutDebugging |
|Step into|**F11**| Debug.StepInto |
|Step into current process|**Ctrl+Alt+F11**| Debug.StepIntoCurrentProcess |
|Step into specific|**Shift+Alt+F11**| Debug.StepIntoSpecific |
|Step out|**Shift+F11**| Debug.StepOut |
|Step out current process|**Ctrl+Shift+Alt+F11**| Debug.StepOutCurrentProcess |
|Step over|**F10** (When debugging: Performs a step over action)| Debug.StepOver |
|Step over|**F10** (When not debugging: Starts debugging and stops on the first line of user code)| Debug.StepOver |
|Step over current process|**Ctrl+Alt+F10**| Debug.StepOverCurrentProcess |
|Stop debugging|**Shift+F5**| Debug.StopDebugging |
|Stop performance analysis|**Shift+Alt+F2**| Debug.StopPerformanceAnalysis |
|Tasks|**Ctrl+Shift+D, K**| Debug.Tasks |
|Threads|**Ctrl+Alt+H**| Debug.Threads |
|Toggle breakpoint|**F9**| Debug.ToggleBreakpoint |
|Toggle disassembly|**Ctrl+F11**| Debug.ToggleDisassembly |
|Watch 1|**Ctrl+Alt+W, 1**| Debug.Watch1 |
|Watch 2|**Ctrl+Alt+W, 2**| Debug.Watch2 |
|Watch 3|**Ctrl+Alt+W, 3**| Debug.Watch3 |
|Watch 4|**Ctrl+Alt+W, 4**| Debug.Watch4 |

### <a name="bkmk_debugger-global-shortcuts"></a> Debugger context menus: global shortcuts

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Delete|**Alt+F9, D**| DebuggerContextMenus.BreakpointsWindow.Delete |
|Go to disassembly|**Alt+F9, A**| DebuggerContextMenus.BreakpointsWindow.GoToDisassembly |
|Go to source code|**Alt+F9, S**| DebuggerContextMenus.BreakpointsWindow.GoToSourceCode |

### <a name="bkmk_diagnostics-global-shortcuts"></a> Diagnostics Hub: global shortcuts

|Command|Keyboard shortcut|Command ID|
|-|-|-|
|Stop collection|**Ctrl+Alt+F2**| DiagnosticsHub.StopCollection |

### <a name="bkmk_edit-global-shortcuts"></a> Edit: global shortcuts

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Copy|**Ctrl+C**<br /><br /> or<br /><br /> **Ctrl+Ins**| Edit.Copy |
|Cut|**Ctrl+X**<br /><br /> or<br /><br /> **Shift+Delete**| Edit.Cut |
|Cycle clipboard ring|**Ctrl+Shift+V**<br /><br /> or<br /><br /> **Ctrl+Shift+Ins**| Edit.CycleClipboardRing |
|Delete|**Delete**| Edit.Delete |
|Duplicate|**Ctrl+D**| Edit.Duplicate |
|Find|**Ctrl+F**| Edit.Find |
|Find all references|**Shift+F12**| Edit.FindAllReferences |
|Find in files|**Ctrl+Shift+F**| Edit.FindinFiles |
|Find next|**F3**| Edit.FindNext |
|Find next selected|**Ctrl+F3**| Edit.FindNextSelected |
|Find previous|**Shift+F3**| Edit.FindPrevious |
|Find previous selected|**Ctrl+Shift+F3**| Edit.FindPreviousSelected |
|Generate method|**Ctrl+K, Ctrl+M**| Edit.GenerateMethod |
|Go to|**Ctrl+G**| Edit.GoTo |
|Go to all|**Ctrl+,** or **Ctrl+T**| Edit.GoToAll |
|Go to declaration|**Ctrl+F12**| Edit.GoToDeclaration |
|Go to definition|**F12**| Edit.GoToDefinition |
|Go to member|**Ctrl+1, Ctrl+M** or **Ctrl+1, M** or **Alt+\\**| Edit.GoToMember |
|Go to next location|**F8** (Next error in Error List or Output window)| Edit.GoToNextLocation |
|Go to prev location|**Shift+F8** (Previous error in Error List or Output window)| Edit.GoToPrevLocation |
|Insert snippet|**Ctrl+K, Ctrl+X**| Edit.InsertSnippet |
|Move control down|**Ctrl+Down Arrow**| Edit.MoveControlDown |
|Move control down grid|**Down Arrow**| Edit.MoveControlDownGrid |
|Move control left|**Ctrl+Left Arrow**| Edit.MoveControlLeft |
|Move control left grid|**Left Arrow**| Edit.MoveControlLeftGrid |
|Move control right|**Ctrl+Right Arrow**| Edit.MoveControlRight |
|Move control right grid|**Right Arrow**| Edit.MoveControlRightGrid |
|Move control up|**Ctrl+Up Arrow**| Edit.MoveControlUp |
|Move control up grid|**Up Arrow**| Edit.MoveControlUpGrid |
|Next bookmark|**Ctrl+K, Ctrl+N**| Edit.NextBookmark |
|Next bookmark in folder|**Ctrl+Shift+K, Ctrl+Shift+N**| Edit.NextBookmarkInFolder |
|Open file|**Ctrl+Shift+G** (Opens the file name under the cursor)| Edit.OpenFile |
|Paste|**Ctrl+V**<br /><br /> or<br /><br /> **Shift+Ins**| Edit.Paste |
|Previous bookmark|**Ctrl+K, Ctrl+P**| Edit.PreviousBookmark |
|Previous bookmark in folder|**Ctrl+Shift+K, Ctrl+Shift+P**| Edit.PreviousBookmarkInFolder |
|Quick find symbol|**Shift+Alt+F12**| Edit.QuickFindSymbol |
|Redo|**Ctrl+Y**<br /><br /> or<br /><br /> **Ctrl+Shift+Z**<br /><br /> or<br /><br /> **Shift+Alt+Backspace**| Edit.Redo |
|Refresh remote references|**Ctrl+Shift+J**| Edit.RefreshRemoteReferences |
|Replace|**Ctrl+H**| Edit.Replace |
|Replace  in files|**Ctrl+Shift+H**| Edit.ReplaceinFiles |
|Select all|**Ctrl+A**| Edit.SelectAll |
|Select next control|**Tab**| Edit.SelectNextControl |
|Select previous control|**Shift+Tab**| Edit.SelectPreviousControl |
|Show tile grid|**Enter**| Edit.ShowTileGrid |
|Size control down|**Ctrl+Shift+Down Arrow**| Edit.SizeControlDown |
|Size control down grid|**Shift+Down Arrow**| Edit.SizeControlDownGrid |
|Size control left|**Ctrl+Shift+Left Arrow**| Edit.SizeControlLeft |
|Size control left grid|**Shift+Left Arrow**| Edit.SizeControlLeftGrid |
|Size control right|**Ctrl+Shift+Right Arrow**| Edit.SizeControlRight |
|Size control right grid|**Shift+Right Arrow**| Edit.SizeControlRightGrid |
|Size control up|**Ctrl+Shift+Up Arrow**| Edit.SizeControlUp |
|Size control up grid|**Shift+Up Arrow**| Edit.SizeControlUpGrid |
|Stop search|**Alt+F3, S**| Edit.StopSearch |
|Surround with|**Ctrl+K, Ctrl+S** <br>(available only in Visual Studio 2019 and earlier)| Edit.SurroundWith |
|Undo|**Ctrl+Z**<br /><br /> or<br /><br /> **Alt+Backspace**| Edit.Undo |

### <a name="bkmk_editorContext-global-shortcuts"></a> Editor context menus: global shortcuts

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Breakpoint conditions|**Alt+F9, C**| EditorContextMenus.CodeWindow.Breakpoint.BreakpointConditions |
|Breakpoint edit labels|**Alt+F9, L**| EditorContextMenus.CodeWindow.Breakpoint.BreakpointEditlabels |
|Insert temporary breakpoint|**Shift+Alt+F9, T**| EditorContextMenus.CodeWindow.Breakpoint.InsertTemporaryBreakpoint |
|Show item|**Ctrl+`**| EditorContextMenus.CodeWindow.CodeMap.ShowItem |
|Execute|**Ctrl+Alt+F5**| EditorContextMenus.CodeWindow.Execute |
|Go to view|**Ctrl+M, Ctrl+G**| EditorContextMenus.CodeWindow.GoToView |
|Toggle header code file|**Ctrl+K, Ctrl+O** (letter 'O')| EditorContextMenus.CodeWindow.ToggleHeaderCodeFile |
|View call hierarchy|**Ctrl+K, Ctrl+T**<br /><br /> or<br /><br /> **Ctrl+K, T**| EditorContextMenus.CodeWindow.ViewCallHierarchy |

### <a name="bkmk_file-global-shortcuts"></a> File: global shortcuts

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Exit|**Alt+F4**| File.Exit |
|New file|**Ctrl+N**| File.NewFile |
|New project|**Ctrl+Shift+N**| File.NewProject |
|New web site|**Shift+Alt+N**| File.NewWebSite |
|Open file|**Ctrl+O** (letter 'O')| File.OpenFile |
|Open project|**Ctrl+Shift+O** (letter 'O')| File.OpenProject |
|Open web site|**Shift+Alt+O** (letter 'O')| File.OpenWebSite |
|Print|**Ctrl+P**| File.Print |
|Save all|**Ctrl+Shift+S**| File.SaveAll |
|Save selected items|**Ctrl+S**| File.SaveSelectedItems |
|View in browser|**Ctrl+Shift+W**| File.ViewinBrowser |

### <a name="bkmk_help-global-shortcuts"></a> Help: global shortcuts

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Add  and remove help content|**Ctrl+Alt+F1**| Help.AddandRemoveHelpContent |
|F1 help|**F1**| Help.F1Help |
|View help|**Ctrl+F1**| Help.ViewHelp |
|Window help|**Shift+F1**| Help.WindowHelp |

### <a name="bkmk_loadtest-global-shortcuts"></a> Load Test: global shortcuts

|Command|Keyboard shortcut|Command ID|
|-|-|-|
|Jump to counter pane|**Ctrl+R, Q**| LoadTest.JumpToCounterPane |

### <a name="bkmk_otherContext-global-shortcuts"></a> Other context menus: global shortcuts

|Command|Keyboard shortcut|Command ID|
|-|-|-|
|Add new diagram|**Insert**| OtherContextMenus.MicrosoftDataEntityDesignContext.AddNewDiagram |

### <a name="bkmk_project-global-shortcuts"></a> Project: global shortcuts

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Add existing item|**Shift+Alt+A**| Project.AddExistingItem |
|Add new item|**Ctrl+Shift+A**| Project.AddNewItem |
|Class wizard|**Ctrl+Shift+X**| Project.ClassWizard |
|Override|**Ctrl+Alt+Ins**| Project.Override |
|Preview changes|**Alt+;** then **Alt+C**| Project.Previewchanges |
|Publish selected files|**Alt+;** then **Alt+P**| Project.Publishselectedfiles |
|Replace selected files from server|**Alt+;** then **Alt+R**| Project.Replaceselectedfilesfromserver |

### <a name="bkmk_projectContext-global-shortcuts"></a> Project and Solution context menus: global shortcuts

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Move down|**Alt+Down Arrow**| ProjectandSolutionContextMenus.Item.MoveDown |
|Move up|**Alt+Up Arrow**| ProjectandSolutionContextMenus.Item.MoveUp |

### <a name="bkmk_refactor-global-shortcuts"></a> Refactor: global shortcuts

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Encapsulate field|**Ctrl+R, Ctrl+E**| Refactor.EncapsulateField |
|Extract interface|**Ctrl+R, Ctrl+I**| Refactor.ExtractInterface |
|Extract method|**Ctrl+R, Ctrl+M**| Refactor.ExtractMethod |
|Remove parameters|**Ctrl+R, Ctrl+V**| Refactor.RemoveParameters |
|Rename|**Ctrl+R, Ctrl+R**| Refactor.Rename |
|Reorder parameters|**Ctrl+R, Ctrl+O** (letter 'O')| Refactor.ReorderParameters |

### <a name="bkmk_solutionexplorerGLOBAL"></a> Solution Explorer: global shortcuts

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Open files filter|**Ctrl+[**, **O** (letter 'O')<br /><br /> or<br /><br /> **Ctrl+[**, **Ctrl+O** (letter 'O')| SolutionExplorer.OpenFilesFilter |
|Pending changes filter|**Ctrl+[**, **P**<br /><br /> or<br /><br /> **Ctrl+[**, **Ctrl+P**| SolutionExplorer.PendingChangesFilter |
|Sync with active document|**Ctrl+[**, **S**<br /><br /> or<br /><br /> **Ctrl+[**, **Ctrl+S**| SolutionExplorer.SyncWithActiveDocument |

### <a name="bkmk_team-global-shortcuts"></a> Team: global shortcuts

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Go to git branches|**Ctrl+0** (zero), **Ctrl+N**<br /><br /> or<br /><br /> **Ctrl+0, N**| Team.Git.GoToGitBranches |
|Go to git changes|**Ctrl+0** (zero), **Ctrl+G**<br /><br /> or<br /><br /> **Ctrl+0, G**| Team.Git.GoToGitChanges |
|Go to git commits|**Ctrl+0** (zero), **Ctrl+O** (letter 'O')<br /><br /> or<br /><br /> **Ctrl+0, O**| Team.Git.GoToGitCommits |
|Team explorer search|**Ctrl+'**| Team.TeamExplorerSearch |

### <a name="bkmk_TFcontext-global-shortcuts"></a> Team Foundation context menus: global shortcuts

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Go to builds|**Ctrl+0** (zero), **Ctrl+B**<br /><br /> or<br /><br /> **Ctrl+0, B**| TeamFoundationContextMenus.Commands.GoToBuilds |
|Go to connect|**Ctrl+0** (zero), **Ctrl+C**<br /><br /> or<br /><br /> **Ctrl+0, C**| TeamFoundationContextMenus.Commands.GoToConnect |
|Go to documents|**Ctrl+0** (zero), **Ctrl+D**<br /><br /> or<br /><br /> **Ctrl+0, D**| TeamFoundationContextMenus.Commands.GoToDocuments |
|Go to home|**Ctrl+0** (zero), **Ctrl+H**<br /><br /> or<br /><br /> **Ctrl+0, H**| TeamFoundationContextMenus.Commands.GoToHome |
|Go to my work|**Ctrl+0** (zero), **Ctrl+M**<br /><br /> or<br /><br /> **Ctrl+0, M**| TeamFoundationContextMenus.Commands.GoToMyWork |
|Go to pending changes|**Ctrl+0** (zero), **Ctrl+P**<br /><br /> or<br /><br /> **Ctrl+0, P**| TeamFoundationContextMenus.Commands.GoToPendingChanges |
|Go to reports|**Ctrl+0** (zero), **Ctrl+R**<br /><br /> or<br /><br /> **Ctrl+0, R**| TeamFoundationContextMenus.Commands.GoToReports |
|Go to settings|**Ctrl+0** (zero), **Ctrl+S**<br /><br /> or<br /><br /> **Ctrl+0, S**| TeamFoundationContextMenus.Commands.GoToSettings |
|Go to web access|**Ctrl+0** (zero), **Ctrl+A**<br /><br /> or<br /><br /> **Ctrl+0, A**| TeamFoundationContextMenus.Commands.GoToWebAccess |
|Go to work items|**Ctrl+0** (zero), **Ctrl+W**<br /><br /> or<br /><br /> **Ctrl+0, W**| TeamFoundationContextMenus.Commands.GoToWorkItems |

### <a name="bkmk_test-global-shortcuts"></a> Test: global shortcuts

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Use coded ui test builder|**Ctrl+\\, Ctrl+C**| Test.UseCodedUITestBuilder |
|Use existing action recording|**Ctrl+\\, Ctrl+A**| Test.UseExistingActionRecording |

### <a name="bkmk_testexplorerGLOBAL"></a> Test Explorer: global shortcuts

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Debug all tests|**Ctrl+R, Ctrl+A**| TestExplorer.DebugAllTests |
|Debug all tests in context|**Ctrl+R, Ctrl+T**| TestExplorer.DebugAllTestsInContext |
|Debug last run|**Ctrl+R, D**| TestExplorer.DebugLastRun |
|Repeat last run|**Ctrl+R, L**| TestExplorer.RepeatLastRun |
|Run all tests|**Ctrl+R, A**| TestExplorer.RunAllTests |
|Run all tests in context|**Ctrl+R, T**| TestExplorer.RunAllTestsInContext |
|Show test explorer|**Ctrl+E, T**| TestExplorer.ShowTestExplorer |
|Open tab|**Ctrl+E, L**| LiveUnitTesting.OpenTab |
|Code coverage results|**Ctrl+E, C**| Test.CodeCoverageResults |

### <a name="bkmk_tools-global-shortcuts"></a> Tools: global shortcuts

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Attach to process|**Ctrl+Alt+P**| Tools.AttachtoProcess |
|Code snippets manager|**Ctrl+K, Ctrl+B**| Tools.CodeSnippetsManager |
|Force gc|**Ctrl+Shift+Alt+F12, Ctrl+Shift+Alt+F12**| Tools.ForceGC |

### <a name="bkmk_view-global-shortcuts"></a> View: global shortcuts

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|All windows|**Shift+Alt+M**| View.AllWindows |
|Architecture explorer|**Ctrl+\\, Ctrl+R**| View.ArchitectureExplorer |
|Backward|**Alt+Left Arrow** (Functions differently from View.NavigateBackward in Text Editor)| View.Backward |
|Bookmark window|**Ctrl+K, Ctrl+W**| View.BookmarkWindow |
|Browse next|**Ctrl+Shift+1**| View.BrowseNext |
|Browse previous|**Ctrl+Shift+2**| View.BrowsePrevious |
|Call hierarchy|**Ctrl+Alt+K**| View.CallHierarchy |
|Class view|**Ctrl+Shift+C**| View.ClassView |
|Class view go to search combo|**Ctrl+K, Ctrl+V**| View.ClassViewGoToSearchCombo |
|Code definition window|**Ctrl+\\, D**<br /><br /> or<br /><br /> **Ctrl+\\, Ctrl+D**| View.CodeDefinitionWindow |
|Command window|**Ctrl+Alt+A**| View.CommandWindow |
|Data sources|**Shift+Alt+D**| View.DataSources |
|Document outline|**Ctrl+Alt+T**| View.DocumentOutline |
|Edit label|**F2**| View.EditLabel |
|Error list|**Ctrl+\\, E**<br /><br /> or<br /><br /> **Ctrl+\\, Ctrl+E**| View.ErrorList |
|F# interactive|**Ctrl+Alt+F**| View.F#Interactive |
|Find symbol results|**Ctrl+Alt+F12**| View.FindSymbolResults |
|Forward|**Alt+Right Arrow**  (Functions differently from View.NavigateForward in Text Editor)| View.Forward |
|Forward browse context|**Ctrl+Shift+7**| View.ForwardBrowseContext |
|Full screen|**Shift+Alt+Enter**| View.FullScreen |
|Navigate backward|**Ctrl+-**| View.NavigateBackward |
|Navigate forward|**Ctrl+Shift+-**| View.NavigateForward |
|Next error|**Ctrl+Shift+F12**| View.NextError |
|Notifications|**Ctrl+W, N**<br /><br /> or<br /><br /> **Ctrl+W, Ctrl+N**| View.Notifications |
|Object browser|**Ctrl+Alt+J**| View.ObjectBrowser |
|Object browser go to search combo|**Ctrl+K, Ctrl+R**| View.ObjectBrowserGoToSearchCombo |
|Output|**Ctrl+Alt+O** (letter 'O')| View.Output |
|Pop browse context|**Ctrl+Shift+8** (C++ only)| View.PopBrowseContext |
|Properties window|**F4**| View.PropertiesWindow |
|Property pages|**Shift+F4**| View.PropertyPages |
|Resource view|**Ctrl+Shift+E**| View.ResourceView |
|Server explorer|**Ctrl+Alt+S**| View.ServerExplorer |
|Show smart tag|**Shift+Alt+F10**<br /><br /> or<br /><br /> **Ctrl+.**| View.ShowSmartTag |
|Solution explorer|**Ctrl+Alt+L**| View.SolutionExplorer |
|SQL Server object explorer|**Ctrl+\\, Ctrl+S**| View.SQLServerObjectExplorer |
|Task list|**Ctrl+\\, T**<br /><br /> or<br /><br /> **Ctrl+\\, Ctrl+T**| View.TaskList |
|TFS team explorer|**Ctrl+\\, Ctrl+M**| View.TfsTeamExplorer |
|Toolbox|**Ctrl+Alt+X**| View.Toolbox |
|UML model explorer|**Ctrl+\\, Ctrl+U**| View.UMLModelExplorer |
|View code|**F7**| View.ViewCode |
|View designer|**Shift+F7**| View.ViewDesigner |
|Web browser|**Ctrl+Alt+R**| View.WebBrowser |
|Zoom in|**Ctrl+Shift+.**| View.ZoomIn |
|Zoom out|**Ctrl+Shift+,**| View.ZoomOut |
|Show Test Explorer|**Ctrl+E, T**| TestExplorer.ShowTestExplorer |

### <a name="bkmk_window-global-shortcuts"></a> Window: global shortcuts

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Activate document window|**Esc**| Window.ActivateDocumentWindow |
|Add tab to selection|**Ctrl+Shift+Alt+Space**| Window.AddTabtoSelection |
|Close document window|**Ctrl+F4**| Window.CloseDocumentWindow |
|Close tool window|**Shift+Esc**| Window.CloseToolWindow |
|Keep tab open|**Ctrl+Alt+Home**| Window.KeepTabOpen |
|Move  to navigation bar|**Ctrl+F2**| Window.MovetoNavigationBar |
|Next document window|**Ctrl+F6**| Window.NextDocumentWindow |
|Next document window nav|**Ctrl+Tab**| Window.NextDocumentWindowNav |
|Next pane|**Alt+F6**| Window.NextPane |
|Next split pane|**F6**| Window.NextSplitPane |
|Next tab|**Ctrl+Alt+PgDn**<br /><br /> or<br /><br /> **Ctrl+PgDn**| Window.NextTab |
|Next tab and add to selection|**Ctrl+Shift+Alt+PgDn**| Window.NextTabandAddtoSelection |
|Next tool window nav|**Alt+F7**| Window.NextToolWindowNav |
|Previous document window|**Ctrl+Shift+F6**| Window.PreviousDocumentWindow |
|Previous document window nav|**Ctrl+Shift+Tab**| Window.PreviousDocumentWindowNav |
|Previous pane|**Shift+Alt+F6**| Window.PreviousPane |
|Previous split pane|**Shift+F6**| Window.PreviousSplitPane |
|Previous tab|**Ctrl+Alt+PgUp**<br /><br /> or<br /><br /> **Ctrl+PgUp**| Window.PreviousTab |
|Previous tab and add to selection|**Ctrl+Shift+Alt+PgUp**| Window.PreviousTabandAddtoSelection |
|Previous tool window nav|**Shift+Alt+F7**| Window.PreviousToolWindowNav |
|Quick launch|**Ctrl+Q**| Window.QuickLaunch |
|Quick launch previous category|**Ctrl+Shift+Q**| Window.QuickLaunchPreviousCategory |
|Show dock menu|**Alt+-**| Window.ShowDockMenu |
|Show Ex MDI file list|**Ctrl+Alt+Down Arrow**| Window.ShowEzMDIFileList |
|Solution explorer search|**Ctrl+;**| Window.SolutionExplorerSearch |
|Window search|**Alt+`**| Window.WindowSearch |

## Context-specific shortcuts
These keyboard shortcuts are context specific, which means that you can use them with menus and items in Visual Studio that are specific to a project type, programming language, or platform.

- [ADO.NET Entity Data Model Designer](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_adonet-entity-data-model-designer-context-specific-shortcuts)
- [Class Diagram](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_class-diagram-context-specific-shortcuts)
- [Coded UI Test Editor](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_coded-ui-test-editor-context-specific-shortcuts)
- [Dataset Editor](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_dataset-editor-context-specific-shortcuts)
- [Difference Viewer](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_difference-viewer-context-specific-shortcuts)
- [DOM Explorer](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_dom-explorer-context-specific-shortcuts)
- [F# Interactive](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_f-interactive-context-specific-shortcuts)
- [Graph Document Editor](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_graph-document-editor-context-specific-shortcuts)
- [Graphics Diagnostics](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_graphics-diagnostics-context-specific-shortcuts)
- [HTML Editor](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_html-editor-context-specific-shortcuts)
- [HTML Editor Design View](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_html-editor-design-view-context-specific-shortcuts)
- [HTML Editor Source View](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_html-editor-source-view-context-specific-shortcuts)
- [Layer Diagram](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_layer-diagram-context-specific-shortcuts)
- [Managed Resources Editor](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_managed-resources-editor-context-specific-shortcuts)
- [Merge Editor Window](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_merge-editor-window-context-specific-shortcuts)
- [Microsoft SQL Server Data Tools, Schema Compare](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_microsoft-sql-server-data-tools-schema-compare-context-specific-shortcuts)
- [Microsoft SQL Server Data Tools, Table Designer](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_microsoft-sql-server-data-tools-table-designer-context-specific-shortcuts)
- [Microsoft SQL Server Data Tools, T-SQL Editor](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_microsoft-sql-server-data-tools-t-sql-editor-context-specific-shortcuts)
- [Microsoft SQL Server Data Tools, T-SQL PDW Editor](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_microsoft-sql-server-data-tools-t-sql-pdw-editor-context-specific-shortcuts)
- [Page Inspector](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_page-inspector-context-specific-shortcuts)
- [Query Designer](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_query-designer-context-specific-shortcuts)
- [Query Results](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_query-results-context-specific-shortcuts)
- [Report Designer](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_report-designer-context-specific-shortcuts)
- [Sequence Diagram](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_sequence-diagram-context-specific-shortcuts)
- [Settings Designer](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_settings-designer-context-specific-shortcuts)
- [Solution Explorer](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_solution-explorer-context-specific-shortcuts)
- [Team Explorer](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_team-explorer-context-specific-shortcuts)
- [Test Explorer](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_test-explorer-context-specific-shortcuts)
- [Text Editor](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_text-editor-context-specific-shortcuts)
- [UML Activity Diagram](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_uml-activity-diagram-context-specific-shortcuts)
- [UML Class Diagram](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_uml-class-diagram-context-specific-shortcuts)
- [UML Component Diagram](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_uml-component-diagram-context-specific-shortcuts)
- [UML Use Case Diagram](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_uml-use-case-diagram-context-specific-shortcuts)
- [VC Accelerator Editor](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_vc-accelerator-editor-context-specific-shortcuts)
- [VC Dialog Editor](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_vc-dialog-editor-context-specific-shortcuts)
- [VC Image Editor](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_vc-image-editor-context-specific-shortcuts)
- [VC String Editor](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_vc-string-editor-context-specific-shortcuts)
- [View Designer](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_view-designer-context-specific-shortcuts)
- [Visual Studio](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_visual-studio-context-specific-shortcuts)
- [Windows Forms Designer](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_windows-forms-designer-context-specific-shortcuts)
- [Work Item Editor](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_work-item-editor-context-specific-shortcuts)
- [Work Item Query View](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_work-item-query-view-context-specific-shortcuts)
- [Work Item Results View](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_work-item-results-view-context-specific-shortcuts)
- [Workflow Designer](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_workflow-designer-context-specific-shortcuts)
- [XAML UI Designer](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_xaml-ui-designer-context-specific-shortcuts)
- [XML (Text) Editor](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_xml-text-editor-context-specific-shortcuts)
- [XML Schema Designer](../ide/default-keyboard-shortcuts-in-visual-studio.md#bkmk_xml-schema-designer-context-specific-shortcuts)

### <a name="bkmk_adonet-entity-data-model-designer-context-specific-shortcuts"></a> ADO.NET Entity Data Model Designer: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Down|**Alt+Down Arrow**| OtherContextMenus.MicrosoftDataEntityDesignContext.MoveProperties.Down |
|Down 5|**Alt+PgDn**| OtherContextMenus.MicrosoftDataEntityDesignContext.MoveProperties.Down5 |
|To bottom|**Alt+End**| OtherContextMenus.MicrosoftDataEntityDesignContext.MoveProperties.ToBottom |
|To top|**Alt+Home**| OtherContextMenus.MicrosoftDataEntityDesignContext.MoveProperties.ToTop |
|Up|**Alt+Up Arrow**| OtherContextMenus.MicrosoftDataEntityDesignContext.MoveProperties.Up |
|Up 5|**Alt+PgUp**| OtherContextMenus.MicrosoftDataEntityDesignContext.MoveProperties.Up5 |
|Rename|**Ctrl+R, R**| OtherContextMenus.MicrosoftDataEntityDesignContext.Refactor.Rename |
|Remove from diagram|**Shift+Del**| OtherContextMenus.MicrosoftDataEntityDesignContext.RemovefromDiagram |
|Entity data model browser|**Ctrl+1**| View.EntityDataModelBrowser |
|Entity data model mapping details|**Ctrl+2**| View.EntityDataModelMappingDetails |

### <a name="bkmk_class-diagram-context-specific-shortcuts"></a> Class diagram: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Collapse|**Num -**| ClassDiagram.Collapse |
|Expand|**Num +**| ClassDiagram.Expand |
|Delete|**Ctrl+Del**| Edit.Delete |
|Expand collapse base type list|**Shift+Alt+B**| Edit.ExpandCollapseBaseTypeList |
|Navigate to lollipop|**Shift+Alt+L**| Edit.NavigateToLollipop |
|Remove from diagram|**Delete**| Edit.RemovefromDiagram |
|View code|**Enter**| View.ViewCode |

### <a name="bkmk_coded-ui-test-editor-context-specific-shortcuts"></a> Coded UI Test Editor: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Copy reference to clipboard|**Ctrl+C**| OtherContextMenus.UITestEditorContextMenu.CopyReferencetoClipboard |
|Insert delay before|**Ctrl+Alt+D**| OtherContextMenus.UITestEditorContextMenu.InsertDelayBefore |
|Locate all|**Shift+Alt+L**| OtherContextMenus.UITestEditorContextMenu.LocateAll |
|Locate  the ui control|**Ctrl+Shift+L**| OtherContextMenus.UITestEditorContextMenu.LocatetheUIControl |
|Move code|**Ctrl+Alt+C**| OtherContextMenus.UITestEditorContextMenu.Movecode |
|Split into a new method|**Ctrl+Shift+T**| OtherContextMenus.UITestEditorContextMenu.Splitintoanewmethod |

### <a name="bkmk_dataset-editor-context-specific-shortcuts"></a> DataSet Editor: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Insert column|**Insert**| OtherContextMenus.ColumnContext.InsertColumn |
|Column|**Ctrl+L**| OtherContextMenus.DbTableContext.Add.Column |

### <a name="bkmk_difference-viewer-context-specific-shortcuts"></a> Difference Viewer: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Ignore trim whitespace|**Ctrl+\\, Ctrl+Spacebar**| Diff.IgnoreTrimWhitespace |
|Inline view|**Ctrl+\\, Ctrl+1**| Diff.InlineView |
|Left only view|**Ctrl+\\, Ctrl+3**| Diff.LeftOnlyView |
|Next difference|**F8**| Diff.NextDifference |
|Previous difference|**Shift+F8**| Diff.PreviousDifference |
|Right only view|**Ctrl+\\, Ctrl+4**| Diff.RightOnlyView |
|Side by side view|**Ctrl+\\, Ctrl+2**| Diff.SideBySideView |
|Switch between left and right|**Ctrl+\\, Ctrl+Tab**| Diff.SwitchBetweenLeftAndRight |
|Synchronize view toggle|**Ctrl+\\, Ctrl+Down Arrow**| Diff.SynchronizeViewToggle |
|Add comment|**Ctrl+Shift+K**| EditorContextMenus.CodeWindow.AddComment |
|Edit local file|**Ctrl+Shift+P**| EditorContextMenus.CodeWindow.EditLocalFile |

### <a name="bkmk_dom-explorer-context-specific-shortcuts"></a> DOM Explorer: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Refresh|**F5**| DOMExplorer.Refresh |
|Select element|**Ctrl+B**| DOMExplorer.SelectElement |
|Show layout|**Ctrl+Shift+I**| DOMExplorer.ShowLayout |

### <a name="bkmk_f-interactive-context-specific-shortcuts"></a> F# Interactive: context specific shortcuts

The shortcuts specific to this context are:

|Command|Keyboard shortcut|Command ID|
|-|-|-|
|Cancel interactive evaluation|**Ctrl+Break**| OtherContextMenus.FSIConsoleContext.CancelInteractiveEvaluation |

### <a name="bkmk_graph-document-editor-context-specific-shortcuts"></a> Graph Document Editor: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Add node|**Insert**| ArchitectureContextMenus.DirectedGraphContextMenu.Advanced.Add.AddNode |
|Both dependencies|**B**| ArchitectureContextMenus.DirectedGraphContextMenu.Advanced.Select.BothDependencies |
|Incoming dependencies|**I**| ArchitectureContextMenus.DirectedGraphContextMenu.Advanced.Select.IncomingDependencies |
|Outgoing dependencies|**O**| ArchitectureContextMenus.DirectedGraphContextMenu.Advanced.Select.OutgoingDependencies |
|New comment|**Ctrl+Shift+K**<br /><br /> or<br /><br /> **Ctrl+E, C**| ArchitectureContextMenus.DirectedGraphContextMenu.NewComment |
|Remove|**Delete**| ArchitectureContextMenus.DirectedGraphContextMenu.Remove |
|Rename|**F2**| ArchitectureContextMenus.DirectedGraphContextMenu.Rename |

### <a name="bkmk_graphics-diagnostics-context-specific-shortcuts"></a> Graphics Diagnostics: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Capture frame|None| Debug.Graphics.CaptureFrame |
|Move pixel selection down|**Shift+Alt+Down Arrow**| Graphics.MovePixelSelectionDown |
|Move pixel selection left|**Shift+Alt+Left Arrow**| Graphics.MovePixelSelectionLeft |
|Move pixel selection right|**Shift+Alt+Right Arrow**| Graphics.MovePixelSelectionRight |
|Move pixel selection up|**Shift+Alt+Up Arrow**| Graphics.MovePixelSelectionUp |
|Zoom to actual size|**Shift+Alt+0** (zero)| Graphics.ZoomToActualSize |
|Zoom to fit in window|**Shift+Alt+9**| Graphics.ZoomToFitInWindow |
|Zoom in|**Shift+Alt+=**| Graphics.ZoomIn |
|Zoom out|**Shift+Alt+-**| Graphics.ZoomOut |

### <a name="bkmk_html-editor-context-specific-shortcuts"></a> HTML Editor: context specific shortcuts

The shortcuts specific to this context are:

|Command|Keyboard shortcut|Command ID|
|-|-|-|
|Go to controller|**Ctrl+M, Ctrl+G**| OtherContextMenus.HTMLContext.GoToController |

### <a name="bkmk_html-editor-design-view-context-specific-shortcuts"></a> HTML Editor Design View: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Move control down|**Ctrl+Down Arrow**| Edit.MoveControlDown |
|Move control up|**Ctrl+Up Arrow**| Edit.MoveControlUp |
|Bold|**Ctrl+B**| Format.Bold |
|Convert  to hyperlink|**Ctrl+L**| Format.ConverttoHyperlink |
|Insert bookmark|**Ctrl+Shift+L**| Format.InsertBookmark |
|Italic|**Ctrl+I**| Format.Italic |
|Underline|**Ctrl+U**| Format.Underline |
|Add content page|**Ctrl+M, Ctrl+C**| Project.AddContentPage |
|Column  to  the left|**Ctrl+Alt+Left Arrow**| Table.ColumntotheLeft |
|Column  to  the right|**Ctrl+Alt+Right Arrow**| Table.ColumntotheRight |
|Row above|**Ctrl+Alt+Up Arrow**| Table.RowAbove |
|Row below|**Ctrl+Alt+Down Arrow**| Table.RowBelow |
|Net nonvisual controls|**Ctrl+Shift+N**| View.ASP.NETNonvisualControls |
|Edit master|**Ctrl+M, Ctrl+M**| View.EditMaster |
|Next view|**Ctrl+PgDn**| View.NextView |
|Show smart tag|**Shift+Alt+F10**| View.ShowSmartTag |
|View markup|**Shift+F7**| View.ViewMarkup |
|Previous tab|**Ctrl+PgUp**| Window.PreviousTab |

### <a name="bkmk_html-editor-source-view-context-specific-shortcuts"></a> HTML Editor Source View: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Go to controller|**Ctrl+M, Ctrl+G**| OtherContextMenus.HTMLContext.GoToController |
|Next view|**Ctrl+PgDn**| View.NextView |
|Synchronize views|**Ctrl+Shift+Y**| View.SynchronizeViews |
|View designer|**Shift+F7**| View.ViewDesigner |
|Previous tab|**Ctrl+PgUp**| Window.PreviousTab |

### <a name="bkmk_layer-diagram-context-specific-shortcuts"></a> Layer diagram: context specific shortcuts

The shortcuts specific to this context are:

|Command|Keyboard shortcut|Command ID|
|-|-|-|
|Delete|**Shift+Delete**| Edit.Delete |

### <a name="bkmk_managed-resources-editor-context-specific-shortcuts"></a> Managed Resources Editor: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Edit cell|**F2**| Edit.EditCell |
|Remove|**Delete**| Edit.Remove |
|Remove row|**Ctrl+Delete**| Edit.RemoveRow |
|Selection cancel|**Escape**| Edit.SelectionCancel |
|Audio|**Ctrl+4**| Resources.Audio |
|Files|**Ctrl+5**| Resources.Files |
|Icons|**Ctrl+3**| Resources.Icons |
|Images|**Ctrl+2**| Resources.Images |
|Other|**Ctrl+6**| Resources.Other |
|Strings|**Ctrl+1**| Resources.Strings |

### <a name="bkmk_merge-editor-window-context-specific-shortcuts"></a> Merge Editor Window: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Set focus on left window|**Alt+1**| TeamFoundationContextMenus.MergeContextMenu.SetFocusonLeftWindow |
|Set focus on result window|**Alt+2**| TeamFoundationContextMenus.MergeContextMenu.SetFocusonResultWindow |
|Set focus on right window|**Alt+3**| TeamFoundationContextMenus.MergeContextMenu.SetFocusonRightWindow |

### <a name="bkmk_microsoft-sql-server-data-tools-schema-compare-context-specific-shortcuts"></a> Microsoft SQL Server Data Tools, Schema Compare: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|SSDT schema compare compare|**Shift+Alt+C**| SQL.SSDTSchemaCompareCompare |
|SSDT schema compare generate script|**Shift+Alt+G**| SQL.SSDTSchemaCompareGenerateScript |
|SSDT schema compare next change|**Shift+Alt+.**| SQL.SSDTSchemaCompareNextChange |
|SSDT schema compare previous change|**Shift+Alt+,**| SQL.SSDTSchemaComparePreviousChange |
|SSDT schema compare stop|**Alt+Break**| SQL.SSDTSchemaCompareStop |
|SSDT schema compare write updates|**Shift+Alt+U**| SQL.SSDTSchemaCompareWriteUpdates |

### <a name="bkmk_microsoft-sql-server-data-tools-table-designer-context-specific-shortcuts"></a> Microsoft SQL Server Data Tools, Table Designer: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Commit all edits|**Shift+Alt+U**|CommitAllEdits |
|Expand wildcards|**Ctrl+R, E**<br /><br /> or<br /><br /> **Ctrl+R, Ctrl+E**| SQL.ExpandWildcards |
|Fully qualify names|**Ctrl+R, Q**<br /><br /> or<br /><br /> **Ctrl+R, Ctrl+Q**| SQL.FullyqualifyNames |
|Move to schema|**Ctrl+R, M**<br /><br /> or<br /><br /> **Ctrl+R, Ctrl+M**| SQL.MovetoSchema |
|Rename|**F2**<br /><br /> or<br /><br /> **Ctrl+R, R**<br /><br /> or<br /><br /> **Ctrl+R, Ctrl+R**| SQL.Rename |
|View file in Script Panel|**Shift+Alt+PgDn**| ViewFileInScriptPanel |

### <a name="bkmk_microsoft-sql-server-data-tools-t-sql-editor-context-specific-shortcuts"></a> Microsoft SQL Server Data Tools, T-SQL Editor: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Commit all edits|**Shift+Alt+U**|CommitAllEdits |
|Execute with debugger|**Alt+F5**| SQL.ExecuteWithDebugger |
|Expand wildcards|**Ctrl+R, E**<br /><br /> or<br /><br /> **Ctrl+R, Ctrl+E**| SQL.ExpandWildcards |
|Fully qualify names|**Ctrl+R, Q**<br /><br /> or<br /><br /> **Ctrl+R, Ctrl+Q**| SQL.FullyqualifyNames |
|Move  to schema|**Ctrl+R, M**<br /><br /> or<br /><br /> **Ctrl+R, Ctrl+M**| SQL.MovetoSchema |
|Rename|**F2**<br /><br /> or<br /><br /> **Ctrl+R, R**<br /><br /> or<br /><br /> **Ctrl+R, Ctrl+R**| SQL.Rename |
|T SQL editor cancel query|**Alt+Break**| SQL.TSqlEditorCancelQuery |
|T SQL editor execute query|**Ctrl+Shift+E**| SQL.TSqlEditorExecuteQuery |
|T SQL editor results as file|**Ctrl+D, F**| SQL.TSqlEditorResultsAsFile |
|T SQL editor results as grid|**Ctrl+D, G**| SQL.TSqlEditorResultsAsGrid |
|T SQL editor results as text|**Ctrl+D, T**| SQL.TSqlEditorResultsAsText |
|T SQL editor show estimated plan|**Ctrl+D, E**| SQL.TSqlEditorShowEstimatedPlan |
|T SQL editor toggle execution plan|**Ctrl+D, A**| SQL.TSqlEditorToggleExecutionPlan |
|T SQL editor toggle results pane|**Ctrl+D, R**| SQL.TSqlEditorToggleResultsPane |
|T SQL editor clone query|**Ctrl+Alt+N**|SQL.TSqlEditorCloneQuery |
|T SQL editor database combo|**Shift+Alt+PgDn**|SQL.TSqlEditorDatabaseCombo |

### <a name="bkmk_microsoft-sql-server-data-tools-t-sql-pdw-editor-context-specific-shortcuts"></a> Microsoft SQL Server Data Tools, T-SQL PDW Editor: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|T SQL editor cancel query|**Alt+Break**| SQL.TSqlEditorCancelQuery |
|T SQL editor execute query|**Ctrl+Shift+E**| SQL.TSqlEditorExecuteQuery |
|T SQL editor results as file|**Ctrl+D, F**| SQL.TSqlEditorResultsAsFile |
|T SQL editor results as grid|**Ctrl+D, G**| SQL.TSqlEditorResultsAsGrid |
|T SQL editor results as text|**Ctrl+D, T**| SQL.TSqlEditorResultsAsText |
|T SQL editor show estimated plan|**Ctrl+D, E**| SQL.TSqlEditorShowEstimatedPlan |
|T SQL editor toggle execution plan|**Ctrl+D, A**| SQL.TSqlEditorToggleExecutionPlan |
|T SQL editor toggle results pane|**Ctrl+D, R**| SQL.TSqlEditorToggleResultsPane |
|T SQL editor clone query|**Ctrl+Alt+N**|SQL.TSqlEditorCloneQuery |
|T SQL editor clone query|**Shift+Alt+PgDn**|SQL.TSqlEditorCloneQuery |

### <a name="bkmk_page-inspector-context-specific-shortcuts"></a> Page Inspector: context specific shortcuts

The shortcuts specific to this context are:

|Command|Keyboard shortcut|Command ID|
|-|-|-|
|Minimize|**F12**| PageInspector.Minimize |

### <a name="bkmk_query-designer-context-specific-shortcuts"></a> Query Designer: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Cancel retrieving data|**Ctrl+T**| QueryDesigner.CancelRetrievingData |
|Criteria|**Ctrl+2**| QueryDesigner.Criteria |
|Diagram|**Ctrl+1**| QueryDesigner.Diagram |
|Execute SQL|**Ctrl+R**| QueryDesigner.ExecuteSQL |
|Goto row|**Ctrl+G**| QueryDesigner.GotoRow |
|Join mode|**Ctrl+Shift+J**| QueryDesigner.JoinMode |
|Results|**Ctrl+4**| QueryDesigner.Results |
|Sql|**Ctrl+3**| QueryDesigner.SQL |

### <a name="bkmk_query-results-context-specific-shortcuts"></a> Query results: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Query results new row|**Alt+End**| SQL.QueryResultsNewRow |
|Query results refresh|**Shift+Alt+R**| SQL.QueryResultsRefresh |
|Query results stop|**Alt+Break**| SQL.QueryResultsStop |

### <a name="bkmk_report-designer-context-specific-shortcuts"></a> Report Designer: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Break line|**Enter**| Edit.BreakLine |
|Char left|**Left Arrow**| Edit.CharLeft |
|Char left extend|**Shift+Left Arrow**| Edit.CharLeftExtend |
|Char right|**Right Arrow**| Edit.CharRight |
|Char right extend|**Shift+Right Arrow**| Edit.CharRightExtend |
|Insert tab|**Tab**| Edit.InsertTab |
|Line down|**Down Arrow**| Edit.LineDown |
|Line down extend|**Shift+Down Arrow**| Edit.LineDownExtend |
|Line up|**Up Arrow**| Edit.LineUp |
|Line up extend|**Shift+Up Arrow**| Edit.LineUpExtend |
|Move control down|**Ctrl+Down Arrow**| Edit.MoveControlDown |
|Move control left|**Ctrl+Left Arrow**| Edit.MoveControlLeft |
|Move control right|**Ctrl+Right Arrow**| Edit.MoveControlRight |
|Move control up|**Ctrl+Up Arrow**| Edit.MoveControlUp |
|Selection cancel|**Esc**| Edit.SelectionCancel |
|Size control down|**Ctrl+Shift+Down Arrow**| Edit.SizeControlDown |
|Size control left|**Ctrl+Shift+Left Arrow**| Edit.SizeControlLeft |
|Size control right|**Ctrl+Shift+Right Arrow**| Edit.SizeControlRight |
|Size control up|**Ctrl+Shift+Up Arrow**| Edit.SizeControlUp |
|Tab left|**Shift+Tab**| Edit.TabLeft |
|Report data|**Ctrl+Alt+D**| View.ReportData |

### <a name="bkmk_sequence-diagram-context-specific-shortcuts"></a> Sequence diagram: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Navigate to code|**F12**| ArchitectureDesigner.Sequence.NavigateToCode |
|Delete|**Shift+Del**| Edit.Delete |

### <a name="bkmk_settings-designer-context-specific-shortcuts"></a> Settings Designer: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Edit cell|**F2**| Edit.EditCell |
|Remove row|**Ctrl+Delete**| Edit.RemoveRow |
|Selection cancel|**Esc**| Edit.SelectionCancel |
|View code|**F7**| View.ViewCode |

### <a name="bkmk_solution-explorer-context-specific-shortcuts"></a> Solution Explorer: context specific shortcuts

The shortcuts specific to this context are:

|Command|Keyboard shortcut|Command ID|
|-|-|-|
|View in page inspector|**Ctrl+K, Ctrl+G**| ClassViewContextMenus.ClassViewProject.View.ViewinPageInspector |
|Quick add new item or class|**Shift+F2**| AddQuickFile |

### <a name="bkmk_team-explorer-context-specific-shortcuts"></a> Team Explorer: context specific shortcuts

The shortcuts specific to this context are:

|Command|Keyboard Shortcut|Command ID|
|-|-|-|
|Delete|**Delete**| Edit.Delete |
|Rename|**F2**| File.Rename |
|Go to team explorer navigation|**Alt+Home**| TeamFoundationContextMenus.Commands.GoToTeamExplorerNavigation |
|Go to team explorer next section content|**Alt+Down Arrow**| TeamFoundationContextMenus.Commands.GoToTeamExplorerNextSectionContent |
|Go to team explorer page content|**Alt+0** (zero)| TeamFoundationContextMenus.Commands.GoToTeamExplorerPageContent |
|Go to team explorer previous section content|**Alt+Up Arrow**| TeamFoundationContextMenus.Commands.GoToTeamExplorerPreviousSectionContent |
|Go to team explorer section 1 content|**Alt+1**| TeamFoundationContextMenus.Commands.GoToTeamExplorerSection1Content |
|Go to team explorer section 2 content|**Alt+2**| TeamFoundationContextMenus.Commands.GoToTeamExplorerSection2Content |
|Go to team explorer section 3 content|**Alt+3**| TeamFoundationContextMenus.Commands.GoToTeamExplorerSection3Content |
|Go to team explorer section 4 content|**Alt+4**| TeamFoundationContextMenus.Commands.GoToTeamExplorerSection4Content |
|Go to team explorer section 5 content|**Alt+5**| TeamFoundationContextMenus.Commands.GoToTeamExplorerSection5Content |
|Go to team explorer section 6 content|**Alt+6**| TeamFoundationContextMenus.Commands.GoToTeamExplorerSection6Content |
|Go to team explorer section 7 content|**Alt+7**| TeamFoundationContextMenus.Commands.GoToTeamExplorerSection7Content |
|Go to team explorer section 8 content|**Alt+8**| TeamFoundationContextMenus.Commands.GoToTeamExplorerSection8Content |
|Go to team explorer section 9 content|**Alt+9**| TeamFoundationContextMenus.Commands.GoToTeamExplorerSection9Content |
|Team explorer navigate backward|**Alt+Left Arrow**| TeamFoundationContextMenus.Commands.TeamExplorerNavigateBackward |
|Team explorer navigate forward|**Alt+Right Arrow**| TeamFoundationContextMenus.Commands.TeamExplorerNavigateForward |
|TFS context my work page create copy wi|**Shift+Alt+C**| TeamFoundationContextMenus.MyWorkPageInProgress.TfsContextMyWorkPageCreateCopyWI |
|TFS context my work page new linked wi|**Shift+Alt+L**| TeamFoundationContextMenus.MyWorkPageInProgress.TfsContextMyWorkPageNewLinkedWI |
|Refresh|**F5**| View.Refresh |

### <a name="bkmk_test-explorer-context-specific-shortcuts"></a> Test Explorer: context specific shortcuts

The shortcuts specific to this context are:

|Command|Keyboard shortcut|Command ID|
|-|-|-|
|Open test|**F12**| TestExplorer.OpenTest |

### <a name="bkmk_text-editor-context-specific-shortcuts"></a> Text Editor: context specific shortcuts

The shortcuts specific to this context are:

| Commands | Keyboard shortcuts |Command ID|
|-|-|-|
|Break line| **Enter**<br /><br /> or<br /><br /> **Shift+Enter** | Edit.BreakLine |
|Char left| **Left Arrow** | Edit.CharLeft |
|Char left extend| **Shift+Left Arrow** | Edit.CharLeftExtend |
|Char left extend column| **Shift+Alt+Left Arrow** | Edit.CharLeftExtendColumn |
|Char right| **Right Arrow** | Edit.CharRight |
|Char right extend| **Shift+Right Arrow** | Edit.CharRightExtend |
|Char right extend column| **Shift+Alt+Right Arrow** | Edit.CharRightExtendColumn |
|Clear bookmarks| **Ctrl+K, Ctrl+L** | Edit.ClearBookmarks |
|Collapse all outlining| **Ctrl+M, Ctrl+A** | Edit.CollapseAllOutlining |
|Collapse current region| **Ctrl+M, Ctrl+S** | Edit.CollapseCurrentRegion |
|Collapse tag| **Ctrl+M, Ctrl+T** | Edit.CollapseTag |
|Collapse to definitions| **Ctrl+M, Ctrl+O** (letter 'O') | Edit.CollapseToDefinitions |
|Contract selection| **Shift+Alt+-** | Edit.ContractSelection |
|Comment selection| **Ctrl+K, Ctrl+C** | Edit.CommentSelection |
|Complete word| **Ctrl+Space**<br /><br /> or<br /><br /> **Alt+Right Arrow** | Edit.CompleteWord |
|Copy parameter tip| **Ctrl+Shift+Alt+C** | Edit.CopyParameterTip |
|Decrease filter level| **Alt+,** | Edit.DecreaseFilterLevel |
|Delete backwards| **Backspace**<br /><br /> or<br /><br /> **Shift+Bkspce** | Edit.DeleteBackwards |
|Delete horizontal white space| **Ctrl+K, Ctrl+\\** | Edit.DeleteHorizontalWhiteSpace |
|Document end| **Ctrl+End** | Edit.DocumentEnd |
|Document end extend| **Ctrl+Shift+End** | Edit.DocumentEndExtend |
|Document start| **Ctrl+Home** | Edit.DocumentStart |
|Document start extend| **Ctrl+Shift+Home** | Edit.DocumentStartExtend |
|Expand all outlining| **Ctrl+M, Ctrl+X** | Edit.ExpandAllOutlining |
|Expand current region| **Ctrl+M, Ctrl+E** | Edit.ExpandCurrentRegion |
|Expand selection| **Shift+Alt+=** | Edit.ExpandSelection |
|Expand selection to containing block| **Shift+Alt+]** | Edit.ExpandSelectiontoContainingBlock |
|Format document| **Ctrl+K, Ctrl+D** | Edit.FormatDocument |
|Format selection| **Ctrl+K, Ctrl+F** | Edit.FormatSelection |
|Goto all| **Ctrl+T**<br /><br /> or<br /><br /> **Ctrl+,** | Edit.GotoAll |
|Goto brace| **Ctrl+]** | Edit.GotoBrace |
|Goto brace extend| **Ctrl+Shift+]** | Edit.GotoBraceExtend |
|Goto recent| **Ctrl+T,R** | Edit.GotoRecent |
|Goto next issue in file| **Alt+PgDn** | Edit.GotoNextIssueinFile |
|Goto previous issue in file| **Alt+PgUp** | Edit.GotoPreviousIssueinFile |
|Hide selection| **Ctrl+M, Ctrl+H** | Edit.HideSelection |
|Increase filter level| **Alt+.** | Edit.IncreaseFilterLevel |
|Incremental search| **Ctrl+I** | Edit.IncrementalSearch |
|Insert carets at all matching| **Shift+Alt+;** | Edit.InsertCaretsatAllMatching |
|Insert next matching caret| **Shift+Alt+.** | Edit.InsertNextMatchingCaret |
|Insert tab| **Tab** | Edit.InsertTab |
|Line cut| **Ctrl+L** | Edit.LineCut |
|Line delete| **Ctrl+Shift+L** | Edit.LineDelete |
|Line down| **Down Arrow** | Edit.LineDown |
|Line down extend| **Shift+Down Arrow** | Edit.LineDownExtend |
|Line down extend column| **Shift+Alt+Down Arrow** | Edit.LineDownExtendColumn |
|Line end| **End** | Edit.LineEnd |
|Line end extend| **Shift+End** | Edit.LineEndExtend |
|Line end extend column| **Shift+Alt+End** | Edit.LineEndExtendColumn |
|Line open above| **Ctrl+Enter** | Edit.LineOpenAbove |
|Line open below| **Ctrl+Shift+Enter** | Edit.LineOpenBelow |
|Line start| **Home** | Edit.LineStart |
|Line start extend| **Shift+Home** | Edit.LineStartExtend |
|Line start extend column| **Shift+Alt+Home** | Edit.LineStartExtendColumn |
|Line transpose| **Shift+Alt+T** | Edit.LineTranspose |
|Line up| **Up Arrow** | Edit.LineUp |
|Line up extend| **Shift+Up Arrow** | Edit.LineUpExtend |
|Line up extend column| **Shift+Alt+Up Arrow** | Edit.LineUpExtendColumn |
|List members| **Ctrl+J** | Edit.ListMembers |
|Make lowercase| **Ctrl+U** | Edit.MakeLowercase |
|Make uppercase| **Ctrl+Shift+U** | Edit.MakeUppercase |
|Move selected lines down| **Alt+Down Arrow** | Edit.MoveSelectedLinesDown |
|Move selected lines up| **Alt+Up Arrow** | Edit.MoveSelectedLinesUp |
|Next highlighted reference| **Ctrl+Shift+Down Arrow** | Edit.NextHighlightedReference |
|Overtype mode| **Insert** | Edit.OvertypeMode |
|Page down| **PgDn** | Edit.PageDown |
|Page down extend| **Shift+PgDn** | Edit.PageDownExtend |
|Page up| **PgUp** | Edit.PageUp |
|Page up extend| **Shift+PgUp** | Edit.PageUpExtend |
|Parameter info| **Ctrl+Shift+Spacebar** | Edit.ParameterInfo |
|Paste parameter tip| **Ctrl+Shift+Alt+P** | Edit.PasteParameterTip |
|Peek backward| **Ctrl+Alt+-** | Edit.PeekBackward |
|Peek definition| **Alt+F12** | Edit.PeekDefinition |
|Peek forward| **Ctrl+Alt+=** | Edit.PeekForward |
|Previous highlighted reference| **Ctrl+Shift+Up Arrow** | Edit.PreviousHighlightedReference |
|Quick info| **Ctrl+K, Ctrl+I** | Edit.QuickInfo |
|Reverse incremental search| **Ctrl+Shift+I** | Edit.ReverseIncrementalSearch |
|Scroll line down| **Ctrl+Down Arrow** | Edit.ScrollLineDown |
|Scroll line up| **Ctrl+Up Arrow** | Edit.ScrollLineUp |
|Select current word| **Ctrl+W** | Edit.SelectCurrentWord |
|Selection cancel| **Escape** | Edit.SelectionCancel |
|Select to last go back| **Ctrl+=** | Edit.SelectToLastGoBack |
|Show code lens menu| **Ctrl+K, Ctrl+\`** | Edit.ShowCodeLensMenu |
|Show navigate menu| **Alt+\`** | Edit.ShowNavigateMenu |
|Stop hiding current| **Ctrl+M, Ctrl+U** | Edit.StopHidingCurrent |
|Stop outlining| **Ctrl+M, Ctrl+P** | Edit.StopOutlining |
|Swap anchor| **Ctrl+K, Ctrl+A** | Edit.SwapAnchor |
|Tab left| **Shift+Tab** | Edit.TabLeft |
|Toggle all outlining| **Ctrl+M, Ctrl+L** | Edit.ToggleAllOutlining |
|Toggle bookmark| **Ctrl+K, Ctrl+K** | Edit.ToggleBookmark |
|Toggle completion mode| **Ctrl+Alt+Space** | Edit.ToggleCompletionMode |
|Toggle outlining expansion| **Ctrl+M, Ctrl+M** | Edit.ToggleOutliningExpansion |
|Toggle task list shortcut| **Ctrl+K, Ctrl+H** | Edit.ToggleTaskListShortcut |
|Toggle word wrap| **Ctrl+E, Ctrl+W** | Edit.ToggleWordWrap |
|Uncomment selection| **Ctrl+K, Ctrl+U** | Edit.UncommentSelection |
|View bottom| **Ctrl+PgDn** | Edit.ViewBottom |
|View bottom extend| **Ctrl+Shift+PgDn** | Edit.ViewBottomExtend |
|View top| **Ctrl+PgUp** | Edit.ViewTop |
|View top extend| **Ctrl+Shift+PgUp** | Edit.ViewTopExtend |
|View white space| **Ctrl+R, Ctrl+W** | Edit.ViewWhiteSpace |
|Word delete to end| **Ctrl+Delete** | Edit.WordDeleteToEnd |
|Word delete to start| **Ctrl+Backspace** | Edit.WordDeleteToStart |
|Word next| **Ctrl+Right Arrow** | Edit.WordNext |
|Word next extend| **Ctrl+Shift+Right Arrow** | Edit.WordNextExtend |
|Word next extend column| **Ctrl+Shift+Alt+Right Arrow** | Edit.WordNextExtendColumn |
|Word previous| **Ctrl+Left Arrow** | Edit.WordPrevious |
|Word previous extend| **Ctrl+Shift+Left Arrow** | Edit.WordPreviousExtend |
|Word previous extend column| **Ctrl+Shift+Alt+Left Arrow** | Edit.WordPreviousExtendColumn |
|Word transpose| **Ctrl+Shift+T** | Edit.WordTranspose |
|Execute in interactive| **Alt+Enter** | EditorContextMenus.CodeWindow.ExecuteInInteractive |
|Execute line in interactive| **Alt+'** | EditorContextMenus.CodeWindow.ExecuteLineInInteractive |
|View  in page inspector| **Ctrl+K, Ctrl+G** | OtherContextMenus.HTMLContext.ViewinPageInspector |
|TFS annotate move next region| **Alt+PgDn** | TeamFoundationContextMenus.Annotate.TfsAnnotateMoveNextRegion |
|TFS annotate move previous region| **Alt+PgUp** | TeamFoundationContextMenus.Annotate.TfsAnnotateMovePreviousRegion |

### <a name="bkmk_uml-activity-diagram-context-specific-shortcuts"></a> UML activity diagram: context specific shortcuts

The shortcuts specific to this context are:

|Command|Keyboard shortcut|Command ID|
|-|-|-|
|Delete|**Shift+Del**| Edit.Delete |

### <a name="bkmk_uml-class-diagram-context-specific-shortcuts"></a> UML class diagram: context specific shortcuts

The shortcuts specific to this context are:

|Command|Keyboard shortcut|Command ID|
|-|-|-|
|Delete from model|**Shift+Del**| Edit.DeleteFromModel |

### <a name="bkmk_uml-component-diagram-context-specific-shortcuts"></a> UML component diagram: context specific shortcuts

The shortcuts specific to this context are:

|Command|Keyboard shortcut|Command ID|
|-|-|-|
|Delete from model|**Shift+Del**| Edit.DeleteFromModel |

### <a name="bkmk_uml-use-case-diagram-context-specific-shortcuts"></a> UML use case diagram: context specific shortcuts

The shortcuts specific to this context are:

|Command|Keyboard shortcut|Command ID|
|-|-|-|
|Delete from model|**Shift+Del**| Edit.DeleteFromModel |

### <a name="bkmk_vc-accelerator-editor-context-specific-shortcuts"></a> VC Accelerator Editor: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|New accelerator|**Insert**| Edit.NewAccelerator |
|Next key typed|**Ctrl+W**| Edit.NextKeyTyped |

### <a name="bkmk_vc-dialog-editor-context-specific-shortcuts"></a> VC Dialog Editor: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Move control down|**Down Arrow**| Edit.MoveControlDown |
|Move control left|**Left Arrow**| Edit.MoveControlLeft |
|Move control right|**Right Arrow**| Edit.MoveControlRight |
|Move control up|**Up Arrow**| Edit.MoveControlUp |
|Scroll column left|**Ctrl+Left Arrow**| Edit.ScrollColumnLeft |
|Scroll column right|**Ctrl+Right Arrow**| Edit.ScrollColumnRight |
|Scroll line down|**Ctrl+Down Arrow**| Edit.ScrollLineDown |
|Scroll line up|**Ctrl+Up Arrow**| Edit.ScrollLineUp |
|Size control down|**Shift+Down Arrow**| Edit.SizeControlDown |
|Size control left|**Shift+Left Arrow**| Edit.SizeControlLeft |
|Size control right|**Shift+Right Arrow**| Edit.SizeControlRight |
|Size control up|**Shift+Up Arrow**| Edit.SizeControlUp |
|Align bottoms|**Ctrl+Shift+Down Arrow**| Format.AlignBottoms |
|Align centers|**Shift+F9**| Format.AlignCenters |
|Align lefts|**Ctrl+Shift+Left Arrow**| Format.AlignLefts |
|Align middles|**F9**| Format.AlignMiddles |
|Align rights|**Ctrl+Shift+Right Arrow**| Format.AlignRights |
|Align tops|**Ctrl+Shift+Up Arrow**| Format.AlignTops |
|Button bottom|**Ctrl+B**| Format.ButtonBottom |
|Button right|**Ctrl+R**| Format.ButtonRight |
|Center horizontal|**Ctrl+Shift+F9**| Format.CenterHorizontal |
|Center vertical|**Ctrl+F9**| Format.CenterVertical |
|Check mnemonics|**Ctrl+M**| Format.CheckMnemonics |
|Size to content|**Shift+F7**| Format.SizetoContent |
|Space across|**Alt+Right Arrow**<br /><br /> or<br /><br /> **Alt+Left Arrow**| Format.SpaceAcross |
|Space down|**Alt+Up Arrow**<br /><br /> or<br /><br /> **Alt+Down Arrow**| Format.SpaceDown |
|Tab order|**Ctrl+D**| Format.TabOrder |
|Test dialog|**Ctrl+T**| Format.TestDialog |
|Toggle guides|**Ctrl+G**| Format.ToggleGuides |

### <a name="bkmk_vc-image-editor-context-specific-shortcuts"></a> VC Image Editor: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Airbrush tool|**Ctrl+A**| Image.AirbrushTool |
|Brush tool|**Ctrl+B**| Image.BrushTool |
|Copy and outline selection|**Ctrl+Shift+U**| Image.CopyandOutlineSelection |
|Draw opaque|**Ctrl+J**| Image.DrawOpaque |
|Ellipse tool|**Alt+P**| Image.EllipseTool |
|Erase tool|**Ctrl+Shift+I**| Image.EraseTool |
|Filled ellipse tool|**Ctrl+Shift+Alt+P**| Image.FilledEllipseTool |
|Filled rectangle tool|**Ctrl+Shift+Alt+R**| Image.FilledRectangleTool |
|Filled rounded rectangle tool|**Ctrl+Shift+Alt+W**| Image.FilledRoundedRectangleTool |
|Fill tool|**Ctrl+F**| Image.FillTool |
|Flip horizontal|**Ctrl+H**| Image.FlipHorizontal |
|Flip vertical|**Shift+Alt+H**| Image.FlipVertical |
|Larger brush|**Ctrl+=**| Image.LargerBrush |
|Line tool|**Ctrl+L**| Image.LineTool |
|Magnification tool|**Ctrl+M**| Image.MagnificationTool |
|Magnify|**Ctrl+Shift+M**| Image.Magnify |
|New image type|**Insert**| Image.NewImageType |
|Next color|**Ctrl+]**<br /><br /> or<br /><br /> **Ctrl+Right Arrow**| Image.NextColor |
|Next right color|**Ctrl+Shift+]**<br /><br /> or<br /><br /> **Ctrl+Shift+Right Arrow**| Image.NextRightColor |
|Outlined ellipse tool|**Shift+Alt+P**| Image.OutlinedEllipseTool |
|Outlined rectangle tool|**Shift+Alt+R**| Image.OutlinedRectangleTool |
|Outlined rounded rectangle tool|**Shift+Alt+W**| Image.OutlinedRoundedRectangleTool |
|Pencil tool|**Ctrl+I**| Image.PencilTool |
|Previous color|**Ctrl+[**<br /><br /> or<br /><br /> **Ctrl+Left Arrow**| Image.PreviousColor |
|Previous right color|**Ctrl+Shift+[**<br /><br /> or<br /><br /> **Ctrl+Shift+Left Arrow**| Image.PreviousRightColor |
|Rectangle selection tool|**Shift+Alt+S**| Image.RectangleSelectionTool |
|Rectangle tool|**Alt+R**| Image.RectangleTool |
|Rotate 90 degrees|**Ctrl+Shift+H**| Image.Rotate90Degrees |
|Rounded rectangle tool|**Alt+W**| Image.RoundedRectangleTool |
|Show grid|**Ctrl+Alt+S**| Image.ShowGrid |
|Show tile grid|**Ctrl+Shift+Alt+S**| Image.ShowTileGrid |
|Small brush|**Ctrl+.**| Image.SmallBrush |
|Smaller brush|**Ctrl+-**| Image.SmallerBrush |
|Text tool|**Ctrl+T**| Image.TextTool |
|Use selection as brush|**Ctrl+U**| Image.UseSelectionasBrush |
|Zoom in|**Ctrl+Shift+.**<br /><br /> or<br /><br /> **Ctrl+Up Arrow**| Image.ZoomIn |
|Zoom out|**Ctrl+Shift+,**<br /><br /> or<br /><br /> **Ctrl+Down Arrow**| Image.ZoomOut |

### <a name="bkmk_vc-string-editor-context-specific-shortcuts"></a> VC String Editor: context specific shortcuts

The shortcuts specific to this context are:

|Command|Keyboard shortcut|Command ID|
|-|-|-|
|New string|**Insert**| Edit.NewString |

### <a name="bkmk_view-designer-context-specific-shortcuts"></a> View Designer: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Cancel retrieving data|**Ctrl+T**| QueryDesigner.CancelRetrievingData |
|Criteria|**Ctrl+2**| QueryDesigner.Criteria |
|Diagram|**Ctrl+1**| QueryDesigner.Diagram |
|Execute SQL|**Ctrl+R**| QueryDesigner.ExecuteSQL |
|Goto row|**Ctrl+G**| QueryDesigner.GotoRow |
|Join mode|**Ctrl+Shift+J**| QueryDesigner.JoinMode |
|Results|**Ctrl+4**| QueryDesigner.Results |
|Sql|**Ctrl+3**| QueryDesigner.SQL |

### <a name="bkmk_visual-studio-context-specific-shortcuts"></a> Visual Studio: context specific shortcuts

The shortcuts specific to this context are:

|Command|Keyboard shortcut|Command ID|
|-|-|-|
|Hide methods pane|**Ctrl+1**| OtherContextMenus.ORDesignerContext.HideMethodsPane |

### <a name="bkmk_windows-forms-designer-context-specific-shortcuts"></a> Windows Forms Designer: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Break line|**Enter**| Edit.BreakLine |
|Char left|**Left Arrow**| Edit.CharLeft |
|Char left extend|**Shift+Left Arrow**| Edit.CharLeftExtend |
|Char right|**Right Arrow**| Edit.CharRight |
|Char right extend|**Shift+Right Arrow**| Edit.CharRightExtend |
|Document end|**End**| Edit.DocumentEnd |
|Document end extend|**Shift+End**| Edit.DocumentEndExtend |
|Document start|**Home**| Edit.DocumentStart |
|Document start extend|**Shift+Home**| Edit.DocumentStartExtend |
|Insert tab|**Tab**| Edit.InsertTab |
|Line down|**Down Arrow**| Edit.LineDown |
|Line down extend|**Shift+Up Arrow**| Edit.LineDownExtend |
|Line up|**Up Arrow**| Edit.LineUp |
|Line up extend|**Shift+Down Arrow**| Edit.LineUpExtend |
|Move control down|**Ctrl+Down Arrow**| Edit.MoveControlDown |
|Move control left|**Ctrl+Left Arrow**| Edit.MoveControlLeft |
|Move control right|**Ctrl+Right Arrow**| Edit.MoveControlRight |
|Move control up|**Ctrl+Up Arrow**| Edit.MoveControlUp |
|Selection cancel|**Escape**| Edit.SelectionCancel |
|Size control down|**Ctrl+Shift+Down Arrow**| Edit.SizeControlDown |
|Size control left|**Ctrl+Shift+Left Arrow**| Edit.SizeControlLeft |
|Size control right|**Ctrl+Shift+Right Arrow**| Edit.SizeControlRight |
|Size control up|**Ctrl+Shift+Up Arrow**| Edit.SizeControlUp |
|Tab left|**Shift+Tab**| Edit.TabLeft |

### <a name="bkmk_work-item-editor-context-specific-shortcuts"></a> Work Item Editor: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Create copy of work item|**Shift+Alt+C**| Edit.CreateCopyofWorkItem |
|Refresh work item|**F5**| Edit.RefreshWorkItem |
|New linked work item|**Shift+Alt+L**| Team.NewLinkedWorkItem |

### <a name="bkmk_work-item-query-view-context-specific-shortcuts"></a> Work Item Query View: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Create copy of work item|**Shift+Alt+C**| Edit.CreateCopyofWorkItem |
|Indent|**Shift+Alt+Right Arrow**| Edit.Indent |
|Outdent|**Shift+Alt+Left Arrow**| Edit.Outdent |
|New linked work item|**Shift+Alt+L**| Team.NewLinkedWorkItem |
|Refresh|**F5**| Team.Refresh |
|Toggle|**Shift+Alt+V**| Window.Toggle |

### <a name="bkmk_work-item-results-view-context-specific-shortcuts"></a> Work Item Results View: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Create copy of work item|**Shift+Alt+C**| Edit.CreateCopyofWorkItem |
|Indent|**Shift+Alt+Right Arrow**| Edit.Indent |
|Outdent|**Shift+Alt+Left Arrow**| Edit.Outdent |
|Goto next work item|**Shift+Alt+N**| Team.GotoNextWorkItem |
|Goto previous work item|**Shift+Alt+P**| Team.GotoPreviousWorkItem |
|New linked work item|**Shift+Alt+L**| Team.NewLinkedWorkItem |
|Refresh|**F5**| Team.Refresh |
|Toggle|**Shift+Alt+V**| Window.Toggle |

### <a name="bkmk_workflow-designer-context-specific-shortcuts"></a> Workflow Designer: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Complete word|**Ctrl+K, W**<br /><br /> or<br /><br /> **Ctrl+K, Ctrl+W**<br /><br /> or<br /><br /> **Ctrl+Spacebar**<br /><br /> or<br /><br /> **Alt+Right Arrow**| Edit.CompleteWord |
|Decrease filter level|**Alt+,**| Edit.DecreaseFilterLevel |
|Increase filter level|**Alt+.**| Edit.IncreaseFilterLevel |
|List members|**Ctrl+K, L**<br /><br /> or<br /><br /> **Ctrl+K, Ctrl+L**<br /><br /> or<br /><br /> **Ctrl+J**| Edit.ListMembers |
|Parameter info|**Ctrl+K, P**<br /><br /> or<br /><br /> **Ctrl+K, Ctrl+P**<br /><br /> or<br /><br /> **Ctrl+Shift+Spacebar**| Edit.ParameterInfo |
|Quick info|**Ctrl+K, I**<br /><br /> or<br /><br /> **Ctrl+K, Ctrl+I**| Edit.QuickInfo |
|Collapse|**Ctrl+E, Ctrl+C**<br /><br /> or<br /><br /> **Ctrl+E, C**| WorkflowDesigner.Collapse |
|Collapse all|or| WorkflowDesigner.CollapseAll |
|Connect nodes|**Ctrl+E, Ctrl+F**<br /><br /> or<br /><br /> **Ctrl+E, F**| WorkflowDesigner.ConnectNodes |
|Create variable|**Ctrl+E, Ctrl+N**<br /><br /> or<br /><br /> **Ctrl+E, N**| WorkflowDesigner.CreateVariable |
|Expand all|**Ctrl+E, Ctrl+X**<br /><br /> or<br /><br /> **Ctrl+E, X**| WorkflowDesigner.ExpandAll |
|Expand in place|**Ctrl+E, Ctrl+E**<br /><br /> or<br /><br /> **Ctrl+E, E**| WorkflowDesigner.ExpandInPlace |
|Go to parent|**Ctrl+E, Ctrl+P**<br /><br /> or<br /><br /> **Ctrl+E, P**| WorkflowDesigner.GoToParent |
|Move focus|**Ctrl+E, Ctrl+M**<br /><br /> or<br /><br /> **Ctrl+E, M**| WorkflowDesigner.MoveFocus |
|Navigate through designer|**Ctrl+Alt+F6**| WorkflowDesigner.NavigateThroughDesigner |
|Restore|**Ctrl+E, Ctrl+R**<br /><br /> or<br /><br /> **Ctrl+E, R**| WorkflowDesigner.Restore |
|Show hide argument designer|**Ctrl+E, Ctrl+A**<br /><br /> or<br /><br /> **Ctrl+E, A**| WorkflowDesigner.ShowHideArgumentDesigner |
|Show hide imports designer|**Ctrl+E, Ctrl+I**<br /><br /> or<br /><br /> **Ctrl+E, I**| WorkflowDesigner.ShowHideImportsDesigner |
|Show hide overview map|**Ctrl+E, Ctrl+O** (letter 'O')<br /><br /> or<br /><br /> **Ctrl+E, O**| WorkflowDesigner.ShowHideOverviewMap |
|Show hide variable designer|**Ctrl+E, Ctrl+V**<br /><br /> or<br /><br /> **Ctrl+E, V**| WorkflowDesigner.ShowHideVariableDesigner |
|Toggle selection|**Ctrl+E, Ctrl+S**<br /><br /> or<br /><br /> **Ctrl+E, S**| WorkflowDesigner.ToggleSelection |
|Zoom in|**Ctrl+Num +**| WorkflowDesigner.ZoomIn |
|Zoom out|**Ctrl+Num -**| WorkflowDesigner.ZoomOut |

### <a name="bkmk_xaml-ui-designer-context-specific-shortcuts"></a> XAML UI Designer: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Fit all|**Ctrl+0** (zero)| Design.FitAll |
|Show handles|**F9**| Design.ShowHandles |
|Zoom in|**Ctrl+Alt+=**| Design.ZoomIn |
|Zoom out|**Ctrl+Alt+-**| Design.ZoomOut |
|Edit text|**F2**| Format.EditText |
|All|**Ctrl+Shift+R**| Format.ResetLayout.All |
|Run project code|**Ctrl+F9**| Design.RunProjectCode |
|Hide (Blend only)|**Ctrl+H**| Timeline.Hide (Blend only) |
|Lock (Blend only)|**Ctrl+L**| Timeline.Lock (Blend only) |
|Show (Blend only)|**Ctrl+Shift+H**| Timeline.Show (Blend only) |
|Unlock (Blend only)|**Ctrl+Shift+L**| Timeline.Unlock (Blend only) |
|Edge left move left|**Ctrl+Shift+,**| View.EdgeLeftMoveLeft |
|Edge left move right|**Ctrl+Shift+.**| View.EdgeLeftMoveRight |
|Edge right move left|**Ctrl+Shift+Alt+,**| View.EdgeRightMoveLeft |
|Edge right move right|**Ctrl+Shift+Alt+.**| View.EdgeRightMoveRight |
|Show property marker menu|**Ctrl+Spacebar**| View.ShowPropertyMarkerMenu |

For detailed info, see [Keyboard shortcuts for XAML Designer](../xaml-tools/keyboard-shortcuts-for-xaml-designer.md) and [Keyboard shortcuts in Blend for Visual Studio](../xaml-tools/keyboard-shortcuts-in-blend.md).

### <a name="bkmk_xml-text-editor-context-specific-shortcuts"></a> XML (Text) Editor: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Start XSLT debugging|**Alt+F5**| XML.StartXSLTDebugging |
|Start XSLT without debugging|**Ctrl+Alt+F5**| XML.StartXSLTWithoutDebugging |

### <a name="bkmk_xml-schema-designer-context-specific-shortcuts"></a> XML Schema Designer: context specific shortcuts

The shortcuts specific to this context are:

|Commands|Keyboard shortcuts|Command ID|
|-|-|-|
|Bottom to top|**Alt+Up Arrow**| GraphView.BottomtoTop |
|Left to right|**Alt+Right Arrow**| GraphView.LefttoRight |
|Right to left|**Alt+Left Arrow**| GraphView.RighttoLeft |
|Top to bottom|**Alt+Down Arrow**| GraphView.ToptoBottom |
|Remove from workspace|**Delete**| OtherContextMenus.GraphView.RemovefromWorkspace |
|Show content model view|**Ctrl+2**| XsdDesigner.ShowContentModelView |
|Show graph view|**Ctrl+3**| XsdDesigner.ShowGraphView |
|Show start view|**Ctrl+1**| XsdDesigner.ShowStartView |
