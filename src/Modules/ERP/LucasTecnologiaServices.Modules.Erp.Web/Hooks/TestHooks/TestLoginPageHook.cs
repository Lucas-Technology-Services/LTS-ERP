﻿using LucasTecnologiaServices.Modules.Erp.Api.Models;
using LucasTecnologiaServices.Modules.Erp.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Hooks.TestHooks
{
	[HookAttachment]
	class TestLoginPageHook : ILoginPageHook
	{
		public IActionResult OnPostAfterLogin(ErpUser user, LoginModel pageModel)
		{
			return null;
		}

		public IActionResult OnPostPreLogin(LoginModel pageModel)
		{
			return null;
		}
	}
}