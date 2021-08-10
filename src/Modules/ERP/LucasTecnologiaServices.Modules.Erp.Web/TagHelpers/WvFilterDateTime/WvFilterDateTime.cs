﻿using LucasTecnologiaServices.Modules.Erp.Api.Models;
using LucasTecnologiaServices.Modules.Erp.Web.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.TagHelpers.WvFilterDateTime
{
	[HtmlTargetElement("wv-filter-datetime")]
	public class WvFilterDateTime : WvFilterBase
	{
		public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
		{
			if (!isVisible)
			{
				output.SuppressOutput();
				return Task.CompletedTask;
			}
			#region << Init >>
			var initSuccess = InitFilter(context, output);

			if (!initSuccess)
			{
				return Task.CompletedTask;
			}
			#endregion
			var inputGroupEl = new TagBuilder("div");
			inputGroupEl.AddCssClass("input-group");

			inputGroupEl.InnerHtml.AppendHtml(FilterTypeSelect);

			#region << valueDateControl >>
			{
				var valueDateControl = new TagBuilder("input");
				valueDateControl.AddCssClass("form-control value");
				if (QueryType != FilterType.BETWEEN && QueryType != FilterType.NOTBETWEEN)
{
valueDateControl.AddCssClass("rounded-right");
}
				valueDateControl.Attributes.Add("value", (Value != null ? Value.ToString("yyyy-MM-ddTHH:mm") : ""));
				valueDateControl.Attributes.Add("type", "datetime-local");
				valueDateControl.Attributes.Add("name", UrlQueryOfValue);
				inputGroupEl.InnerHtml.AppendHtml(valueDateControl);
			}
			#endregion


			inputGroupEl.InnerHtml.AppendHtml(AndDivider);

#region << value2DateControl >>
{
var value2DateControl = new TagBuilder("input");
				value2DateControl.Attributes.Add("value", (Value2 != null ? Value2.ToString("yyyy-MM-ddTHH:mm") : ""));
				value2DateControl.AddCssClass("form-control value2");
				value2DateControl.Attributes.Add("type", "datetime-local");
				if (QueryType == FilterType.BETWEEN || QueryType == FilterType.NOTBETWEEN)
				{
					value2DateControl.Attributes.Add("name", UrlQueryOfValue2);
				}
				else
				{
					value2DateControl.AddCssClass("d-none");
				}
				inputGroupEl.InnerHtml.AppendHtml(value2DateControl);
			}
			#endregion


			output.Content.AppendHtml(inputGroupEl);

			return Task.CompletedTask;
		}

	}
}