---
title: "CA3011: Review code for DLL injection vulnerabilities"
ms.date: 04/03/2019
ms.topic: reference
author: dotpaul
ms.author: paulming
manager: jillfra
dev_langs:
 - "CSharp"
 - VB
ms.workload:
 - "multiple"
---
# CA3011: Review code for DLL injection vulnerabilities

|||
|-|-|
|TypeName|ReviewCodeForDllInjectionVulnerabilities|
|CheckId|CA3011|
|Category|Microsoft.Security|
|Breaking Change|Non Breaking|

## Cause

Potentially untrusted HTTP request input reaches a method that loads an assembly.

## Rule description

When working with untrusted input, be mindful of loading untrusted code. If your web application loads untrusted code, an attacker may be able to inject malicous DLLs into your process and execute malicious code.

This rule attempts to find input from an HTTP request that reaches a method that loads an assembly.

> [!NOTE]
> This rule can't track data across assemblies. For example, if one assembly reads the HTTP request input and then passes it to another assembly that loads an assembly, this rule won't produce a warning.

> [!NOTE]
> There is a configurable limit to how deep this rule will analyze data flow across method calls. See [Analyzer Configuration](https://github.com/dotnet/roslyn-analyzers/blob/master/docs/Analyzer%20Configuration.md#dataflow-analysis) for how to configure the limit in `.editorconfig` files.

## How to fix violations

Don't load untrusted DLLs from user input.

## When to suppress warnings

Don't suppress warnings from this rule.

## Pseudo-code examples

### Violation

```csharp
using System;
using System.Reflection;

public partial class WebForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string input = Request.Form["in"];
        byte[] rawAssembly = Convert.FromBase64String(input);
        Assembly.Load(rawAssembly);
    }
}
```

```vb
Imports System
Imports System.Reflection

Public Partial Class WebForm
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs)
        Dim input As String = Request.Form("in")
        Dim rawAssembly As Byte() = Convert.FromBase64String(input)
        Assembly.Load(rawAssembly)
    End Sub
End Class
```
