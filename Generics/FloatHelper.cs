using ToolBox.Signals;
using UnityEngine;

namespace ToolBox.Reactors
{
	[System.Serializable]
	public sealed class FloatReactor : Reactor<float, IFloatReactor> { }

	public interface IFloatReactor : IReactor<float> { }

	public sealed class FloatSignalDispatcher : SignalDispatcher<float, FloatSignal>, IFloatReactor { }

	public sealed class FloatMonoReactor : MonoReactor<float, IFloatReactor>, IFloatReactor { }
}
