namespace BlazorSlideShowUi.Messages;

public class ImageSelectedMessage
{
    public ImageSelectedMessage(string imagePath)
    {
        ImagePath = imagePath;
    }

    public string ImagePath { get; }
}