using ToolBox.Signals;
using UnityEngine;

namespace ToolBox.Reactors
{
	[System.Serializable]
	public sealed class Vector2Reactor : Reactor<Vector2, IVector2Reactor> { }

	public interface IVector2Reactor : IReactor<Vector2> { }

	public sealed class Vector2SignalDispatcher : SignalDispatcher<Vector2, Vector2Signal>, IVector2Reactor { }

	public sealed class Vector2MonoReactor : MonoReactor<Vector2, IVector2Reactor>, IVector2Reactor { }
}
