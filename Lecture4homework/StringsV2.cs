using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture4homework
{
    class StringsV2
    {
        public static string UrlFormat(string url, string section, int id)
        {
            if (!url.Contains("section") && !url.Contains("id"))
            {
                return "Error";
            }

            return url.
                    Replace("/section", $"/{section}").
                    Replace("/section/", $"/{section}/").
                    Replace("/section?", $"/{section}?").
                    Replace("?section=", $"?{section}=").
                    Replace("=section", $"={section}").
                    Replace("&section=", $"&{section}=").
                    Replace("=section&", $"={section}&").
                    Replace("/id", $"/{id}").
                    Replace("/id/", $"/{id}/").
                    Replace("/id?", $"/{id}?").
                    Replace("?id=", $"?{id}=").
                    Replace("&id=", $"&{id}=").
                    Replace("=id&", $"={id}&").
                    Replace("=id", $"={id}");
        }

       
    }
}
