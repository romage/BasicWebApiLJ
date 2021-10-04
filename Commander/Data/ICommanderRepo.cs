using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateItem(Command cmd);
        void UpdateCommand(Command com);
        void DeleteCommand(Command cmd);
    }
}