using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _ScriptUILayoutComponentsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
