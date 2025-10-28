using BindableLayoutMauiApp.Models;
using System.Collections.ObjectModel;

namespace BindableLayoutMauiApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<ToDoTask> ToDoTasks { get; set; }

        public string NewTitle { get; set; }

        public MainPage()
        {
            ToDoTasks = new ObservableCollection<ToDoTask>() 
            {
                new ToDoTask(){Title = "Praca domowa", IsComplited = false, Column=0, Row =0},
                new ToDoTask(){Title = "Wyjść z psem", IsComplited = true, Column = 1, Row = 1},
                new ToDoTask(){Title = "Nauka na sprawdzian z matematyki", IsComplited = false, Column=1, Row = 0},
            };
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //ToDoTasks = new List<ToDoTask>();
            ToDoTasks.Add(new ToDoTask() {Title = NewTitle, IsComplited = false});
            //OnPropertyChanged("ToDoTasks");
        }
    }
}
