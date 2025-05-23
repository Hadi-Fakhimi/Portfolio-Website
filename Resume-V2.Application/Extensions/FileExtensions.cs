using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Resume_V2.Application.Extensions
{
    public static class FileExtensions
    {
        public static async Task AddImageAjaxToServer(this IFormFile file, string fileName, string orginalPath)
        {
            if (file != null)
            {
                if (!Directory.Exists(orginalPath)) Directory.CreateDirectory(orginalPath);

                string OrginalPath = orginalPath + fileName;

                if (File.Exists(OrginalPath))
                {
                    File.Delete(OrginalPath);
                }

                using (var stream = new FileStream(OrginalPath, FileMode.Create))
                {
                    if (!Directory.Exists(OrginalPath)) await file.CopyToAsync(stream);
                }

            }
        }

        public static async Task AddPdfAjaxToServer(this IFormFile file, string fileName, string orginalPath)
        {
            if (file != null)
            {
                if (!Directory.Exists(orginalPath)) Directory.CreateDirectory(orginalPath);

                string OrginalPath = orginalPath + fileName;


                if (File.Exists(OrginalPath))
                {
                    File.Delete(OrginalPath);
                }

                using (var stream = new FileStream(OrginalPath, FileMode.Create))
                {
                    if (!Directory.Exists(OrginalPath)) await file.CopyToAsync(stream);
                }

            }
        }
    }
}
