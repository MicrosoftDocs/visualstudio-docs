---
title: "Property Functions"
ms.custom: na
ms.date: 10/07/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 2253956e-3ae0-4bdc-9d3a-4881dfae4ddb
caps.latest.revision: 29
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Property Functions
<?xml version="1.0" encoding="utf-8"?>
<developerConceptualDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>In the .NET Framework versions 4 and 4.5, property functions can be used to evaluate MSBuild scripts. Property functions can be used wherever properties appear. Unlike tasks, property functions can be used outside of targets, and are evaluated before any target runs.</para>
    <para>Without using MSBuild tasks, you can read the system time, compare strings, match regular expressions, and perform other actions in your build script. MSBuild will try to convert string to number and number to string, and make other conversions as required.</para>
    <para>
      <embeddedLabel>In this topic:</embeddedLabel>
    </para>
    <list class="bullet">
      <listItem>
        <para>
          <link xlink:href="#BKMK_Syntax">Property Function Syntax</link>
        </para>
        <list class="bullet">
          <listItem>
            <para>
              <link xlink:href="#BKMK_String">String Property Functions</link>
            </para>
          </listItem>
          <listItem>
            <para>
              <link xlink:href="#BKMK_Static">Static Property Functions</link>
            </para>
          </listItem>
          <listItem>
            <para>
              <link xlink:href="#BKMK_InstanceMethods">Calling Instance Methods on Static Properties</link>
            </para>
          </listItem>
          <listItem>
            <para>
              <link xlink:href="#BKMK_PropertyFunctions">MSBuild Property Functions</link>
            </para>
          </listItem>
        </list>
      </listItem>
      <listItem>
        <para>
          <link xlink:href="#BKMK_Nested">Nested Property Functions</link>
        </para>
      </listItem>
      <listItem>
        <para>
          <link xlink:href="#BKMK_DoesTaskHostExist">MSBuild DoesTaskHostExist</link>
        </para>
      </listItem>
      <listItem>
        <para>
          <link xlink:href="#BKMK_GetDirectoryNameOfFileAbove">MSBuild GetDirectoryNameOfFileAbove</link>
        </para>
      </listItem>
      <listItem>
        <para>
          <link xlink:href="#BKMK_GetRegistryValue">MSBuild GetRegistryValue</link>
        </para>
      </listItem>
      <listItem>
        <para>
          <link xlink:href="#BKMK_GetRegistryValueFromView">MSBuild GetRegistryValueFromView</link>
        </para>
      </listItem>
      <listItem>
        <para>
          <link xlink:href="#BKMK_MakeRelative">MSBuild MakeRelative</link>
        </para>
      </listItem>
      <listItem>
        <para>
          <link xlink:href="#BKMK_ValueOrDefault">MSBuild ValueOrDefault</link>
        </para>
      </listItem>
    </list>
  </introduction>
  <section address="BKMK_Syntax">
    <title>Property Function Syntax</title>
    <content>
      <para>These are three kinds of property functions; each function has a different syntax:</para>
      <list class="bullet">
        <listItem>
          <para>String (instance) property functions</para>
        </listItem>
        <listItem>
          <para>Static property functions</para>
        </listItem>
        <listItem>
          <para>MSBuild property functions</para>
        </listItem>
      </list>
    </content>
    <sections>
      <section address="BKMK_String">
        <title>String Property Functions</title>
        <content>
          <para>All build property values are just string values. You can use string (instance) methods to operate on any property value. For example, you can extract the drive name (the first three characters) from a build property that represents a full path by using this code: </para>
          <para>
            <codeInline>$(ProjectOutputFolder.Substring(0,3))</codeInline>
          </para>
        </content>
      </section>
      <section address="BKMK_Static">
        <title>Static Property Functions</title>
        <content>
          <para>In your build script, you can access the static properties and methods of many system classes. To get the value of a static property, use the following syntax, where <placeholder>Class</placeholder> is the name of the system class and <placeholder>Property</placeholder> is the name of the property.</para>
          <para>
            <codeInline>$([Class]::Property)</codeInline>
          </para>
          <para>For example, you can use the following code to set a build property to the current date and time.</para>
          <para>
            <codeInline>&lt;Today&gt;$([System.DateTime]::Now)&lt;/Today&gt;</codeInline>
          </para>
          <para>To call a static method, use the following syntax, where <placeholder>Class</placeholder> is the name of the system class, <placeholder>Method</placeholder> is the name of the method, and <placeholder>(Parameters)</placeholder> is the parameter list for the method:</para>
          <para>
            <codeInline>$([Class]::Method(Parameters))</codeInline>
          </para>
          <para>For example, to set a build property to a new GUID, you can use this script:</para>
          <para>
            <codeInline>&lt;NewGuid&gt;$([System.Guid]::NewGuid())&lt;/NewGuid&gt;</codeInline>
          </para>
          <para>In static property functions, you can use any static method or property of these system classes:</para>
          <list class="bullet">
            <listItem>
              <para>System.Byte</para>
            </listItem>
            <listItem>
              <para>System.Char</para>
            </listItem>
            <listItem>
              <para>System.Convert</para>
            </listItem>
            <listItem>
              <para>System.DateTime </para>
            </listItem>
            <listItem>
              <para>System.Decimal</para>
            </listItem>
            <listItem>
              <para>System.Double</para>
            </listItem>
            <listItem>
              <para>System.Enum</para>
            </listItem>
            <listItem>
              <para>System.Guid</para>
            </listItem>
            <listItem>
              <para>System.Int16</para>
            </listItem>
            <listItem>
              <para>System.Int32</para>
            </listItem>
            <listItem>
              <para>System.Int64</para>
            </listItem>
            <listItem>
              <para>System.IO.Path</para>
            </listItem>
            <listItem>
              <para>System.Math</para>
            </listItem>
            <listItem>
              <para>System.UInt16</para>
            </listItem>
            <listItem>
              <para>System.UInt32</para>
            </listItem>
            <listItem>
              <para>System.UInt64</para>
            </listItem>
            <listItem>
              <para>System.SByte</para>
            </listItem>
            <listItem>
              <para>System.Single</para>
            </listItem>
            <listItem>
              <para>System.String</para>
            </listItem>
            <listItem>
              <para>System.StringComparer</para>
            </listItem>
            <listItem>
              <para>System.TimeSpan</para>
            </listItem>
            <listItem>
              <para>System.Text.RegularExpressions.Regex</para>
            </listItem>
            <listItem>
              <para>Microsoft.Build.Utilities.ToolLocationHelper</para>
            </listItem>
          </list>
          <para>In addition, you can use the following static methods and properties:</para>
          <list class="bullet">
            <listItem>
              <para>System.Environment::CommandLine</para>
            </listItem>
            <listItem>
              <para>System.Environment::ExpandEnvironmentVariables</para>
            </listItem>
            <listItem>
              <para>System.Environment::GetEnvironmentVariable</para>
            </listItem>
            <listItem>
              <para>System.Environment::GetEnvironmentVariables</para>
            </listItem>
            <listItem>
              <para>System.Environment::GetFolderPath</para>
            </listItem>
            <listItem>
              <para>System.Environment::GetLogicalDrives</para>
            </listItem>
            <listItem>
              <para>System.IO.Directory::GetDirectories</para>
            </listItem>
            <listItem>
              <para>System.IO.Directory::GetFiles</para>
            </listItem>
            <listItem>
              <para>System.IO.Directory::GetLastAccessTime</para>
            </listItem>
            <listItem>
              <para>System.IO.Directory::GetLastWriteTime</para>
            </listItem>
            <listItem>
              <para>System.IO.Directory::GetParent</para>
            </listItem>
            <listItem>
              <para>System.IO.File::Exists</para>
            </listItem>
            <listItem>
              <para>System.IO.File::GetCreationTime</para>
            </listItem>
            <listItem>
              <para>System.IO.File::GetAttributes</para>
            </listItem>
            <listItem>
              <para>System.IO.File::GetLastAccessTime</para>
            </listItem>
            <listItem>
              <para>System.IO.File::GetLastWriteTime</para>
            </listItem>
            <listItem>
              <para>System.IO.File::ReadAllText</para>
            </listItem>
          </list>
        </content>
      </section>
      <section address="BKMK_InstanceMethods">
        <title>Calling Instance Methods on Static Properties</title>
        <content>
          <para>If you access a static property that returns an object instance, you can invoke the instance methods of that object. To invoke an instance method, use the following syntax, where <placeholder>Class</placeholder> is the name of the system class, <placeholder>Property</placeholder> is the name of the property, <placeholder>Method</placeholder> is the name of the method, and <placeholder>(Parameters)</placeholder> is the parameter list for the method:</para>
          <para>
            <codeInline>$([Class]::Property.Method(Parameters))</codeInline>
          </para>
          <para>The name of the class must be fully qualified with the namespace. </para>
          <para>For example, you can use the following code to set a build property to the current date today.</para>
          <para>
            <codeInline>&lt;Today&gt;$([System.DateTime]::Now.ToString("yyyy.MM.dd"))&lt;/Today&gt;</codeInline>
          </para>
        </content>
      </section>
      <section address="BKMK_PropertyFunctions">
        <title>MSBuild Property Functions</title>
        <content>
          <para>Several static methods in your build can be accessed to provide arithmetic, bitwise logical, and escape character support. You access these methods by using the following syntax, where <placeholder>Method</placeholder> is the name of the method and <placeholder>Parameters</placeholder> is the parameter list for the method.</para>
          <para>
            <codeInline>$([MSBuild]::Method(Parameters))</codeInline>
          </para>
          <para>For example, to add together two properties that have numeric values, use the following code.</para>
          <para>
            <codeInline>$([MSBuild]::Add($(NumberOne), $(NumberTwo))</codeInline>
          </para>
          <para>Here is a list of MSBuild property functions:</para>
          <table xmlns:caps="http://schemas.microsoft.com/build/caps/2013/11">
            <thead>
              <tr>
                <TD>
                  <para>Function Signature</para>
                </TD>
                <TD>
                  <para>Description</para>
                </TD>
              </tr>
            </thead>
            <tbody>
              <tr>
                <TD>
                  <para>double Add(double a, double b)</para>
                </TD>
                <TD>
                  <para>Add two doubles.</para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>long Add(long a, long b)</para>
                </TD>
                <TD>
                  <para>Add two longs.</para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>double Subtract(double a, double b)</para>
                </TD>
                <TD>
                  <para>Subtract two doubles.</para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>long Subtract(long a, long b)</para>
                </TD>
                <TD>
                  <para>Subtract two longs.</para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>double Multiply(double a, double b)</para>
                </TD>
                <TD>
                  <para>Multiply two doubles.</para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>long Multiply(long a, long b)</para>
                </TD>
                <TD>
                  <para>Multiply two longs.</para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>double Divide(double a, double b)</para>
                </TD>
                <TD>
                  <para>Divide two doubles.</para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>long Divide(long a, long b)</para>
                </TD>
                <TD>
                  <para>Divide two longs.</para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>double Modulo(double a, double b)</para>
                </TD>
                <TD>
                  <para>Modulo two doubles.</para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>long Modulo(long a, long b)</para>
                </TD>
                <TD>
                  <para>Modulo two longs.</para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>string Escape(string unescaped)</para>
                </TD>
                <TD>
                  <para>Escape the string according to MSBuild escaping rules.</para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>string Unescape(string escaped)</para>
                </TD>
                <TD>
                  <para>Unescape the string according to MSBuild escaping rules.</para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>int BitwiseOr(int first, int second)</para>
                </TD>
                <TD>
                  <para>Perform a bitwise <languageKeyword>OR</languageKeyword> on the first and second (first | second).</para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>int BitwiseAnd(int first, int second)</para>
                </TD>
                <TD>
                  <para>Perform a bitwise <languageKeyword>AND</languageKeyword> on the first and second (first &amp; second).</para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>int BitwiseXor(int first, int second)</para>
                </TD>
                <TD>
                  <para>Perform a bitwise <languageKeyword>XOR</languageKeyword> on the first and second (first ^ second).</para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>int BitwiseNot(int first)</para>
                </TD>
                <TD>
                  <para>Perform a bitwise <languageKeyword>NOT</languageKeyword> (~first).</para>
                </TD>
              </tr>
            </tbody>
          </table>
        </content>
      </section>
    </sections>
  </section>
  <section address="BKMK_Nested">
    <title>Nested Property Functions</title>
    <content>
      <para>You can combine property functions to form more complex functions, as the following example shows.</para>
      <para>
        <codeInline>$([MSBuild]::BitwiseAnd(32,   $([System.IO.File]::GetAttributes(tempFile))))</codeInline>
      </para>
      <para>This example returns the value of the <codeEntityReference autoUpgrade="true">T:System.IO.FileAttributes</codeEntityReference> <languageKeyword>Archive</languageKeyword> bit (32 or 0) of the file given by the path <codeInline>tempFile</codeInline>. Notice that enumerated data values cannot appear by name within property functions. The numeric value (32) must be used instead.</para>
      <para>Metadata may also appear in nested property functions. For more information, see <link xlink:href="d35c085b-27b8-49d7-b6f8-8f2f3a0eec38">Batching</link>.</para>
    </content>
  </section>
  <section address="BKMK_DoesTaskHostExist">
    <title>MSBuild DoesTaskHostExist</title>
    <content>
      <para>The <languageKeyword>DoesTaskHostExist</languageKeyword> property function in MSBuild returns whether a task host is currently installed for the specified runtime and architecture values.</para>
      <para>This property function has the following syntax: </para>
      <code>$[MSBuild]::DoesTaskHostExist(string theRuntime, string theArchitecture)</code>
    </content>
  </section>
  <section address="BKMK_GetDirectoryNameOfFileAbove">
    <title>MSBuild GetDirectoryNameOfFileAbove</title>
    <content>
      <para>The MSBuild <codeInline>GetDirectoryNameOfFileAbove</codeInline> property function looks for a file in the directories above the current directory in the path.</para>
      <para>This property function has the following syntax:</para>
      <code>$[MSBuild]::GetDirectoryNameOfFileAbove(string ThePath, string TheFile)</code>
      <para>The following code is an example of this syntax.</para>
      <code>&lt;Import Project="$([MSBuild]::GetDirectoryNameOfFileAbove($(MSBuildThisFileDirectory), EnlistmentInfo.props))\EnlistmentInfo.props" Condition=" '$([MSBuild]::GetDirectoryNameOfFileAbove($(MSBuildThisFileDirectory), EnlistmentInfo.props))' != '' " /&gt;</code>
    </content>
  </section>
  <section address="BKMK_GetRegistryValue">
    <title>MSBuild GetRegistryValue</title>
    <content>
      <para>The MSBuild <codeInline>GetRegistryValue</codeInline> property function returns the value of a registry key. This function takes two arguments, the key name and the value name, and returns the value from the registry. If you don't specify a value name, the default value is returned.</para>
      <para>The following examples show how this function is used:</para>
      <code>$([MSBuild]::GetRegistryValue(`HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\10.0\Debugger`, ``))                                  // default value
$([MSBuild]::GetRegistryValue(`HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\10.0\Debugger`, `SymbolCacheDir`))
$([MSBuild]::GetRegistryValue(`HKEY_LOCAL_MACHINE\SOFTWARE\(SampleName)`, `(SampleValue)`))             // parens in name and value
</code>
    </content>
  </section>
  <section address="BKMK_GetRegistryValueFromView">
    <title>MSBuild GetRegistryValueFromView</title>
    <content>
      <para>The MSBuild <languageKeyword>GetRegistryValueFromView</languageKeyword> property function gets system registry data given the registry key, value, and one or more ordered registry views. The key and value are searched in each registry view in order until they are found.</para>
      <para>The syntax for this property function is:</para>
      <para>[MSBuild]::GetRegistryValueFromView(string keyName, string valueName, object defaultValue, params object[] views)</para>
      <para>The Windows 64-bit operating system maintains a HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node registry key that presents a HKEY_LOCAL_MACHINE\SOFTWARE registry view for 32-bit applications. </para>
      <para>By default, a 32-bit application running on WOW64 accesses the 32-bit registry view and a 64-bit application accesses the 64-bit registry view.</para>
      <para>The following registry views are available:</para>
      <table xmlns:caps="http://schemas.microsoft.com/build/caps/2013/11">
        <thead>
          <tr>
            <TD>
              <para>Registry View</para>
            </TD>
            <TD>
              <para>Definition</para>
            </TD>
          </tr>
        </thead>
        <tbody>
          <tr>
            <TD>
              <para>RegistryView.Registry32</para>
            </TD>
            <TD>
              <para>The 32-bit application registry view.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>RegistryView.Registry64</para>
            </TD>
            <TD>
              <para>The 64-bit application registry view.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>RegistryView.Default</para>
            </TD>
            <TD>
              <para>The registry view that matches the process that the application is running on.</para>
            </TD>
          </tr>
        </tbody>
      </table>
      <para>The following is an example.</para>
      <para>
        <codeInline>$([MSBuild]::GetRegistryValueFromView('HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Microsoft SDKs\Silverlight\v3.0\ReferenceAssemblies', 'SLRuntimeInstallPath', null, RegistryView.Registry64, RegistryView.Registry32))</codeInline>
      </para>
      <para>gets the SLRuntimeInstallPath data of the ReferenceAssemblies key, looking first in the 64-bit registry view and then in the 32-bit registry view.</para>
    </content>
  </section>
  <section address="BKMK_MakeRelative">
    <title>MSBuild MakeRelative</title>
    <content>
      <para>The MSBuild <languageKeyword>MakeRelative</languageKeyword> property function returns the relative path of the second path relative to first path. Each path can be a file or folder.</para>
      <para>This property function has the following syntax:</para>
      <code>$[MSBuild]::MakeRelative($(FileOrFolderPath1), $(FileOrFolderPath2))</code>
      <para>The following code is an example of this syntax.</para>
      <code language="xml">&lt;PropertyGroup&gt;
    &lt;Path1&gt;c:\users\&lt;/Path1&gt;
    &lt;Path2&gt;c:\users\username\&lt;/Path2&gt;
&lt;/PropertyGroup&gt;

&lt;Target Name = "Go"&gt;
    &lt;Message Text ="$([MSBuild]::MakeRelative($(Path1), $(Path2)))" /&gt;
    &lt;Message Text ="$([MSBuild]::MakeRelative($(Path2), $(Path1)))" /&gt;
&lt;/Target&gt;

&lt;!--
Output:
   username\
   ..\
--&gt;</code>
    </content>
  </section>
  <section address="BKMK_ValueOrDefault">
    <title>MSBuild ValueOrDefault</title>
    <content>
      <para>The MSBuild <languageKeyword>ValueOrDefault</languageKeyword> property function returns the first argument, unless it's null or empty. If the first argument is null or empty, the function returns the second argument.</para>
      <para>The following example shows how this function is used.</para>
      <code>&lt;Project ToolsVersion="4.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003"&gt;

    &lt;PropertyGroup&gt;
        &lt;Value1&gt;$([MSBuild]::ValueOrDefault(`$(UndefinedValue)`, `a`))&lt;/Value1&gt;
        &lt;Value2&gt;$([MSBuild]::ValueOrDefault(`b`, `$(Value1)`))&lt;/Value2&gt;
    &lt;/PropertyGroup&gt;

    &lt;Target Name="MyTarget"&gt;
        &lt;Message Text="Value1 = $(Value1)" /&gt;
        &lt;Message Text="Value2 = $(Value2)" /&gt;
    &lt;/Target&gt;
&lt;/Project&gt;

&lt;!--
Output: 
  Value1 = a
  Value2 = b
--&gt;</code>
    </content>
  </section>
  <relatedTopics>

</relatedTopics>
</developerConceptualDocument>