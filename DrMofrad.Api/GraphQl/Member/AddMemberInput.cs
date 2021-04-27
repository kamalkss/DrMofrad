namespace DrMofrad.Api.GraphQl.Member
{
    public record AddMemberInput(string MemberFullName, string MemberUserName, string MemberPassword,
        string MemberEmail);
    public record UpdateMemberInput(int MemberId,string MemberFullName, string MemberUserName, string MemberPassword,
        string MemberEmail);

    public record DeleteMemberInput(int MemberId);
}