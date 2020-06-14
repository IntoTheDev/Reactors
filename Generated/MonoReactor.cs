using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

namespace ToolBox.Reactors
{
	public class MonoReactor : IReactor
	{
		[SerializeField, Required, OnValueChanged(nameof(OnMonoReactorSelected))] private MonoBehaviour _potentialReactor = null;
		[SerializeField] private Transform _root = null;
		[ShowInInspector, ValueDropdown(nameof(GetMonoReactors)), ShowIf(nameof(_root)), OnValueChanged(nameof(OnReactorSelected))] private IReactor _selfReactors = null;

		public void HandleReaction()
		{
			IReactor reactor = _potentialReactor as IReactor;
			reactor.HandleReaction();
		}

		private void OnMonoReactorSelected()
		{
			bool isReactor = _potentialReactor is IReactor;

			if (!isReactor)
				_potentialReactor = null;
		}

		private IEnumerable<IReactor> GetMonoReactors()
		{
			if (_root == null)
				return null;

			return _root.GetComponentsInChildren<IReactor>();
		}

		private void OnReactorSelected()
		{
			if (_selfReactors != null)
				_potentialReactor = _selfReactors as MonoBehaviour;
		}
	}

	public class MonoReactor<T, R> : IReactor<T> where R : IReactor<T>
	{
		[SerializeField, Required, OnValueChanged(nameof(OnMonoReactorSelected))] private MonoBehaviour _potentialReactor = null;
		[SerializeField] private Transform _root = null;
		[ShowInInspector, ValueDropdown(nameof(GetMonoReactors)), ShowIf(nameof(_root)), OnValueChanged(nameof(OnReactorSelected))] private R _reactor = default;

		public void HandleReaction(T value)
		{
			IReactor<T> reactor = _potentialReactor as IReactor<T>;
			reactor.HandleReaction(value);
		}

		private void OnMonoReactorSelected()
		{
			bool isReactor = _potentialReactor is R;

			if (!isReactor)
				_potentialReactor = null;
		}

		private IEnumerable<R> GetMonoReactors()
		{
			if (_root == null)
				return null;

			return _root.GetComponentsInChildren<R>();
		}

		private void OnReactorSelected()
		{
			if (_reactor != null)
				_potentialReactor = _reactor as MonoBehaviour;
		}
	}
}
