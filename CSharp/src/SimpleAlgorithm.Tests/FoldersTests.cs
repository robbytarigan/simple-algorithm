using Xunit;

namespace SimpleAlgorithm.Tests
{
    public class FoldersTests
    {
        [Fact]
        public void Should_return_correct_folder_names()
        {
            string xml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<folder name=\"c\">" +
                "<folder name=\"program files\">" +
                "<folder name=\"uninstall information\" />" +
                "</folder>" +
                "<folder name=\"users\" />" +
                "</folder>";

            var expectedFolders = new[]
            {
                "uninstall information", "users"
            };

            var resultFolders = Folders.FolderNames(xml, 'u');

            Assert.Equal(expectedFolders, resultFolders);
        }
    }
}
