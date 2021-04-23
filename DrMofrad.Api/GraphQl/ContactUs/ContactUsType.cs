using HotChocolate.Types;

namespace DrMofrad.Api.GraphQl.ContactUs
{
    public class ContactUsType : ObjectType<Model.ContactU>
    {
        protected override void Configure(IObjectTypeDescriptor<Model.ContactU> descriptor)
        {
            descriptor.Description("Contact Us");
        }
    }
}