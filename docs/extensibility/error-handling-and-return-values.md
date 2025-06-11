---
title: Error Handling and Return Values
description: Learn how the Visual Studio SDK provides interop assemblies to record rich error information when receiving an error notification.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- errors [Visual Studio SDK], handling
- error handling
- return values
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Error handling and return values

VSPackages and COM use the same architecture for errors. The `SetErrorInfo` and `GetErrorInfo` functions are part of the Win32 application programming interface (API). Any VSPackage in the integrated development environment (IDE) can call these global Win32 APIs to record rich error information when receiving an error notification. The Visual Studio SDK provides interop assemblies to manage error information.

## Interop methods
 As a convenience, the IDE provides a method, <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.SetErrorInfo%2A>, to use instead of calling the Win32 APIs. In managed code use <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.SetErrorInfo%2A>. When an error `HRESULT` arrives at the level where the error message should be displayed (this is often the object implementing an <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> command handler), the IDE uses another method, <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.ReportErrorInfo%2A>, to display the appropriate message box. In managed code use the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.ReportErrorInfo%2A> method.

 As a VSPackage implementer, your COM objects normally implement `ISupportErrorInfo`. The `ISupportErrorInfo` interface ensures that rich error information can move vertically up the call chain. Objects that might be used across processes or across threads must support `ISupportErrorInfo` to ensure that the rich error information is properly marshaled back to the caller.

 All objects that are related to VSPackages and that are involved in extending the IDE, including editor factories, editors, hierarchies, and offered services, should support rich error information. While the IDE does not require these VSPackage objects to implement `ISupportErrorInfo`, it is always encouraged.

 The IDE is responsible for reporting error information and displaying it to a user of Visual Studio whenever an `HRESULT` is propagated to the IDE. The IDE is also the mechanism for creating `ErrorInfo` objects.

## General guidelines
 You can use the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.SetErrorInfo%2A> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.ReportErrorInfo%2A> methods to set and report errors that are internal to your VSPackage implementation as well. However, as a general rule, follow these guidelines for handling error messages in your VSPackage:

- Implement `ISupportErrorInfo` in your VSPackage COM objects.

- Create an error reporting mechanism that calls the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.SetErrorInfo%2A> method in objects that implement <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget>.

- Let the IDE display errors to users through the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.ReportErrorInfo%2A> method.

## Error information in the IDE
 The following rules indicate how to handle error information in the Visual Studio IDE:

- As a defensive strategy to guarantee that stale error info is not reported to users, functions that call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.ReportErrorInfo%2A> method should first call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.SetErrorInfo%2A> method. Pass in `null` to clear cached error messages before calling anything that might set new error information.

- Functions that do not directly report error messages are only allowed to call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.SetErrorInfo%2A> method if they are returning an error `HRESULT`. It is permissible to clear the `ErrorInfo` on the entry to a function or when returning <xref:Microsoft.VisualStudio.VSConstants.S_OK>. The only exception to this rule is when a call returns an error `HRESULT` from which the receiving party can explicitly recover or safely ignore.

- Any party that explicitly ignores an error `HRESULT` must call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.SetErrorInfo%2A> method with <xref:Microsoft.VisualStudio.VSConstants.S_OK>. Otherwise, the `ErrorInfo` object might be accidentally used when another party generates an error without providing their own `ErrorInfo`.

- All methods that originate an error `HRESULT` are encouraged to call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.SetErrorInfo%2A> method to provide rich error information. If the returned `HRESULT` is a special `FACILITY_ITF` error, then the method is required to provide a proper `ErrorInfo` object. If the returned error is a standard system error (for example, <xref:Microsoft.VisualStudio.VSConstants.E_OUTOFMEMORY>, <xref:Microsoft.VisualStudio.VSConstants.E_ABORT>, <xref:Microsoft.VisualStudio.VSConstants.E_INVALIDARG>, <xref:Microsoft.VisualStudio.VSConstants.E_UNEXPECTED>, and so on.) it is acceptable to return the error code without explicitly calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.SetErrorInfo%2A> method. As a defensive coding strategy, when originating an error `HRESULT` (including system errors), always call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.SetErrorInfo%2A> method, either with `ErrorInfo` describing the failure in greater detail, or `null`.

- All functions that return an error originated by another call must pass on the information that was received from the failing call in the `HRESULT` without modifying the `ErrorInfo` object.

## See also
- <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget>
- [SetErrorInfo (Component Automation)](/previous-versions/windows/desktop/api/oleauto/nf-oleauto-seterrorinfo)
- [GetErrorInfo](/previous-versions/windows/desktop/api/oleauto/nf-oleauto-geterrorinfo)
- [ISupportErrorInfo Interface](/previous-versions/windows/desktop/api/oaidl/nn-oaidl-isupporterrorinfo)
