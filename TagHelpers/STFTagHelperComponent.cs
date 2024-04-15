
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using WebMonitoring.Models;

namespace WebMonitoring.TagHelpers
{
    [HtmlTargetElement("div", Attributes = "htmltable")]
    public class STFTagHelperComponent : TagHelper
    {
        public string Htmltable { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (output.TagName == "div")
            {          
                output.TagMode = TagMode.StartTagAndEndTag;

                TagBuilder main = new TagBuilder("div");
                TagBuilder table = new TagBuilder("table");
                table.AddCssClass("table table-hover table-striped table-bordered");
                table.Attributes.Add("id", "idSTF");
                table.InnerHtml.AppendHtml(Htmltable);
                main.InnerHtml.AppendHtml(table);
                output.Content.AppendHtml(main);
            }
        }
    }
}
