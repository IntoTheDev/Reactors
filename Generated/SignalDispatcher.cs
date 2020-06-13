using Sirenix.OdinInspector;
using ToolBox.Signals;
using UnityEngine;

namespace ToolBox.Reactors
{
	public class SignalDispatcher : IReactor
	{
		[SerializeField, Required] private Signal signal = null;

		public void HandleReaction() =>
			signal.Dispatch();
	}

	public class SignalDispatcher<T, S> : IReactor, IReactor<T> where S : GenericSignal<T>
	{
		[SerializeField, Required] private S signal = null;
		[SerializeField] private T value = default;

		public void HandleReaction() =>
			signal.Dispatch(value);

		public void HandleReaction(T value) =>
			signal.Dispatch(value);
	}
}
