namespace AlbumRating.Services.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using AlbumRating.Data.Models;

    public interface IUserService
    {
        List<User> GetAll();

        User GetUserByName(string name);

        int RateAlbum(int albumId, int rating, string userId);

        List<UserRatedAlbum> GetAllRated(string userId);

    }
}