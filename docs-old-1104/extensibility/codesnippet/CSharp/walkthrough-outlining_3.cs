    string startHide = "[";     //the characters that start the outlining region
    string endHide = "]";       //the characters that end the outlining region
    string ellipsis = "...";    //the characters that are displayed when the region is collapsed
    string hoverText = "hover text"; //the contents of the tooltip for the collapsed span
    ITextBuffer buffer;
    ITextSnapshot snapshot;
    List<Region> regions;