using System;
using System.Collections.Generic;
using System.Text;
using ImageGallery.DataStore.Models;

namespace ImageGallery.DataStore.Models
{
    /// <summary>
    /// This model contains all the properties of an instance of image 
    /// </summary>
    public class Images
    {
        #region Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
        //To store location of an image stored in the cloud
        public string ImageUrl { get; set; }
        //Adding metadata to enable better search of images
        public virtual IEnumerable<ImageTag> MetaDataTags { get; set; } 
        #endregion
    }
}
