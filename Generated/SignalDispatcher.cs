using Sirenix.OdinInspector;
using ToolBox.Signals;
using UnityEngine;

namespace ToolBox.Reactors
{
	public class SignalDispatcher : IReactor
	{
		[SerializeField, Required] private Signal _signal = null;

		public void HandleReaction() =>
			_signal.Dispatch();
	}

	public class SignalDispatcher<T, S> : IReactor, IReactor<T> where S : GenericSignal<T>
	{
		[SerializeField, Required] private S _signal = null;
		[SerializeField] private T _value = default;

		public void HandleReaction() =>
			_signal.Dispatch(_value);

		public void HandleReaction(T value) =>
			_signal.Dispatch(value);
	}
}
