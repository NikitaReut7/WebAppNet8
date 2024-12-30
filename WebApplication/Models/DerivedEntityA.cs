namespace WebApp.Models
{

    public class DerivedEntityA : BaseEntity
    {
        public string PropertyA { get; set; }
        public Point? Point { get; set; }

        public Money Money { get; set; }
    }
}
