namespace VideoLesson_5
{
    public abstract class PageBase
    {
        protected abstract void RenderPage();
    }

    public abstract class MainPageBase : PageBase
    {
        protected override sealed void RenderPage();
        {
            RenderHeader();
            RenderBody();
            RenderFooter();
        }

        protected abstract void RenderHeader();
        protected abstract void RenderBody();
        protected abstract void RenderFooter();
    }
}