

//* Repository Pattern
public class StreamingContentRepository
{
    //* Used when we interact w/ data
    //* dont have a database right now we are going to simulate one using List<T> (collection)
    //* will be at the top of our class
    //! THIS IS OUR FAKE DATABASE
    //? protected -> only inheriting members can use this variable
    protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

    //* We will be using C.R.U.D

    //? Create
    public bool AddContentToDirectory(StreamingContent content)
    {
        //* Check the overall _contentDirectory count
        int startingCount = _contentDirectory.Count();

        //*Adding content to the Fake Database....
        _contentDirectory.Add(content);

        //*After adding the startingCount, we can Add the content and then compare the current count
        //* this will evalualte to true/false
        bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
        return wasAdded;
    }

    //? Read 
    public List<StreamingContent> GetAllContent()
    {
        return _contentDirectory;
    }

    //? Read #2
    //! string title is the Unique Identifier that describes a specific movie
    //*considered to be a helper method
    public StreamingContent GetContentByTitle(string title)
    {
        //* look in all of the _contentDirectory and check if the title exists
        foreach (StreamingContent content in _contentDirectory)
        {
            if (content.Title == title)
            {
                return content;
            }
        }

        return null;
    }

    //? Update
    //? Updates clear everything!
    public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
    {
        //* use helper method (GetContentByTitle)
        StreamingContent oldContent = GetContentByTitle(originalTitle);

        //*check if oldContent actually has content
        if (oldContent != null)
        {
            oldContent.Title = newContent.Title;
            oldContent.Description = newContent.Description;
            oldContent.MaturityRating = newContent.MaturityRating;
            oldContent.StarRating = newContent.StarRating;
            oldContent.TypeOfGenre = newContent.TypeOfGenre;

            return true;
        }
        return false;
    }

    //? Delete
    public bool DeleteExistingContent(StreamingContent content)
    {
        bool deleteResult = _contentDirectory.Remove(content);
        return deleteResult;
    }

    //? You can make other methods
    //? You are not restricted to crud
    //* Get streaming content by Genre
    public List<StreamingContent> GetStreamingContentByGenre(GenreType type)
    {
        //todo: list starting point (empty list)
        var genereList = new List<StreamingContent>();
        
        //todo: loops through entire directory
        foreach(var content in _contentDirectory)
        {
            //todo: if we find a genre that matches...
            if(content.TypeOfGenre == type)
            {
                //todo: add it to the above list
                genereList.Add(content);
            }
        }

        //todo: return or 'give us back' the value
        return genereList;
    }
}

//todo: Challenges:
        //todo: Get by other parameters
        //todo: Get By Rating
        //todo: Get By Family Friendly
        //todo: Etc