using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateItem(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id=0, HowTo="Boil and egg", Line="Boil water", Platform="Cooking" },
                new Command { Id=1, HowTo="Cut bread", Line="Saw Knife", Platform="Cooking" },
                new Command { Id=2, HowTo="Make tea", Line="tea bag into teapot", Platform="Cooking" }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id=0, HowTo="Boil and egg", Line="Boil water", Platform="Cooking" };
        }

        public void UpdateCommand(Command com)
        {
            throw new System.NotImplementedException();
        }

        bool ICommanderRepo.SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}