using DrMofrad.Api.Model;
using HotChocolate;
using HotChocolate.Types;
using System.Linq;

namespace DrMofrad.Api.GraphQl.SeoSetting
{
    public class SeoSettingType : ObjectType<Model.SeoSetting>
    {
        protected override void Configure(IObjectTypeDescriptor<Model.SeoSetting> descriptor)
        {
            descriptor.Description("SeoSetting");
            descriptor.Field(p => p.Lang)
                .UseDbContext<DrMofradDbContext>()
                .ResolveWith<Resolver>(resolver => resolver.GetLang(default!, default!));
        }

        private class Resolver
        {
            public Model.Lang GetLang(Model.SeoSetting _seoSetting, [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.Langs.FirstOrDefault(lang => lang.Id == _seoSetting.LangId);
            }
        }
    }
}