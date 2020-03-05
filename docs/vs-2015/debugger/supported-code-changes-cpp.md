---
title: "Supported Code Changes (C++) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "Edit and Continue, limitations"
  - "supported code changes"
  - "object files, limitations of Edit and Continue"
  - "C++ language, supported code changes"
  - "coding, supported code changes"
  - "resource files, limitations of Edit and Continue"
  - "code changes, handling in Edit and Continue"
  - "what's new [C++], supported code changes"
  - "code changes"
ms.assetid: f5754363-8a56-417b-b904-b05d9dd26d03
caps.latest.revision: 29
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Supported Code Changes (C++)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Edit and Continue for Visual C++ handles most types of code changes. However, some changes cannot be applied during program execution. To apply these changes, you must stop execution and build a fresh version of the code.  
  
 See [Edit and Continue (Visual C++)](../debugger/edit-and-continue-visual-cpp.md) for information about working with Edit and Continue for C++ in Visual Studio.  
  
## <a name="BKMK_Unsupported_changes"></a> Unsupported changes  

The following C/C++ changes cannot be applied during a debugging session:  
  
- Most changes to global or static data.  
  
- Changes to executables that are copied from another machine and not built locally.  
  
- Changes to a data type that affect the layout of an object, such as data members of a class.  
  
- Adding more than 64k bytes of new code or data.  
  
- Adding variables that require a constructor at a point before the instruction pointer.  
  
- Changes that affect code that requires run-time initialization.  
  
- Adding exception handlers, in some instances.  
  
- Changes to resource files.  
  
- Changes to code in read-only files.  
  
- Changes to code without a corresponding PDB file.  
  
- Changes to code that has no object file.  
  
If you make one of these changes and then try to apply code changes, an error or warning message appears in the **Output** window.  
  
- Edit and Continue does not update static libraries. If you make a change in a static library, execution continues with the old version and no warning is issued.  
  
## <a name="BKMK_Unsupported_scenarios"></a> Unsupported scenarios  
 Edit and Continue for C/C++ is unavailable in the following debugging scenarios:  
  
- Debugging native apps compiled with [/Zo (Enhance Optimized Debugging)](https://msdn.microsoft.com/library/eea8d89a-7fe0-4fe1-86b2-7689bbebbd7f)  
  
- In versions of Visual Studio previous to Visual Studio 2015 Update 1, debugging Windows Store apps or components. Starting in Visual Studio 2015 Update 1, you can use Edit and Continue in Windows Store C++ apps and DirectX apps, because it now supports the `/ZI` compiler switch with the  `/bigobj` switch. You can also use Edit and Continue with binaries compiled with the `/FASTLINK` switch.  
  
- Debugging on Windows 98.  
  
- Mixed-mode (native/managed) debugging.  
  
- Javascript debugging.  
  
- SQL debugging.  
  
- Debugging a dump file.  
  
- Editing code after an unhandled exception, when the **Unwind the call stack on unhandled exceptions** option is not selected.  
  
- Debugging an app by using **Attach to** instead of running the app by choosing **Start** on the **Debug** menu.  
  
- Debugging optimized code.  
  
- Debugging an old version of your code after a new version failed to build because of build errors.  
  
## <a name="BKMK_Linking_limitations"></a> Linking limitations  
  
### <a name="BKMK_Linker_options_that_disable_Edit_and_Continue"></a> Linker options that disable Edit and Continue  
 The following linker options disable Edit and Continue:  
  
- Setting **/OPT:REF**, **/OPT:ICF**, or **/INCREMENTAL:NO** disables Edit and Continue with the following warning:  
  
     LINK : warning LNK4075: ignoring /EDITANDCONTINUE due to /OPT  
  
     specification  
  
- Setting **/ORDER**, **/RELEASE**, or **/FORCE** disables Edit and Continue with this warning:  
  
     LINK : warning LNK4075: ignoring /INCREMENTAL due to /option  
  
     specification  
  
- Setting any option that prevents the creation of a program database (.pdb) file disables Edit and Continue with no specific warning.  
  
### <a name="BKMK_Auto_relinking_limitations"></a> Auto relinking limitations  
 By default, Edit and Continue relinks your program at the end of a debugging session to create an up-to-date executable.  
  
 Edit and Continue cannot relink your program if you are debugging it from a location other than the original build location. A message tells you that you need to rebuild manually.  
  
 Edit and Continue does not rebuild static libraries. If you make changes to a static library using Edit and Continue, you need to manually rebuild the library and relink apps using it.  
  
 Edit and Continue does not invoke custom build steps. If your program uses custom build steps, you might want to rebuild manually so that custom build steps can be invoked. In that case, you can disable relinking after Edit and Continue to ensure that you are prompted to manually rebuild.  
  
 **To disable relinking after Edit and Continue**  
  
1. On the **Debug** menu, choose **Options and Settings**.  
  
2. In the **Options** dialog box, under the **Debugging** node, and select the **Edit and Continue** node.  
  
3. Clear the **Relink code changes after debugging** check box.  
  
## <a name="BKMK_Precompiled_Header_Limitations"></a> Precompiled Header Limitations  
 By default, Edit and Continue loads and processes precompiled headers in the background to speed up processing of code changes. Loading precompiled headers requires allocation of physical memory, which can be a problem if you are compiling on a machine with limited RAM. You can determine if this might be a problem by using the Windows Task Manager to determine the amount of available physical memory while you are debugging. If this amount is greater than the size of your precompiled headers, Edit and Continue should have no problem. If the amount is less than the size of your precompiled headers, you can prevent Edit and Continue from loading precompiled headers in the background.  
  
 **To disable background loading of precompiled headers for Edit and Continue**  
  
1. On the **Debug** menu, choose **Options and Settings**.  
  
2. In the **Options** dialog box, under the **Debugging** node, and select the **Edit and Continue** node.  
  
3. Clear the **Allow Precompiling** check box.  
  
## <a name="BKMK_IDL_Attribute_Limitations"></a> IDL Attribute Limitations  
 Edit and Continue does not regenerate interface definition (IDL) files. Therefore, changes to IDL attributes will not be reflected while you are debugging. To see the result of changes to IDL attributes, you must stop debugging and rebuild your app. Edit and Continue does not generate an error or warning if IDL attributes have changed. For more information, see [IDL Attributes](https://msdn.microsoft.com/library/04c596f4-c97b-4952-8053-316678b1d0b6).  
  
## See Also  
 [Edit and Continue (Visual C++)](../debugger/edit-and-continue-visual-cpp.md)
