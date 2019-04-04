---
title: "CA3003: Review code for file path injection vulnerabilities"
ms.date: 03/25/2019
ms.topic: reference
author: dotpaul
ms.author: paulming
manager: jillfra
dev_langs:
 - "CSharp"
 - "VisualBasic"
ms.workload:
  - "multiple"
---
# CA3003: Review code for file path injection vulnerabilities

|||
|-|-|
|TypeName|ReviewCodeForFilePathInjectionVulnerabilities|
|CheckId|CA3003|
|Category|Microsoft.Security|
|Breaking Change|Non Breaking|

## Cause

Potentially untrusted HTTP request input reaches the path of a file operation.

## Rule description

When working with untrusted input from web requests, be mindful of using user-controlled input when specifying paths to files. An attacker may be able to read an unintended file, resulting in information disclosure of sensitive data. Or, an attacker may be able to write to an unintended file, resulting in unauthorized modification of sensitive data or compromising the server's security. A common attacker technique is [Path Traversal](https://www.owasp.org/index.php/Path_Traversal) to access files outside of the intended directory.

This rule attempts to find input from HTTP requests reaching a path in a file operation.

> [!NOTE]
> This rule can't track data across assemblies. For example, if one assembly reads the HTTP request input and then passes it to another assembly that writes to a file, this rule won't produce a warning.

> [!NOTE]
> There is a configurable limit to how deep this rule will analyze data flow across method calls. See [Analyzer Configuration](https://github.com/dotnet/roslyn-analyzers/blob/master/docs/Analyzer%20Configuration.md#dataflow-analysis) for how to configure the limit in `.editorconfig` files.

## How to fix violations

- If possible, limit file paths based on user input to an explicitly known safe list.  For example, if your application only needs to access "red.txt", "green.txt", or "blue.txt", only allow those values.
- Check for untrusted filenames and validate that the name is well formed.
- Use full path names when specifying paths.
- Avoid potentially dangerous constructs such as path environment variables.
- Only accept long filenames and validate long name if user submits short names.
- Restrict end user input to valid characters.
- Reject names where MAX_PATH length is exceeded.
- Handle filenames literally, without interpretation.
- Determine if the filename represents a file or a device.

## When to suppress warnings

If you've validated input as described in the previous section, it's okay to suppress this warning.

## Pseudo-code examples

### Violation

```csharp
using System;
using System.IO;

public partial class WebForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string userInput = Request.Params["UserInput"];
        // Assume the following directory structure:
        //   wwwroot\currentWebDirectory\user1.txt
        //   wwwroot\currentWebDirectory\user2.txt
        //   wwwroot\secret\allsecrets.txt
        // There is nothing wrong if the user inputs:
        //   user1.txt
        // However, if the user input is: 
        //   ..\secret\allsecrets.txt
        // Then an attacker can now see all the secrets.

        // Avoid this:
        using (File.Open(userInput, FileMode.Open))
        {
            // Read a file with the name supplied by user
            // Input through request's query string and display 
            // The content to the webpage. 
        }
    }
}
```

```vb
Imports System
Imports System.IO

Partial Public Class WebForm 
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs)
        Dim userInput As String = Me.Request.Params("UserInput")
        ' Assume the following directory structure:
        '   wwwroot\currentWebDirectory\user1.txt
        '   wwwroot\currentWebDirectory\user2.txt
        '   wwwroot\secret\allsecrets.txt
        ' There is nothing wrong if the user inputs:
        '   user1.txt
        ' However, if the user input is: 
        '   ..\secret\allsecrets.txt
        ' Then an attacker can now see all the secrets.

        ' Avoid this:
        Using File.Open(userInput, FileMode.Open)
            ' Read a file with the name supplied by user
            ' Input through request's query string and display 
            ' The content to the webpage. 
        End Using
    End Sub
End Class
```
