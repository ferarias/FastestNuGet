namespace FastestNuGet.Test
{
    using FastestNuGet;
    using Xunit;

    public class Class1Test
    {
        [Fact]
        public void Given_When_Then()
        {
            var class1 = new Class1();
            var class2 = new Class1();
            Assert.NotNull(class1);
            Assert.NotNull(class2);
        }
    }
}
