using Sirenix.OdinInspector;
using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class ObjectDestroyer : IReactor, IGameObjectReactor
	{
		[SerializeField, Required, SceneObjectsOnly] private GameObject objectToDestroy = null;

		public void HandleReaction() =>
			Object.Destroy(objectToDestroy);

		public void HandleReaction(GameObject value) =>
			Object.Destroy(value);
	}
}
