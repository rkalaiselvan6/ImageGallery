using System;
using ImageGallery.DataStore.Models;
using Microsoft.EntityFrameworkCore;

namespace ImageGallery.DataStore
{
    public class ImageGalleryDbContext: DbContext
    {
        //Using EFCoreTools to run database migrations from package manager
        //Also using EFCoreSqlServer which acts a backend for the app
        public ImageGalleryDbContext(DbContextOptions options):base (options)
        {

        }
        public DbSet<Images> GallaryImages { get; set; }
        public DbSet<ImageTag> GalleryImageTags { get; set; }

    }
}
