using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newspaper.Tests
{
    public class IssueTests
    {
        [Fact]
        public void IssueProperties_InitializedCorrectly()
        {
            int id = 1;
            DateTime date = DateTime.Now;
            Article article = new Article();

            Issue issue = new Issue
            {
                Id = id,
                Date = date,
                Articles = new List<Article> { article }
            };

            Assert.Equal(id, issue.Id);
            Assert.Equal(date, issue.Date);
            Assert.Equal(new List<Article> { article }, issue.Articles);
        }
    }
}