using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class Debugger : IReactor
	{
		[SerializeField] private string _message = "Message!";

		public void HandleReaction() =>
			Debug.Log(_message);
	}
}
