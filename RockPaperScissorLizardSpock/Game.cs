using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class Game
    {


        List<string> GameActions = new List<string>();

        public void AddToGameActions(GameActions)
        {
            GameActions.Add("rock");
            GameActions.Add("paper");
            GameActions.Add("scissors");
            GameActions.Add("lizard");
            GameActions.Add("spock");
        }
    }
}
