---
title: "CA2321: Do not deserialize with JavaScriptSerializer using a SimpleTypeResolver"
ms.date: 05/08/2019
ms.topic: reference
author: dotpaul
ms.author: paulming
manager: jillfra
dev_langs:
 - CSharp
 - VB
ms.workload:
  - "multiple"
f1_keywords:
  - "CA2321"
  - "DoNotCallBinaryFormatterDeserializeWithoutFirstSettingBinaryFormatterBinder"
---
# CA2321: Do not deserialize with JavaScriptSerializer using a SimpleTypeResolver

|||
|-|-|
|TypeName|DoNotDeserializeWithJavaScriptSerializerUsingASimpleTypeResolver|
|CheckId|CA2321|
|Category|Microsoft.Security|
|Breaking Change|Non Breaking|

## Cause

A <xref:System.Web.Script.Serialization.JavaScriptSerializer?displayProperty=nameWithType> deserialization method was called or referenced after initializing with a <xref:System.Web.Script.Serialization.SimpleTypeResolver?displayProperty=nameWithType>.

## Rule description

[!INCLUDE[insecure-deserializers-description](includes/insecure-deserializers-description-md.md)]

This rule finds <xref:System.Web.Script.Serialization.JavaScriptSerializer?displayProperty=nameWithType> deserialization method calls or references, after initializing the <xref:System.Web.Script.Serialization.JavaScriptSerializer> with a <xref:System.Web.Script.Serialization.SimpleTypeResolver?displayProperty=nameWithType>.

## How to fix violations

- Don't initialize <xref:System.Web.Script.Serialization.JavaScriptTypeResolver?displayPropertyName=nameWithType> with a <xref:System.Web.Script.Serialization.SimpleTypeResolver?displayProperty=nameWithType>.
- If your code needs to read data serialized using a <xref:System.Web.Script.Serialization.SimpleTypeResolver>, restrict deserialized types to an expected list by implementing a custom <xref:System.Web.Script.Serialization.JavaScriptTypeResolver>.
- If possible, use a secure serializer instead, and **don't allow an attacker to specify an arbitrary type to deserialize**. Some safer serializers include:
  - <xref:System.Runtime.Serialization.DataContractSerializer?displayProperty=nameWithType>
  - <xref:System.Runtime.Serialization.Json.DataContractJsonSerializer?displayProperty=nameWithType>
  - <xref:System.Xml.Serialization.XmlSerializer?displayProperty=nameWithType>
  - Newtonsoft Json.NET - Use TypeNameHandling.None. If you must use another value for TypeNameHandling, restrict deserialized types to an expected list with a custom ISerializationBinder.
  - Protocol Buffers
- Make the serialized data tamper-proof. After serialization, cryptographically sign the serialized data. Before deserialization, validate the cryptographic signature. Protect the cryptographic key from being disclosed and design for key rotations.

## When to suppress warnings

[!INCLUDE[insecure-deserializers-common-safe-to-suppress](includes/insecure-deserializers-common-safe-to-suppress-md.md)]

## Pseudo-code examples

### Violation

```csharp
using System.Web.Script.Serialization;

public class ExampleClass
{
    public T Deserialize<T>(string str)
    {
        JavaScriptSerializer s = new JavaScriptSerializer(new SimpleTypeResolver());
        return s.Deserialize<T>(str);
    }
}
```

```vb
Imports System.Web.Script.Serialization

Public Class ExampleClass
    Public Function Deserialize(Of T)(str As String) As T
        Dim s As JavaScriptSerializer = New JavaScriptSerializer(New SimpleTypeResolver())
        Return s.Deserialize(Of T)(str)
    End Function
End Class
```

### Solution

```csharp
using System.Web.Script.Serialization;

public class ExampleClass
{
    public T Deserialize<T>(string str)
    {
        JavaScriptSerializer s = new JavaScriptSerializer();
        return s.Deserialize<T>(str);
    }
}
```

```vb
Imports System.Web.Script.Serialization

Public Class ExampleClass
    Public Function Deserialize(Of T)(str As String) As T
        Dim s As JavaScriptSerializer = New JavaScriptSerializer()
        Return s.Deserialize(Of T)(str)
    End Function
End Class
```

### Violation

