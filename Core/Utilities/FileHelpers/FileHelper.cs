using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.FileHelpers
{
    public static class FileHelper
    {
        public static string Add(IFormFile file, string path)
        {
            var newGuidPath = Guid.NewGuid() + Path.GetExtension(file.FileName);
            string newPath = path + "\\" + newGuidPath;
            if (file == null)
            {
                return "default.png";
            }

            using (var stream = System.IO.File.Create(newPath))
            {
                file.CopyTo(stream);
                stream.Flush();
            }
            return newGuidPath;
        }
    }
}
