using DG.Tweening;
using Sirenix.OdinInspector;
using ToolBox.Utilities;
using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class TweenMover : Tweener
	{
		[SerializeField, Required, SceneObjectsOnly, FoldoutGroup("Data")] private Transform _transform = null;
		[SerializeReference, Required, FoldoutGroup("Data")] private IPositionSelector _positionSelector = null;
		[SerializeField, FoldoutGroup("Data")] private float _duration = 1f;

		protected override Tween RunTween() =>
			_transform.DOMove(_positionSelector.GetPosition(), _duration);
	}
}
