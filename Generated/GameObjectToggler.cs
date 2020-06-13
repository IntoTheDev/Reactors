using Sirenix.OdinInspector;
using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class GameObjectToggler : IReactor, IGameObjectReactor
	{
		[SerializeField, SceneObjectsOnly] private GameObject objectToToggle = null;
		[SerializeField] private bool active = false;

		public void HandleReaction() =>
			objectToToggle.SetActive(active);

		public void HandleReaction(GameObject value) =>
			value.SetActive(active);
	}
}
