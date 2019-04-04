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

Insecure deserializers are vulnerable when deserializing untrusted data. An attacker could modify the serialized data to include unexpected types with malicious side effects. An attack against an insecure deserializer could, for example, execute commands on the underlying operating system, communicate over the network, or delete files.

This rule finds <xref:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter?displayProperty=nameWithType> deserialization method calls or references. If you wish to allow deserialization when the <xref:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter.Binder> property is set to restrict types that can be deserialized, disable this rule and enable rules CA2301 and CA2302 instead.

## How to fix violations

Some mitigations include:
- If possible, use a secure serializer instead, and **don't allow an attacker to specify an arbitrary type to deserialize**. Some safer serializers include:
  - <xref:System.Runtime.Serialization.DataContractSerializer?displayProperty=nameWithType>
  - <xref:System.Runtime.Serialization.Json.DataContractJsonSerializer?displayProperty=nameWithType>
  - <xref:System.Web.Script.Serialization.JavaScriptSerializer?displayProperty=nameWithType> - Never use <xref:System.Web.Script.Serialization.SimpleTypeResolver?displayProperty=nameWithType>. If you must use a type resolver, you must restrict types that can be deserialized to an expected list.
  - <xref:System.Xml.Serialization.XmlSerializer?displayProperty=nameWithType>
  - NewtonSoft Json.NET - Use TypeNameHandling.None. If you must use another value for TypeNameHandling, then you must restrict types that can be deserialized to an expected list.
  - Protocol Buffers
- Make the serialized data tamper proof. After serialization, cryptographically sign the serialized data. Before deserializing, validate the cryptographic signature. You must protect the cryptographic key from being disclosed, and should design for key rotations.
- Restrict deserialized types. Implement a custom <xref:System.Runtime.Serialization.SerializationBinder?displayProperty=nameWithType>. Before deserializing with a <xref:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter>, set the <xref:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter.Binder> property to an instance of your custom <xref:System.Runtime.Serialization.SerializationBinder>. In the overridden <xref:System.Runtime.Serialization.Binary.SerializationBinder.BindToType> method, throw exceptions, unless the input type is expected in your object graph and known to be safe. Don't return null, because then the deserializer won't restrict types.
 - If you restrict deserialized types, you may want to disable this rule and enable rules CA2301 and CA2302, to ensure that the <xref:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter.Binder> property is always set before deserializing.

## When to suppress warnings

- It's safe to suppress a warning from this rule if you know the input is trusted. Consider that your application's trust boundary and data flows may change over time.
- It's safe to suppress this warning if you've taken one of the precautions above.

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
