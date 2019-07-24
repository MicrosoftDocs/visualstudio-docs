---
title: "Property Functions | Microsoft Docs"
ms.date: "02/21/2017"
ms.topic: "conceptual"
helpviewer_keywords:
  - "MSBuild, property functions"
ms.assetid: 2253956e-3ae0-4bdc-9d3a-4881dfae4ddb
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# Property functions

In the .NET Framework versions 4 and 4.5, property functions can be used to evaluate MSBuild scripts. Property functions can be used wherever properties appear. Unlike tasks, property functions can be used outside of targets, and are evaluated before any target runs.

 Without using MSBuild tasks, you can read the system time, compare strings, match regular expressions, and perform other actions in your build script. MSBuild will try to convert string to number and number to string, and make other conversions as required.
 
String values returned from property functions have [special characters](msbuild-special-characters.md) escaped. If you want the value to be treated as though it was put directly in the project file, use `$([MSBuild]::Unescape())` to unescape the special characters.

## Property function syntax

These are three kinds of property functions; each function has a different syntax:

- String (instance) property functions
- Static property functions
- MSBuild property functions

### String property functions

All build property values are just string values. You can use string (instance) methods to operate on any property value. For example, you can extract the drive name (the first three characters) from a build property that represents a full path by using this code:

```fundamental
$(ProjectOutputFolder.Substring(0,3))
```

### Static property functions

In your build script, you can access the static properties and methods of many system classes. To get the value of a static property, use the following syntax, where \<Class> is the name of the system class and \<Property> is the name of the property.

```fundamental
$([Class]::Property)
```

For example, you can use the following code to set a build property to the current date and time.

```xml
<Today>$([System.DateTime]::Now)</Today>
```

To call a static method, use the following syntax, where \<Class> is the name of the system class, \<Method> is the name of the method, and (\<Parameters>) is the parameter list for the method:

```fundamental
$([Class]::Method(Parameters))
```

For example, to set a build property to a new GUID, you can use this script:

```xml
<NewGuid>$([System.Guid]::NewGuid())</NewGuid>
```

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
- System.Runtime.InteropServices.OSPlatform
- System.Runtime.InteropServices.RuntimeInformation
- System.UInt16
- System.UInt32
- System.UInt64
- System.SByte
- System.Single
- System.String
- System.StringComparer
- System.TimeSpan
- System.Text.RegularExpressions.Regex
- System.UriBuilder
- System.Version
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

### Calling instance methods on static properties

If you access a static property that returns an object instance, you can invoke the instance methods of that object. To invoke an instance method, use the following syntax, where \<Class> is the name of the system class, \<Property> is the name of the property, \<Method> is the name of the method, and (\<Parameters>) is the parameter list for the method:

```fundamental
$([Class]::Property.Method(Parameters))
```

The name of the class must be fully qualified with the namespace.

For example, you can use the following code to set a build property to the current date today.

```xml
<Today>$([System.DateTime]::Now.ToString('yyyy.MM.dd'))</Today>
```

### MSBuild property functions

Several static methods in your build can be accessed to provide arithmetic, bitwise logical, and escape character support. You access these methods by using the following syntax, where \<Method> is the name of the method and (\<Parameters>) is the parameter list for the method.

```fundamental
$([MSBuild]::Method(Parameters))
```

For example, to add together two properties that have numeric values, use the following code.

```fundamental
$([MSBuild]::Add($(NumberOne), $(NumberTwo)))
```

Here is a list of MSBuild property functions:

|Function signature|Description|
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
|bool IsOsPlatform(string platformString)|Specify whether the current OS platform is `platformString`. `platformString` must be a member of <xref:System.Runtime.InteropServices.OSPlatform>.|
|bool IsOSUnixLike()|True if current OS is a Unix system.|
|string NormalizePath(params string[] path)|Gets the canonicalized full path of the provided path and ensures it contains the correct directory separator characters for the current operating system.|
|string NormalizeDirectory(params string[] path)|Gets the canonicalized full path of the provided directory and ensures it contains the correct directory separator characters for the current operating system while ensuring it has a trailing slash.|
|string EnsureTrailingSlash(string path)|If the given path doesn't have a trailing slash then add one. If the path is an empty string, does not modify it.|
|string GetPathOfFileAbove(string file, string startingDirectory)|Searches for a file based on the current build file's location, or based on `startingDirectory`, if specified.|
|GetDirectoryNameOfFileAbove(string startingDirectory, string fileName)|Locate a file in either the directory specified or a location in the directory structure above that directory.|
|string MakeRelative(string basePath, string path)|Makes `path` relative to `basePath`. `basePath` must be an absolute directory. If `path` cannot be made relative, it is returned verbatim. Similar to `Uri.MakeRelativeUri`.|
|string ValueOrDefault(string conditionValue, string defaultValue)|Return the string in parameter 'defaultValue' only if parameter 'conditionValue' is empty, else, return the value conditionValue.|

## Nested property functions

You can combine property functions to form more complex functions, as the following example shows.

```fundamental
$([MSBuild]::BitwiseAnd(32, $([System.IO.File]::GetAttributes(tempFile))))
```

