using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuget
{
    [Serializable]
public class Task
{
   public string Title{get;set;}
   public string Description{get;set;}
   public DateTime DueBy{get;set;}
}

[Serializable]
public class TaskModel : LiveDomain.Core.Model
{
   public List<Task> Tasks{get;set;}
   public TaskModel() { Tasks = new List<Task>(); }
}

//[Serializable]
//public class AddTaskCommand : LiveDomain.Core.Command<TaskModel>
//{
//   public string Title{get;set;}
//   public string Description{get;set;}
//   public DateTime DueBy{get;set;}

//   ///Set by prepare, dont serialize to command journal. Saves space
//   [NonSerialized]
//   private Task _task;

   //public void override Prepare(TaskModel model)
   //{
   //   // You are allowed to read the model during prepare. 
   //   // Do validation to ensure execution wont fail and do as 
   //   // much processing as possible to keep execute as short as possible
   //   if (model => model.Tasks.Count(task => task.Title == Title) > 0)
   //   {
   //      throw new ArgumentException("Task title already exists", "Title");
   //   }

   //   _task = new Task{ Title = Title, Description = Description, DueBy = DueBy };
   //}
   //public void overide Execute(TaskModel model)
   //{
   //   model.Tasks.Add(_task);
   //}
}



