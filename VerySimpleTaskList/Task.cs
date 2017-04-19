using System;

namespace VerySimpleTaskList
{
    public class Task
    {
        public Task(string description)
        {
            _description = description;
            _priority = 1;
            _completed = false;
        }

        public void SetPriority(int priority)
        {
            if (priority >= 1 && priority <= 5)
            {
                _priority = priority;
            }
        }

        public void MarkCompleted()
        {
            _completed = true;
        }

        public virtual string DescribeYourself()
        {
                        // This is called "string interpolation"
            string me = $"I am a task to {_description} with priority {_priority}";
            if (_completed)
            {
                me += " and I am done";
            }
            else
            {
                me += " and I am not done";
            }
            return me;
        }

        private string _description;
        private int _priority;
        private DateTime _dueDate;
        private bool _completed;
    }
}
