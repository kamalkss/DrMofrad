using System;

namespace DrMofrad.Api.GraphQl.ContactUs
{
    public record AddContactUsInput(string FullName, string Email, string Cell, string Messeges,DateTime date,bool isreaded);
}