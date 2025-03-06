namespace Project.Models
{
    public class Register
    {

        public Guid Id { get; set; }
        public string full_name { get; set; }
        public  int sem { get; set; }
        public int year {  get; set; }
        public string dep { get; set; } 
        public long contact_no {  get; set; }
        public string email { get; set; }

    }
}
