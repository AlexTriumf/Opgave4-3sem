using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Player;

namespace RESTAPI_Football.managers
{
    interface IManageFootballers
    {
        IEnumerable<FootballPlayer> Get();
        FootballPlayer Get(int id);
        IEnumerable<FootballPlayer> GetName(string name);
        bool Create(FootballPlayer footballPlayer);
        bool Update(int id, FootballPlayer footballPlayer);
        FootballPlayer Delete(int id);
    }
}
