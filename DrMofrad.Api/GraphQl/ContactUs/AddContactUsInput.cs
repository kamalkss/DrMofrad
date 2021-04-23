using System;

namespace DrMofrad.Api.GraphQl.ContactUs
{
    public record AddContactUsInput(string ContactUsFullName, string ContactUsEmail, string ContactUsCell,
        string ContactUsMesseges, DateTime ContactUsdate, bool ContactUsisreaded);
}