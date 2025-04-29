namespace Project.Models
{
    public class StudentAssShow
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string FileType { get; set; } = string.Empty;
        public string FacultyId { get; set; } = string.Empty;
        public string Facultyname { get; set; } = string.Empty;
        public DateTime Deadline { get; set; }
        public int maxmarks { get; set; }
    //        // New property for the assignment link
    //public string? AssignmentLink { get; set; }

    }
}
