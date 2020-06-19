using MEC;
using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class DelayedRepeater : Repeater
	{
		[SerializeField, TabGroup("Data")] private GameObject _root = null;
		[SerializeField, TabGroup("Data")] private bool _interruptable = false;
		[SerializeField, TabGroup("Data")] private float _delay = 1f;
		[ShowInInspector, ReadOnly, TabGroup("Data")] private bool _isRunning = false;
		[ShowInInspector, ReadOnly, TabGroup("Data")] private int _currentCount = 0;

		private CoroutineHandle _repeatCoroutine = default;

		protected override void Repeat()
		{
			if (_isRunning)
			{
				if (_interruptable)
				{
					Timing.KillCoroutines(_repeatCoroutine);
					_currentCount = 0;
					_isRunning = false;
				}
				else
				{
					return;
				}
			}

			_isRunning = true;
			_repeatCoroutine = Timing.RunCoroutine(ProcessRepeater().CancelWith(_root));
		}

		private IEnumerator<float> ProcessRepeater()
		{
			while (true)
			{
				_reactor.SendReaction();
				_currentCount++;

				if (_currentCount == _count)
				{
					_currentCount = 0;
					_isRunning = false;

					break;
				}

				yield return Timing.WaitForSeconds(_delay);
			}
		}

	}
}
