﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.PluginsProject.Model
{
	internal class PluginSettings
	{
		[JsonProperty(PropertyName = "version")]
		public int Version { get; set; }
	}
}