using ShoppingMallMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ShoppingMallMVC.Html
{
    public static class PagingHelper
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, PagingInfo info, Func<int, string> pageUrl)
        {
            //    @for(int p = 1; p <= Model.Page.TotalPages; p++)
            //{
            //        if (p == Model.Page.CurrentPage)
            //        {
            //        < li class="page-item active" aria-current="page"><p class="page-link">@p</p></li>
            //    }
            //    else
            //    {
            //        <li class="page-item"><a class="page-link" href="/Product/Index?category=@Model.CurrentCategory&page=@p">@p</a></li>
            //    }
            //}

            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= info.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml = i.ToString();
                tag.AddCssClass("page-link");

                TagBuilder li = new TagBuilder("li");
                if (i == info.CurrentPage)
                {
                    li.AddCssClass("page-item active");
                }
                else
                {
                    li.AddCssClass("page-item");
                }

                li.InnerHtml = tag.ToString();

                sb.Append(li.ToString());
                
            }

            return MvcHtmlString.Create(sb.ToString());
        }
    }
}