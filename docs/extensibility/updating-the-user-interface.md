---
title: Updating the User Interface
description: Learn how to add code to update the user interface after you implement a new command in your VSPackage.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- user interfaces, updating
- commands, updating UI
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Updating the User Interface

After you implement a command, you can add code to update the user interface with the state of your new commands.

 In a typical Win32 application, the command set can be continuously polled and the state of individual commands can be adjusted as the user views them. However, because the Visual Studio shell can host an unlimited number of VSPackages, extensive polling might decrease responsiveness, especially polling across interop assemblies between managed code and COM.

### To update the UI

1. Perform one of the following steps:

    - Call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.UpdateCommandUI%2A> method.

         An <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell> interface can be obtained from the <xref:Microsoft.VisualStudio.Shell.Interop.SVsUIShell> service, as follows.

        ```csharp
        void UpdateUI(Microsoft.VisualStudio.Shell.ServiceProvider sp)
        {
            IVsUIShell vsShell = (IVsUIShell)sp.GetService(typeof(IVsUIShell));
            if (vsShell != null)
            {
                int hr = vsShell.UpdateCommandUI(0);
                Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure(hr);
            }
        }

        ```

         If the parameter of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.UpdateCommandUI%2A> is non-zero (`TRUE`), then the update is performed synchronously and immediately. We recommend that you pass zero (`FALSE`) for this parameter to help maintain good performance. If you want to avoid caching, apply the `DontCache` flag when you create the command in the .vsct file. Nevertheless, use the flag cautiously or performance might decrease. For more information about command flags, see the [Command Flag Element](../extensibility/command-flag-element.md) documentation.

    - In VSPackages that host an ActiveX control by using the in-place activation model in a window, it might be more convenient to use the <xref:Microsoft.VisualStudio.Shell.Interop.IOleInPlaceComponentUIManager.UpdateUI%2A> method. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.UpdateCommandUI%2A> method in the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell> interface and the <xref:Microsoft.VisualStudio.Shell.Interop.IOleInPlaceComponentUIManager.UpdateUI%2A> method in the <xref:Microsoft.VisualStudio.Shell.Interop.IOleInPlaceComponentUIManager> interface are functionally equivalent. Both cause the environment to re-query the state of all commands. Typically, an update is not performed immediately. Instead, an update is delayed until idle time. The shell caches the command state to help maintain good performance. If you want to avoid caching, apply the `DontCache` flag when you create the command in the .vsct file. Nevertheless, use the flag cautiously because performance might decrease.

         Notice that you can obtain the <xref:Microsoft.VisualStudio.Shell.Interop.IOleInPlaceComponentUIManager> interface by calling the `QueryInterface` method on an <xref:Microsoft.VisualStudio.Shell.Interop.IOleComponentUIManager> object or by obtaining the interface from the <xref:Microsoft.VisualStudio.Shell.Interop.SOleComponentUIManager> service.

## Related content
- [How VSPackages Add User Interface Elements](../extensibility/internals/how-vspackages-add-user-interface-elements.md)
- [Implementation](../extensibility/internals/command-implementation.md)
