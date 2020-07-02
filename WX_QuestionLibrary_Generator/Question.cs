using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX_QuestionLibrary_Generator
{
    class Question
    {
        //存题目的
        private string question;
        //存选项
        private List<string> choices;
        //存答案
        private List<string> answers;
        public Question(string question){
            this.question = question;
            choices = new List<string>();
            answers = new List<string>();
        }
        public Question(string question, string[] choices, string[] answers) : this(question)
        {
            this.choices.AddRange(choices);
            this.answers.AddRange(answers);
        }
        public Question(string question, List<string> choices, List<string> answers)
        {
            this.question = question;
            this.choices = choices;
            this.answers = answers;
        }
        public string getQuestion()
        {
            return this.question;
        }
        public List<string> getChoices()
        {
            return this.choices;
        }
        public List<string> getAnswers()
        {
            return this.answers;
        }
        private void listCheck() {
            for  (int i = 0; i < choices.Count; i++) {
                if (!choices[i].StartsWith("\"")) {
                    choices[i] = "\"" + choices[i];
                }
                if (!choices[i].EndsWith("\""))
                {
                    choices[i] = choices[i] + "\"";
                }
            }

            for (int i = 0; i < answers.Count; i++)
            {
                if (!answers[i].StartsWith("\""))
                {
                    answers[i] = "\"" + answers[i];
                }
                if (!answers[i].EndsWith("\""))
                {
                    answers[i] = answers[i] + "\"";
                }
            }
        }
        public string ToPerviewString()
        {
            listCheck();
            string c = string.Join(",", choices.ToArray());
            string a = string.Join(",", answers.ToArray());
            return "{\r\n    \"question\": \"" + question + "\",\r\n    \"choices\": [" + c + "],\r\n    \"answers\":[" + a + "]\r\n}";
        }
        public override string ToString()
        {
            listCheck();
            string c = string.Join(",", choices.ToArray());
            string a = string.Join(",", answers.ToArray());
            return "{\"question\": \"" + question + "\",\"choices\": [" + c + "],\"answers\":[" + a + "]}";
        }
    }
}
