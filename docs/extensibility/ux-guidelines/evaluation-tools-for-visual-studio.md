---
title: Evaluation Tools for Visual Studio
description: Use this checklist to evaluate user experience quality for visual and interaction details for new features you design for Visual Studio.
ms.date: 11/04/2016
ms.topic: reference
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Evaluation Tools for Visual Studio

## Craftsmanship checklist for Visual Studio
 Use this checklist to evaluate user experience quality for visual and interaction details.


- Verify that all commands result in feedback that tells users that their commands have been carried out.

- Verify that all UI elements and controls are visible in all themes and in High Contrast mode.

- Verify that inactive and active selection are always differentiated, both in standard and High Contrast mode.

- Verify that focus is always visible and apparent.

### Performance

- Verify that some kind of "busy" indicator is shown if a command takes more than one second to complete.

- Verify that if a command takes more than 10 seconds to complete, an explicit progress bar, either determinate (preferred) or indeterminate, is displayed.

### UI text

- Verify that all labels are sentence- or title-case and that no text is entirely lowercase.

    ||Correct|Incorrect|
    |-|-------------|---------------|
    |**Command text (all)**|Sentence case:<br /><br /> **Directory name:**|Directory Name:|
    |**Button text (client)**|Title case:<br /><br /> **[ Set As Default ]**|SET AS DEFAULT|
    |**Button text (online)**|Sentence case:<br /><br /> **[ Set as default ]**||

- Verify that all labels, except group headers and buttons, end with a colon and precede the control with which they are paired.

- Verify that buttons, commands, and command links that launch UI to capture user input end in an ellipsis **[...]**.

  Examples:

  - An **[Advanced...]** button on a dialog.

  - The command options under the Tools menu (**Tools > Options**) should not get an ellipsis, because launching the dialog itself is the intent of the command.

- Verify that the UI contains no abbreviations, except for industry-standard terms. For instance, neither HTML nor TCP/IP need to be spelled out, though OOM (out of memory) and PII (personally identifiable information) should.

### Keyboard access

- Verify that there is a way to accomplish each task with the keyboard. Generally this is accomplished through keyboard access for each control, but for some highly visual areas, a workaround such as going to code view is acceptable.

- Verify that you can Tab through controls in a logical order (left-to-right and top-to-bottom). While this is a best practice for most controls, not all controls require this approach. For example, verify that radio button controls are in a group with a single tab stop.

- Verify that all controls have labels and that each label has a mnemonic (exceptions include some non-labeled controls that might follow a labeled control in the tab).

- Verify that there are no mnemonic conflicts.

### Fonts

- Verify that all fonts (face, size, color) are used consistently and maintain hierarchy.

- Verify that all UI elements use the environment font service. (See [Fonts and Formatting for Visual Studio](../../extensibility/ux-guidelines/fonts-and-formatting-for-visual-studio.md))

     To check if the service is being used, go to **Tools > Options > Fonts and Colors**. In the Settings dropdown, choose Environment Font and change the font face to something stylistically different (such as Harrington or Comic Sans) and set the size to 12 pt. Then click OK. You might need to restart the IDE, but most UI will change immediately. Areas that don't pick up the font change even on restart are not using the environment font.

- Verify that fonts that are derivative of the service (for example, bold or enlarged text) retain their size and formatting in relation to "normal" text when the environment font size is changed.

- Verify that there are no clipping bugs due to enlarged fonts. Fonts that get clipped are likely the result of fixed height controls or fixed height containers.

### Dialogs

- Verify that the dialog title is the same as the command that launched it.

- Verify that all standard controls are consistent with the operating system: background color is standard and no controls should have a special re-templated style that makes them appear different from standard controls.

- Verify that margins within the form should be 12 pixels and should appear uniform and consistent.

- Verify that dialogs appear centered within the IDE shell or the window that spawned them.

- When useful, dialogs should be resizable. For dialogs that are resizable, verify that upon resizing, the appropriate controls must resize while other parts of the dialog remain constant.

- Verify that resizable dialogs persist any user-adjusted size (size, location, expansion of dialog controls, and so on).

- Verify that there is no icon in the title bar.

- Verify that there are no Minimize and Maximize buttons in the title bar.

#### Dialog operation buttons (VS Client only)

- Verify that operation buttons are in this order: **OK**, **Cancel**, **Apply**.

- Verify that **OK** and **Cancel** buttons are the standard size: 75x23 pixels.

- Verify that **OK** and **Cancel** buttons are of equal size regardless of string length.

