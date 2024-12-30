namespace WebApp.Models
{

    public class DerivedEntityC : BaseEntity
    {
        public Point? Point { get; set; }
        public Money Money { get; set; }

        public string PropertyC { get; set; }
    }
}
