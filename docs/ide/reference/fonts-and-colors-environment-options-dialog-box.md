---
title: Fonts and Colors, Environment, Options dialog box
description: Learn how to use the Fonts and Colors page in the Environment section to establish a custom font and color scheme for various user interface elements in the IDE.
ms.date: 11/12/2024
ms.topic: reference
f1_keywords:
- VS.ToolsOptionsPages.FontsAndColors
- VS.ToolsOptionsPages.Environment.Fonts_And_Colors
- VS.Environment.Fonts And Colors
helpviewer_keywords:
- colors, customizing IDE
- Query and View Designer, customizing
- fonts, editors
- menus, customizing
- Table Designer, customizing
- Database Designer, customizing environment
- default colors
- accessibility, options
- editors, customizing
- designers, customizing environment
- defaults, colors
- printers, customizing
ms.custom: "ide-ref"
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Fonts and Colors, Environment, Options dialog box

The **Fonts and Colors** page of the **Options** dialog box lets you establish a custom font and color scheme for various user interface elements in the integrated development environment (IDE). You can access this dialog box by clicking **Tools** > **Options**, and then selecting **Environment** > **Fonts and Colors**.

Color scheme changes do not take effect during the session in which you make them. You can evaluate color changes by opening another instance of Visual Studio and producing the conditions under which you expect your changes to apply.

**Show settings for**

Lists all of the user interface elements for which you can change font and color schemes. After selecting an item from this list you can customize color settings for the item selected in **Display items**.

- **Text Editor**

     Changes to font style, size, and color display settings for Text Editor affect the appearance of text in your default text editor. Documents opened in a text editor outside the IDE will not be affected by these settings.

- **Printer and Cut/Copy**

     Changes to font style, size, and color display settings for Printer affect the appearance of text in printed documents.

    > [!NOTE]
    > As needed, you can select a different default font for printing than that used for display in the text editor. This can be useful when printing code that contains both single-byte and double-byte characters.

- **Statement Completion**

     Changes the font style and size for the text that appears in statement completion pop-up in the editor.

- **Editor Tooltip**

     Changes the font style and size for the text that appears in ToolTips displayed in the editor.

- **Environment**

     Changes the font style and size for all IDE user interface elements that do not already have a separate option in **Show settings for**.

- **[All Text Tool Windows]**

     Changes to font style, size, and color display settings for this item affect the appearance of text in tool windows that have output panes in the IDE. For example, Output window, Command window, Immediate window, etc.

    > [!NOTE]
    > Changes to the text of **[All Text Tool Windows]** items do not take effect during the session in which you make them. You can evaluate such changes by opening another instance of Visual Studio.

**Use Defaults**

Resets the font and color values of the list item selected in **Show settings for**. The **Use** button appears when other display schemes are available for selection. For example, you can choose from two schemes for the Printer.

**Font (bold type indicates fixed-width fonts)**

Lists all the fonts installed on your system. When the drop-down menu first appears, the current font for the element selected in the **Show settings for** field is highlighted. Fixed fonts — which are easier to align in the editor — appear in bold.

**Size**

Lists available point sizes for the highlighted font. Changing the size of the font affects all **Display items** for the **Show settings for** selection.

**Display items**

Lists the items for which you can modify the foreground and background color.

> [!NOTE]
> **Plain Text** is the default display item. As such, properties assigned to **PlainText** will be overridden by properties assigned to other display items. For example, if you assign the color blue to **PlainText** and the color green to **Identifier**, all identifiers will appear in green. In this example, **Identifier** properties override **PlainText** properties.

Some of display items include:

