---
title: "Web.Config file - Instrument & profile dynamic ASP.NET app"
description: Learn how to use the Visual Studio Profiling Tools to collect timing and memory activity data for a dynamically compiled ASP.NET web application.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
ms.assetid: a92e5692-2183-4ae3-9431-b067c6a7aab4
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - aspnet
---
# How to: Modify web.config files to instrument and profile dynamically compiled ASP.NET web applications
You can use the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools instrumentation method to collect detailed timing data, .NET memory allocation data, and .NET object lifetime data from dynamically compiled [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] Web applications.

 This topic describes how to modify the *web.config* configuration file to enable the instrumentation and profiling of [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] Web applications.

> [!NOTE]
> You are not required to modify the *web.config* file when you use the sampling profiling method, or when you want to instrument a pre-compiled [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] module.

 The root of a *web.config* file is the **configuration** element. To instrument and profile a dynamically compiled [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] web application, you must add or modify the following elements:

- A **configuration/runtime/assemblyBinding/dependentAssembly** element that identifies the Microsoft.VisualStudio.Enterprise.ASPNetHelper assembly that controls profiling. The **dependentAssembly** element contains two child elements: **assemblyIdentity** and **codeBase**.

- A **configuration/system.web/compilation** element that identifies the profiler post-process compilation step for the target assembly.

- Two **add** elements that identify the location of the Profiling Tools tools are added to the **configuration/appSettings** section .

  We recommend that you create a copy of the original *web.config* file that you can use to restore the configuration of the application.

### To add the ASPNetHelper assembly as a configuration/runtime/assemblyBinding/dependentAssembly element

1. If necessary, add the **runtime** element as a child element of the **configuration** element; otherwise, go to the next step.

    The **runtime** element has no attributes. The **configuration** element can have only one **runtime** child element.

2. If necessary, add the **assemblyBinding** element as a child element of the **runtime** element; otherwise, go to the next step.

    The **runtime** element can have only one **assemblyBinding** element.

3. Add the following attribute name and value to the **assemblyBinding** element:

   | Attribute Name | Attribute Value |
   |----------------|--------------------------------------|
   | **Xmlns** | **urn:schemas-microsoft-com:asm.v1** |

4. Add a **dependentAssembly** element as a child element of the **assemblyBinding** element.

    The **dependentAssembly** element has no attributes.

5. Add an **assemblyIdentity** element as a child of the **dependentAssembly** element.

6. Add the following attribute names and values to the **assemblyIdentity** element:

   | Attribute Name | Attribute Value |
   |--------------------| - |
   | **name** | **Microsoft.VisualStudio.Enterprise.ASPNetHelper** |
   | **PublicKeyToken** | **b03f5f7f11d50a3a** |
   | **culture** | **Neutral** |

7. Add a **codeBase** element as a child of the **dependentAssembly** element.

8. Add the following attribute names and values to the **codeBase** element:

   |Attribute Name|Attribute Value|
   |--------------------|---------------------|
   |**version**|**10.0.0.0**|
   |**href**|`PathToASPNetHelperDll`|

    `PathToASPNetHelperDll` is the file URL of the Microsoft.VisualStudio.Enterprise.ASPNetHelper.dll. If [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] is installed in the default location, the **href** value should be
    `C:/Program%20Files/Microsoft%20Visual%20Studio%202010.0/Common7/IDE/PrivateAssemblies/Microsoft.VisualStudio.Enterprise.ASPNetHelper.DLL`

```xml
    <configuration>
        <runtime>
            <assemblyBinding
                xmlns="urn:schemas-microsoft-com:asm.v1"
            >
                <dependentAssembly>
                    <assemblyIdentity name="Microsoft.VisualStudio.Enterprise.ASPNetHelper"
                        publicKeyToken="b03f5f7f11d50a3a"
                        culture="neutral"
                    />
                    <codeBase
                        version="10.0.0.0"
                        href="file:///C:/Program%20Files/Microsoft%20Visual%20Studio%2010.0/Common7/IDE/PrivateAssemblies/Microsoft.VisualStudio.Enterprise.ASPNetHelper.DLL"
                    />
                </dependentAssembly>
            </assemblyBinding>
        </runtime>
```

### To add the profiler post-process step to the configuration/system.web/compilation element

1. If necessary, add the **system.web** element as a child element of the **configuration** element; otherwise, go to the next step.

     The **system.web** element has no attributes. The **configuration** element can have only one **system.web** child element.

2. If necessary, add the **compilation** element as a child element of the **system.web** element; otherwise, go to the next step.

     The **system.web** element can have only one **compilation** child element.

