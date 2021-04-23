using System;

namespace DrMofrad.Api.GraphQl.Faq
{
    public record AddfaqInput(string FaqQuestion, string FaqAnswer, int FaqShowCount, int FaqLikeCount,
        DateTime Faqdate, int FaqLangId);
}