using ToolBox.Signals;
using UnityEngine;

namespace ToolBox.Reactors
{
	[System.Serializable]
	public sealed class Vector3Reactor : Reactor<Vector3, IVector3Reactor> { }

	public interface IVector3Reactor : IReactor<Vector3> { }

	public sealed class Vector3SignalDispatcher : SignalDispatcher<Vector3, Vector3Signal>, IVector3Reactor { }

	public sealed class Vector3MonoReactor : MonoReactor<Vector3, IVector3Reactor>, IVector3Reactor { }
}
