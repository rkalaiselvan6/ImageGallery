using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ImageGallery.Models;
using ImageGallery.DataStore.Models;

namespace ImageGallery.Controllers
{
    public class ImageGalleryController : Controller
    {
        public IActionResult Index()
        {
            var Image1Tags = new List<ImageTag>();
            var Image2Tags = new List<ImageTag>();
            var Image3Tags = new List<ImageTag>();
            #region Tags
            var tag1 = new ImageTag()
            {
                Description = "OhYeah",
                Id = 0
            };
            var tag2 = new ImageTag()
            {
                Description = "littlePanda",
                Id = 1,
            };
            var tag3 = new ImageTag()
            {
                Description = "Bears",
                Id = 2,
            };
            var tag4 = new ImageTag()
            {
                Description = "SwimmingPool",
                Id = 4
            };
            var tag5 = new ImageTag()
            {
                Description = "panda",
                Id = 5
            };
            var tag6 = new ImageTag()
            {
                Description = "Tree",
                Id = 6
            };
            var tag7 = new ImageTag()
            {
                Description = "Bear",
                Id = 7
            };
            var tag8 = new ImageTag()
            {
                Description = "TwoBears",
                Id = 8
            };
            #endregion
            Image1Tags.Add(tag1);
            Image1Tags.Add(tag4); 
            Image2Tags.AddRange(new List<ImageTag> { tag2, tag5, tag6 });
            Image3Tags.AddRange(new List<ImageTag> { tag3, tag7, tag8 });
            var imagesList = new List<Images>
            {
                new Images
                {
                    Title="Image1",
                    ImageUrl="https://binged.it/2zA6RZx",
                    Created=DateTime.Now,
                    MetaDataTags=Image1Tags,
                },
                new Images
                {
                    Title="Image2",
                    ImageUrl="https://binged.it/2zCXDvH",
                    Created=DateTime.Now,
                    MetaDataTags=Image2Tags,
                },
                new Images
                {
                    Title="Image3",
                    ImageUrl="https://binged.it/2Pdka79",
                    Created=DateTime.Now,
                    MetaDataTags=Image3Tags,
                }
            };
            //passing a model to the view represents Gallery
            var model = new ImageGalleryIndexModel()
            {
                Pictures = imagesList,
                SearchQuery="0"
            };
            return View(model);
        }
    }
}