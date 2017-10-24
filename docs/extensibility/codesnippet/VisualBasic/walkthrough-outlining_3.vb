    'the characters that start the outlining region
    Private startHide As String = "["
    'the characters that end the outlining region
    Private endHide As String = "]"
    'the characters that are displayed when the region is collapsed
    Private ellipsis As String = "..."
    'the contents of the tooltip for the collapsed span
    Private hoverText As String = "hover text"
    Private buffer As ITextBuffer
    Private snapshot As ITextSnapshot
    Private regions As List(Of Region)