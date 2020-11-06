using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorBattles.Shared;
//implementation class service

namespace BlazorBattles.Client.Services
{
    public class UnitService : IUnitService
    {
        public IList<Unit> Units { get; } = new List<Unit> { //mock units
            new Unit { Id = 1, Title = "Knight", Attack = 10, Defense = 10, BananaCost = 100},
            new Unit { Id = 2, Title = "Archer", Attack = 15, Defense = 5, BananaCost = 150},
            new Unit { Id = 3, Title = "Mage", Attack = 20, Defense = 1, BananaCost = 200}
        };

        public IList<UserUnit> MyUnits { get; set; } = new List<UserUnit>(); //the army of the users, add unit method gets the ID of the unit and adds new unit

        public void AddUnit(int unitId)
        {
            Unit unit = Units.First(unit => unit.Id == unitId);
            MyUnits.Add(new UserUnit { UnitId = unit.Id, HitPoints = unit.HitPoints});
        }
    }
}