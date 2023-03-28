using BlazorDate.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDate.Server.Controllers
{
    public class PictureController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PictureController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("UploadImage")]
        public async Task<ActionResult> UploadImage()
        {
            bool Result = false;
            try
            {
                var files = Request.Form.Files;
                //foreach (IFormFile source in _uploadedfiles)
                //{
                //    string fileName = source.FileName;
                //    string filePath = GetFilePath(fileName);

                //    if (!System.IO.Directory.Exists(filePath))
                //    {
                //        System.IO.Directory.CreateDirectory(filePath);
                //    }

                //    string imagePath = filePath + "\\image.png";

                //    if (System.IO.File.Exists(imagePath))
                //    {
                //        System.IO.File.Delete(imagePath);
                //    }
                //    using (FileStream stream = System.IO.File.Create(imagePath))
                //    {
                //        await source.CopyToAsync(stream);
                //        Result = true;
                //    }
                //}
            }
            catch (Exception ex)
            {

            }
            return Ok(Result);
        }

        [NonAction]
        private string GetFilePath(string fileName)
        {
            return this._webHostEnvironment.WebRootPath + "\\Uploads\\Person\\";  //PersonId;
        }

        [NonAction]
        private string GetImageByPerson(Person person)
        {
            //todo make person to personId

            string imageUrl = string.Empty;
            string hostUrl = "https://localhost:7287/";
            string filePath = GetFilePath(person.PersonId.ToString());
            string imagePath = filePath + "\\image.png";
            if(!System.IO.File.Exists(filePath))
            {
                imageUrl = hostUrl + "/uploads/common/noimage.png";

            }
            else
            {
                imageUrl = hostUrl + "/uploads/Person/" + person.PersonId.ToString() + "/image.png" ;
            }
            return imageUrl;
        }

        //public ResponseType RemoveImage(string imageId)
        //{
        //    string filePath = GetFilePath(imageId.ToLower());
        //    string imagePath = filePath + "\\image.png";
        //    try
        //    {
        //        if (System.IO.File.Exists(filePath))
        //        {
        //            System.IO.File.Delete(imagePath);
        //        }
        //        return new ResponseType { Result = "pass", KyValue = code }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
