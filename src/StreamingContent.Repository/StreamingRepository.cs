using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class StreamingRepository : StreamingContentRepository
    {
        //? _contentDirector is inherited from StreamingContentRepository..
        public Show GetShowByTitle(string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                                                            //we are looking for a Show type (class)
                if(content.Title.ToLower()==title.ToLower() && content.GetType() == typeof(Show))
                {
                    return (Show)content;
                }
            }
            return null;
        }

        public Movie GetMovieByTitle(string title)
        {
            // foreach(StreamingContent content in _contentDirectory)
            // {
            //     if(content.Title.ToLower()==title.ToLower() && content is Movie)
            //     {
            //         return (Movie)content;
            //     }
            // }
            // return null;

            //? L.I.N.Q 
            var movie = _contentDirectory.FirstOrDefault(m=>m.Title.ToLower()==title.ToLower());
            return (Movie)movie;
        }

        public List<Show> GetAllShows()
        {
            // var allShows = new List<Show>();
            // foreach (var content in _contentDirectory)
            // {
            //     if(content is Show)
            //     {
            //         allShows.Add((Show)content);
            //     }
            // }
            // return allShows;

            //? L.I.N.Q
            var allShows =_contentDirectory.Where(s=> s is Show).Select(s=>new Show());
            return allShows.ToList();

        }

        public List<Movie> GetAllMovies()
        {
            // var allMovies = new List<Movie>();
            // foreach (var content in _contentDirectory)
            // {
            //     if(content is Movie)
            //     {
            //         allMovies.Add((Movie)content);
            //     }
            // }
            // return null;

            //? L.I.N.Q

            return _contentDirectory.Where(m=>m is Movie).Select(m=>new Movie()).ToList();
        }
    }

//* Challenges for the students to add from here:
        //* Get by other parameters
        //* Get by RunTime/AverageRunTime
        //* Get Shows with over x episodes
        //* Get Shows/Movie By Rating
        