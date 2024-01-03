﻿namespace Creational.Prototype
{
    public class ConcretePrototype : Prototype
    {
        #region Constructor.

        public ConcretePrototype(int id) : base(id)
        {
        }

        #endregion Constructor.

        #region Public Overrides.

        public override Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
        }

        #endregion Public Overrides.
    }
}