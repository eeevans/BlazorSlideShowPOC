namespace BlazorSlideShow.Services;

public class MessageService
{
    public event MessageTriggeredHandler RaiseMessageTriggered;

    public delegate void MessageTriggeredHandler(object sender, MessageTriggeredEventArgs args);
}

public class MessageTriggeredEventArgs : EventArgs
{
    public MessageTriggeredEventArgs(string newFile)
    {
        NewFile = newFile;
    }

    public string NewFile { get; set; }
}