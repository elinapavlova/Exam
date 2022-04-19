using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class TaskListTest
    {
        [TestMethod]
        public void GetNameTest()
        {
            string exp_name = "new";
            TaskList taskList = new TaskList(exp_name);

            string act_name = taskList.GetName();
            Assert.AreEqual(exp_name, act_name);
        }

        [TestMethod]
        public void GetTasksTest()
        {
            List<Task> exp_tasks = null;
            TaskList taskList = new TaskList("new");

            List<Task> act_tasks = taskList.GetTasks();
            Assert.AreEqual(exp_tasks, act_tasks);
        }
    }
}