This example returns the value of the <xref:System.IO.FileAttributes>`Archive` bit (32 or 0) of the file given by the path `tempFile`. Notice that enumerated data values cannot appear by name within property functions. The numeric value (32) must be used instead.

Metadata may also appear in nested property functions. For more information, see [Batching](../msbuild/msbuild-batching.md).

## MSBuild DoesTaskHostExist

The `DoesTaskHostExist` property function in MSBuild returns whether a task host is currently installed for the specified runtime and architecture values.

This property function has the following syntax:

```fundamental
$([MSBuild]::DoesTaskHostExist(string theRuntime, string theArchitecture))
```

## MSBuild EnsureTrailingSlash

The `EnsureTrailingSlash` property function in MSBuild adds a trailing slash if one doesn't already exist.

This property function has the following syntax:

```fundamental
$([MSBuild]::EnsureTrailingSlash('$(PathProperty)'))
```

## MSBuild GetDirectoryNameOfFileAbove

The MSBuild `GetDirectoryNameOfFileAbove` property function looks for a file in the directories above the current directory in the path.

 This property function has the following syntax:

```fundamental
$([MSBuild]::GetDirectoryNameOfFileAbove(string ThePath, string TheFile))
```

 The following code is an example of this syntax.

```xml
<Import Project="$([MSBuild]::GetDirectoryNameOfFileAbove($(MSBuildThisFileDirectory), EnlistmentInfo.props))\EnlistmentInfo.props" Condition=" '$([MSBuild]::GetDirectoryNameOfFileAbove($(MSBuildThisFileDirectory), EnlistmentInfo.props))' != '' " />
```

## MSBuild GetPathOfFileAbove

The `GetPathOfFileAbove` property function in MSBuild returns the path of the file immediately preceding this one. It is functionally equivalent to calling

```xml
<Import Project="$([MSBuild]::GetDirectoryNameOfFileAbove($(MSBuildThisFileDirectory), dir.props))\dir.props" />
```

This property function has the following syntax:

```fundamental
$([MSBuild]::GetPathOfFileAbove(dir.props))
```

## MSBuild GetRegistryValue

The MSBuild `GetRegistryValue` property function returns the value of a registry key. This function takes two arguments, the key name and the value name, and returns the value from the registry. If you don't specify a value name, the default value is returned.

The following examples show how this function is used:

```fundamental
$([MSBuild]::GetRegistryValue(`HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\10.0\Debugger`, ``))                                  // default value
$([MSBuild]::GetRegistryValue(`HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\10.0\Debugger`, `SymbolCacheDir`))
$([MSBuild]::GetRegistryValue(`HKEY_LOCAL_MACHINE\SOFTWARE\(SampleName)`, `(SampleValue)`))             // parens in name and value
```

## MSBuild GetRegistryValueFromView

The MSBuild `GetRegistryValueFromView` property function gets system registry data given the registry key, value, and one or more ordered registry views. The key and value are searched in each registry view in order until they are found.

The syntax for this property function is:

```fundamental
[MSBuild]::GetRegistryValueFromView(string keyName, string valueName, object defaultValue, params object[] views)
```

The Windows 64-bit operating system maintains a **HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node** registry key that presents a **HKEY_LOCAL_MACHINE\SOFTWARE** registry view for 32-bit applications.

By default, a 32-bit application running on WOW64 accesses the 32-bit registry view and a 64-bit application accesses the 64-bit registry view.

The following registry views are available:

|Registry view|Definition|
|-------------------|----------------|
|RegistryView.Registry32|The 32-bit application registry view.|
|RegistryView.Registry64|The 64-bit application registry view.|
|RegistryView.Default|The registry view that matches the process that the application is running on.|

The following is an example.

 ```fundamental
$([MSBuild]::GetRegistryValueFromView('HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Microsoft SDKs\Silverlight\v3.0\ReferenceAssemblies', 'SLRuntimeInstallPath', null, RegistryView.Registry64, RegistryView.Registry32))
```

gets the **SLRuntimeInstallPath** data of the **ReferenceAssemblies** key, looking first in the 64-bit registry view and then in the 32-bit registry view.

## MSBuild MakeRelative

The MSBuild `MakeRelative` property function returns the relative path of the second path relative to first path. Each path can be a file or folder.

This property function has the following syntax:

```fundamental
$([MSBuild]::MakeRelative($(FileOrFolderPath1), $(FileOrFolderPath2)))
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

## MSBuild ValueOrDefault

The MSBuild `ValueOrDefault` property function returns the first argument, unless it's null or empty. If the first argument is null or empty, the function returns the second argument.

The following example shows how this function is used.

```xml
<Project ToolsVersion="4.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">

    <PropertyGroup>
        <Value1>$([MSBuild]::ValueOrDefault('$(UndefinedValue)', 'a'))</Value1>
        <Value2>$([MSBuild]::ValueOrDefault('b', '$(Value1)'))</Value2>
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

## See also

- [MSBuild properties](../msbuild/msbuild-properties.md)

- [MSBuild overview](../msbuild/msbuild.md)
