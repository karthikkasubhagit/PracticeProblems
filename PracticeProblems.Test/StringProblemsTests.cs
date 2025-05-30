namespace PracticeProblems.Test
{
    public class StringProblemsTests
    {
     
        //public void CountUpper_ShouldReturnCorrectCount_ForSingleInput(int input, int output)
        //{
        //    StringProblems problems = new StringProblems();
        //    int result = problems.CountUpper("kArTHiK");
        //    Assert.Equal(4,result);
        //}

        [Theory]
        [InlineData("kArTHiK", 4)]
        [InlineData("HelloWorld", 2)]
        [InlineData("12345", 0)]
        [InlineData("ALLCAPS", 7)]
        public void CountUpper_ShouldReturnCorrectCount_ForMultipleInputs(string input, int expectedOutput)
        {
            // Arrange
            StringProblems problems = new StringProblems();

            // Act
            int actualOutput = problems.CountUpper(input);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
