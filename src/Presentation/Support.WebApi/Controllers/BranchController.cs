using Mapster;
using Microsoft.AspNetCore.Mvc;
using Support.Application.Business.Abstracts;
using Support.Application.Business.Concretes;
using Support.WebApi.Models;

namespace Support.WebApi.Controllers
{
    [Route("api/v1/branches")]
    public class BranchController : Controller
    {
        private readonly IBranchBusiness _branchBusiness;

        public BranchController(IBranchBusiness branchBusiness)
        {
            _branchBusiness = branchBusiness;
        }
        public ViewResult GetBranchProductByCurrentCodePage()
        {
            return View();
        }

        [HttpGet("{currentCode}")]
        public ViewResult GetBranchProductByCurrentCode([FromRoute] int currentCode)
        {
            var product = _branchBusiness.GetBranchProduct(currentCode);
            return View(product.Adapt<GetBranchProductViewModel>());
        }
    }
}
