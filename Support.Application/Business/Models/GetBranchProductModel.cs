using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Support.Application.Business.Models
{
    public class GetBranchProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CurrentCode { get; set; }
        public List<ProductModel> Products { get; set; }

    }

    public class ProductModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int VariantId { get; set; }
        public string VariantCode { get; set; }
        public CategoryModel Category { get; set; }
    }

    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
