using Microsoft.EntityFrameworkCore;
using PeopleRepositoryClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleRepositoryClassLibrary
{

    /*
    * Pobierz osoby o wieku wiêkszym ni¿ 30 lat.
    * Pobierz osoby, których nazwisko zaczyna siê na „K”.
    * ZnajdŸ osoby z najmniejszym wiekiem.
    * Policz, ile osób jest w tabeli.
    * Zwróæ wszystkie unikalne imiona.
    * Zmieñ nazwisko wszystkich osób o nazwisku „Kowalski” na „Kowal”.
    * Dodaj wszystkim osobom 1 rok (symulacja urodzin).
    * Usuñ wszystkich, którzy maj¹ wiêcej ni¿ 80 lat.
    *  ZnajdŸ najstarsz¹ osobê i zmieñ jej nazwisko na „Najstarszy”.
    * Usuñ osoby m³odsze ni¿ œrednia wieku.
    * Zmieñ imiona na wersjê „WIELKIMI LITERAMI”.
    

    */
    public class PeopleRepository
    {
        private PeopleDBContext context;

        public PeopleRepository()
        {
            context = new PeopleDBContext();
        }

        //CRUD

        //C - create

        public void AddNewPerson(string name, string surname, int age)
        {
            Person newPerson = new Person() { Name = name, Surname = surname, Age = age };

            context.People.Add(newPerson);

            context.SaveChanges();
        }

        //R- read

        /*
        select *
        from people4e2026.people
        order by name, surname;
        */

        public List<Person> GetAllPeople()
        {
            return context.People
                .AsNoTracking()
                .OrderBy(p => p.Name)
                .ThenBy(p => p.Surname)
                .ToList();
        }

        //U - update

        public void UpdateName(int id, string newName)
        {
            Person? personToUpdate = context.People.FirstOrDefault(p => p.Id == id);

            if (personToUpdate != null)
            {
                personToUpdate.Name = newName;

                context.SaveChanges();
            }
        }

        //D - delete

        public void DeletePerson(int id)
        {
            Person? personToDelete = context.People.FirstOrDefault(p => p.Id == id);

            if (personToDelete != null)
            {
                context.People.Remove(personToDelete);

                context.SaveChanges();
            }
        }
    }
}
