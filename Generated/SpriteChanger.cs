using Sirenix.OdinInspector;
using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class SpriteChanger : IReactor
	{
		[SerializeField, Required, SceneObjectsOnly] private SpriteRenderer _spriteRenderer = null;
		[SerializeField, Required, AssetSelector] private Sprite _sprite = null;

		public void HandleReaction() =>
			_spriteRenderer.sprite = _sprite;
	}
}
