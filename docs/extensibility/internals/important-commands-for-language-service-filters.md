---
title: "Important Commands for Language Service Filters | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "language services, filters"
  - "language services, commands to support"
ms.assetid: 4948c494-3d4d-4f50-b3f9-959e73f90e4d
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Important Commands for Language Service Filters
If you want to create a fully featured language service filter, consider handling the following commands. The full list of command identifiers is defined in the <xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID> enumeration for managed code and the Stdidcmd.h header file for unmanaged [!INCLUDE[vcprvc](../../code-quality/includes/vcprvc_md.md)] code. You can find the Stdidcmd.h file in *Visual Studio SDK installation path*\VisualStudioIntegration\Common\Inc.

## Commands to Handle

> [!NOTE]
> It is not mandatory to filter for every command in the following table.

|Command|Description|
|-------------|-----------------|
|<xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID>|Sent when the user right-clicks. This command indicates that it is time to provide a shortcut menu. If you do not handle this command, the text editor provides a default shortcut menu without any language-specific commands. To include your own commands on this menu, handle the command and display a shortcut menu yourself.|
|<xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID>|Typically sent when the user types CTRL+J. Call the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.UpdateCompletionStatus%2A> method on the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView> to show the statement completion box.|
|<xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID>|Sent when the user types a character. Monitor this command to determine when a trigger character is typed and to provide statement completion, method tips, and text markers, such as syntax coloring, brace matching, and error markers. Call the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.UpdateCompletionStatus%2A> method on the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView> for statement completion and the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodTipWindow.SetMethodData%2A> method on the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodTipWindow> for method tips. To support text markers, monitor this command to determine whether the character being typed requires that you update your markers.|
|<xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID>|Sent when the user types the Enter key. Monitor this command to determine when to dismiss a method tip window by calling the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData.OnDismiss%2A> method on the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData>. By default, the text view handles this command.|
|<xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID>|Sent when the user types the Backspace key. Monitor to determine when to dismiss a method tip window by calling the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData.OnDismiss%2A> method on the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData>. By default, the text view handles this command.|
|<xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID>|Sent from a menu or a shortcut key. Call the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.UpdateTipWindow%2A> method on the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView> to update the tip window with the parameter information.|
|<xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID>|Sent when the user hovers over a variable or positions the cursor on a variable and selects **Quick Info** from **IntelliSense** in the **Edit** menu. Return the type of the variable in a tip by calling the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.UpdateTipWindow%2A> method on the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView>. If debugging is active, the tip should also show the value of the variable.|
|<xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID>|Typically sent when the user types CTRL+SPACEBAR. This command tells the language service to call the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.UpdateCompletionStatus%2A> method on the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView>.|
|<xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID><br /><br /> <xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID>|Sent from a menu, typically **Comment Selection** or **Uncomment Selection** from **Advanced** in the **Edit** menu. <xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID> indicates that the user wants to comment out the selected text; <xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID> indicates that the user wants to uncomment the selected text. These commands can be implemented only by the language service.|

## See also
- [Developing a Legacy Language Service](../../extensibility/internals/developing-a-legacy-language-service.md)