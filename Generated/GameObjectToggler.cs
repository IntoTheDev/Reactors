using Sirenix.OdinInspector;
using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class GameObjectToggler : IReactor, IGameObjectReactor
	{
		[SerializeField, SceneObjectsOnly] private GameObject _objectToToggle = null;
		[SerializeField] private bool _active = false;

		public void HandleReaction() =>
			_objectToToggle.SetActive(_active);

		public void HandleReaction(GameObject value) =>
			value.SetActive(_active);
	}
}
