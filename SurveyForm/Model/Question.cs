using System;

namespace Model
{
    //Question details
    public class Question
    {
        public int QuestionID;
        public int SectionID;
        public string Description;
        public int OptionGroupID;
    }
    //record answers of questions
    public class Survey
    {
        public int SurveyID;
        public string Answers;
        public int QuestionID;
        public int TrainingID;
    }
    //Training details
    public class TrainingProgram
    {
        public int TrainingID;
        public string TrainingName;
        public string Trainer;
        public DateTime Date;
        public string Venue;
        public string Attendees;

    }
    //user details
    public class UserTable
    {
        public int UserId;
        public string UserName;
    }

    public class Admin
    {
        public string UserName;
        public string Password;
    }



}

