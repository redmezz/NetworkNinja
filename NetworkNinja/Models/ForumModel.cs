using System.Collections.Generic;

namespace NetworkNinja.Models
{
    public class ForumModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<SubForumModel> SubForum { get; set; }
    }
}
