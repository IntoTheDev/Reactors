using ToolBox.Signals;
using UnityEngine;

namespace ToolBox.Reactors
{
	[System.Serializable]
	public sealed class GameObjectReactor : Reactor<GameObject, IGameObjectReactor> { }

	public interface IGameObjectReactor : IReactor<GameObject> { }

	public sealed class GameObjectSignalDispatcher : SignalDispatcher<GameObject, GameObjectSignal>, IGameObjectReactor { }

	public sealed class GameObjectMonoReactor : MonoReactor<GameObject, IGameObjectReactor>, IGameObjectReactor { }
}
