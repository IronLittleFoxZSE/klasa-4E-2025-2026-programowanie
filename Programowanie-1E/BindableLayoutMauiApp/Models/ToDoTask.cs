using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindableLayoutMauiApp.Models
{
    public class ToDoTask : BindableObject
    {
        public string Title { get; set; }

        private bool isComplited;
        public bool IsComplited
        {
            get { return isComplited; }
            set { isComplited = value; OnPropertyChanged(); }
        }

        public int Column { get; set; }
        public int Row { get; set; }

    }
}
