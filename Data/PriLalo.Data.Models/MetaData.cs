namespace PriLalo.Data.Models
{
    using PriLalo.Data.Common.Models;

    public class MetaData : BaseDeletableModel<int>
    {
        public string UserId { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public bool IsActive { get; set; }
    }
}
