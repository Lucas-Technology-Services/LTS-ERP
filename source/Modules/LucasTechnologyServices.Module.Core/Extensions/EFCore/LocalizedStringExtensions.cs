﻿using Microsoft.AspNetCore.Mvc.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Module.Core.Extensions.EFCore
{
    public static class LocalizedStringExtensions
    {
        public static Func<int, LocalizedHtmlString> GetTextPartsFunction(this LocalizedHtmlString localizedHtmlString, params string[] splitTokens)
        {
            var originalTextParts = localizedHtmlString.Name.Split(splitTokens, StringSplitOptions.None).ToList();
            var localizedTextParts = localizedHtmlString.Value.Split(splitTokens, StringSplitOptions.None).ToList();

            LocalizedHtmlString funcLocalizedParts(int i) =>
                i < originalTextParts.Count && i < localizedTextParts.Count
                    ? new LocalizedHtmlString(originalTextParts.ElementAt(i), localizedTextParts.ElementAt(i))
                    : new LocalizedHtmlString($"Index_{i}_OutOfRange", string.Empty);

            return funcLocalizedParts;

        }
    }
}
