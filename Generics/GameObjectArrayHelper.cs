using ToolBox.Signals;
using UnityEngine;

namespace ToolBox.Reactors
{
	[System.Serializable]
	public sealed class GameObjectArrayReactor : Reactor<GameObject[], IGameObjectArrayReactor> { }

	public interface IGameObjectArrayReactor : IReactor<GameObject[]> { }

	public sealed class GameObjectArraySignalDispatcher : SignalDispatcher<GameObject[], GameObjectArraySignal>, IGameObjectArrayReactor { }

	public sealed class GameObjectArrayMonoReactor : MonoReactor<GameObject[], IGameObjectArrayReactor>, IGameObjectArrayReactor { }
}
