---
title: "CA5351 Do Not Use Broken Cryptographic Algorithms | Microsoft Docs"
ms.date: 11/15/2016
ms.technology: vs-ide-code-analysis
ms.topic: reference
ms.assetid: 483f51b3-e186-4433-b48e-5ca24a9a9c94
caps.latest.revision: 12
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA5351 Do Not Use Broken Cryptographic Algorithms
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|DoNotUseBrokenCryptographicAlgorithms|
|CheckId|CA5351|
|Category|Microsoft.Cryptography|
|Breaking Change|Non Breaking|

> [!NOTE]
> This warning was last updated on November 2015.

## Cause
 Hashing functions such as <xref:System.Security.Cryptography.MD5> and encryption algorithms such as <xref:System.Security.Cryptography.DES> and <xref:System.Security.Cryptography.RC2> can expose significant risk and may result in the exposure of sensitive information through trivial attack techniques, such as brute force attacks and hash collisions.

 The cryptographic algorithms list below are subject to known cryptographic attacks. The cryptographic hash algorithm <xref:System.Security.Cryptography.MD5> is subject to hash collision attacks.  Depending on the usage, a hash collision may lead to impersonation, tampering, or other kinds of attacks on systems that rely on the unique cryptographic output of a hashing function. The encryption algorithms <xref:System.Security.Cryptography.DES> and <xref:System.Security.Cryptography.RC2> are subject to cryptographic attacks that may result in unintended disclosure of encrypted data.

## Rule Description
 Broken cryptographic algorithms are not  considered secure and their use should be discouraged. The MD5 hash algorithm is susceptible to known collision attacks, though the specific vulnerability will vary based on the context of use.  Hashing algorithms used to ensure data integrity (e.g., file signature or digital certificate) are particularly vulnerable.  In this context, attackers could generate two separate pieces of data, such that benign data can be substituted with malicious data, without changing the hash value or invalidating an associated digital signature.

 For encryption algorithms:

- <xref:System.Security.Cryptography.DES> encryption contains a small key size, which could be brute-forced in less than a day.

- <xref:System.Security.Cryptography.RC2> encryption is susceptible to a related-key attack, where the attacker finds mathematical relationships between all key values.

  This rule triggers when it finds any of the above cryptographic functions in source code and throws a warning to the user.

## How to Fix Violations
 Use cryptographically stronger options:

- For MD5, use hashes in the [SHA-2](https://msdn.microsoft.com/library/windows/desktop/aa382459.aspx) family (e.g. <xref:System.Security.Cryptography.SHA512>, <xref:System.Security.Cryptography.SHA384>, <xref:System.Security.Cryptography.SHA256>).

- For DES and RC2, use <xref:System.Security.Cryptography.Aes> encryption.

## When to Suppress Warnings
 Do not suppress a warning from this rule, unless it's been reviewed by a cryptographic expert.

## Pseudo-code Example
 The following pseudo-code sample illustrates the pattern detected by this rule and possible alternatives.

### MD5 Hashing Violation

```
using System.Security.Cryptography;
...
var hashAlg = MD5.Create();

```

### Solution

```
using System.Security.Cryptography;
...
var hashAlg = SHA256.Create();

```

### RC2 Encryption Violation

```
using System.Security.Cryptography;
...
RC2 encAlg = RC2.Create();

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

### DES <br /><br />Encryption Violation

```
using System.Security.Cryptography;
...
DES encAlg = DES.Create();

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