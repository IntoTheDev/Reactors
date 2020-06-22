using Sirenix.OdinInspector;
using UnityEngine;

namespace ToolBox.Reactors
{
	[System.Serializable]
	public class Reactor : ISetupable
	{
		[SerializeReference, ListDrawerSettings(Expanded = true)] private IReactor[] _reactors = null;

		[Button, ButtonGroup]
		public void Setup()
		{
			for (int i = 0; i < _reactors.Length; i++)
			{
				ISetupable setupable = _reactors[i] as ISetupable;
				setupable?.Setup();
			}
		}

		[Button, ButtonGroup]
		public void SendReaction()
		{
			for (int i = 0; i < _reactors.Length; i++)
				_reactors[i].HandleReaction();
		}
	}

	[System.Serializable]
	public class Reactor<T, R> : ISetupable where R : IReactor<T>
	{
		[SerializeReference, ListDrawerSettings(Expanded = true)] private R[] _reactors = null;

		[Button, ButtonGroup]
		public void Setup()
		{
			for (int i = 0; i < _reactors.Length; i++)
			{
				ISetupable setupable = _reactors[i] as ISetupable;
				setupable?.Setup();
			}
		}

		[Button, ButtonGroup]
		public void SendReaction(T value)
		{
			for (int i = 0; i < _reactors.Length; i++)
				_reactors[i].HandleReaction(value);
		}
	}
}