3. Remove any existing attributes from the **compilation** element, and add the following attribute name and value:

    |Attribute Name|Attribute Value|
    |--------------------|---------------------|
    |**assemblyPostProcessorType**|**Microsoft.VisualStudio.Enterprise.Common.AspPerformanceInstrumenter, Microsoft.VisualStudio.Enterprise.ASPNetHelper, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a**|

```xml
    <configuration>
        <runtime>
        . . .
        </runtime>
        <system.web>
            <compilation
                assemblyPostProcessorType="Microsoft.VisualStudio.Enterprise.Common.AspPerformanceInstrumenter,
                    Microsoft.VisualStudio.Enterprise.ASPNetHelper,
                    Version=10.0.0.0,
                    Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
            />
        </system.web>
    <configuration>
```

### To add profiler location settings to the configuration/appSettings element

1. If necessary, add the **appSettings** element as a child element of the **configuration** element; otherwise, go to the next step.

    The **appSettings** element has no attributes. The **configuration** element can have only one **appSettings** child element.

2. Add an **add** element as a child of the **appSettings** element.

3. Add the following attribute names and values to the **add** element:

   | Attribute Name | Attribute Value |
   |----------------| - |
   | **key** | **Microsoft.VisualStudio.Enterprise.AspNetHelper.VsInstrLocation** |
   | **value** | `PerformanceToolsFolder` **\VSInstr.Exe** |

4. Add another **add** element as a child of the **appSettings** element.

5. Add the following attribute names and values to this **add** element:

   |Attribute Name|Attribute Value|
   |--------------------|---------------------|
   |**key**|**Microsoft.VisualStudio.Enterprise.AspNetHelper.VsInstrTools**|
   |**value**|`PerformanceToolsFolder`|

    `PerformanceToolsFolder` is the path of the profiler executable files. To get the path to the profiling tools, see [Specify the path to command line tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md).

```xml
    <configuration>
        <runtime>
        . . .
        </runtime>
        . . .
        <system.web>
        </system.web>
        <appSettings>
            <add
                key="Microsoft.VisualStudio.Enterprise.AspNetHelper.VsInstrLocation"
                value="C:\Program Files\Microsoft Visual Studio 14.0\Team Tools\Performance Tools\vsinstr.exe"
        />
            <add
                key="Microsoft.VisualStudio.Enterprise.AspNetHelper.VsInstrTools"
                value="C:\Program Files\Microsoft Visual Studio 14.0\Team Tools\Performance Tools\"
            />
        </appSettings>
    </configuration>
```

## Example
 The following is a complete *web.config* file that enables the instrumentation and profiling of dynamically compiled [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] Web applications. This example assumes that there were no other settings in the file before modification.

```xml
<?xml version="1.0"?>
    <configuration>
        <runtime>
            <assemblyBinding
                xmlns="urn:schemas-microsoft-com:asm.v1"
            >
                <dependentAssembly>
                    <assemblyIdentity
                        name="Microsoft.VisualStudio.Enterprise.ASPNetHelper"
                        publicKeyToken="b03f5f7f11d50a3a"
                        culture="neutral"
                    />
                    <codeBase
                        version="10.0.0.0"
                        href="file:///C:/Program%20Files/Microsoft%20Visual%20Studio%2010.0/Common7/IDE/PrivateAssemblies/Microsoft.VisualStudio.Enterprise.ASPNetHelper.DLL"
                    />
                </dependentAssembly>
            </assemblyBinding>
        </runtime>
        <system.web>
            <compilation
                assemblyPostProcessorType="Microsoft.VisualStudio.Enterprise.Common.AspPerformanceInstrumenter,
                    Microsoft.VisualStudio.Enterprise.ASPNetHelper,
                    Version=10.0.0.0,
                    Culture=neutral,
                    PublicKeyToken=b03f5f7f11d50a3a"
            />
        </system.web>
        <appSettings>
            <add
                key="Microsoft.VisualStudio.Enterprise.AspNetHelper.VsInstrLocation"
                value="C:\Program Files\Microsoft Visual Studio 14.0\Team Tools\Performance Tools\vsinstr.exe"
            />
            <add
                key="Microsoft.VisualStudio.Enterprise.AspNetHelper.VsInstrTools"
                value="C:\Program Files\Microsoft Visual Studio 14.0\Team Tools\Performance Tools\"
            />
        </appSettings>
    </configuration>

```

## See also
- [How to: Instrument a dynamically compiled ASP.NET application and collect detailed timing data](../profiling/how-to-instrument-a-dynamically-compiled-aspnet-app-and-collect-timing-data.md)
- [How to: Instrument a dynamically compiled ASP.NET application and collect memory data](../profiling/how-to-instrument-a-dynamically-compiled-aspnet-web-application-and-collect-memory-data.md)
