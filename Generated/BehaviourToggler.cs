using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class BehaviourToggler : IReactor
	{
		[SerializeField] private Behaviour[] _behaivoursToEnable = null;
		[SerializeField] private Behaviour[] _behaivoursToDisable = null;

		public void HandleReaction()
		{
			for (int i = 0; i < _behaivoursToDisable.Length; i++)
				_behaivoursToEnable[i].enabled = true;

			for (int i = 0; i < _behaivoursToDisable.Length; i++)
				_behaivoursToDisable[i].enabled = false;
		}
	}
}
