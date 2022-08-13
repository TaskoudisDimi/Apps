using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Person
    {

        //public ICar _car;

        private Car _car;

        //Το Car  είναι το dependency
        //Μπορρώ να περάσω στο Person οποιοδήποτε τύπο της Car class.
        //Το dependency στη class Person είναι το interface ICar το οποίο δημιουργεί ένα layer abstraction
        //public Person(ICar car)
        //{
        //    _car = car;
        //}

        public Person(Car car)
        {
            _car = car;
        }

        public void Drive()
        {
            _car.TurnOff();


        }

    }
}
