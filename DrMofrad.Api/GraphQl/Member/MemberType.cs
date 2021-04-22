﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrMofrad.Api.Model;
using HotChocolate.Types;

namespace DrMofrad.Api.GraphQl.Member
{
    public class MemberType : ObjectType<Model.Member>
    {
        protected override void Configure(IObjectTypeDescriptor<Model.Member> descriptor)
        {
            descriptor.Description("Member Of website");

            //descriptor.Field(q=>q.GetMembers(default).Type<>)
            //descriptor.Field(item => item.).Type<Model.Member>().Name()
        }
    }
}
