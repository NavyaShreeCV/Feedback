using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using DAL;

namespace SurveyForm.Controllers
{
    public class SurveyController : ApiController
    {
        SurveyQuestion allquestions = new SurveyQuestion();

        /// <summary>
        /// to get all the users to populate training dropdown
        /// </summary>
        /// <returns>list of users,List<UserTable></returns>
        [HttpGet]
        public List<UserTable> GetAllUsers()
        {
            List<UserTable> lists = new List<UserTable>();
            lists = SurveyQuestion.GetUsers();
            return lists;
        }

        /// <summary>
        /// fetching questions of particular section
        /// </summary>
        /// <param name="id"></param>
        /// <returns> list of questions,List<Question></returns>
        [HttpGet]
        public List<Question> GetQuestions(int id)
        {
            List<Question> questions = allquestions.GetQuestions(id);
            return questions;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public List<Survey> GetFeedback(int id)
        {
            List<Survey> values = SurveyQuestion.GetAnswers(id);
            return values;
        }

        /// <summary>
        /// fetches training details to display
        /// </summary>
        /// <returns>list of trainingprograms,List<TrainingProgram></returns>
        [HttpGet]
        public List<TrainingProgram> GetTraining()
        {
            List<TrainingProgram> training = allquestions.Training();
            return training;
        }

        /// <summary>
        /// to insert answers into survey table of a particular survey 
        /// </summary>
        /// <param name="surveys"></param>
        [HttpPost]
        public void PostSurvey([FromBody]Survey[] survey)
        {
            allquestions.Survey(survey);
        }

        /// <summary>
        /// to insert training details into TrainingProgram table
        /// </summary>
        /// <param name="training"></param>
        [HttpPost]
        public void PostTraining(TrainingProgram train)
        {
            SurveyQuestion.InsertTraining(train);
        }
        [HttpDelete]
        public void Deletetraining(int id)
        {
            SurveyQuestion.DeleteTraining(id);
        }
        [HttpPut]
        public void Edittraining(TrainingProgram training)
        {
            SurveyQuestion.EditTraining(training);
        }

        [HttpGet]
        public List<Admin> GetAdmin()
        {
          
            List<Admin> user= SurveyQuestion.GetAdmin();
            return user;
        }
    }
}

