---
title: SDK Helpers for Debugging
description: Learn about functions and declarations that are global helper functions for implementing debug engines, expression evaluators, and symbol providers in C++.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- dbgmetric.lib
- registry, Debugging SDK
- Debugging SDK, registry locations
- dbgmetric.h
- metrics [Debugging SDK]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# SDK Helpers for Debugging

These functions and declarations are global helper functions for implementing debug engines, expression evaluators, and symbol providers in C++.

> [!NOTE]
> There are no managed versions of these functions and declarations at this time.

 In order for debug engines, expression evaluators, and symbol providers to be used by Visual Studio, they must be registered. This is done by setting registry subkeys and entries, otherwise known as "setting metrics." The following global functions are designed to ease the process of updating these metrics. See the section on Registry Locations to find out the layout of each registry subkey that is updated by these functions.

## General Metric Functions
 These are general functions used by debug engines. Specialized functions for expression evaluators and symbol providers are detailed later.

### GetMetric Method
 Retrieves a metric value from the registry.

```cpp
HRESULT GetMetric(
   LPCWSTR pszMachine,
   LPCWSTR pszType,
   REFGUID guidSection,
   LPCWSTR pszMetric,
   DWORD * pdwValue,
   LPCWSTR pszAltRoot
);
```

|Parameter|Description|
|---------------|-----------------|
|pszMachine|[in] Name of a possibly remote machine whose register will be written (`NULL` means local machine).|
|pszType|[in] One of the metric types.|
|guidSection|[in] GUID of a specific engine, evaluator, exception, etc. This specifies a subsection under a metric type for a specific element.|
|pszMetric|[in] The metric to be obtained. This corresponds to a specific value name.|
|pdwValue|[in] The storage location of the value from the metric. There are several flavors of GetMetric that can return a DWORD (as in this example), a BSTR, a GUID, or an array of GUIDs.|
|pszAltRoot|[in] An alternate registry root to use. Set to `NULL` to use the default.|

### SetMetric Method
 Sets the specified metric value in the registry.

```cpp
HRESULT SetMetric(
         LPCWSTR pszType,
         REFGUID guidSection,
         LPCWSTR pszMetric,
   const DWORD   dwValue,
         bool    fUserSpecific,
         LPCWSTR pszAltRoot
);
```

|Parameter|Description|
|---------------|-----------------|
|pszType|[in] One of the metric types.|
|guidSection|[in] GUID of a specific engine, evaluator, exception, etc. This specifies a subsection under a metric type for a specific element.|
|pszMetric|[in] The metric to be obtained. This corresponds to a specific value name.|
|dwValue|[in] The storage location of the value in the metric. There are several flavors of SetMetric that can store a DWORD (in this example), a BSTR, a GUID, or an array of GUIDs.|
|fUserSpecific|[in] TRUE if the metric is user-specific and if it should be written to the user's hive instead of the local machine hive.|
|pszAltRoot|[in] An alternate registry root to use. Set to `NULL` to use the default.|

### RemoveMetric Method
 Removes the specified metric from the registry.

```cpp
HRESULT RemoveMetric(
   LPCWSTR pszType,
   REFGUID guidSection,
   LPCWSTR pszMetric,
   LPCWSTR pszAltRoot
);
```

|Parameter|Description|
|---------------|-----------------|
|pszType|[in] One of the metric types.|
|guidSection|[in] GUID of a specific engine, evaluator, exception, etc. This specifies a subsection under a metric type for a specific element.|
|pszMetric|[in] The metric to be removed. This corresponds to a specific value name.|
|pszAltRoot|[in] An alternate registry root to use. Set to `NULL` to use the default.|

### EnumMetricSections Method
 Enumerates the various metric sections in the registry.

```cpp
HRESULT EnumMetricSections(
   LPCWSTR pszMachine,
   LPCWSTR pszType,
   GUID *  rgguidSections,
   DWORD * pdwSize,
   LPCWSTR pszAltRoot
);
```

|Parameter|Description|
|---------------|-----------------|
|pszMachine|[in] Name of a possibly remote machine whose register will be written (`NULL` means local machine).|
|pszType|[in] One of the metric types.|
|rgguidSections|[in, out] Preallocated array of GUIDs to be filled in.|
|pdwSize|[in] The maximum number of GUIDs that can be stored in the `rgguidSections` array.|
|pszAltRoot|[in] An alternate registry root to use. Set to `NULL` to use the default.|

## Expression Evaluator Functions

|Function|Description|
|--------------|-----------------|
|GetEEMetric|Retrieves a metric value from the registry.|
|SetEEMetric|Sets the specified metric value in the registry.|
|RemoveEEMetric|Removes the specified metric from the registry.|
|GetEEMetricFile|Gets a file name from the specified metric and loads it, returning the file contents as a string.|

