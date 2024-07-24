using Microsoft.AspNetCore.Mvc;
using Nop.Web.Factories;
using Nop.Web.Framework.Components;

namespace Nop.Web.Components
{
    public class LogoWithRandomViewComponent : NopViewComponent
    {
        private readonly ICommonModelFactory _commonModelFactory;

        public LogoWithRandomViewComponent(ICommonModelFactory commonModelFactory)
        {
            _commonModelFactory = commonModelFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _commonModelFactory.PrepareLogoWithRandomModelAsync();
            return View(model);
        }
    }
}
