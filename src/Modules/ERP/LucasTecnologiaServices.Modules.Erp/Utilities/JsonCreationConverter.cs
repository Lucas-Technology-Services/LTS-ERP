﻿using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace LucasTecnologiaServices.Modules.Erp.Utilities
{
	public abstract class JsonCreationConverter<T> : JsonConverter
	{
		protected abstract T Create(Type objectType, JObject jObject);
public override bool CanConvert(Type objectType)
{
			return typeof(T).IsAssignableFrom(objectType);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
{
if (reader.TokenType == JsonToken.Null)
				return null;

			// Load JObject from stream
			JObject jObject = JObject.Load(reader);

			// Create target object based on JObject
			T target = Create(objectType, jObject);

			// Populate the object properties
			StringWriter writer = new StringWriter();
			serializer.Serialize(writer, jObject);
			using (JsonTextReader newReader = new JsonTextReader(new StringReader(writer.ToString())))
			{
				newReader.Culture = reader.Culture;
				newReader.DateParseHandling = reader.DateParseHandling;
				newReader.DateTimeZoneHandling = reader.DateTimeZoneHandling;
				newReader.FloatParseHandling = reader.FloatParseHandling;
serializer.Populate(newReader, target);
			}

			return target;
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			serializer.Serialize(writer, value);
		}
	}
}
