using ToolBox.Serialization;

namespace ToolBox.Reactors
{
	public sealed class FileSaver : IReactor
	{
		public void HandleReaction() =>
			DataSerializer.SaveFile();
	}
}
