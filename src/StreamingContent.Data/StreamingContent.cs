
//* This is our POCO (Plain Old C# Object)
//* "Abstraction"
//* This is key for the implementation of the Repository Pattern
public class StreamingContent
{
    //* We need some properties
    //! This is my 'Key' (unique identifier)
    public string Title { get; set; }
    public string Description { get; set; }
    public double StarRating { get; set; }
    public MaturityRating MaturityRating { get; set; }
    public bool IsFamilyFriendly 
    { 
        get
        {
            //* we're going to use a switch statement here
            switch(MaturityRating)
            {
                case MaturityRating.G:
                case MaturityRating.PG:
                case MaturityRating.TV_Y:
                case MaturityRating.TV_G:
                case MaturityRating.TV_PG:
                return true;
                case MaturityRating.PG_13:
                case MaturityRating.R:
                case MaturityRating.NC_17:
                case MaturityRating.TV_14:
                case MaturityRating.TV_MA:
                default:
                return false;
            }
            
        }
    }

    public GenreType TypeOfGenre { get; set; }

    //* constructors
    //* Empty Constructor
    public StreamingContent() { }

    //* Full Constructor
    public StreamingContent(string title, string description, double starRating, MaturityRating maturityRating,
                            GenreType typeOfGenre)
    {
        Title = title;
        Description = description;
        StarRating = starRating;
        MaturityRating = maturityRating;
        TypeOfGenre = typeOfGenre;
    }
}
