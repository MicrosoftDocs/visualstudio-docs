---
title: "CA5350: Do Not Use Weak Cryptographic Algorithms"
ms.custom: na
ms.date: 10/03/2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 4c51bb8a-fcfa-46aa-ab61-634be84c4a7a
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# CA5350: Do Not Use Weak Cryptographic Algorithms
|||  
|-|-|  
|TypeName|DoNotUseWeakCryptographicAlgorithms|  
|CheckId|CA5350|  
|Category|Microsoft.Cryptography|  
|Breaking Change|Non Breaking|  
  
> [!NOTE]
>  This warning was last updated on November 2015.  
  
## Cause  
 Encryption algorithms such as <xref:System.Security.Cryptography.TripleDES?qualifyHint=False> and hashing algorithms such as <xref:System.Security.Cryptography.SHA1?qualifyHint=False> and <xref:System.Security.Cryptography.RIPEMD160?qualifyHint=False> are considered to be weak.  
  
 These cryptographic algorithms do not provide as much security assurance as more modern counterparts. Cryptographic hashing algorithms <xref:System.Security.Cryptography.SHA1?qualifyHint=False> and <xref:System.Security.Cryptography.RIPEMD160?qualifyHint=False> provide less collision resistance than more modern hashing algorithms. The encryption algorithm <xref:System.Security.Cryptography.TripleDES?qualifyHint=False> provides fewer bits of security than more modern encryption  algorithms.  
  
## Rule Description  
 Weak encryption algorithms and hashing functions are used today for a number of reasons, but they should not be used to guarantee the confidentiality of the data they protect.  
  
 The rule triggers when it finds 3DES, SHA1 or RIPEMD160 algorithms in the code and throws a warning to the user.  
  
## How to Fix Violations  
 Use cryptographically stronger options:  
  
-   For TripleDES encryption, use <xref:System.Security.Cryptography.Aes?qualifyHint=False> encryption.  
  
-   For SHA1 or RIPEMD160 hashing functions, use ones in the [SHA-2](https://msdn.microsoft.com/en-us/library/windows/desktop/aa382459.aspx) family (e.g. <xref:System.Security.Cryptography.SHA512?qualifyHint=False>, <xref:System.Security.Cryptography.SHA384?qualifyHint=False>, <xref:System.Security.Cryptography.SHA256?qualifyHint=False>).  
  
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