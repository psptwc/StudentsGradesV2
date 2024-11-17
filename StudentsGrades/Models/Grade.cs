﻿using System.Text.Json.Serialization;

namespace StudentsGrades.Models
{
    public class Grade
    {
        public Guid GradeId { get; set; }
        public int GradeGot {  get; set; }
        public DateTime DateTime { get; set; }

        public Guid StudentId { get; set; }
        public Guid SubjectId { get; set; }

        //[JsonIgnore]
        public Student Student { get; set; } = null!;
        //[JsonIgnore]
        public Subject Subject { get; set; } = null!;

        public Grade() { }

        public Grade(int gradeGot, Guid studentId, Guid subjectId)
        {
            GradeId = Guid.NewGuid();
            GradeGot = gradeGot;
            //DateTime = DateTime.Now;
            StudentId = studentId;
            SubjectId = subjectId;
        }
    }
}