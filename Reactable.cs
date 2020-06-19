using UnityEngine;

namespace ToolBox.Reactors
{
	public class Reactable : MonoBehaviour, IReactor
	{
		[SerializeField] private Reactor[] _reactors = null;

		private void Awake()
		{
			for (int i = 0; i < _reactors.Length; i++)
				_reactors[i].Setup();
		}

		public void Dispatch(int index) =>
			_reactors[index].SendReaction();

		public void HandleReaction() =>
			_reactors[0].SendReaction();
	}
}
