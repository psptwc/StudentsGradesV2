﻿namespace StudentsGrades.Models
{
    public class Grade
    {
        public Guid GradeId { get; set; }
        public int GradeGot {  get; set; }
        public DateTime DateTime { get; set; }

        // Id's for referencing to objects
        public Guid StudentId { get; set; }
        public Guid SubjectId { get; set; }

        public Student? Student { get; set; }
        public Subject? Subject { get; set; }

        public Grade() { }

        public Grade(int gradeGot, Guid studentId, Guid subjectId)
        {
            GradeId = Guid.NewGuid();
            GradeGot = gradeGot;
            DateTime = DateTime.UtcNow;
            StudentId = studentId;
            SubjectId = subjectId;
        }
    }
}
