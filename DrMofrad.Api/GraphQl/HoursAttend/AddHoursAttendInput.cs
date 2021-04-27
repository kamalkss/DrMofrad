namespace DrMofrad.Api.GraphQl.HoursAttend
{
    public record AddHoursAttendInput(string HoursAttendDay, string HoursAttendTime, int HoursAttendLangId);
    public record UpdateHoursAttendInput(int HoursAttendId,string HoursAttendDay, string HoursAttendTime, int HoursAttendLangId);

    public record DeleteHoursAttendInput(int HoursAttendId);
}