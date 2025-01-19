using System;
namespace Kudos.Coring.Interfaces
{
	public interface IShallowCopiable<T>
	{
		public T ShallowCopy();
	}
}