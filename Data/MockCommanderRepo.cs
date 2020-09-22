using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Comment Bouillir un oeuf", Line="Bouillir de l'eau", Platform="Windows"};
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>{
                new Command{Id=0, HowTo="Comment Bouillir un oeuf", Line="Bouillir de l'eau", Platform="Poêle"},
                new Command{Id=1, HowTo="Comment cuire du riz", Line="Bouillir de l'eau", Platform="Poêle"},
                new Command{Id=2, HowTo="Comment cuire des pâtes", Line="Bouillir de l'eau", Platform="Poêle"}
            };
            return commands;
        }
    }
}