using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorBattles.Shared;

namespace BlazorBattles.Client.Services
{
    public interface IUnitService
    {
        IList<Unit> Units { get; set; } //receive units from service
        IList<UserUnit> MyUnits { get; set; }
        Task AddUnit(int unitId); //method
        Task LoadUnitsAsync();
        Task LoadUserUnitsAsync();
    }
}