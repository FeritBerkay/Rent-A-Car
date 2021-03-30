using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
        public static string newPath(IFormFile file)
        {
            FileInfo fileInfo = new FileInfo(file.FileName);
            string fileExtension = fileInfo.Extension;

            var newPath = Guid.NewGuid().ToString() + "_"
                + DateTime.Now.Month + "_"
                + DateTime.Now.Day + "_"
                + DateTime.Now.Year
                + fileExtension;

            string result = $@"wwwroot\Images\{newPath}";
            return result;
        }

        public static string Add(IFormFile file)
        {
            var result = newPath(file);

            try
            {
                var sourcePath = Path.GetTempFileName();

                if (file.Length > 0)
                {
                    using (var stream = new FileStream(sourcePath, FileMode.Create))
                        file.CopyTo(stream);
                }
                File.Move(sourcePath, result);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return result;
        }
    }   
}

