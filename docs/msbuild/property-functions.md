---
title: Use property functions to call .NET methods
description: Use property functions to call .NET methods that appear in MSBuild property definitions, and see examples for working with the properties and methods.
ms.date: 6/4/2025
ms.topic: how-to
helpviewer_keywords:
- MSBuild, property functions
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Property functions

Property functions are calls to .NET methods that appear in MSBuild property definitions. You typically use them to construct property definitions that require more complex logic.

Unlike tasks, property functions can be used outside of targets. Property functions are evaluated whenever the properties or items get expanded. So, for properties and items outside of any targets, property functions are evaluated before any target runs. For property groups and item groups inside targets, property functions are evaluated when the target is executed.

Without using MSBuild tasks, you can read the system time, compare strings, match regular expressions, and perform other actions in your build script. MSBuild will try to convert string to number and number to string, and make other conversions as required.

String values returned from property functions have [special characters](msbuild-special-characters.md) escaped. If you want the value to be treated as though it was put directly in the project file, use `$([MSBuild]::Unescape())` to unescape the special characters.

## Property function syntax

These are three kinds of property functions; each function has a different syntax:

- String (instance) property functions
- Static property functions
- MSBuild property functions

### String property functions

All build property values are just string values. You can use string (instance) methods to operate on any property value. For example, you can extract the drive name (the first three characters) from a build property that represents a full path by using this code:

```xml
$(ProjectOutputFolder.Substring(0,3))
```

### Static property functions

In your build script, you can access the static properties and methods of many system classes. To get the value of a static property, use the following syntax, where `Class` is the name of the system class and `Property` is the name of the property.

```xml
$([Class]::Property)
```

For example, you can use the following code to set a build property to the current date and time.

```xml
<Today>$([System.DateTime]::Now)</Today>
```

To call a static method, use the following syntax, where `Class` is the name of the system class, `Method` is the name of the method, and `(Parameters)` is the parameter list for the method:

```xml
$([Class]::Method(Parameters))
```

For example, to set a build property to a new GUID, you can use this script:

```xml
<NewGuid>$([System.Guid]::NewGuid())</NewGuid>
```

In static property functions, you can use any public static method or property that's defined in .NET Standard 2.0 for these system classes:

- [System.Byte](/dotnet/api/System.Byte?view=netstandard-2.0&preserve-view=true)
- [System.Char](/dotnet/api/System.Char?view=netstandard-2.0&preserve-view=true)
- [System.Convert](/dotnet/api/System.Convert?view=netstandard-2.0&preserve-view=true)
- [System.DateTime](/dotnet/api/System.DateTime?view=netstandard-2.0&preserve-view=true)
- [System.DateTimeOffset](/dotnet/api/System.DateTimeOffset?view=netstandard-2.0&preserve-view=true) (Available in MSBuild 17.3 and higher)
- [System.Decimal](/dotnet/api/System.Decimal?view=netstandard-2.0&preserve-view=true)
- [System.Double](/dotnet/api/System.Double?view=netstandard-2.0&preserve-view=true)
- [System.Enum](/dotnet/api/System.Enum?view=netstandard-2.0&preserve-view=true)
- [System.Guid](/dotnet/api/System.Guid?view=netstandard-2.0&preserve-view=true)
- [System.Int16](/dotnet/api/System.Int16?view=netstandard-2.0&preserve-view=true)
- [System.Int32](/dotnet/api/System.Int32?view=netstandard-2.0&preserve-view=true)
- [System.Int64](/dotnet/api/System.Int64?view=netstandard-2.0&preserve-view=true)
- [System.IO.Path](/dotnet/api/System.IO.Path?view=netstandard-2.0&preserve-view=true)
- [System.Math](/dotnet/api/system.math?view=netstandard-2.0&preserve-view=true)
- [System.Runtime.InteropServices.OSPlatform](/dotnet/api/System.Runtime.InteropServices.OSPlatform?view=netstandard-2.0&preserve-view=true)
- [System.Runtime.InteropServices.RuntimeInformation](/dotnet/api/System.Runtime.InteropServices.RuntimeInformation?view=netstandard-2.0&preserve-view=true)
- [System.UInt16](/dotnet/api/System.UInt16?view=netstandard-2.0&preserve-view=true)
- [System.UInt32](/dotnet/api/System.UInt32?view=netstandard-2.0&preserve-view=true)
- [System.UInt64](/dotnet/api/System.UInt64?view=netstandard-2.0&preserve-view=true)
- [System.SByte](/dotnet/api/System.SByte?view=netstandard-2.0&preserve-view=true)
- [System.Single](/dotnet/api/System.Single?view=netstandard-2.0&preserve-view=true)
- [System.String](/dotnet/api/System.String?view=netstandard-2.0&preserve-view=true)
- [System.StringComparer](/dotnet/api/System.StringComparer?view=netstandard-2.0&preserve-view=true)
- [System.TimeSpan](/dotnet/api/System.TimeSpan?view=netstandard-2.0&preserve-view=true)
- [System.Text.RegularExpressions.Regex](/dotnet/api/System.Text.RegularExpressions.Regex?view=netstandard-2.0&preserve-view=true)
- [System.UriBuilder](/dotnet/api/System.UriBuilder?view=netstandard-2.0&preserve-view=true)
- [System.Version](/dotnet/api/System.Version?view=netstandard-2.0&preserve-view=true)
- [Microsoft.Build.Utilities.ToolLocationHelper](/dotnet/api/Microsoft.Build.Utilities.ToolLocationHelper)

