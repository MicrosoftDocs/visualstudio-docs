---
title: Registering an Expression Evaluator
description: Learn how the expression evaluator must register itself as a class factory with both the Windows COM environment and Visual Studio.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- debugging [Debugging SDK], expression evaluation
- expression evaluators, registering
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Register an expression evaluator

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, see [CLR expression evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed expression evaluator sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 The expression evaluator (EE) must register itself as a class factory with both the Windows COM environment and Visual Studio. An EE is set up as a DLL so that it's injected into either the debug engine (DE) address space or the Visual Studio address space, depending on which entity instantiates the EE.

## Managed code expression evaluator
 A managed code EE is implemented as a Class Library, which is a DLL that registers itself with the COM environment, typically started by a call to the VSIP program, *regpkg.exe*. The actual process of writing the registry keys for the COM environment is handled automatically.

 A method of the main class is marked with <xref:System.Runtime.InteropServices.ComRegisterFunctionAttribute>, indicating that the method is to be called when the DLL is being registered with COM. This registration method, often called `RegisterClass`, performs the task of registering the DLL with Visual Studio. A corresponding `UnregisterClass` (marked with the <xref:System.Runtime.InteropServices.ComUnregisterFunctionAttribute>), undoes the effects of `RegisterClass` when the DLL is uninstalled.
 The same registry entries are made as for an EE written in unmanaged code; the only difference is that there is no helper function such as `SetEEMetric` to do the work for you. Following is an example of the registration and unregistration process.

### Example
 The following function shows how a managed code EE registers and unregisters itself with Visual Studio.

```csharp
namespace EEMC
{
    [GuidAttribute("462D4A3D-B257-4AEE-97CD-5918C7531757")]
    public class EEMCClass : IDebugExpressionEvaluator
    {
        #region Register and unregister.
        private static Guid guidMycLang = new Guid("462D4A3E-B257-4AEE-97CD-5918C7531757");
        private static string languageName = "MyC";
        private static string eeName = "MyC Expression Evaluator";

        private static Guid guidMicrosoftVendor = new Guid("994B45C4-E6E9-11D2-903F-00C04FA302A1");
        private static Guid guidCOMPlusOnlyEng = new Guid("449EC4CC-30D2-4032-9256-EE18EB41B62B");
        private static Guid guidCOMPlusNativeEng = new Guid("92EF0900-2251-11D2-B72E-0000F87572EF");

        /// <summary>
        /// Register the expression evaluator.
        /// Set "project properties/configuration properties/build/register for COM interop" to true.
        /// </summary>
         [ComRegisterFunctionAttribute]
        public static void RegisterClass(Type t)
        {
            // Get Visual Studio version (set by regpkg.exe)
            string hive = Environment.GetEnvironmentVariable("EnvSdk_RegKey");
            string s = @"SOFTWARE\Microsoft\VisualStudio\"
                        + hive
                        + @"\AD7Metrics\ExpressionEvaluator";

            RegistryKey rk = Registry.LocalMachine.CreateSubKey(s);
            if (rk == null)  return;

            rk = rk.CreateSubKey(guidMycLang.ToString("B"));
            rk = rk.CreateSubKey(guidMicrosoftVendor.ToString("B"));
            rk.SetValue("CLSID", t.GUID.ToString("B"));
            rk.SetValue("Language", languageName);
            rk.SetValue("Name", eeName);

            rk = rk.CreateSubKey("Engine");
            rk.SetValue("0", guidCOMPlusOnlyEng.ToString("B"));
            rk.SetValue("1", guidCOMPlusNativeEng.ToString("B"));
        }
        /// <summary>
        /// Unregister the expression evaluator.
        /// </summary>
         [ComUnregisterFunctionAttribute]
        public static void UnregisterClass(Type t)
        {
            // Get Visual Studio version (set by regpkg.exe)
            string hive = Environment.GetEnvironmentVariable("EnvSdk_RegKey");
            string s = @"SOFTWARE\Microsoft\VisualStudio\"
                        + hive
                        + @"\AD7Metrics\ExpressionEvaluator\"
                        + guidMycLang.ToString("B");
            RegistryKey key = Registry.LocalMachine.OpenSubKey(s);
            if (key != null)
            {
                key.Close();
                Registry.LocalMachine.DeleteSubKeyTree(s);
            }
        }
    }
}
```

## Unmanaged code expression evaluator
 The EE DLL implements the `DllRegisterServer` function to register itself with the  COM environment as well as Visual Studio.

> [!NOTE]
> You can find the MyCEE code sample registry code in the file *dllentry.cpp*, which is located in the VSIP installation under EnVSDK\MyCPkgs\MyCEE.

### DLL server process
 When registering the EE, the DLL server:

1. Registers its class factory `CLSID` as per normal COM conventions.

2. Calls the helper function `SetEEMetric` to register with Visual Studio the EE metrics shown in the following table. The function `SetEEMetric` and the metrics specified as follows are part of the *dbgmetric.lib* library. See [SDK helpers for debugging](../../extensibility/debugger/reference/sdk-helpers-for-debugging.md) for details.

    |Metric|Description|
    |------------|-----------------|
    |`metricCLSID`|`CLSID` of the EE class factory|
    |`metricName`|Name of the EE as a displayable string|
    |`metricLanguage`|The name of the language that the EE is designed to evaluate|
    |`metricEngine`|`GUID`s of the debug engines (DE) that work with this EE|

    > [!NOTE]
    > The `metricLanguage``GUID` identifies the language by name, but it is the `guidLang` argument to `SetEEMetric` that selects the language. When the compiler generates the debug information file, it should write the appropriate `guidLang` so that the DE knows which EE to use. The DE typically asks the symbol provider for this language `GUID`, which is stored in the debug information file.

3. Registers with Visual Studio by creating keys under HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\\*X.Y*, where *X.Y* is the version of Visual Studio to register with.

### Example
 The following function shows how an unmanaged code (C++) EE registers and unregisters itself with Visual Studio.

```cpp
/*---------------------------------------------------------
  Registration
-----------------------------------------------------------*/
#ifndef LREGKEY_VISUALSTUDIOROOT
    #define LREGKEY_VISUALSTUDIOROOT L"Software\\Microsoft\\VisualStudio\\8.0"
#endif

static HRESULT RegisterMetric( bool registerIt )
{
    // check where we should register
    const ULONG cchBuffer = _MAX_PATH;
    WCHAR wszRegistrationRoot[cchBuffer];
    DWORD cchFreeBuffer = cchBuffer - 1;
    wcscpy(wszRegistrationRoot, LREGKEY_VISUALSTUDIOROOT_NOVERSION);
    wcscat(wszRegistrationRoot, L"\\");

    // this is Environment SDK specific
    // we check for  EnvSdk_RegKey environment variable to
    // determine where to register
    DWORD cchDefRegRoot = lstrlenW(LREGKEY_VISUALSTUDIOROOT_NOVERSION) + 1;
    cchFreeBuffer = cchFreeBuffer - cchDefRegRoot;
    DWORD cchEnvVarRead = GetEnvironmentVariableW(
        /* LPCTSTR */ L"EnvSdk_RegKey", // environment variable name
        /* LPTSTR  */ &wszRegistrationRoot[cchDefRegRoot],// buffer for variable value
        /* DWORD   */ cchFreeBuffer);// size of buffer
    if (cchEnvVarRead >= cchFreeBuffer)
        return E_UNEXPECTED;
    // If the environment variable does not exist then we must use
    // LREGKEY_VISUALSTUDIOROOT which has the version number.
    if (0 == cchEnvVarRead)
        wcscpy(wszRegistrationRoot, LREGKEY_VISUALSTUDIOROOT);

    if (registerIt)
    {
        SetEEMetric(guidMycLang,
                    guidMicrosoftVendor,
                    metricCLSID,
                    CLSID_MycEE,
                    wszRegistrationRoot );
        SetEEMetric(guidMycLang,
                    guidMicrosoftVendor,
                    metricName,
                    GetString(IDS_INFO_MYCDESCRIPTION),
                    wszRegistrationRoot );
        SetEEMetric(guidMycLang,
                    guidMicrosoftVendor,
                    metricLanguage, L"MyC",
                    wszRegistrationRoot);

        GUID engineGuids[2];
        engineGuids[0] = guidCOMPlusOnlyEng;
        engineGuids[1] = guidCOMPlusNativeEng;
        SetEEMetric(guidMycLang,
                    guidMicrosoftVendor,
                    metricEngine,
                    engineGuids,
                    2,
                    wszRegistrationRoot);
    }
    else
    {
        RemoveEEMetric( guidMycLang,
                        guidMicrosoftVendor,
                        metricCLSID,
                        wszRegistrationRoot);
        RemoveEEMetric( guidMycLang,
                        guidMicrosoftVendor,
                        metricName,
                        wszRegistrationRoot );
        RemoveEEMetric( guidMycLang,
                        guidMicrosoftVendor,
                        metricLanguage,
                        wszRegistrationRoot );
        RemoveEEMetric( guidMycLang,
                        guidMicrosoftVendor,
                        metricEngine,
                        wszRegistrationRoot );
    }

    return S_OK;
}
```

## Related content
- [Writing a CLR expression evaluator](../../extensibility/debugger/writing-a-common-language-runtime-expression-evaluator.md)
- [SDK helpers for debugging](../../extensibility/debugger/reference/sdk-helpers-for-debugging.md)
