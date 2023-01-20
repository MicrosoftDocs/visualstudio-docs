---
title: Property Functions | Microsoft Docs
description: Learn how to use property functions, which are calls to .NET Framework methods that appear in MSBuild property definitions.
ms.custom: SEO-VS-2020
ms.date: 10/20/2021
ms.topic: conceptual
helpviewer_keywords:
- MSBuild, property functions
ms.assetid: 2253956e-3ae0-4bdc-9d3a-4881dfae4ddb
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# Property functions

Property functions are calls to .NET Framework methods that appear in MSBuild property definitions. Unlike tasks, property functions can be used outside of targets. Property functions are evaluated whenever the properties or items get expanded, which is before any target runs for properties and items outside of any targets, or when the target is evaluated, for property groups and item groups inside targets.

Without using MSBuild tasks, you can read the system time, compare strings, match regular expressions, and perform other actions in your build script. MSBuild will try to convert string to number and number to string, and make other conversions as required.

String values returned from property functions have [special characters](msbuild-special-characters.md) escaped. If you want the value to be treated as though it was put directly in the project file, use `$([MSBuild]::Unescape())` to unescape the special characters.

Property functions are available with .NET Framework 4 and later.

## Property function syntax

These are three kinds of property functions; each function has a different syntax:

- String (instance) property functions
- Static property functions
- MSBuild property functions

### String property functions

All build property values are just string values. You can use string (instance) methods to operate on any property value. For example, you can extract the drive name (the first three characters) from a build property that represents a full path by using this code:

```
$(ProjectOutputFolder.Substring(0,3))
```

### Static property functions

In your build script, you can access the static properties and methods of many system classes. To get the value of a static property, use the following syntax, where \<Class> is the name of the system class and \<Property> is the name of the property.

```
$([Class]::Property)
```

For example, you can use the following code to set a build property to the current date and time.

```xml
<Today>$([System.DateTime]::Now)</Today>
```

To call a static method, use the following syntax, where \<Class> is the name of the system class, \<Method> is the name of the method, and (\<Parameters>) is the parameter list for the method:

```
$([Class]::Method(Parameters))
```

For example, to set a build property to a new GUID, you can use this script:

```xml
<NewGuid>$([System.Guid]::NewGuid())</NewGuid>
```

In static property functions, you can use any static method or property of these system classes:

- <xref:System.Byte?displayProperty=nameWithType>
- <xref:System.Char?displayProperty=nameWithType>
- <xref:System.Convert?displayProperty=nameWithType>
- <xref:System.DateTime?displayProperty=nameWithType>
- <xref:System.DateTimeOffset?displayProperty=nameWithType> (Available in MSBuild 17.3 and higher)
- <xref:System.Decimal?displayProperty=nameWithType>
- <xref:System.Double?displayProperty=nameWithType>
- <xref:System.Enum?displayProperty=nameWithType>
- <xref:System.Guid?displayProperty=nameWithType>
- <xref:System.Int16?displayProperty=nameWithType>
- <xref:System.Int32?displayProperty=nameWithType>
- <xref:System.Int64?displayProperty=nameWithType>
- <xref:System.IO.Path?displayProperty=nameWithType>
- <xref:System.Math?displayProperty=nameWithType>
- <xref:System.Runtime.InteropServices.OSPlatform?displayProperty=nameWithType>
- <xref:System.Runtime.InteropServices.RuntimeInformation?displayProperty=nameWithType>
- <xref:System.UInt16?displayProperty=nameWithType>
- <xref:System.UInt32?displayProperty=nameWithType>
- <xref:System.UInt64?displayProperty=nameWithType>
- <xref:System.SByte?displayProperty=nameWithType>
- <xref:System.Single?displayProperty=nameWithType>
- <xref:System.String?displayProperty=nameWithType>
- <xref:System.StringComparer?displayProperty=nameWithType>
- <xref:System.TimeSpan?displayProperty=nameWithType>
- <xref:System.Text.RegularExpressions.Regex?displayProperty=nameWithType>
- <xref:System.UriBuilder?displayProperty=nameWithType>
- <xref:System.Version?displayProperty=nameWithType>
- <xref:Microsoft.Build.Utilities.ToolLocationHelper?displayProperty=nameWithType>

