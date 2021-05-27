using Microsoft.Extensions.PlatformAbstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerExtension.Helpers
{
    public static class XMLPathHelper
    {
        public static string[] XmlCommentsFilePaths
        {
            get
            {
                var basePath = PlatformServices.Default.Application.ApplicationBasePath;

                string[] files = Directory.GetFiles(basePath, "*.xml", SearchOption.TopDirectoryOnly);

                return files.Select(f => Path.Combine(basePath, f)).ToArray();
            }
        }
    }
}
