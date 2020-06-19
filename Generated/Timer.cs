using MEC;
using Sirenix.OdinInspector;
using System.Collections.Generic;
using ToolBox.Utilities;
using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class Timer : IReactor
	{
		[SerializeField, Required, ChildGameObjectsOnly, TabGroup("Setup")] private GameObject _root = null;
		[SerializeField, TabGroup("Setup")] private RangeFloat _possibleTime = default;
		[SerializeField, TabGroup("Setup")] private bool _interruptable = false;
		[ShowInInspector, ReadOnly, TabGroup("Setup")] private bool _running = false;

		[SerializeField, TabGroup("Reactor")] private Reactor _onTimeElapsed = null;

		private CoroutineHandle _timerCoroutine = default;

		public void HandleReaction()
		{
			if (_running)
			{
				if (_interruptable)
					Timing.KillCoroutines(_timerCoroutine);
				else
					return;
			}

			_timerCoroutine = Timing.RunCoroutine(ProcessTimer().CancelWith(_root));
			_running = true;
		}

		private IEnumerator<float> ProcessTimer()
		{
			yield return Timing.WaitForSeconds(_possibleTime.Value);

			_onTimeElapsed.SendReaction();
			_running = false;
		}		
	}
}