In addition, you can use the following static methods and properties:

- [System.Environment::CommandLine](xref:System.Environment.CommandLine*)
- [System.Environment::ExpandEnvironmentVariables](xref:System.Environment.ExpandEnvironmentVariables*)
- [System.Environment::GetEnvironmentVariable](xref:System.Environment.GetEnvironmentVariable*)
- [System.Environment::GetEnvironmentVariables](xref:System.Environment.GetEnvironmentVariables*)
- [System.Environment::GetFolderPath](xref:System.Environment.GetFolderPath*)
- [System.Environment::GetLogicalDrives](xref:System.Environment.GetLogicalDrives*)
- [System.Environment::Is64BitOperatingSystem](xref:System.Environment.Is64BitOperatingSystem*)
- [System.Environment::Is64BitProcess](xref:System.Environment.Is64BitProcess*)
- [System.Environment::MachineName](xref:System.Environment.MachineName*)
- [System.Environment::NewLine](xref:System.Environment.NewLine*) (Available in MSBuild 17.3 and higher)
- [System.Environment::OSVersion](xref:System.Environment.OSVersion*)
- [System.Environment::ProcessorCount](xref:System.Environment.ProcessorCount*)
- [System.Environment::StackTrace](xref:System.Environment.StackTrace*)
- [System.Environment::SystemDirectory](xref:System.Environment.SystemDirectory*)
- [System.Environment::SystemPageSize](xref:System.Environment.SystemPageSize*)
- [System.Environment::TickCount](xref:System.Environment.TickCount*)
- [System.Environment::UserDomainName](xref:System.Environment.UserDomainName*)
- [System.Environment::UserInteractive](xref:System.Environment.UserInteractive*)
- [System.Environment::UserName](xref:System.Environment.UserName*)
- [System.Environment::Version](xref:System.Environment.UserName*)
- [System.Environment::WorkingSet](xref:System.Environment.WorkingSet*)
- [System.IO.Directory::GetDirectories](xref:System.IO.Directory.GetDirectories*)
- [System.IO.Directory::GetFiles](xref:System.IO.Directory.GetFiles*)
- [System.IO.Directory::GetLastAccessTime](xref:System.IO.Directory.GetLastAccessTime*)
- [System.IO.Directory::GetLastWriteTime](xref:System.IO.Directory.GetLastWriteTime*)
- [System.IO.Directory::GetParent](xref:System.IO.Directory.GetParent*)
- [System.IO.File::Exists](xref:System.IO.File.Exists*)
- [System.IO.File::GetAttributes](xref:System.IO.File.GetAttributes*)
- [System.IO.File::GetCreationTime](xref:System.IO.File.GetCreationTime*)
- [System.IO.File::GetLastAccessTime](xref:System.IO.File.GetLastAccessTime*)
- [System.IO.File::GetLastWriteTime](xref:System.IO.File.GetLastWriteTime*)
- [System.IO.File::ReadAllText](xref:System.IO.File.ReadAllText*)

### Calling instance methods on static properties

If you access a static property that returns an object instance, you can invoke the instance methods of that object. To invoke an instance method, use the following syntax, where \<Class> is the name of the system class, \<Property> is the name of the property, \<Method> is the name of the method, and (\<Parameters>) is the parameter list for the method:

```
$([Class]::Property.Method(Parameters))
```

The name of the class must be fully qualified with the namespace.

For example, you can use the following code to set a build property to the current date today.

```xml
<Today>$([System.DateTime]::Now.ToString('yyyy.MM.dd'))</Today>
```

### MSBuild property functions

Several static methods in your build can be accessed to provide arithmetic, bitwise logical, and escape character support. You access these methods by using the following syntax, where \<Method> is the name of the method and (\<Parameters>) is the parameter list for the method.

```
$([MSBuild]::Method(Parameters))
```

For example, to add together two properties that have numeric values, use the following code.

