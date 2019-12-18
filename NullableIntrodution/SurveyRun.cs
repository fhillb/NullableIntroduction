using System;
using System.Collections.Generic;
using System.Text;

namespace NullableIntrodution
{
    public class SurveyRun
    {
        private List<SurveyQuestion> SurveyQuestions = new List<SurveyQuestion>();

        public void AddQuestion(QuestionType type, string question)
            => AddQuestion(new SurveyQuestion(type, question));

        public void AddQuestion(SurveyQuestion surveyQuestion)
            => SurveyQuestions.Add(surveyQuestion);
    }
}
