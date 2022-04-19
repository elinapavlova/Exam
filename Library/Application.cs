using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class Application
    {
        public static Application application { get; set; }
        public List<TaskList> taskLists { get; set; }

        private Application()
        {
            taskLists = new List<TaskList>();
        }

        /// <summary>
        /// Получение экземпляра приложения
        /// </summary>
        /// <returns></returns>
        public Application GetApplication()
        {
            if (application == null)
            {
                return new Application();
            }

            return application;
        }

        /// <summary>
        /// Создание списка задач
        /// </summary>
        /// <param name="name">Имя списка задач</param>
        public void CreateTaskList(string name)
        {
            taskLists.Add(new TaskList(name));
        }

        /// <summary>
        /// Получение списка имен списков задач
        /// </summary>
        /// <returns></returns>
        public List<string> GetTaskListNames()
        {
            List<string> names = taskLists.Select(t => t.GetName()).ToList();
            return names;
        }

        /// <summary>
        ///  Получение списка задач по имени
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public TaskList GetTaskListByName(string name)
        {
            TaskList taskList = taskLists.FirstOrDefault(t => t.GetName() == name);
            return taskList;
        }

        /// <summary>
        /// Получение сегодняшних задач
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasksByToday()
        {
            List<Task> tasks = new List<Task>();

            foreach(TaskList taskList in taskLists)
            {
                tasks.AddRange(taskList.GetTasksByToday());
            }

            return tasks;
        }

        /// <summary>
        /// Получение будущих задач
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasksByFuture()
        {
            List<Task> tasks = new List<Task>();

            foreach (TaskList taskList in taskLists)
            {
                tasks.AddRange(taskList.GetTasksByFuture());
            }

            return tasks;
        }
    }
}
