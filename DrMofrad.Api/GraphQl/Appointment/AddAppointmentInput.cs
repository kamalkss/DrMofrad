using System;

namespace DrMofrad.Api.GraphQl.Appointment
{
    public record AddAppointmentInput(string Fullname, string cell, string clinic, DateTime Appointmentdate,
        string Appointmenttime, string Apointmenttexts, bool Isreader);
    public record UpdateAppointmentInput(int AppointmentId,string Fullname, string cell, string clinic, DateTime Appointmentdate,
        string Appointmenttime, string Apointmenttexts, bool Isreader);

    public record RemoveAppointmentInput(int AppointmentId);
}