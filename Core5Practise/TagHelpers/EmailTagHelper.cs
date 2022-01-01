using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Core5Practise.TagHelpers
{
    public class EmailTagHelper :TagHelper
    {
        public string Email { get; set; }
        public string Content   { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.Add("href",$"mailto:{Email}");
            output.Content.Append(Content);
        }
    }
}