namespace quora.Entities
{
    public class QuestionEntity
    {
        private int Id;
        private int TopicId;
        private List<AnswerEntity>? Answers;
        private string Description;
        private string CreatedBy;
        private DateTime CreatedDateTime;
        private string ModifiedBy;
        private DateTime ModifiedDateTime;

        public int QId
        {
            get { return Id; }
            set { Id = value; }
        }

        public int QTopicId
        {
            get { return TopicId; }
            set { TopicId = value; }
        }
        public string QDescription
        {
            get { return Description; }
            set
            {
                Description = value;
            }
        }
        public string QCreatedBy
        {
            get { return CreatedBy; }
            set
            {
                CreatedBy = value;
            }
        }
        public DateTime QCreatedDateTime
        {
            get { return CreatedDateTime; }
            set
            {
                CreatedDateTime = value;
            }
        }
        public string QModifiedBy
        {
            get { return ModifiedBy; }
            set { ModifiedBy = value; }
        }
        public DateTime QModifiedDateTime
        {
            get { return ModifiedDateTime; }
            set
            {
                ModifiedDateTime = value;
            }
        }

        public List<AnswerEntity>? QAnswers
        {
            get { return Answers; }
        }

    }
}
