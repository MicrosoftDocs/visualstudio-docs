---
title: "CA2312: Ensure NetDataContractSerializer.Binder is set before deserializing"
ms.date: 05/01/2019
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
# CA2312: Ensure NetDataContractSerializer.Binder is set before deserializing

|||
|-|-|
|TypeName|EnsureNetDataContractSerializerBinderIsSetBeforeDeserializing|
|CheckId|CA2312|
|Category|Microsoft.Security|
|Breaking Change|Non Breaking|

## Cause

A <xref:System.Runtime.Serialization.NetDataContractSerializer?displayProperty=nameWithType> deserialization method was called or referenced and the <xref:System.Runtime.Serialization.NetDataContractSerializer.Binder> property may be null.

## Rule description

[!INCLUDE[insecure-deserializers-description](includes/insecure-deserializers-description-md.md)]

This rule finds <xref:System.Runtime.Serialization.NetDataContractSerializer?displayProperty=nameWithType> deserialization method calls or references when the <xref:System.Runtime.Serialization.NetDataContractSerializer.Binder> might be null. If you want to disallow any deserialization with <xref:System.Runtime.Serialization.NetDataContractSerializer> regardless of the <xref:System.Runtime.Serialization.NetDataContractSerializer.Binder> property, disable this rule and [CA2311](ca2311-do-not-deserialize-without-first-setting-netdatacontractserializer-binder.md), and enable rule [CA2310](ca2310-do-not-use-insecure-deserializer-netdatacontractserializer.md).

## How to fix violations

- If possible, use a secure serializer instead, and **don't allow an attacker to specify an arbitrary type to deserialize**. Some safer serializers include:
  - <xref:System.Runtime.Serialization.DataContractSerializer?displayProperty=nameWithType>
  - <xref:System.Runtime.Serialization.Json.DataContractJsonSerializer?displayProperty=nameWithType>
  - <xref:System.Web.Script.Serialization.JavaScriptSerializer?displayProperty=nameWithType> - Never use <xref:System.Web.Script.Serialization.SimpleTypeResolver?displayProperty=nameWithType>. If you must use a type resolver, restrict deserialized types to an expected list.
  - <xref:System.Xml.Serialization.XmlSerializer?displayProperty=nameWithType>
  - Newtonsoft Json.NET - Use TypeNameHandling.None. If you must use another value for TypeNameHandling, restrict deserialized types to an expected list with a custom ISerializationBinder.
  - Protocol Buffers
- Make the serialized data tamper-proof. After serialization, cryptographically sign the serialized data. Before deserialization, validate the cryptographic signature. Protect the cryptographic key from being disclosed, and design for key rotations.
- Restrict deserialized types. Implement a custom <xref:System.Runtime.Serialization.SerializationBinder?displayProperty=nameWithType>. Before deserializing with <xref:System.Runtime.Serialization.NetDataContractSerializer>, set the <xref:System.Runtime.Serialization.NetDataContractSerializer.Binder> property to an instance of your custom <xref:System.Runtime.Serialization.SerializationBinder>. In the overridden <xref:System.Runtime.Serialization.SerializationBinder.BindToType%2A> method, if the type is unexpected then throw an exception.
  - Ensure that all code paths have the <xref:System.Runtime.Serialization.NetDataContractSerializer.Binder> property set.

## When to suppress warnings

[!INCLUDE[insecure-deserializers-common-safe-to-suppress](includes/insecure-deserializers-common-safe-to-suppress-md.md)]

## Pseudo-code examples

### Violation

```csharp
using System;
using System.IO;
using System.Runtime.Serialization;

[DataContract]
public class BookRecord
{
    [DataMember]
    public string Title { get; set; }

    [DataMember]
    public string Author { get; set; }

    [DataMember]
    public int PageCount { get; set; }

    [DataMember]
    public AisleLocation Location { get; set; }
}

[DataContract]
public class AisleLocation
{
    [DataMember]
    public char Aisle { get; set; }

    [DataMember]
    public byte Shelf { get; set; }
}

public class ExampleClass
{
    public NetDataContractSerializer Serializer { get; set; }

    public BookRecord DeserializeBookRecord(byte[] bytes)
    {
        using (MemoryStream ms = new MemoryStream(bytes))
        {
            return (BookRecord) this.Serializer.Deserialize(ms);
        }
    }
}
```