> [!NOTE]
> Methods and properties that aren't defined in .NET Standard 2.0 might be available when you use MSBuild in an environment that supports them, but can't be guaranteed to be available in all situations. For compatibility reasons, they are best avoided.

In addition, you can use the following static methods and properties:

- [System.Environment::CommandLine](/dotnet/api/System.Environment.CommandLine?view=netstandard-2.0&preserve-view=true)
- [System.Environment::ExpandEnvironmentVariables](/dotnet/api/System.Environment.ExpandEnvironmentVariables?view=netstandard-2.0&preserve-view=true)
- [System.Environment::GetEnvironmentVariable](/dotnet/api/System.Environment.GetEnvironmentVariable?view=netstandard-2.0&preserve-view=true)
- [System.Environment::GetEnvironmentVariables](/dotnet/api/System.Environment.GetEnvironmentVariables?view=netstandard-2.0&preserve-view=true)
- [System.Environment::GetFolderPath](/dotnet/api/System.Environment.GetFolderPath?view=netstandard-2.0&preserve-view=true)
- [System.Environment::GetLogicalDrives](/dotnet/api/System.Environment.GetLogicalDrives?view=netstandard-2.0&preserve-view=true)
- [System.Environment::Is64BitOperatingSystem](/dotnet/api/System.Environment.Is64BitOperatingSystem?view=netstandard-2.0&preserve-view=true)
- [System.Environment::Is64BitProcess](/dotnet/api/System.Environment.Is64BitProcess?view=netstandard-2.0&preserve-view=true)
- [System.Environment::MachineName](/dotnet/api/System.Environment.MachineName?view=netstandard-2.0&preserve-view=true)
- [System.Environment::NewLine](/dotnet/api/System.Environment.NewLine?view=netstandard-2.0&preserve-view=true)
- [System.Environment::OSVersion](/dotnet/api/System.Environment.OSVersion?view=netstandard-2.0&preserve-view=true)
- [System.Environment::ProcessorCount](/dotnet/api/System.Environment.ProcessorCount?view=netstandard-2.0&preserve-view=true)
- [System.Environment::StackTrace](/dotnet/api/System.Environment.StackTrace?view=netstandard-2.0&preserve-view=true)
- [System.Environment::SystemDirectory](/dotnet/api/System.Environment.SystemDirectory?view=netstandard-2.0&preserve-view=true)
- [System.Environment::SystemPageSize](/dotnet/api/System.Environment.SystemPageSize?view=netstandard-2.0&preserve-view=true)
- [System.Environment::TickCount](/dotnet/api/System.Environment.TickCount?view=netstandard-2.0&preserve-view=true)
- [System.Environment::UserDomainName](/dotnet/api/System.Environment.UserDomainName?view=netstandard-2.0&preserve-view=true)
- [System.Environment::UserInteractive](/dotnet/api/System.Environment.UserInteractive?view=netstandard-2.0&preserve-view=true)
- [System.Environment::UserName](/dotnet/api/System.Environment.UserName?view=netstandard-2.0&preserve-view=true)
- [System.Environment::Version](/dotnet/api/System.Environment.Version?view=netstandard-2.0&preserve-view=true)
- [System.Environment::WorkingSet](/dotnet/api/System.Environment.WorkingSet?view=netstandard-2.0&preserve-view=true)
- [System.IO.Directory::GetDirectories](/dotnet/api/System.IO.Directory.GetDirectories?view=netstandard-2.0&preserve-view=true)
- [System.IO.Directory::GetFiles](/dotnet/api/System.IO.Directory.GetFiles?view=netstandard-2.0&preserve-view=true)
- [System.IO.Directory::GetLastAccessTime](/dotnet/api/System.IO.Directory.GetLastAccessTime?view=netstandard-2.0&preserve-view=true)
- [System.IO.Directory::GetLastWriteTime](/dotnet/api/System.IO.Directory.GetLastWriteTime?view=netstandard-2.0&preserve-view=true)
- [System.IO.Directory::GetParent](/dotnet/api/System.IO.Directory.GetParent?view=netstandard-2.0&preserve-view=true)
- [System.IO.File::Exists](/dotnet/api/System.IO.File.Exists?view=netstandard-2.0&preserve-view=true)
- [System.IO.File::GetAttributes](/dotnet/api/System.IO.File.GetAttributes?view=netstandard-2.0&preserve-view=true)
- [System.IO.File::GetCreationTime](/dotnet/api/System.IO.File.GetCreationTime?view=netstandard-2.0&preserve-view=true)
- [System.IO.File::GetLastAccessTime](/dotnet/api/System.IO.File.GetLastAccessTime?view=netstandard-2.0&preserve-view=true)
- [System.IO.File::GetLastWriteTime](/dotnet/api/System.IO.File.GetLastWriteTime?view=netstandard-2.0&preserve-view=true)
- [System.IO.File::ReadAllText](/dotnet/api/System.IO.File.ReadAllText?view=netstandard-2.0&preserve-view=true)
- [System.Globalization.CultureInfo::GetCultureInfo](/dotnet/api/System.Globalization.CultureInfo.GetCultureInfo?view=netstandard-2.0&preserve-view=true)
- [System.Globalization.CultureInfo::new](/dotnet/api/System.Globalization.CultureInfo.-ctor?view=netstandard-2.0&preserve-view=true)
- [System.Globalization.CultureInfo::CurrentUICulture](/dotnet/api/System.Globalization.CultureInfo.CurrentUICulture?view=netstandard-2.0&preserve-view=true)

