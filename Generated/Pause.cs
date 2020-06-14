using Sirenix.OdinInspector;
using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class Pause : IReactor
	{
		[ShowInInspector, ReadOnly] public static bool IsPaused { get; private set; } = false;

		public void HandleReaction()
		{
			IsPaused = !IsPaused;
			Time.timeScale = IsPaused ? 0f : 1f;
		}
	}
}
