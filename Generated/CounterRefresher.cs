using Sirenix.OdinInspector;
using ToolBox.Utilities;
using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class CounterRefresher : IReactor
	{
		[SerializeField, Required, SceneObjectsOnly] private Counter _counter = null;

		public void HandleReaction() =>
			_counter.Refresh();
	}
}
