---
title: "CA3008: Review code for XPath injection vulnerabilities"
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
# CA3008: Review code for XPath injection vulnerabilities

|||
|-|-|
|TypeName|ReviewCodeForXPathInjectionVulnerabilities|
|CheckId|CA3008|
|Category|Microsoft.Security|
|Breaking Change|Non Breaking|

## Cause

Potentially untrusted HTTP request input reaches an XPath query.

## Rule description

When working with untrusted input, be mindful of XPath injection attacks. Constructing XPath queries using untrusted input may allow an attacker to maliciously manipulate the query to return an unintended result, and possibly disclose the contents of the queried XML. 

This rule attempts to find input from HTTP requests reaching an XPath expression.

> [!NOTE]
> This rule can't track data across assemblies. For example, if one assembly reads the HTTP request input and then passes it to another assembly that performs an XPath query, this rule won't produce a warning.

> [!NOTE]
> There is a configurable limit to how deep this rule will analyze data flow across method calls. See [Analyzer Configuration](https://github.com/dotnet/roslyn-analyzers/blob/master/docs/Analyzer%20Configuration.md#dataflow-analysis) for how to configure the limit in `.editorconfig` files.

## How to fix violations

Some approaches to fixing XPath injection vulnerabilities include:

1. Do not construct XPath queries from user input.
1. Validate that the input only contains a safe set of characters.
1. Escape quotation marks.

## When to suppress warnings

If you know the input has been validated to be safe.

## Pseudo-code examples

### Violation

```csharp
using System;
using System.Xml.XPath;

public partial class WebForm : System.Web.UI.Page
{
    public XPathNavigator AuthorizedOperations { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        string operation = Request.Form["operation"];

        // If an attacker uses this for input:
        //     ' or 'a' = 'a
        // Then the XPath query will be:
        //     authorizedOperation[@username = 'anonymous' and @operationName = '' or 'a' = 'a']
        // and it will return any authorizedOperation node.
        XPathNavigator node = AuthorizedOperations.SelectSingleNode(
            "//authorizedOperation[@username = 'anonymous' and @operationName = '" + operation + "']");
    }
}
```

```vb
Imports System
Imports System.Xml.XPath

Partial Public Class WebForm
    Inherits System.Web.UI.Page

    Public Property AuthorizedOperations As XPathNavigator

    Protected Sub Page_Load(sender As Object, e As EventArgs)
        Dim operation As String = Me.Request.Form("operation")
        
        ' If an attacker uses this for input:
        '     ' or 'a' = 'a
        ' Then the XPath query will be:
        '      authorizedOperation[@username = 'anonymous' and @operationName = '' or 'a' = 'a']
        ' and it will return any authorizedOperation node.
        Dim node As XPathNavigator = AuthorizedOperations.SelectSingleNode( _
            "//authorizedOperation[@username = 'anonymous' and @operationName = '" + operation + "']")
    End Sub
End Class
```
