using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Player;

namespace RESTAPI_Football.managers
{
    public class ManageFootball : IManageFootballers

    {
    private static List<FootballPlayer> _data = new List<FootballPlayer>()
    {
        new FootballPlayer(1, "Jakobsen", 20000, 10),
        new FootballPlayer(2, "Eriksen", 30000, 20)
    };

    public ManageFootball()
    {

    }
        public bool Create(FootballPlayer footballPlayer)
        {
            _data.Add(footballPlayer);
            return true;
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer f = Get(id);
            _data.Remove(f);
            return f;
        }

        public IEnumerable<FootballPlayer> Get()
        {
            return new List<FootballPlayer>(_data);
        }

        public FootballPlayer Get(int id)
        {
            if (_data.Exists(i => i.Id == id))
            {
                return _data.Find(p => p.Id == id);
            }

            throw new KeyNotFoundException();
        }

        public IEnumerable<FootballPlayer> GetName(string name)
        {
            return _data.FindAll(p => p.Name.StartsWith(name));
        }

        public bool Update(int id, FootballPlayer footballPlayer)
        {
            footballPlayer.Id = id;
            _data[id] = footballPlayer;
            return true;
        }
    }
}
