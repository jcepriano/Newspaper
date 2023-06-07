using Newspaper;

namespace NewspaperTests
{
    public class ReporterTests
    {
        [Fact]
        public void Reporter_Properties_Initialized()
        {
            int id = 1;
            string name = "James Cepriano";
            string speciality = "Politics";
            Article article = new Article();

            Reporter reporter = new Reporter()
            {
                Id = id,
                Name = name,
                Speciality = speciality,
                Articles = new List<Article> { article }
            };

            Assert.Equal(id, reporter.Id);
            Assert.Equal(name, reporter.Name);
            Assert.Equal(speciality, reporter.Speciality);
            Assert.Equal(new List<Article> { article }, reporter.Articles);
        }
    }
}