```
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
|string GetPathOfFileAbove(string file, string startingDirectory)|Searches for and returns the full path to a file in the directory structure at and above the current build file's location, or based on `startingDirectory`, if specified.|
|GetDirectoryNameOfFileAbove(string startingDirectory, string fileName)|Locate and return the directory of a file in either the directory specified or a location in the directory structure above that directory.|
|string MakeRelative(string basePath, string path)|Makes `path` relative to `basePath`. `basePath` must be an absolute directory. If `path` cannot be made relative, it is returned verbatim. Similar to `Uri.MakeRelativeUri`.|
|string ValueOrDefault(string conditionValue, string defaultValue)|Returns the string in parameter `defaultValue` only if parameter `conditionValue` is empty, else, return the value `conditionValue`.|
|string ConvertToBase64(string toEncode)|Returns the string after converting all bytes to base 64 (alphanumeric characters plus `+` and `/`), ending in one or two `=`.|
|string ConvertFromBase64(string toDecode)|Returns the string after converting from base 64 (alphanumeric characters plus `+` and `/`), ending in one or two `=`.|

## Nested property functions

You can combine property functions to form more complex functions, as the following example shows.

```
$([MSBuild]::BitwiseAnd(32, $([System.IO.File]::GetAttributes(tempFile))))
```

This example returns the value of the <xref:System.IO.FileAttributes>.`Archive` bit (32 or 0) of the file given by the path `tempFile`. Notice that enumerated data values cannot appear by name in some contexts. In the previous example, the numeric value (32) must be used instead. In other cases, depending on the expectations of the method called, the enum data value must be used. In the following example, the enum value <xref:System.Text.RegularExpressions.RegexOptions>.`ECMAScript` must be used because a numeric value cannot be converted as this method expects.

```xml
<PropertyGroup>
    <GitVersionHeightWithOffset>$([System.Text.RegularExpressions.Regex]::Replace("$(PrereleaseVersion)", "^.*?(\d+)$", "$1", "System.Text.RegularExpressions.RegexOptions.ECMAScript"))</GitVersionHeightWithOffset>
