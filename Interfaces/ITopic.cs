using quora.Entities;

namespace quora.topics
{
    public interface ITopic
    {
        public Task CreateQuestion(QuestionEntity question);
        public List<QuestionEntity> GetQuestion(int Id);
        public Task UpdateQuestion(QuestionEntity question);
        public Task DeleteQuestion(int Id);
        public Task  CreateAnswer(AnswerEntity answer);
        public List<AnswerEntity> GetAnswer(int Id);
        public Task UpdateAnswer(AnswerEntity answer);
        public Task  DeleteAnswer(int Id);
        public Task CreateTopic(TopicEntity topic);
        public Task UpdateTopic(TopicEntity topic);
        public List<TopicEntity> GetTopic();  
        public Task DeleteTopic(int Id);
        


    }
}
