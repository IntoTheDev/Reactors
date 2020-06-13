using Sirenix.OdinInspector;
using UnityEngine;

namespace ToolBox.Reactors
{
	[System.Serializable]
	public class Reactor
	{
		[SerializeReference] private IReactor[] reactors = null;

		[Button]
		public void SendReaction()
		{
			for (int i = 0; i < reactors.Length; i++)
				reactors[i].HandleReaction();
		}
	}

	[System.Serializable]
	public class Reactor<T, R> where R : IReactor<T>
	{
		[SerializeReference] private R[] reactors = null;

		[Button]
		public void SendReaction(T value)
		{
			for (int i = 0; i < reactors.Length; i++)
				reactors[i].HandleReaction(value);
		}
	}
}
