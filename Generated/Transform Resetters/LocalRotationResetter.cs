namespace ToolBox.Reactors
{
	public sealed class LocalRotationResetter : TransformResetter
	{
		protected override void Reset() =>
			_transform.localRotation = default;
	}
}
