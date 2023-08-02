using Stream.Core.Data;
using Stream.Core.Repository;
using Stream.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Infra.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly IStreamCategory streamCategory;
        public CategoryService(IStreamCategory streamCategory)
        {
            this.streamCategory = streamCategory;
        }

        public void Create(Streamcategory stream)
        {
            streamCategory.Create(stream);
        }

        public void Delete(int id)
        {
            streamCategory.Delete(id);
        }

        public List<Streamcategory> GetAll()
        {
            return streamCategory.GetAll();
        }

        public Streamcategory GetById(int id)
        {
            return streamCategory.GetById(id);
        }

        public void Update(Streamcategory stream)
        {
            streamCategory.Update(stream);
        }
    }
}
