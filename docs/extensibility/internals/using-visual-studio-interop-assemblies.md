---
title: Using Visual Studio Interop Assemblies
description: Learn how Visual Studio interop assemblies allow managed applications to access the COM interfaces that provide Visual Studio extensibility.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- Visual Studio, interop assemblies
- interop assemblies, Visual Studio
- managed VSPackages, interop assemblies
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Using Visual Studio Interop Assemblies

Visual Studio interop assemblies allow managed applications to access the COM interfaces that provide Visual Studio extensibility. There are some differences between straight COM interfaces and their interop versions. For example, HRESULTs are generally represented as int values and need to be handled in the same way as exceptions, and parameters (especially out parameters) are treated differently.

## Handling HRESULTs Returned to Managed Code from COM
 When you call a COM interface from managed code, examine the HRESULT value and throw an exception if required. The <xref:Microsoft.VisualStudio.ErrorHandler> class contains the <xref:Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure%2A> method, which throws a COM exception, depending on the value of the HRESULT passed to it.

 By default, <xref:Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure%2A> throws an exception whenever it is passed an HRESULT that has a value less than zero. In cases where such HRESULTs are acceptable values and no exception should be thrown, the values of additional HRESULTS should be passed to <xref:Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure%2A> after the values are tested. If the HRESULT being tested matches any HRESULT values explicitly passed to <xref:Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure%2A>, no exception is thrown.

> [!NOTE]
> The <xref:Microsoft.VisualStudio.VSConstants> class contains constants for common HRESULTS, for example, <xref:Microsoft.VisualStudio.VSConstants.S_OK> and <xref:Microsoft.VisualStudio.VSConstants.E_NOTIMPL>, and Visual Studio HRESULTS, for example, <xref:Microsoft.VisualStudio.VSConstants.VS_E_INCOMPATIBLEDOCDATA> and <xref:Microsoft.VisualStudio.VSConstants.VS_E_UNSUPPORTEDFORMAT>. <xref:Microsoft.VisualStudio.VSConstants> also provides the <xref:Microsoft.VisualStudio.ErrorHandler.Succeeded%2A> and <xref:Microsoft.VisualStudio.ErrorHandler.Failed%2A> methods, which correspond to the SUCCEEDED and FAILED macros in COM.

 For example, consider the following function call, in which <xref:Microsoft.VisualStudio.VSConstants.E_NOTIMPL> is an acceptable return value but any other HRESULT less than zero represents an error.

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../../snippets/csharp/VS_Snippets_VSSDK/vssdkhresultinformation/cs/vssdkhresultinformationpackage.cs" id="Snippet1":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VSSDK/vssdkhresultinformation/vb/vssdkhresultinformationpackage.vb" id="Snippet1":::
 ---

 If there are more than one acceptable return values, additional HRESULT values can just be appended to the list in the call to <xref:Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure%2A>.

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../../snippets/csharp/VS_Snippets_VSSDK/vssdkhresultinformation/cs/vssdkhresultinformationpackage.cs" id="Snippet2":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VSSDK/vssdkhresultinformation/vb/vssdkhresultinformationpackage.vb" id="Snippet2":::
 ---

## Returning HRESULTS to COM from Managed Code
 If no exception occurs, managed code returns <xref:Microsoft.VisualStudio.VSConstants.S_OK> to the COM function that called it. COM interop supports common exceptions that are strongly typed in managed code. For example, a method that receives an unacceptable `null` argument throws an <xref:System.ArgumentNullException>.

 If you are not certain which exception to throw, but you know the HRESULT you want to return to COM, you can use the <xref:System.Runtime.InteropServices.Marshal.ThrowExceptionForHR%2A> method to throw an appropriate exception. This works even with a nonstandard error, for example, <xref:Microsoft.VisualStudio.VSConstants.VS_E_INCOMPATIBLEDOCDATA>. <xref:System.Runtime.InteropServices.Marshal.ThrowExceptionForHR%2A> attempts to map the HRESULT passed to it to a strongly typed exception. If it cannot, it throws a generic COM exception instead. The ultimate result is that the HRESULT you pass to <xref:System.Runtime.InteropServices.Marshal.ThrowExceptionForHR%2A> from managed code is returned to the COM function that called it.

> [!NOTE]
> Exceptions compromise performance and are intended to indicate abnormal program conditions. Conditions that occur often should be handled inline, instead of a thrown exception.

## IUnknown parameters passed as Type void**
 Look for [out] parameters that are defined as type `void **` in the COM interface, but that are defined as `[``iid_is``]` in the Visual Studio interop assembly method prototype.

 Sometimes, a COM interface generates an `IUnknown` object, and the COM interface then passes it as type `void **`. These interfaces are especially important because if the variable is defined as [out] in the IDL, then the `IUnknown` object is reference-counted with the `AddRef` method. A memory leak occurs if the object is not handled correctly.

