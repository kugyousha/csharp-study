﻿using System.Collections;
using System.IO;

namespace Grades
{
    internal interface IGradeTracker : IEnumerable
    {
	    void AddGrade(float grade);
		GradeStatistics ComputeStatistics();
		void WriteGrades(TextWriter destiniation);
        string Name { get; set; }
        event NameChangedDelegate NameChanged;
    }
}