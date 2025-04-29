using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Submission
    {

        public int Id { get; set; }
        public string SubmittedBy { get; set; } = string.Empty;
        public string SubjectName { get; set; } = string.Empty;

        public string SubmissionLink { get; set; } = string.Empty;

        public DateTime SubmittedAt { get; set; }

    }
}
