namespace MyFitnessApp.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MyFitnessApp.Data.Common.Models;

    using static MyFitnessApp.Common.DataConstants;

    public class ArticleCategory : BaseDeletableModel<int>
    {
        public ArticleCategory()
        {
            this.Articles = new HashSet<Article>();
        }

        [Required]
        [MaxLength(ArticleCategoryNameMaxLength)]
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
