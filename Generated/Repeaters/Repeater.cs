using Sirenix.OdinInspector;
using UnityEngine;

namespace ToolBox.Reactors
{
	public abstract class Repeater : IReactor, ISetupable
	{
		[SerializeField, TabGroup("Setup")] protected int _count = 3;
		[SerializeField, TabGroup("Setup")] protected Reactor _reactor = null;

		public void Setup() =>
			_reactor.Setup();

		public void HandleReaction() =>
			Repeat();

		protected abstract void Repeat();
	}
}
