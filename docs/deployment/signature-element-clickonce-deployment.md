---
title: "&lt;Signature&gt; Element (ClickOnce Deployment) | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "<Signature> element [ClickOnce deployment manifest]"
ms.assetid: c99b07ad-e8ba-43f2-b0d6-3745e7a7c8b3
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# &lt;Signature&gt; element (ClickOnce deployment)
Contains the necessary information to digitally sign this deployment manifest.

## Syntax

```xml

      <Signature> 
   XML signature information 
</Signature>
```

## Remarks
 Signing a deployment manifest using an envelope signature is optional, but recommended. For more information about signing XML files, see the World Wide Web Consortium Recommendation, "XML-Signature Syntax and Processing," described at [http://www.w3.org/TR/xmldsig-core/](https://www.w3.org/TR/xmldsig-core/).

 If you want to sign your manifest, hashes must be provided for all files. A manifest with files that are not hashed cannot be signed, because users cannot verify the contents of unhashed files.

## Example
 The following code example illustrates a `Signature` element in a deployment manifest used in a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] deployment.

```xml
<Signature xmlns="http://www.w3.org/2000/09/xmldsig#">
  <SignedInfo>
    <CanonicalizationMethod Algorithm=
           "http://www.w3.org/TR/2001/REC-xml-c14n-20010315" />
    <SignatureMethod Algorithm=
           "http://www.w3.org/2000/09/xmldsig#rsa-sha1" />
    <Reference URI="">
      <Transforms>
        <Transform Algorithm=
           "http://www.w3.org/2000/09/xmldsig#enveloped-signature" />
      </Transforms>
      <DigestMethod Algorithm="http://www.w3.org/2000/09/xmldsig#sha1" />
      <DigestValue>d2z5AE...</DigestValue>
    </Reference>
  </SignedInfo>
  <SignatureValue>
4PHj6SaopoLp...
  </SignatureValue>
  <KeyInfo>
    <X509Data>
      <X509Certificate>
MIIHnTCCBoWgAwIBAgIKJY9+nwAHAAB...
      </X509Certificate>
    </X509Data>
  </KeyInfo>
</Signature>
```

## See also
- [ClickOnce deployment manifest](../deployment/clickonce-deployment-manifest.md)