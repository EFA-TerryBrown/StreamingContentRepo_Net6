using Xunit;



public class StreamingContentTestingSite
{
    [Fact]
    public void SetTitle_ShouldSetCorrectString()
    {
        //? AAA setup

        //? Arrange
            StreamingContent content = new StreamingContent();
            content.Title = "Toy Story";
        
        //? Action
            string expected= "Toy Story";
            string actual = content.Title;

        //? Assert
            Assert.Equal(expected,actual);
    }

    [Theory]
    [InlineData(MaturityRating.G,true)]
    [InlineData(MaturityRating.TV_PG,true)]
    [InlineData(MaturityRating.R,false)]
    [InlineData(MaturityRating.TV_MA,false)]
    public void SetMaturityRating_ShouldGetCorrectFamilyFriendlyRating(MaturityRating maturityRating, bool expectedFamilyFriendly)
    {
        //? AAA setup

        //? Arrange
        StreamingContent content = new StreamingContent("Content Title", "Some Description", 4.2, maturityRating, GenreType.SciFi);
        //? Action
        bool actual =content.IsFamilyFriendly;
        bool expected = expectedFamilyFriendly;
        //? Assert
        Assert.Equal(expected,actual);
    }
}