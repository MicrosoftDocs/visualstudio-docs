---
title: "CA3012: Review code for regex injection vulnerabilities"
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
# CA3012: Review code for regex injection vulnerabilities

|||
|-|-|
|TypeName|ReviewCodeForRegexInjectionVulnerabilities|
|CheckId|CA3012|
|Category|Microsoft.Security|
|Breaking change|Non-breaking|

## Cause

Potentially untrusted HTTP request input reaches a regular expression.

## Rule description

When working with untrusted input, be mindful of regex injection attacks. An attacker can use regex injection to maliciously modify a regular expression, to make the regex match unintended results, or to make the regex consume excessive CPU resulting in a Denial of Service attack.

This rule attempts to find input from HTTP requests reaching a regular expression.

> [!NOTE]
> This rule can't track data across assemblies. For example, if one assembly reads the HTTP request input and then passes it to another assembly that creates a regular expression, this rule won't produce a warning.

> [!NOTE]
> There is a configurable limit to how deep this rule will analyze data flow across method calls. See [Analyzer Configuration](https://github.com/dotnet/roslyn-analyzers/blob/master/docs/Analyzer%20Configuration.md#dataflow-analysis) for how to configure the limit in an EditorConfig file.

## How to fix violations

Some mitigations against regex injections include:

- Always use a [match timeout](/dotnet/standard/base-types/best-practices#use-time-out-values) when using regular expressions.
- Avoid using regular expressions based on user input.
- Escape special characters from user input by calling <xref:System.Text.RegularExpressions.Regex.Escape%2A?displayProperty=fullName> or another method.
- Allow only non-special characters from user input.

## When to suppress warnings

If you know you're using a [match timeout](/dotnet/standard/base-types/best-practices#use-time-out-values) and the user input is free of special characters, it's okay to suppress this warning.

## Pseudo-code examples

### Violation

```csharp
using System;
using System.Text.RegularExpressions;

public partial class WebForm : System.Web.UI.Page
{
    public string SearchableText { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        string findTerm = Request.Form["findTerm"];
        Match m = Regex.Match(SearchableText, "^term=" + findTerm);
    }
}
```

```vb
Imports System
Imports System.Text.RegularExpressions

Public Partial Class WebForm
    Inherits System.Web.UI.Page

    Public Property SearchableText As String

    Protected Sub Page_Load(sender As Object, e As EventArgs)
        Dim findTerm As String = Request.Form("findTerm")
        Dim m As Match = Regex.Match(SearchableText, "^term=" + findTerm)
    End Sub
End Class
```