|Display item|Description|
|------------------|-----------------|
|**Plain Text**|Text in the editor.|
|**Selected Text**|Text that is included in the current selection when the editor has focus.|
|**Inactive Selected Text**|Text that is included in the current selection when the editor has lost focus.|
|**Indicator Margin**|The margin at the left of the Code Editor where breakpoints and bookmark icons are displayed.|
|**Line Number**|Optional numbers that appear next to each line of code|
|**Visible White Space**|Spaces, tabs and word wrap indicators|
|**Bookmark**|Lines that have bookmarks. **Bookmark** is only visible if the indicator margin is disabled.|
|**Brace Matching (Highlight)**|Highlighting that is typically bold formatting for matching braces.|
|**Brace Matching (Rectangle)**|Highlighting that is typically a grey rectangle in the background.|
|**Breakpoint - Advanced (Disabled)**|Specifies the highlight color for statements or lines containing disabled conditional or hit-counted breakpoints. Applicable only if statement-level breakpoints are active or the **Highlight entire source line for breakpoints or current statement** option is selected on [General, Debugging, Options Dialog Box](../../debugger/general-debugging-options-dialog-box.md).|
|**Breakpoint - Advanced (Enabled)**|Specifies the highlight color for statements or lines containing conditional or hit-counted breakpoints. Applicable only if statement-level breakpoints are active or the **Highlight entire source line for breakpoints or current statement** option is selected on [General, Debugging, Options Dialog Box](../../debugger/general-debugging-options-dialog-box.md).|
|**Breakpoint - Advanced (Error)**|Specifies the highlight color for statements or lines containing conditional or hit-counted breakpoints that are in an error state. Applicable only if statement-level breakpoints are active or the **Highlight entire source line for breakpoints or current statement** option is selected on [General, Debugging, Options Dialog Box](../../debugger/general-debugging-options-dialog-box.md).|
|**Breakpoint - Advanced (Warning)**|Specifies the highlight color for statements or lines containing conditional or hit-counted breakpoints that are in a warning state. Applicable only if statement-level breakpoints are active or the **Highlight entire source line for breakpoints or current statement** option is selected on [General, Debugging, Options Dialog Box](../../debugger/general-debugging-options-dialog-box.md).|
|**Breakpoint - Mapped (Disabled)**|Specifies the highlight color for statements or lines containing disabled mapped breakpoints. Applicable for ASP or ASP.NET debugging if statement-level breakpoints are active or the **Highlight entire source line for breakpoints or current statement** option is selected on [General, Debugging, Options Dialog Box](../../debugger/general-debugging-options-dialog-box.md).|
|**Breakpoint - Mapped (Enabled)**|Specifies the highlight color for statements or lines containing mapped breakpoints. Applicable for ASP or ASP.NET debugging if statement-level breakpoints are active or the **Highlight entire source line for breakpoints or current statement** option is selected on [General, Debugging, Options Dialog Box](../../debugger/general-debugging-options-dialog-box.md).|
|**Breakpoint - Mapped (Error)**|Specifies the highlight color for statements or lines containing mapped breakpoints in an error state. Applicable for ASP or ASP.NET debugging if statement-level breakpoints are active or the **Highlight entire source line for breakpoints or current statement** option is selected on [General, Debugging, Options Dialog Box](../../debugger/general-debugging-options-dialog-box.md).|
|**Breakpoint - Mapped (Warning)**|Specifies the highlight color for statements or lines containing mapped breakpoints in a warning state. Applicable for ASP or ASP.NET debugging if statement-level breakpoints are active or the **Highlight entire source line for breakpoints or current statement** option is selected on [General, Debugging, Options Dialog Box](../../debugger/general-debugging-options-dialog-box.md).|
|**Breakpoint (Disabled)**|Not used.|
|**Breakpoint (Enabled)**|Specifies the highlight color for statements or lines containing simple breakpoints. This option is applicable only if statement-level breakpoints are active or the **Highlight entire source line for breakpoints or current statement** option is selected on [General, Debugging, Options Dialog Box](../../debugger/general-debugging-options-dialog-box.md).|
|**Breakpoint (Error)**|Specifies the highlight color for statements or lines containing breakpoints that are in an error state. Applicable only if statement-level breakpoints are active or the **Highlight entire source line for breakpoints or current statement** option is selected on [General, Debugging, Options Dialog Box](../../debugger/general-debugging-options-dialog-box.md).|
|**Breakpoint (Warning)**|Specifies the highlight color for statements or lines containing breakpoints that are in a warning state. Applicable only if statement-level breakpoints are active or the **Highlight entire source line for breakpoints or current statement** option is selected on [General, Debugging, Options Dialog Box](../../debugger/general-debugging-options-dialog-box.md).|
|**C/C++ User Keywords**|A constant within a particular code file defined by means of the `#define` directive.|
|**Call Return**|Specifies the highlight color for source statements or lines that indicate call return points when context is switched to a non-top stack frame when debugging.|
|**Code Snippet Dependent Field**|A field that will be updated when the current editable field is modified.|
|**Code Snippet Field**|Editable field when a code snippet is active.|
|**Collapsed Text (Collapsed)**|A block of text or code that can be toggled in and out of view within the Code Editor.|
|**Collapsed Text (Expanded)**|A block of text or code that can be toggled in and out of view within the Code Editor.|
|**Collapsed Text Indicator (Collapsed)**|Sets custom or predefined colors for the collapsed indicators in the Editor.|
|**Collapsed Text Indicator (Expanded)**|Sets custom or predefined colors for the expanded indicators in the Editor.|
|**Compiler Error**|Blue squiggles in the editor indicating a compiler error.|
|**Coverage Not Touched Area**|Code that has not been covered by a unit test.|
|**Coverage Partially Touched Area**|Code that has been partially covered by a unit test.|
|**Coverage Touched Area**|Code that has been completely covered by a unit test.|
|**CSS Comment**|A comment in Cascading Style Sheets. For example:<br /><br /> /* comment \*/|
|**CSS Keyword**|Keywords in the Cascading Style Sheet.|
|**CSS Property Name**|The name of a property, such as Background.|
|**CSS Property Value**|The value assigned to a property such as blue.|
|**CSS Selector**|A string that identifies what elements the corresponding rule applies to. A selector can either be a simple selector, such a 'H1', or a contextual selector, such as 'H1 B', which consists of several simple selectors.|
|**CSS String Value**|A string in Cascading Style Sheets.|
|**Current list location**|Current line navigated to in a list tool window, such as the Output window or Find Results windows.|
|**Current Statement**|Specifies the highlight color for the source statement or line that indicates the current step position when debugging.|
|**Debugger Data Changed**|The color of text used to display changed data inside the **Registers** and **Memory** windows.|
|**Definition Window Background**|The background color of the **Code Definition** window.|
|**Definition Window Current Match**|The current definition in the **Code Definition** window.|
|**Disassembly File Name**|The color of text used to display file name breaks inside the **Disassembly** window.|
|**Disassembly Source**|The color of text used to display source lines inside the **Disassembly** window.|
|**Disassembly Symbol**|The color of text used to display symbol names inside the **Disassembly** window.|
|**Disassembly Text**|The color of text used to display op-code and data inside the **Disassembly** window.|
|**Excluded Code**|Code that is not to be compiled, per a conditional preprocessor directive such as `#if`.|
|**Identifier**|Identifiers in code such as the class names, methods names, and variable names.|
|**Keyword**|Keywords for the given language that are reserved. For example: class and namespace.|
|**Memory Address**|The color of text used to display the address column inside the **Memory** window.|
|**Memory Changed**|The color of text used to display changed data inside the **Memory** window.|
|**Memory Data**|The color of text used to display data inside the **Memory** window.|
|**Memory Unreadable**|The color of text used to display unreadable memory areas within the **Memory** window.|
|**Number**|A number in code that represents an actual numeric value.|
|**Operator**|Operators such as +, -, and !=.|
|**Other Error**|Other error types not covered by other error squiggles. Currently, this includes rude edits in Edit and Continue.|
|**Preprocessor Keyword**|Keywords used by the preprocessor such as #include.|
|**Read-Only Region**|Code that cannot be edited. For example code displayed in the Code Definition View window or code that cannot be modified during Edit and Continue.|
|**Refactoring Background**|Background color of the **Preview Changes** dialog box.|
|**Refactoring Current Field**|Background color of the current element to be refactored in the **Preview Changes** dialog box.|
|**Refactoring Dependent Field**|Color of references of the element to be refactored in the **Preview Changes** dialog box.|
|**Register Data**|The color of text used to display data inside the **Registers** window.|
|**Register NAT**|The color of text used to display unrecognized data and objects inside the **Registers** window.|
|**Smart Tag**|Used to denote the outline when smart tags are invoked.|
|**SQL DML Marker**|Applies to the Transact-SQL editor. DML statements in this editor are marked with a bounding blue box by default.|
|**Stale Code**|Superseded code awaiting an update. In some cases, Edit and Continue cannot apply code changes immediately, but will apply them later as you continue debugging. This occurs if you edit a function that must call the function currently executing, or if you add more than 64 bytes of new variables to a function waiting on the call stack. When this happens, the debugger displays a "Stale Code Warning" dialog box, and the superseded code continues to execute until the function in question finishes and is called again. Edit and Continue applies the code changes at that time.|
|**String**|String literals.|
|**String (C# @ Verbatim)**|String literals in C# that are interpreted verbatim. For example:<br /><br /> @"x"|
|**Syntax Error**|Parse errors.|
|**Task List Shortcut**|If a **Task List** shortcut is added to a line, and the indicator margin is disabled, the line will be highlighted.|
|**Tracepoint (Disabled)**|Not used.|
|**Tracepoint (Enabled)**|Specifies the highlight color for statements or lines containing simple tracepoints. This option is applicable only if statement-level tracepoints are active or the **Highlight entire source line for breakpoints or current statement** option is selected on [General, Debugging, Options Dialog Box](../../debugger/general-debugging-options-dialog-box.md).|
|**Tracepoint (error)**|Specifies the highlight color for statements or lines containing tracepoints that are in an error state. This option is applicable only if statement-level tracepoints are active or the **Highlight entire source line for breakpoints or current statement** option is selected on [General, Debugging, Options Dialog Box](../../debugger/general-debugging-options-dialog-box.md).|
|**Tracepoint (Warning)**|Specifies the highlight color for statements or lines containing tracepoints that are in a warning state. This option is applicable only if statement-level tracepoints are active or the **Highlight entire source line for breakpoints or current statement** option is selected on [General, Debugging, Options Dialog Box](../../debugger/general-debugging-options-dialog-box.md).|
|**Tracepoint - Advanced (Disabled)**|Specifies the highlight color for statements or lines containing disabled conditional or hit-counted tracepoints. This option is applicable only if statement-level tracepoints are active or the **Highlight entire source line for breakpoints or current statement** option is selected on [General, Debugging, Options Dialog Box](../../debugger/general-debugging-options-dialog-box.md).|
|**Tracepoint - Advanced (Enabled)**|Specifies the highlight color for statements or lines containing conditional or hit-counted tracepoints. This option is applicable only if statement-level tracepoints are active or the **Highlight entire source line for breakpoints or current statement** option is selected on [General, Debugging, Options Dialog Box](../../debugger/general-debugging-options-dialog-box.md).|
|**Tracepoint - Advanced (Error)**|Specifies the highlight color for statements or lines containing conditional or hit-counted tracepoints that are in an error state. This option is applicable only if statement-level tracepoints are active or the **Highlight entire source line for breakpoints or current statement** option is selected on [General, Debugging, Options Dialog Box](../../debugger/general-debugging-options-dialog-box.md).|
|**Tracepoint - Advanced (Warning)**|Specifies the highlight color for statements or lines containing conditional or hit-counted tracepoints that are in a warning state. This option is applicable only if statement-level tracepoints are active or the **Highlight entire source line for breakpoints or current statement** option is selected on [General, Debugging, Options Dialog Box](../../debugger/general-debugging-options-dialog-box.md).|
|**Tracepoint - Mapped (Disabled)**|Specifies the highlight color for statements or lines containing disabled mapped tracepoints. Applicable for ASP or ASP.NET debugging if statement-level breakpoints are active or the **Highlight entire source line for breakpoints or current statement** option is selected on [General, Debugging, Options Dialog Box](../../debugger/general-debugging-options-dialog-box.md).|
|**Tracepoint - Mapped (Enabled)**|Specifies the highlight color for statements or lines containing mapped tracepoints. Applicable for ASP or ASP.NET debugging if statement-level breakpoints are active or the **Highlight entire source line for breakpoints or current statement** option is selected on [General, Debugging, Options Dialog Box](../../debugger/general-debugging-options-dialog-box.md).|
|**Tracepoint - Mapped (Error)**|Specifies the highlight color for statements or lines containing mapped tracepoints in an error state. Applicable for ASP or ASP.NET debugging if statement-level breakpoints are active or the **Highlight entire source line for breakpoints or current statement** option is selected on [General, Debugging, Options Dialog Box](../../debugger/general-debugging-options-dialog-box.md).|
|**Tracepoint - Mapped (Warning)**|Specifies the highlight color for statements or lines containing mapped tracepoints in a warning state. Applicable for ASP or ASP.NET debugging if statement-level breakpoints are active or the **Highlight entire source line for breakpoints or current statement** option is selected on [General, Debugging, Options Dialog Box](../../debugger/general-debugging-options-dialog-box.md).|
|**Track Changes after save**|Lines of code that have been modified since the file was opened but are saved to disk.|
|**Track Changes before save**|Lines of code that have been modified since the file was opened but are not saved to disk.|
|**User Types**|Types defined by users.|
|**User Types (Delegates)**|Type color for delegates.|
|**User Types (Enums)**|Type color used for enums.|
|**User Types (Interfaces)**|Type color for interfaces.|
|**User Types (Value types)**|Type color for value types such as structs in C#.|
|**Visual Basic Read Only Marker**|A marker specific to Visual Basic used for designating EnC, such as exception regions, a method definition, and non-leaf call frames.|
|**Warning**|Compiler warnings.|
|**Warning Lines Path**|Used for Static Analysis warning lines.|
|**XML Attribute**|Attribute names.|
|**XML Attribute Quotes**|The quote characters for XML attributes.|
|**XML Attribute Value**|Contents of XML attributes.|
|**XML Cdata Section**|Contents of \<![CDATA[...]]>.|
|**XML Comment**|The contents of \<!-- -->.|
|**XML Delimiter**|XML Syntax delimiters, including <, <?, <!, \<!--, -->, ?\>, \<![, ]]>, and [, ].|
|**XML Doc Attribute**|The value of an xml documentation attribute, such as \<param name="I"> where the "I" is colorized.|
|**XML Doc Comment**|The comments enclosed in the xml documentation comments.|
|**XML Doc Tag**|The tags in XML doc comments, such as<br /><br /> /// \<summary>.|
|**XML Keyword**|DTD keywords such as CDATA, IDREF, and NDATA.|
|**XML Name**|Element names and Processing Instructions target name.|
|**XML Processing Instruction**|Contents of Processing Instructions, not including target name.|
|**XML Text**|Plain text element content.|
|**XSLT Keyword**|XSLT element names.|

