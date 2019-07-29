using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    public class Movie
    {
        #region fields
        private string title;
        private string category;
#endregion
        #region properties
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
#endregion
        #region constructors
        public Movie()
        {

        }
        public Movie(string _title, string _category)
        {
            title = _title;
            category = _category;
        }
        #endregion
        #region methods
        //public List<Movie> SortMovies(List<Movie> movies)
        //{
        //    foreach(Movie movie in movies)
        //    {
                
        //    }
        //}
        #endregion
    }
}
