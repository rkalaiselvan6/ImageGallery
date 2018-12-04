using ImageGallery.DataStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGallery.Models
{
    public class ImageGalleryIndexModel
    {
        //creating collection of images
        public IEnumerable<Images> Pictures { get; set; }
        //string that takes search query
        public string SearchQuery { get; set; }


    }
}
