using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using quora.Service;
using quora.Entities;


namespace quora.Controllers
{
    [Route("api/Topic")]
    [ApiController]
    public class TopicController : ControllerBase
    {
        private readonly TopicService topicService;
        public TopicController() => topicService = new();

        /// <summary>
        /// returns the list of topics
        /// </summary>
        /// <returns></returns>
        [HttpGet("Topic")]
        public List<TopicEntity> GetTopic()
        {
            try
            {
                List<TopicEntity> topics = topicService.GetTopic();
                return topics;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        /// <summary>
        /// creates a new topic
        /// </summary>
        /// <param name="topic"></param>
        /// <returns></returns>
        [HttpPost("Topic")]
        public async Task CreateTopic(TopicEntity topic)
        {
            try
            {
                await topicService.CreateTopic(topic);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        /// <summary>
        /// updates the topic details
        /// </summary>
        /// <param name="topic"></param>
        /// <returns></returns>
        [HttpPut("Topic")]
        public async Task UpdateTopic(TopicEntity topic)
        {
            try
            {
                await topicService.UpdateTopic(topic);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        /// <summary>
        /// delete the topic
        /// </summary>
        /// <param name="topicId"></param>
        /// <returns></returns>
        [HttpDelete("Topic")]
        public async Task DeleteTopic(int topicId)
        {
            try
            {
                await topicService.DeleteTopic(topicId);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
        /// <summary>
        /// gets the question by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("Question")]
        public List<QuestionEntity> GetQuestions(int Id)
        {
            try
            {
                List<QuestionEntity> question = topicService.GetQuestion(Id);
                return question;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// creates the question
        /// </summary>
        /// <param name="question"></param>
        [HttpPost("Question")]
        public async Task CreateQuestion(QuestionEntity question) 
        {
            try
            {
                 await topicService.CreateQuestion(question);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        /// <summary>
        /// upadtes the question
        /// </summary>
        /// <param name="question"></param>
        [HttpPut("Question")]
        public async Task UpdateQuestion(QuestionEntity question)
        {
            try
            {
                await topicService.UpdateQuestion(question);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        /// <summary>
        /// deletes the question by id
        /// </summary>
        /// <param name="Id"></param>
        [HttpDelete("Question")]
        public async Task DeleteQuestion(int Id) 
        {
            try
            {
                await topicService.DeleteQuestion(Id);
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }

        /// <summary>
        /// gets the answer by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("Answer")]
        public List<AnswerEntity>GetAnswer(int Id)
        {
            try
            {
                List<AnswerEntity> answer = topicService.GetAnswer(Id);
                return answer;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// creates the answer
        /// </summary>
        /// <param name="answer"></param>
        [HttpPost("Answer")]
        public async Task AddAnswer(AnswerEntity answer)
        {
            try
            {
                await topicService.CreateAnswer(answer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

 
        /// <summary>
        /// updates the answer
        /// </summary>
        /// <param name="answer"></param>
        [HttpPut("Answer")]
        public async Task UpdateAnswer(AnswerEntity answer)
        {
            try
            {
                await topicService.UpdateAnswer(answer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       /// <summary>
       /// deltes the answer by id 
       /// </summary>
       /// <param name="Id"></param>
        [HttpDelete("Answer")]
        public async Task DeleteAnswer(int Id)
        {
            try
            {
                await topicService.DeleteAnswer(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
