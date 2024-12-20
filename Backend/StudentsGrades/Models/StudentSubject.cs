﻿using System.Text.Json.Serialization;

namespace StudentsGrades.Models
{
    /*
     * The StudentSubject class exists to resolve
     * many to many relation between Student and Subject classes
     */
    public class StudentSubject
    {
        public Guid StudentId { get; }
        public Guid SubjectId { get; }

        [JsonIgnore]
        public Student? Student { get; set; }
        [JsonIgnore]
        public Subject? Subject { get; set; }

        public StudentSubject(Guid studentId, Guid subjectId)
        {
            StudentId = studentId;
            SubjectId = subjectId;
        }
    }
}
