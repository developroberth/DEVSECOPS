namespace DEVSECOPS.API.Models
{
    public class BeanModel
    {
        public int beanId { get; set; }
        public List<string> groupName { get; set; }
        public List<string> ingredients { get; set; }
        public string flavorName { get; set; }
        public string description { get; set; }
        public string colorGroup { get; set; }
        public string backgroundColor { get; set; }
        public string imageUrl { get; set; }
        public bool glutenFree { get; set; }
        public bool sugarFree { get; set; }
        public bool seasonal { get; set; }
        public bool kosher { get; set; }
    }
}