- If the label on an operation button requires the button to be wider than standard, verify that the corresponding **Cancel** button is of equal size.

- Verify that there is a 6-pixel padding between buttons and associated controls.

- Verify that the **OK** and **Cancel** buttons do not have mnemonics (access keys defined by an underlined letter).

- Verify that one button (typically **OK**) has focus by default.

- Verify that **Esc** cancels the dialog

- Verify that **Enter** executes the default button if focus is not in a control that processes Enter.

- Verify that the **OK** and **Cancel** buttons are positioned in the bottom right corner of the dialog. In rare exceptions, it is acceptable for them to be stacked vertically in the upper right.

- Verify that the vertical configuration is used only if other buttons are in a horizontal alignment within the dialog.

### Control standards

#### General

- Verify that, when possible, there are good default values to speed up user interaction and direct users toward a safe or common outcome.

- Verify that standard controls behave the same way so that users know what will happen based on earlier experience.

#### Label controls

- Verify that each control has a label and that each label is visually paired with its control (generally within a 4-6 pixel range) and is closer to its corresponding control than to other controls.

- Verify that labels are positioned flush left with the control left edge if positioned above and centered horizontally, so that the baseline of the label is aligned with the baseline of the input text if positioned to the left.

- Verify that if several stacked label and input controls are positioned to the left of a control, the labels are flush left and an equal distance from the edge of the dialog, never flush right and an equal distance from the controls. Pairs should be evenly distributed unless they need additional spacing to indicate grouping.

#### Input controls (text boxes and combo boxes)

- Verify that when using the default environment font, the display height for text boxes, combo boxes and buttons are all 23 pixels.

- If hint text is used, verify that the color is set to `Environment.ControlEditHintText` using the color service.

- If the field is a required field that must be identified as such, verify:

  - that the background is set to `Environment.ControlEditRequiredBackground` and the foreground is set to `Environment.ControlEditRequiredHintText`

  - that there is hint text within the control that appears as **"\<Required>"**

#### Button controls

- Verify that buttons are a minimum size of 75x23 pixels, unless accommodating longer text.

- Verify that buttons have left and right margins of 3-5 pixels, as well as padding for the content.

- It is acceptable to use a small square button with only an ellipsis **[...]** on it instead of a **[Browse...]** button (or similar functionality). If used, verify that the button is 23x23 in size.

- If there is more than one **[Browse...]** button in a dialog, then verify that the shortened version (ellipsis-only **[...]**) is used for all.

- Verify that ellipsis **[...]** buttons do not have a mnemonic. When focus is on the input control beside it, one tab should move focus to the ellipsis button.

- Verify that buttons, commands, and command links that launch secondary UI that captures more user input must end in an ellipsis **[...]**.

#### Hyperlinks

- Verify that a hyperlink control never flashes red when active. This is an indicator that the color service is not being use

- Verify that the VS Colors used are:

  - `Environment.ControlLinkText`

  - `Environment.ControlLinkTextHover`

  - `Environment.ControlLinkTextPressed`

- Verify that hyperlinks appear blue with no underline unless embedded in a paragraph.

#### Check boxes

- If a check box has multi-line text, verify that the box aligns with the first line of text, not centered vertically across all lines.

- Verify that check boxes always indicate a binary choice and do not navigate the user or open new windows or pages.

- If a check box presents an option related to an input control, verify that it is positioned flush left and very close under that control to indicate its relation.

- Verify that a check box is **never** used as a means to enable the entire contents of a dialog or page.

#### Group boxes

- Verify that a dialog does not contain a single group box within it that contains the entire contents of the dialog.

- Verify that there are at least two controls within each group box.

- Rarely should there be more than two group boxes on a dialog.

- Verify that there are no nested group boxes.

### Icons

- Verify that icons appear correctly inverted when in the dark theme.

- Verify that all icons are based on core concepts.

- Verify that each icon is distinct, easy to recognize and does not contain more than two concepts (without status modifier/language).

- Verify that the base icon appears centered within the space.

- Verify that all icons appear legible in High Contrast mode.

- Verify that any color used aligns with color usage standards.

- Verify that there are no halos (borders) around icons. (If present, the halo should match the background color of the adjacent UI).

### Touch-enabled UI

- Verify that interactive controls are large enough to be easily touchable - minimum **23x23 pixels** in size

- Verify that the most frequently used controls are at least **40x40 pixels** in size.

- Verify that interactive controls have at least **5 pixels of spacing** between them
