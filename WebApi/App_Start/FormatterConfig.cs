﻿namespace forCrowd.WealthEconomy.WebApi
{
    using System.Net.Http.Formatting;

    public class FormatterConfig
    {
        public static void RegisterFormatters(MediaTypeFormatterCollection formatters)
        {
            // Remove xml formatter (at least for the moment)
            formatters.Remove(formatters.XmlFormatter);

            // Json formatter
            //formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            //formatters.JsonFormatter.Indent = true; ?
            //formatters.JsonFormatter.SerializerSettings.Converters.Add(new StringEnumConverter());
            //formatters.JsonFormatter.MaxDepth = 1;
            //formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        }
    }
}