:::moniker range=">=vs-2022"
#### System.OperatingSystem property functions

The `System.OperatingSystem` property functions return information about the operating system on which MSBuild is running. For example, if your project targets Linux and you build it on macOS, the property functions will return information about macOS.

In MSBuild running on .NET (`dotnet build`), all static methods of the `System.OperatingSystem` class will be callable as static property functions.

In MSBuild running on .NET Framework (`MSBuild.exe`), only the following methods of `System.OperatingSystem` will be callable as static property functions. MSBuild implements them internally, because `System.OperatingSystem` does not define them on .NET Framework. Methods for operating systems for which there is no .NET SDK, such as `System.OperatingSystem::IsTvOS`, are not callable.

- [System.OperatingSystem::IsOSPlatform](/dotnet/api/System.OperatingSystem.IsOSPlatform)
- [System.OperatingSystem::IsOSPlatformVersionAtLeast](/dotnet/api/System.OperatingSystem.IsOSPlatformVersionAtLeast)
- [System.OperatingSystem::IsLinux](/dotnet/api/System.OperatingSystem.IsLinux)
- [System.OperatingSystem::IsFreeBSD](/dotnet/api/System.OperatingSystem.IsFreeBSD)
- [System.OperatingSystem::IsFreeBSDVersionAtLeast](/dotnet/api/System.OperatingSystem.IsFreeBSDVersionAtLeast)
- [System.OperatingSystem::IsMacOS](/dotnet/api/System.OperatingSystem.IsMacOS)
- [System.OperatingSystem::IsMacOSVersionAtLeast](/dotnet/api/System.OperatingSystem.IsMacOSVersionAtLeast)
- [System.OperatingSystem::IsWindows](/dotnet/api/System.OperatingSystem.IsWindows)
- [System.OperatingSystem::IsWindowsVersionAtLeast](/dotnet/api/System.OperatingSystem.IsWindowsVersionAtLeast)

