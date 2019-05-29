---
title: "How to: Update the Status Bar | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "editors [Visual Studio SDK], legacy - update status bar"
ms.assetid: 7500c8a7-4913-4818-a88b-bfd1b9887cb6
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# How to: Update the Status Bar
The **Status Bar** is a control bar located at the bottom of many application windows that contains one or more status text lines or indicators.

## To update the Status Bar

1. Implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbarUser> on each individual view object (DocView) that your editor provides, such as a form view and a code view.

2. When the IDE calls <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbarUser.SetInfo%2A>, update the information in the **Status Bar** by calling the methods of <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbarUser>.

    > [!NOTE]
    > The IDE calls <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbarUser.SetInfo%2A> only when your document window is initially activated. For the remainder of the time that your document window is active, you must update the **Status Bar** information as the state of your editor changes.

## Robust programming
 A **Status Bar** contains four separate fields:

- Status text

- Progress bar

- Animated icon

- Editor information

  For more information, see [Status bars](/cpp/mfc/status-bars).

  The IDE automatically calls the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbarUser.SetInfo%2A> method of your <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbarUser> implementation when your document window is activated.

  The VSPackage implementer is responsible for updating the status text in the status bar. The IDE resets this string to "READY" if the status text field is set to empty text ("") at idle time.

## See also
- [Status bars](/cpp/mfc/status-bars)