```cs
using System.Web.Script.Serialization;

public class BookRecord
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PageCount { get; set; }
    public AisleLocation Location { get; set; }
}

public class AisleLocation
{
    public char Aisle { get; set; }
    public byte Shelf { get; set; }
}

public class ExampleClass
{
    public BookRecord DeserializeBookRecord(string s)
    {
        JavaScriptSerializer serializer = new JavaScriptSerializer(new SimpleTypeResolver());
        return serializer.Deserialize<BookRecord>(s);
    }
}
```

```vb
Imports System.Web.Script.Serialization

Public Class BookRecord
    Public Property Title As String
    Public Property Author As String
    Public Property Location As AisleLocation
End Class

Public Class AisleLocation
    Public Property Aisle As Char
    Public Property Shelf As Byte
End Class

Public Class ExampleClass
    Public Function DeserializeBookRecord(str As String) As BookRecord
        Dim serializer As JavaScriptSerializer = New JavaScriptSerializer(New SimpleTypeResolver())
        Return serializer.Deserialize(Of BookRecord)(str)
    End Function
End Class
```

### Solution

```cs
using System;
using System.Web.Script.Serialization;

public class BookRecordTypeResolver : JavaScriptTypeResolver
{
    // For compatibility with data serialized with a JavaScriptSerializer initialized with SimpleTypeResolver.
    private static readonly SimpleTypeResolver Simple = new SimpleTypeResolver();

    public override Type ResolveType(string id)
    {
        // One way to discover expected types is through testing deserialization
        // of **valid** data and logging the types used.

        ////Console.WriteLine($"ResolveType('{id}')");

        if (id == typeof(BookRecord).AssemblyQualifiedName || id == typeof(AisleLocation).AssemblyQualifiedName)
        {
            return Simple.ResolveType(id);
        }
        else
        {
            throw new ArgumentException("Unexpected type ID", nameof(id));
        }
    }

    public override string ResolveTypeId(Type type)
    {
        return Simple.ResolveTypeId(type);
    }
}

public class BookRecord
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PageCount { get; set; }
    public AisleLocation Location { get; set; }
}

public class AisleLocation
{
    public char Aisle { get; set; }
    public byte Shelf { get; set; }
}

public class ExampleClass
{
    public BookRecord DeserializeBookRecord(string s)
    {
        JavaScriptSerializer serializer = new JavaScriptSerializer(new BookRecordTypeResolver());
        return serializer.Deserialize<BookRecord>(s);
    }
}
```

```vb
Imports System
Imports System.Web.Script.Serialization

Public Class BookRecordTypeResolver
    Inherits JavaScriptTypeResolver

    ' For compatibility with data serialized with a JavaScriptSerializer initialized with SimpleTypeResolver.
    Private Dim Simple As SimpleTypeResolver = New SimpleTypeResolver()

    Public Overrides Function ResolveType(id As String) As Type
        ' One way to discover expected types is through testing deserialization
        ' of **valid** data and logging the types used.

        ''Console.WriteLine($"ResolveType('{id}')")

        If id = GetType(BookRecord).AssemblyQualifiedName Or id = GetType(AisleLocation).AssemblyQualifiedName Then
            Return Simple.ResolveType(id)
        Else
            Throw New ArgumentException("Unexpected type", NameOf(id))
        End If
    End Function

    Public Overrides Function ResolveTypeId(type As Type) As String
        Return Simple.ResolveTypeId(type)
    End Function
End Class

Public Class BookRecord
    Public Property Title As String
    Public Property Author As String
    Public Property Location As AisleLocation
End Class

Public Class AisleLocation
    Public Property Aisle As Char
    Public Property Shelf As Byte
End Class

Public Class ExampleClass
    Public Function DeserializeBookRecord(str As String) As BookRecord
        Dim serializer As JavaScriptSerializer = New JavaScriptSerializer(New BookRecordTypeResolver())
        Return serializer.Deserialize(Of BookRecord)(str)
    End Function
End Class
```

## Related rules

[CA2322: Ensure JavaScriptSerializer is not initialized with SimpleTypeResolver before deserializing](ca2322-ensure-javascript-serializer-is-not-initialized-with-simpletyperesolver-before-deserializing.md)