```vb
Imports System
Imports System.IO
Imports System.Runtime.Serialization

<DataContract()>
Public Class BookRecord
    <DataMember()>
    Public Property Title As String

    <DataMember()>
    Public Property Author As String

    <DataMember()>
    Public Property Location As AisleLocation
End Class

<DataContract()>
Public Class AisleLocation
    <DataMember()>
    Public Property Aisle As Char

    <DataMember()>
    Public Property Shelf As Byte
End Class

Public Class ExampleClass
    Public Property Serializer As NetDataContractSerializer

    Public Function DeserializeBookRecord(bytes As Byte()) As BookRecord
        Using ms As MemoryStream = New MemoryStream(bytes)
            Return CType(Me.Serializer.Deserialize(ms), BookRecord)
        End Using
    End Function
End Class
```

### Solution

```csharp
using System;
using System.IO;
using System.Runtime.Serialization;

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
            throw new ArgumentException("Unexpected type", nameof(typeName));
        }
    }
}

[DataContract]
public class BookRecord
{
    [DataMember]
    public string Title { get; set; }

    [DataMember]
    public string Author { get; set; }

    [DataMember]
    public int PageCount { get; set; }

    [DataMember]
    public AisleLocation Location { get; set; }
}

[DataContract]
public class AisleLocation
{
    [DataMember]
    public char Aisle { get; set; }

    [DataMember]
    public byte Shelf { get; set; }
}

public class ExampleClass
{
    public BookRecord DeserializeBookRecord(byte[] bytes)
    {
        NetDataContractSerializer serializer = new NetDataContractSerializer();
        serializer.Binder = new BookRecordSerializationBinder();
        using (MemoryStream ms = new MemoryStream(bytes))
        {
            return (BookRecord) serializer.Deserialize(ms);
        }
    }
}
```

```vb
Imports System
Imports System.IO
Imports System.Runtime.Serialization

Public Class BookRecordSerializationBinder
    Inherits SerializationBinder

    Public Overrides Function BindToType(assemblyName As String, typeName As String) As Type
        ' One way to discover expected types is through testing deserialization
        ' of **valid** data and logging the types used.

        'Console.WriteLine($"BindToType('{assemblyName}', '{typeName}')")

        If typeName = "BinaryFormatterVB.BookRecord" Or typeName = "BinaryFormatterVB.AisleLocation" Then
            Return Nothing
        Else
            Throw New ArgumentException("Unexpected type", NameOf(typeName))
        End If
    End Function
End Class

<DataContract()>
Public Class BookRecord
    <DataMember()>
    Public Property Title As String

    <DataMember()>
    Public Property Author As String

    <DataMember()>
    Public Property Location As AisleLocation
End Class

<DataContract()>
Public Class AisleLocation
    <DataMember()>
    Public Property Aisle As Char

    <DataMember()>
    Public Property Shelf As Byte
End Class

Public Class ExampleClass
    Public Function DeserializeBookRecord(bytes As Byte()) As BookRecord
        Dim serializer As NetDataContractSerializer = New NetDataContractSerializer()
        serializer.Binder = New BookRecordSerializationBinder()
        Using ms As MemoryStream = New MemoryStream(bytes)
            Return CType(serializer.Deserialize(ms), BookRecord)
        End Using
    End Function
End Class
```

## Related rules

[CA2310: Do not use insecure deserializer NetDataContractSerializer](ca2310-do-not-use-insecure-deserializer-netdatacontractserializer.md)

[CA2311: Do not deserialize without first setting NetDataContractSerializer.Binder](ca2311-do-not-deserialize-without-first-setting-netdatacontractserializer-binder.md)
