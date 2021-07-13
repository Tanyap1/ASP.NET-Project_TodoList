namespace ToDoList.Models
{
    public class ListBase
    {
        private string task;

        public string GetTask()
        {
            return task;
        }

        public void SetTask(string value)
        {
            task = value;
        }

        public Task Task { get; set; }

        //fk
        public int TaskId { get; set; }
    }
}