using System;

namespace DrMofrad.Api.GraphQl.Faq
{
    public record AddfaqInput(string FaqQuestion, string FaqAnswer, int FaqShowCount, int FaqLikeCount,
        DateTime Faqdate, int FaqLangId);
    public record UpdatefaqInput(int FaqId, string FaqQuestion, string FaqAnswer, int FaqShowCount, int FaqLikeCount,
        DateTime Faqdate, int FaqLangId);

    public record RemovefaqInput(int FaqId);
}