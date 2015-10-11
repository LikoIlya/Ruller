// Ilya Likhoshva
// Ruler
// Tests.cs
// 09.10.2015

using System;
using System.Collections.Generic;
using System.Xml;
using System.Drawing;
using System.Drawing.Text;
using System.Reflection.Emit;
using System.Threading;

namespace Ruler
{
    [Serializable]
    class Answer
    {
        public bool correct;
        public string answer;
        public Answer(string answer, bool correct)
        {
            this.answer = answer;
            this.correct = correct;
        }
    }
    [Serializable]
    class Question
    {
        string quetion;
        List<Answer> answers;
        public Question(string quetion, List<Answer> answers)
        {
            this.quetion = quetion;
            this.answers = answers;
            this.answers.Shuffle();
        }
        public bool Answer(int number)
        {
            return answers[number].correct;
        }
        public string GetQuestion()
        { return quetion; }
        public List<string> GetAnswers()
        {
            List<string> s = new List<string>();
            foreach (Answer answer in answers)
                s.Add(answer.answer);
            return s;
        }
    }

    class Tests
    {
        List<Question> questions = new List<Question>();
        public Tests(string xmlQuetions)
        {
            xmlQuetions = "Questions.xml";
            XmlDocument Questions = new XmlDocument();
            Questions.Load(xmlQuetions);
            foreach (XmlNode node in Questions.GetElementsByTagName("Questions"))
            {
                List<Answer> answers = new List<Answer>();
                foreach (XmlNode nodeansw in node.SelectNodes("Answers"))
                    answers.Add(new Answer(nodeansw.FirstChild.FirstChild.Value, nodeansw.LastChild.FirstChild.Value == "1"));
                questions.Add(new Question(node.FirstChild.FirstChild.Value, answers));
            }
            questions.Shuffle();
        }
        public List<Question> GetQuestions()
        {
            return questions;
        }
    }



}
public static class ThreadSafeRandom
{
    [ThreadStatic]
    private static Random Local;

    public static Random ThisThreadsRandom
    {
        get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
    }
}
static class AddList
{
    public static void Shuffle<T>(this IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}