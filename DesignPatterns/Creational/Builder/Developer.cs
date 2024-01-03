namespace Creational.Builder
{
    public class Developer : IFrameworkDeveloper
    {
        #region Private Variable Declarations.

        private readonly IBuilder _builder;

        #endregion Private Variable Declarations.

        #region IFrameworkDeveloper Interface Implementation.

        public Framework Framework { get; private set; }

        public void BuildFramework()
        {
            _builder.BuildCoreFramework();
            _builder.BuildDatabase();
            _builder.BuildUI();
            _builder.BuildUnitTestFramework();

            Framework = _builder.GetFramework();
        }

        #endregion IFrameworkDeveloper Interface Implementation.

        #region Constructors.

        public Developer(IBuilder builder)
        {
            _builder = builder;
        }

        #endregion Constructors.
    }
}