## Exception Functions

|Function|Description|
|--------------|-----------------|
|GetExceptionMetric|Retrieves a metric value from the registry.|
|SetExceptionMetric|Sets the specified metric value in the registry.|
|RemoveExceptionMetric|Removes the specified metric from the registry.|
|RemoveAllExceptionMetrics|Removes all exception metrics from the registry.|

## Symbol Provider Functions

|Function|Description|
|--------------|-----------------|
|GetSPMetric|Retrieves a metric value from the registry.|
|SetSPMetric|Sets the specified metric value in the registry.|
|RemoveSPMetric|Removes the specified metric from the registry.|

## Enumeration Functions

|Function|Description|
|--------------|-----------------|
|EnumMetricSections|Enumerates all metrics for a specified metric type.|
|EnumDebugEngine|Enumerates the registered debug engines.|
|EnumEEs|Enumerates the registered expression evaluators.|
|EnumExceptionMetrics|Enumerates all exception metrics.|

## Metric Definitions
 These definitions can be used for predefined metric names. The names correspond to various registry keys and value names and are all defined as wide character strings: for example, `extern LPCWSTR metrictypeEngine`.

|Predefined Metric Types|Description: The base key for....|
|-----------------------------|---------------------------------------|
|metrictypeEngine|All debug engine metrics.|
|metrictypePortSupplier|All port supplier metrics.|
|metrictypeException|All exception metrics.|
|metricttypeEEExtension|All expression evaluator extensions.|

|Debug Engine Properties|Description|
|-----------------------------|-----------------|
|metricAddressBP|Set to nonzero to indicate support for address breakpoints.|
|metricAlwaysLoadLocal|Set to nonzero in order to always load the debug engine locally.|
|metricLoadInDebuggeeSession|NOT USED|
|metricLoadedByDebuggee|Set to nonzero to indicate that the debug engine will always be loaded with or by the program being debugged.|
|metricAttach|Set to nonzero to indicate support for attachment to existing programs.|
|metricCallStackBP|Set to nonzero to indicate support for call stack breakpoints.|
|metricConditionalBP|Set to nonzero to indicate support for the setting of conditional breakpoints.|
|metricDataBP|Set to nonzero to indicate support for the setting of breakpoints on changes in data.|
|metricDisassembly|Set to nonzero to indicate support for the production of a disassembly listing.|
|metricDumpWriting|Set to nonzero to indicate support for dump writing (the dumping of memory to an output device).|
|metricENC|Set to nonzero to indicate support for Edit and Continue. **Note:**  A custom debug engine should never set this or should always set it to 0.|
|metricExceptions|Set to nonzero to indicate support for exceptions.|
|metricFunctionBP|Set to nonzero to indicate support for named breakpoints (breakpoints that break when a certain function name is called).|
|metricHitCountBP|Set to nonzero to indicate support for the setting of "hit point" breakpoints (breakpoints that are triggered only after being hit a certain number of times).|
|metricJITDebug|Set to nonzero to indicate support for just-in-time debugging (the debugger is launched when an exception occurs in a running process).|
|metricMemory|NOT USED|
|metricPortSupplier|Set this to the CLSID of the port supplier if one is implemented.|
|metricRegisters|NOT USED|
|metricSetNextStatement|Set to nonzero to indicate support for setting the next statement (which skips execution of intermediate statements).|
|metricSuspendThread|Set to nonzero to indicate support for suspending thread execution.|
|metricWarnIfNoSymbols|Set to nonzero to indicate that the user should be notified if there are no symbols.|
|metricProgramProvider|Set this to the CLSID of the program provider.|
|metricAlwaysLoadProgramProviderLocal|Set this to nonzero to indicate that the program provider should always be loaded locally.|
|metricEngineCanWatchProcess|Set this to nonzero to indicate that the debug engine will watch for process events instead of the program provider.|
|metricRemoteDebugging|Set this to nonzero to indicate support for remote debugging.|
|metricEncUseNativeBuilder|Set this to nonzero to indicate that the Edit and Continue Manager should use the debug engine's encbuild.dll to build for Edit and Continue. **Note:**  A custom debug engine should never set this or should always set it to 0.|
|metricLoadUnderWOW64|Set this to nonzero to indicate that the debug engine should be loaded in the debuggee process under WOW when debugging a 64-bit process; otherwise, the debug engine will be loaded in the Visual Studio process (which is running under WOW64).|
|metricLoadProgramProviderUnderWOW64|Set this to nonzero to indicate that the program provider should be loaded in the debuggee process when debugging a 64-bit process under WOW; otherwise, it will be loaded in the Visual Studio process.|
|metricStopOnExceptionCrossingManagedBoundary|Set this to nonzero to indicate that the process should stop if an unhandled exception is thrown across managed/unmanaged code boundaries.|
|metricAutoSelectPriority|Set this to a priority for automatic selection of the debug engine (higher values equals higher priority).|
|metricAutoSelectIncompatibleList|Registry key containing entries that specify GUIDs for debug engines to be ignored in automatic selection. These entries are a number (0, 1, 2, and so on) with a GUID expressed as a string.|
|metricIncompatibleList|Registry key containing entries that specify GUIDs for debug engines that are incompatible with this debug engine.|
|metricDisableJITOptimization|Set this to nonzero to indicate that just-in-time optimizations (for managed code) should be disabled during debugging.|

