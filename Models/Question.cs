using System;
using System.Collections.Generic;

namespace quora.Models;

public partial class Question
{
    public int Id { get; set; }

    public int? TopicId { get; set; }

    public string? Description { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDateTime { get; set; }

    public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();

    public virtual Topic? Topic { get; set; }
}
