---
title: "Reliability Warnings"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 77886846-10a2-4585-968a-7eb60ebe07e8
caps.latest.revision: 21
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
# Reliability Warnings
Reliability warnings support library and application reliability, such as correct memory and thread usage.  
  
## In This Section  
  
|Rule|Description|  
|----------|-----------------|  
|[CA2000: Dispose objects before losing scope](../VS_IDE/CA2000--Dispose-objects-before-losing-scope.md)|Because an exceptional event might occur that will prevent the finalizer of an object from running, the object should be explicitly disposed before all references to it are out of scope.|  
|[CA2001: Avoid calling problematic methods](../VS_IDE/CA2001--Avoid-calling-problematic-methods.md)|A member calls a potentially dangerous or problematic method.|  
|[CA2002: Do not lock on objects with weak identity](../VS_IDE/CA2002--Do-not-lock-on-objects-with-weak-identity.md)|An object is said to have a weak identity when it can be directly accessed across application domain boundaries. A thread that tries to acquire a lock on an object that has a weak identity can be blocked by a second thread in a different application domain that has a lock on the same object.|  
|[CA2003: Do not treat fibers as threads](../VS_IDE/CA2003--Do-not-treat-fibers-as-threads.md)|A managed thread is being treated as a Win32 thread.|  
|[CA2004: Remove calls to GC.KeepAlive](../VS_IDE/CA2004--Remove-calls-to-GC.KeepAlive.md)|If you are converting to SafeHandle usage, remove all calls to GC.KeepAlive (object). In this case, classes should not have to call GC.KeepAlive, assuming they do not have a finalizer but rely on SafeHandle to finalize the OS handle for them.|  
|[CA2006: Use SafeHandle to encapsulate native resources](../VS_IDE/CA2006--Use-SafeHandle-to-encapsulate-native-resources.md)|Use of IntPtr in managed code might indicate a potential security and reliability problem. All uses of IntPtr must be reviewed to determine whether use of a SafeHandle, or similar technology, is required in its place.|