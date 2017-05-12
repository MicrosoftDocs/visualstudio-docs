---
title: "Hosting the JavaScript Runtime | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 30ec744e-57cc-4ef5-8fe1-d2c27b946548
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Hosting the JavaScript Runtime
The JavaScript Runtime (JsRT) APIs provide a way for desktop, Windows Store, and server-side applications running on the Windows operating system to add scripting capabilities to the application by using the standards-based Chakra JavaScript engine that is also utilized by Microsoft Edge and Internet Explorer. These APIs are available on Windows 10 and any version of the Windows operating system that has Internet Explorer version 11.0 installed on the machine. For more info, see [Reference (JavaScript Runtime)](../chakra-hosting/reference-javascript-runtime.md). For info on using the JsRT in Windows Store apps, see [JsRT and the Universal Windows Platform](#Windows).  
  
> [!NOTE]
>  This documentation assumes a general working familiarity with the JavaScript language.  
  
## Concepts  
 Understanding how to host the JavaScript engine using the JsRT APIs depends on two key concepts: runtimes and execution contexts.  
  
 A *runtime* represents a complete JavaScript execution environment. Each runtime that is created has its own isolated garbage collected heap and, by default, its own just-in-time (JIT) compiler thread and garbage collector (GC) thread. An *execution context* represents a JavaScript environment that has its own JavaScript global object distinct from all other execution contexts. One runtime may contain multiple execution contexts, and in such cases, all the execution contexts share the JIT compiler and GC thread associated with the runtime.  
  
 Runtimes represent a single thread of execution. Only one runtime can be active on a particular thread at a time, and a runtime can only be active on one thread at a time. Runtimes are rental threaded, so a runtime that is not currently active on a thread (i.e. isn't running any JavaScript code or responding to any calls from the host) can be used on any thread that doesn't already have an active runtime on it.  
  
 Execution contexts are tied to a particular runtime and execute code within that runtime. Unlike runtimes, multiple execution contexts can be active on a thread at the same time. So a host can make a call into an execution context, that execution context can call back to the host, and the host can make a call into a different execution context.  
  
 ![Multiple Execution Contexts](../chakra-hosting/media/js-chakra-hosting.png "JS_Chakra_Hosting")  
  
 In practice, unless a host needs to run code in separated environments, a single execution context can be used. Similarly, unless a host needs to run multiple pieces of code concurrently, a single runtime is sufficient.  
  
## Memory management  
 JavaScript is a garbage collected language, and thus there are several considerations that must be kept in mind when working with the JsRT APIs from another language.  
  
 The main consideration is that the JavaScript garbage collector can only see references to values in two places: its runtime's heap, and the stack. Thus, a reference to a JavaScript value that is stored inside of another JavaScript value or in a local variable on the stack will always be seen by the garbage collector. But references stored in other locations, such as heaps managed by the host or the system, will not be seen by the garbage collector and may result in premature collection of values that are still in use by the host.  
  
> [!IMPORTANT]
>  Some language compilers (such as the Visual Studio C++ compiler) will optimize away local variables where possible. Care must be taken to ensure that local variables that reference JavaScript values are on the stack if they are expected to keep those values alive.  
  
 If a reference to a JavaScript value will be stored in a location not visible to the garbage collector, the host must manually add and remove references using the JsRT APIs.  
  
## Exception handling  
 When a JavaScript exception occurs during script execution, the containing runtime is put into an exception state. While in an exception state, no code can run and all API calls will fail with the error code `JsErrorInExceptionState` until the host retrieves and clears the exception using the `JsGetAndClearException` API. If the host returns from a JavaScript callback without clearing the runtime from an exception state, then the JavaScript exception will be re-thrown as soon as control passes back to the JavaScript engine. This also enables host callbacks to "throw" a JavaScript exception by setting the runtime into an exception state and then returning from a host callback.  
  
 A host is not allowed to let its own internal exceptions to propagate across a host callback—any callback methods must catch all host exceptions before returning control to the runtime.  
  
## Runtime resource usage  
 The JsRT APIs expose a number of way to monitor and modify the way runtimes use resources. They generally break down into the following categories:  
  
-   **Thread Usage**. By default, each runtime will create a dedicated JIT compiler thread and a dedicated GC thread that service that runtime. If a runtime is created with the `JsRuntimeAttributeDisableBackgroundWork` flag, then the JIT and GC work will be performed on the runtime thread itself instead of separate background threads for each one of them. A host can also supply a thread service callback to the `JsCreateRuntime` call, which will allow the host to schedule JIT and GC work in any way it sees fit.  
  
-   **Memory Usage**. There are several ways to monitor and modify the memory usage of a runtime. If the runtime will be running for a long time, the host can specify the `JsRuntimeAttributeEnableIdleProcessing` flag when creating the runtime and then call `JsIdle` when the host is in an idle state. This allows the engine to defer some memory cleanup and bookkeeping work until idle time.  
  
     The host can monitor garbage collections by calling `JsSetRuntimeBeforeCollectCallback`. It can also monitor allocations made by the heap by calling `JsSetRuntimeMemoryAllocationCallback`. Note that this API does not call back on every JavaScript allocation, just when the runtime's heap needs more space from which to allocate. The memory allocation callback is allowed to deny the request, which will trigger a garbage collection and, if no memory is available, an out of memory error in the runtime.  
  
     The host can also call `JsSetRuntimeMemoryLimit` to set a limit for how much memory a runtime can use. When a runtime hits a limit, it will trigger a garbage collection and, if no memory is available, an out of memory error will be thrown by the runtime.  
  
-   **Script Interruption and Evaluation**. The host can call `JsDisableRuntimeExecution` to terminate execution within a runtime. This call can be made at any time and from any thread. Because script termination depends on reaching guard points inserted into the code, a script may not terminate at the exact moment, but will do so very shortly afterwards. By default, termination guard points are placed in the generated code conservatively and may not cover every situation, such as an infinite loop. Creating the runtime with the `JsRuntimeAttributeAllowScriptInterrupt` flag causes the runtime to insert additional checks for infinite loops, often at the cost of a small performance overhead.  
  
     If a host wishes to disallow generation of native code by the JIT compiler, it can specify the `JsRuntimeAttributeDisableNativeCodeGeneration` flag. A host can also disallow scripts from dynamically running scripts itself by specifying the `JsRuntimeAttributeDisableEval` flag.  
  
## Debugging and Profiling  
 JsRT APIs supports debugging and profiling via the Active Scripting technology.  
  
 Starting in Windows 10, the Chakra JavaScript Engine supports a legacy engine and Edge engine, and you can target either in JsRT (see [Targeting Edge vs. Legacy Engines](../chakra-hosting/targeting-edge-vs-legacy-engines-in-jsrt-apis.md) for details). Debugging a script in Visual Studio works differently between the legacy and the Edge engine. With the legacy engine, the host needs to provide an [IDebugApplication Interface](../winscript/reference/idebugapplication-interface.md) pointer, which can be obtained from an [IProcessDebugManager Interface](../winscript/reference/iprocessdebugmanager-interface.md) instance. With the Edge engine, `IDebugApplication` is deprecated, and the Chakra engine enables native and script debugging capabilities through the Visual Studio debugger without requiring an implementation of `IDebugApplication` from the user.  
  
 To make scripts in an execution context debuggable, the Chakra engine has to switch to using less efficient code execution methods. As such, debuggable code typically runs slower than non-debuggable code. As a result, with the legacy engine, a host can choose to either start debugging in an execution context from the beginning by providing the `IDebugApplication` pointer up front through `JsCreateContext`, or it can wait until debugging is needed and then call `JsStartDebugging`. With the Edge engine, `JsCreateContext` no longer takes an `IDebugApplication` parameter, and as a result the script is debuggable only after `JsStartDebugging` is called. When debugging using Visual Studio, the "Script" debugger option must be enabled.  
  
 The JavaScript code in an execution context can be profiled in one of two ways. The command line Visual Studio Profiler (vsperf.exe) can be used in Windows 8.1 and later versions with the /js switch to produce a report that targets the JavaScript code run in the application. Or the host can directly call `JsStartProfiling` and `JsStopProfiling` and provide a callback to do profiling itself. The host can also examine the state of the garbage collected heap by calling `JsEnumerateHeap`. Profiling in JsRT works in the same manner between the legacy and the Edge engine. However, JsRT profiling APIs (`JsStartProfiling`, `JsStopProfiling`, `JsEnumerateHeap`, and `JsIsEnumeratingHeap`) are not available for Universal Windows Apps.  
  
<a name="Windows"></a>   
## JsRT and the Universal Windows Platform  
 You can use JsRT APIs to add scripting capabilities to a Universal Windows app. A Universal Windows app that uses the JsRT APIs will need to target the Edge JSRT APIs, which in turn target the Edge Chakra engine. For more information, see [Targeting Edge vs. Legacy Engines](../chakra-hosting/targeting-edge-vs-legacy-engines-in-jsrt-apis.md). The complete JsRT API is available for Universal Windows apps, except for profiling and heap enumeration support (`JsStartProfiling`, `JsStopProfiling`, `JsEnumerateHeap`, and `JsIsEnumeratingHeap` are not supported).  
  
 JsRT also allows scripts to natively access any [Universal Windows Platform (UWP) APIs](https://msdn.microsoft.com/en-us/library/windows/apps/br211377.aspx) after exposing the API namespace through Edge JsRT API `JsProjectWinRTNamespace`. While Universal Windows Applications require no setup in addition to projecting necessary namespaces, in a Classic (Win32) Windows Application, a COM-initialized delegated pumping mechanism needs to be enabled through `JsSetProjectionEnqueueCallback` to enable events and asynchronous APIs. The following Win32 sample utilizes asynchronous UWP APIs to create an http client to get content from a Uri:  
  
```cpp  
typedef struct _jsCall {  
    JsProjectionCallback jsCallback;  
    JsProjectionCallbackContext jsContext;  
    HANDLE event;  
} jsCall;  
  
// Set up delegated pumping mechanism; not necessary in UWP applications.  
jsCall outstandingCall = {};  
CoInitializeEx(nullptr, COINIT_MULTITHREADED);  
JsSetProjectionEnqueueCallback([](JsProjectionCallback jsCallback,   
JsProjectionCallbackContext jsContext, void *callbackState) {  
    jsCall* call = (jsCall*)callbackState;  
    call->jsCallback = jsCallback;  
    call->jsContext = jsContext;  
    SetEvent(call->event);  
    },  
&outstandingCall);  
HANDLE event = CreateEventEx(NULL, NULL, CREATE_EVENT_MANUAL_RESET, EVENT_ALL_ACCESS);  
outstandingCall.event = event;  
  
// Project necessary namespaces.  
JsProjectWinRTNamespace(L"Windows.Foundation");  
JsProjectWinRTNamespace(L"Windows.Web");  
  
// Get content from an Uri.  
JsRunScript(L"var uri = new Windows.Foundation.Uri(\"http://somedatasource.com\"); " \  
    L"var httpClient = new Windows.Web.Http.HttpClient();" \  
    L"httpClient.getStringAsync(uri).done(function (content) { " \  
    L"    // do something with the string content " \    
    L"}, onError); " \  
    L"function onError(reason) { " \  
    L"    // error handling " \        
    L"}",   
    currentSourceContext, L"", &result);  
  
// Wait for async call to come in and then execute; not necessary in UWP applications.  
WaitForSingleObjectEx(outstandingCall.event, 10000, FALSE) == WAIT_OBJECT_0;  
outstandingCall.jsCallback(outstandingCall.jsContext);  
  
```  
  
## See Also  
 [JavaScript Runtime Sample App](http://go.microsoft.com/fwlink/p/?LinkID=306674&clcid=0x409)   
 [Reference (JavaScript Runtime)](../chakra-hosting/reference-javascript-runtime.md)   
 [JavaScript Runtime Hosting](../chakra-hosting/javascript-runtime-hosting.md)