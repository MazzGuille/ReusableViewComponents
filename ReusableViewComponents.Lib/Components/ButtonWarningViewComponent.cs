using Microsoft.AspNetCore.Mvc;
using ReusableViewComponents.Lib.Models;

namespace ReusableViewComponents.Lib.Components;
public class ButtonWarningViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(ButtonModel model)
    {
        return View(model);
    }
}
