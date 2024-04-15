
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using WebMonitoring.Search;

namespace WebMonitoring.TagHelpers
{
    [HtmlTargetElement("div", Attributes = "stf1file")]
    public class Stf1FileTagHelperComponent : TagHelper
    {
        public List<byte[]> Stf1file { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (output.TagName == "div")
            {          
                output.TagMode = TagMode.StartTagAndEndTag;

                TagBuilder main = new TagBuilder("div");

                TagBuilder script = new TagBuilder("script");
                script.InnerHtml.AppendHtml(
                    @" $('#btnDonwload').click(function() {
                        $.ajax({
                        url: '@Url.Action(\""SendFileStf1\"", \""SearchData\"")',
                        type: 'POST',
                        date: {'stf': " + Stf1file + @"}
                    });
                   });");

                output.Content.AppendHtml(script);
            }
        }
    }
}
