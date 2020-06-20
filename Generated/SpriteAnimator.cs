using MEC;
using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class SpriteAnimator : IReactor, ISetupable
	{
		[SerializeField, Required, FoldoutGroup("Animation")] private SpriteAnimation _spriteAnimation = null;
		[SerializeField, FoldoutGroup("Animation")] private float timeBetweenFrames = 0.2f;
		[SerializeField, FoldoutGroup("Animation")] private bool _interruptable = false;
		[SerializeField, FoldoutGroup("Animation")] private bool _looped = false;

		[SerializeField, Required, SceneObjectsOnly, FoldoutGroup("Components")] SpriteRenderer _spriteRenderer = null;
		[SerializeField, Required, SceneObjectsOnly, FoldoutGroup("Components")] private GameObject _root = null;

		[SerializeField, FoldoutGroup("Reactor")] private Reactor _onAnimationEnd = null;

		[ShowInInspector, ReadOnly, FoldoutGroup("Debug")] private bool _playing = false;
		[ShowInInspector, ReadOnly, FoldoutGroup("Debug")] private int _currentIndex = 0;

		private Sprite[] _sprites = null;
		private CoroutineHandle _animationCoroutine = default;

		public void Setup()
		{
			_spriteAnimation.LoadSprites(ref _sprites);
			_onAnimationEnd.Setup();
		}

		public void HandleReaction()
		{
			if (_playing)
			{
				if (_interruptable)
				{
					Timing.KillCoroutines(_animationCoroutine);
					_currentIndex = 0;
				}
				else
				{
					return;
				}
			}

			_playing = true;
			_animationCoroutine = Timing.RunCoroutine(PlayAnimation().CancelWith(_root));
		}

		private IEnumerator<float> PlayAnimation()
		{
			while (true)
			{
				_spriteRenderer.sprite = _sprites[_currentIndex];
				_currentIndex++;

				yield return Timing.WaitForSeconds(timeBetweenFrames);

				if (_currentIndex == _sprites.Length)
				{
					_onAnimationEnd.SendReaction();

					if (_looped)
					{
						_currentIndex = 0;
					}
					else
					{
						_playing = false;
						_currentIndex = 0;

						break;
					}
				}
			}
		}
	}
}
