using Sirenix.OdinInspector;
using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class RendererToggler : IReactor
	{
		[SerializeField, Required, SceneObjectsOnly] private Renderer _renderer = null;
		[SerializeField] private bool _active = false;

		public void HandleReaction() =>
			_renderer.enabled = _active;
	}
}