</PropertyGroup>
```

Metadata may also appear in nested property functions. For more information, see [Batching](../msbuild/msbuild-batching.md).

## MSBuild DoesTaskHostExist

The `DoesTaskHostExist` property function in MSBuild returns whether a task host is currently installed for the specified runtime and architecture values.

This property function has the following syntax:

```
$([MSBuild]::DoesTaskHostExist(string theRuntime, string theArchitecture))
```

## MSBuild EnsureTrailingSlash

The `EnsureTrailingSlash` property function in MSBuild adds a trailing slash if one doesn't already exist.

This property function has the following syntax:

```
$([MSBuild]::EnsureTrailingSlash('$(PathProperty)'))
```

## MSBuild GetDirectoryNameOfFileAbove

The MSBuild `GetDirectoryNameOfFileAbove` property function searches upward for a directory containing the specified file, beginning in (and including) the specified directory. It returns the full path of the nearest directory containing the file if it is found, otherwise an empty string.

This property function has the following syntax:

```
$([MSBuild]::GetDirectoryNameOfFileAbove(string startingDirectory, string fileName))
```

This example shows how to import the nearest *EnlistmentInfo.props* file in or above the current folder, only if a match is found:

```xml
<Import Project="$([MSBuild]::GetDirectoryNameOfFileAbove($(MSBuildThisFileDirectory), EnlistmentInfo.props))\EnlistmentInfo.props" Condition=" '$([MSBuild]::GetDirectoryNameOfFileAbove($(MSBuildThisFileDirectory), EnlistmentInfo.props))' != '' " />
```

Note that this example can be written more concisely by using the `GetPathOfFileAbove` function instead:

```xml
<Import Project="$([MSBuild]::GetPathOfFileAbove(EnlistmentInfo.props))" Condition=" '$([MSBuild]::GetPathOfFileAbove(EnlistmentInfo.props))' != '' " />
```

## MSBuild GetPathOfFileAbove

The MSBuild `GetPathOfFileAbove` property function searches upward for a directory containing the specified file, beginning in (and including) the specified directory. It returns the full path of the nearest matching file if it is found, otherwise an empty string.

This property function has the following syntax:

```
$([MSBuild]::GetPathOfFileAbove(string file, [string startingDirectory]))
```

where `file` is the name of the file to search for and `startingDirectory` is an optional directory to start the search in. By default, the search will start in the current file's own directory.
 
This example shows how to import a file named *dir.props* in or above the current directory, only if a match is found:

```xml
<Import Project="$([MSBuild]::GetPathOfFileAbove(dir.props))" Condition=" '$([MSBuild]::GetPathOfFileAbove(dir.props))' != '' " />
```

which is functionally equivalent to

```xml
<Import Project="$([MSBuild]::GetDirectoryNameOfFileAbove($(MSBuildThisFileDirectory), dir.props))\dir.props" Condition=" '$([MSBuild]::GetDirectoryNameOfFileAbove($(MSBuildThisFileDirectory), dir.props))' != '' " />
```

However, sometimes you need to start the search in the parent directory, to avoid matching the current file. This example shows how a *Directory.Build.props* file can import the nearest *Directory.Build.props* file in a strictly higher level of the tree, without recursively importing itself:

```xml
<Import Project="$([MSBuild]::GetPathOfFileAbove('Directory.Build.props', '$(MSBuildThisFileDirectory)../'))" />
```

which is functionally equivalent to

```xml
<Import Project="$([MSBuild]::GetDirectoryNameOfFileAbove('$(MSBuildThisFileDirectory)../', 'Directory.Build.props'))/Directory.Build.props" />
```

## MSBuild GetRegistryValue

The MSBuild `GetRegistryValue` property function returns the value of a registry key. This function takes two arguments, the key name and the value name, and returns the value from the registry. If you don't specify a value name, the default value is returned.

The following examples show how this function is used:

```
$([MSBuild]::GetRegistryValue(`HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\10.0\Debugger`, ``))                                  // default value
$([MSBuild]::GetRegistryValue(`HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\10.0\Debugger`, `SymbolCacheDir`))
$([MSBuild]::GetRegistryValue(`HKEY_LOCAL_MACHINE\SOFTWARE\(SampleName)`, `(SampleValue)`))             // parens in name and value
```

> [!WARNING]
> In the .NET SDK version of MSBuild (`dotnet build`), this function is not supported.

## MSBuild GetRegistryValueFromView

The MSBuild `GetRegistryValueFromView` property function gets system registry data given the registry key, value, and one or more ordered registry views. The key and value are searched in each registry view in order until they are found.

The syntax for this property function is:

```
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

 ```
$([MSBuild]::GetRegistryValueFromView('HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Microsoft SDKs\Silverlight\v3.0\ReferenceAssemblies', 'SLRuntimeInstallPath', null, RegistryView.Registry64, RegistryView.Registry32))
```

gets the **SLRuntimeInstallPath** data of the **ReferenceAssemblies** key, looking first in the 64-bit registry view and then in the 32-bit registry view.

> [!WARNING]
> In the .NET SDK version of MSBuild (`dotnet build`), this function is not supported.

## MSBuild MakeRelative

The MSBuild `MakeRelative` property function returns the relative path of the second path relative to first path. Each path can be a file or folder.

This property function has the following syntax:

