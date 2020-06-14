using Sirenix.OdinInspector;
using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class ReactorDispatcher : IReactor
	{
		[SerializeField, Required, SceneObjectsOnly] private ReactorComponent _reactorComponent = null;
		[SerializeField] private int _index = 0;

		public void HandleReaction() =>
			_reactorComponent.Dispatch(_index);
	}
}
