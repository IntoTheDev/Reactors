using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class BehaviourToggler : IReactor
	{
		[SerializeField] private Behaviour[] behaivoursToEnable = null;
		[SerializeField] private Behaviour[] behaivoursToDisable = null;

		public void HandleReaction()
		{
			for (int i = 0; i < behaivoursToDisable.Length; i++)
				behaivoursToEnable[i].enabled = true;

			for (int i = 0; i < behaivoursToDisable.Length; i++)
				behaivoursToDisable[i].enabled = false;
		}
	}
}