> [!NOTE]
> An `IUnknown` object created by the COM interface and returned in an [out] variable causes a memory leak if it is not explicitly released.

 Managed methods that handle such objects should treat <xref:System.IntPtr> as a pointer to an `IUnknown` object, and call the <xref:System.Runtime.InteropServices.Marshal.GetObjectForIUnknown%2A> method to obtain the object. The caller should then cast the return value to whatever type is appropriate. When the object is no longer needed, call <xref:System.Runtime.InteropServices.Marshal.Release%2A> to release it.

 Following is an example of calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame.QueryViewInterface%2A> method and handling the `IUnknown` object correctly:

```
MyClass myclass;
Object object;
IntPtr pObj;
Guid iid = Typeof(MyClass).Guid;
int hr = windowFrame.QueryViewInterface(ref iid, out pObj);
if (NativeMethods.Succeeded(hr))
{
    try
    {
        object = Marshal.GetObjectForIUnknown(pObj);
        myclass = object;
    }
    finally
    {
        Marshal.Release(pObj);
    }
}
else
{
    // error calling QueryViewInterface
}
```

> [!NOTE]
> The following methods are known to pass `IUnknown` object pointers as type <xref:System.IntPtr>. Handle them as described in this section.

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectFactory.CreateProject%2A>

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsOwnedProjectFactory.InitializeForOwner%2A>

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.GetNestedHierarchy%2A>

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolution.CreateProject%2A>

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame.QueryViewInterface%2A>

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectCfg2.get_CfgType%2A>

## Optional [out] Parameters
 Look for parameters that are defined as an [out] data type (`int`, `object`, and so on) in the COM interface, but that are defined as arrays of the same data type in the Visual Studio interop assembly method prototype.

 Some COM interfaces, such as <xref:Microsoft.VisualStudio.Shell.Interop.IVsCfgProvider2.GetCfgs%2A>, treat [out] parameters as optional. If an object is not required, these COM interfaces return a `null` pointer as the value of that parameter instead of creating the [out] object. This is by design. For these interfaces, `null` pointers are assumed as part of the correct behavior of the VSPackage, and no error is returned.

 Because the CLR does not allow the value of an [out] parameter to be `null`, part of the designed behavior of these interfaces is not directly available within managed code. The Visual Studio interop assembly methods for affected interfaces work around the issue by defining the relevant parameters as arrays because the CLR allows the passing of `null` arrays.

 Managed implementations of these methods should put a `null` array into the parameter when there is nothing to be returned. Otherwise, create a one-element array of the correct type and put the return value in the array.

 Managed methods that receive information from interfaces with optional [out] parameters receive the parameter as an array. Just examine the value of the first element of the array. If it is not `null`, treat the first element as if it were the original parameter.

## Passing Constants in Pointer Parameters
 Look for parameters that are defined as [in] pointers in the COM interface, but that are defined as a <xref:System.IntPtr> type in the Visual Studio interop assembly method prototype.

 A similar issue occurs when a COM interface passes a special value, such as 0, -1, or -2, instead of an object pointer. Unlike Visual C++, the CLR does not allow constants to be cast as objects. Instead, the Visual Studio interop assembly defines the parameter as a <xref:System.IntPtr> type.

 Managed implementations of these methods should take advantage of the fact that the <xref:System.IntPtr> class has both `int` and `void *` constructors to create an <xref:System.IntPtr> from either an object or an integer constant, as appropriate.

 Managed methods that receive <xref:System.IntPtr> parameters of this type should use the <xref:System.IntPtr> type conversion operators to handle the results. First convert the <xref:System.IntPtr> to `int` and test it against relevant integer constants. If no values match, convert it to an object of the required type and continue.

 For examples of this, see <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor%2A> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenSpecificEditor%2A>.

## OLE Return Values Passed as [out] Parameters
 Look for methods that have a `retval` return value in the COM interface, but that have an `int` return value and an additional [out] array parameter in the Visual Studio interop assembly method prototype. It should be clear that these methods require special handling because the Visual Studio interop assembly method prototypes have one more parameter than the COM interface methods.

 Many COM interfaces that deal with OLE activity send information about OLE status back to the calling program stored in the `retval` return value of the interface. Instead of using a return value, the corresponding Visual Studio interop assembly methods send the information back to the calling program stored in an [out] array parameter.

 Managed implementations of these methods should create a single-element array of the same type as the [out] parameter and put it in the parameter. The value of the array element should be the same as the appropriate COM `retval`.

 Managed methods that call interfaces of this type should pull the first element out of the [out] array. This element can be treated as if it were a `retval` return value from the corresponding COM interface.

## Related content
- [Interoperating with Unmanaged Code](/dotnet/framework/interop/index)
