//LinqTasksConsoleApp

using LinqTasksConsoleApp;

var tasks = new List<TaskItem>
{
    new TaskItem(1, "Buy groceries", true),
    new TaskItem(2, "Clean the house", false),
    new TaskItem(3, "Pay bills", true),
    new TaskItem(4, "Study LINQ", false),
    new TaskItem(5, "Exercise", true)
};

Console.WriteLine("Wszystkie elementy kolekcji:");
foreach (var task in tasks)
{
    Console.WriteLine(task);
}

//Zadanie 0: Wyszukaj wszystkie nazwy zadań
/*
select Name
from tasks
*/
Console.WriteLine("Zadanie 0");
List<string> names = tasks.Select(t => t.Name).ToList();
foreach (var name in names)
    Console.WriteLine(name);

//Zadanie 0.1: Wyszukaj wszystkie nazwy zadań oraz ich długość
Console.WriteLine("Zadanie 0.1");
/*
select Name, Length(Name), IsCompleted
from tasks
*/

//Wersja 1
/*
List<TaskName> taskNames = tasks.Select(t => new TaskName() { Name = t.Name, Length = t.Name.Length }).ToList();
foreach (TaskName taskName in taskNames)
{
    Console.WriteLine($"{taskName.Name} {taskName.Length}");
}
*/
//Wersja 2
var taskNames = tasks.Select(t => new { Name = t.Name, Length = t.Name.Length });
foreach (var taskName in taskNames)
{
    Console.WriteLine($"{taskName.Name} {taskName.Length}");
}

// Zadanie 1: Wyszukaj wszystkie zakończone zadania
/*
select *
from tasks
where IsCompleted == true
*/
Console.WriteLine("Zadanie 1");
List<TaskItem> allCompletedTasks = tasks.Where(t => t.IsCompleted == true).ToList();
foreach (var task in allCompletedTasks)
{
    Console.WriteLine(task);
}

// Zadanie 2: Znajdź pierwsze zadanie, które nie jest zakończone
/*
select *
from tasks
where IsCompleted == false
limit 1
*/
Console.WriteLine("Zadanie 2");
//TaskItem firstCompletedTask = tasks.Where(t => t.IsCompleted == false).First();
TaskItem firstCompletedTask = tasks.First(t => t.IsCompleted == false);
Console.WriteLine(firstCompletedTask);

// Zadanie 3: Posortuj zadania według nazwy

// Zadanie 4: Policz zadania zakończone

// Zadanie 5: Wybierz tylko nazwy zadań i wyświetl

// Zadanie 6: Znalezienie nazw zakończonych zadań posortowanych według długości nazwy

//Zadanie 7: Zadania pogrupowane według stanu zakończenia, a następnie posortowane w grupach według nazwy
Console.WriteLine("Zadanie 7");
/*
var x = tasks.GroupBy(t => t.IsCompleted)
    .Select(g => new NewGroup() { IsCompleted = g.Key, 
                                  Items = g.OrderBy(t => t.Name)
                                           .ToList()});

foreach(NewGroup newGroup in x)
{
    Console.WriteLine(newGroup.IsCompleted);
    foreach (TaskItem taskItem in newGroup.Items)
    {
        Console.WriteLine(taskItem);
    }
}
class NewGroup
{
    public bool IsCompleted { get; set; }
    public List<TaskItem> Items { get; set; }
}
*/

//Zadanie 8: Najkrótsza nazwa zadania niezakończonego
Console.WriteLine("Zadanie 8");
var shortestName = tasks.Where(t => t.IsCompleted == false).OrderBy(t => t.Name.Length).First().Name;
Console.WriteLine(shortestName);

//Zadanie 9: Ilość liter w nazwach wszystkich zakończonych zadań
Console.WriteLine("Zadanie 9");
var numberOfLetters = tasks
    .Where(t => t.IsCompleted)
    .Sum(t => t.Name
               .Where(c => (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')).Count());
Console.WriteLine(numberOfLetters);

//Zadanie 10: Lista zadań z indeksami (zakończone zadania z numeracją)
Console.WriteLine("Zadanie 10");
/*
var complitedTasks = tasks.Where(t => t.IsCompleted);
for (int i = 0; i< complitedTasks.Count(); i++)
{
    Console.WriteLine($"{i+1}:");
    Console.WriteLine(complitedTasks.ElementAt(i));
}
*/

var complitedTasksWidthIndex = tasks
    .Where(t => t.IsCompleted)
    .Select((t, index) => new { Index = index + 1, TaskItem = t });

foreach (var item in complitedTasksWidthIndex)
{
    Console.WriteLine($"{item.Index}:");
    Console.WriteLine(item.TaskItem);
}

//Zadanie 11: Zadania z najdłuższą nazwą w każdej grupie zakończonych i niezakończonych

//Zadanie 12: Zlicz, ile zadań w każdej grupie zakończonych i niezakończonych zawiera słowo „the” w nazwie
Console.WriteLine("Zadanie 12");

var x = tasks
    .GroupBy(t => t.IsCompleted)
    .Select(g => new { GrouopValue = g.Key, Count = g.Where(t => t.Name.Contains("the")).Count() });

foreach (var item in x)
{
    Console.WriteLine($"{item.GrouopValue}:");
    Console.WriteLine(item.Count);
}


//Zadanie 13: Utwórz listę zakończonych zadań z ich numeracją oraz długością nazw

//Zadanie 14: Zadania posortowane według stanu zakończenia, a następnie alfabetycznie według nazw

//Zadanie 15: Sprawdź, czy w nazwach wszystkich zadań są co najmniej 2 różne samogłoski
Console.WriteLine("Zadanie 15");

bool isTrue = tasks.All(t => t.Name.ToLower().Where(c => "aeiouy".Contains(c)).Distinct().Count() >= 2);
Console.WriteLine(isTrue);

//Zadanie 16: Znajdź wszystkie unikalne litery używane w nazwach zadań zakończonych

class TaskName
{
    public string Name { get; set; }
    public int Length { get; set; }
}