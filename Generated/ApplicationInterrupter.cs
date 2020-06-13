using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class ApplicationInterrupter : IReactor
	{
		public void HandleReaction() =>
			Application.Quit();
	}
}
