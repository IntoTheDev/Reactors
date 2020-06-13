using ToolBox.Signals;
using UnityEngine;

namespace ToolBox.Reactors
{
	[System.Serializable]
	public sealed class TransformReactor : Reactor<Transform, ITransformReactor> { }

	public interface ITransformReactor : IReactor<Transform> { }

	public sealed class TransformSignalDispatcher : SignalDispatcher<Transform, TransformSignal>, ITransformReactor { }

	public sealed class TransformMonoReactor : MonoReactor<Transform, ITransformReactor>, ITransformReactor { }
}
