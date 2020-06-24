using Sirenix.OdinInspector;
using ToolBox.Utilities;
using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class ReactorProcessor : IReactor
	{
		[SerializeField, Required, SceneObjectsOnly] private Reactable _reactable = null;
		[SerializeField] private int _index = 0;

		public void HandleReaction() =>
			_reactable.Process(_index);
	}
}
