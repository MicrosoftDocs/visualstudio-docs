---
title: "CA2100: Review SQL queries for security vulnerabilities | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "Review SQL queries for security vulnerabilities"
  - "ReviewSqlQueriesForSecurityVulnerabilities"
  - "CA2100"
helpviewer_keywords:
  - "CA2100"
  - "ReviewSqlQueriesForSecurityVulnerabilities"
ms.assetid: 79670604-c02a-448d-9c0e-7ea0120bc5fe
caps.latest.revision: 26
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2100: Review SQL queries for security vulnerabilities
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|ReviewSqlQueriesForSecurityVulnerabilities|
|CheckId|CA2100|
|Category|Microsoft.Security|
|Breaking Change|Non-breaking|

## Cause
 A method sets the <xref:System.Data.IDbCommand.CommandText%2A?displayProperty=fullName> property by using a string that is built from a string argument to the method.

## Rule Description
 This rule assumes that the string argument contains user input. A SQL command string that is built from user input is vulnerable to SQL injection attacks. In a SQL injection attack, a malicious user supplies input that alters the design of a query in an attempt to damage or gain unauthorized access to the underlying database. Typical techniques include injection of a single quotation mark or apostrophe, which is the SQL literal string delimiter; two dashes, which signifies a SQL comment; and a semicolon, which indicates that a new command follows. If user input must be part of the query, use one of the following, listed in order of effectiveness, to reduce the risk of attack.

- Use a stored procedure.

- Use a parameterized command string.

- Validate the user input for both type and content before you build the command string.

  The following [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] types implement the <xref:System.Data.IDbCommand.CommandText%2A> property or provide constructors that set the property by using a string argument.

- <xref:System.Data.Odbc.OdbcCommand?displayProperty=fullName> and <xref:System.Data.Odbc.OdbcDataAdapter?displayProperty=fullName>

- <xref:System.Data.OleDb.OleDbCommand?displayProperty=fullName> and <xref:System.Data.OleDb.OleDbDataAdapter?displayProperty=fullName>

- <xref:System.Data.OracleClient.OracleCommand?displayProperty=fullName> and <xref:System.Data.OracleClient.OracleDataAdapter?displayProperty=fullName>

- [System.Data.SqlServerCe.SqlCeCommand](<!-- TODO: review code entity reference <xref:assetId:///System.Data.SqlServerCe.SqlCeCommand?qualifyHint=False&amp;autoUpgrade=True>  -->) and  [System.Data.SqlServerCe.SqlCeDataAdapter](<!-- TODO: review code entity reference <xref:assetId:///System.Data.SqlServerCe.SqlCeDataAdapter?qualifyHint=False&amp;autoUpgrade=True>  -->)

- <xref:System.Data.SqlClient.SqlCommand?displayProperty=fullName> and <xref:System.Data.SqlClient.SqlDataAdapter?displayProperty=fullName>

  Notice that this rule is violated when the ToString method of a type is used explicitly or implicitly to construct the query string. The following is an example.

```
int x = 10;
string query = "SELECT TOP " + x.ToString() + " FROM Table";
```

 The rule is violated because a malicious user can override the ToString() method.

 The rule also is violated when ToString is used implicitly.

```
int x = 10;
string query = String.Format("SELECT TOP {0} FROM Table", x);
```

## How to Fix Violations
 To fix a violation of this rule, use a parameterized query.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule if the command text does not contain any user input.

## Example
 The following example shows a method, `UnsafeQuery`, that violates the rule and a method, `SaferQuery`, that satisfies the rule by using a parameterized command string.

 [!code-cpp[FxCop.Security.ReviewSqlQueries#1](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Security.ReviewSqlQueries/cpp/FxCop.Security.ReviewSqlQueries.cpp#1)]
 [!code-csharp[FxCop.Security.ReviewSqlQueries#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Security.ReviewSqlQueries/cs/FxCop.Security.ReviewSqlQueries.cs#1)]
 [!code-vb[FxCop.Security.ReviewSqlQueries#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Security.ReviewSqlQueries/vb/FxCop.Security.ReviewSqlQueries.vb#1)]

## See Also
 [Security Overview](https://msdn.microsoft.com/library/33e09965-61d5-48cc-9e8c-3b047cc4f194)
