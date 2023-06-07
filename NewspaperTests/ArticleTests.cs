using Newspaper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperTests
{
    public class ArticleTests
    {
        [Fact]
        public void Article_Properties_Initialized()
        {
            int id = 1;
            string title = "Book";
            string content = "content";
            Reporter reporter = new Reporter();
            Issue issue = new Issue();

            Article article = new Article()
            {
                Id = id,
                Title = title,
                Content = content,
                Reporter = reporter,
                Issue = issue
            };

            Assert.Equal(id, article.Id);
            Assert.Equal(title, article.Title);
            Assert.Equal(content, article.Content);
            Assert.Equal(reporter, article.Reporter);
            Assert.Equal(issue, article.Issue);
        }
    }
}