namespace Project.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FileType { get; set; }
        public string FacultyId { get; set; }
        public string Facultyname { get; set; } // Faculty who uploaded it
        public DateTime Deadline { get; set; }
        public int maxmarks {  get; set; }
       

    }

}
