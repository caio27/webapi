using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boild an egg", Line="Boil water", Platform="kettle & Pan"},
                new Command{Id=0, HowTo="Cut Bread", Line="Get a knife", Platform="knife & chopping board"},
                new Command{Id=0, HowTo="Make a cup of tea", Line="Place teabag in cup", Platform="kettle & cup"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boild an egg", Line="Boil water", Platform="kettle & Pan"};
        }
    }
}