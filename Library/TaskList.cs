using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class TaskList
    {
        private string _name { get; set; }
        private List<Task> _tasks { get; set; }

        public TaskList(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Получение имени списка задач
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return _name;
        }

        /// <summary>
        /// Добаление задачи
        /// </summary>
        /// <param name="task">Имя задачи</param>
        public void AddTask(Task task)
        {
            _tasks.Add(task);
        }

        /// <summary>
        /// Получение всех задач
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasks()
        {
            return _tasks;
        }

        /// <summary>
        /// Удаление задачи
        /// </summary>
        /// <param name="task">Имя задачи</param>
        public void Remove(Task task)
        {
            if (_tasks.Contains(task))
            {
                _tasks.Remove(task);
            }
        }

        /// <summary>
        /// Получение сегодняшних задач
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasksByToday()
        {
            List<Task> tasksByToday = _tasks.Where(t => t.Due.ToShortDateString() == DateTime.Now.ToShortDateString()).ToList();
            return tasksByToday;
        }

        /// <summary>
        /// Получение будущих задач
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasksByFuture()
        {
            List<Task> tasksByToday = _tasks.Where(t => t.Due > DateTime.Now).ToList();
            return tasksByToday;
        }
    }
}
