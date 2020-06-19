namespace ToolBox.Reactors
{
	public sealed class PositionResetter : TransformResetter
	{
		protected override void Reset() =>
			_transform.position = default;
	}
}
