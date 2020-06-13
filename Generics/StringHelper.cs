using ToolBox.Signals;
using UnityEngine;

namespace ToolBox.Reactors
{
	[System.Serializable]
	public sealed class StringReactor : Reactor<string, IStringReactor> { }

	public interface IStringReactor : IReactor<string> { }

	public sealed class StringSignalDispatcher : SignalDispatcher<string, StringSignal>, IStringReactor { }

	public sealed class StringMonoReactor : MonoReactor<string, IStringReactor>, IStringReactor { }
}
