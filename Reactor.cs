using Sirenix.OdinInspector;
using UnityEngine;

namespace ToolBox.Reactors
{
	[System.Serializable]
	public class Reactor
	{
		[SerializeReference] private IReactor[] _reactors = null;

		[Button]
		public void SendReaction()
		{
			for (int i = 0; i < _reactors.Length; i++)
				_reactors[i].HandleReaction();
		}
	}

	[System.Serializable]
	public class Reactor<T, R> where R : IReactor<T>
	{
		[SerializeReference] private R[] _reactors = null;

		[Button]
		public void SendReaction(T value)
		{
			for (int i = 0; i < _reactors.Length; i++)
				_reactors[i].HandleReaction(value);
		}
	}
}
