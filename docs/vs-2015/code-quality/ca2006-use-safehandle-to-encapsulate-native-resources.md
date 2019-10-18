---
title: "CA2006: Use SafeHandle to encapsulate native resources | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2006"
  - "UseSafeHandleToEncapsulateNativeResources"
helpviewer_keywords:
  - "UseSafeHandleToEncapsulateNativeResources"
  - "CA2006"
ms.assetid: a71950bd-bcc1-463d-b1f2-5233bc451456
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2006: Use SafeHandle to encapsulate native resources
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|UseSafeHandleToEncapsulateNativeResources|
|CheckId|CA2006|
|Category|Microsoft.Reliability|
|Breaking Change|Non-breaking|

## Cause
 Managed code uses <xref:System.IntPtr> to access native resources.

## Rule Description
 Use of `IntPtr` in managed code might indicate a potential security and reliability problem. All uses of `IntPtr` must be reviewed to determine whether the use of a <xref:System.Runtime.InteropServices.SafeHandle> , or a similar technology, is required in its place. Problems will occur if the `IntPtr` represents some native resource, such as memory, a file handle, or a socket, that the managed code is considered to own. If the managed code owns the resource, it must also release the native resources associated with it, because a failure to do so would cause resource leakage.

 In such scenarios, security or reliability problems will also exist if multithreaded access is allowed to the `IntPtr` and a way of releasing the resource that is represented by the `IntPtr` is provided. These problems involve recycling of the `IntPtr` value on resource release while simultaneous use of the resource is being made on another thread. This can cause race conditions where one thread can read or write data that is associated with the wrong resource. For example, if your type stores an OS handle as an `IntPtr` and allows users to call both **Close** and any other method that uses that handle simultaneously and without some kind of synchronization, your code has a handle recycling problem.

 This handle recycling problem can cause data corruption and, frequently, a security vulnerability. `SafeHandle` and its sibling class <xref:System.Runtime.InteropServices.CriticalHandle> provide a mechanism to encapsulate a native handle to a resource so that such threading problems can be avoided. Additionally, you can use `SafeHandle` and its sibling class `CriticalHandle` for other threading issues, for example, to carefully control the lifetime of managed objects that contain a copy of the native handle over calls to native methods. In this situation, you can often remove calls to `GC.KeepAlive`. The performance overhead thay you incur when you use `SafeHandle` and, to a lesser degree, `CriticalHandle`, can frequently be reduced through careful design.

## How to Fix Violations
 Convert `IntPtr` usage to `SafeHandle` to safely manage access to native resources. See the <xref:System.Runtime.InteropServices.SafeHandle> reference topic for examples.

## When to Suppress Warnings
 You should not suppress this warning.

## See Also
 <xref:System.IDisposable>
