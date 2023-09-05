namespace quora.Entities
{
    public class TopicEntity
    {
        private int Id;
        private string Name;
        private string Description;
        private List<QuestionEntity>? Questions;
        private string CreatedBy;
        private DateTime CreatedDateTime;
        private string ModifiedBy;
        private DateTime ModifiedDateTime;

        public int TId
        {
            get { return Id; }
            set { Id = value; }
        }
        public string TName
        {
            get { return Name; }
            set { Name = value; }
        }
        public string TDescription
        {
            get { return Description; }
            set
            {
                Description = value;
            }
        }
        public List<QuestionEntity>? TQuestions
        { 
            get { return Questions; } 
        }
        public string TCreatedBy
        {
            get { return CreatedBy; }
            set
            {
                CreatedBy = value;
            }
        }
        public DateTime TCreatedDateTime
        {
            get { return CreatedDateTime; }
            set
            {
                CreatedDateTime = value;
            }
        }
        public string TModifiedBy
        {
            get { return ModifiedBy; }
            set { ModifiedBy = value; }
        }
        public DateTime TModifiedDateTime
        {
            get { return ModifiedDateTime; }
            set
            {
                ModifiedDateTime = value;
            }
        }
    }
}
