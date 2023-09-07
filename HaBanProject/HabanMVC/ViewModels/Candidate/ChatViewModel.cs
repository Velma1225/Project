namespace HabanMVC.ViewModels.Candidate
{
    public class ChatViewModel
    {
        public List<ChatListViewModel> ChatList { get; set; }
        public List<CurrentChatViewModel> CurrentChat { get; set; }
        public string ActiveJobName { get; set; }
        public string ActiveCompany { get; set; }
    }

    public class ChatListViewModel
    {
        public string Pic { get; set; }
        public DateTime MessageTime { get; set; }
        public string SenderName { get; set; }
        public string JobName { get; set; }
        public string ChatContent { get; set; }

    }

    public class CurrentChatViewModel
    {
        public string Pic { get; set; }
        public string ChatContent { get; set; }
        public DateTime MessageTime { get; set; }

        public int readStatus { get; set; }

        public int SenderAccount { get; set; }


    }
}
