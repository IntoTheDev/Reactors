using DG.Tweening;
using Sirenix.OdinInspector;
using ToolBox.Extensions;
using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class TweenSwing : Tweener
	{
		[SerializeField, Required, SceneObjectsOnly] private Transform _transform = null;
		[SerializeField] private float _duration = 0.05f;
		[SerializeField] private float _swingValue = default;

		private Quaternion[] _angles = null;
		private int _index = 0;

		private const int ANGLES_COUNT = 2;

		protected override void Initialize()
		{
			_angles = new Quaternion[ANGLES_COUNT]
			{
				Quaternion.Euler(0f, 0f, -_swingValue),
				Quaternion.Euler(0f, 0f, _swingValue)
			};
		}

		protected override Tween RunTween()
		{
			Quaternion rotation = _angles[_index];
			_index = _index.RoundRobin(ANGLES_COUNT);
			return _transform.DOLocalRotateQuaternion(rotation, _duration);
		}
	}
}
