using HotChocolate.Types;

namespace DrMofrad.Api.GraphQl.Appointment
{
    public class AppointmentType : ObjectType<Model.Appointment>
    {
        protected override void Configure(IObjectTypeDescriptor<Model.Appointment> descriptor)
        {
            descriptor.Description("Appointment");
        }
    }
}