|Expression Evaluator Properties|Description|
|-------------------------------------|-----------------|
|metricEngine|This holds the number of debug engines that support the specified expression evaluator.|
|metricPreloadModules|Set this to nonzero to indicate that modules should be preloaded when an expression evaluator is launched against a program.|
|metricThisObjectName|Set this to the "this" object name.|

|Expression Evaluator Extension Properties|Description|
| - |-----------------|
|metricExtensionDll|Name of the dll that supports this extension.|
|metricExtensionRegistersSupported|List of registers supported.|
|metricExtensionRegistersEntryPoint|Entry point for accessing registers.|
|metricExtensionTypesSupported|List of types supported.|
|metricExtensionTypesEntryPoint|Entry point for accessing types.|

|Port Supplier Properties|Description|
|------------------------------|-----------------|
|metricPortPickerCLSID|The CLSID of the port picker (a dialog box the user can use to select ports and add ports to use for debugging).|
|metricDisallowUserEnteredPorts|Nonzero if the user-entered ports cannot be added to the port supplier (this makes the port-picker dialog box essentially read-only).|
|metricPidBase|The base process ID used by the port supplier when allocating process IDs.|

|Predefined SP Store Types|Description|
|-------------------------------|-----------------|
|storetypeFile|The symbols are stored in a separate file.|
|storetypeMetadata|The symbols are stored as metadata in an assembly.|

|Miscellaneous Properties|Description|
|------------------------------|-----------------|
|metricShowNonUserCode|Set this to nonzero to show nonuser code.|
|metricJustMyCodeStepping|Set this to nonzero to indicate that stepping can occur only in user code.|
|metricCLSID|CLSID for an object of a specific metric type.|
|metricName|User-friendly name for an object of a specific metric type.|
|metricLanguage|Language name.|

## Registry Locations
 The metrics are read from and written to the registry, specifically in the `VisualStudio` subkey.

> [!NOTE]
> Most of the time, the metrics will be written to the HKEY_LOCAL_MACHINE key. However, sometimes HKEY_CURRENT_USER will be the destination key. Dbgmetric.lib handles both keys. When getting a metric, it searches HKEY_CURRENT_USER first, then HKEY_LOCAL_MACHINE. When it is setting a metric, a parameter specifies which top-level key to use.

 *[registry key]*\

 `Software`\

 `Microsoft`\

 `VisualStudio`\

 *[version root]*\

 *[metric root]*\

 *[metric type]*\

 *[metric] = [metric value]*

 *[metric] = [metric value]*

 *[metric] = [metric value]*

|Placeholder|Description|
|-----------------|-----------------|
|*[registry key]*|`HKEY_CURRENT_USER` or `HKEY_LOCAL_MACHINE`.|
|*[version root]*|The version of Visual Studio (for example, `7.0`, `7.1`, or `8.0`). However, this root can also be modified using the **/rootsuffix** switch to **devenv.exe**. For VSIP, this modifier is typically **Exp**, so the version root would be, for example, 8.0Exp.|
|*[metric root]*|This is either `AD7Metrics` or `AD7Metrics(Debug)`, depending on whether the debug version of dbgmetric.lib is used. **Note:**  Whether or not dbgmetric.lib is used, this naming convention should be adhered to if you have differences between debug and release versions that must be reflected in the registry.|
|*[metric type]*|The type of metric to be written: `Engine`, `ExpressionEvaluator`, `SymbolProvider`, etc. These are all defined as in dbgmetric.h as `metricTypeXXXX`, where `XXXX` is the specific type name.|
|*[metric]*|The name of an entry to be assigned a value in order to set the metric. The actual organization of the metrics depends on the metric type.|
|*[metric value]*|The value assigned to the metric. The type the value should have (string, number, etc.) depends on the metric.|

> [!NOTE]
> All GUIDs are stored in the format of `{GUID}`. For example, `{123D150B-FA18-461C-B218-45B3E4589F9B}`.

