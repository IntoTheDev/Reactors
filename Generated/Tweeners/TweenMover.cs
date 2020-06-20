using DG.Tweening;
using Sirenix.OdinInspector;
using ToolBox.Utilities;
using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class TweenMover : Tweener
	{
		[SerializeField, Required, SceneObjectsOnly] private Transform _transform = null;
		[SerializeReference, Required] private IPositionSelector _positionSelector = null;
		[SerializeField] private float _duration = 1f;

		protected override Tween RunTween() =>
			_transform.DOMove(_positionSelector.GetPosition(), _duration);
	}
}
