using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleDatabaseMauiApp.Model
{
    public class Person : BindableObject
    {
        public int Id { get; set; }

        private string name;

        public string Name { get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        private string surname;

        public string Surname { get => surname; 
            set {
                surname = value;
                OnPropertyChanged();
            }
        }

        private int age;
        public int Age
        {
            get => age;
            set
            {
                age = value;
                OnPropertyChanged();
            }
        }
    }
}
