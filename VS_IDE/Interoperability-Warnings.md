---
title: "Interoperability Warnings"
ms.custom: na
ms.date: 10/04/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 95de6eb3-40c4-4063-9f59-25cb70e3b2b3
caps.latest.revision: 18
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Interoperability Warnings
Interoperability warnings support interaction with COM clients.  
  
## In This Section  
  
|Rule|Description|  
|----------|-----------------|  
|[CA1400: P/Invoke entry points should exist](../VS_IDE/CA1400--P-Invoke-entry-points-should-exist.md)|A public or protected method is marked by using the System.Runtime.InteropServices.DllImportAttribute attribute. Either the unmanaged library could not be located or the method could not be matched to a function in the library.|  
|[CA1401: P/Invokes should not be visible](../VS_IDE/CA1401--P-Invokes-should-not-be-visible.md)|A public or protected method in a public type has the System.Runtime.InteropServices.DllImportAttribute attribute (also implemented by the Declare keyword in Visual Basic). Such methods should not be exposed.|  
|[CA1402: Avoid overloads in COM visible interfaces](../VS_IDE/CA1402--Avoid-overloads-in-COM-visible-interfaces.md)|When overloaded methods are exposed to COM clients, only the first method overload retains its name. Subsequent overloads are uniquely renamed by appending to the name an underscore character (_) and an integer that corresponds to the order of declaration of the overload.|  
|[CA1403: Auto layout types should not be COM visible](../VS_IDE/CA1403--Auto-layout-types-should-not-be-COM-visible.md)|A COM-visible value type is marked by using the System.Runtime.InteropServices.StructLayoutAttribute attribute set to LayoutKind.Auto. The layout of these types can change between versions of the .NET Framework, which will break COM clients that expect a specific layout.|  
|[CA1404: Call GetLastError immediately after P/Invoke](../VS_IDE/CA1404--Call-GetLastError-immediately-after-P-Invoke.md)|A call is made to the Marshal.GetLastWin32Error method or the equivalent Win32 GetLastError function, and the immediately previous call is not to a platform invoke method.|  
|[CA1405: COM visible type base types should be COM visible](../VS_IDE/CA1405--COM-visible-type-base-types-should-be-COM-visible.md)|A COM-visible type derives from a type that is not COM-visible.|  
|[CA1406: Avoid Int64 arguments for Visual Basic 6 clients](../VS_IDE/CA1406--Avoid-Int64-arguments-for-Visual-Basic-6-clients.md)|Visual Basic 6 COM clients cannot access 64-bit integers.|  
|[CA1407: Avoid static members in COM visible types](../VS_IDE/CA1407--Avoid-static-members-in-COM-visible-types.md)|COM does not support static methods.|  
|[CA1408: Do not use AutoDual ClassInterfaceType](../VS_IDE/CA1408--Do-not-use-AutoDual-ClassInterfaceType.md)|Types that use a dual interface enable clients to bind to a specific interface layout. Any changes in a future version to the layout of the type or any base types will break COM clients that bind to the interface. By default, if the ClassInterfaceAttribute attribute is not specified, a dispatch-only interface is used.|  
|[CA1409: Com visible types should be creatable](../VS_IDE/CA1409--Com-visible-types-should-be-creatable.md)|A reference type that is specifically marked as visible to COM contains a public parameterized constructor but does not contain a public default (parameterless) constructor. A type without a public default constructor is not creatable by COM clients.|  
|[CA1410: COM registration methods should be matched](../VS_IDE/CA1410--COM-registration-methods-should-be-matched.md)|A type declares a method that is marked by using the <xref:System.Runtime.InteropServices.ComRegisterFunctionAttribute?qualifyHint=True> attribute but does not declare a method that is marked by using the <xref:System.Runtime.InteropServices.ComUnregisterFunctionAttribute?qualifyHint=True> attribute, or vice versa.|  
|[CA1411: COM registration methods should not be visible](../VS_IDE/CA1411--COM-registration-methods-should-not-be-visible.md)|A method that is marked by using the System.Runtime.InteropServices.ComRegisterFunctionAttribute attribute or the System.Runtime.InteropServices.ComUnregisterFunctionAttribute attribute is externally visible.|  
|[CA1412: Mark ComSource Interfaces as IDispatch](../VS_IDE/CA1412--Mark-ComSource-Interfaces-as-IDispatch.md)|A type is marked by using the System.Runtime.InteropServices.ComSourceInterfacesAttribute attribute, and at least one of the specified interfaces is not marked by using the System.Runtime.InteropServices.InterfaceTypeAttribute attribute set to ComInterfaceType.InterfaceIsIDispatch.|  
|[CA1413: Avoid non-public fields in COM visible value types](../VS_IDE/CA1413--Avoid-non-public-fields-in-COM-visible-value-types.md)|Nonpublic instance fields of COM-visible value types are visible to COM clients. Review the content of the fields for information that should not be exposed, or that will have unintended design or security effects.|  
|[CA1414: Mark boolean P/Invoke arguments with MarshalAs](../VS_IDE/CA1414--Mark-boolean-P-Invoke-arguments-with-MarshalAs.md)|The Boolean data type has multiple representations in unmanaged code.|  
|[CA1415: Declare P/Invokes correctly](../VS_IDE/CA1415--Declare-P-Invokes-correctly.md)|This rule looks for platform invoke method declarations that target Win32 functions that have a pointer to an OVERLAPPED structure parameter and the corresponding managed parameter is not a pointer to a <xref:System.Threading.NativeOverlapped?qualifyHint=True> structure.|