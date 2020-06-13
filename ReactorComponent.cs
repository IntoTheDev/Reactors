using UnityEngine;

namespace ToolBox.Reactors
{
	public class ReactorComponent : MonoBehaviour, IReactor
	{
		[SerializeField] private Reactor[] reactors = null;

		public void Dispatch(int index) =>
			reactors[index].SendReaction();

		public void HandleReaction() =>
			reactors[0].SendReaction();
	}
}
