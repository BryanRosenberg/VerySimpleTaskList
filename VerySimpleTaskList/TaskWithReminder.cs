using System;

namespace VerySimpleTaskList
{
    public class TaskWithReminder : Task
    {
        public TaskWithReminder(string description, int numberOfHours) 
            : base(description)
        {
            _numberOfHours = numberOfHours;
            _time = DateTime.Now;
        }

        public override string DescribeYourself()
        {
            string parentsDescription = base.DescribeYourself();
            //return $"{parentsDescription} and I will remind you in {_numberOfHours} hour(s).";

            DateTime reminderTime = new DateTime();
            reminderTime = _time.AddHours(_numberOfHours);
            return $"{parentsDescription} and I will remind you at {reminderTime} .";
        }

        private int _numberOfHours;
        private DateTime _time;
    }
}
