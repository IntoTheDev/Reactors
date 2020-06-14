using UnityEngine;

namespace ToolBox.Reactors
{
	public class ReactorComponent : MonoBehaviour, IReactor
	{
		[SerializeField] private Reactor[] _reactors = null;

		public void Dispatch(int index) =>
			_reactors[index].SendReaction();

		public void HandleReaction() =>
			_reactors[0].SendReaction();
	}
}
