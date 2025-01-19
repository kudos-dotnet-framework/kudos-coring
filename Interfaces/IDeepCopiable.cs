using System;
namespace Kudos.Coring.Interfaces
{
	public interface IDeepCopiable<T>
	{
		public T DeepCopy();
	}
}

