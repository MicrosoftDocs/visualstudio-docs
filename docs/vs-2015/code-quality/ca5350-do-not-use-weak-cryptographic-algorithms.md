---
title: "CA5350: Do Not Use Weak Cryptographic Algorithms | Microsoft Docs"
ms.date: 11/15/2016
ms.technology: vs-ide-code-analysis
ms.topic: reference
ms.assetid: 4c51bb8a-fcfa-46aa-ab61-634be84c4a7a
caps.latest.revision: 11
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA5350: Do Not Use Weak Cryptographic Algorithms
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|Item|Value|
|-|-|
|TypeName|DoNotUseWeakCryptographicAlgorithms|
|CheckId|CA5350|
|Category|Microsoft.Cryptography|
|Breaking Change|Non Breaking|

> [!NOTE]
> This warning was last updated on November 2015.

## Cause
 Encryption algorithms such as <xref:System.Security.Cryptography.TripleDES> and hashing algorithms such as <xref:System.Security.Cryptography.SHA1> and <xref:System.Security.Cryptography.RIPEMD160> are considered to be weak.

 These cryptographic algorithms do not provide as much security assurance as more modern counterparts. Cryptographic hashing algorithms <xref:System.Security.Cryptography.SHA1> and <xref:System.Security.Cryptography.RIPEMD160> provide less collision resistance than more modern hashing algorithms. The encryption algorithm <xref:System.Security.Cryptography.TripleDES> provides fewer bits of security than more modern encryption  algorithms.

## Rule Description
 Weak encryption algorithms and hashing functions are used today for a number of reasons, but they should not be used to guarantee the confidentiality of the data they protect.

 The rule triggers when it finds 3DES, SHA1 or RIPEMD160 algorithms in the code and throws a warning to the user.

## How to Fix Violations
 Use cryptographically stronger options:

- For TripleDES encryption, use <xref:System.Security.Cryptography.Aes> encryption.

- For SHA1 or RIPEMD160 hashing functions, use ones in the [SHA-2](https://msdn.microsoft.com/library/windows/desktop/aa382459.aspx) family (e.g. <xref:System.Security.Cryptography.SHA512>, <xref:System.Security.Cryptography.SHA384>, <xref:System.Security.Cryptography.SHA256>).

## When to Suppress Warnings
 Suppress a warning from this rule when the level of protection needed for the data does not require a security guarantee.

## Pseudo-code Example
 As of the time of this writing, the following pseudo-code sample illustrates the pattern detected by this rule.

### SHA-1 Hashing Violation

```
using System.Security.Cryptography;
...
var hashAlg = SHA1.Create();

```

### Solution

```
using System.Security.Cryptography;
...
var hashAlg = SHA256.Create();

```

### RIPEMD160 <br /><br />Hashing Violation

```
using System.Security.Cryptography;
...
var hashAlg = RIPEMD160Managed.Create();

```

### Solution

```
using System.Security.Cryptography;
...
var hashAlg = SHA256.Create();

```

### TripleDES Encryption Violation

```
using System.Security.Cryptography;
...
using (TripleDES encAlg = TripleDES.Create())
{
  ...
}
```

### Solution

```
using System.Security.Cryptography;
...
using (AesManaged encAlg = new AesManaged())
{
  ...
}
```