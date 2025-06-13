---
title: 'Generate Registry Information for an Installer'
description: Learn how to use the RegPkg.exe utility in Visual Studio to generate VSPackage registry information for incorporation in a Windows installer setup package.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- registration, VSPackages
- VSPackages, registering
- VSPackages, registration manifests
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Generate registry information for an installer

The *RegPkg.exe* utility can be used to generate a registration manifest for a managed VSPackage. The manifest can be incorporated into a Windows Installer setup package. RegPkg also can generate a file that can be included in a setup source file based on the [Windows Installer XML toolset](https://wixtoolset.org/).

> [!IMPORTANT]
> RegPkg generates path names that are specific to your development system, so every time you use RegPkg, you must edit the output to use appropriate Windows Installer formatted properties. For example, the `InprocServer32` value should be *\<SystemFolder\>mscoree.dll* and paths should use *\<#filekey\>* and *\<$componentkey\>*. Adjusting the output in this way supports computers with Windows installed on a different drive or in a different directory, localized directory names, and paths that users can choose. For more information, see [Formatted](https://msdn.microsoft.com/library?url=/library/msi/setup/formatted.asp) in the Windows Installer SDK. If you follow RegPkg conventions for your development system paths—for example, file IDs of the form *File_\<filename\>*—you need make fewer changes.

## To create a registration manifest

- Run RegPkg with the **/regfile** switch. Provide any other switches, the name of the output file, and the path of the VSPackage.

     For example, at the command prompt, you would type something like the following:

    ```
    <Visual Studio SDK installation path>\VisualStudioIntegration\Tools\Bin\RegPkg /regfile:MyRegFile.reg MyPackage.dll
    ```

## To view a registration manifest

- Open the registration manifest in any text editor.

     The following example is the registration manifest that RegPkg creates for the IronPython language service:

    ```
    REGEDIT4

    [HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\8.0\Languages]
    [HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\8.0\Languages\CodeExpansions]
    [HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\8.0\Languages\CodeExpansions\Python]
    @="{ae8ce01a-b3ff-4c19-8c80-54669c197f2c}"
    "DisplayName"="131"
    "IndexPath"="C:\\VSSDK80\\2006.07\\VisualStudioIntegration\\Samples\\IronPythonIntegration\\bin\\Release\\CodeSnippets\\SnippetsIndex.xml"
    "LangStringId"="python"
    "Package"="{1b05e2b4-7c21-4f63-910e-29fe55eb5f8b}"
    "ShowRoots"=dword:00000000
    [HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\8.0\Languages\CodeExpansions\Python\ForceCreateDirs]
    "Python"="C:\\VSSDK80\\2006.07\\VisualStudioIntegration\\Samples\\IronPythonIntegration\\bin\\Release\\CodeSnippets\\Snippets\\;%MyDocs%\Code Snippets\Python\My Code Snippets\"
    [HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\8.0\Languages\CodeExpansions\Python\Paths]
    "Python"="C:\\VSSDK80\\2006.07\\VisualStudioIntegration\\Samples\\IronPythonIntegration\\bin\\Release\\CodeSnippets\\Snippets\\;%MyDocs%\Code Snippets\Python\My Code Snippets\"
    [HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\8.0\Packages]
    [HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\8.0\Packages\{1b05e2b4-7c21-4f63-910e-29fe55eb5f8b}]
    @="Microsoft.Samples.VisualStudio.IronPythonLanguageService.PythonPackage, IronPython.LanguageService, Version=1.0.2373.36479, Culture=neutral, PublicKeyToken=null"
    "InprocServer32"="C:\\WINNT\\system32\\mscoree.dll"
    "Class"="Microsoft.Samples.VisualStudio.IronPythonLanguageService.PythonPackage"
    "Assembly"="IronPython.LanguageService, Version=1.0.2373.36479, Culture=neutral, PublicKeyToken=null"
    [HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\8.0\Languages]
    [HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\8.0\Languages\File Extensions]
    [HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\8.0\Languages\File Extensions\.py]
    @="{ae8ce01a-b3ff-4c19-8c80-54669c197f2c}"
    [HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\8.0\Languages]
    [HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\8.0\Languages\Language Services]
    [HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\8.0\Languages\Language Services\Python]
    @="{ae8ce01a-b3ff-4c19-8c80-54669c197f2c}"
    "Package"="{1b05e2b4-7c21-4f63-910e-29fe55eb5f8b}"
    "LangResID"=dword:00000064
    "ShowMatchingBrace"=dword:00000001
    "CodeSense"=dword:00000001
    "MatchBraces"=dword:00000001
    "EnableCommenting"=dword:00000001
    "ShowCompletion"=dword:00000001
    [HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\8.0\Packages]
    [HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\8.0\Packages\{1b05e2b4-7c21-4f63-910e-29fe55eb5f8b}]
    "ID"=dword:00000001
    "MinEdition"="standard"
    "ProductVersion"="1.0"
    "ProductName"="Visual Studio Integration of IronPython Language Service"
    "CompanyName"="Microsoft Corporation"
    [HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\8.0\Services]
    [HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\8.0\Services\{923b4811-26e4-4347-ac8a-244762798e1c}]
    @="{1b05e2b4-7c21-4f63-910e-29fe55eb5f8b}"
    "Name"="IPythonLibraryManager"
    [HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\8.0\Services]
    [HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\8.0\Services\{ae8ce01a-b3ff-4c19-8c80-54669c197f2c}]
    @="{1b05e2b4-7c21-4f63-910e-29fe55eb5f8b}"
    "Name"="Python"

    ```

## To create a Windows Installer XML toolset include file

- Run RegPkg with the **/wixfile** switch. Provide any other switches, the name of the output file, and the path of the VSPackage.

     For example, at the command prompt, you would type something like the following:

    ```
    <Visual Studio SDK installation path>\VisualStudioIntegration\Tools\Bin\RegPkg /codebase /wixfile:IronPython.LanguageService.wxi ..\bin\Release\IronPython.LanguageService.dll
    ```

## To view a Windows Installer XML toolset include file

- Open the Windows Installer XML Toolset include file in any text editor.

     The following example is the include file that RegPkg creates for the IronPython language service:

    ```xml
    <Include>

      <Registry Root="HKLM" Key="Software\Microsoft\VisualStudio\8.0\Languages\IntellisenseProviders\IronPythonCodeProvider">
        <Registry Name="GUID" Value="{9c1807ea-d222-4775-afa8-c092c580e451}" Type="string" />
        <Registry Name="AddItemLanguageName" Value="Iron Python" Type="string" />
        <Registry Name="DefaultExtension" Value=".py" Type="string" />
        <Registry Name="ShortLanguageName" Value="IronPython;Python" Type="string" />
        <Registry Name="TemplateFolderName" Value="IronPython" Type="string" />
      </Registry>

      <Registry Root="HKLM" Key="Software\Microsoft\VisualStudio\8.0\Languages\CodeExpansions\Python" Value="{ae8ce01a-b3ff-4c19-8c80-54669c197f2c}" Type="string">
        <Registry Name="DisplayName" Value="131" Type="string" />
        <Registry Name="IndexPath" Value="C:\\VSSDK80\\2006.08\\VisualStudioIntegration\\Samples\\IronPythonIntegration\\Setup\\[$ComponentPath]\\CodeSnippets\\SnippetsIndex.xml" Type="string" />
        <Registry Name="LangStringId" Value="python" Type="string" />
        <Registry Name="Package" Value="{1b05e2b4-7c21-4f63-910e-29fe55eb5f8b}" Type="string" />
        <Registry Name="ShowRoots" Value="0" Type="integer" />
      </Registry>

      <Registry Root="HKLM" Key="Software\Microsoft\VisualStudio\8.0\Languages\CodeExpansions\Python\ForceCreateDirs">
        <Registry Name="Python" Value="C:\\VSSDK80\\2006.08\\VisualStudioIntegration\\Samples\\IronPythonIntegration\\Setup\\[$ComponentPath]\\CodeSnippets\\Snippets\\;%MyDocs%\Code Snippets\Python\My Code Snippets\" Type="string" />
      </Registry>

      <Registry Root="HKLM" Key="Software\Microsoft\VisualStudio\8.0\Languages\CodeExpansions\Python\Paths">
        <Registry Name="Python" Value="C:\\VSSDK80\\2006.08\\VisualStudioIntegration\\Samples\\IronPythonIntegration\\Setup\\[$ComponentPath]\\CodeSnippets\\Snippets\\;%MyDocs%\Code Snippets\Python\My Code Snippets\" Type="string" />
      </Registry>

      <Registry Root="HKLM" Key="Software\Microsoft\VisualStudio\8.0\Languages\File Extensions\.py" Value="{ae8ce01a-b3ff-4c19-8c80-54669c197f2c}" Type="string" />

      <Registry Root="HKLM" Key="Software\Microsoft\VisualStudio\8.0\Languages\Language Services\Python" Value="{ae8ce01a-b3ff-4c19-8c80-54669c197f2c}" Type="string">
        <Registry Name="Package" Value="{1b05e2b4-7c21-4f63-910e-29fe55eb5f8b}" Type="string" />
        <Registry Name="LangResID" Value="100" Type="integer" />
        <Registry Name="ShowCompletion" Value="1" Type="integer" />
        <Registry Name="ShowMatchingBrace" Value="1" Type="integer" />
        <Registry Name="CodeSense" Value="1" Type="integer" />
        <Registry Name="MatchBraces" Value="1" Type="integer" />
        <Registry Name="EnableCommenting" Value="1" Type="integer" />
        <Registry Name="DefaultToInsertSpaces" Value="1" Type="integer" />
      </Registry>

      <Registry Root="HKLM" Key="Software\Microsoft\VisualStudio\8.0\Packages\{1b05e2b4-7c21-4f63-910e-29fe55eb5f8b}" Value="Microsoft.Samples.VisualStudio.IronPythonLanguageService.PythonPackage, IronPython.LanguageService, Version=1.0.2394.27719, Culture=neutral, PublicKeyToken=null" Type="string">
        <Registry Name="InprocServer32" Value="[SystemFolder]mscoree.dll" Type="string" />
        <Registry Name="Class" Value="Microsoft.Samples.VisualStudio.IronPythonLanguageService.PythonPackage" Type="string" />
        <Registry Name="CodeBase" Value="[#File_IronPython.LanguageService.dll]" Type="string" />
        <Registry Name="ID" Value="1" Type="integer" />
        <Registry Name="MinEdition" Value="standard" Type="string" />
        <Registry Name="ProductVersion" Value="1.0" Type="string" />
        <Registry Name="ProductName" Value="Visual Studio Integration of IronPython Language Service" Type="string" />
        <Registry Name="CompanyName" Value="Microsoft Corporation" Type="string" />
      </Registry>

      <Registry Root="HKLM" Key="Software\Microsoft\VisualStudio\8.0\CLSID\{9c1807ea-d222-4775-afa8-c092c580e451}" Value="Microsoft.Samples.VisualStudio.IronPythonLanguageService.PythonIntellisenseProvider" Type="string">
        <Registry Name="InprocServer32" Value="[SystemFolder]mscoree.dll" Type="string" />
        <Registry Name="Class" Value="Microsoft.Samples.VisualStudio.IronPythonLanguageService.PythonIntellisenseProvider" Type="string" />
        <Registry Name="CodeBase" Value="[#File_IronPython.LanguageService.dll]" Type="string" />
        <Registry Name="ThreadingModel" Value="Both" Type="string" />
      </Registry>

      <Registry Root="HKLM" Key="Software\Microsoft\VisualStudio\8.0\Services\{923b4811-26e4-4347-ac8a-244762798e1c}" Value="{1b05e2b4-7c21-4f63-910e-29fe55eb5f8b}" Type="string">
        <Registry Name="Name" Value="IPythonLibraryManager" Type="string" />
      </Registry>

      <Registry Root="HKLM" Key="Software\Microsoft\VisualStudio\8.0\Services\{ae8ce01a-b3ff-4c19-8c80-54669c197f2c}" Value="{1b05e2b4-7c21-4f63-910e-29fe55eb5f8b}" Type="string">
        <Registry Name="Name" Value="Python" Type="string" />
      </Registry>
    </Include>
    ```

## Related content

- [Register VSPackages](../../extensibility/registering-and-unregistering-vspackages.md)
- [VSPackages](../../extensibility/internals/vspackages.md)
