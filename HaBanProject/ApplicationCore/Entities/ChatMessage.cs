using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities;

public partial class ChatMessage
{
    public int MessageId { get; set; }

    public DateTime CreateAt { get; set; }

    public string MessageContent { get; set; }

    public bool SenderAccount { get; set; }

    public bool ReadStatus { get; set; }

    public int CandidateId { get; set; }

    public int CompanyId { get; set; }

    public int JobDescriptionId { get; set; }

    public virtual Candidate Candidate { get; set; }

    public virtual Company Company { get; set; }
}
