using Sirenix.OdinInspector;
using ToolBox.Serialization;
using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class StateSaver : IReactor
	{
		[SerializeField, Required, SceneObjectsOnly] private StateSerializer _stateSerializer = null;

		public void HandleReaction() =>
			_stateSerializer.Save();
	}
}
