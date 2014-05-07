using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using Newtonsoft.Json;

namespace MovieList.Helpers
{
    public static class Utility
    {
        public static Movie GetMovieDetails(string ID)
        {
            var json = new WebClient().DownloadString("http://www.omdbapi.com/?i=" + ID);
            Movie m = JsonConvert.DeserializeObject<Movie>(json);

            return m;
        }
    }
}