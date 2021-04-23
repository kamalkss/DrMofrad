namespace DrMofrad.Api.GraphQl.Member
{
    public record AddMemberInput(string MemberFullName, string MemberUserName, string MemberPassword,
        string MemberEmail);
}