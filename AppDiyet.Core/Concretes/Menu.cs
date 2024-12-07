using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using AppDiyet.Core.Abstract;

namespace AppDiyet.Core.Concretes
{
    public class Menu : BaseEntity
    {
        public string Name { get; set; }
        public double CurrentWeight{ get; set; }
        public double CaloriesTaken { get; set; }
        public double ProteinIntake { get; set; }
        public double CaloriesRemaining { get; set; }
        public double ProteinRemaining { get; set; }
        public double ExcessCalories { get; set; }

    }
}
