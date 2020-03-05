---
title: "VSInstr Warnings | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "instrumentation, VSInstr tool"
  - "warnings"
  - "VSInstr tool"
  - "warnings, VSInstr tool"
  - "performance tools, VSInstr tool"
ms.assetid: 47512bc9-a8e9-4628-883a-d9888edab786
caps.latest.revision: 25
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# VSInstr Warnings
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The following table lists warnings issued by the VSInstr.exe tool. You can use the NOWARN option along with the warning numbers to suppress the warning from appearing.  
  
|Warning Number|Description|  
|--------------------|-----------------|  
|**VSP2000**|Internal Error. Cannot get the module file name for this executable.|  
|**VSP2001**|\<assembly name> is a strongly named assembly. It must be re-signed before it can be executed.<br /><br /> This warning occurs when a signed assembly is instrumented. You can use the sn.exe tool to resign the binary or to temporarily turn off the strong name requirement. For more information, see [Sn.exe (Strong Name Tool)](https://msdn.microsoft.com/library/c1d2b532-1b8e-4c7a-8ac5-53b801135ec6).|  
|**VSP2002**|Could not find function \<funcname> in file \<filename><br /><br /> This warning occurs if a function cannot be located in the specified file.|  
|**VSP2003**|Could not find any cross jumps to the function \<funcname> in file \<filename>.<br /><br /> This warning occurs if VSInstr cannot nullify cross jumps. Cross jumps are used for code optimization.|  
|**VSP2004**|Function \<funcname> was excluded by using the EXCLUDE command-line switch but was required because it contained a cross jump.<br /><br /> This warning occurs if the function was excluded by using the EXCLUDE option, but is needed during the instrumentation process. The profiler automatically includes the required function.|  
|**VSP2005**|Internal Instrumentation Error \<error text><br /><br /> This warning is issued if instrumentation cannot be performed. Review the error text to determine whether it can be corrected.|  
|**VSP2006**|Could not locate PDB for \<name><br /><br /> This warning occurs if the PDB file does not exist on the search path or does not match the binary.|  
|**VSP2007**|\<filename> contains no instrumentable code.<br /><br /> This warning is issued if the functions in the binary file were all excluded or if the specified file only contains resources.|  
|**VSP2008**|Unable to get security attributes from \<name>. Error code \<code><br /><br /> This warning occurs if the user does not have READ_DAC permission. During the instrumentation process, the profiler attempts to preserve the original DACL for the binary. Because the original binary is replaced with a new binary, the DACL from the original binary must be copied and applied to the new binary. This can fail if the user does not have READ_DAC access on the original binary.|  
|**VSP2009**|Unable to set security attributes on \<name>. Error code \<error number><br /><br /> This warning occurs if the user does not have WRITE_DAC permission. During the instrumentation process, the profiler attempts to preserve the original DACL for the binary. Because the original binary is replaced with a new binary, the DACL from the original binary must be copied and applied to the new binary. This can fail if the user does not have WRITE_DAC access on the new binary.|  
|**VSP2010**|No functions are specifically selected for instrumentation because of -INCLUDE/-EXCLUDE options|  
|**VSP2011**|Include/Exclude funcspec \<name> does not match any functions|  
|**VSP2012**|The image does not contain any code that can be instrumented for code coverage.<br /><br /> Profiler does not instrument the following type of code:<br /><br /> -   Static CRT functions<br />-   Managed methods attributed with NonUserCodeAttribute<br />-   Managed methods attributed with DebuggerHiddenAttribute<br />-   MASM blocks<br /><br /> This warning is generated if, after this filtering, there is no code left.|  
|**VSP2013**|Instrumenting this image requires it to run as a 32-bit process. The CLR header flags have been updated to reflect this.<br /><br /> The profiler modifies the binary so that 64-bit operating systems can open the 32-bit process in WOW64 emulator. For libraries (DLLs) this might fail if they are loaded in an existing 64-bit process. This warning notifies the user of the dependency.|  
|**VSP2014**|The resulting instrumented image appears to be invalid, and might not run.<br /><br /> This message occurs when the final instrumented assembly has an invalid PE header.|  
  
## See Also  
 [VSInstr](../profiling/vsinstr.md)
