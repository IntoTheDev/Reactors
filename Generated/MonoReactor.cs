using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

namespace ToolBox.Reactors
{
	public class MonoReactor : IReactor
	{
		[SerializeField, Required, OnValueChanged(nameof(OnMonoReactorSelected))] private MonoBehaviour potentialReactor = null;
		[SerializeField] private Transform root = null;
		[ShowInInspector, ValueDropdown(nameof(GetMonoReactors)), ShowIf(nameof(root)), OnValueChanged(nameof(OnReactorSelected))] private IReactor reactor = null;

		public void HandleReaction()
		{
			IReactor reactor = potentialReactor as IReactor;
			reactor.HandleReaction();
		}

		private void OnMonoReactorSelected()
		{
			bool isReactor = potentialReactor is IReactor;

			if (!isReactor)
				potentialReactor = null;
		}

		private IEnumerable<IReactor> GetMonoReactors()
		{
			if (root == null)
				return null;

			return root.GetComponentsInChildren<IReactor>();
		}

		private void OnReactorSelected()
		{
			if (reactor != null)
				potentialReactor = reactor as MonoBehaviour;
		}
	}

	public class MonoReactor<T, R> : IReactor<T> where R : IReactor<T>
	{
		[SerializeField, Required, OnValueChanged(nameof(OnMonoReactorSelected))] private MonoBehaviour potentialReactor = null;
		[SerializeField] private Transform root = null;
		[ShowInInspector, ValueDropdown(nameof(GetMonoReactors)), ShowIf(nameof(root)), OnValueChanged(nameof(OnReactorSelected))] private R reactor = default;

		public void HandleReaction(T value)
		{
			IReactor<T> reactor = potentialReactor as IReactor<T>;
			reactor.HandleReaction(value);
		}

		private void OnMonoReactorSelected()
		{
			bool isReactor = potentialReactor is R;

			if (!isReactor)
				potentialReactor = null;
		}

		private IEnumerable<R> GetMonoReactors()
		{
			if (root == null)
				return null;

			return root.GetComponentsInChildren<R>();
		}

		private void OnReactorSelected()
		{
			if (reactor != null)
				potentialReactor = reactor as MonoBehaviour;
		}
	}
}
