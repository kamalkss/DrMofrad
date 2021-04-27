namespace DrMofrad.Api.GraphQl.Cilinic
{
    public record AddClinicInput(string CilinicTitle, int CilinicLangId);
    public record UpdateClinicInput(int ClinicId,string CilinicTitle, int CilinicLangId);

    public record RemoveClinicInput(int ClinicId);
}