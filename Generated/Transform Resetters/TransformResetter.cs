using Sirenix.OdinInspector;
using UnityEngine;

namespace ToolBox.Reactors
{
	public abstract class TransformResetter : IReactor
	{
		[SerializeField, Required, SceneObjectsOnly] protected Transform _transform = null;

		public void HandleReaction() =>
			Reset();

		protected abstract void Reset();
	}
}
