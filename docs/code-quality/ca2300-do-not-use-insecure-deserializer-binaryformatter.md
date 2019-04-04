---
title: "CA2300: Do not use insecure deserializer BinaryFormatter"
ms.date: 04/04/2019
ms.topic: reference
author: dotpaul
ms.author: paulming
manager: jillfra
dev_langs:
 - CSharp
 - VB
ms.workload:
  - "multiple"
---
# CA2300: Do not use insecure deserializer BinaryFormatter

|||
|-|-|
|TypeName|DoNotUseInsecureDeserializerBinaryFormatter|
|CheckId|CA2300|
|Category|Microsoft.Security|
|Breaking Change|Non Breaking|

## Cause

A <xref:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter?displayProperty=nameWithType> deserialization method was called or referenced.

## Rule description

Insecure deserializers are vulnerable to remote code execution attacks when deserializing untrusted data. If an attacker can control the serialized data, then the attacker could inject unexpected types to be deserialized with malicious side effects, such as executing commands on the underlying operating system or deleting files.

This rule finds <xref:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter?displayProperty=nameWithType> deserialization method calls or references. If you wish to allow deserialization when the <xref:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter.Binder> property is set to restrict types that can be deserialized, disable this rule and enable rules CA2301 and CA2302 instead.

## How to fix violations

Some mitigations include:
- If possible, use a secure serializer instead, and **don't allow an attacker to specify an arbitrary type to deserialize**. Some safer serializers include:
    - <xref:System.Runtime.Serialization.DataContractSerializer?displayProperty=nameWithType>
    - <xref:System.Runtime.Serialization.Json.DataContractJsonSerializer?displayProperty=nameWithType>
    - <xref:System.Web.Script.JavaScriptSerializer?displayProperty=nameWithType> - Never use <xref:System.Web.Script.SimpleTypeResolver?displayProperty=nameWithType>. If you must use a type resolver, you must restrict types that can be deserialized to an expected list.
    - <xref:System.Xml.Serialization.XmlSerializer?displayProperty=nameWithType>
    - NewtonSoft Json.NET - Use TypeNameHandling.None. If you must use another value for TypeNameHandling, then you must restrict types that can be deserialized to an expected list.
    - Protocol Buffers
- Make the serialized data tamper proof. After serialization, cryptographically sign the serialized data. Before deserializing, validate the cryptographic signature. You must protect the cryptographic key from being disclosed, and should design for key rotations.
- Restrict types that can be deserialized by implementing a custom <xref:System.Runtime.Serialization.SerializationBinder?displayProperty=nameWithType>, and setting the <xref:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter.Binder> property to an instance of your customer serialization binder. In the overridden <xref:System.Runtime.Serialization.Formatters.Binary.SerializationBinder.BindToType> method, you must throw exceptions unless the input type is expected in your object graph and known to be safe. Don't return null, because then the deserializer won't restrict types.
    - If you do this, you may want to disable this rule and enable rules CA2301 and CA2302 instead, to ensure that the Binder property is always set before deserializing.

## When to suppress warnings

It's safe to suppress a warning from this rule if you know that the input is trusted. Take into consideration that your application's trust boundary and data flows may change over time.

## Pseudo-code examples

### Violation

```csharp
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class ExampleClass
{
    public object MyDeserialize(byte[] bytes)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        return formatter.Deserialize(new MemoryStream(bytes));
    }
}
```

```vb
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class ExampleClass
    Public Function MyDeserialize(bytes As Byte()) As Object
        Dim formatter As BinaryFormatter = New BinaryFormatter()
        Return formatter.Deserialize(New MemoryStream(bytes))
    End Function
End Class
```
