namespace Experiment.EntityFramework.Model
{
    public class Page
    {

        private static int id = 1;

        public Page() {
            this.PageId = Page.id;
            Page.id++;
        }
        public int PageId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        
    }
}