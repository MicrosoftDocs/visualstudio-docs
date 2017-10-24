    Private _QuickInfoBroker As IQuickInfoBroker
    <Import()> _
    Friend Property QuickInfoBroker() As IQuickInfoBroker
        Get
            Return _QuickInfoBroker
        End Get
        Set(ByVal value As IQuickInfoBroker)
            _QuickInfoBroker = value
        End Set
    End Property