---
title: "CA3006: Review code for process command injection vulnerabilities"
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
# CA3006: Review code for process command injection vulnerabilities

|||
|-|-|
|TypeName|ReviewCodeForProcessCommandInjectionVulnerabilities|
|CheckId|CA3006|
|Category|Microsoft.Security|
|Breaking Change|Non Breaking|

## Cause

Potentially untrusted HTTP request input reaches a process command.

## Rule description

When working with untrusted input, be mindful of command injection attacks. A command injection attack can execute malicious commands on the underlying operating system, compromising the security and integrity of your server.

This rule attempts to find input from HTTP requests reaching a process command.

> [!NOTE]
> This rule can't track data across assemblies. For example, if one assembly reads the HTTP request input and then passes it to another assembly that starts a process, this rule won't produce a warning.

> [!NOTE]
> There is a configurable limit to how deep this rule will analyze data flow across method calls. See [Analyzer Configuration](https://github.com/dotnet/roslyn-analyzers/blob/master/docs/Analyzer%20Configuration.md#dataflow-analysis) for how to configure the limit in `.editorconfig` files.

## How to fix violations

- If possible, avoid starting processes based on user input.
- Validate input against a known safe set of characters and length.

## When to suppress warnings

If you know the input has been validated or escaped to be safe, it's safe to suppress this warning.

## Pseudo-code examples

### Violation

```csharp
using System;
using System.Diagnostics;

public partial class WebForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string input = Request.Form["in"];
        Process p = Process.Start(input);
    }
}
```

```vb
Imports System
Imports System.Diagnostics

Partial Public Class WebForm
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, eventArgs as EventArgs)
        Dim input As String = Me.Request.Form("in")
        Dim p As Process = Process.Start(input)
    End Sub
End Class
```
