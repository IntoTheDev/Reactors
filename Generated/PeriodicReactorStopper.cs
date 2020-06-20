using Sirenix.OdinInspector;
using ToolBox.Utilities;
using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class PeriodicReactorStopper : IReactor
	{
		[SerializeField, Required, SceneObjectsOnly] private PeriodicReactor _periodicReactor = null;

		public void HandleReaction() =>
			_periodicReactor.Stop();
	}
}