The following example shows the usage of these property functions.

```xml
<IsWindows>$([System.OperatingSystem]::IsWindows())</IsWindows>
```

:::moniker-end

### Calling instance methods on static properties

If you access a static property that returns an object instance, you can invoke the instance methods of that object. To invoke an instance method, use the following syntax, where `Class` is the name of the system class, `Property` is the name of the property, `Method` is the name of the method, and `(Parameters)` is the parameter list for the method:

```xml
$([Class]::Property.Method(Parameters))
```

The name of the class must be fully qualified with the namespace.

For example, you can use the following code to set a build property to the current date today.

```xml
<Today>$([System.DateTime]::Now.ToString('yyyy.MM.dd'))</Today>
```

### MSBuild property functions

Several static methods in your build can be accessed to provide arithmetic, bitwise logical, and escape character support. You access these methods by using the following syntax, where `Method` is the name of the method and `(Parameters)` is the parameter list for the method.

```xml
$([MSBuild]::Method(Parameters))
```

For example, to add together two properties that have numeric values, use the following code.

```xml
$([MSBuild]::Add($(NumberOne), $(NumberTwo)))
```

Here is a list of MSBuild property functions:

|Function signature|Description|
|------------------------|-----------------|
|`double Add(double a, double b)`|Add two doubles.|
|`long Add(long a, long b)`|Add two longs.|
|`int BitwiseOr(int first, int second)`|Perform a bitwise `OR` on the first and second (first &#124; second).|
|`int BitwiseAnd(int first, int second)`|Perform a bitwise `AND` on the first and second (first & second).|
|`int BitwiseXor(int first, int second)`|Perform a bitwise `XOR` on the first and second (first ^ second).|
|`int BitwiseNot(int first)`|Perform a bitwise `NOT` (~first).|
|`string CheckFeatureAvailability(string featureName)`| Returns the feature name as a string if and only if the specified feature is supported in this version of MSBuild. |
|`string ConvertToBase64(string toEncode)`|Returns the string after converting all bytes to base 64 (alphanumeric characters plus `+` and `/`), ending in one or two `=`.|
|`string ConvertFromBase64(string toDecode)`|Returns the string after converting from base 64 (alphanumeric characters plus `+` and `/`), ending in one or two `=`.|
|`string CurrentMSBuildConfigurationFile()`|Gets the path to the configuration file used by this instance of MSBuild.|
|`string CurrentMSBuildExePath()` |Gets the path to the executable file for this instance of MSBuild. This path might not be the current running process. For example, if running inside Visual Studio or another host process, the returned path will point to the version of MSBuild found to be associated with the current environment.|
|`string CurrentMSBuildToolsDirectory()`| Gets the full path to the MSBuild tools directory for the current instance of MSBuild. |
|`double Divide(double a, double b)`|Divide two doubles.|
|`long Divide(long a, long b)`|Divide two longs.|
|`bool DoesTaskHostExist(string runtime, string architecture)`|Returns whether a task host is currently installed for the specified runtime and architecture values.|
|`string Escape(string unescaped)`|Escape the string according to MSBuild escaping rules.|
|`string EnsureTrailingSlash(string path)`|If the given path doesn't have a trailing slash then add one. If the path is an empty string, does not modify it.|
|`string GetCurrentToolsDirectory()`| Get the current MSBuild tools directory. |
|`string GetToolsDirectory32()` | Gets the directory where Arm64 versions of the MSBuild tools are located. |
|`string GetToolsDirectory32()` | Gets the directory where 32-bit versions of the MSBuild tools are located. |
|`string GetToolsDirectory64()` | Gets the directory where 64-bit versions of the MSBuild tools are located. |
|`string GetDirectoryNameOfFileAbove(string startingDirectory, string fileName)`|Locate and return the directory of a file in either the directory specified or a location in the directory structure above that directory.|
|`string GetPathOfFileAbove(string file, string startingDirectory)`|Searches for and returns the full path to a file in the directory structure at and above the current build file's location, or based on `startingDirectory`, if specified.|
|`object GetRegistryValue(string keyName, string valueName, object defaultValue)`|Get the value of the registry key and value.|
|`object GetRegistryValueFromView(string keyName, string valueName, object defaultValue, params object[] views)`|Gets system registry data given the registry key, value, and one or more ordered registry views.|
|`bool IsOsPlatform(string platformString)`|Specify whether the current OS platform is `platformString`. `platformString` must be a member of <xref:System.Runtime.InteropServices.OSPlatform>.|
|`bool IsOsBsdLike()`|True if the current OS is a BSD-style Unix system.|
|`bool IsOSUnixLike()`|True if current OS is a Unix system.|
|`int LeftShift(int operand, int count)`| Shift left by `count` bits.|
|`string MakeRelative(string basePath, string path)`|Makes `path` relative to `basePath`. `basePath` must be an absolute directory. If `path` cannot be made relative, it is returned verbatim. Similar to `Uri.MakeRelativeUri`.|
|`double Modulo(double a, double b)`|Modulo two doubles.|
|`long Modulo(long a, long b)`|Modulo two longs.|
|`string MSBuildExtensionsPath()`| Gets the MSBuild extensions path. When running *MSBuild.exe*, this is usually the MSBuild executable folder. When running in Visual Studio, this is the MSBuild subfolder under the Visual Studio installation folder. |
|`string MSBuildSDKsPath()` | Gets the directory where SDKs are expected, for the current MSBuild instance.|
|`double Multiply(double a, double b)`|Multiply two doubles.|
|`long Multiply(long a, long b)`|Multiply two longs.|
|`string NormalizeDirectory(params string[] path)`|Gets the canonicalized full path of the provided directory and ensures it contains the correct directory separator characters for the current operating system while ensuring it has a trailing slash.|
|`string NormalizePath(params string[] path)`|Gets the canonicalized full path of the provided path and ensures it contains the correct directory separator characters for the current operating system.|
|`int RightShift(int operand, int count)`| Shift right by `count` bits, as a signed integer. |
|`int RightShiftUnsigned(int operand, int count)`| Shift right by `count` bits, treating the operand as an unsigned integer.|
|`object StableStringHash(string toHash, StringHashingAlgorithm algo)`| Accepts a string argument, and returns a hash code that is guaranteed to be stable.|
|`string SubstringByAsciiChars(string input, int start, int length)`|Returns a substring of `input`, starting at the specified `start` position and with the specified `length`, treating the string as ASCII-encoded.|
|`double Subtract(double a, double b)`|Subtract two doubles.|
|`long Subtract(long a, long b)`|Subtract two longs.|
|`string Unescape(string escaped)`|Unescape the string according to MSBuild escaping rules.|
|`string ValueOrDefault(string conditionValue, string defaultValue)`|Returns the string in parameter `defaultValue` only if parameter `conditionValue` is empty, else, return the value `conditionValue`.|
|`string VisualStudioInstallRootDirectory()`|Gets the full path to the root of the Visual Studio installation folder associated with the current instance of MSBuild.|

## Nested property functions

You can combine property functions to form more complex functions, as the following example shows:

```xml
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

```xml
$([MSBuild]::DoesTaskHostExist(string theRuntime, string theArchitecture))
```

## MSBuild EnsureTrailingSlash

The `EnsureTrailingSlash` property function in MSBuild adds a trailing slash if one doesn't already exist.

This property function has the following syntax:

```xml
$([MSBuild]::EnsureTrailingSlash('$(PathProperty)'))
```

## MSBuild GetDirectoryNameOfFileAbove

The MSBuild `GetDirectoryNameOfFileAbove` property function searches upward for a directory containing the specified file, beginning in (and including) the specified directory. It returns the full path of the nearest directory containing the file if it is found, otherwise an empty string.

This property function has the following syntax:

```xml
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

```xml
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

```xml
$([MSBuild]::GetRegistryValue(`HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\10.0\Debugger`, ``))                                  // default value
$([MSBuild]::GetRegistryValue(`HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\10.0\Debugger`, `SymbolCacheDir`))
$([MSBuild]::GetRegistryValue(`HKEY_LOCAL_MACHINE\SOFTWARE\(SampleName)`, `(SampleValue)`))             // parens in name and value
```

> [!WARNING]
> In the .NET SDK version of MSBuild (`dotnet build`), this function is not supported.

## MSBuild GetRegistryValueFromView

The MSBuild `GetRegistryValueFromView` property function gets system registry data given the registry key, value, and one or more ordered registry views. The key and value are searched in each registry view in order until they are found.

The syntax for this property function is:

```xml
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

```xml
$([MSBuild]::GetRegistryValueFromView('HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Microsoft SDKs\Silverlight\v3.0\ReferenceAssemblies', 'SLRuntimeInstallPath', null, RegistryView.Registry64, RegistryView.Registry32))
```

gets the **SLRuntimeInstallPath** data of the **ReferenceAssemblies** key, looking first in the 64-bit registry view and then in the 32-bit registry view.

> [!WARNING]
> In the .NET SDK version of MSBuild (`dotnet build`), this function is not supported.

## MSBuild MakeRelative

The MSBuild `MakeRelative` property function returns the relative path of the second path relative to first path. Each path can be a file or folder.

This property function has the following syntax:

```xml
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

## MSBuild StableStringHash

The MSBuild `StableStringHash` property function accepts a string argument, and returns a hash code that is guaranteed to be stable, meaning that the same code is always returned for the same string input. The returned hash is the same regardless of whether MSBuild or `dotnet build` is used, and is stable across platform architecture, unlike the .NET method `GetHashCode`. It is not guaranteed to be stable across different MSBuild versions.

This function is available in MSBuild 16.9.0 or later.

The following example shows how this function is used.

```xml
<Project>
   <PropertyGroup>
      <MyHash>$([MSBuild]::StableStringHash("test1"))</MyHash>
   </PropertyGroup>

   <Target Name="WriteHash" AfterTargets="Build">
      <Message Text="Hash: $(MyHash)"/>
   </Target>
</Project>
```

With MSBuild version 17.10 and later, this function accepts second, optional, argument requesting the hashing algorithm to be used:

```xml
<Project>
   <PropertyGroup>
      <MyHash>$([MSBuild]::StableStringHash("test1", "Sha256"))</MyHash>
   </PropertyGroup>

   <Target Name="WriteHash" AfterTargets="Build">
      <Message Text="Hash: $(MyHash)"/>
   </Target>
</Project>
```

The second argument is case insensitive and currently supports following values:
* Legacy - keeps the same behavior as calling the function without the second argument. Returns signed 32bit integer with similar properties as `string.GetHashCode`.
* Fnv1a32bit - Returns signed 32bit integer representing a [Fowler–Noll–Vo hash of version '1a'](https://en.wikipedia.org/wiki/Fowler%E2%80%93Noll%E2%80%93Vo_hash_function#FNV-1a_hash) hash of the given string.
* Fnv1a64bit - Returns signed 64bit integer representing a [Fowler–Noll–Vo hash of version '1a'](https://en.wikipedia.org/wiki/Fowler%E2%80%93Noll%E2%80%93Vo_hash_function#FNV-1a_hash) hash of the given string.
* Sha256 - Returns unprefixed hex string representing a SHA256 hash of the given string.

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
|`FilterTargetFrameworks(string incoming, string filter)`|Return the list of the target frameworks that match the specified filter. An incoming target framework from `incoming` is kept if it is compatible with any of the desired target frameworks on `filter`.|
|`GetTargetFrameworkIdentifier(string targetFramework)`|Parse the TargetFrameworkIdentifier from the TargetFramework.|
|`GetTargetFrameworkVersion(string targetFramework, int versionPartCount)`|Parse the TargetFrameworkVersion from the TargetFramework.|
|`GetTargetPlatformIdentifier(string targetFramework)`|Parse the TargetPlatformIdentifier from the TargetFramework.|
|`GetTargetPlatformVersion(string targetFramework, int versionPartCount)`|Parse the TargetPlatformVersion from the TargetFramework.|
|`IsTargetFrameworkCompatible(string targetFrameworkTarget, string targetFrameworkCandidate)`|Return 'True' if the candidate target framework (second argument) is compatible with the target framework indicated by the first argument, and false otherwise.|

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
        <Value6>$([MSBuild]::IsTargetFrameworkCompatible('net5.0', 'net6.0'))</Value6>
        <Value7>$([MSBuild]::IsTargetFrameworkCompatible('net5.0', 'net8.0'))</Value7>
    </PropertyGroup>

    <Target Name="MyTarget">
        <Message Text="Value1 = $(Value1)" />
        <Message Text="Value2 = $(Value2)" />
        <Message Text="Value3 = $(Value3)" />
        <Message Text="Value4 = $(Value4)" />
        <Message Text="Value5 = $(Value5)" />
        <Message Text="Value6 = $(Value6)" />
        <Message Text="Value7 = $(Value7)" />
    </Target>
</Project>
```

```output
Value1 = .NETCoreApp
Value2 = 5.0
Value3 = windows
Value4 = 7.0
Value5 = True
Value6 = False
Value7 = False
```

## MSBuild version-comparison functions

MSBuild 16.5 and higher define several functions for comparing strings that represent versions.

> [!NOTE]
> Comparison operators in conditions [can compare strings that can be parsed as `System.Version` objects](msbuild-conditions.md#comparing-versions), but the comparison can produce unexpected results. Prefer the property functions.

|Function signature|Description|
|------------------------|-----------------|
|`VersionEquals(string a, string b)`|Return `true` if versions `a` and `b` are equivalent according to the below rules.|
|`VersionGreaterThan(string a, string b)`|Return `true` if version `a` is greater than `b` according to the below rules.|
|`VersionGreaterThanOrEquals(string a, string b)`|Return `true` if version `a` is greater than or equal to `b` according to the below rules.|
|`VersionLessThan(string a, string b)`|Return `true` if version `a` is less than `b` according to the below rules.|
|`VersionLessThanOrEquals(string a, string b)`|Return `true` if version `a` is less than or equal to `b` according to the below rules.|
|`VersionNotEquals(string a, string b)`|Return `false` if versions `a` and `b` are equivalent according to the below rules.|

In these methods, versions are parsed like <xref:System.Version?displayProperty=fullName>, with the following exceptions:

- Leading `v` or `V` is ignored, which allows comparison to `$(TargetFrameworkVersion)`.

- Everything from the first '-' or '+' to the end of the version string is ignored. This allows passing in semantic versions (semver), though the order is not the same as semver. Instead, prerelease specifiers and build metadata do not have any sorting weight. This can be useful, for example, to turn on a feature for `>= x.y` and have it kick in on `x.y.z-pre`.

- Unspecified parts are same as zero value parts. (`x == x.0 == x.0.0 == x.0.0.0`).

- Whitespace is not allowed in integer components.

- Major version only is valid (`3` is equal to `3.0.0.0`)

- `+` is not allowed as positive sign in integer components (it is treated as semver metadata and ignored)

> [!TIP]
> Comparisons of [TargetFramework properties](msbuild-target-framework-and-target-platform.md) should generally use [IsTargetFrameworkCompatible](#TargetFramework) instead of extracting and comparing versions. This allows comparing `TargetFramework`s that vary in `TargetFrameworkIdentifier` as well as version.

## MSBuild condition functions

The functions `Exists` and `HasTrailingSlash` are not property functions. They are available for use with the `Condition` attribute. See [MSBuild conditions](msbuild-conditions.md).

## Related content

- [MSBuild properties](../msbuild/msbuild-properties.md)

- [MSBuild overview](../msbuild/msbuild.md)
