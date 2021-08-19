using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcMusicStore.Models;

namespace MvcMusicStore.Models
{
    public class MusicStoreDbInitializer : DropCreateDatabaseAlways<MusicStoreDB>
    {
        protected override void Seed(MusicStoreDB context)
        {

            context.Artists.Add(new Artist { Name = "m3xpl4y" });
            context.Genres.Add(new Genre 
            { 
                Name = "Twitch", 
                Description = "Streaming ASP.NET on Twitch" 
            });
            context.Albums.Add(new Album
            { 
                Artist = new Artist { Name = "Max Play"},
                Genre = new Genre { Name = "Youtube", Description = "Videos on Youtube"},
                Price = 9.99m,
                Title = "Learning by Doing"
            });


            base.Seed(context);
        }
    }
}