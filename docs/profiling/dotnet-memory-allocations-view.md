---
title: ".NET Memory Allocations View | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.performance.view.allocation"
helpviewer_keywords:
  - "performance reports, allocation view"
  - "Allocations view"
  - "profiling tools, Allocation view"
  - "profiling tools reports, Allocation view"
ms.assetid: 01eb876e-c413-4516-977b-4f896929e8a6
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# .NET Memory Allocations View
The Allocations view lists the types that were created during the profiling run. Each type is the root node of a call tree that displays the function execution paths that resulted in the allocations of the type.

 The data in a type row displays the total number of objects of the type that were created in the profiling run and the total number of bytes allocated for the objects of that type. Inclusive and exclusive values for a type are always the same.

- Inclusive values are for objects created in the instances of the function and its child functions that were called by the parent function in the call tree.

- Exclusive values are for objects that were created directly by the function when they were called by the parent function. Objects created in child functions are not included.

  The data for a function displays the number of objects created and the number of bytes allocated for objects of the parent type.

## Highlight the execution hot path
 You can find the execution path of the call tree  that created the most objects of the parent type.

- To display the most active path, right-click the type or function, and then click **Expand Hot Path**.

|Column|Description|
|------------|-----------------|
|**Name**|The name of the allocated type or function.|
|**Process ID**|The process ID (PID) of the profiling run.|
|**Process Name**|The name of the process.|
|**Module Name**|The name of the module that contains the type or function.|
|**Module Path**|The path of the module that contains the type or function.|
|**Source File**|The source file that contains the definition for the type or function.|
|**Function Line Number**|The line number of the start of this type definition or function in the source file.|
|**Level**|Indicates whether the data is for a type or a function.|
|**Inclusive Allocations**|-   For a function, the total number of objects of the parent type that were created by the function. This number includes objects created in child functions.<br />-   For a type, the total number of instances of that type that were created.|
|**Inclusive Allocations %**|-   For a function, the percentage of all objects created in the profiling run that were inclusive allocations of the parent type by the function.<br />-   For a type, the percentage of the total number of objects that were created in the profiling run that were instances of the type.|
|**Exclusive Allocations**|-   For a function, the number of objects that were created when the function was directly executing at the top of the call stack. This number does not include objects created in child functions.<br />-   For a type, the total number of instances of that type that were created.|
|**Exclusive Allocations %**|-   For a function, the percentage of all objects created in the profiling run that were exclusive allocations of the parent type by the function.<br />-   For a type, the percentage of the total number of objects that were created in the profiling run that were instances of the type.|
|**Inclusive Bytes**|-   For a function, the number of bytes of memory that were allocated by the function for objects of the parent type. This number includes the memory that was allocated by its child functions.<br />-   For a type, the total number of bytes that was allocated in the profiling run for the instances of the type.|
|**Inclusive Bytes %**|-   For a function, the percentage of all memory allocated in the profiling run that was inclusive allocations of the parent type by the function.<br />-   For a type, the percentage of all memory allocated in the profiling run that was allocated for instances of the type.|
|**Exclusive Bytes**|-   For a function, the number of bytes of memory that were allocated by the function for objects of the parent type. This number does not include the memory that was allocated by its child functions.<br />-   For a type, the total number of bytes that were allocated in the profiling run for the instances of the type.|
|**Exclusive Bytes %**|-   For a function, the percentage of all memory allocated in the profiling run that was exclusive allocations of the parent type by the function.<br />-   For a type, the percentage of all memory allocated in the profiling run that was allocated for instances of the type.|
