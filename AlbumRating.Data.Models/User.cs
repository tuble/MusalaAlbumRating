﻿namespace AlbumRating.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    using Microsoft.AspNetCore.Identity;

    public class User : IdentityUser
    {
        public User()
        {
            this.UserRatedAlbums = new List<UserRatedAlbum>();
        }

/*        [Key]
        public int UserId { get; set; } // only keep this ID

        public string Name { get; set; }
*/
        public ICollection<UserRatedAlbum> UserRatedAlbums { get; set; }

        [Key]
        public string UserId { get; set; }
    }
}