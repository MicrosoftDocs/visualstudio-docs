---
title: Design Windows Forms Applications
description: Explore Windows Forms Designer in Visual Studio for rapid application development. Arrange controls, set margins and padding, and adjust the layout, size, and display of forms.
ms.date: 06/24/2025
ms.topic: overview
helpviewer_keywords:
- Windows Forms Designer
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: ui-designers
#customer intent: As a developer, I want to use Windows Forms Designer in Visual Studio, so I can arrange controls, set margins and padding, and adjust the layout, size, and display of forms.
---
# What is Windows Forms Designer?

Windows Forms Designer in Visual Studio provides a rapid development solution for creating Windows Forms-based applications. Windows Forms Designer lets you easily add controls to a form, arrange them, and write code for their events. For more information about Windows Forms, see [Windows Forms overview](/dotnet/desktop/winforms/overview/).

## Explore the functionality

Here are some of the tasks you can complete with Windows Forms Designer:

- Add components, data controls, or Windows-based controls to a form.

- Double-click the form in the designer and write code in the `Load` event for that form. Double-click a control on the form and write code for the control's default event.

- Edit a control's **Text** property by selecting the control and entering a name.

- Adjust the placement of the selected control by moving it with the mouse or the arrow keys (**Up**, **Down**, **Left**, **Right**). Adjust the placement more precisely by selecting **Ctrl** + the arrow keys. Adjust the size of the control by selecting **Shift** + the arrow keys.

- Access multiple form controls simultaneously with **Shift** or **Ctrl** followed by the control shortcut. When you select **Shift** + \<Control shortcut>, the first control you select is the dominant control as you align windows and adjust the size. When you select **Ctrl** + \<Control shortcut>, the last control you select is dominant. This approach allows the dominant control to change to the new control each time you add a control. Another approach is to select multiple controls by dragging a selection rectangle around the controls that you want to select.

## Review caution scenarios

When you work with Windows Forms Designer in Visual Studio, exercise caution in the following scenarios:

- Windows Forms Designer executes application code when displaying controls or forms on the design surface. To ensure executed application code is safe for your system, open projects only from [files and folders configured with trust settings](..\ide\reference\trust-settings.md).

- Changes to the resource (*.resx*) file for a form should be made with Windows Forms Designer only and not the Resource Editor. If you edit a form-based *.resx* file, changes made outside the designer can be lost. 

- Resources in a _.resx_ file can be serialized by using the [BinaryFormatter](/dotnet/api/system.runtime.serialization.formatters.binary.binaryformatter) type. However, this type presents deserialization risks. The type is [insecure and not trustworthy](/dotnet/standard/serialization/binaryformatter-security-guide). Use Windows Forms Designer to work only with forms and controls that you trust.

## Related content

- [Windows Forms overview](/dotnet/framework/winforms/windows-forms-overview)
- [Windows Forms controls](/dotnet/framework/winforms/controls/)
- [User input in Windows Forms](/dotnet/framework/winforms/user-input-in-windows-forms)