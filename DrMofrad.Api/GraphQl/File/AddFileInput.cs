namespace DrMofrad.Api.GraphQl.File
{
    public record AddFileInput(string FileTitle, string FileFileUrl);
    public record UpdateFileInput(int FileId, string FileTitle, string FileFileUrl);

    public record RemoveFileInput(int FileId);
}