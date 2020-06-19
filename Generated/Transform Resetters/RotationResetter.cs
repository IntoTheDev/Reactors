namespace ToolBox.Reactors
{
	public sealed class RotationResetter : TransformResetter
	{
		protected override void Reset() =>
			_transform.rotation = default;
	}
}
