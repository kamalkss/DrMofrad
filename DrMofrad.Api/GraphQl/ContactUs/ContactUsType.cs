using DrMofrad.Api.Model;
using HotChocolate.Types;

namespace DrMofrad.Api.GraphQl.ContactUs
{
    public class ContactUsType : ObjectType<ContactU>
    {
        protected override void Configure(IObjectTypeDescriptor<ContactU> descriptor)
        {
            descriptor.Description("Contact Us");
        }
    }
}