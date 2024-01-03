using System;

namespace Creational.Factory
{
    public class DotMatrixPrinter : IPrinter
    {
        #region Constructors.

        public DotMatrixPrinter(string name = "Dot Matrix Printer")
        {
            Name = name;
        }

        #endregion Constructors.

        #region IPrinter Interface Implementation.

        public string Name { get; private set; }

        public void Configure()
        {
            Console.WriteLine(string.Format("Configuring {0}.", Name));
        }

        public void Print()
        {
            Console.WriteLine(string.Format("Printing from {0}.", Name));
        }

        #endregion IPrinter Interface Implementation.
    }
}