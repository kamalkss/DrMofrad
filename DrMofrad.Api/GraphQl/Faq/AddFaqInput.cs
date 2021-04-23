using System;

namespace DrMofrad.Api.GraphQl.Faq
{
    public record AddfaqInput(string Question, string Answer, int ShowCount, int LikeCount,DateTime date,int LangId);
}