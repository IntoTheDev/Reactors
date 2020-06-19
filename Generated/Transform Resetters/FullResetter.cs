using UnityEngine;

namespace ToolBox.Reactors
{
	public sealed class FullResetter : TransformResetter, ISetupable
	{
		private Vector3 defaultScale = default;

		public void Setup() =>
			defaultScale = new Vector3(1f, 1f, 1f);

		protected override void Reset()
		{
			_transform.position = default;
			_transform.rotation = default;
			_transform.localScale = defaultScale;
		}
	}
}
