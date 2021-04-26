using System;

namespace WebAPI.Application.Tasks
{
    public class ResultTask : ResultTask<Object>
    {
        public ResultTask() : base()
        {
            this.Value = null;
        }
    }
    public class ResultTask<T>
    {
        public T Value { get; set; }
        public bool ValidOperation { get; set; }
        public string Message { get; set; }

        public ResultTask()
        {
            this.ValidOperation = true;
            this.Message = null;
        }

        public void WithError(string message)
        {
            this.ValidOperation = false;
            this.Message = message;
        }
    }
     
}