namespace DrMofrad.Api.GraphQl.ActivityCenter
{
    public record AddActivityCenterInput(string Title, int ActivityCenterLangId, string MoreInfo);
    public record UpdateActivityCenterInput(int ActivityCenterId, string Title, int ActivityCenterLangId, string MoreInfo);

    public record RemoveActivityCenterInput(int ActivityCenterId);
}