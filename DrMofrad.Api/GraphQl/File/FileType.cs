using HotChocolate.Types;

namespace DrMofrad.Api.GraphQl.File
{
    public class FileType : ObjectType<Model.File>
    {
        protected override void Configure(IObjectTypeDescriptor<Model.File> descriptor)
        {
            base.Configure(descriptor);
            descriptor.Description(("Files"));
        }
    }
}