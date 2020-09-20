namespace HelloWorld.Models
{
    using System.Collections.Generic;

    public class ContactGroup : List<Contact>
    {
        public ContactGroup(string title, string shortTitle)
        {
            this.Title = title;
            this.ShortTitle = shortTitle;
        }

        public string Title { get; set; }
        public string ShortTitle { get; set; }
    }
}
