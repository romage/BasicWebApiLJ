using System;
using System.Collections.Generic;
using System.Linq;
using Commander.Models;

namespace Commander.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            this._context = context;
        }

        public void CreateItem(Command cmd)
        {
            if(cmd == null)
                throw new ArgumentException();
            _context.Commands.Add(cmd);
        }

        public void DeleteCommand(Command cmd)
        {
            if(cmd == null)
                throw new ArgumentException();
            _context.Commands.Remove(cmd);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands;
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(s=> s.Id == id);
        }

       
        public bool SaveChanges()
        {
            return _context.SaveChanges()>0? true: false;
        }

        public void UpdateCommand(Command com)
        {
            // do nothing...
        }
    }
}