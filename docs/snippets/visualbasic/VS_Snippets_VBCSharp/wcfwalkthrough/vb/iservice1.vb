﻿' NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
' <Snippet6>
<ServiceContract()>
Public Interface IService1
' </Snippet6>
    ' <Snippet1>
    <OperationContract()>
    Function GetData(ByVal value As String) As String
    ' </Snippet1>
    <OperationContract()>
    Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType
    
    ' TODO: Add your service operations here

End Interface

' Use a data contract as illustrated in the sample below to add composite types to service operations

<DataContract()>
Public Class CompositeType

    <DataMember()>
    Public Property BoolValue() As Boolean

    <DataMember()>
    Public Property StringValue() As String

End Class
