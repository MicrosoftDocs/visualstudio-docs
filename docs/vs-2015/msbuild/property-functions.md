---
title: "Property Functions | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
helpviewer_keywords: 
  - "MSBuild, property functions"
ms.assetid: 2253956e-3ae0-4bdc-9d3a-4881dfae4ddb
caps.latest.revision: 35
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Property Functions
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In the .NET Framework versions 4 and 4.5, property functions can be used to evaluate MSBuild scripts. Property functions can be used wherever properties appear. Unlike tasks, property functions can be used outside of targets, and are evaluated before any target runs.  
  
 Without using MSBuild tasks, you can read the system time, compare strings, match regular expressions, and perform other actions in your build script. MSBuild will try to convert string to number and number to string, and make other conversions as required.  
  
 **In this topic:**  
  
- [Property Function Syntax](#BKMK_Syntax)  
  
  - [String Property Functions](#BKMK_String)  

  - [Static Property Functions](#BKMK_Static)  

  - [Calling Instance Methods on Static Properties](#BKMK_InstanceMethods)  

  - [MSBuild Property Functions](#BKMK_PropertyFunctions)  
  
- [Nested Property Functions](#BKMK_Nested)  
  
- [MSBuild DoesTaskHostExist](#BKMK_DoesTaskHostExist)  
  
- [MSBuild GetDirectoryNameOfFileAbove](#BKMK_GetDirectoryNameOfFileAbove)  
  
- [MSBuild GetRegistryValue](#BKMK_GetRegistryValue)  
  
- [MSBuild GetRegistryValueFromView](#BKMK_GetRegistryValueFromView)  
  
- [MSBuild MakeRelative](#BKMK_MakeRelative)  
  
- [MSBuild ValueOrDefault](#BKMK_ValueOrDefault)  
  
## <a name="BKMK_Syntax"></a> Property Function Syntax  
 These are three kinds of property functions; each function has a different syntax:  
  
- String (instance) property functions  
  
- Static property functions  
  
- MSBuild property functions  
  
### <a name="BKMK_String"></a> String Property Functions  
 All build property values are just string values. You can use string (instance) methods to operate on any property value. For example, you can extract the drive name (the first three characters) from a build property that represents a full path by using this code:  
  
 `$(ProjectOutputFolder.Substring(0,3))`  
  
### <a name="BKMK_Static"></a> Static Property Functions  
 In your build script, you can access the static properties and methods of many system classes. To get the value of a static property, use the following syntax, where *Class* is the name of the system class and *Property* is the name of the property.  
  
 `$([Class]::Property)`  
  
 For example, you can use the following code to set a build property to the current date and time.  
  
 `<Today>$([System.DateTime]::Now)</Today>`  
  
 To call a static method, use the following syntax, where *Class* is the name of the system class, *Method* is the name of the method, and *(Parameters)* is the parameter list for the method:  
  
 `$([Class]::Method(Parameters))`  
  
 For example, to set a build property to a new GUID, you can use this script:  
  
 `<NewGuid>$([System.Guid]::NewGuid())</NewGuid>`  
  
 In static property functions, you can use any static method or property of these system classes:  
  
- System.Byte  
  
- System.Char  
  
- System.Convert  
  
- System.DateTime  
  
- System.Decimal  
  
- System.Double  
  
- System.Enum  
  
- System.Guid  
  
- System.Int16  
  
- System.Int32  
  
- System.Int64  
  
- System.IO.Path  
  
- System.Math  
  
- System.UInt16  
  
- System.UInt32  
  
- System.UInt64  
  
- System.SByte  
  
- System.Single  
  
- System.String  
  
- System.StringComparer  
  
- System.TimeSpan  
  
- System.Text.RegularExpressions.Regex  
  
- Microsoft.Build.Utilities.ToolLocationHelper  
  
  In addition, you can use the following static methods and properties:  
  
- System.Environment::CommandLine  
  
- System.Environment::ExpandEnvironmentVariables  
  
- System.Environment::GetEnvironmentVariable  
  
- System.Environment::GetEnvironmentVariables  
  
- System.Environment::GetFolderPath  
  
- System.Environment::GetLogicalDrives  
  
- System.IO.Directory::GetDirectories  
  
- System.IO.Directory::GetFiles  
  
- System.IO.Directory::GetLastAccessTime  
  
- System.IO.Directory::GetLastWriteTime  
  
- System.IO.Directory::GetParent  
  
- System.IO.File::Exists  
  
- System.IO.File::GetCreationTime  
  
- System.IO.File::GetAttributes  
  
- System.IO.File::GetLastAccessTime  
  
- System.IO.File::GetLastWriteTime  
  
- System.IO.File::ReadAllText  
  
### <a name="BKMK_InstanceMethods"></a> Calling Instance Methods on Static Properties  
 If you access a static property that returns an object instance, you can invoke the instance methods of that object. To invoke an instance method, use the following syntax, where *Class* is the name of the system class, *Property* is the name of the property, *Method* is the name of the method, and *(Parameters)* is the parameter list for the method:  
  
 `$([Class]::Property.Method(Parameters))`  
  
 The name of the class must be fully qualified with the namespace.  
  
 For example, you can use the following code to set a build property to the current date today.  
  
 `<Today>$([System.DateTime]::Now.ToString("yyyy.MM.dd"))</Today>`  
  
### <a name="BKMK_PropertyFunctions"></a> MSBuild Property Functions  
 Several static methods in your build can be accessed to provide arithmetic, bitwise logical, and escape character support. You access these methods by using the following syntax, where *Method* is the name of the method and *Parameters* is the parameter list for the method.  
  
 `$([MSBuild]::Method(Parameters))`  
  
 For example, to add together two properties that have numeric values, use the following code.  
  
 `$([MSBuild]::Add($(NumberOne), $(NumberTwo))`  
  
 Here is a list of MSBuild property functions:  
  
|Function Signature|Description|  
|------------------------|-----------------|  
|double Add(double a, double b)|Add two doubles.|  
|long Add(long a, long b)|Add two longs.|  
|double Subtract(double a, double b)|Subtract two doubles.|  
|long Subtract(long a, long b)|Subtract two longs.|  
|double Multiply(double a, double b)|Multiply two doubles.|  
|long Multiply(long a, long b)|Multiply two longs.|  
|double Divide(double a, double b)|Divide two doubles.|  
|long Divide(long a, long b)|Divide two longs.|  
|double Modulo(double a, double b)|Modulo two doubles.|  
|long Modulo(long a, long b)|Modulo two longs.|  
|string Escape(string unescaped)|Escape the string according to MSBuild escaping rules.|  
|string Unescape(string escaped)|Unescape the string according to MSBuild escaping rules.|  
|int BitwiseOr(int first, int second)|Perform a bitwise `OR` on the first and second (first &#124; second).|  
|int BitwiseAnd(int first, int second)|Perform a bitwise `AND` on the first and second (first & second).|  
|int BitwiseXor(int first, int second)|Perform a bitwise `XOR` on the first and second (first ^ second).|  
|int BitwiseNot(int first)|Perform a bitwise `NOT` (~first).|  
  
## <a name="BKMK_Nested"></a> Nested Property Functions  
 You can combine property functions to form more complex functions, as the following example shows.  
  
 `$([MSBuild]::BitwiseAnd(32,   $([System.IO.File]::GetAttributes(tempFile))))`  
  
 This example returns the value of the <xref:System.IO.FileAttributes>`Archive` bit (32 or 0) of the file given by the path `tempFile`. Notice that enumerated data values cannot appear by name within property functions. The numeric value (32) must be used instead.  
  
 Metadata may also appear in nested property functions. For more information, see [Batching](../msbuild/msbuild-batching.md).  
  
## <a name="BKMK_DoesTaskHostExist"></a> MSBuild DoesTaskHostExist  
 The `DoesTaskHostExist` property function in MSBuild returns whether a task host is currently installed for the specified runtime and architecture values.  
  
 This property function has the following syntax:  
  
```  
$[MSBuild]::DoesTaskHostExist(string theRuntime, string theArchitecture)  
```  
  
## <a name="BKMK_GetDirectoryNameOfFileAbove"></a> MSBuild GetDirectoryNameOfFileAbove  
 The MSBuild `GetDirectoryNameOfFileAbove` property function looks for a file in the directories above the current directory in the path.  
  
 This property function has the following syntax:  
  
```  
$[MSBuild]::GetDirectoryNameOfFileAbove(string ThePath, string TheFile)  
```  
  
 The following code is an example of this syntax.  
  
```  
<Import Project="$([MSBuild]::GetDirectoryNameOfFileAbove($(MSBuildThisFileDirectory), EnlistmentInfo.props))\EnlistmentInfo.props" Condition=" '$([MSBuild]::GetDirectoryNameOfFileAbove($(MSBuildThisFileDirectory), EnlistmentInfo.props))' != '' " />  
```  
  
## <a name="BKMK_GetRegistryValue"></a> MSBuild GetRegistryValue  
 The MSBuild `GetRegistryValue` property function returns the value of a registry key. This function takes two arguments, the key name and the value name, and returns the value from the registry. If you don't specify a value name, the default value is returned.  
  
 The following examples show how this function is used:  
  
```  
$([MSBuild]::GetRegistryValue(`HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\10.0\Debugger`, ``))                                  // default value  
$([MSBuild]::GetRegistryValue(`HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\10.0\Debugger`, `SymbolCacheDir`))  
$([MSBuild]::GetRegistryValue(`HKEY_LOCAL_MACHINE\SOFTWARE\(SampleName)`, `(SampleValue)`))             // parens in name and value  
  
```  
  
## <a name="BKMK_GetRegistryValueFromView"></a> MSBuild GetRegistryValueFromView  
 The MSBuild `GetRegistryValueFromView` property function gets system registry data given the registry key, value, and one or more ordered registry views. The key and value are searched in each registry view in order until they are found.  
  
 The syntax for this property function is:  
  
 [MSBuild\]::GetRegistryValueFromView(string keyName, string valueName, object defaultValue, params object[] views)  
  
 The Windows 64-bit operating system maintains a HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node registry key that presents a HKEY_LOCAL_MACHINE\SOFTWARE registry view for 32-bit applications.  
  
 By default, a 32-bit application running on WOW64 accesses the 32-bit registry view and a 64-bit application accesses the 64-bit registry view.  
  
 The following registry views are available:  
  
|Registry View|Definition|  
|-------------------|----------------|  
|RegistryView.Registry32|The 32-bit application registry view.|  
|RegistryView.Registry64|The 64-bit application registry view.|  
|RegistryView.Default|The registry view that matches the process that the application is running on.|  
  
 The following is an example.  
  
 `$([MSBuild]::GetRegistryValueFromView('HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Microsoft SDKs\Silverlight\v3.0\ReferenceAssemblies', 'SLRuntimeInstallPath', null, RegistryView.Registry64, RegistryView.Registry32))`  
  
 gets the SLRuntimeInstallPath data of the ReferenceAssemblies key, looking first in the 64-bit registry view and then in the 32-bit registry view.  
  
## <a name="BKMK_MakeRelative"></a> MSBuild MakeRelative  
 The MSBuild `MakeRelative` property function returns the relative path of the second path relative to first path. Each path can be a file or folder.  
  
 This property function has the following syntax:  
  
```  
$[MSBuild]::MakeRelative($(FileOrFolderPath1), $(FileOrFolderPath2))  
```  
  
 The following code is an example of this syntax.  
  
```xml  
<PropertyGroup>  
    <Path1>c:\users\</Path1>  
    <Path2>c:\users\username\</Path2>  
</PropertyGroup>  
  
<Target Name = "Go">  
    <Message Text ="$([MSBuild]::MakeRelative($(Path1), $(Path2)))" />  
    <Message Text ="$([MSBuild]::MakeRelative($(Path2), $(Path1)))" />  
</Target>  
  
<!--  
Output:  
   username\  
   ..\  
-->  
```  
  
## <a name="BKMK_ValueOrDefault"></a> MSBuild ValueOrDefault  
 The MSBuild `ValueOrDefault` property function returns the first argument, unless it's null or empty. If the first argument is null or empty, the function returns the second argument.  
  
 The following example shows how this function is used.  
  
```  
<Project ToolsVersion="4.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  
    <PropertyGroup>  
        <Value1>$([MSBuild]::ValueOrDefault(`$(UndefinedValue)`, `a`))</Value1>  
        <Value2>$([MSBuild]::ValueOrDefault(`b`, `$(Value1)`))</Value2>  
    </PropertyGroup>  
  
    <Target Name="MyTarget">  
        <Message Text="Value1 = $(Value1)" />  
        <Message Text="Value2 = $(Value2)" />  
    </Target>  
</Project>  
  
<!--  
Output:   
  Value1 = a  
  Value2 = b  
-->  
```

## See Also
[MSBuild Properties](msbuild-properties1.md)   
[MSBuild Overview](msbuild.md)