### Debug Engines
 The following is the organization of the debug engines metrics in the registry. `Engine` is the metric type name for a debug engine and corresponds to *[metric type]* in the above registry subtree.

 `Engine`\

 *[engine guid]*\

 `CLSID` = *[class guid]*

 *[metric] = [metric value]*

 *[metric] = [metric value]*

 *[metric] = [metric value]*

 `PortSupplier`\

 `0` = *[port supplier guid]*

 `1` = *[port supplier guid]*

|Placeholder|Description|
|-----------------|-----------------|
|*[engine guid]*|The GUID of the debug engine.|
|*[class guid]*|The GUID of the class that implements this debug engine.|
|*[port supplier guid]*|The GUID of the port supplier, if any. Many debug engines use the default port supplier and therefore do not specify their own supplier. In this case, the subkey `PortSupplier` will be absent.|

### Port Suppliers
 The following is the organization of the port supplier metrics in the registry. `PortSupplier` is the metric type name for a port supplier and corresponds to *[metric type]*.

 `PortSupplier`\

 *[port supplier guid]*\

 `CLSID` = *[class guid]*

 *[metric] = [metric value]*

 *[metric] = [metric value]*

|Placeholder|Description|
|-----------------|-----------------|
|*[port supplier guid]*|The GUID of the port supplier|
|*[class guid]*|The GUID of the class that implements this port supplier|

### Symbol Providers
 The following is the organization of the symbol supplier metrics in the registry. `SymbolProvider` is the metric type name for the symbol provider and corresponds to *[metric type]*.

 `SymbolProvider`\

 *[symbol provider guid]*\

 `file`\

 `CLSID` = *[class guid]*

 *[metric] = [metric value]*

 *[metric] = [metric value]*

 `metadata`\

 `CLSID` = *[class guid]*

 *[metric] = [metric value]*

 *[metric] = [metric value]*

|Placeholder|Description|
|-----------------|-----------------|
|*[symbol provider guid]*|The GUID of the symbol provider|
|*[class guid]*|The GUID of the class that implements this symbol provider|

### Expression Evaluators
 The following is the organization of the expression evaluator metrics in the registry. `ExpressionEvaluator` is the metric type name for the expression evaluator and corresponds to *[metric type]*.

> [!NOTE]
> The metric type for `ExpressionEvaluator` is not defined in dbgmetric.h, as it is assumed that all metric changes for expression evaluators will go through the appropriate expression evaluator metric functions (the layout of the `ExpressionEvaluator` subkey is somewhat complicated, so the details are hidden inside dbgmetric.lib).

 `ExpressionEvaluator`\

 *[language guid]*\

 *[vendor guid]*\

 `CLSID` = *[class guid]*

 *[metric] = [metric value]*

 *[metric] = [metric value]*

 `Engine`\

 `0` = *[debug engine guid]*

 `1` = *[debug engine guid]*

|Placeholder|Description|
|-----------------|-----------------|
|*[language guid]*|The GUID of a language|
|*[vendor guid]*|The GUID of a vendor|
|*[class guid]*|The GUID of the class that implements this expression evaluator|
|*[debug engine guid]*|The GUID of a debug engine that this expression evaluator works with|

### Expression Evaluator Extensions
 The following is the organization of the expression evaluator extension metrics in the registry. `EEExtensions` is the metric type name for the expression evaluator extensions and corresponds to *[metric type]*.

 `EEExtensions`\

 *[extension guid]*\

 *[metric] = [metric value]*

 *[metric] = [metric value]*

|Placeholder|Description|
|-----------------|-----------------|
|*[extension guid]*|The GUID of an expression evaluator extension|

### Exceptions
 The following is the organization of the exceptions metrics in the registry. `Exception` is the metric type name for the exceptions and corresponds to *[metric type]*.

 `Exception`\

 *[debug engine guid]*\

 *[exception types]*\

 *[exception]*\

 *[metric] = [metric value]*

 *[metric] = [metric value]*

 *[exception]*\

 *[metric] = [metric value]*

 *[metric] = [metric value]*

|Placeholder|Description|
|-----------------|-----------------|
|*[debug engine guid]*|The GUID of a debug engine that supports exceptions.|
|*[exception types]*|A general title for the subkey identifying the class of exceptions that can be handled. Typical names are **C++ Exceptions**, **Win32 Exceptions**, **Common Language Runtime Exceptions**, and **Native Run-Time Checks**. These names are also used to identify a particular class of exception to the user.|
|*[exception]*|A name for an exception: for example, **_com_error** or **Control-Break**. These names are also used to identify a particular exception to the user.|

## Requirements
 These files are located in the Microsoft Visual Studio 2010 SDK installation directory (by default, *[drive]*\Program Files\Microsoft Visual Studio 2010 SDK\\).

 Header: includes\dbgmetric.h

 Library: libs\ad2de.lib, libs\dbgmetric.lib

## See also
- [API Reference](../../../extensibility/debugger/reference/api-reference-visual-studio-debugging.md)