```
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

<a name="TargetFramework"></a>

## MSBuild TargetFramework and TargetPlatform functions

MSBuild 16.7 and higher define several functions for handling [TargetFramework and TargetPlatform properties](msbuild-target-framework-and-target-platform.md).

|Function signature|Description|
|------------------------|-----------------|
|GetTargetFrameworkIdentifier(string targetFramework)|Parse the TargetFrameworkIdentifier from the TargetFramework.|
|GetTargetFrameworkVersion(string targetFramework, int versionPartCount)|Parse the TargetFrameworkVersion from the TargetFramework.|
|GetTargetPlatformIdentifier(string targetFramework)|Parse the TargetPlatformIdentifier from the TargetFramework.|
|GetTargetPlatformVersion(string targetFramework, int versionPartCount)|Parse the TargetPlatformVersion from the TargetFramework.|
|IsTargetFrameworkCompatible(string targetFrameworkTarget, string targetFrameworkCandidate)|Return 'True' if the candidate target framework is compatible with this target framework and false otherwise.|

The `versionPartCount` parameter of `GetTargetFrameworkVersion` and `GetTargetPlatformVersion` has a default value of 2.

The following example shows how these functions are used. 

```xml
<Project ToolsVersion="4.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">

    <PropertyGroup>
        <Value1>$([MSBuild]::GetTargetFrameworkIdentifier('net5.0-windows7.0'))</Value1>
        <Value2>$([MSBuild]::GetTargetFrameworkVersion('net5.0-windows7.0'))</Value2>
        <Value3>$([MSBuild]::GetTargetPlatformIdentifier('net5.0-windows7.0'))</Value3>
        <Value4>$([MSBuild]::GetTargetPlatformVersion('net5.0-windows7.0'))</Value4>
        <Value5>$([MSBuild]::IsTargetFrameworkCompatible('net5.0-windows', 'net5.0'))</Value5>
    </PropertyGroup>

    <Target Name="MyTarget">
        <Message Text="Value1 = $(Value1)" />
        <Message Text="Value2 = $(Value2)" />
        <Message Text="Value3 = $(Value3)" />
        <Message Text="Value4 = $(Value4)" />
        <Message Text="Value5 = $(Value5)" />
    </Target>
</Project>
```

```output
Value1 = .NETCoreApp
Value2 = 5.0
Value3 = windows
Value4 = 7.0
Value5 = True
```

## MSBuild version-comparison functions

MSBuild 16.5 and higher define several functions for comparing strings that represent versions.

> [!Note]
> Comparison operators in conditions [can compare strings that can be parsed as `System.Version` objects](msbuild-conditions.md#comparing-versions), but the comparison can produce unexpected results. Prefer the property functions.

|Function signature|Description|
|------------------------|-----------------|
|VersionEquals(string a, string b)|Return `true` if versions `a` and `b` are equivalent according to the below rules.|
|VersionGreaterThan(string a, string b)|Return `true` if version `a` is greater than `b` according to the below rules.|
|VersionGreaterThanOrEquals(string a, string b)|Return `true` if version `a` is greater than or equal to `b` according to the below rules.|
|VersionLessThan(string a, string b)|Return `true` if version `a` is less than `b` according to the below rules.|
|VersionLessThanOrEquals(string a, string b)|Return `true` if version `a` is less than or equal to `b` according to the below rules.|
|VersionNotEquals(string a, string b)|Return `false` if versions `a` and `b` are equivalent according to the below rules.|

In these methods, versions are parsed like <xref:System.Version?displayProperty=fullName>, with the following exceptions:

* Leading `v` or `V` is ignored, which allows comparison to `$(TargetFrameworkVersion)`.

* Everything from the first '-' or '+' to the end of the version string is ignored. This allows passing in semantic versions (semver), though the order is not the same as semver. Instead, prerelease specifiers and build metadata do not have any sorting weight. This can be useful, for example, to turn on a feature for `>= x.y` and have it kick in on `x.y.z-pre`.

* Unspecified parts are same as zero value parts. (`x == x.0 == x.0.0 == x.0.0.0`).

* Whitespace is not allowed in integer components.

* Major version only is valid (`3` is equal to `3.0.0.0`)

* `+` is not allowed as positive sign in integer components (it is treated as semver metadata and ignored)

> [!TIP]
> Comparisons of [TargetFramework properties](msbuild-target-framework-and-target-platform.md) should generally use [IsTargetFrameworkCompatible](#TargetFramework) instead of extracting and comparing versions. This allows comparing `TargetFramework`s that vary in `TargetFrameworkIdentifier` as well as version.

## MSBuild condition functions

The functions `Exists` and `HasTrailingSlash` are not property functions. They are available for use with the `Condition` attribute. See [MSBuild conditions](msbuild-conditions.md).

## See also

- [MSBuild properties](../msbuild/msbuild-properties.md)

- [MSBuild overview](../msbuild/msbuild.md)
