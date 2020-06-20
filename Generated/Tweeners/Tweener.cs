using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;

namespace ToolBox.Reactors
{
	public abstract class Tweener : IReactor
	{
		[SerializeField, FoldoutGroup("Main")] protected Ease _ease = default;
		[SerializeField, FoldoutGroup("Main")] private bool _interruptable = false;
		[SerializeField, FoldoutGroup("Main")] private int _loops = 0;
		[SerializeField, FoldoutGroup("Main")] private LoopType _loopType = default;
		[ShowInInspector, ReadOnly, FoldoutGroup("Main")] protected bool _running = false;

		private Tween _tween = null;

		public void HandleReaction()
		{
			if (_running)
			{
				if (_interruptable)
					_tween.Kill();
				else
					return;
			}

			_tween = RunTween();
			_tween.SetEase(_ease);
			_tween.SetLoops(_loops, _loopType);
			_tween.OnComplete(OnComplete);

			_running = true;
		}

		protected abstract Tween RunTween();

		protected virtual void OnComplete() =>
			_running = false;
	}
}
