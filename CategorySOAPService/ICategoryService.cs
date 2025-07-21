using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CategorySOAPService
{
    [ServiceContract]
    public interface ICategoryService
    {
        [OperationContract]
        List<Category> GetCategories();

        [OperationContract]
        Category GetCategoryById(int id);

    }

    [DataContract]
    public class Category
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        
    }
}
