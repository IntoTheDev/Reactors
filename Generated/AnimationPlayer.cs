using Sirenix.OdinInspector;
using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class AnimationPlayer : IReactor, ISetupable
	{
		[SerializeField, Required, AssetSelector] private AnimationClip _animationClip = null;
		[SerializeField, Required, SceneObjectsOnly] private Animator _animator = null;

		private int _hash = 0;

		public void Setup() =>
			_hash = Animator.StringToHash(_animationClip.name);

		public void HandleReaction() =>
			_animator.Play(_hash);
	}
}