**Item foreground**

Lists the available colors you can choose for the foreground of the item selected in **Display items**. Because some items are related, and should therefore maintain a consistent display scheme, changing the foreground color of text also changes the defaults for elements such as Compiler Error, Keyword, or Operator.

**Automatic**

Items can inherit the foreground color from other display items such as **Plain Text**. Using this option, when you change the color of an inherited display item, the color of the related display items also change automatically. For example, if you selected the **Automatic** value for **Compiler Error** and later changed the color of **Plain Text** to Red, **Compiler Error** would also automatically inherit the color Red.

**Default**

The color that appears for the item the first time you open Visual Studio. Clicking the **Use Defaults** button resets to this color.

**Custom**

Displays the Color dialog box to allow you to set a custom color for the item selected in the Display items list.

> [!NOTE]
> Your ability to define custom colors may be limited by the color settings for your computer display. For example, if your computer is set to display 256 colors and you select a custom color from the **Color** dialog box, the IDE defaults to the closest available **Basic color** and displays the color black in the **Color** preview box.

**Item background**

Provides a color palette from which you can choose a background color for the item selected in **Display items**. Because some items are related, and should therefore maintain a consistent display scheme, changing the background color of text also changes the defaults for elements such as Compiler Error, Keyword, or Operator.

**Automatic**

Items can inherit the background color from other display items such as **Plain Text**. Using this option, when you change the color of an inherited display item, the color of the related display items also change automatically. For example, if you selected the **Automatic** value for **Compiler Error** and later changed the color of **Plain Text** to Red, **Compiler Error** would also automatically inherit the color Red.

**Default**

The color that appears for the item the first time you open Visual Studio. Clicking the **Use Defaults** button resets to this color.

**Custom**

Displays the Color dialog box to allow you to set a custom color for the item selected in the Display items list.

**Bold**

Select this option to display the text of selected **Display items** in bold text. Bold text is easier to identify in the editor.

**Sample**

Displays a sample of the font style, size, and color scheme for the **Show settings for** and **Display items** selected. You can use this box to preview the results as you experiment with different formatting options.

## See also

- [Options Dialog Box](../../ide/reference/options-dialog-box-visual-studio.md)
- [How to: Change Fonts and Colors](../../ide/how-to-change-fonts-and-colors-in-visual-studio.md)
