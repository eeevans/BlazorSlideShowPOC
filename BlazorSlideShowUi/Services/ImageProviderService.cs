namespace BlazorSlideShowUi.Services;

public interface IImageProviderService
{
    IList<string> Images { get; }
}

public class ImageProviderService : IImageProviderService
{
    private readonly IHostEnvironment _environment;
    private List<string> _images;

    public ImageProviderService(IWebHostEnvironment environment)
    {
        _environment = environment;
        _images = _environment.ContentRootFileProvider.GetDirectoryContents(Path.Combine("wwwroot", "images"))
            .Select(f => f.Name)
            .ToList();
    }

    public IList<string> Images => _images;
}