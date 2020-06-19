using Sirenix.OdinInspector;
using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class ReactorDispatcher : IReactor
	{
		[SerializeField, Required, SceneObjectsOnly] private Reactable _reactable = null;
		[SerializeField] private int _index = 0;

		public void HandleReaction() =>
			_reactable.Dispatch(_index);
	}
}
