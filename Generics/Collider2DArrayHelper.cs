using ToolBox.Signals;
using UnityEngine;

namespace ToolBox.Reactors
{
	[System.Serializable]
	public sealed class Collider2DArrayReactor : Reactor<Collider2D[], ICollider2DArrayReactor> { }

	public interface ICollider2DArrayReactor : IReactor<Collider2D[]> { }

	public sealed class Collider2DArraySignalDispatcher : SignalDispatcher<Collider2D[], Collider2DArraySignal>, ICollider2DArrayReactor { }

	public sealed class Collider2DArrayMonoReactor : MonoReactor<Collider2D[], ICollider2DArrayReactor>, ICollider2DArrayReactor { }
}
