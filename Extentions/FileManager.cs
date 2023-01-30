using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Extention
{
    public static class FileManager
    {

        public static string CreateImage(this IFormFile file, IWebHostEnvironment env, params string[] folders)
        {
            string oldFileName = file.FileName;
            string fileExtention = oldFileName.Split('.').Last();
            string newfileName = $"{Guid.NewGuid()}_{DateTime.Now.ToString("yyyyMMddHHmmssffff")}.{fileExtention}";

            string path = env.WebRootPath;

            foreach (string folder in folders)
            {
                path = Path.Combine(path, folder);
            }

            path = Path.Combine(path, newfileName);

            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            return newfileName;
        }

        public static bool CheckFileSize(this IFormFile file, double size)
        {
            return Math.Round((double)file.Length / 1024) < size;
        }

        public static bool CheckFileType(this IFormFile file, string contentType)
        {
            return file.ContentType == contentType;
        }
    }
}
