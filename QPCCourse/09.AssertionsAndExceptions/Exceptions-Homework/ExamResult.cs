using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("Grade can't be a negative number.");
        }

        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("minGrade can't be a negative number.");
        }

        if (maxGrade <= minGrade)
        {
            throw new ArgumentOutOfRangeException("minGrade must be smaller than maxGrade.");
        }

        if (String.IsNullOrEmpty(comments))
        {
            throw new ArgumentNullException("comments can't be null or whitespace.");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
