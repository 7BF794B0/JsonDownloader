using JsonDownloader.Implementations;
using JsonDownloader.Interfaces;

namespace JsonDownloader.Factories
{
    class ClassCreatorFactory
    {
		private static readonly ClassCreatorFactory _instance = new ClassCreatorFactory();

		public static ClassCreatorFactory GetInstance()
		{
			return _instance;
		}

		public IClassCreator CreateClassCreator()
		{
			IClassCreator classCreator = new ClassCreatorImplementation();
			return classCreator;
		}
	}
}
