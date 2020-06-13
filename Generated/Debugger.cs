using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class Debugger : IReactor
	{
		[SerializeField] private string message = "Message!";

		public void HandleReaction() =>
			Debug.Log(message);
	}
}
