using System;
using System.Collections.Generic;

namespace quora.Models;

public partial class Topic
{
    public int TopicId { get; set; }

    public string? TopicName { get; set; }

    public string? TopicDescription { get; set; }

    public string? TopicCreatedBy { get; set; }

    public DateTime? TopicCreatedDateTime { get; set; }

    public string? TopicModifiedBy { get; set; }

    public DateTime? TopicModifiedDateTime { get; set; }

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
}
