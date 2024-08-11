using Microsoft.AspNetCore.Mvc;
using ReusableViewComponents.Lib.Models;

namespace ReusableViewComponents.Lib.Components;
public class ButtonCancelViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(ButtonModel model)
    {
        return View(model);
    }
}
