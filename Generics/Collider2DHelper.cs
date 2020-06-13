using ToolBox.Signals;
using UnityEngine;

namespace ToolBox.Reactors
{
	[System.Serializable]
	public sealed class Collider2DReactor : Reactor<Collider2D, ICollider2DReactor> { }

	public interface ICollider2DReactor : IReactor<Collider2D> { }

	public sealed class Collider2DSignalDispatcher : SignalDispatcher<Collider2D, Collider2DSignal>, ICollider2DReactor { }

	public sealed class Collider2DMonoReactor : MonoReactor<Collider2D, ICollider2DReactor>, ICollider2DReactor { }
}
