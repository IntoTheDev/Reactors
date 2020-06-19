using ToolBox.Pools;
using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class ObjectCreator : IReactor, ISetupable
	{
		[SerializeField] private Pool _pool = null;
		[SerializeField] private Transform _spawnPivot = null;

		public void Setup() =>
			_pool.Fill();

		public void HandleReaction() =>
			_pool.GetEntity(_spawnPivot.position, _spawnPivot.rotation);
	}
}
