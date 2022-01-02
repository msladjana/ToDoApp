using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ToDoVM
{
    public class WorkTasksVM : BaseVM
    {
        public ObservableCollection<WorkTaskVM> WorkTaskList { get; set; } = new ObservableCollection<WorkTaskVM>();

        public string NewWorkTaskTitle { get; set; }

        public string NewWorkTaskDescription { get; set; }

        public ICommand AddNewTaskCommand { get; set; }

        public ICommand DeleteSelectedTasksCommand { get; set; }


        public WorkTasksVM()
        {
            AddNewTaskCommand = new RelayCommand(AddNewTask);
            DeleteSelectedTasksCommand = new RelayCommand(DeleteSelectedTasks);
        }
        private void AddNewTask()
        {
            var newTask = new WorkTaskVM
            {
                Title = NewWorkTaskTitle,
                Description = NewWorkTaskDescription,
                CreatedDate = DateTime.Now
            };
            WorkTaskList.Add(newTask);

            NewWorkTaskTitle = string.Empty;
            NewWorkTaskDescription = string.Empty;
        }

        private void DeleteSelectedTasks()
        {
            var selectedTasks = WorkTaskList.Where(x => x.IsSelected).ToList();

            foreach (var task in selectedTasks)
            {
                WorkTaskList.Remove(task);
            }
        }
    }
}
