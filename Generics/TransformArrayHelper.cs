using ToolBox.Signals;
using UnityEngine;

namespace ToolBox.Reactors
{
	[System.Serializable]
	public sealed class TransformArrayReactor : Reactor<Transform[], ITransformArrayReactor> { }

	public interface ITransformArrayReactor : IReactor<Transform[]> { }

	public sealed class TransformArraySignalDispatcher : SignalDispatcher<Transform[], TransformArraySignal>, ITransformArrayReactor { }

	public sealed class TransformArrayMonoReactor : MonoReactor<Transform[], ITransformArrayReactor>, ITransformArrayReactor { }
}
