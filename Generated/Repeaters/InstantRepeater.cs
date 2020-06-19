namespace ToolBox.Reactors
{
	public sealed class InstantRepeater : Repeater
	{
		protected override void Repeat()
		{
			for (int i = 0; i < _count; i++)
				_reactor.SendReaction();
		}
	}
}
