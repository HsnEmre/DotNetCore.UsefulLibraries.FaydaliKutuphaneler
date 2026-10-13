namespace FluentValidation.App.DTO
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string isim { get; set; }

        public string eposta { get; set; }
        public int yaş { get; set; }

        public string FullName { get; set; }
    }
}
