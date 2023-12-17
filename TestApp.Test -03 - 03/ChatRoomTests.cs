using TestApp___03___03;

namespace TestApp.Test__03___03
{
    [TestFixture]
    public class ChatRoomTests
    {
        private ChatRoom _chatRoom = null!;

        [SetUp]
        public void Setup()
        {
            this._chatRoom = new();
        }

        [Test]
        public void Test_SendMessage_MessageSentToChatRoom()
        {
            // Arrange 
            string sender = "'Veselina";
            string message = "Hi";

            //Act
            this._chatRoom.SendMessage(sender, message);
            string result = this._chatRoom.DisplayChat();

            //Assert
            Assert.That(result, Does.Contain("Veselina: Hi - Sent at "));
        }

        [Test]
        public void Test_DisplayChat_NoMessages_ReturnsEmptyString()
        {
            // Arrange 

            //Act
            string result = this._chatRoom.DisplayChat();

            //Assert
            Assert.That(result, Is.EqualTo(string.Empty));
        }

        [Test]
        public void Test_DisplayChat_WithMessages_ReturnsFormattedChat()
        {
            // Arrange 
            string sender = "'Veselina";
            string message = "Hi";

            string sender2 = "Nikolas";
            string message2 = "Hi";

            //Act
            this._chatRoom.SendMessage(sender, message);
            this._chatRoom.SendMessage(sender2, message2);
            string result = this._chatRoom.DisplayChat();

            //Assert
            Assert.That(result, Does.Contain("Chat Room Messages:"));
            Assert.That(result, Does.Contain("Veselina: Hi - Sent at "));
            Assert.That(result, Does.Contain("Nikolas: Hi - Sent at "));
        }
    }

}