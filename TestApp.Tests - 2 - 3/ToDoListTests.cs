using NUnit.Framework.Interfaces;
using TestApp___2___3.ToDo;


namespace TestApp.Tests___2___3
{
    [TestFixture]
    public class ToDoListTests
    {
        private ToDoList  _toDoList = null!;

        [SetUp]
        public void SetUp()
        {
            this._toDoList = new();
        }

        [Test]
        public void Test_AddTask_TaskAddedToToDoList()
        {
            // Arrange
            string title = "Task1";
            DateTime dueDate = DateTime.Today;
            this._toDoList.AddTask(title, dueDate);

            string expected = $"To-Do List:{Environment.NewLine}[ ] {title} - Due: {dueDate.ToString("MM/dd/yyyy")}";

            //Act
            string result = this._toDoList.DisplayTasks();

            //Act && Assert
            Assert.That(result, Is.EqualTo(expected));
            Assert.That(result, Does.Contain("[ ] Task1 - Due:"));
        }

        [Test]
        public void Test_CompleteTask_TaskMarkedAsCompleted()
        {
            // Arrange
            string title = "Task1";
            DateTime dueDate = DateTime.Today;
            this._toDoList.AddTask(title, dueDate);
            this._toDoList.CompleteTask(title);

            //string expected = $"To-Do List:{Environment.NewLine}{"[✓]"} {title} - Due: {dueDate.ToString("MM/dd/yyyy")}";


            //Act
            string result = this._toDoList.DisplayTasks();

            //Act && Assert
            Assert.That(result, Does.Contain("[✓] Task1 - Due:"));

        }

        [Test]
        public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
        {
            // Arrange
            string title = "Task1";
            DateTime dueDate = DateTime.Today;
            //this._toDoList.AddTask(title, dueDate);
            //this._toDoList.CompleteTask(title);

            //Act && Assert
            Assert.That(() => this._toDoList.CompleteTask(title), Throws.ArgumentException);
        }

        [Test]
        public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
        {
            //Arrange

            //Act
            string result = this._toDoList.DisplayTasks();

            //Assert
            Assert.That(result, Is.EqualTo("To-Do List:"));
        }

        [Test]
        public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
        {
            // Arrange
            string title = "Task1";
            DateTime dueDate = DateTime.Today;

            string title2 = "Task2";
            DateTime dueDates2 = DateTime.Today;

            this._toDoList.AddTask(title, dueDate);
            this._toDoList.AddTask(title2, dueDates2);

            string expected = $"To-Do List:{Environment.NewLine}[ ] {title} - Due: {dueDate.ToString("MM/dd/yyyy")}{Environment.NewLine}[ ] {title2} - Due: {dueDates2.ToString("MM/dd/yyyy")}";

            //Act
            string result = this._toDoList.DisplayTasks();

            //Act && Assert
            Assert.That(result, Is.EqualTo(expected));
            Assert.That(result, Does.Contain("[ ] Task1 - Due:"));
            Assert.That(result, Does.Contain("[ ] Task2 - Due:"));
        }
    }

}