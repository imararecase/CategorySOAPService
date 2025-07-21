using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CategorySOAPService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category { Id = 1, Name = "Electronics" },
                new Category { Id = 2, Name = "Books" },
                new Category { Id = 3, Name = "Clothing" }
            };
        }

        public Category GetCategoryById(int id)
        {
            var categories = GetCategories();
            return categories.FirstOrDefault(c => c.Id == id);
        }

    }

}
