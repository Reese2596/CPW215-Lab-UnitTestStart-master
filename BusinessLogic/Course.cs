﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        String defaultInstructName = "STAFF";
        private byte numberOfCredits;
        private string courseName;

        public Course(string courseName)
        {
            CourseName = courseName;
            InstructorName = defaultInstructName;
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName { get; set; }

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName 
        { 
            get => courseName;
            set 
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    courseName = value;
                    
                }
                else
                {
                    throw new ArgumentNullException();
                };
            } 
        }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits
        {
            get => numberOfCredits;
            set
            {
                if (value < 30 && value > 0)
                {
                    numberOfCredits = value;
                }
                else
                {
                    throw new ArgumentException();
                };
            }
        }

    }
}
