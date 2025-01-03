namespace DungeonMasterApp.Pages.Story
{
    public partial class StoryPage
    {
        private string story = string.Empty;

        private async Task GenerateStory()
        {
            story = await StoryService.GetStory();
        }
    }
}
