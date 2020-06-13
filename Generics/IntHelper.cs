using ToolBox.Signals;
using UnityEngine;

namespace ToolBox.Reactors
{
	[System.Serializable]
	public sealed class IntReactor : Reactor<int, IIntReactor> { }

	public interface IIntReactor : IReactor<int> { }

	public sealed class IntSignalDispatcher : SignalDispatcher<int, IntSignal>, IIntReactor { }

	public sealed class IntMonoReactor : MonoReactor<int, IIntReactor>, IIntReactor { }
}
