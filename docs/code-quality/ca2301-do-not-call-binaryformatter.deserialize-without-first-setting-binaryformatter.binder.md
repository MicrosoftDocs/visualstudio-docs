---
title: "CA2301: Do not call BinaryFormatter.Deserialize without first setting BinaryFormatter.Binder"
ms.date: 04/05/2019
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
# CA2301: Do not call BinaryFormatter.Deserialize without first setting BinaryFormatter.Binder

|||
|-|-|
|TypeName|DoNotCallBinaryFormatterDeserializeWithoutFirstSettingBinaryFormatterBinder|
|CheckId|CA2301|
|Category|Microsoft.Security|
|Breaking Change|Non Breaking|

## Cause

A <xref:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter?displayProperty=nameWithType> deserialization method was called or referenced without the <xref:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter.Binder> property set.

## Rule description

Insecure deserializers are vulnerable when deserializing untrusted data. An attacker could modify the serialized data to include unexpected types with malicious side effects. An attack against an insecure deserializer could, for example, execute commands on the underlying operating system, communicate over the network, or delete files.

This rule finds <xref:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter?displayProperty=nameWithType> deserialization method calls or references, when <xref:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter> doesn't have its <xref:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter.Binder> set. If you want to disallow any deserialization with <xref:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter> regardless of the <xref:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter.Binder> property, disable this rule and CA2302, and enable rule [CA2300](ca2300-do-not-use-insecure-deserializer-binaryformatter.md).

## How to fix violations

Some mitigations include:
- If possible, use a secure serializer instead, and **don't allow an attacker to specify an arbitrary type to deserialize**. Some safer serializers include:
  - <xref:System.Runtime.Serialization.DataContractSerializer?displayProperty=nameWithType>
  - <xref:System.Runtime.Serialization.Json.DataContractJsonSerializer?displayProperty=nameWithType>
  - <xref:System.Web.Script.Serialization.JavaScriptSerializer?displayProperty=nameWithType> - Never use <xref:System.Web.Script.Serialization.SimpleTypeResolver?displayProperty=nameWithType>. If you must use a type resolver, you must restrict deserialized types to an expected list.
  - <xref:System.Xml.Serialization.XmlSerializer?displayProperty=nameWithType>
  - NewtonSoft Json.NET - Use TypeNameHandling.None. If you must use another value for TypeNameHandling, then you must restrict deserialized types  to an expected list.
  - Protocol Buffers
- Make the serialized data tamper proof. After serialization, cryptographically sign the serialized data. Before deserializing, validate the cryptographic signature. You must protect the cryptographic key from being disclosed, and should design for key rotations.
- Restrict deserialized types. Implement a custom <xref:System.Runtime.Serialization.SerializationBinder?displayProperty=nameWithType>. Before deserializing with a <xref:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter>, set the <xref:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter.Binder> property to an instance of your custom <xref:System.Runtime.Serialization.SerializationBinder>. In the overridden <xref:System.Runtime.Serialization.SerializationBinder.BindToType%2A> method, if the type is unexpected then throw an exception.

## When to suppress warnings

- It's safe to suppress a warning from this rule if you know the input is trusted. Consider that your application's trust boundary and data flows may change over time.
- It's safe to suppress this warning if you've taken one of the precautions above.

## Pseudo-code examples

### Violation

```csharp
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class BookRecord
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PageCount { get; set; }
    public AisleLocation Location { get; set; }
}

[Serializable]
public class AisleLocation
{
    public char Aisle { get; set; }
    public byte Shelf { get; set; }
}

public class ExampleClass
{
    public BookRecord DeserializeBookRecord(byte[] bytes)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        using (MemoryStream ms = new MemoryStream(bytes))
        {
            return (BookRecord) formatter.Deserialize(ms);
        }
    }
}
```

### Solution
```csharp
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class BookRecordSerializationBinder : SerializationBinder
{
    public override Type BindToType(string assemblyName, string typeName)
    {
        // One way to discover expected types is through testing deserialization
        // of **valid** data and logging the types used.

        ////Console.WriteLine($"BindToType('{assemblyName}', '{typeName}')");

        if (typeName == "BookRecord" || typeName == "AisleLocation")
        {
            return null;
        }
        else
        {
            throw new ArgumentException("Unexpected type", "typeName");
        }
    }
}

[Serializable]
public class BookRecord
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PageCount { get; set; }
    public AisleLocation Location { get; set; }
}

[Serializable]
public class AisleLocation
{
    public char Aisle { get; set; }
    public byte Shelf { get; set; }
}

public class ExampleClass
{
    public BookRecord DeserializeBookRecord(byte[] bytes)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Binder = new BookRecordSerializationBinder();
        using (MemoryStream ms = new MemoryStream(bytes))
        {
            return (BookRecord) formatter.Deserialize(ms);
        }
    }
}
```
