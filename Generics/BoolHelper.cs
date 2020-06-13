using ToolBox.Signals;
using UnityEngine;

namespace ToolBox.Reactors
{
	[System.Serializable]
	public sealed class BoolReactor : Reactor<bool, IBoolReactor> { }

	public interface IBoolReactor : IReactor<bool> { }

	public sealed class BoolSignalDispatcher : SignalDispatcher<bool, BoolSignal>, IBoolReactor { }

	public sealed class BoolMonoReactor : MonoReactor<bool, IBoolReactor>, IBoolReactor { }
}
