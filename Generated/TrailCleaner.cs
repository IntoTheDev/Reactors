using Sirenix.OdinInspector;
using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class TrailCleaner : IReactor
	{
		[SerializeField, Required, SceneObjectsOnly] private TrailRenderer _trailRenderer = null;

		public void HandleReaction() =>
			_trailRenderer.Clear();
	}
}
