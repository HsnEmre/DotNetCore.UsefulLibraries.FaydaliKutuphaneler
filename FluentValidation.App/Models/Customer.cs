namespace FluentValidation.App.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Mail { get; set; }
        public int Age { get; set; }


        public DateTime? BirthDate { get; set; }


        public IList<Address> Address { get; set; }
        public Gender Gender { get; set; }

        public string GetFullname()
        {
            return $"{Name}-{Mail}-{Age}";
        }
    }
}
