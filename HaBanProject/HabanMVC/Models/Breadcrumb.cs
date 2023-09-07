namespace HabanMVC.Models
{
    public class Breadcrumb
    {
        public Breadcrumb(string text, string url)
        {
            Text = text;
            Url = url;
        }

        public string Text { get; set; }
        public string Url { get; set; }
    }
}
