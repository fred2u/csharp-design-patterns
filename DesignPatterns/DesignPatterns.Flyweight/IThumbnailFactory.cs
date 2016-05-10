namespace DesignPatterns.Flyweight
{
    internal interface IThumbnailFactory
    {
        Thumbnail GetThumbnail(string fileName);
    }
}