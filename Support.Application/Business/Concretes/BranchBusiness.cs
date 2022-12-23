using Support.Application.Business.Abstracts;
using Support.Application.Business.Models;
using Support.Application.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Support.Application.Business.Concretes
{
    public class BranchBusiness : IBranchBusiness
    {
        private readonly IBranchService _branchService;

        public BranchBusiness(IBranchService branchService)
        {
            _branchService = branchService;
        }

        public GetBranchProductModel GetBranchProduct(int currentCode)
        {
            throw new NotImplementedException();
        }

        //public GetBranchProductModel GetBranchProduct(int currentCode)
        //{
        //    var product = _branchService.GetBranchProduct(currentCode);
        //    if (product == null) return null;
        //    return new GetBranchProductModel()
        //    {
        //        PKBranchId = product.PKBranchId,
        //        BranchName = product.BranchName,
        //        CategoryId = product.CategoryId,
        //        CategoryName = product.CategoryName,
        //        CurrentCode = product.CurrentCode,
        //        PKProductId = product.PKProductId,
        //        PKProductVariantId = product.PKProductVariantId,
        //        ProductCode = product.ProductCode,
        //        ProductName = product.ProductName,
        //        ProductVariantCode = product.ProductVariantCode
        //    };
        //}
    }
}
