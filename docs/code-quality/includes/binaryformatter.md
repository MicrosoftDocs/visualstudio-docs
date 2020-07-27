[!WARNING]
`BinaryFormatter` is insecure and cannot be made secure. For more information, see the [BinaryFormatter security guide](/dotnet/standard/serialization/binaryformatter-security-guide).

<!--
Prefer to just say it can't be made secure and send them off for more details. 
((can help mitigate against known remote code execution attacks)) only encourages them to keep using it.
Using a SerializationBinder to restrict deserializable types can help mitigate against known remote code execution attacks, but your deserialization will still be vulnerable to denial of service attacks. In the future, there may be new remote code execution attacks that a SerializationBinder can't prevent. For more information, see the [BinaryFormatter security guide](/dotnet/standard/serialization/binaryformatter-security-guide).
-->
