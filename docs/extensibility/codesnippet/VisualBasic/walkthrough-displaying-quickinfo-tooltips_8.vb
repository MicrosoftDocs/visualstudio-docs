    Private _NavigatorService As ITextStructureNavigatorSelectorService
    <Import()> _
    Friend Property NavigatorService() As ITextStructureNavigatorSelectorService
        Get
            Return _NavigatorService
        End Get
        Set(ByVal value As ITextStructureNavigatorSelectorService)
            _NavigatorService = value
        End Set
    End Property

    Private _TextBufferFactoryService As ITextBufferFactoryService
    <Import()> _
    Friend Property TextBufferFactoryService() As ITextBufferFactoryService
        Get
            Return _TextBufferFactoryService
        End Get
        Set(ByVal value As ITextBufferFactoryService)
            _TextBufferFactoryService = value
        End Set
    End Property