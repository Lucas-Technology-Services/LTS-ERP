﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Hooks
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class HookAttachmentAttribute : Attribute
	{
		public string Key { get; private set; } = string.Empty;

		public int Priority { get; private set; } = 10;

		public HookAttachmentAttribute(string key = "", int priority = 10)
		{
			Key = key;
			Priority = priority;
		}
	}
}
