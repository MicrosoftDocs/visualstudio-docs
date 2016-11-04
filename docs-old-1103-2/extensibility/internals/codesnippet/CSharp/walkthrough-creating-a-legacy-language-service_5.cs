namespace MyLanguagePackage
{
    class MySource : Source
    {
        public MySource(LanguageService service,
                        IVsTextLines textLines,
                        Colorizer colorizer)
            : base(service, textLines, colorizer)
        {
        }
    }
}