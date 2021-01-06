using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Drawing.Imaging;


namespace DataPointProject.Validation
{
    public class ValidateFile : RequiredAttribute
    {
        public override bool IsValid(object value)
        {
            if (!(value is IFormFile file))
            {
                return true;
            }

            if (file.Length > 1 * 2024 * 2024)
            {
                return false;
            }

            try
            {
                using var img = Image.FromStream(file.OpenReadStream());
                return img.RawFormat.Equals(img.RawFormat.Equals(ImageFormat.Png) ? ImageFormat.Png : ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
    }
}
