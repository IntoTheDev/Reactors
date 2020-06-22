using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;

namespace ToolBox.Reactors
{
	public abstract class Tweener : IReactor, ISetupable
	{
		[SerializeField, FoldoutGroup("Main")] private Ease _ease = default;
		[SerializeField, FoldoutGroup("Main")] private bool _interruptable = false;
		[SerializeField, FoldoutGroup("Main")] private int _loops = 0;
		[SerializeField, FoldoutGroup("Main"), ShowIf("@this._loops != 0")] private LoopType _loopType = default;
		[ShowInInspector, ReadOnly, FoldoutGroup("Main")] private bool _running = false;
		
		[SerializeField, FoldoutGroup("Reactor")] private Reactor _onComplete = null;
		
		private Tween _tween = null;

		public void Setup() =>
			_onComplete.Setup();

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

		protected virtual void OnComplete()
		{
			_onComplete.SendReaction();
			_running = false;
		}
	}
}
