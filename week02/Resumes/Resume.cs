using System;
using Work;

namespace Experience
{
    public class Resume
    {
        public string _name = "";
        public List<Job> _jobs = new List<Job>();


        public void ResumeDetails()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");

            foreach (Job work in _jobs)
            {
                work.DisplayJobDetails();
            }
        }
    }
}