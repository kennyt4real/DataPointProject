using DataPointProject.Validation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DataPointProject.Models
{
    public class Member 
    {
        public int MemberId { get; set; }
        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public byte[] Passport { get; set; }
        public string ImageDisplay => Passport.ToCustomImage();
        [NotMapped]
        [Display(Name = "Upload A Passport/Picture")]
        //[ValidateFile(ErrorMessage = "Please select a PNG/JPEG image smaller than 1MB")]
        public IFormFile File { get; set; }
        //{
        //    get
        //    {
        //        return null;
        //    }
        //    set
        //    {
        //        try
        //        {
        //            using (var memoryStream = new MemoryStream())
        //            {
        //                value.CopyTo(memoryStream);
        //                Passport = memoryStream.ToArray();
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }
        //    }
        //}

    }

}
