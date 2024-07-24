using Nop.Web.Framework.Models;

namespace Nop.Web.Models.Common;

public partial record LogoWithRandomModel : BaseNopModel
{
    public string StoreName { get; set; }

    public string LogoPath { get; set; }

    public string[] LogoArray { get; set; }
    public string LogoArrayPath { get; set; }
}