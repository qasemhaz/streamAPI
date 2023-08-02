using Stream.Core.Data;
using Stream.Core.Repository;
using Stream.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Infra.Service
{
    public class ReviewService : IReviewService
    {
        private readonly IStreamReview streamReview;
        public ReviewService(IStreamReview streamReview)
        {
            this.streamReview = streamReview;
        }

        public void Create(Streamreview stream)
        {
            streamReview.Create(stream);
        }

        public void Delete(int id)
        {
            streamReview.Delete(id);
        }

        public List<Streamreview> GetAll()
        {
            return streamReview.GetAll();
        }

        public Streamreview GetById(int id)
        {
            return streamReview.GetById(id);
        }

        public void Update(Streamreview stream)
        {
            streamReview.Update(stream);
        }
    }
}
