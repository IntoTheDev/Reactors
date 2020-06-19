namespace ToolBox.Reactors
{
	public sealed class LocalPositionResetter : TransformResetter
	{
		protected override void Reset() =>
			_transform.localPosition = default;
	}
}
