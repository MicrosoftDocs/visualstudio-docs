---
title: Design Windows Forms apps
description: Learn about Windows Forms Designer in Visual Studio, which provides a rapid development solution for creating Windows Forms-based applications. 
ms.custom: SEO-VS-2020
ms.date: 08/09/2019
ms.topic: overview
helpviewer_keywords:
- Windows Forms Designer
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-designers
---
# Windows Forms Designer overview

Windows Forms Designer in Visual Studio provides a rapid development solution for creating Windows Forms-based applications. Windows Forms Designer lets you easily add controls to a form, arrange them, and write code for their events. For more information about Windows Forms, see [Windows Forms overview](/dotnet/framework/winforms/windows-forms-overview).

## Functionality

Using the designer you can:

- Add components, data controls, or Windows-based controls to a form.

- Double-click the form in the designer and write code in the `Load` event for that form, or double-click a control on the form and write code for the control's default event.

- Edit a control's Text property by selecting the control and typing a name.

- Adjust the placement of the selected control by moving it with the mouse or the arrow keys. Similarly, adjust the placement more precisely using the Ctrl and arrow keys. Finally, adjust the size of the control by using the Shift and arrow keys.

- Select multiple controls by selecting either **Shift** or **Ctrl** while you click. When using sing **Shift**+click, the first control selected is the dominant control when aligning or manipulating size. When using **Ctrl**+click, the last control selected is dominant, so the dominant control changes with every new control added. Alternatively, you can select multiple controls by dragging a selection rectangle around the controls that you want to select.

> [!NOTE]
> Use Windows Forms Designer, and not the Resource Editor, to make changes to a form's resource (*.resx*) file. If you edit a form-based .resx file, you'll see a warning that changes you make in the Resource Editor may be lost. This is because the Windows Forms Designer generates the .resx file.

## See also

- [Windows Forms overview](/dotnet/framework/winforms/windows-forms-overview)
- [Windows Forms controls](/dotnet/framework/winforms/controls/)
- [User input in Windows Forms](/dotnet/framework/winforms/user-input-in-windows-forms)
- [Data binding in Windows Forms](/dotnet/framework/winforms/windows-forms-data-binding)
- [Enhance Windows Forms apps](/dotnet/framework/winforms/advanced/)
- <xref:System.Windows.Forms?displayProperty=fullName> API reference
